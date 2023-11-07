using System;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace ExpressionToolkit.Test;

public class ReplaceWithMassTest
{

#region 0Args

    private class OneClass0
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod() => throw new NotImplementedException();

        private Expression InstanceBackingMethod() => Expression.Constant(0);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod() => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0) => Expression.Constant(0);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod() => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod() => Expression.Constant(0);
    }

    [Fact]
    public void InstanceBackedMethodWith0ArgsIsReplaced()
    {
        var c = new OneClass0();
        Expression<Func<int>> input = () => c.InstanceBackedMethod();
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(0);
    }

    [Fact]
    public void StaticBackedMethodWith0ArgsIsReplaced()
    {
        Expression<Func<OneClass0, int>> input = (p0) => p0.StaticBackedMethod();
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass0, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(0);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith0ArgsIsReplaced()
    {
        Expression<Func<OneClass0, int>> input = (p0) => p0.StaticOnlyBackedMethod();
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass0, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(0);
    }

#endregion

#region 1Args

    private class OneClass1
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1) => Expression.Constant(1);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1) => Expression.Constant(1);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1) => Expression.Constant(1);
    }

    [Fact]
    public void InstanceBackedMethodWith1ArgsIsReplaced()
    {
        var c = new OneClass1();
        Expression<Func<int, int>> input = (p1) => c.InstanceBackedMethod(p1);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(1);
    }

    [Fact]
    public void StaticBackedMethodWith1ArgsIsReplaced()
    {
        Expression<Func<OneClass1, int, int>> input = (p0, p1) => p0.StaticBackedMethod(p1);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass1, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(1);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith1ArgsIsReplaced()
    {
        Expression<Func<OneClass1, int, int>> input = (p0, p1) => p0.StaticOnlyBackedMethod(p1);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass1, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(1);
    }

#endregion

#region 2Args

    private class OneClass2
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2) => Expression.Constant(2);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2) => Expression.Constant(2);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2) => Expression.Constant(2);
    }

    [Fact]
    public void InstanceBackedMethodWith2ArgsIsReplaced()
    {
        var c = new OneClass2();
        Expression<Func<int, int, int>> input = (p1, p2) => c.InstanceBackedMethod(p1, p2);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(2);
    }

    [Fact]
    public void StaticBackedMethodWith2ArgsIsReplaced()
    {
        Expression<Func<OneClass2, int, int, int>> input = (p0, p1, p2) => p0.StaticBackedMethod(p1, p2);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass2, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(2);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith2ArgsIsReplaced()
    {
        Expression<Func<OneClass2, int, int, int>> input = (p0, p1, p2) => p0.StaticOnlyBackedMethod(p1, p2);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass2, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(2);
    }

#endregion

#region 3Args

    private class OneClass3
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3) => Expression.Constant(3);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3) => Expression.Constant(3);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3) => Expression.Constant(3);
    }

    [Fact]
    public void InstanceBackedMethodWith3ArgsIsReplaced()
    {
        var c = new OneClass3();
        Expression<Func<int, int, int, int>> input = (p1, p2, p3) => c.InstanceBackedMethod(p1, p2, p3);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(3);
    }

    [Fact]
    public void StaticBackedMethodWith3ArgsIsReplaced()
    {
        Expression<Func<OneClass3, int, int, int, int>> input = (p0, p1, p2, p3) => p0.StaticBackedMethod(p1, p2, p3);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass3, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(3);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith3ArgsIsReplaced()
    {
        Expression<Func<OneClass3, int, int, int, int>> input = (p0, p1, p2, p3) => p0.StaticOnlyBackedMethod(p1, p2, p3);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass3, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(3);
    }

#endregion

#region 4Args

    private class OneClass4
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4) => Expression.Constant(4);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4) => Expression.Constant(4);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4) => Expression.Constant(4);
    }

    [Fact]
    public void InstanceBackedMethodWith4ArgsIsReplaced()
    {
        var c = new OneClass4();
        Expression<Func<int, int, int, int, int>> input = (p1, p2, p3, p4) => c.InstanceBackedMethod(p1, p2, p3, p4);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(4);
    }

    [Fact]
    public void StaticBackedMethodWith4ArgsIsReplaced()
    {
        Expression<Func<OneClass4, int, int, int, int, int>> input = (p0, p1, p2, p3, p4) => p0.StaticBackedMethod(p1, p2, p3, p4);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass4, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(4);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith4ArgsIsReplaced()
    {
        Expression<Func<OneClass4, int, int, int, int, int>> input = (p0, p1, p2, p3, p4) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass4, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(4);
    }

#endregion

#region 5Args

    private class OneClass5
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5) => Expression.Constant(5);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5) => Expression.Constant(5);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5) => Expression.Constant(5);
    }

    [Fact]
    public void InstanceBackedMethodWith5ArgsIsReplaced()
    {
        var c = new OneClass5();
        Expression<Func<int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5) => c.InstanceBackedMethod(p1, p2, p3, p4, p5);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(5);
    }

    [Fact]
    public void StaticBackedMethodWith5ArgsIsReplaced()
    {
        Expression<Func<OneClass5, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5) => p0.StaticBackedMethod(p1, p2, p3, p4, p5);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass5, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(5);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith5ArgsIsReplaced()
    {
        Expression<Func<OneClass5, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass5, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(5);
    }

#endregion

#region 6Args

    private class OneClass6
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6) => Expression.Constant(6);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6) => Expression.Constant(6);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6) => Expression.Constant(6);
    }

    [Fact]
    public void InstanceBackedMethodWith6ArgsIsReplaced()
    {
        var c = new OneClass6();
        Expression<Func<int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(6);
    }

    [Fact]
    public void StaticBackedMethodWith6ArgsIsReplaced()
    {
        Expression<Func<OneClass6, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass6, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(6);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith6ArgsIsReplaced()
    {
        Expression<Func<OneClass6, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass6, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(6);
    }

#endregion

#region 7Args

    private class OneClass7
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7) => Expression.Constant(7);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7) => Expression.Constant(7);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7) => Expression.Constant(7);
    }

    [Fact]
    public void InstanceBackedMethodWith7ArgsIsReplaced()
    {
        var c = new OneClass7();
        Expression<Func<int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(7);
    }

    [Fact]
    public void StaticBackedMethodWith7ArgsIsReplaced()
    {
        Expression<Func<OneClass7, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass7, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(7);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith7ArgsIsReplaced()
    {
        Expression<Func<OneClass7, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass7, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(7);
    }

#endregion

#region 8Args

    private class OneClass8
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8) => Expression.Constant(8);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8) => Expression.Constant(8);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8) => Expression.Constant(8);
    }

    [Fact]
    public void InstanceBackedMethodWith8ArgsIsReplaced()
    {
        var c = new OneClass8();
        Expression<Func<int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(8);
    }

    [Fact]
    public void StaticBackedMethodWith8ArgsIsReplaced()
    {
        Expression<Func<OneClass8, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass8, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(8);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith8ArgsIsReplaced()
    {
        Expression<Func<OneClass8, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass8, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(8);
    }

#endregion

#region 9Args

    private class OneClass9
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9) => Expression.Constant(9);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9) => Expression.Constant(9);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9) => Expression.Constant(9);
    }

    [Fact]
    public void InstanceBackedMethodWith9ArgsIsReplaced()
    {
        var c = new OneClass9();
        Expression<Func<int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(9);
    }

    [Fact]
    public void StaticBackedMethodWith9ArgsIsReplaced()
    {
        Expression<Func<OneClass9, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass9, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(9);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith9ArgsIsReplaced()
    {
        Expression<Func<OneClass9, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass9, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(9);
    }

#endregion

#region 10Args

    private class OneClass10
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10) => Expression.Constant(10);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10) => Expression.Constant(10);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10) => Expression.Constant(10);
    }

    [Fact]
    public void InstanceBackedMethodWith10ArgsIsReplaced()
    {
        var c = new OneClass10();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(10);
    }

    [Fact]
    public void StaticBackedMethodWith10ArgsIsReplaced()
    {
        Expression<Func<OneClass10, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass10, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(10);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith10ArgsIsReplaced()
    {
        Expression<Func<OneClass10, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass10, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(10);
    }

#endregion

#region 11Args

    private class OneClass11
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11) => Expression.Constant(11);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11) => Expression.Constant(11);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11) => Expression.Constant(11);
    }

    [Fact]
    public void InstanceBackedMethodWith11ArgsIsReplaced()
    {
        var c = new OneClass11();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(11);
    }

    [Fact]
    public void StaticBackedMethodWith11ArgsIsReplaced()
    {
        Expression<Func<OneClass11, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass11, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(11);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith11ArgsIsReplaced()
    {
        Expression<Func<OneClass11, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass11, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(11);
    }

#endregion

#region 12Args

    private class OneClass12
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12) => Expression.Constant(12);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12) => Expression.Constant(12);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12) => Expression.Constant(12);
    }

    [Fact]
    public void InstanceBackedMethodWith12ArgsIsReplaced()
    {
        var c = new OneClass12();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(12);
    }

    [Fact]
    public void StaticBackedMethodWith12ArgsIsReplaced()
    {
        Expression<Func<OneClass12, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass12, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(12);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith12ArgsIsReplaced()
    {
        Expression<Func<OneClass12, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass12, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(12);
    }

#endregion

#region 13Args

    private class OneClass13
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13) => Expression.Constant(13);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13) => Expression.Constant(13);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13) => Expression.Constant(13);
    }

    [Fact]
    public void InstanceBackedMethodWith13ArgsIsReplaced()
    {
        var c = new OneClass13();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(13);
    }

    [Fact]
    public void StaticBackedMethodWith13ArgsIsReplaced()
    {
        Expression<Func<OneClass13, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass13, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(13);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith13ArgsIsReplaced()
    {
        Expression<Func<OneClass13, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass13, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(13);
    }

#endregion

#region 14Args

    private class OneClass14
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14) => Expression.Constant(14);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14) => Expression.Constant(14);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14) => Expression.Constant(14);
    }

    [Fact]
    public void InstanceBackedMethodWith14ArgsIsReplaced()
    {
        var c = new OneClass14();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(14);
    }

    [Fact]
    public void StaticBackedMethodWith14ArgsIsReplaced()
    {
        Expression<Func<OneClass14, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass14, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(14);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith14ArgsIsReplaced()
    {
        Expression<Func<OneClass14, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass14, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(14);
    }

#endregion

#region 15Args

    private class OneClass15
    {
        [ReplaceWith(nameof(InstanceBackingMethod))]
        public int InstanceBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14, int p15) => throw new NotImplementedException();

        private Expression InstanceBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15) => Expression.Constant(15);

        [ReplaceWith(nameof(StaticBackingMethod))]
        public int StaticBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14, int p15) => throw new NotImplementedException();

        private static Expression StaticBackingMethod(Expression p0, Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15) => Expression.Constant(15);

        [ReplaceWith(nameof(StaticOnlyBackingMethod))]
        public int StaticOnlyBackedMethod(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11, int p12, int p13, int p14, int p15) => throw new NotImplementedException();

        private static Expression StaticOnlyBackingMethod(Expression p1, Expression p2, Expression p3, Expression p4, Expression p5, Expression p6, Expression p7, Expression p8, Expression p9, Expression p10, Expression p11, Expression p12, Expression p13, Expression p14, Expression p15) => Expression.Constant(15);
    }

    [Fact]
    public void InstanceBackedMethodWith15ArgsIsReplaced()
    {
        var c = new OneClass15();
        Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => c.InstanceBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(15);
    }

    [Fact]
    public void StaticBackedMethodWith15ArgsIsReplaced()
    {
        Expression<Func<OneClass15, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => p0.StaticBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass15, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(15);
    }

    [Fact]
    public void StaticOnlyBackedMethodWith15ArgsIsReplaced()
    {
        Expression<Func<OneClass15, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> input = (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => p0.StaticOnlyBackedMethod(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        var output = new ExpressionReplacingVisitor(ImmutableDictionary<Expression, Expression>.Empty)
            .Visit(input);
        output.ShouldBeAssignableTo<Expression<Func<OneClass15, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>>()
            !.Body.ShouldBeOfType<ConstantExpression>()
            .Value.ShouldBe(15);
    }

#endregion
}