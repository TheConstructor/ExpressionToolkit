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
    }
}