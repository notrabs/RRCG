using RRCGBuild;
using System.Collections.Generic;
using System;

namespace RRCGBuild.SemanticScopes
{
    // Base class for semantic scopes.
    // Only serves to give them a common type.
    public class SemanticScope { }

    public class SwitchScope : SemanticScope
    {
        public ExecFlow BreakFlow;
    }

    public class WhileScope : SemanticScope
    {
        public ExecFlow BlockFlow; // Exec flow of the while loop body. Will cycle back to entry "If" node.
        public ExecFlow DoneFlow; // Exec flow for when the loop is finished/break is invoked.
        public Node EntryIfNode;
    }

    public class DoWhileScope : SemanticScope
    {
        public ExecFlow ContinueFlow; // Will jump to the input exec of the loopback "If" node
        public ExecFlow DoneFlow; // Exec flow for when the loop is finished/break is invoked.
        public Node LoopbackIfNode;
    }

    // Scope valid in the expression of an assignment to an identifier. (currently only implemented for declaration intiailizers)
    public class NamedAssignmentScope : SemanticScope
    {
        // The Left-Hand side Identifier of the assignment
        public string Identifier;
    }

    // The accessibility scope is used to determine what can be accessed where.
    // This currently only manages declared/pending gotos and labels, but in
    // the future we can store variable declarations to address the assignment problem.
    public class AccessibilityScope : SemanticScope
    {
        // Gotos that jump to labels not yet defined
        // (exec flow contains ports waiting to be advanced
        //  once the label is declared)
        public Dictionary<string, ExecFlow> PendingGotos;

        // Labels that have been defined, but are awaiting
        // a suitable Port to resolve to
        public List<string> PendingLabels;

        // Fully resolved labels, ready to jump to
        public Dictionary<string, Port> DeclaredLabels;

        // Variables declared within this scope.
        // Maps identifier name -> getter/setter methods
        public Dictionary<string, (Func<dynamic> Getter, Action<dynamic>? Setter)> DeclaredVariables;

        // Can "access operations" running under this scope
        // search up into enclosing accessibility scopes?
        public bool CanAccessParent;
    }

    // Manages promotion of variables in conditional branches
    public class ConditionalContext : SemanticScope
    {
        public interface IPromotedVariable
        {
            public dynamic RRVariableValue { get; set; }
            public dynamic ValueBeforePromotion { get; }
            public IPromotedVariable NewWithSameRRVariable(dynamic valueBeforePromotion);
        }

        public class PromotedVariable<T> : IPromotedVariable where T : AnyPort, new()
        {
            private Variable<T> RRVariable;
            public PromotedVariable(string identifier, dynamic valueBeforePromotion, Variable<T>? rrVariable)
            {
                ValueBeforePromotion = valueBeforePromotion;

                SemanticStack.current.Push(new NamedAssignmentScope { Identifier = $"Conditional_{identifier}" });
                RRVariable = rrVariable ?? new();
                SemanticStack.current.Pop();
            }

            public dynamic RRVariableValue { get => RRVariable.Value; set => RRVariable.Value = value; }
            public dynamic ValueBeforePromotion { get; private set; }
            public IPromotedVariable NewWithSameRRVariable(dynamic valueBeforePromotion) => new PromotedVariable<T>("", valueBeforePromotion, RRVariable);
        }

        // Variable promotion state
        public Dictionary<string, IPromotedVariable> PromotedVariables;

        // Should the initial assignment reference the RR variable value pin?
        public bool InitialAssignmentsReferenceRRVariable;

        public void MergePromotionsFrom(ConditionalContext b)
        {
            foreach (var identifier in b.PromotedVariables.Keys)
            {
                if (PromotedVariables.ContainsKey(identifier)) continue;
                PromotedVariables[identifier] = b.PromotedVariables[identifier];
            }
        }
    }
}