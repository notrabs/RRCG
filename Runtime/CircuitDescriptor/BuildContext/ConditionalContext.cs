using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class ConditionalContext
    {
        private static Stack<ConditionalContext> stack = new Stack<ConditionalContext>();

        public static ConditionalContext current => stack.Count > 0 ? stack.Peek() : null;

        public static ConditionalContext Push(ConditionalContext conditionalContext)
        {
            stack.Push(conditionalContext);
            return conditionalContext;
        }
        public static ConditionalContext Pop()
        {
            return stack.Pop();
        }
    }

    public class IfConditionalContext : ConditionalContext
    {
        public BoolPort test;
        public bool branch;
        public Node ifExpression;
    }
}