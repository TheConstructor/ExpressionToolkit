using System;

namespace ExpressionToolkit
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ReplaceWith : Attribute
    {
        public string TypeName { get; }
        public string MemberName { get; }

        public ReplaceWith(string memberName)
            : this(null, memberName)
        {
        }

        public ReplaceWith(string typeName, string memberName)
        {
            TypeName = typeName;
            MemberName = memberName;
        }
    }
}