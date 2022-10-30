using System;
using System.Linq.Expressions;
using System.Reflection;

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

        public static bool TryResolveAs<T>(this Expression expression, out T value)
        {
            if (expression is T t)
            {
                value = t;
                return true;
            }

            if (TryResolveValue(expression, out var obj)
                && obj is T t2)
            {
                value = t2;
                return true;
            }

            value = default;
            return false;
        }
        public static bool TryResolveValue(this Expression expression, out object value)
        {
            switch (expression)
            {
                case ConstantExpression constantExpression:
                    value = constantExpression.Value;
                    return true;
                case MemberExpression memberExpression:
                    switch (memberExpression.Member)
                    {
                        case FieldInfo fieldInfo:
                        {
                            if (TryResolveValue(memberExpression.Expression, out var container))
                            {
                                value = fieldInfo.GetValue(container);
                                return true;
                            }

                            break;
                        }
                        case PropertyInfo propertyInfo:
                        {
                            if (TryResolveValue(memberExpression.Expression, out var container))
                            {
                                value = propertyInfo.GetValue(container);
                                return true;
                            }

                            break;
                        }
                    }
                    break;
            }

            value = null;
            return false;
        }
    }
}