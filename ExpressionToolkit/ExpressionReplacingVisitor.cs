using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
            if (_replacements.TryGetValue(node, out var replacement))
            {
                return replacement;
            }
            return base.Visit(node);
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            if (node.Expression is MethodCallExpression mce
                && typeof(LambdaExpression).IsAssignableFrom(mce.Method.DeclaringType)
                && mce.Method.Name == nameof(LambdaExpression.Compile)
                && mce.Object.TryResolveValue(out var value) 
                && value is LambdaExpression lambdaExpression)
            {
                return ParameterBinder.BindParametersAndReturnBody(lambdaExpression, node.Arguments);
            }
            return base.VisitInvocation(node);
        }
    }
}