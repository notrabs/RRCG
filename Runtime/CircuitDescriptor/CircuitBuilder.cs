#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using DeclaredVariable = RRCGBuild.AccessibilityScope.DeclaredVariable;
using PromotedVariable = RRCGBuild.ConditionalContext.PromotedVariable;

namespace RRCGBuild
{
    public class EventFunction : Attribute { }
    public class SharedProperty : Attribute { }
    public class CircuitGraph : Attribute { }

    /// <summary>
    /// A compiled RRCG building class containing parts of a circuit.
    /// </summary>
    public abstract class CircuitLibraryBuilder : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            // A library needs no entry point. Maybe it makes sense to clean up the structure here some day.
            // The CircuitBuilder would make more sense to inherit from CircuitLibraryBuilder
        }
    }

    /// <summary>
    /// A RRCG class for building a complete circuit from an entry point.
    /// </summary>
    public abstract class CircuitBuilder : ChipBuilder
    {
        public abstract void CircuitGraph();

        //
        // Exec Flow Helpers
        //

        public static void StartNewGraph()
        {
            ExecFlow.current = new ExecFlow();
        }

        public static void ClearExec()
        {
            ExecFlow.current.Clear();
        }
        public static void InlineGraph(AlternativeExec graphFn)
        {
            var prevExec = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            graphFn();

            ExecFlow.current = prevExec;
        }

        public static T InlineGraph<T>(Func<T> graphFn)
        {
            var prevExec = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            var result = graphFn();

            ExecFlow.current = prevExec;

            return result;
        }

        public static void Singleton(string key, Action creator)
        {
            if (!Context.current.SingletonChips.ContainsKey(key))
            {
                creator();
                Context.current.SingletonChips.Add(key, null);
            }
        }

        public static T Singleton<T>(string key, Func<T> creator)
        {
            if (!Context.current.SingletonChips.ContainsKey(key))
            {
                Context.current.SingletonChips.Add(key, creator());
            }
            return (T)Context.current.SingletonChips[key];
        }

        //
        // Circuit Board Helpers
        //

        private static object __CircuitBoard(Delegate circuitBoardFn, params dynamic[] parameters)
        {
            return __CircuitBoard(circuitBoardFn.Method.Name, circuitBoardFn, parameters);
        }

        private static object __CircuitBoard(string name, Delegate circuitBoardFn, params dynamic[] parameters)
        {
            var prevContext = Context.current;
            var prevExecFlow = ExecFlow.current;

            var cbContext = new Context();
            prevContext.SubContexts.Add(cbContext);
            cbContext.ParentContext = prevContext;
            Context.current = cbContext;
            ExecFlow.current = new ExecFlow();

            var returnType = circuitBoardFn.GetMethodInfo().ReturnType;

            var isVoid = returnType == typeof(void);
            var isPort = returnType.BaseType == typeof(AnyPort);
            var isTuple = returnType.IsGenericType && returnType.GetGenericTypeDefinition().BaseType.Name.StartsWith("ValueType");

            if (!(isVoid || isPort || isTuple)) throw new Exception("CircuitBoard() only works with port types or tuples!");

            var execPortGroup = 1;
            var dataPortGroup = 2;

            // Construct Inner Context

            In();
            var inNode = Context.lastSpawnedNode;

            ExecFlow.current.Ports.Add(inNode.Port(execPortGroup, 0));

            var inNodePorts = parameters.Select((p, index) =>
            {
                dynamic port = Activator.CreateInstance(p.GetType());
                port.Port = inNode.Port(dataPortGroup, index);
                port.Data = p.Data;
                return port;
            });

            var cbResult = circuitBoardFn.DynamicInvoke(inNodePorts.ToArray());

            var hasExecIn = Context.current.Connections.Any(c => c.isExec && c.From.Node == inNode);
            var hasExecOut = ExecFlow.current.hasAdvanced && ExecFlow.current.Ports.Count() > 0;

            Out();
            var outNode = Context.lastSpawnedNode;

            if (hasExecOut) ExecFlow.current.Advance(Context.current, outNode.Port(execPortGroup, 0), null);

            if (isPort)
            {
                outNode.ConnectInputPort(Context.current, cbResult as AnyPort, outNode.Port(dataPortGroup, 0));
            }
            else if (isTuple)
            {
                var tuple = (ITuple)cbResult;

                for (var i = 0; i < tuple.Length; i++)
                {
                    outNode.ConnectInputPort(Context.current, (AnyPort)tuple[i], outNode.Port(dataPortGroup, i));
                }
            }

            // Set context interface

            cbContext.MetaNewBoard = new List<CBFunction>();

            // this dummy makes sure the CB is rendered correctly in the Circuit Editor
            cbContext.MetaNewBoard.Add(new CBFunction() { Name = "Dummy" });

            var execFunction = new CBFunction() { Name = "Exec" };
            cbContext.MetaNewBoard.Add(execFunction);

            var dataFunction = new CBFunction() { Name = "Data" };
            cbContext.MetaNewBoard.Add(dataFunction);

            if (hasExecIn) execFunction.Inputs.Add(("Exec", typeof(void)));
            if (hasExecOut) execFunction.Outputs.Add(("Exec", typeof(void)));

            int parameterIndex = 0;
            foreach (var parameter in parameters)
            {
                var inputName = circuitBoardFn.Method.GetParameters().ElementAtOrDefault(parameterIndex)?.Name ?? "value0";
                dataFunction.Inputs.Add((inputName, parameter.GetType()));
                parameterIndex++;
            }

            if (isPort)
            {
                dataFunction.Outputs.Add(("result", cbResult.GetType()));
            }
            else if (isTuple)
            {
                var tuple = (ITuple)cbResult;

                var namesAttr = (TupleElementNamesAttribute)circuitBoardFn.Method.ReturnTypeCustomAttributes.GetCustomAttributes(true).FirstOrDefault(attr => attr is TupleElementNamesAttribute);

                for (var i = 0; i < tuple.Length; i++)
                {
                    var outputName = namesAttr?.TransformNames[i] ?? ("value" + i);

                    dataFunction.Outputs.Add((outputName, tuple[i].GetType()));
                }
            }


            // Construct CB

            Context.current = prevContext;
            ExecFlow.current = prevExecFlow;

            ChipBuilder.CircuitBoard();
            var cbNode = Context.lastSpawnedNode;
            cbNode.CircuitBoardId = cbContext.Id.ToString();
            cbNode.Name = Context.current.GetUniqueId("RRCG_" + name);

            if (hasExecIn && hasExecOut) ExecFlow.current.Advance(Context.current, cbNode.Port(execPortGroup, 0), cbNode.Port(execPortGroup, 0));
            else if (hasExecIn) ExecFlow.current.Advance(Context.current, cbNode.Port(execPortGroup, 0), null);
            else if (hasExecOut) ExecFlow.current.Advance(Context.current, null, cbNode.Port(execPortGroup, 0));

            parameterIndex = 0;
            foreach (var parameter in parameters)
            {
                cbNode.ConnectInputPort(Context.current, parameter, cbNode.Port(dataPortGroup, parameterIndex));
                parameterIndex++;
            }

            if (isVoid) return null;
            if (isPort)
            {
                dynamic port = Activator.CreateInstance(cbResult.GetType());
                port.Port = cbNode.Port(dataPortGroup, 0);
                port.Data = (cbResult as AnyPort).Data;
                return port;
            }
            else
            {
                var cbResultTuple = (ITuple)cbResult;
                var cbOutPorts = new List<dynamic>();

                for (var i = 0; i < cbResultTuple.Length; i++)
                {
                    dynamic port = Activator.CreateInstance(cbResultTuple[i].GetType());
                    port.Port = cbNode.Port(dataPortGroup, i);
                    port.Data = (cbResultTuple[i] as AnyPort).Data;
                    cbOutPorts.Add(port);
                }

                return TupleUtils.UnwrapTuple(cbResult.GetType(), cbOutPorts.ToArray());
            }
        }

        public static void CircuitBoard(Action circuitBoardFn) => __CircuitBoard(circuitBoardFn);
        public static T CircuitBoard<T>(Func<T> circuitBoardFn) => (T)__CircuitBoard(circuitBoardFn);
        public static void CircuitBoard<P0>(Action<P0> circuitBoardFn, P0 value0) => __CircuitBoard(circuitBoardFn, value0);
        public static T CircuitBoard<P0, T>(Func<P0, T> circuitBoardFn, P0 value0) => (T)__CircuitBoard(circuitBoardFn, value0);
        public static void CircuitBoard<P0, P1>(Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) => __CircuitBoard(circuitBoardFn, value0, value1);
        public static T CircuitBoard<P0, P1, T>(Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) => (T)__CircuitBoard(circuitBoardFn, value0, value1);

        public static void CircuitBoard(string name, Action circuitBoardFn) => __CircuitBoard(name, circuitBoardFn);
        public static T CircuitBoard<T>(string name, Func<T> circuitBoardFn) => (T)__CircuitBoard(name, circuitBoardFn);
        public static void CircuitBoard<P0>(string name, Action<P0> circuitBoardFn, P0 value0) => __CircuitBoard(name, circuitBoardFn, value0);
        public static T CircuitBoard<P0, T>(string name, Func<P0, T> circuitBoardFn, P0 value0) => (T)__CircuitBoard(name, circuitBoardFn, value0);
        public static void CircuitBoard<P0, P1>(string name, Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) => __CircuitBoard(name, circuitBoardFn, value0, value1);
        public static T CircuitBoard<P0, P1, T>(string name, Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) => (T)__CircuitBoard(name, circuitBoardFn, value0, value1);

        public static void ExistingCircuitBoard(StringPort boardName, AlternativeExec circuitBoardFn)
        {
            var parentContext = Context.current;
            var parentExec = ExecFlow.current;

            Context newContext = new Context() { ParentContext = parentContext, MetaExistingCircuitBoard = boardName.Data };
            parentContext.SubContexts.Add(newContext);

            Context.current = newContext;
            ExecFlow.current = new ExecFlow();

            circuitBoardFn();

            Context.current = parentContext;
            ExecFlow.current = parentExec;
        }

        public static PortType ExistingDataInput<PortType>(StringPort portName)
        {
            return default;
        }
        public static void ExistingDataOutput<PortType>(StringPort portName, PortType value)
        {
        }

        public static void ExistingExecInput(StringPort portName)
        {
        }

        public static void ExistingExecOutput(StringPort portName)
        {
        }

        public void StudioEventReceiver(string eventName)
        {
            CircuitBuilder.Singleton("StudioEventReceiver_" + eventName, () => EventDefinition(eventName));
            EventReceiver(eventName);
        }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room
        /// </summary>
        public static EventDefinition ExistingEvent(string eventName)
        {
            return new EventDefinition(true, eventName);
        }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With one Event parameter.
        /// </summary>
        public static EventDefinition<T0> ExistingEvent<T0>(string eventName)
            where T0 : AnyPort, new()
        {
            return new EventDefinition<T0>(true, eventName);
        }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With two Event parameter.
        /// </summary>
        public static EventDefinition<T0, T1> ExistingEvent<T0, T1>(string eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            return new EventDefinition<T0, T1>(true, eventName);
        }

        //
        // Compilation Helpers
        //

        internal readonly Dictionary<string, dynamic> __RRCG_EVENT_FUNCTIONS = new Dictionary<string, dynamic>();
        internal readonly Dictionary<string, object> __RRCG_EVENT_FUNCTION_RETURNS = new Dictionary<string, object>();
        internal readonly Dictionary<string, dynamic> __RRCG_EVENT_FUNCTIONS_P1 = new Dictionary<string, dynamic>();
        internal readonly Dictionary<string, object> __RRCG_EVENT_FUNCTION_RETURNS_P1 = new Dictionary<string, object>();
        internal readonly Dictionary<string, dynamic> __RRCG_EVENT_FUNCTIONS_P2 = new Dictionary<string, dynamic>();
        internal readonly Dictionary<string, object> __RRCG_EVENT_FUNCTION_RETURNS_P2 = new Dictionary<string, object>();
        internal readonly Dictionary<string, dynamic> __RRCG_EVENT_FUNCTIONS_P3 = new Dictionary<string, dynamic>();
        internal readonly Dictionary<string, object> __RRCG_EVENT_FUNCTION_RETURNS_P3 = new Dictionary<string, object>();

        internal readonly Dictionary<string, dynamic> __RRCG_SHARED_PROPERTIES = new Dictionary<string, dynamic>();

        protected void __DispatchEventFunction(string name, Action fn)
        {
            if (!__RRCG_EVENT_FUNCTIONS.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS[name] = new EventDefinition("EventFunction_" + name);

                InlineGraph(() =>
                {
                    __RRCG_EVENT_FUNCTIONS[name].Receiver();
                    fn();
                });
            }

            __RRCG_EVENT_FUNCTIONS[name].SendLocal();
        }

        protected T __DispatchEventFunction<T>(string name, Func<T> fn)
        {
            if (!__RRCG_EVENT_FUNCTIONS.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS[name] = new EventDefinition("EventFunction_" + name);

                InlineGraph(() =>
                {
                    __RRCG_EVENT_FUNCTIONS[name].Receiver();
                    __RRCG_EVENT_FUNCTION_RETURNS[name] = fn();
                });
            }

            __RRCG_EVENT_FUNCTIONS[name].SendLocal();

            return (T)__RRCG_EVENT_FUNCTION_RETURNS[name];
        }

        protected void __DispatchEventFunction<T0>(string name, Action<T0> fn, T0 param0)
            where T0 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P1.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P1[name] = new EventDefinition<T0>("EventFunction_" + name, "value0");

                InlineGraph(() =>
                {
                    var param0 = __RRCG_EVENT_FUNCTIONS_P1[name].Receiver();
                    fn((T0)param0);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P1[name].SendLocal(param0);
        }

        protected T __DispatchEventFunction<T, T0>(string name, Func<T0, T> fn, T0 param0)
            where T0 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P1.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P1[name] = new EventDefinition<T0>("EventFunction_" + name, "value0");

                InlineGraph(() =>
                {
                    var param0 = __RRCG_EVENT_FUNCTIONS_P1[name].Receiver();
                    __RRCG_EVENT_FUNCTION_RETURNS_P1[name] = fn(param0);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P1[name].SendLocal(param0);

            return (T)__RRCG_EVENT_FUNCTION_RETURNS_P1[name];
        }

        protected void __DispatchEventFunction<T0, T1>(string name, Action<T0, T1> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P2.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P2[name] = new EventDefinition<T0, T1>("EventFunction_" + name, "value0", "value1");

                InlineGraph(() =>
                {
                    var (param0, param1) = ((EventDefinition<T0, T1>)__RRCG_EVENT_FUNCTIONS_P2[name]).Receiver();
                    fn(param0, param1);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P2[name].SendLocal(param0, param1);
        }

        protected T __DispatchEventFunction<T, T0, T1>(string name, Func<T0, T1, T> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P2.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P2[name] = new EventDefinition<T0, T1>("EventFunction_" + name, "value0", "value1");

                InlineGraph(() =>
                {
                    var (param0, param1) = ((EventDefinition<T0, T1>)__RRCG_EVENT_FUNCTIONS_P2[name]).Receiver();
                    __RRCG_EVENT_FUNCTION_RETURNS_P2[name] = fn(param0, param1);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P2[name].SendLocal(param0, param1);

            return (T)__RRCG_EVENT_FUNCTION_RETURNS_P2[name];
        }

        protected void __DispatchEventFunction<T0, T1, T2>(string name, Action<T0, T1, T2> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P3.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P3[name] = new EventDefinition<T0, T1, T2>("EventFunction_" + name, "value0", "value1", "value2");

                InlineGraph(() =>
                {
                    var (param0, param1, param2) = ((EventDefinition<T0, T1, T2>)__RRCG_EVENT_FUNCTIONS_P3[name]).Receiver();
                    fn(param0, param1, param2);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P3[name].SendLocal(param0, param1, param2);
        }

        protected T __DispatchEventFunction<T, T0, T1, T2>(string name, Func<T0, T1, T2, T> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            if (!__RRCG_EVENT_FUNCTIONS_P3.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS_P3[name] = new EventDefinition<T0, T1, T2>("EventFunction_" + name, "value0", "value1", "value2");

                InlineGraph(() =>
                {
                    var (param0, param1, param2) = ((EventDefinition<T0, T1, T2>)__RRCG_EVENT_FUNCTIONS_P3[name]).Receiver();
                    __RRCG_EVENT_FUNCTION_RETURNS_P3[name] = fn(param0, param1, param2);
                });
            }

            __RRCG_EVENT_FUNCTIONS_P3[name].SendLocal(param0, param1, param2);

            return (T)__RRCG_EVENT_FUNCTION_RETURNS_P3[name];
        }

        protected dynamic __DispatchSharedPropertyFunction<T>(string name, Func<T> fn)
        {
            if (!__RRCG_SHARED_PROPERTIES.ContainsKey(name))
            {
                InlineGraph(() =>
                {
                    __RRCG_SHARED_PROPERTIES[name] = fn();
                });
            }

            return __RRCG_SHARED_PROPERTIES[name];
        }

        public static void __BeginReturnScope(string methodName, Type? returnType, string[]? tupleElementNames)
        {
            SemanticStack.current.Push(new ReturnScope(methodName, returnType, tupleElementNames));
        }

        public static dynamic? __EndReturnScope()
        {
            var scope = SemanticStack.current.Pop();
            if (scope is not ReturnScope returnScope)
                throw new Exception("Topmost element of SemanticStack.current was not ReturnScope");

            return returnScope.FinalizeReturns();
        }

        // We use the generics to ensure implicit casting to Port types.
        // The parameterless one does.. that, to avoid duplicate code.
        public static void __Return() => __Return<dynamic>(null!);
        public static void __Return<T>(T data)
        {
            SemanticStackUtils.AllIteratorsNeedManual();

            var returnScope = SemanticStack.current.GetNextScopeWithType<ReturnScope>();
            if (returnScope == null)
                throw new Exception("Could not find ReturnScope in SemanticStack");

            returnScope.AddReturn(data);
        }

        public T __Assign<T>(string identifier, out T variable, Func<T> value)
        {
            // TODO: Now that variable promotions are computed at rewriting time,
            //       maybe this isn't necessary anymore.
            var assignedValue = value();
            variable = assignedValue;

            return assignedValue;
        }

        public void __While(ConditionalContext conditional, Func<BoolPort> condition, bool buildIfAfterBlock, AlternativeExec block)
        {
            // Create While scope
            var whileScope = new WhileScope()
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional
            };

            // Write promoted variables & set their C# state to the output pins
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Evaluate condition now that C# states point to the RR variable outputs
            var conditionResult = condition();

            // Build the If node on a new execution flow
            var prevFlow = ExecFlow.current;
            ExecFlow.current = new();
            If(conditionResult, () => { });
            var ifNode = Context.lastSpawnedNode;

            // If we're building the if before the block, advance execution flow now & add the Then port.
            // Otherwise, just add the Then port to the current execution flow.
            ExecFlow.current = prevFlow;

            if (!buildIfAfterBlock) ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), ifNode.Port(0, 0));
            else ExecFlow.current.Ports.Add(ifNode.Port(0, 0));

            // Now we can push our items onto the SemanticStack
            // and build the loop block.
            SemanticStack.current.Push(conditional);
            SemanticStack.current.Push(whileScope);
            block();

            // Write the promoted variables & re-set C# state to reference RR variables
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // End our semantic scopes
            SemanticStack.current.PopExpectedScope(whileScope);
            SemanticStack.current.PopExpectedScope(conditional);

            // Merge the continue flow into the current execution flow,
            // and loop back to the if node.
            ExecFlow.current.Merge(whileScope.ContinueFlow);
            ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);

            // Finally, add the Else port to the break flow,
            // and continue building nodes from there.
            ExecFlow.current = whileScope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }

        public void __Switch(AnyPort match, AlternativeExec failed, Dictionary<AnyPort, AlternativeExec> branches)
        {
            // TODO: Conditional context for switch statements
            // Create & push our switch scope
            var switchScope = new SwitchScope
            {
                BreakFlow = new ExecFlow()
            };
            SemanticStack.current.Push(switchScope);

            // Build the switch chip & all the branches
            ChipBuilder.ExecutionAnySwitch(match, failed, branches);

            // Merge the break flow back into the current flow
            ExecFlow current = ExecFlow.current;
            current.Merge(switchScope.BreakFlow);

            SemanticStack.current.PopExpectedScope(switchScope);
        }

        public void __Break()
        {
            var breakable = SemanticStack.current.GetNextScopeWithType<SemanticScope.IBreak>();
            if (breakable != null)
                breakable.Break();
        }

        public void __Continue()
        {
            var continuable = SemanticStack.current.GetNextScopeWithType<SemanticScope.IContinue>();
            if (continuable != null)
                continuable.Continue();
        }

        public static StringPort __StringInterpolation(params AnyPort[] ports)
        {
            var stringPorts = new List<StringPort>();
            foreach (var port in ports)
            {
                if (port is StringPort)
                {
                    stringPorts.Add((StringPort)port);
                    continue;
                }

                stringPorts.Add(port.ToString());
            }

            if (stringPorts.Count == 0) return new StringPort { Data = "" };
            if (stringPorts.Count == 1) return stringPorts[0];
            if (stringPorts.All(s => s.IsDataPort)) return string.Join("", stringPorts.Select(s => s.Data));

            return Concat(stringPorts.ToArray());
        }

        public static T __VariableDeclaratorExpression<T>(string identifier, Func<T>? initializer, Func<dynamic> getter, Action<dynamic>? setter)
        {
            // Store in accessibility scope?
            var scope = SemanticStack.current.GetNextScopeWithType<AccessibilityScope>();
            if (scope is AccessibilityScope accessScope)
            {
                // Is there already a variable with the identifier?
                if (!SemanticStackUtils.CanDeclareVariableWithIdentifier(identifier))
                    throw new Exception($"Attempt to declare variable with identifier \"{identifier}\", but there was " +
                                         "already a variable with the same identifier in an enclosing accessibility scope!");

                // Add to current scope
                accessScope.DeclaredVariables[identifier] = new() { Getter = getter, Setter = setter, Type = typeof(T) };
            }

            // Initialize the variable?
            T value = default!;

            if (initializer != null)
            {
                SemanticStack.current.Push(new NamedAssignmentScope { Identifier = identifier });
                value = initializer();
                SemanticStack.current.Pop();
            }

            return value;
        }

        public static void __BeginAccessibilityScope(AccessibilityScope.Kind scopeKind)
        {
            SemanticStack.current.Push(new AccessibilityScope
            {
                PendingGotos = new(),
                PendingLabels = new(),
                DeclaredLabels = new(),
                DeclaredVariables = new(),
                ScopeKind = scopeKind
            });
        }

        public static void __EndAccessibilityScope()
        {
            var scope = SemanticStack.current.Pop();

            if (scope is not AccessibilityScope accessScope)
                throw new Exception("Attempt to end accessibility scope, but topmost element of current SemanticStack was not AccessibilityScope!");

            var parentScope = SemanticStack.current.GetNextScopeWithType<AccessibilityScope>();
            bool canCarry = parentScope != null && accessScope.ScopeKind != AccessibilityScope.Kind.MethodRoot;

            // Attempt to carry pending items into the parent scope, if allowed
            if (accessScope.PendingLabels.Count > 0)
            {
                if (!canCarry)
                    Debug.LogWarning("Accessibility scope had pending labels waiting on execution to advance.");

                parentScope!.PendingLabels.AddRange(accessScope.PendingLabels);
            }

            if (accessScope.PendingGotos.Count > 0)
            {
                if (!canCarry)
                    Debug.LogWarning("Accessibility scope had pending gotos waiting for labels that were never defined " +
                                     "(or had no suitable exec port to advance to)");

                foreach (var kvp in accessScope.PendingGotos)
                {
                    if (!parentScope!.PendingGotos.ContainsKey(kvp.Key))
                        parentScope!.PendingGotos[kvp.Key] = new ExecFlow();

                    parentScope!.PendingGotos[kvp.Key].Merge(kvp.Value);
                }
            }

        }

        public static void __LabelDecl(string labelName)
        {
            // Ensure we're enclosed by a LabelAccessibilityScope
            var scope = SemanticStack.current.GetNextScopeWithType<AccessibilityScope>();
            if (scope is not AccessibilityScope accessScope)
                throw new Exception("Attempt to declare label outside of an AccessibilityScope!");

            // Ensure name isn't already declared
            if (accessScope.DeclaredLabels.ContainsKey(labelName))
                throw new Exception($"Label {labelName} was already defined within the enclosing AccessibilityScope!");

            // Add to pending labels
            accessScope.PendingLabels.Add(labelName);
        }

        public static void __Goto(string labelName)
        {
            // See if this label exists in the current/a parent AccessibilityScope
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not AccessibilityScope accessScope) continue;

                // Any pending gotos for this label?
                if (accessScope.PendingGotos.TryGetValue(labelName, out var flow))
                {
                    // Let's merge in with this pending goto.
                    flow.Merge(ExecFlow.current);
                    ExecFlow.current.Clear();
                    return;
                }

                // Maybe it's already declared?
                if (accessScope.DeclaredLabels.TryGetValue(labelName, out var port))
                {
                    // Advance execution to the port
                    ExecFlow.current.Advance(Context.current, port, null);
                    return;
                }

                // And are we allowed to climb any higher?
                if (accessScope.ScopeKind == AccessibilityScope.Kind.MethodRoot) break;
            }

            // Otherwise, we'll add a pending goto in the current accessibility scope
            var scope = SemanticStack.current.GetNextScopeWithType<AccessibilityScope>();
            if (scope is not AccessibilityScope currAccessScope)
                throw new Exception("Attempt to goto label outside of an AccessibilityScope!");

            if (!currAccessScope.PendingGotos.ContainsKey(labelName))
                currAccessScope.PendingGotos[labelName] = new ExecFlow();

            currAccessScope.PendingGotos[labelName].Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        private static ExecFlow IfBranch(Port fromPort, AlternativeExec branch)
        {
            var branchFlow = new ExecFlow();
            branchFlow.Ports.Add(fromPort);

            ExecFlow.current = branchFlow;
            branch();

            return ExecFlow.current;
        }

        public static void __If(ConditionalContext conditional, Func<BoolPort> condition, AlternativeExec ifBranch, AlternativeExec elseBranch)
        {
            // Create If node
            If(condition(), () => { });
            var ifNode = Context.lastSpawnedNode;

            // Push conditional context
            SemanticStack.current.Push(conditional);

            // Run each branch, writing & resetting promoted variables in-between
            var ifFlow = IfBranch(ifNode.Port(0, 0), ifBranch);
            var finalValuesIf = conditional.PromotedVariables.ToDictionary(kvp => kvp.Value, kvp => kvp.Value.DeclaredVariable.Getter());
            conditional.ResetPromotedVariables(false);

            var elseFlow = IfBranch(ifNode.Port(0, 1), elseBranch);
            var finalValuesElse = conditional.PromotedVariables.ToDictionary(kvp => kvp.Value, kvp => kvp.Value.DeclaredVariable.Getter());

            // Pop the conditional context
            SemanticStack.current.PopExpectedScope(conditional);

            // Now we have a couple cases.
            if (ifFlow.Ports.Count > 0 && elseFlow.Ports.Count > 0)
            {
                // If both exec flows have ports, we write the final values of each
                // promoted variable to their RR variables, on their respective flows
                ExecFlow.current = ifFlow;
                foreach (var kvp in finalValuesIf)
                    kvp.Key.RRVariableValue = kvp.Value;

                ExecFlow.current = elseFlow;
                foreach (var kvp in finalValuesElse)
                    kvp.Key.RRVariableValue = kvp.Value;
            }
            else
            {
                // Otherwise, if one branch has ports, but not the other,
                // we set the C# state of each promoted variable to the
                // final values of the branch that has ports.
                var leastPorts = ifFlow.Ports.Count > elseFlow.Ports.Count
                    ? (elseFlow, finalValuesElse) : (ifFlow, finalValuesIf);

                var mostPorts = ifFlow.Ports.Count > elseFlow.Ports.Count
                    ? (ifFlow, finalValuesIf) : (elseFlow, finalValuesElse);

                if (leastPorts.Item1.Ports.Count <= 0 && mostPorts.Item1.Ports.Count > 0)
                    foreach (var kvp in mostPorts.Item2)
                        if (kvp.Key.DeclaredVariable.Setter != null)
                            kvp.Key.DeclaredVariable.Setter(kvp.Value);
            }

            // If both flows don't have ports, it probably doesn't matter what the
            // c# state of the promoted variables is set to. TODO?

            // Otherwise, now that we've handled the variable promotions,
            // we can now merge the execution flows & continue building nodes.
            ExecFlow.current = ifFlow;
            ExecFlow.current.Merge(elseFlow);
        }

        public ConditionalContext __ConditionalContext(params string[] promotedIdentifiers)
        {
            var conditionalContext = new ConditionalContext() { PromotedVariables = new() };

            // Create promoted variables
            foreach (var identifier in promotedIdentifiers)
            {
                // Is the variable declared & accessible?
                var declaredVariable = SemanticStackUtils.GetDeclaredVariable(identifier, out _);
                if (declaredVariable == null) continue;

                // Is it a port type?
                var variableValue = declaredVariable.Getter();
                var variableType = declaredVariable.Type;
                if (!typeof(AnyPort).IsAssignableFrom(variableType)) continue;

                // Is the variable marked as promoted within the current conditional context?
                var promotedVariables = conditionalContext.PromotedVariables;
                if (promotedVariables.ContainsKey(identifier)) continue;

                // Does it have a variable for promotion we can re-use?
                dynamic? variableForPromotion = declaredVariable.RRVariableForPromotion;
                if (variableForPromotion == null)
                {
                    // Create a new one. Reflection magic!
                    var type = typeof(Variable<>).MakeGenericType(variableType);

                    SemanticStack.current.Push(new NamedAssignmentScope { Identifier = $"Conditional_{identifier}" });
                    variableForPromotion = Activator.CreateInstance(type, new object[] { null });
                    SemanticStack.current.Pop();

                    declaredVariable.RRVariableForPromotion = variableForPromotion;
                }

                // Create promoted variable & add to conditional context
                var promotedVariable = new PromotedVariable() { DeclaredVariable = declaredVariable, ValueBeforePromotion = variableValue };
                conditionalContext.PromotedVariables[identifier] = promotedVariable;
            }

            return conditionalContext;
        }

        public void __ForEach<T>(ConditionalContext conditional, ListPort<T> list, Action<T> body) where T : AnyPort, new()
        {
            // First, create ForEach scope & push onto the semantic stack.
            var scope = new ForEachScope
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional
            };

            SemanticStack.current.Push(scope);
            SemanticStack.current.Push(conditional);

            // Write & re-set promoted variable values
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Build loop body under the assumption we can use the For Each node.
            // We'll swap this out later if we learn this isn't the case (we don't know beforehand)
            InlineGraph(() => ForEach(list, _ => { }));
            var forEachNode = Context.lastSpawnedNode;

            ExecFlow.current.Advance(Context.current, forEachNode.Port(0, 0), forEachNode.Port(0, 0));
            body(new T { Port = forEachNode.Port(0, 1) });

            // End the conditional context
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Now validate execflow continuity from the current back to the "Loop" port
            scope.EnsureContinuityAndCheckDelays(ExecFlow.current, forEachNode.Port(0, 0));

            // Now we can pop our semantic scopes
            SemanticStack.current.PopExpectedScope(conditional);
            SemanticStack.current.PopExpectedScope(scope);

            // If we don't need to build a manual implementation, we can continue building nodes from the Done pin
            if (!scope.NeedsManualImplementation)
            {
                ExecFlow.current.Advance(Context.current, null, forEachNode.Port(0, 2));
                return;
            }

            // Otherwise we need to do a little surgery on the graph,
            // and upgrade (downgrade?) to a manual implementation.
            var prevFlow = ExecFlow.current;
            ExecFlow.current = new();

            // Build index variable
            SemanticStack.current.Push(new NamedAssignmentScope { Identifier = "ForEach_index" });
            var indexVariable = new Variable<IntPort>();
            SemanticStack.current.Pop();

            // Rewire all item connections (& return data) to a List Get Element chip..
            var itemConnections = Context.current.Connections.Where(c => c.From.EquivalentTo(forEachNode.Port(0, 1))).ToList();
            Func<T> getElementPort = () => Singleton($"ForEach_GetElement_{list.PortKey()}_{indexVariable.Value.PortKey()}",
                                                     () => ListGetElement(list, indexVariable.Value));

            // Rewire connections
            if (itemConnections.Count > 0)
                foreach (var conn in itemConnections)
                    conn.From = getElementPort().Port;

            // Modify returns. A bit complicated because we have to handle the tuple case.
            // TODO: Do we have to handle nested tuples? And can we "helper-ify" this to use in For loops?
            var returnScope = SemanticStack.current.GetNextScopeWithType<ReturnScope>();
            Func<dynamic, bool> dataIsForEachItem = (data) => data is T port && port.IsActualPort && port.Port.EquivalentTo(forEachNode.Port(0, 1));

            foreach (var ret in returnScope?.Returns ?? Enumerable.Empty<ReturnScope.Return>())
            {
                var data = ret.Data;

                if (dataIsForEachItem(data)) ret.Data = getElementPort();
                else if (data is ITuple tuple)
                {
                    var result = TupleUtils.WrapTuple(tuple).Select((v) => dataIsForEachItem(v) ? getElementPort() : v);
                    ret.Data = TupleUtils.UnwrapTuple(tuple.GetType(), result.ToArray());
                }
            }

            // Determine exec input source
            var execInputFrom = Context.current.Connections
                .Where(c => c.To.EquivalentTo(forEachNode.Port(0, 0)))
                .Select(c => c.From)
                .FirstOrDefault();

            // Determine exec output destination
            var execOutputTo = Context.current.Connections
                .Where(c => c.From.EquivalentTo(forEachNode.Port(0, 0)))
                .Select(c => c.To)
                .FirstOrDefault();

            // Remove old For Each node & setup ExecFlow
            Context.current.RemoveNode(forEachNode);
            ExecFlow.current.Advance(Context.current, null, execInputFrom);

            // Reset index
            indexVariable.Value = 0;

            // Check condition
            var condition = LessThan(indexVariable.Value, list.Count);
            If(condition, () => { });
            var ifNode = Context.lastSpawnedNode;

            // Wire "Then" to exec output destination
            ExecFlow.current.Advance(Context.current, execOutputTo, null);

            // Jump back onto the loop body exec flow, increment index
            ExecFlow.current = prevFlow;
            indexVariable.Value += 1;

            // Merge continue flow into the current flow, advance back to If node
            ExecFlow.current.Merge(scope.ContinueFlow);
            ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);

            // Continue building nodes from the break flow
            // (with the Else port added in)
            ExecFlow.current = scope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }
    }
}
#nullable disable