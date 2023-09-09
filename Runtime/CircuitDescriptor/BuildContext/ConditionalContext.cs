using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public abstract class ConditionalContext
    {
        private static Stack<ConditionalContext> stack = new Stack<ConditionalContext>();

        public static ConditionalContext current => stack.Count > 0 ? stack.Peek() : null;

        protected ConditionalContext parent;

        public static T Push<T>(T conditionalContext) where T : ConditionalContext
        {
            conditionalContext.parent = current;
            stack.Push(conditionalContext);
            return conditionalContext;
        }
        public static ConditionalContext Pop()
        {
            return stack.Pop();
        }

        public static void Clear()
        {
            stack.Clear();
        }

        public abstract T ConnectValuePort<T>(T value) where T : AnyPort, new();
    }

    public class RootConditionalContext : ConditionalContext
    {
        public override T ConnectValuePort<T>(T value)
        {
            return new T { Port = new Port { } };
        }
    }

    public class IfConditionalContext : ConditionalContext
    {
        public BoolPort test;
        public bool currentBranch;

        public override T ConnectValuePort<T>(T value)
        {
            if (parent == null)
            {

            }

            if (value.Port == null || value.Port.Node.MetaConditionalContext != this)
            {

            }

            return new T { Port = new Port() { } };
        }
    }
}