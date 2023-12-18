﻿#nullable enable
using RRCGBuild.SemanticScopes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class SemanticStack : Stack<SemanticScope>
    {
        // In this stack we store all semantic information that leads down to
        // the current runtime environment.
        // E.g this allows some keywords (break, continue) to perform different tasks
        // depending on enclosing scopes or variables to know their assigned names in the source.
        public static SemanticStack current;

        public delegate void ScopedImpl(SemanticScope scope);

        public T? GetNextScopeWithType<T>() where T : SemanticScope
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
            return SemanticStack.current.GetNextScopeWithType<NamedAssignmentScope>()?.Identifier ?? defaultName;
        }

        public static (Func<dynamic> Getter, Action<dynamic>? Setter)? GetDeclaredVariable(string identifier, out AccessibilityScope? accessScope)
        {
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not AccessibilityScope scope) continue;

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

        public static ConditionalContext.IPromotedVariable? GetPromotedVariable(string identifier)
        {
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not ConditionalContext scope) continue;

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
                if (item is not AccessibilityScope scope) continue;

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
        public static void ResetPromotedVariables(Dictionary<string, ConditionalContext.IPromotedVariable> variables)
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
        public static void EndConditionalContext(ConditionalContext context, Dictionary<ExecFlow, Dictionary<string, dynamic>> branchMap)
        {
            var prevFlow = ExecFlow.current;

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

                    // Do we need to set the value here?
                    if (kvp.Value.ContainsKey(identifier) && ((AnyPort)kvp.Value[identifier]).EquivalentTo(promotedVariable.RRVariableValue))
                        continue;

                    dynamic value = kvp.Value.ContainsKey(identifier) ? kvp.Value[identifier] : promotedVariable.ValueBeforePromotion;
                    promotedVariable.RRVariableValue = value;

                    if (declaredVariable.Value.Setter != null)
                        declaredVariable.Value.Setter(promotedVariable.RRVariableValue);
                }
            }

            if (!SemanticStack.current.Pop().Equals(context))
                throw new Exception("Expected ConditionalContext at the top of the SemanticStack!");

            // If we have a parenting conditional context, merge promotions into it
            var parentConditional = SemanticStack.current.GetNextScopeWithType<ConditionalContext>();
            if (parentConditional != null)
                parentConditional.Value!.MergePromotionsFrom(context);

            ExecFlow.current = prevFlow;
        }
    }
}
#nullable disable