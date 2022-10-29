using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionToolkit
{

#region Action & Func having 1 parameters
    public static class InvokeExpression1
    {
        [ReplaceWith(nameof(ParameterBinder1), nameof(ParameterBinder1.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, TResult>(this Expression<Func<T1, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder1.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder1), nameof(ParameterBinder1.BindParameters))]
        public static Action BindAndCompile<T1>(this Expression<Action<T1>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder1.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder1), nameof(ParameterBinder1.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, TResult>(this Expression<Func<T1, TResult>> expression, T1 p1)
        {
            var func = expression.Compile();
            return func(p1);
        }

        [ReplaceWith(nameof(ParameterBinder1), nameof(ParameterBinder1.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1>(this Expression<Action<T1>> expression, T1 p1)
        {
            var action = expression.Compile();
            action(p1);
        }
    }
#endregion

#region Action & Func having 2 parameters
    public static class InvokeExpression2
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParameters))]
        public static Func<T2, TResult> BindAndCompile<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder2.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParameters))]
        public static Action<T2> BindAndCompile<T1, T2>(this Expression<Action<T1, T2>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder2.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder2.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParameters))]
        public static Action BindAndCompile<T1, T2>(this Expression<Action<T1, T2>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder2.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, T1 p1, T2 p2)
        {
            var func = expression.Compile();
            return func(p1, p2);
        }

        [ReplaceWith(nameof(ParameterBinder2), nameof(ParameterBinder2.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2>(this Expression<Action<T1, T2>> expression, T1 p1, T2 p2)
        {
            var action = expression.Compile();
            action(p1, p2);
        }
    }
#endregion

#region Action & Func having 3 parameters
    public static class InvokeExpression3
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Func<T2, T3, TResult> BindAndCompile<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Action<T2, T3> BindAndCompile<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Func<T3, TResult> BindAndCompile<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Action<T3> BindAndCompile<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder3.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var func = expression.Compile();
            return func(p1, p2, p3);
        }

        [ReplaceWith(nameof(ParameterBinder3), nameof(ParameterBinder3.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3>(this Expression<Action<T1, T2, T3>> expression, T1 p1, T2 p2, T3 p3)
        {
            var action = expression.Compile();
            action(p1, p2, p3);
        }
    }
#endregion

#region Action & Func having 4 parameters
    public static class InvokeExpression4
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Func<T2, T3, T4, TResult> BindAndCompile<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Action<T2, T3, T4> BindAndCompile<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Func<T3, T4, TResult> BindAndCompile<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Action<T3, T4> BindAndCompile<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Func<T4, TResult> BindAndCompile<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Action<T4> BindAndCompile<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder4.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4);
        }

        [ReplaceWith(nameof(ParameterBinder4), nameof(ParameterBinder4.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4);
        }
    }
#endregion

#region Action & Func having 5 parameters
    public static class InvokeExpression5
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Func<T2, T3, T4, T5, TResult> BindAndCompile<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Action<T2, T3, T4, T5> BindAndCompile<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Func<T3, T4, T5, TResult> BindAndCompile<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Action<T3, T4, T5> BindAndCompile<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Func<T4, T5, TResult> BindAndCompile<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Action<T4, T5> BindAndCompile<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Func<T5, TResult> BindAndCompile<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Action<T5> BindAndCompile<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder5.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5);
        }

        [ReplaceWith(nameof(ParameterBinder5), nameof(ParameterBinder5.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5);
        }
    }
#endregion

#region Action & Func having 6 parameters
    public static class InvokeExpression6
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action<T2, T3, T4, T5, T6> BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<T3, T4, T5, T6, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action<T3, T4, T5, T6> BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<T4, T5, T6, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action<T4, T5, T6> BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<T5, T6, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action<T5, T6> BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<T6, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action<T6> BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder6.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6);
        }

        [ReplaceWith(nameof(ParameterBinder6), nameof(ParameterBinder6.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6);
        }
    }
#endregion

#region Action & Func having 7 parameters
    public static class InvokeExpression7
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T3, T4, T5, T6, T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T4, T5, T6, T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T4, T5, T6, T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T5, T6, T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T5, T6, T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T6, T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T6, T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<T7, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action<T7> BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder7.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7);
        }

        [ReplaceWith(nameof(ParameterBinder7), nameof(ParameterBinder7.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7);
        }
    }
#endregion

#region Action & Func having 8 parameters
    public static class InvokeExpression8
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T4, T5, T6, T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T5, T6, T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T5, T6, T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T6, T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T6, T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T7, T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T7, T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<T8, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action<T8> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder8.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8);
        }

        [ReplaceWith(nameof(ParameterBinder8), nameof(ParameterBinder8.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8);
        }
    }
#endregion

#region Action & Func having 9 parameters
    public static class InvokeExpression9
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T5, T6, T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T6, T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T6, T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T7, T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T7, T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T8, T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T8, T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<T9, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action<T9> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder9.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        [ReplaceWith(nameof(ParameterBinder9), nameof(ParameterBinder9.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }
    }
#endregion

#region Action & Func having 10 parameters
    public static class InvokeExpression10
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T6, T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T7, T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T7, T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T8, T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T8, T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T9, T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T9, T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<T10, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action<T10> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder10.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        [ReplaceWith(nameof(ParameterBinder10), nameof(ParameterBinder10.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }
    }
#endregion

#region Action & Func having 11 parameters
    public static class InvokeExpression11
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T7, T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T8, T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T8, T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T9, T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T9, T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T10, T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T10, T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<T11, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action<T11> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder11.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        [ReplaceWith(nameof(ParameterBinder11), nameof(ParameterBinder11.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }
    }
#endregion

#region Action & Func having 12 parameters
    public static class InvokeExpression12
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T7, T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T8, T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T8, T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T9, T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T9, T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T10, T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T10, T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T11, T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T11, T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 11 Parameters
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<T12, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action<T12> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder12.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        [ReplaceWith(nameof(ParameterBinder12), nameof(ParameterBinder12.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }
    }
#endregion

#region Action & Func having 13 parameters
    public static class InvokeExpression13
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T7, T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T8, T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T8, T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T9, T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T9, T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T10, T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T10, T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T11, T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T11, T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 11 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T12, T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T12, T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 12 Parameters
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<T13, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action<T13> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder13.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }

        [ReplaceWith(nameof(ParameterBinder13), nameof(ParameterBinder13.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }
    }
#endregion

#region Action & Func having 14 parameters
    public static class InvokeExpression14
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T8, T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T9, T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T9, T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T10, T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T10, T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T11, T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T11, T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 11 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T12, T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T12, T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 12 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T13, T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T13, T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 13 Parameters
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<T14, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action<T14> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder14.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }

        [ReplaceWith(nameof(ParameterBinder14), nameof(ParameterBinder14.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }
    }
#endregion

#region Action & Func having 15 parameters
    public static class InvokeExpression15
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T8, T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T9, T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T10, T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T10, T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T11, T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T11, T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 11 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T12, T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T12, T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 12 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T13, T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T13, T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 13 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T14, T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T14, T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 14 Parameters
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<T15, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action<T15> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var boundExpression = ParameterBinder15.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }

        [ReplaceWith(nameof(ParameterBinder15), nameof(ParameterBinder15.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }
    }
#endregion

#region Action & Func having 16 parameters
    public static class InvokeExpression16
    {

#region Binding first 1 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 2 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 3 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 4 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 5 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 6 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 7 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 8 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T9, T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 9 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T10, T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 10 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T11, T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T11, T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 11 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T12, T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T12, T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 12 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T13, T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T13, T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 13 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T14, T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T14, T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 14 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T15, T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T15, T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14));
            return boundExpression.Compile();
        }
#endregion

#region Binding first 15 Parameters
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<T16, TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action<T16> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15));
            return boundExpression.Compile();
        }
#endregion
        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Func<TResult> BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15), Expression.Constant(p16));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParameters))]
        public static Action BindAndCompile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var boundExpression = ParameterBinder16.BindParameters(expression, Expression.Constant(p1), Expression.Constant(p2), Expression.Constant(p3), Expression.Constant(p4), Expression.Constant(p5), Expression.Constant(p6), Expression.Constant(p7), Expression.Constant(p8), Expression.Constant(p9), Expression.Constant(p10), Expression.Constant(p11), Expression.Constant(p12), Expression.Constant(p13), Expression.Constant(p14), Expression.Constant(p15), Expression.Constant(p16));
            return boundExpression.Compile();
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }

        [ReplaceWith(nameof(ParameterBinder16), nameof(ParameterBinder16.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }
    }
#endregion
}
