using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionToolkit
{
    public static class ParameterBinder
    {

#region 1 Parameter

        public static Expression<Func<TResult>> BindParameters<T1, TResult>(this Expression<Func<T1, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, TResult>(this Expression<Func<T1, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1>(this Expression<Action<T1>> expression, Expression p1)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1>(this Expression<Action<T1>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 2 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, TResult>> BindParameters<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1]);
        }

        public static Expression<Func<T2, TResult>> BindParameters<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1]);
        }

        public static Expression<Action<T2>> BindParameters<T1, T2>(this Expression<Action<T1, T2>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1]);
        }

        public static Expression<Action<T2>> BindParameters<T1, T2>(this Expression<Action<T1, T2>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2>(this Expression<Action<T1, T2>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2>(this Expression<Action<T1, T2>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 3 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2]);
        }

        public static Expression<Func<T2, T3, TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2]);
        }

        public static Expression<Action<T2, T3>> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2]);
        }

        public static Expression<Action<T2, T3>> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2]);
        }

        public static Expression<Func<T3, TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2]);
        }

        public static Expression<Action<T3>> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2]);
        }

        public static Expression<Action<T3>> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 4 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Func<T2, T3, T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Action<T2, T3, T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Action<T2, T3, T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Func<T3, T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Action<T3, T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3]);
        }

        public static Expression<Action<T3, T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3]);
        }

        public static Expression<Func<T4, TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3]);
        }

        public static Expression<Action<T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3]);
        }

        public static Expression<Action<T4>> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 5 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Func<T2, T3, T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T2, T3, T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T2, T3, T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Func<T3, T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T3, T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T3, T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Func<T4, T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4]);
        }

        public static Expression<Action<T4, T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4]);
        }

        public static Expression<Func<T5, TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4]);
        }

        public static Expression<Action<T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4]);
        }

        public static Expression<Action<T5>> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 6 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Func<T3, T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T3, T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T3, T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Func<T4, T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T4, T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Func<T5, T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5]);
        }

        public static Expression<Action<T5, T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5]);
        }

        public static Expression<Func<T6, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5]);
        }

        public static Expression<Action<T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5]);
        }

        public static Expression<Action<T6>> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 7 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Func<T4, T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T4, T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Func<T5, T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T5, T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Func<T6, T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6]);
        }

        public static Expression<Action<T6, T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6]);
        }

        public static Expression<Func<T7, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6]);
        }

        public static Expression<Action<T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6]);
        }

        public static Expression<Action<T7>> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 8 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T5, T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T5, T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T6, T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T6, T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Func<T7, T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7]);
        }

        public static Expression<Action<T7, T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7]);
        }

        public static Expression<Func<T8, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7]);
        }

        public static Expression<Action<T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7]);
        }

        public static Expression<Action<T8>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 9 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T6, T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T6, T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T7, T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T7, T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Func<T8, T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8]);
        }

        public static Expression<Action<T8, T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8]);
        }

        public static Expression<Func<T9, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8]);
        }

        public static Expression<Action<T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8]);
        }

        public static Expression<Action<T9>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 10 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T7, T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T7, T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T8, T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T8, T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Func<T9, T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9]);
        }

        public static Expression<Action<T9, T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9]);
        }

        public static Expression<Func<T10, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9]);
        }

        public static Expression<Action<T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9]);
        }

        public static Expression<Action<T10>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 11 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T8, T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T8, T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T9, T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T9, T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Func<T10, T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10]);
        }

        public static Expression<Action<T10, T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10]);
        }

        public static Expression<Func<T11, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10]);
        }

        public static Expression<Action<T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10]);
        }

        public static Expression<Action<T11>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 12 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T8, T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T9, T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T9, T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T10, T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T10, T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Func<T11, T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11]);
        }

        public static Expression<Action<T11, T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11, T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11]);
        }
#endregion

#region Binding first 11 Parameters
        public static Expression<Func<T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11]);
        }

        public static Expression<Func<T12, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<T12, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11]);
        }

        public static Expression<Action<T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action<T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11]);
        }

        public static Expression<Action<T12>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action<T12>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 13 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T8, T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T9, T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T10, T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T10, T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T11, T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T11, T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11, T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 11 Parameters
        public static Expression<Func<T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Func<T12, T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<T12, T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action<T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12]);
        }

        public static Expression<Action<T12, T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action<T12, T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12]);
        }
#endregion

#region Binding first 12 Parameters
        public static Expression<Func<T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Func<T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12]);
        }

        public static Expression<Func<T13, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Func<T13, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12]);
        }

        public static Expression<Action<T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Action<T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12]);
        }

        public static Expression<Action<T13>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Action<T13>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 14 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T9, T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T10, T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T11, T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T11, T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 11 Parameters
        public static Expression<Func<T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T12, T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action<T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T12, T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action<T12, T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 12 Parameters
        public static Expression<Func<T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Func<T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Func<T13, T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Func<T13, T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Action<T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13]);
        }

        public static Expression<Action<T13, T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Action<T13, T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13]);
        }
#endregion

#region Binding first 13 Parameters
        public static Expression<Func<T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Func<T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13]);
        }

        public static Expression<Func<T14, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Func<T14, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13]);
        }

        public static Expression<Action<T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Action<T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13]);
        }

        public static Expression<Action<T14>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Action<T14>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 15 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T9, T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T10, T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T11, T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T11, T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 11 Parameters
        public static Expression<Func<T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T12, T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action<T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T12, T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action<T12, T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 12 Parameters
        public static Expression<Func<T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Func<T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T13, T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Func<T13, T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Action<T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T13, T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Action<T13, T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 13 Parameters
        public static Expression<Func<T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Func<T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Func<T14, T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Func<T14, T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Action<T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14]);
        }

        public static Expression<Action<T14, T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Action<T14, T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14]);
        }
#endregion

#region Binding first 14 Parameters
        public static Expression<Func<T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Func<T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14]);
        }

        public static Expression<Func<T15, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Func<T15, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14]);
        }

        public static Expression<Action<T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Action<T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14]);
        }

        public static Expression<Action<T15>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Action<T15>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion

#region 16 Parameter

#region Binding first 1 Parameters
        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1)
        {
            return Expression.Lambda<Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(1)
                        {
                            {expression.Parameters[0], p1.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[1],
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 2 Parameters
        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2)
        {
            return Expression.Lambda<Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(2)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[2],
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 3 Parameters
        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3)
        {
            return Expression.Lambda<Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(3)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[3],
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 4 Parameters
        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4)
        {
            return Expression.Lambda<Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(4)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[4],
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 5 Parameters
        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5)
        {
            return Expression.Lambda<Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(5)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[5],
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 6 Parameters
        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6)
        {
            return Expression.Lambda<Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(6)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[6],
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 7 Parameters
        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T8, T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7)
        {
            return Expression.Lambda<Action<T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(7)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[7],
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 8 Parameters
        public static Expression<Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T9, T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8)
        {
            return Expression.Lambda<Action<T9, T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(8)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[8],
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 9 Parameters
        public static Expression<Func<T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T10, T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Func<T10, T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T10, T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9)
        {
            return Expression.Lambda<Action<T10, T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(9)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[9],
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 10 Parameters
        public static Expression<Func<T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T11, T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Func<T11, T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T11, T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10)
        {
            return Expression.Lambda<Action<T11, T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(10)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[10],
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 11 Parameters
        public static Expression<Func<T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T12, T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Func<T12, T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11)
        {
            return Expression.Lambda<Action<T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T12, T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11)
        {
            return Expression.Lambda<Action<T12, T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(11)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[11],
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 12 Parameters
        public static Expression<Func<T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Func<T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T13, T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Func<T13, T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12)
        {
            return Expression.Lambda<Action<T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T13, T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12)
        {
            return Expression.Lambda<Action<T13, T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(12)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[12],
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 13 Parameters
        public static Expression<Func<T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Func<T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T14, T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Func<T14, T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13)
        {
            return Expression.Lambda<Action<T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T14, T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13)
        {
            return Expression.Lambda<Action<T14, T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(13)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[13],
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 14 Parameters
        public static Expression<Func<T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Func<T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Func<T15, T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Func<T15, T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14)
        {
            return Expression.Lambda<Action<T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14],
                expression.Parameters[15]);
        }

        public static Expression<Action<T15, T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14)
        {
            return Expression.Lambda<Action<T15, T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(14)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[14],
                expression.Parameters[15]);
        }
#endregion

#region Binding first 15 Parameters
        public static Expression<Func<T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15)
        {
            return Expression.Lambda<Func<T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[15]);
        }

        public static Expression<Func<T16, TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15)
        {
            return Expression.Lambda<Func<T16, TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[15]);
        }

        public static Expression<Action<T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15)
        {
            return Expression.Lambda<Action<T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[15]);
        }

        public static Expression<Action<T16>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15)
        {
            return Expression.Lambda<Action<T16>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(15)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body}
                        })
                    .Visit(expression.Body)!,
                expression.Parameters[15]);
        }
#endregion

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15, Expression p16)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(16)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15},
                            {expression.Parameters[15], (p16 as Expression<Func<T16>>)?.Body ?? p16}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Func<TResult>> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15, Expression<Func<T16>> p16)
        {
            return Expression.Lambda<Func<TResult>>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(16)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body},
                            {expression.Parameters[15], p16.Body}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15, Expression p16)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(16)
                        {
                            {expression.Parameters[0], (p1 as Expression<Func<T1>>)?.Body ?? p1},
                            {expression.Parameters[1], (p2 as Expression<Func<T2>>)?.Body ?? p2},
                            {expression.Parameters[2], (p3 as Expression<Func<T3>>)?.Body ?? p3},
                            {expression.Parameters[3], (p4 as Expression<Func<T4>>)?.Body ?? p4},
                            {expression.Parameters[4], (p5 as Expression<Func<T5>>)?.Body ?? p5},
                            {expression.Parameters[5], (p6 as Expression<Func<T6>>)?.Body ?? p6},
                            {expression.Parameters[6], (p7 as Expression<Func<T7>>)?.Body ?? p7},
                            {expression.Parameters[7], (p8 as Expression<Func<T8>>)?.Body ?? p8},
                            {expression.Parameters[8], (p9 as Expression<Func<T9>>)?.Body ?? p9},
                            {expression.Parameters[9], (p10 as Expression<Func<T10>>)?.Body ?? p10},
                            {expression.Parameters[10], (p11 as Expression<Func<T11>>)?.Body ?? p11},
                            {expression.Parameters[11], (p12 as Expression<Func<T12>>)?.Body ?? p12},
                            {expression.Parameters[12], (p13 as Expression<Func<T13>>)?.Body ?? p13},
                            {expression.Parameters[13], (p14 as Expression<Func<T14>>)?.Body ?? p14},
                            {expression.Parameters[14], (p15 as Expression<Func<T15>>)?.Body ?? p15},
                            {expression.Parameters[15], (p16 as Expression<Func<T16>>)?.Body ?? p16}
                        })
                    .Visit(expression.Body)!);
        }

        public static Expression<Action> BindParameters<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, Expression<Func<T1>> p1, Expression<Func<T2>> p2, Expression<Func<T3>> p3, Expression<Func<T4>> p4, Expression<Func<T5>> p5, Expression<Func<T6>> p6, Expression<Func<T7>> p7, Expression<Func<T8>> p8, Expression<Func<T9>> p9, Expression<Func<T10>> p10, Expression<Func<T11>> p11, Expression<Func<T12>> p12, Expression<Func<T13>> p13, Expression<Func<T14>> p14, Expression<Func<T15>> p15, Expression<Func<T16>> p16)
        {
            return Expression.Lambda<Action>(
                new ExpressionReplacingVisitor(
                        new Dictionary<Expression, Expression>(16)
                        {
                            {expression.Parameters[0], p1.Body},
                            {expression.Parameters[1], p2.Body},
                            {expression.Parameters[2], p3.Body},
                            {expression.Parameters[3], p4.Body},
                            {expression.Parameters[4], p5.Body},
                            {expression.Parameters[5], p6.Body},
                            {expression.Parameters[6], p7.Body},
                            {expression.Parameters[7], p8.Body},
                            {expression.Parameters[8], p9.Body},
                            {expression.Parameters[9], p10.Body},
                            {expression.Parameters[10], p11.Body},
                            {expression.Parameters[11], p12.Body},
                            {expression.Parameters[12], p13.Body},
                            {expression.Parameters[13], p14.Body},
                            {expression.Parameters[14], p15.Body},
                            {expression.Parameters[15], p16.Body}
                        })
                    .Visit(expression.Body)!);
        }
#endregion
    }
}
