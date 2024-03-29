﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace ExpressionToolkit.Test;

public class ExpressionReplacingVisitorTests
{

    public static TheoryData<Expression, Expression, Expression, Expression> SimpleReplacementTestData()
    {
        var const2 = Expression.Constant(2);
        var const4 = Expression.Constant(4);
        var const6 = Expression.Constant(6);
        return new TheoryData<Expression, Expression, Expression, Expression>
        {
            {
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(const4),
                const4,
                const2,
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(const2)
            },
            {
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(const4),
                const4,
                ExpressionUtil.BodyOf(() => 6),
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(() => 6)
            },
            {
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(const4),
                const6,
                const2,
                ((Expression<Func<int, int>>) (a => a + 3)).BindParameters(const4)
            }
        };
    }

    [Theory]
    [MemberData(nameof(SimpleReplacementTestData))]
    public void SimpleReplacementTest(Expression input, Expression needle, Expression replacement, Expression result)
    {
        var visitor = new ExpressionReplacingVisitor(new Dictionary<Expression, Expression>
        {
            {needle, replacement}
        });
        var actual = visitor.Visit(input);
        TestUtil.GetDebugView(actual).ShouldBe(TestUtil.GetDebugView(result));
    }

    public static TheoryData<Expression, Expression> CompileAndInvokeTestData()
    {
        var func = (Expression<Func<int, int>>) (a => a);
        return new TheoryData<Expression, Expression>
        {
            {
                (Expression<Func<int>>) (() => func.Compile()(3)),
                (Expression<Func<int>>) (() => 3)
            },
            {
                ParameterBinder1.BindParameters<Expression<Func<int, int>>, int>( f => f.Compile()(3), Expression.Constant(func)),
                (Expression<Func<int>>) (() => 3)
            }
        };
    }

    [Theory]
    [MemberData(nameof(CompileAndInvokeTestData))]
    public void CompileAndInvokeTest(Expression input, Expression result)
    {
        var visitor = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty);
        var actual = visitor.Visit(input);
        TestUtil.GetDebugView(actual).ShouldBe(TestUtil.GetDebugView(result));
    }

    public static TheoryData<Expression, Expression> ReplaceWithTestData()
    {
        var func = (Expression<Func<int, int>>) (a => a);
        return new TheoryData<Expression, Expression>
        {
            {
                (Expression<Func<int>>) (() => func.CompileAndInvoke(3)),
                (Expression<Func<int>>) (() => 3)
            },
            {
                (Expression<Func<int>>) (() => ((Expression<Func<int, int>>) (a => a)).CompileAndInvoke(4)),
                (Expression<Func<int>>) (() => 4)
            },
            {
                (Expression<Func<int>>) (() => InvokeExpression1.CompileAndInvoke(a => a, 5)),
                (Expression<Func<int>>) (() => 5)
            }
        };
    }

    [Theory]
    [MemberData(nameof(ReplaceWithTestData))]
    public void ReplaceWithTest(Expression input, Expression result)
    {
        var visitor = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty);
        var actual = visitor.Visit(input);
        TestUtil.GetDebugView(actual).ShouldBe(TestUtil.GetDebugView(result));
    }
}