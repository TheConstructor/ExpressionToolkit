using System;
using System.Linq.Expressions;

namespace ExpressionToolkit
{
    public static class ExpressionUtil
    {
        public static Expression BodyOf(this Expression<Action> expression)
        {
            return expression.Body;
        }

        public static Expression BodyOf<T>(this Expression<Func<T>> expression)
        {
            return expression.Body;
        }
    }
}