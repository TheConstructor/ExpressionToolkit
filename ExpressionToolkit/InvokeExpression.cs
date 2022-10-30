using System;
using System.Linq.Expressions;

namespace ExpressionToolkit
{

#region Action & Func having 1 parameters
    public static class InvokeExpression1
    {
        [ReplaceWith(typeof(ParameterBinder1), nameof(ParameterBinder1.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, TResult>(this Expression<Func<T1, TResult>> expression, T1 p1)
        {
            var func = expression.Compile();
            return func(p1);
        }

        [ReplaceWith(typeof(ParameterBinder1), nameof(ParameterBinder1.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder2), nameof(ParameterBinder2.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> expression, T1 p1, T2 p2)
        {
            var func = expression.Compile();
            return func(p1, p2);
        }

        [ReplaceWith(typeof(ParameterBinder2), nameof(ParameterBinder2.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder3), nameof(ParameterBinder3.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> expression, T1 p1, T2 p2, T3 p3)
        {
            var func = expression.Compile();
            return func(p1, p2, p3);
        }

        [ReplaceWith(typeof(ParameterBinder3), nameof(ParameterBinder3.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder4), nameof(ParameterBinder4.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4);
        }

        [ReplaceWith(typeof(ParameterBinder4), nameof(ParameterBinder4.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder5), nameof(ParameterBinder5.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5);
        }

        [ReplaceWith(typeof(ParameterBinder5), nameof(ParameterBinder5.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder6), nameof(ParameterBinder6.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6);
        }

        [ReplaceWith(typeof(ParameterBinder6), nameof(ParameterBinder6.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder7), nameof(ParameterBinder7.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7);
        }

        [ReplaceWith(typeof(ParameterBinder7), nameof(ParameterBinder7.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder8), nameof(ParameterBinder8.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8);
        }

        [ReplaceWith(typeof(ParameterBinder8), nameof(ParameterBinder8.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder9), nameof(ParameterBinder9.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        [ReplaceWith(typeof(ParameterBinder9), nameof(ParameterBinder9.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder10), nameof(ParameterBinder10.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        [ReplaceWith(typeof(ParameterBinder10), nameof(ParameterBinder10.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder11), nameof(ParameterBinder11.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        [ReplaceWith(typeof(ParameterBinder11), nameof(ParameterBinder11.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder12), nameof(ParameterBinder12.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        [ReplaceWith(typeof(ParameterBinder12), nameof(ParameterBinder12.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder13), nameof(ParameterBinder13.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }

        [ReplaceWith(typeof(ParameterBinder13), nameof(ParameterBinder13.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder14), nameof(ParameterBinder14.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }

        [ReplaceWith(typeof(ParameterBinder14), nameof(ParameterBinder14.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder15), nameof(ParameterBinder15.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }

        [ReplaceWith(typeof(ParameterBinder15), nameof(ParameterBinder15.BindParametersAndReturnBody))]
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
        [ReplaceWith(typeof(ParameterBinder16), nameof(ParameterBinder16.BindParametersAndReturnBody))]
        public static TResult CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var func = expression.Compile();
            return func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }

        [ReplaceWith(typeof(ParameterBinder16), nameof(ParameterBinder16.BindParametersAndReturnBody))]
        public static void CompileAndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16)
        {
            var action = expression.Compile();
            action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }
    }
#endregion
}
