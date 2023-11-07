using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
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
                var instance = new Lazy<(bool found, object? value)>(
                    () => node.Object == null
                        ? (false, null)
                        : (node.Object.TryResolveValue(out var value), value));
                var type = replaceWith.Container ?? calledMethod.DeclaringType;

                var calledMethodIsStatic = calledMethod.IsStatic;
                var minArgumentsCount = node.Arguments.Count;
                var maxArgumentsCount = calledMethodIsStatic
                    ? minArgumentsCount
                    : minArgumentsCount + 1; // +1 for non-static -> static

                var nodeArguments = node.Arguments.Select(InputOrReplacement).ToArray();

                foreach (var m in type.GetMethods(calledMethodIsStatic
                             ? BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static
                             : BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
                {
                    if(!(m.Name == replaceWith.MemberName
                         && m.GetParameters().Length >= minArgumentsCount
                         && m.GetParameters().Length <= maxArgumentsCount
                         && (!m.ContainsGenericParameters
                             || m.GetGenericArguments().Length == calledMethod.GetGenericArguments().Length)))
                        continue;

                    var method = m.ContainsGenericParameters
                        ? m.MakeGenericMethod(calledMethod.GetGenericArguments())
                        : m;

                    var rawArgs = method.GetParameters().Length == node.Arguments.Count
                        ? (IReadOnlyList<Expression>) nodeArguments
                        : nodeArguments.Prepend(node.Object).ToList();
                    if(!(method.GetParameters()
                             .Zip(rawArgs,
                                 (p, a) => (p, a))
                             .All(t => t.p.ParameterType.IsInstanceOfType(t.a)
                                       || t.p.ParameterType.IsAssignableFrom(t.a.Type))
                         && typeof(Expression).IsAssignableFrom(method.ReturnType)))
                        continue;
                    
                    var parameters = method.GetParameters();
                    var arguments = new object[parameters.Length];
                    for (var i = 0; i < parameters.Length; i++)
                    {
                        if (parameters[i].ParameterType.IsInstanceOfType(rawArgs[i]))
                        {
                            arguments[i] = rawArgs[i];
                        }
                        else if (parameters[i].ParameterType.IsAssignableFrom(rawArgs[i].Type)
                                 && rawArgs[i].TryResolveValue(out var argument))
                        {
                            arguments[i] = argument;
                        }
                        else
                        {
                            goto nextMethod;
                        }
                    }

                    object? target;
                    if (method.IsStatic)
                    {
                        target = null;
                    }
                    else if (instance.Value is {found: true} instanceValue )
                    {
                        target = instanceValue.value;
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