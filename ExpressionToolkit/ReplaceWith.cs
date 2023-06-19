using System;

namespace ExpressionToolkit
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class ReplaceWith : Attribute
    {
        public Type? Container { get; }
        public string MemberName { get; }

        public ReplaceWith(string memberName)
            : this(null, memberName)
        {
        }

        public ReplaceWith(Type? container, string memberName)
        {
            Container = container;
            MemberName = memberName;
        }
    }
}