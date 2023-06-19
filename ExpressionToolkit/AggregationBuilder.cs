using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using JetBrains.Annotations;

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
                [NoEnumeration] this IEnumerable<TIn>? example,
                Expression<Func<AggregationBuilder<TIn>, TResult>> aggregation)
        {
            return CreateAggregator(aggregation);
        }

        public static Expression<Func<IEnumerable<TIn>, TResult>> CreateAggregator<TIn, TResult>(
            Expression<Func<AggregationBuilder<TIn>, TResult>> aggregation)
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

            ThrowOnInvalidReplacements(replacements);

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

        private static void ThrowOnInvalidReplacements(Dictionary<Expression, Expression> replacements)
        {
            var invalidReplacements = new List<Exception>();
            foreach (var throwExpression in replacements.Values.OfType<UnaryExpression>()
                         .Where(e => e.NodeType == ExpressionType.Throw))
            {
                try
                {
                    Expression.Lambda<Action>(throwExpression).Compile().Invoke();
                }
                catch (Exception e)
                {
                    invalidReplacements.Add(e);
                }
            }

            if (invalidReplacements.Count == 1)
            {
                ExceptionDispatchInfo.Capture(invalidReplacements.Single()).Throw();
            }
            else if (invalidReplacements.Count > 1)
            {
                throw new AggregateException("You aggregator could not be created", invalidReplacements);
            }
        }

        private class ReplacementCollector<TIn> : ExpressionVisitor
        {
            private readonly ParameterExpression _builderParameter;
            private readonly AggregationBuilder<TIn> _builder;
            private readonly Dictionary<Expression, Expression> _replacements;
            private readonly Dictionary<Expression, IAggregationBuilder> _subBuilders;

            public ReplacementCollector(
                ParameterExpression builderParameter,
                AggregationBuilder<TIn> builder,
                Dictionary<Expression, Expression> replacements)
            {
                _builderParameter = builderParameter;
                _builder = builder;
                _replacements = replacements;
                _subBuilders = new Dictionary<Expression, IAggregationBuilder>();
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                var methodDeclaringType = node.Method.DeclaringType;
                if (!(methodDeclaringType is {IsConstructedGenericType: true}) 
                    || methodDeclaringType.GetGenericTypeDefinition() != typeof(AggregationBuilder<>))
                    return base.VisitMethodCall(node);

                if (node.Object == _builderParameter)
                {
                    Expression.Lambda<Action<AggregationBuilder<TIn>>>(node, _builderParameter)
                        .CompileAndInvoke(_builder);
                    _replacements.Add(node, _builder.ReplaceWith);
                    return node;
                }

                if (node.Object is MethodCallExpression
                    {
                        Method: {DeclaringType: {IsConstructedGenericType: true} declaringType}
                    } objectSelectorExpression
                    && declaringType.GetGenericTypeDefinition() == typeof(AggregationBuilder<>))
                {
                    if (!_subBuilders.TryGetValue(objectSelectorExpression, out var subBuilder))
                    {
                        subBuilder = Expression
                            .Lambda<Func<AggregationBuilder<TIn>, IAggregationBuilder>>(objectSelectorExpression, _builderParameter)
                            .CompileAndInvoke(_builder);
                        _subBuilders.Add(objectSelectorExpression, subBuilder);
                    }

                    var subBuilderParameter = Expression.Parameter(subBuilder.GetType());
                    Expression.Lambda(node.Update(subBuilderParameter, node.Arguments), subBuilderParameter)
                        .Compile().DynamicInvoke(subBuilder);
                    _replacements.Add(node, subBuilder.ReplaceWith);
                    return node;
                }

                throw new InvalidOperationException(
                    $"We currently don't support the way {node} is bound to an AggregationBuilder instance. Please remove any cast or custom instantiation");
            }
        }
    }

    internal interface IAggregationBuilder
    {
        Expression ReplaceWith { get; }
    }

    public class AggregationBuilder<TIn> : IAggregationBuilder
    {
        private readonly List<ParameterExpression> _variables;
        private readonly List<Expression> _preparation;
        private readonly List<Expression> _onNoElement;
        private readonly List<Expression> _onFirstElement;
        private readonly List<Expression> _onNextElements;
        private readonly Expression _current;
        private Expression? _replaceWith;

        internal Expression ReplaceWith
        {
            get => _replaceWith
                   ?? throw new InvalidOperationException("Replacement was not registered. This is likely a bug");
            private set => _replaceWith = value;
        }

        Expression IAggregationBuilder.ReplaceWith => ReplaceWith;

        private bool RejectsEmptyEnumerable
            => _onNoElement.FirstOrDefault() is UnaryExpression {NodeType: ExpressionType.Throw};

        internal AggregationBuilder(List<ParameterExpression> variables,
            List<Expression> preparation,
            List<Expression> onNoElement,
            List<Expression> onFirstElement,
            List<Expression> onNextElements,
            Expression current)
        {
            _variables = variables;
            _preparation = preparation;
            _onNoElement = onNoElement;
            _onFirstElement = onFirstElement;
            _onNextElements = onNextElements;
            _current = current;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Max``1(System.Collections.Generic.IEnumerable{``0})"/>
        public TIn Max()
        {
            ReplaceWith = MinOrMax<TIn>(_current, Expression.LessThan);
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Max``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"/>
        public TResult Max<TResult>(Expression<Func<TIn, TResult>> selector)
        {
            ReplaceWith = MinOrMax<TResult>(selector.BindParametersAndReturnBody(_current), Expression.LessThan);
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Min``1(System.Collections.Generic.IEnumerable{``0})"/>
        public TIn Min()
        {
            ReplaceWith = MinOrMax<TIn>(_current, Expression.GreaterThan);
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Min``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"/>
        public TResult Min<TResult>(Expression<Func<TIn, TResult>> selector)
        {
            ReplaceWith = MinOrMax<TResult>(selector.BindParametersAndReturnBody(_current), Expression.GreaterThan);
            return default!;
        }

        private Expression MinOrMaxPrimitive<T>(Expression current,
            Func<Expression, Expression, Expression> overwriteOn)
        {
            var variable = Variable(typeof(T));
            OnFirstElement(Expression.Assign(variable, current));

            if (default(T) == null)
            {
                OnNoElement(Expression.Assign(variable, Expression.Constant(default(T), typeof(T))));
                OnNextElements(
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
                RejectEmptyEnumerable();
                OnNextElements(
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

            var variable = Variable(typeof(T));
            OnFirstElement(Expression.Assign(variable, current));

            var comparer = GetOrAddComparer<T>();

            if (default(T) == null)
            {
                OnNoElement(Expression.Assign(variable, Expression.Constant(default(T), typeof(T))));
                OnNextElements(
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
                RejectEmptyEnumerable();
                OnNextElements(
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

        private ParameterExpression GetOrAddComparer<T>()
        {
            var comparer = _variables.FirstOrDefault(
                expression => expression != _current && expression.Type == typeof(Comparer<T>));
            if (comparer != null)
            {
                return comparer;
            }

            comparer = Variable(typeof(Comparer<T>));
            OnFirstElement(Expression.Assign(comparer, ExpressionUtil.BodyOf(() => Comparer<T>.Default)));
            return comparer;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Any``1(System.Collections.Generic.IEnumerable{``0})"/>
        public bool Any()
        {
            var variable = Variable(typeof(bool));
            OnNoElement(Expression.Assign(variable, Expression.Constant(false)));
            OnFirstElement(Expression.Assign(variable, Expression.Constant(true)));
            ReplaceWith = variable;
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Any``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})"/>
        public bool Any(Expression<Func<TIn, bool>> predicate)
        {
            ReplaceWith = AnyOrAll( Expression.Constant(false),predicate.BindParametersAndReturnBody(_current), Expression.OrAssign);
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.All``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})"/>
        public bool All(Expression<Func<TIn, bool>> predicate)
        {
            ReplaceWith = AnyOrAll(Expression.Constant(true),predicate.BindParametersAndReturnBody(_current), Expression.AndAssign);
            return default;
        }

        private Expression AnyOrAll(Expression onEmpty, Expression current, Func<Expression, Expression, Expression> assign)
        {
            var variable = Variable(typeof(bool));
            OnNoElement(Expression.Assign(variable, onEmpty));
            OnFirstElement(Expression.Assign(variable, current));
            OnNextElements(assign(variable, current));
            return variable;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Aggregate``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,``0})"/>
        public TIn Aggregate(Expression<Func<TIn, TIn, TIn>> func)
        {
            var variable = Variable(typeof(TIn));
            RejectEmptyEnumerable();
            OnFirstElement(Expression.Assign(variable, _current));
            OnNextElements(Expression.Assign(variable, func.BindParametersAndReturnBody(variable, _current)));
            ReplaceWith = variable;
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Aggregate``2(System.Collections.Generic.IEnumerable{``0},``1,System.Func{``1,``0,``1})"/>
        public TAccumulate Aggregate<TAccumulate>(Expression<Func<TAccumulate>> seed, Expression<Func<TAccumulate, TIn, TAccumulate>> func)
        {
            var variable = Variable(typeof(TAccumulate));
            Preparation(Expression.Assign(variable, seed.Body));
            OnAllElements(Expression.Assign(variable, func.BindParametersAndReturnBody(variable, _current)));
            ReplaceWith = variable;
            return default!;
        }

        public TAccumulate Aggregate<TAccumulate>(Expression<Func<TAccumulate>> seed, Expression<Action<TAccumulate, TIn>> func)
        {
            var variable = Variable(typeof(TAccumulate));
            Preparation(Expression.Assign(variable, seed.Body));
            OnAllElements(func.BindParametersAndReturnBody(variable, _current));
            ReplaceWith = variable;
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Aggregate``3(System.Collections.Generic.IEnumerable{``0},``1,System.Func{``1,``0,``1},System.Func{``1,``2})"/>
        public TResult Aggregate<TAccumulate, TResult>(Expression<Func<TAccumulate>> seed, Expression<Func<TAccumulate, TIn, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> resultSelector)
        {
            var variable = Variable(typeof(TAccumulate));
            Preparation(Expression.Assign(variable, seed.Body));
            OnAllElements(Expression.Assign(variable, func.BindParametersAndReturnBody(variable, _current)));
            ReplaceWith = resultSelector.BindParametersAndReturnBody(variable);
            return default!;
        }

        public TResult Aggregate<TAccumulate, TResult>(Expression<Func<TAccumulate>> seed, Expression<Action<TAccumulate, TIn>> func, Expression<Func<TAccumulate, TResult>> resultSelector)
        {
            var variable = Variable(typeof(TAccumulate));
            Preparation(Expression.Assign(variable, seed.Body));
            OnAllElements( func.BindParametersAndReturnBody(variable, _current));
            ReplaceWith = resultSelector.BindParametersAndReturnBody(variable);
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Count``1(System.Collections.Generic.IEnumerable{``0})"/>
        public int Count()
        {
            var variable = Variable(typeof(int));
            Preparation(Expression.Assign(variable, Expression.Constant(0)));
            OnAllElements(Expression.Assign(variable, Expression.AddChecked(variable, Expression.Constant(1))));
            ReplaceWith = variable;
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Count``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})"/>
        public int Count(Expression<Func<TIn, bool>> predicate)
        {
            var variable = Variable(typeof(int));
            Preparation(Expression.Assign(variable, Expression.Constant(0)));
            OnAllElements(Expression.IfThen(
                predicate.BindParametersAndReturnBody(_current),
                Expression.Assign(variable, Expression.AddChecked(variable, Expression.Constant(1)))));
            ReplaceWith = variable;
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.LongCount``1(System.Collections.Generic.IEnumerable{``0})"/>
        public long LongCount()
        {
            var variable = Variable(typeof(long));
            Preparation(Expression.Assign(variable, Expression.Constant(0L)));
            OnAllElements(Expression.Assign(variable, Expression.AddChecked(variable, Expression.Constant(1L))));
            ReplaceWith = variable;
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.LongCount``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})"/>
        public long LongCount(Expression<Func<TIn, bool>> predicate)
        {
            var variable = Variable(typeof(long));
            Preparation(Expression.Assign(variable, Expression.Constant(0L)));
            OnAllElements(Expression.IfThen(
                predicate.BindParametersAndReturnBody(_current),
                Expression.Assign(variable, Expression.AddChecked(variable, Expression.Constant(1L)))));
            ReplaceWith = variable;
            return default;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.SelectMany``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Collections.Generic.IEnumerable{``1}})"/>
        public List<TResult> SelectMany<TResult>(Expression<Func<TIn, IEnumerable<TResult>>> selector)
        {
            var variable = Variable(typeof(List<TResult>));
            Preparation(
                Expression.Assign(variable,
                    ExpressionUtil.BodyOf(() => new List<TResult>())));
            OnAllElements(
                ParameterBinder2.BindParametersAndReturnBody(
                    (List<TResult> variable, TIn current) => variable.AddRange(selector.CompileAndInvoke(current)),
                    variable,
                    _current));
            ReplaceWith = variable;
            return default!;
        }

        public TIn Sum()
        {
            return Sum<TIn>(_current);
        }

        public T Sum<T>(Expression<Func<TIn, T>> selector)
        {
            return Sum<T>(selector.BindParametersAndReturnBody(_current));
        }

        private T Sum<T>(Expression summand)
        {
            var variable = Variable(typeof(T));
            if (default(T) == null)
            {
                OnNoElement(Expression.Assign(variable,
                    Expression.Constant(default(T), typeof(T))));
                OnFirstElement(Expression.Assign(variable, summand));
                OnNextElements(Expression.Assign(variable,
                    Expression.IfThen(
                        Expression.NotEqual(summand,
                            Expression.Constant(default(T), typeof(T))),
                        Expression.Assign(variable,
                            Expression.IfThenElse(
                                Expression.Equal(variable,
                                    Expression.Constant(default(T), typeof(T))),
                                summand,
                                Expression.AddChecked(variable, summand))))));
            }
            else
            {
                OnNoElement(Expression.Assign(variable,
                    Expression.Constant(default(T), typeof(T))));
                OnFirstElement(Expression.Assign(variable, summand));
                OnNextElements(Expression.Assign(variable,
                    Expression.AddChecked(variable, summand)));
            }

            ReplaceWith = variable;
            return default!;
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.ToArray``1(System.Collections.Generic.IEnumerable{``0})"/>
        public TIn[] ToArray()
        {
            return Aggregate(
                () => new List<TIn>(),
                (list, item) => list.Add(item),
                list => list.ToArray());
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.ToList``1(System.Collections.Generic.IEnumerable{``0})"/>
        public List<TIn> ToList()
        {
            return Aggregate(
                () => new List<TIn>(),
                (list, item) => list.Add(item));
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.ToHashSet``1(System.Collections.Generic.IEnumerable{``0})"/>
        public HashSet<TIn> ToHashSet()
        {
            return Aggregate(
                () => new HashSet<TIn>(),
                (list, item) => list.Add(item));
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.ToHashSet``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0})"/>
        public HashSet<TIn> ToHashSet(IEqualityComparer<TIn> comparer)
        {
            return Aggregate(
                () => new HashSet<TIn>(comparer),
                (list, item) => list.Add(item));
        }

        /// <inheritdoc cref="M:System.Linq.Enumerable.Select``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"/>
        public AggregationBuilder<TResult> Select<TResult>(Expression<Func<TIn, TResult>> selector)
        {
            var variable = Variable(typeof(TResult));
            OnAllElements(Expression.Assign(variable, selector.BindParametersAndReturnBody(_current)));
            ReplaceWith = Expression.Throw(
                ParameterBinder1.BindParametersAndReturnBody(
                    (Expression<Func<TIn, TResult>> selector) => new InvalidOperationException(
                        $"Can not include the AggregationBuilder<{typeof(TResult)}> of Select({selector}) in the result. Please call a method on it"),
                    Expression.Quote(selector)),
                typeof(AggregationBuilder<TResult>));
            return new AggregationBuilder<TResult>(
                _variables,
                _preparation,
                _onNoElement,
                _onFirstElement,
                _onNextElements,
                variable);
        }

        private ParameterExpression Variable(Type type)
        {
            return Variable(Expression.Variable(type));
        }

        private ParameterExpression Variable(ParameterExpression expression)
        {
            _variables.Add(expression);
            return expression;
        }

        private void Preparation(Expression expression)
        {
            _preparation.Add(expression);
        }

        private void OnNoElement(Expression expression)
        {
            if (RejectsEmptyEnumerable)
            {
                return;
            }
            
            _onNoElement.Add(expression);
        }

        private void OnAllElements(Expression expression)
        {
            OnFirstElement(expression);
            OnNextElements(expression);
        }

        private void OnFirstElement(Expression expression)
        {
            _onFirstElement.Add(expression);
        }

        private void OnNextElements(Expression expression)
        {
            _onNextElements.Add(expression);
        }

        private void RejectEmptyEnumerable()
        {
            if (RejectsEmptyEnumerable)
            {
                return;
            }

            _onNoElement.Clear();
            _onNoElement.Add(Expression.Throw(
                ExpressionUtil.BodyOf(() =>
                    new InvalidOperationException("Can only aggregate non-empty enumerables"))));
        }
    }
}