#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using IPromotedVariable = RRCGBuild.SemanticStack.ConditionalContext.IPromotedVariable;

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

        // The accessibility scope is used to determine what can be accessed where.
        // This currently only manages declared/pending gotos and labels, but in
        // the future we can store variable declarations to address the assignment problem.
        public struct AccessibilityScope
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
        public struct ConditionalContext
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
                public PromotedVariable(dynamic valueBeforePromotion, Variable<T>? rrVariable)
                {
                    ValueBeforePromotion = valueBeforePromotion;
                    RRVariable = rrVariable ?? new();
                }

                public dynamic RRVariableValue { get => RRVariable.Value; set => RRVariable.Value = value; }
                public dynamic ValueBeforePromotion { get; private set; }
                public IPromotedVariable NewWithSameRRVariable(dynamic valueBeforePromotion) => new PromotedVariable<T>(valueBeforePromotion, RRVariable);
            }

            // Variable promotion state
            // Maps identifier -> rr variable, value before promotion
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

        public static (Func<dynamic> Getter, Action<dynamic>? Setter)? GetDeclaredVariable(string identifier, out SemanticStack.AccessibilityScope accessScope)
        {
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not SemanticStack.AccessibilityScope scope) continue;

                if (scope.DeclaredVariables.TryGetValue(identifier, out var declVar))
                {
                    accessScope = scope;
                    return declVar;
                }

                if (!scope.CanAccessParent) break;
            }

            accessScope = default;
            return null;
        }

        public static IPromotedVariable? GetPromotedVariable(string identifier)
        {
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not SemanticStack.ConditionalContext scope) continue;

                if (scope.PromotedVariables.TryGetValue(identifier, out var promotedVar))
                {
                    return promotedVar;
                }
            }

            return null;
        }

        public static int ScopeLevelDifference(object a, object b)
        {
            if (!SemanticStack.current.Contains(a) || !SemanticStack.current.Contains(b))
                throw new Exception("The current SemanticStack must contain both elements.");

            int aIndex = -1, bIndex = -1;
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item.Equals(a)) aIndex = i;
                if (item.Equals(b)) bIndex = i;

                if (aIndex != -1 && bIndex != -1) break;
            }

            return aIndex - bIndex;
        }

        public static Dictionary<string, dynamic> GetDeclaredVariableValues(IEnumerable<string> identifiers)
        {
            var identifiersList = identifiers.ToList();
            var result = new Dictionary<string, dynamic>();

            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not SemanticStack.AccessibilityScope scope) continue;

                foreach (var identifier in identifiersList.ToList()) // shallow copy
                {
                    if (scope.DeclaredVariables.TryGetValue(identifier, out var declVar))
                    {
                        result[identifier] = declVar.Getter();
                        identifiersList.Remove(identifier);
                    }
                }

                if (identifiersList.Count <= 0 || !scope.CanAccessParent) break;
            }

            if (identifiersList.Count > 0)
                throw new Exception("Failed to find one or more declared variables.");

            return result;
        }

        /// <summary>
        /// Given a mapping of identifier to promoted variable,
        /// attempt to reset each C# variable to the pre-promotion value.
        /// </summary>
        public static void ResetPromotedVariables(Dictionary<string, IPromotedVariable> variables)
        {
            foreach (var identifier in variables.Keys)
            {
                var promotedVariable = variables[identifier];
                var declaredVariable = GetDeclaredVariable(identifier, out _);
                if (declaredVariable == null)
                    throw new Exception($"Could not find declared variable with identifier \"{identifier}\"");

                if (declaredVariable.Value.Setter != null)
                    declaredVariable.Value.Setter(promotedVariable.ValueBeforePromotion);
            }
        }

        /// <summary>
        /// Helper method to assign promoted values at the end of each conditional branch.
        /// Also pops the conditional context off the SemanticStack.
        /// </summary>
        /// <param name="context">The conditional context to end.</param>
        /// <param name="branchMap">Map ExecFlow -> identifier -> final value on the branch)</param>
        public static void EndConditionalContext(SemanticStack.ConditionalContext context, Dictionary<ExecFlow, Dictionary<string, dynamic>> branchMap)
        {
            // Build union of all identifiers
            var identifiers = branchMap.SelectMany(v => v.Value.Keys).Distinct().ToList();

            foreach (var kvp in branchMap)
            {
                ExecFlow.current = kvp.Key;
                foreach (var identifier in identifiers)
                {
                    var declaredVariable = SemanticStackUtils.GetDeclaredVariable(identifier, out _);
                    var promotedVariable = SemanticStackUtils.GetPromotedVariable(identifier);

                    if (declaredVariable == null) throw new Exception($"Could not find declared variable with identifier \"{identifier}\"");
                    if (promotedVariable == null) throw new Exception($"Could not find promoted variable with identifier \"{identifier}\"");

                    // TODO: Don't set the RR variable value if we don't need to. But how best to detect this?

                    dynamic value = kvp.Value.ContainsKey(identifier) ? kvp.Value[identifier] : promotedVariable.ValueBeforePromotion;
                    promotedVariable.RRVariableValue = value;

                    if (declaredVariable.Value.Setter != null)
                        declaredVariable.Value.Setter(promotedVariable.RRVariableValue);
                }
            }

            if (!SemanticStack.current.Pop().Equals(context))
                throw new Exception("Expected ConditionalContext at the top of the SemanticStack!");
        }
    }
}
#nullable disable