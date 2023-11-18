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

        // Scope valid in the expression of an assignment to an identifier. (currently only implemented for declaration intiailizers)
        public struct NamedAssignmentScope
        {
            // The Left-Hand side Identifier of the assignment
            public string Identifier;
        }

        // TODO: It may be worth refactoring this into a generalized "accessibility scope"
        //       that extends beyond labels. We could put variables in here for example.
        //       I'm not doing this now because I don't know what that should look like yet,
        //       let's discuss sometime
        public struct LabelAccessibilityScope
        {
            // Goto statements to labels not yet defined
            // (exec flow contains ports waiting to be advanced
            //  once the label is declared)
            public Dictionary<string, ExecFlow> PendingGotos;

            // Labels that have been defined, but are awaiting
            // a suitable Port to resolve to
            public List<string> PendingLabels;

            // Fully resolved labels, ready to jump to
            public Dictionary<string, Port> DeclaredLabels;

            // While performing a goto, as we iterate over
            // the stack, can we climb any higher than here?
            // (so that we don't have any cross-context gotos)
            public bool GotoCanAccessParent;
        }

        public delegate void ScopedImpl(object scope);

        public T? GetNextScopeWithType<T>() where T : struct
        {
            try
            {
                return (T?)this.First(scope => scope.GetType() == typeof(T));
            }
            catch (Exception) { }
            return null;
        }
    }

    public class SemanticStackUtils
    {
        public static string GetNamedAssignmentName(string defaultName)
        {
            return SemanticStack.current.GetNextScopeWithType<SemanticStack.NamedAssignmentScope>()?.Identifier ?? defaultName;
        }
    }
}
