#nullable enable
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
                return (T?)this.First(scope => scope is T);
            }
            catch (Exception) { }
            return default;
        }

        public void PopExpectedScope(SemanticScope scope)
        {
            if (!Pop().Equals(scope))
                throw new Exception("Topmost element was not the expected scope.");
        }
    }

    public class SemanticStackUtils
    {
        public static string GetNamedAssignmentName(string defaultName)
        {
            return SemanticStack.current.GetNextScopeWithType<NamedAssignmentScope>()?.Identifier ?? defaultName;
        }

        public static AccessibilityScope.DeclaredVariable GetDeclaredVariable(string identifier, out AccessibilityScope? accessScope)
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

                // Method declarations within methods are able to access variables in the parenting scope
                // so we don't need to check if we can climb higher.
            }

            accessScope = default;
            return null;
        }

        public static bool CanDeclareVariableWithIdentifier(string identifier)
        {
            // Search up to and including a method root accessibility scope,
            // and if a variable exists with the identifier, return false.

            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not AccessibilityScope scope) continue;

                if (scope.DeclaredVariables.TryGetValue(identifier, out var declVar))
                    return false;

                if (scope.ScopeKind == AccessibilityScope.Kind.MethodRoot) break;
            }

            return true;
        }

        /// <summary>
        /// Marks all iterators on the SemanticStack as requiring a manual implementation.
        /// </summary>
        public static void AllIteratorsNeedManual()
        {
            var query = SemanticStack.current
                .Where(s => s is SemanticScope.BaseIterator)
                .Cast<SemanticScope.BaseIterator>();

            foreach (var iterator in query)
                iterator.NeedsManualImplementation = true;
        }
    }
}
#nullable disable