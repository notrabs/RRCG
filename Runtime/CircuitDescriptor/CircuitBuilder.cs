using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RRCGBuild
{
    public class EventFunction : Attribute { }
    public class SharedProperty : Attribute { }

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

        public static void __Return(ExecFlow returnFlow)
        {
            returnFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        public static void __Return<T>(ExecFlow returnFlow, out T returnData, T expression)
        {
            returnFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();

            returnData = expression;
        }

        public T __Assign<T>(out T variable, T value)
        {
            var assignedValue = value;

            // TODO: If a variable is assigned out of a conditional context, it should either be replaced by a ifvalue/switch or be promoted to a proper Variable

            variable = assignedValue;
            return assignedValue;
        }

        public void __While(BoolPort condition, AlternativeExec block)
        {
            // First, spawn the entry "If" node
            RRCGGenerated.ChipBuilderGen.If(condition, () => { });
            var entryIfNode = Context.lastSpawnedNode;

            // Now we create our "while" scope
            var whileScope = new SemanticStack.WhileScope
            {
                BlockFlow = new ExecFlow(),
                DoneFlow = new ExecFlow(),
                EntryIfNode = entryIfNode
            };

            // Mark Done flow as having advanced
            whileScope.DoneFlow.hasAdvanced = true;

            // Add Then/Else ports to Block/Done flows respectively
            whileScope.BlockFlow.Ports.Add(new Port { Node = entryIfNode });
            whileScope.DoneFlow.Ports.Add(new Port { Node = entryIfNode, Index = 1 });

            // Push scope to the stack, move to the block flow,
            // and build the block contents
            SemanticStack.current.Push(whileScope);

            ExecFlow.current = whileScope.BlockFlow;
            block();

            SemanticStack.current.Pop();

            // Advance the current execution flow back to the entry If node,
            // and continue spawning nodes on the Done execution flow.
            ExecFlow.current.Advance(Context.current, new Port { Node = whileScope.EntryIfNode }, null);
            ExecFlow.current = whileScope.DoneFlow;
        }

        private void __ContinueImpl_While(object scope)
        {
            var whileScope = (SemanticStack.WhileScope)scope;

            // Advance the current execution flow back to the entry If node.
            // Nodes spawned after this will start a new flow.
            ExecFlow.current.Advance(Context.current, new Port { Node = whileScope.EntryIfNode }, null);
        }

        private void __BreakImpl_While(object scope)
        {
            var whileScope = (SemanticStack.WhileScope)scope;

            // Merge the current execution flow into the done flow,
            // then clear the current execution flow.
            // Nodes spawned after this will start a new flow.
            whileScope.DoneFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        public void __DoWhile(BoolPort condition, AlternativeExec block)
        {
            // Build the loopback If chip on a new
            // ExecFlow to preserve the current one.
            ExecFlow prevFlow = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            RRCGGenerated.ChipBuilderGen.If(condition, () => { });
            var loopbackIfNode = Context.lastSpawnedNode;
            ExecFlow.current = prevFlow;

            // Create our DoWhile scope & exec flows
            var doWhileScope = new SemanticStack.DoWhileScope()
            {
                ContinueFlow = new ExecFlow(),
                DoneFlow = new ExecFlow(),
                LoopbackIfNode = loopbackIfNode
            };

            // Mark done flow as advanced, add Then port to the current ExecFlow
            doWhileScope.DoneFlow.hasAdvanced = true;
            ExecFlow.current.Ports.Add(new Port { Node = loopbackIfNode });

            // Push scope to the stack and build the block contents
            SemanticStack.current.Push(doWhileScope);
            block();
            SemanticStack.current.Pop();

            // Merge the continue flow into the current flow,
            // then advance execution to the loopback If node.
            ExecFlow.current.Merge(doWhileScope.ContinueFlow);
            ExecFlow.current.Advance(Context.current, new Port { Node = loopbackIfNode }, null);

            // Move to the "done" flow, add the Else port
            // of the loopback If node, and continue building from there.
            ExecFlow.current = doWhileScope.DoneFlow;
            ExecFlow.current.Ports.Add(new Port { Node = loopbackIfNode, Index = 1 });
        }

        private void __ContinueImpl_DoWhile(object scope)
        {
            var doWhileScope = (SemanticStack.DoWhileScope)scope;

            // Merge the current exec flow into
            // the continue flow, then clear the current flow.
            // Nodes spawned after this will create a new flow.
            doWhileScope.ContinueFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        private void __BreakImpl_DoWhile(object scope)
        {
            var doWhileScope = (SemanticStack.DoWhileScope)scope;

            // Merge the current exec flow into
            // the done flow, then clear the current flow.
            // Nodes spawned after this will create a new flow.
            doWhileScope.DoneFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        public void __Switch(AnyPort match, AlternativeExec failed, Dictionary<AnyPort, AlternativeExec> branches)
        {
            // Create & push our switch scope
            var switchScope = new SemanticStack.SwitchScope()
            {
                BreakFlow = new ExecFlow()
            };
            SemanticStack.current.Push(switchScope);

            // Build the switch chip & all the branches
            ChipBuilder.ExecutionAnySwitch(match, failed, branches);

            // Merge the break flow back into the current flow
            ExecFlow current = ExecFlow.current;
            current.Merge(switchScope.BreakFlow);

            SemanticStack.current.Pop();
        }

        private void __BreakImpl_Switch(object scope)
        {
            // Merge the current exec flow into the break flow,
            // then clear the current exec flow.
            var switchScope = (SemanticStack.SwitchScope)scope;

            switchScope.BreakFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        private void RunSharedKeywordImpl(Dictionary<Type, SemanticStack.ScopedImpl> typeToMethod)
        {
            // Some keywords do not have implementations for some scopes,
            // and as such they actually affect some parent scope.
            // (e.g continue in a switch statement)

            // Iterate over the stack to find a scope we have an implementation for.
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var scope = SemanticStack.current.ElementAt(i);
                var type = scope.GetType();
                if (!typeToMethod.ContainsKey(type))
                    continue;

                typeToMethod[type](scope);
                return;
            }
        }

        public void __Break()
        {
            RunSharedKeywordImpl(new Dictionary<Type, SemanticStack.ScopedImpl>
            {
                { typeof(SemanticStack.WhileScope), __BreakImpl_While },
                { typeof(SemanticStack.SwitchScope), __BreakImpl_Switch },
                { typeof(SemanticStack.DoWhileScope), __BreakImpl_DoWhile }
            });
        }

        public void __Continue()
        {
            RunSharedKeywordImpl(new Dictionary<Type, SemanticStack.ScopedImpl>
            {
                { typeof(SemanticStack.WhileScope), __ContinueImpl_While },
                { typeof(SemanticStack.DoWhileScope), __ContinueImpl_DoWhile }
            });
        }

        public StringPort __StringInterpolation(params AnyPort[] ports)
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

            return Concat(stringPorts.ToArray());
        }

        public static T __VariableDeclaratorExpression<T>(string identifer, Func<T> valueFn)
        {
            SemanticStack.current.Push(new SemanticStack.NamedAssignmentScope { Identifier = identifer });
            var value = valueFn();
            SemanticStack.current.Pop();

            return value;
        }

        public static void __BeginLabelAccessibilityScope(bool canAccessParent)
        {
            SemanticStack.current.Push(new SemanticStack.LabelAccessibilityScope
            {
                PendingGotos = new Dictionary<string, ExecFlow>(),
                PendingLabels = new List<string>(),
                DeclaredLabels = new Dictionary<string, Port>(),
                GotoCanAccessParent = canAccessParent
            });
        }

        public static void __EndLabelAccessibilityScope()
        {
            // Ensure item on the top of the stack is a LabelAccessibilityScope
            var scope = SemanticStack.current.Peek();
            if (scope is not SemanticStack.LabelAccessibilityScope accessScope)
                throw new Exception("Attempt to end label scope, but topmost element of current SemanticStack was not LabelAccessibilityScope!");

            // Remove it from the stack
            SemanticStack.current.Pop();

            var parentScope = SemanticStack.current.GetNextScopeWithType<SemanticStack.LabelAccessibilityScope>();
            bool canCarry = parentScope != null && accessScope.GotoCanAccessParent;

            // Attempt to carry pending items into the parent scope, if allowed
            if (accessScope.PendingLabels.Count > 0)
            {
                if (!canCarry)
                    Debug.LogWarning("Label accessibility scope had pending labels waiting on execution to advance.");

                parentScope.Value.PendingLabels.AddRange(accessScope.PendingLabels);
            }

            if (accessScope.PendingGotos.Count > 0)
            {
                if (!canCarry)
                    Debug.LogWarning("Label accessibility scope had pending gotos waiting for labels that were never defined " +
                                     "(or had no suitable exec port to advance to)");

                foreach (var kvp in accessScope.PendingGotos)
                {
                    if (!parentScope.Value.PendingGotos.ContainsKey(kvp.Key))
                        parentScope.Value.PendingGotos[kvp.Key] = new ExecFlow();

                    parentScope.Value.PendingGotos[kvp.Key].Merge(kvp.Value);
                }
            }

        }

        public static void __LabelDecl(string labelName)
        {
            // Ensure we're enclosed by a LabelAccessibilityScope
            var scope = SemanticStack.current.GetNextScopeWithType<SemanticStack.LabelAccessibilityScope>();
            if (scope is not SemanticStack.LabelAccessibilityScope accessScope)
                throw new Exception("Attempt to declare label outside of a LabelAccessibilityScope!");

            // Ensure name isn't already declared
            if (accessScope.DeclaredLabels.ContainsKey(labelName))
                throw new Exception($"Label {labelName} was already defined within the enclosing LabelAccessibilityScope!");

            // Add to pending labels
            accessScope.PendingLabels.Add(labelName);
        }

        public static void __Goto(string labelName)
        {
            // See if this label exists in the current/a parent LabelAccessibilityScope
            for (int i = 0; i < SemanticStack.current.Count; i++)
            {
                var item = SemanticStack.current.ElementAt(i);
                if (item is not SemanticStack.LabelAccessibilityScope accessScope) continue;

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
                if (!accessScope.GotoCanAccessParent) break;
            }

            // Otherwise, we'll add a pending goto in the current accessibility scope
            var scope = SemanticStack.current.GetNextScopeWithType<SemanticStack.LabelAccessibilityScope>();
            if (scope is not SemanticStack.LabelAccessibilityScope currAccessScope)
                throw new Exception("Attempt to goto label outside of a LabelAccessibilityScope!");

            if (!currAccessScope.PendingGotos.ContainsKey(labelName))
                currAccessScope.PendingGotos[labelName] = new ExecFlow();

            currAccessScope.PendingGotos[labelName].Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }
    }
}
