#nullable enable
using System.Collections.Generic;
using System;
using DeclaredVariable = RRCGBuild.AccessibilityScope.DeclaredVariable;
using PromotedVariable = RRCGBuild.ConditionalContext.PromotedVariable;
using System.Linq;
using System.Runtime.CompilerServices;
using RRCG;

namespace RRCGBuild
{
    // Base type for semantic scopes.
    public interface SemanticScope
    {
        // Define interfaces for implementing keywords
        // (SemanticScope.IBreak might be more descriptive than just IBreak)
        public interface IBreak : SemanticScope
        {
            public void Break();
        }

        public interface IContinue : SemanticScope
        {
            public void Continue();
        }

        public abstract class BaseIterator : IBreak, IContinue
        {
            // Going with a base class here, because for most
            // iterators the logic will basically be this.

            public Port SourceExec; // Necessary to ensure continuity in Continue/Break
            public ExecFlow BreakFlow = new() { hasAdvanced = true }; // Break out of loop
            public ExecFlow ContinueFlow = new(); // Jump back to the start of the loop
            public ConditionalContext ConditionalContext; // Required to write variable values when breaking/continuing

            public BaseIterator(Port sourceExec, ConditionalContext conditional)
            {
                SourceExec = sourceExec;
                ConditionalContext = conditional;
            }

            // If this is true, the iterator will need to be built
            // with a manual implementation, and cannot be built with
            // the existing For/For Each nodes.
            public bool NeedsManualImplementation;

            public void Break()
            {
                ConditionalContext.WritePromotedVariables();
                EnsureContinuityAndCheckAsync(ExecFlow.current);

                BreakFlow.Merge(ExecFlow.current);
                ExecFlow.current.Clear();
                NeedsManualImplementation = true;
            }

            public void Continue()
            {
                ConditionalContext.WritePromotedVariables();
                EnsureContinuityAndCheckAsync(ExecFlow.current);

                // Note: For CV2-native iterators (For, For Each),
                // continue can just be implemented as clearing the current exec flow.
                // But we still store this flow so we can use it in the manual case.
                ContinueFlow.Merge(ExecFlow.current);
                ExecFlow.current.Clear();
            }

            /// <summary>
            /// Ensures the provided ExecFlow connects back to SourceExec.
            /// Also flags all open iterators on the SemanticStack as requiring a manual implementation if an async exec port is present.
            /// </summary>
            public void EnsureContinuityAndCheckAsync(ExecFlow execFlow)
            {
                // Edge-case: No ports in the exec flow.
                // If you have something like: while (true) { break; }, you can trigger this.
                // TODO: Is this the best way to handle this?
                if (execFlow.Ports.Count <= 0) return;

                var portsToCheck = new Stack<Port>(execFlow.Ports);
                var checkedPorts = new List<Port>();
                bool foundSource = false;

                while (portsToCheck.Count > 0)
                {
                    var currPort = portsToCheck.Pop();
                    var node = currPort.Node;
                    checkedPorts.Add(currPort);

                    if (currPort.EquivalentTo(SourceExec))
                    {
                        foundSource = true;
                        continue; // Don't search behind this node
                    }

                    if (ChipTypeUtils.IsExecPortAsync(currPort))
                        SemanticStackUtils.AllIteratorsNeedManual();

                    var connectedExecPorts = Context.current.Connections
                        .Where(c => c.isExec && c.To.Node == currPort.Node)
                        .Select(c => c.From);

                    foreach (var port in connectedExecPorts)
                        if (!checkedPorts.Contains(port))
                            portsToCheck.Push(port);
                }

                if (!foundSource) throw new Exception("Iterator discontinuity detected -- provided ExecFlow did not connect back to sourceExec!");
            }
        }
    }

    // Actual scope definitions
    public class SwitchScope : SemanticScope.IBreak
    {
        public ExecFlow BreakFlow = new();
        public ConditionalContext ConditionalContext;

        public SwitchScope(ConditionalContext conditional)
        {
            ConditionalContext = conditional;
        }

        public void Break()
        {
            // Write promoted variables
            ConditionalContext.WritePromotedVariables();

            // Merge the current exec flow into the break flow,
            // then clear the current exec flow.
            BreakFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }
    }

    public class WhileScope : SemanticScope.BaseIterator
    {
        // NOTE: For While loops, a manual implementation will always be built
        // because there is no CV2 equivalent.
        public WhileScope(Port sourceExec, ConditionalContext conditional)
            : base(sourceExec, conditional) { }
    }

    public class ForEachScope : SemanticScope.BaseIterator
    {
        public ForEachScope(Port sourceExec, ConditionalContext conditional)
            : base(sourceExec, conditional) { }
    }
    
    public class ForScope : SemanticScope.BaseIterator
    {
        public ForScope(Port sourceExec, ConditionalContext conditional)
            : base(sourceExec, conditional) { }
    }

    // Scope valid in the expression of an assignment to an identifier. (currently only implemented for declaration intiailizers)
    public class NamedAssignmentScope : SemanticScope
    {
        // The Left-Hand side Identifier of the assignment
        public string Identifier;

        public NamedAssignmentScope(string identifier)
        {
            Identifier = identifier;
        }
    }

    // The accessibility scope is used to determine what
    // variables/labels/etc are currently accessible.
    public class AccessibilityScope : SemanticScope
    {
        public enum Kind
        {
            General,
            MethodRoot // root accessibility scope of a method
        }

        public class DeclaredVariable
        {
            public Type Type { get; private set; }
            public Func<dynamic> Getter { get; private set; }
            public Action<dynamic>? Setter { get; private set; }

            // Only set when creating promoted variables in a conditional context.
            // This allows us to make use of the "double-set" prevention when we have
            // two seperate conditional contexts that immediately precede/follow eachother.
            public dynamic? RRVariableForPromotion;

            public DeclaredVariable(Type type, Func<dynamic> getter, Action<dynamic>? setter = null)
            {
                Type = type;
                Getter = getter;
                Setter = setter;
            }
        }

        // Gotos that jump to labels not yet defined
        // (exec flow contains ports waiting to be advanced
        //  once the label is declared)
        public Dictionary<string, ExecFlow> PendingGotos = new();

        // Labels that have been defined, but are awaiting
        // a suitable Port to resolve to
        public List<string> PendingLabels = new();

        // Fully resolved labels, ready to jump to
        public Dictionary<string, Port> DeclaredLabels = new();

        // Variables declared within this scope.
        // Maps identifier name -> getter/setter methods
        public Dictionary<string, DeclaredVariable> DeclaredVariables = new();

        // Scope kind. May have implications on whether "access operations"
        // running under this scope can search up into enclosing accessibility scopes.
        public Kind ScopeKind;

        public AccessibilityScope(Kind kind)
        {
            ScopeKind = kind;
        }
    }

    // Manages promotion of variables in conditional branches
    public class ConditionalContext : SemanticScope
    {
        // TODO: For declared/promoted variables, we end up using dynamic a lot.
        //       It might not be necessary, but is there anything we can do to improve type safety?
        public class PromotedVariable
        {
            public DeclaredVariable DeclaredVariable;
            public dynamic ValueBeforePromotion; // TODO: This name is unclear. We really mean "value before entering this conditional context".
            public dynamic RRVariableValue
            {
                // When creating PromotedVariables in __ConditionalContext,
                // we always ensure the declared variable has an RRVariableForPromotion.
                get => DeclaredVariable.RRVariableForPromotion!.Value;

                set {
                    // Avoid double-setting the variable value by checking if the value
                    // is the variable getter port.

                    if (((AnyPort)value).EquivalentTo(RRVariableValue)) return;
                    DeclaredVariable.RRVariableForPromotion!.Value = value;
                }
            }

            public PromotedVariable(DeclaredVariable declVar, dynamic? valueBeforePromotion = null)
            {
                DeclaredVariable = declVar;
                ValueBeforePromotion = valueBeforePromotion ?? declVar.Getter();
            }
        }

        // Variable promotion state
        public Dictionary<string, PromotedVariable> PromotedVariables = new();

        /// <summary>
        /// Writes the current C# state of each promoted variable to the RR variable on the current exec flow.
        /// </summary>
        public void WritePromotedVariables()
        {
            foreach (var promotedVariable in PromotedVariables.Values)
                promotedVariable.RRVariableValue = promotedVariable.DeclaredVariable.Getter();
        }

        /// <summary>
        /// Resets the C# state of each promoted variable to either
        /// the pre-promotion state, or the RR variable output (if setToVariableValue is set)
        /// </summary>
        public void ResetPromotedVariables(bool setToVariableValue)
        {
            foreach (var promotedVariable in PromotedVariables.Values)
            {
                if (promotedVariable.DeclaredVariable.Setter == null) continue;

                var value = setToVariableValue ? promotedVariable.RRVariableValue : promotedVariable.ValueBeforePromotion;
                promotedVariable.DeclaredVariable.Setter(value);
            }
        }
    }

    public class ReturnScope : SemanticScope
    {
        public Type? ReturnType;
        public string MethodName;
        public string[]? TupleElementNames;
        public List<Return> Returns = new();
        public bool ReturnTypeIsTupleType => ReturnType != null && typeof(ITuple).IsAssignableFrom(ReturnType);

        public class Return
        {
            public ExecFlow ExecFlow;
            public dynamic? Data;

            public Return(ExecFlow execFlow, dynamic? returnData)
            {
                ExecFlow = execFlow;
                Data = returnData;
            }
        }

        public ReturnScope(string methodName, Type? returnType, string[]? tupleElementNames)
        {
            MethodName = methodName;
            ReturnType = returnType;
            TupleElementNames = tupleElementNames;

            int numTupleItems = returnType != null ? returnType.GetGenericArguments().Length : 0;
            if (ReturnTypeIsTupleType && (tupleElementNames == null || tupleElementNames.Length != numTupleItems))
                throw new Exception("Return type was a tuple type, but the number of " +
                                    "provided tuple element names didn't match!");
        }

        public void AddReturn(dynamic? data)
        {
            // ValueTuple doesn't support '=='.
            // We just want to check if it's null, so this'll do
            var dataIsNull = Object.Equals(data, null);

            // Ensure return type
            if (ReturnType == null && !dataIsNull)
                throw new Exception("Return scope had void return type, but return data was provided!");

            if (ReturnType != null)
            {
                if (dataIsNull)
                    throw new Exception("Return scope had non-void return type, but no return data was provided!");

                if (!ReturnType.IsAssignableFrom(data!.GetType()))
                    throw new Exception("The return data type was not compatible with the ReturnScope return type!");
            }

            // Copy the current exec flow, store it with the data
            var returnFlow = new ExecFlow();
            returnFlow.Merge(ExecFlow.current);
            Returns.Add(new Return(returnFlow, data));

            // Clear the current exec flow & we're done
            ExecFlow.current.Clear();
        }

        /// <summary>
        /// Searches all returns for occurances of the targetPort, and replaces it with the result of newPort.
        /// newPort is a delegate so that you can avoid spawning nodes when there are no occurances.
        /// </summary>
        public void ReplacePort(Port targetPort, Func<AnyPort> newPort)
        {
            Func<dynamic, bool> dataIsTargetPort = (data) => data is AnyPort port && port.IsActualPort && port.Port.EquivalentTo(targetPort);

            foreach (var ret in Returns)
            {
                if (dataIsTargetPort(ret.Data)) ret.Data = newPort();
                else if (ret.Data is ITuple tuple)
                {
                    var result = TupleUtils.WrapTuple(tuple).Select((v) => dataIsTargetPort(v) ? newPort() : v);
                    ret.Data = TupleUtils.UnwrapTuple(tuple.GetType(), result.ToArray());
                }
            }
        }

        bool ReturnTypeIsPortCompatible()
        {
            if (ReturnTypeIsTupleType)
                return ReturnType!.GetGenericArguments().All(t => typeof(AnyPort).IsAssignableFrom(t));
            else
                return ReturnType != null && typeof(AnyPort).IsAssignableFrom(ReturnType);
        }

        public dynamic? FinalizeReturns()
        {
            // If we have only one return, or the type isn't supported,
            // merge exec flows and just return the single port (or emulate old behaviour)
            if (Returns.Count <= 1 || ReturnType == null || !ReturnTypeIsPortCompatible())
            {
                foreach (var ret in Returns)
                    ExecFlow.current.Merge(ret.ExecFlow);

                return Returns.LastOrDefault()?.Data;
            }

            // Otherwise we construct an event to serve
            // as a "merge point" for the return data.
            // Start by creating the list of port definitions..
            var ports = new List<(StringPort Name, Type Type)>();
            if (ReturnTypeIsTupleType)
            {
                var types = ReturnType.GetGenericArguments();
                for (int i = 0; i < types.Length; i++)
                    ports.Add((TupleElementNames![i], types[i]));
            }
            else ports.Add(("result", ReturnType));

            // Now we can create the event definition from those
            var returnEvent = new DynamicEventDefinition($"Return_{MethodName}", ports.ToArray());

            // Jump to each return location and use our
            // new event to cache the return data
            var returnFlow = ExecFlow.current;
            foreach (var ret in Returns)
            {
                ExecFlow.current = ret.ExecFlow;

                // Build list of ports to connect.
                // C# doesn't recognize dynamic[] as being an enumerable,
                // so we cast directly to use the Cast<> extension.
                AnyPort[] dataPorts = !ReturnTypeIsTupleType ? new AnyPort[] { ret.Data! }
                    : ((IEnumerable<dynamic>)TupleUtils.WrapTuple(ret.Data)).Cast<AnyPort>().ToArray();

                // Build event sender & merge into return flow
                returnEvent.SendLocal(dataPorts);
                returnFlow.Merge(ExecFlow.current);
            }

            // Receive the new event
            var cachePorts = CircuitBuilder.InlineGraph(() => returnEvent.Receiver());

            // Return the first port or a tuple as necessary
            ExecFlow.current = returnFlow;
            return !ReturnTypeIsTupleType ? cachePorts.FirstOrDefault() : TupleUtils.UnwrapTuple(ReturnType, cachePorts.ToArray());
        }
    }
}
#nullable disable