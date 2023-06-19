using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ExpressionToolkit
{
    public static class ExpressionUtil
    {
        public static Expression AsBlockIfNeeded(this IEnumerable<Expression> expressions)
        {
            switch (expressions)
            {
                case IReadOnlyCollection<Expression> {Count: 0}:
                case ICollection<Expression> {Count: 0}:
                    return Expression.Empty();
                case IReadOnlyCollection<Expression> {Count: 1}:
                case ICollection<Expression> {Count: 1}:
                    return expressions.First();
                default:
                {
                    var block = Expression.Block(expressions);
                    return block.Expressions.Count switch
                    {
                        0 => Expression.Empty(),
                        1 => block.Expressions[0],
                        _ => block
                    };
                }
            }
        }

        public static Expression While(Expression condition, params Expression[] body)
        {
            return While(condition, (IEnumerable<Expression>) body);
        }

        public static Expression While(Expression condition, IEnumerable<Expression> body)
        {
            var breakLabel = Expression.Label();
            return Expression.Loop(
                Expression.IfThenElse(
                    condition,
                    body.AsBlockIfNeeded(),
                    Expression.Break(breakLabel)),
                breakLabel);
        }

        public static Expression BodyOf(this Expression<Action> expression)
        {
            return expression.Body;
        }

        public static Expression BodyOf<T>(this Expression<Func<T>> expression)
        {
            return expression.Body;
        }

        public static bool TryResolveAs<T>(this Expression expression, [MaybeNullWhen(false)] out T value)
        {
            if (TryResolveValue(expression, out var obj)
                && obj is T t2)
            {
                value = t2;
                return true;
            }

            value = default;
            return false;
        }

        public static bool TryResolveValue(this Expression expression, [MaybeNullWhen(false)] out object value)
        {
            switch (expression)
            {
                case ConstantExpression constantExpression:
                    value = constantExpression.Value;
                    return true;
                case UnaryExpression unaryExpression:
                    switch (unaryExpression.NodeType)
                    {
                        case ExpressionType.Quote:
                            value = unaryExpression.Operand;
                            return true;
                        case ExpressionType.Convert:
                        case ExpressionType.ConvertChecked:
                        {
                            if (unaryExpression.Type.IsAssignableFrom(unaryExpression.Operand.Type))
                            {
                                return TryResolveValue(unaryExpression.Operand, out value);
                            }

                            break;
                        }
                    }

                    break;
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