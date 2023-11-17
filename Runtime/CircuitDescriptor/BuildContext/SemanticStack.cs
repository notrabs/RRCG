using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class SemanticStack : Stack<object>
    {
        // In this stack we store all semantic information that leads down to
        // the current runtime environment.
        // E.g this allows some keywords (break, continue) to perform different tasks
        // depending on enclosing scopes or variables to know their assigned names in the source.
        public static SemanticStack current;

        public struct SwitchScope
        {
            public ExecFlow BreakFlow;
        }

        public struct WhileScope
        {
            public ExecFlow BlockFlow; // Exec flow of the while loop body. Will cycle back to entry "If" node.
            public ExecFlow DoneFlow; // Exec flow for when the loop is finished/break is invoked.
            public Node EntryIfNode;
        }

        public struct DoWhileScope
        {
            public ExecFlow ContinueFlow; // Will jump to the input exec of the loopback "If" node
            public ExecFlow DoneFlow; // Exec flow for when the loop is finished/break is invoked.
            public Node LoopbackIfNode;
        }

        public delegate void ScopedImpl(object scope);


        public T GetTopmostScopeWithType<T>()
        {
            object scope = this.Peek();
            if (scope.GetType() == typeof(T))
                return (T)scope;

            throw new Exception($"Topmost semantic scope type was not \"${typeof(T)}\"!");
        }

        public T GetNextScopeWithType<T>()
        {
            return (T) this.FirstOrDefault(scope => scope.GetType() == typeof(T));
        }
    }
}
