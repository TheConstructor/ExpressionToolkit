using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ExpressionToolkit
{
    public class ExpressionReplacingVisitor : DynamicExpressionVisitor
    {
        private readonly IReadOnlyDictionary<Expression, Expression> _replacements;

        public ExpressionReplacingVisitor(IReadOnlyDictionary<Expression, Expression> replacements)
        {
            _replacements = replacements;
        }

        public override Expression Visit(Expression node)
        {
            if (node != null && _replacements.TryGetValue(node, out var replacement))
            {
                return replacement;
            }

            return base.Visit(node);
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            switch (node.Expression)
            {
                case LambdaExpression le:
                    return Visit(ParameterBinder.BindParametersAndReturnBody(le, node.Arguments))!;
                case MethodCallExpression mce
                    when typeof(LambdaExpression).IsAssignableFrom(mce.Method.DeclaringType)
                         && mce.Method.Name == nameof(LambdaExpression.Compile)
                         && mce.Object.TryResolveAs<LambdaExpression>(out var lambdaExpression):
                    return Visit(ParameterBinder.BindParametersAndReturnBody(lambdaExpression, node.Arguments))!;
            }

            return base.VisitInvocation(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var calledMethod = node.Method;
            var replaceWith = calledMethod.GetCustomAttributes<ReplaceWith>(false)
                .FirstOrDefault();
            if (replaceWith != null)
            {
                var instance = new Lazy<(bool found, object value)>(() => (node.Object.TryResolveValue(out var value), value));
                var type = replaceWith.Container ?? calledMethod.DeclaringType;

                var methods = type.GetMethods(calledMethod.IsStatic
                        ? BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static
                        : BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
                    .Where(m => m.Name == replaceWith.MemberName
                                && m.GetParameters().Length == node.Arguments.Count
                                && (!m.ContainsGenericParameters
                                    || m.GetGenericArguments().Length == calledMethod.GetGenericArguments().Length))
                    .Select(m => m.ContainsGenericParameters
                        ? m.MakeGenericMethod(calledMethod.GetGenericArguments())
                        : m)
                    .Where(m => m.GetParameters()
                                    .Zip(node.Arguments, (p, a) => (p, a))
                                    .All(t => t.p.ParameterType.IsInstanceOfType(t.a)
                                              || t.p.ParameterType.IsAssignableFrom(t.a.Type))
                                && typeof(Expression).IsAssignableFrom(m.ReturnType));

                var nodeArguments = node.Arguments.Select(InputOrReplacement).ToArray();

                foreach (var method in methods)
                {
                    var parameters = method.GetParameters();
                    var arguments = new object[parameters.Length];
                    for (var i = 0; i < parameters.Length; i++)
                    {
                        if (parameters[i].ParameterType.IsInstanceOfType(nodeArguments[i]))
                        {
                            arguments[i] = nodeArguments[i];
                        }
                        else if (parameters[i].ParameterType.IsAssignableFrom(nodeArguments[i].Type)
                                 && nodeArguments[i].TryResolveValue(out var argument))
                        {
                            arguments[i] = argument;
                        }
                        else
                        {
                            goto nextMethod;
                        }
                    }

                    object target;
                    if (method.IsStatic)
                    {
                        target = null;
                    }
                    else if (instance.Value is {found: true} instanceValue)
                    {
                        target = instanceValue;
                    }
                    else
                    {
                        continue;
                    }
                    var newExpression = (Expression) method.Invoke(target, arguments);
                    return ReferenceEquals(node, newExpression) ? node : Visit(newExpression)!;
                    nextMethod: ;
                }
            }

            return base.VisitMethodCall(node);
        }

        private Expression InputOrReplacement(Expression input)
        {
            return _replacements.TryGetValue(input, out var replacement) ? replacement : input;
        }
    }
}