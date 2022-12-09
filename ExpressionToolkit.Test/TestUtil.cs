using System;
using System.Linq.Expressions;

namespace ExpressionToolkit.Test;

static internal class TestUtil
{
    public static readonly Func<Expression, string> GetDebugView;

    static TestUtil()
    {
        Func<Expression, string>? func;
        try
        {
            var expression = Expression.Parameter(typeof(Expression), "expression");
            func = Expression.Lambda<Func<Expression, string>>(
                    Expression.Property(expression, typeof(Expression), "DebugView"),
                    expression)
                .Compile();
        }
        catch (ArgumentException)
        {
            func = expression => expression.ToString();
        }

        GetDebugView = func;
    }
}