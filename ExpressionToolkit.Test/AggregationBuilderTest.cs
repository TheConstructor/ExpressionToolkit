using System;
using System.Linq;

namespace ExpressionToolkit.Test;

public class AggregationBuilderTest
{
    [Theory]
    [InlineData(new[] {1, 2, 3}, 1)]
    [InlineData(new[] {4, 3, 2}, 2)]
    [InlineData(new[] {-1}, -1)]
    public void IntMinIsDetermined(int[] input, int min)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => builder.Min());
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(min);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 1)]
    [InlineData(new[] {4, 3, 2}, 2)]
    [InlineData(new[] {-1}, -1)]
    public void ObjectIntMinIsDetermined(int[] input, int min)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<object> builder) => builder.Min(o => (int)o));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input.Select(i => (object) i)).ShouldBe(min);
    }

    [Fact]
    public void IntMinThrowsOnEmptyInput()
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => builder.Min());
        var aggregator = aggregatorExpression.Compile();
        ShouldThrowExtensions.ShouldThrow<InvalidOperationException>(() => aggregator(Array.Empty<int>()));
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 3)]
    [InlineData(new[] {4, 3, 2}, 4)]
    [InlineData(new[] {-1}, -1)]
    public void IntMaxIsDetermined(int[] input, int max)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => builder.Max());
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(max);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 3)]
    [InlineData(new[] {4, 3, 2}, 4)]
    [InlineData(new[] {-1}, -1)]
    public void ObjectIntMaxIsDetermined(int[] input, int max)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<object> builder) => builder.Max(o => (int)o));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input.Select(i => (object) i)).ShouldBe(max);
    }

    [Fact]
    public void IntMaxThrowsOnEmptyInput()
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => builder.Max());
        var aggregator = aggregatorExpression.Compile();
        ShouldThrowExtensions.ShouldThrow<InvalidOperationException>(() => aggregator(Array.Empty<int>()));
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 1, 3)]
    [InlineData(new[] {4, 3, 2}, 2, 4)]
    [InlineData(new[] {-1}, -1, -1)]
    public void IntMinAndMaxAreDeterminedAsObject(int[] input, int min, int max)
    {
        AggregationBuilder.CreateAggregator(new int[0], builder => 0);
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => new {Min = builder.Min(),Max = builder.Max()});
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldSatisfyAllConditions(
                r => r.Min.ShouldBe(min),
                r => r.Max.ShouldBe(max));
    }
}