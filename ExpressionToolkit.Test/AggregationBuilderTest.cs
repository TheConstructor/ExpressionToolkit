using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    [InlineData(new[] {"a", "b", "c"}, "a")]
    [InlineData(new[] {"d", "c", "b"}, "b")]
    [InlineData(new string[0], null)]
    [InlineData(new string?[] {null}, null)]
    [InlineData(new[] {null, "a", "b"}, "a")]
    public void StringMinIsDetermined(string[] input, string min)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<string> builder) => builder.Min(o => o));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(min);
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
    [InlineData(new[] {"a", "b", "c"}, "c")]
    [InlineData(new[] {"d", "c", "b"}, "d")]
    [InlineData(new string[0], null)]
    [InlineData(new string?[] {null}, null)]
    public void StringMaxIsDetermined(string[] input, string max)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<string> builder) => builder.Max(o => o));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(max);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 1, 3)]
    [InlineData(new[] {4, 3, 2}, 2, 4)]
    [InlineData(new[] {-1}, -1, -1)]
    public void IntMinAndMaxAreDeterminedAsObject(int[] input, int min, int max)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => new {Min = builder.Min(),Max = builder.Max()});
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldSatisfyAllConditions(
                r => r.Min.ShouldBe(min),
                r => r.Max.ShouldBe(max));
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, true, true)]
    [InlineData(new[] {4, 3, 2}, true, true)]
    [InlineData(new int[0], false, false)]
    [InlineData(new[] {-1}, true, false)]
    [InlineData(new[] {-1, 0}, true, false)]
    [InlineData(new[] {-1, 0, 1}, true, false)]
    public void IntAnyIsDetermined(int[] input, bool anyExpected, bool largerThanTwoExpected)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => new
            {
                Any = builder.Any(),
                LargerThanTwo = builder.Any(i => i > 2)
            });
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(new
        {
            Any = anyExpected,
            LargerThanTwo = largerThanTwoExpected
        });
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, true)]
    [InlineData(new[] {4, 3, 2}, true)]
    [InlineData(new int[0], true)]
    [InlineData(new[] {-1}, false)]
    [InlineData(new[] {-1, 0}, false)]
    [InlineData(new[] {-1, 0, 1}, false)]
    public void IntAllIsDetermined(int[] input, bool expected)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder) => builder.All(i => i > 0));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(expected);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 2)]
    [InlineData(new[] {4, 3, 2}, 3)]
    [InlineData(new[] {-1}, -1)]
    [InlineData(new[] {-1, 0}, 1)]
    [InlineData(new[] {-1, 0, 1}, 0)]
    public void IntAggregateToDiffIsDetermined(int[] input, int expected)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder)
                => builder.Aggregate(
                    (d, i) => i - d));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(expected);
    }

    [Fact]
    public void IntAggregateToDiffThrowsOnEmptyInput()
    {
        var aggregatorExpression
            = Enumerable.Empty<int>()
                .CreateAggregator(builder
                => builder.Aggregate(
                    (d, i) => i - d));
        var aggregator = aggregatorExpression.Compile();
        ShouldThrowExtensions.ShouldThrow<InvalidOperationException>(() => aggregator(Array.Empty<int>()));
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, "123")]
    [InlineData(new[] {4, 3, 2}, "432")]
    [InlineData(new int[0], "")]
    [InlineData(new[] {-1}, "-1")]
    [InlineData(new[] {-1, 0}, "-10")]
    [InlineData(new[] {-1, 0, 1}, "-101")]
    public void IntAggregateToStringIsDetermined(int[] input, string expected)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder)
                => builder.Aggregate(
                    () => "",
                    (s, i) => s + i));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(expected);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, "123")]
    [InlineData(new[] {4, 3, 2}, "432")]
    [InlineData(new int[0], "")]
    [InlineData(new[] {-1}, "-1")]
    [InlineData(new[] {-1, 0}, "-10")]
    [InlineData(new[] {-1, 0, 1}, "-101")]
    public void IntAggregateToStringBuilderIsDetermined(int[] input, string expected)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder)
                => builder.Aggregate(
                    () => new StringBuilder(),
                    (s, i) => s.Append(i),
                    sb => sb.ToString()));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(expected);
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 3, 1)]
    [InlineData(new[] {4, 3, 2}, 3,2)]
    [InlineData(new int[0], 0, 0)]
    [InlineData(new[] {-1}, 1, 0)]
    [InlineData(new[] {-1, 0}, 2, 1)]
    [InlineData(new[] {-1, 0, 1}, 3, 1)]
    public void IntAggregateCountIsDetermined(int[] input, int expectedCount, int expectedEvenCount)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder)
                => new
                {
                    Count = builder.Count(),
                    LongCount = builder.LongCount(),
                    EvenCount = builder.Count(i => i % 2 == 0),
                    LongEvenCount = builder.LongCount(i => i % 2 == 0)
                });
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(new
        {
            Count = expectedCount,
            LongCount = (long) expectedCount,
            EvenCount = expectedEvenCount,
            LongEvenCount = (long) expectedEvenCount
        });
    }

    [Fact]
    public void SelectManyCollectsItemsIntoList()
    {
        var input = Enumerable.Range(0,4)
            .Select(i => Enumerable.Range(0, i));
        var aggregatorExpression
            = input.CreateAggregator(builder
                => builder.SelectMany(i => i));
        var aggregator = aggregatorExpression.Compile();
        aggregator(input)
            .ShouldBeOfType<List<int>>()
            .ShouldBe(Enumerable.Range(0,4)
                .Select(i => Enumerable.Range(0, i))
                .SelectMany(i => i));
        
    }

    [Theory]
    [InlineData(new[] {1, 2, 3}, 6)]
    [InlineData(new[] {4, 3, 2}, 9)]
    [InlineData(new int[0], 0)]
    [InlineData(new[] {-1}, -1)]
    [InlineData(new[] {-1, 0}, -1)]
    [InlineData(new[] {-1, 0, 1}, 0)]
    public void IntAggregateSumIsDetermined(int[] input, int expectedSum)
    {
        var aggregatorExpression
            = AggregationBuilder.CreateAggregator((AggregationBuilder<int> builder)
                => new
                {
                    Sum = builder.Sum(),
                    DoubledSum = builder.Sum(i => i * 2)
                });
        var aggregator = aggregatorExpression.Compile();
        aggregator(input).ShouldBe(new
        {
            Sum = expectedSum,
            DoubledSum = expectedSum * 2
        });
    }

    [Fact]
    public void CanCollectItems()
    {
        var input = Enumerable.Range(0, 42);
        var aggregatorExpression = input.CreateAggregator(builder =>
            new {
                Array = builder.ToArray(),
                List = builder.ToList(),
                HashSet = builder.ToHashSet()
            });
        var aggregator = aggregatorExpression.Compile();
        aggregator(input)
            .ShouldSatisfyAllConditions(
                output => output.Array
                    .ShouldBeOfType<int[]>()
                    .ShouldBe(Enumerable.Range(0, 42)),
                output => output.List
                    .ShouldBeOfType<List<int>>()
                    .ShouldBe(Enumerable.Range(0, 42)),
                output => output.HashSet
                    .ShouldBeOfType<HashSet<int>>()
                    .ShouldBe(Enumerable.Range(0, 42)));
    }
}