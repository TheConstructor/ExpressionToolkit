using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

// ReSharper disable VariableHidesOuterVariable

namespace ExpressionToolkit
{
    public static class AggregationBuilder
    {

        internal static readonly ISet<Type> PrimitiveComparableTypes
            = new HashSet<Type>
            {
                typeof(sbyte),
                typeof(sbyte?),
                typeof(byte),
                typeof(byte?),
                typeof(short),
                typeof(short?),
                typeof(ushort),
                typeof(ushort?),
                typeof(int),
                typeof(int?),
                typeof(uint),
                typeof(uint?),
                typeof(long),
                typeof(long?),
                typeof(ulong),
                typeof(ulong?),
                typeof(decimal),
                typeof(decimal?),
                typeof(float),
                typeof(float?),
                typeof(double),
                typeof(double?)
            };

        public static Expression<Func<IEnumerable<TIn>, TResult>> CreateAggregator<TIn, TResult>(
                this IEnumerable<TIn> example,
                Expression<Func<AggregationBuilder<TIn>, TResult>> aggregation)
        {
            return CreateAggregator(aggregation);
        }

        public static Expression<Func<IEnumerable<TIn>, TResult>> CreateAggregator<TIn, TResult>(Expression<Func<AggregationBuilder<TIn>, TResult>> aggregation)
        {
            var enumerable = Expression.Parameter(typeof(IEnumerable<TIn>), "enumerable");

            var enumerator = Expression.Variable(typeof(IEnumerator<TIn>), "enumerator");
            var current = Expression.Variable(typeof(TIn), "current");

            var variables = new List<ParameterExpression>
            {
                enumerator,
                current
            };
            var body = new List<Expression>();
            var onNoElement = new List<Expression>();
            var onFirstElement = new List<Expression>
            {
                Expression.Assign(
                    current,
                    ParameterBinder1.BindParametersAndReturnBody(
                        (IEnumerator<TIn> enumerator) => enumerator.Current, enumerator))
            };
            var onNextElements = new List<Expression>
            {
                Expression.Assign(
                    current,
                    ParameterBinder1.BindParametersAndReturnBody(
                        (IEnumerator<TIn> enumerator) => enumerator.Current, enumerator))
            };

            var replacements = new Dictionary<Expression, Expression>();

            var builder = new AggregationBuilder<TIn>(
                variables, body, onNoElement, onFirstElement, onNextElements, current);

            new ReplacementCollector<TIn>(aggregation.Parameters[0], builder, replacements)
                .Visit(aggregation);

            body.Add(Expression.Assign(
                enumerator,
                ParameterBinder1.BindParametersAndReturnBody(
                    (IEnumerable<TIn> enumerable) => enumerable.GetEnumerator(), enumerable)));

            body.Add(Expression.TryFinally(
                Expression.IfThenElse(
                    ParameterBinder1.BindParametersAndReturnBody(
                        (IEnumerator<TIn> enumerator) => enumerator.MoveNext(), enumerator),
                    onFirstElement
                        .Append(
                            ExpressionUtil.While(
                                ParameterBinder1.BindParametersAndReturnBody(
                                    (IEnumerator<TIn> enumerator) => enumerator.MoveNext(), enumerator),
                                onNextElements))
                        .AsBlockIfNeeded(),
                    onNoElement.AsBlockIfNeeded()
                ),
                ParameterBinder1.BindParametersAndReturnBody(
                    (IEnumerator<TIn> enumerator) => enumerator.Dispose(), enumerator)));

            var expressionReplacingVisitor = new ExpressionReplacingVisitor(replacements);
            body.Add(expressionReplacingVisitor.Visit(aggregation.Body)!);

            return Expression.Lambda<Func<IEnumerable<TIn>, TResult>>(
                Expression.Block(variables, body),
                enumerable);
        }

        private class ReplacementCollector<TIn> : ExpressionVisitor
        {
            private readonly ParameterExpression _builderParameter;
            private readonly AggregationBuilder<TIn> _builder;
            private readonly Dictionary<Expression, Expression> _replacements;

            public ReplacementCollector(
                ParameterExpression builderParameter,
                AggregationBuilder<TIn> builder,
                Dictionary<Expression, Expression> replacements)
            {
                _builderParameter = builderParameter;
                _replacements = replacements;
                _builder = builder;
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                if (node.Method.DeclaringType == typeof(AggregationBuilder<TIn>))
                {
                    Expression.Lambda<Action<AggregationBuilder<TIn>>>(node, _builderParameter)
                        .CompileAndInvoke(_builder);
                    _replacements.Add(node, _builder.ReplaceWith);
                    return node;
                }

                return base.VisitMethodCall(node);
            }
        }
    }

    public class AggregationBuilder<TIn>
    {
        private readonly List<ParameterExpression> _variables;
        private readonly List<Expression> _preparation;
        private readonly List<Expression> _onNoElement;
        private readonly List<Expression> _onFirstElement;
        private readonly List<Expression> _onNextElements;
        private readonly ParameterExpression _current;

        internal Expression ReplaceWith { get; private set; }

        internal AggregationBuilder(List<ParameterExpression> variables,
            List<Expression> preparation,
            List<Expression> onNoElement,
            List<Expression> onFirstElement,
            List<Expression> onNextElements,
            ParameterExpression current)
        {
            _variables = variables;
            _preparation = preparation;
            _onNoElement = onNoElement;
            _onFirstElement = onFirstElement;
            _onNextElements = onNextElements;
            _current = current;
        }

        public TIn Max()
        {
            ReplaceWith = MinOrMax<TIn>(_current, Expression.LessThan);
            return default;
        }

        public TResult Max<TResult>(Expression<Func<TIn, TResult>> selector)
        {
            ReplaceWith = MinOrMax<TResult>(selector.BindParametersAndReturnBody(_current), Expression.LessThan);
            return default;
        }

        public TIn Min()
        {
            ReplaceWith = MinOrMax<TIn>(_current, Expression.GreaterThan);
            return default;
        }

        public TResult Min<TResult>(Expression<Func<TIn, TResult>> selector)
        {
            ReplaceWith = MinOrMax<TResult>(selector.BindParametersAndReturnBody(_current), Expression.GreaterThan);
            return default;
        }

        private Expression MinOrMaxPrimitive<T>(Expression current,
            Func<Expression, Expression, Expression> overwriteOn)
        {
            var variable = Expression.Variable(typeof(T));
            _variables.Add(variable);
            _onFirstElement.Add(Expression.Assign(variable, current));

            if (default(T) == null)
            {
                _onNoElement.Add(Expression.Assign(variable, Expression.Constant(default(T))));
                _onNextElements.Add(
                    Expression.IfThen(
                        Expression.And(
                            Expression.NotEqual(current, Expression.Constant(null, typeof(T))),
                            Expression.Or(
                                Expression.Equal(variable, Expression.Constant(null, typeof(T))),
                                overwriteOn(variable, current))),
                        Expression.Assign(variable, current)));
            }
            else
            {
                RejectEmptyEnumerable<T>();
                _onNextElements.Add(
                    Expression.IfThen(
                        overwriteOn(variable, current),
                        Expression.Assign(variable, current)));
            }

            return variable;
        }

        private Expression MinOrMax<T>(Expression current, Func<Expression, Expression, Expression> overwriteOn)
        {
            if (AggregationBuilder.PrimitiveComparableTypes.Contains(typeof(T)))
            {
                return MinOrMaxPrimitive<T>(current, overwriteOn);
            }

            var variable = Expression.Variable(typeof(T));
            _variables.Add(variable);
            _onFirstElement.Add(Expression.Assign(variable, current));

            var comparer = GetOrAddComparer<T>();

            if (default(T) == null)
            {
                _onNoElement.Add(Expression.Assign(variable, Expression.Constant(default(T))));
                _onNextElements.Add(
                    Expression.IfThen(
                        Expression.And(
                            Expression.NotEqual(current, Expression.Constant(null, typeof(T))),
                            Expression.Or(
                                Expression.Equal(variable, Expression.Constant(null, typeof(T))),
                                overwriteOn(
                                    ParameterBinder3.BindParametersAndReturnBody(
                                        (Comparer<T> comparer, T variable, T current) =>
                                            comparer.Compare(variable, current),
                                        comparer, variable, current),
                                    Expression.Constant(0)
                                ))),
                        Expression.Assign(variable, current)));
            }
            else
            {
                RejectEmptyEnumerable<T>();
                _onNextElements.Add(
                    Expression.IfThen(
                        overwriteOn(
                            ParameterBinder3.BindParametersAndReturnBody(
                                (Comparer<T> comparer, T variable, T current) =>
                                    comparer.Compare(variable, current),
                                comparer, variable, current),
                            Expression.Constant(0)
                        ),
                        Expression.Assign(variable, current)));
            }

            return variable;
        }

        private void RejectEmptyEnumerable<T>()
        {
            _onNoElement.Clear();
            _onNoElement.Add(Expression.Throw(
                ExpressionUtil.BodyOf(() =>
                    new InvalidOperationException("Can only aggregate non-empty enumerables"))));
        }

        private ParameterExpression GetOrAddComparer<T>()
        {
            var comparer = _variables.FirstOrDefault(
                expression => expression != _current && expression.Type == typeof(Comparer<T>));
            if (comparer != null)
            {
                return comparer;
            }

            comparer = Expression.Variable(typeof(Comparer<T>));
            _variables.Add(comparer);
            _onFirstElement.Add(Expression.Assign(comparer, ExpressionUtil.BodyOf(() => Comparer<T>.Default)));
            return comparer;
        }
    }
}