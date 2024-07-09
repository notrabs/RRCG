#nullable enable
using RRCG;
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
    public class Variable : Attribute { }
    public class SyncedVariable : Attribute { }
    public class CloudVariable : Attribute
    {
        public CloudVariable(params string[] names) { }
    }

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

        public static void StudioEventReceiver(string eventName)
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

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With three Event parameter.
        /// </summary>
        public static EventDefinition<T0, T1, T2> ExistingEvent<T0, T1, T2>(string eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            return new EventDefinition<T0, T1, T2>(true, eventName);
        }

        /// <summary>
        /// Allows you to access an existing Data Table in the room.
        /// You must supply the column names as they appear in-game.
        /// </summary>
        public static DataTable<T0> ExistingDataTable<T0>(string name, string column0Name)
            where T0 : AnyPort, new()
        {
            return new DataTable<T0>(true, name, column0Name);
        }

        /// <inheritdoc cref="ExistingDataTable{T0}(string, string)"/>
        public static DataTable<T0, T1> ExistingDataTable<T0, T1>(string name, string column0Name, string column1Name)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            return new DataTable<T0, T1>(true, name, column0Name, column1Name);
        }

        /// <inheritdoc cref="ExistingDataTable{T0}(string, string)"/>
        public static DataTable<T0, T1, T2> ExistingDataTable<T0, T1, T2>(string name, string column0Name, string column1Name, string column2Name)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            return new DataTable<T0, T1, T2>(true, name, column0Name, column1Name, column2Name);
        }

        //
        // Compilation Helpers
        //

        #region Deprecated Dispatching Logic
        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction(string name, Action fn) => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn);


        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T>(string name, Func<T> fn) => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0>(string name, Action<T0> fn, T0 param0)
            where T0 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0);


        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0>(string name, Func<T0, T> fn, T0 param0)
            where T0 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1>(string name, Action<T0, T1> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1>(string name, Func<T0, T1, T> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2>(string name, Action<T0, T1, T2> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2>(string name, Func<T0, T1, T2, T> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2, T3>(string name, Action<T0, T1, T2, T3> fn, T0 param0, T1 param1, T2 param2, T3 param3)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2, T3>(string name, Func<T0, T1, T2, T3, T> fn, T0 param0, T1 param1, T2 param2, T3 param3)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2, T3, T4>(string name, Action<T0, T1, T2, T3, T4> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2, T3, T4>(string name, Func<T0, T1, T2, T3, T4, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2, T3, T4, T5>(string name, Action<T0, T1, T2, T3, T4, T5> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2, T3, T4, T5>(string name, Func<T0, T1, T2, T3, T4, T5, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2, T3, T4, T5, T6>(string name, Action<T0, T1, T2, T3, T4, T5, T6> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5, param6);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2, T3, T4, T5, T6>(string name, Func<T0, T1, T2, T3, T4, T5, T6, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5, param6);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected void __DispatchEventFunction<T0, T1, T2, T3, T4, T5, T6, T7>(string name, Action<T0, T1, T2, T3, T4, T5, T6, T7> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5, param6, param7);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected T __DispatchEventFunction<T, T0, T1, T2, T3, T4, T5, T6, T7>(string name, Func<T0, T1, T2, T3, T4, T5, T6, T7, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
        => SpecialMethodsDispatcher.current.DispatchEventFunction(this, name, fn, param0, param1, param2, param3, param4, param5, param6, param7);

        [Obsolete("Dispatching logic has moved to SpecialMethodsDispatcher. Please recompile your circuit descriptor.")]
        protected dynamic __DispatchSharedPropertyFunction<T>(string name, Func<T> fn)
        {
            return SpecialMethodsDispatcher.current.DispatchSharedPropertyFunction<T>(this, fn)!;
        }
        #endregion

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

        public static T __Assign<T>(string identifier, out T variable, Func<T> value)
        {
            // TODO: Now that variable promotions are computed at rewriting time,
            //       maybe this isn't necessary anymore.
            var assignedValue = value();
            variable = assignedValue;

            return assignedValue;
        }

        public static void __While(ConditionalContext conditional, Func<BoolPort> condition, bool buildIfAfterBlock, AlternativeExec block)
        {
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

            // Now we can create & push a WhileScope
            // onto the SemanticStack and build the loop block.
            var whileScope = new WhileScope()
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional,
                SourceExec = ifNode.Port(0, 0)
            };

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
            // ensure continuity, and loop back to the if node.
            ExecFlow.current.Merge(whileScope.ContinueFlow);
            whileScope.EnsureContinuityAndCheckAsync(ExecFlow.current);
            ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);

            // Finally, add the Else port to the break flow,
            // and continue building nodes from there.
            ExecFlow.current = whileScope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }

        public static void __Switch(ConditionalContext conditional, Func<AnyPort> match, AlternativeExec failed, Dictionary<AnyPort, AlternativeExec> branches)
        {
            // Push our semantic scopes
            var switchScope = new SwitchScope
            {
                BreakFlow = new ExecFlow(),
                ConditionalContext = conditional
            };
            SemanticStack.current.Push(conditional);
            SemanticStack.current.Push(switchScope);

            // Write promoted variables & set their C# state to
            // reference their RR variables before building the Switch
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Build the switch chip & all the branches
            ChipBuilder.ExecutionAnySwitch(match(), failed, branches, conditional);

            // Merge the break flow back into the current flow
            ExecFlow current = ExecFlow.current;
            current.Merge(switchScope.BreakFlow);

            SemanticStack.current.PopExpectedScope(switchScope);
            SemanticStack.current.PopExpectedScope(conditional);
        }

        public static void __Break()
        {
            var breakable = SemanticStack.current.GetNextScopeWithType<SemanticScope.IBreak>();
            if (breakable != null)
                breakable.Break();
        }

        public static void __Continue()
        {
            var continuable = SemanticStack.current.GetNextScopeWithType<SemanticScope.IContinue>();
            if (continuable != null)
                continuable.Continue();
        }

        public static StringPort __StringInterpolation(params object[] values)
        {
            var stringPorts = new List<StringPort>();
            foreach (var value in values)
            {
                var port = PortConversionUtils.ToAnyPort(value);
                if (port is StringPort stringPort)
                {
                    stringPorts.Add(stringPort);
                    continue;
                }

                stringPorts.Add(port.ToString());
            }

            if (stringPorts.Count == 0) return new StringPort { Data = "" };
            if (stringPorts.Count == 1) return stringPorts[0];
            if (stringPorts.All(s => s.IsDataPort)) return string.Join("", stringPorts.Select(s => s.Data));

            return Concat(stringPorts.ToArray());
        }

        public static T __VariableDeclaratorExpression<T>(string identifier, Func<T>? initializer, Func<T> getter, Action<T>? setter)
        {
            // Store in accessibility scope?
            var scope = SemanticStack.current.GetNextScopeWithType<AccessibilityScope>();
            if (scope is AccessibilityScope accessScope)
            {
                // Is there already a variable with the identifier?
                if (!SemanticStackUtils.CanDeclareVariableWithIdentifier(identifier))
                    throw new Exception($"Attempt to declare variable with identifier \"{identifier}\", but there was " +
                                         "already a variable with the same identifier in an enclosing accessibility scope!");

                // In the case of method parameters, the rewriter may not have easy access to the type information to write
                // as the generic parameters. To aid in this, we can use the getter/setter/initializer lambdas to help C# resolve the type.
                // However, we need the getters/setters to work with the dynamic type.
                // To resolve this we just wrap the methods, but maybe there's a better way to do this?
                Func<dynamic> dynamicGetter = () => getter()!;
                Action<dynamic>? dynamicSetter = setter != null ? (v) => setter(v) : null;

                // Add to current scope
                accessScope.DeclaredVariables[identifier] = new() { Getter = dynamicGetter, Setter = dynamicSetter, Type = typeof(T) };
            }

            // Initialize the variable?
            T value = default!;

            if (initializer != null)
            {
                var assignmentScope = new NamedAssignmentScope { Identifier = identifier };
                SemanticStack.current.Push(assignmentScope);
                value = initializer();
                SemanticStack.current.PopExpectedScope(assignmentScope);
            }

            return value;
        }

        public static T __NamedAssignment<T>(string identifier, Func<T> initializer)
        {
            // This method is purely to push/pop a named assignment scope to the SemanticStack,
            // and does not interface with AccessibilityScopes.
            var scope = new NamedAssignmentScope { Identifier = identifier };

            SemanticStack.current.Push(scope);
            T value = initializer();
            SemanticStack.current.PopExpectedScope(scope);

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
                if (canCarry)
                    parentScope!.PendingLabels.AddRange(accessScope.PendingLabels);
                else
                    Debug.LogWarning("Accessibility scope had pending labels waiting on execution to advance.");
            }

            if (accessScope.PendingGotos.Count > 0)
            {
                if (canCarry)
                    foreach (var kvp in accessScope.PendingGotos)
                    {
                        if (!parentScope!.PendingGotos.ContainsKey(kvp.Key))
                            parentScope!.PendingGotos[kvp.Key] = new ExecFlow();

                        parentScope!.PendingGotos[kvp.Key].Merge(kvp.Value);
                    }
                else
                    Debug.LogWarning("Accessibility scope had pending gotos waiting for labels that were never defined " +
                                     "(or had no suitable exec port to advance to)");
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
            // If we're within a SwitchScope and we're jumping to
            // a switch label, write promoted variables beforehand
            if (labelName.StartsWith("rrcg_switch_case_label") &&
                SemanticStack.current.GetNextScopeWithType<SwitchScope>() is SwitchScope swScope)
                swScope.ConditionalContext.WritePromotedVariables();

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

                // Then set their C# state to refer to the variable outputs
                conditional.ResetPromotedVariables(true);
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

        public static ConditionalContext __ConditionalContext(params string[] promotedIdentifiers)
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

        public static void __ForEach<T>(ConditionalContext conditional, ListPort<T> list, Action<T> body) where T : AnyPort, new()
        {
            // First, write & re-set promoted variable values
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Build loop body under the assumption we can use the For Each node.
            // We'll swap this out later if we learn this isn't the case (we don't know beforehand)
            InlineGraph(() => ForEach(list, _ => { }));
            var forEachNode = Context.lastSpawnedNode;
            ExecFlow.current.Advance(Context.current, forEachNode.Port(0, 0), forEachNode.Port(0, 0));

            var scope = new ForEachScope
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional,
                SourceExec = forEachNode.Port(0, 0)
            };

            SemanticStack.current.Push(scope);
            SemanticStack.current.Push(conditional);
            body(new T { Port = forEachNode.Port(0, 1) });

            // End the conditional context
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Now validate execflow continuity from the current back to the "Loop" port
            scope.EnsureContinuityAndCheckAsync(ExecFlow.current);

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
            var indexVariable = __CreateNamedVariable<IntPort>("ForEach_index", null!, VariableKind.Local);

            // Rewire all item connections (& return data) to a List Get Element chip..
            var itemConnections = Context.current.Connections.Where(c => c.From.EquivalentTo(forEachNode.Port(0, 1))).ToList();
            Func<T> getElementPort = () => Singleton($"ForEach_GetElement_{list.PortKey()}_{indexVariable.Value.PortKey()}",
                                                     () => ListGetElement(list, indexVariable.Value));

            // Rewire connections
            foreach (var conn in itemConnections)
                conn.From = getElementPort().Port;

            // Modify returns
            var returnScope = SemanticStack.current.GetNextScopeWithType<ReturnScope>();
            returnScope?.ReplacePort(forEachNode.Port(0, 1), getElementPort);

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
            // Edge-case: Empty execution flow (like: foreach (var _ in _) { break; })
            //            In this case the increment will be unreachable, so don't spawn it.
            ExecFlow.current = prevFlow;
            if (ExecFlow.current.Ports.Count > 0)
                indexVariable.Value += 1;

            // Merge continue flow into the current flow, advance back to If node
            ExecFlow.current.Merge(scope.ContinueFlow);
            ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);

            // Continue building nodes from the break flow
            // (with the Else port added in)
            ExecFlow.current = scope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }

        public static void __ManualFor(ConditionalContext conditional, AlternativeExec body, Func<BoolPort> condition, AlternativeExec incrementors)
        {
            // Write promoted variables & set their C# state to the output pins
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Evaluate condition now that C# states point to the RR variable outputs
            var conditionResult = condition();

            // Check if we should enter the loop body
            If(conditionResult, () => { });
            var ifNode = Context.lastSpawnedNode;

            // Create & push our scopes onto the SemanticStack,
            // build the body of the loop
            var scope = new ForScope()
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional,
                SourceExec = ifNode.Port(0, 0)
            };

            SemanticStack.current.Push(conditional);
            SemanticStack.current.Push(scope);
            body();

            // End our semantic scopes
            SemanticStack.current.PopExpectedScope(scope);
            SemanticStack.current.PopExpectedScope(conditional);

            // Edge-case: exec flow with no ports (i.e for (...) { break; })
            if (ExecFlow.current.Ports.Count > 0)
            {
                // Write the promoted variables & re-set C# state to reference RR variables
                conditional.WritePromotedVariables();
                conditional.ResetPromotedVariables(true);
            }

            // Merge the continue flow into the current
            // execution flow, and build the incrementors
            // (only if we have ports.. need the double-check
            //  because we merged exec flow).
            ExecFlow.current.Merge(scope.ContinueFlow);
            if (ExecFlow.current.Ports.Count > 0)
            {
                incrementors();
                conditional.WritePromotedVariables();
                conditional.ResetPromotedVariables(true);
            }

            // Finally we can check for continuity and async exec ports
            scope.EnsureContinuityAndCheckAsync(ExecFlow.current);

            // Loop back to the If node
            ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);

            // Finally, add the Else port to the break flow,
            // and continue building nodes from there.
            ExecFlow.current = scope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }

        public static void __OptimizedFor(ConditionalContext conditional, bool iterateUpward, IntPort min, IntPort max, Action<IntPort> body, AlternativeExec incrementors)
        {
            // Write promoted variables to RR variables,
            // set their C# state to reference the RR variable outputs
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Build loop body assuming we can use the For node.
            // The For node does not support negative iteration, so if we're iterating
            // in the negative direction, we'll need some special behaviour to support it.
            Node? maxCacheNode = null;
            IntPort maxCached = max;
            Node forNode;
            Node? subtractNode = null;

            // If negative (& the max value is a real port) build a cache for the max value
            if (!iterateUpward && max.IsActualPort)
            {
                RandomInt(max, max);
                maxCacheNode = Context.lastSpawnedNode;
                maxCached = new IntPort { Port = maxCacheNode.Port(0, 1) };
            }

            // Build the For node itself
            InlineGraph(() => For(min, maxCached, (_) => { }));
            forNode = Context.lastSpawnedNode;

            ExecFlow.current.Advance(Context.current, forNode.Port(0, 0), forNode.Port(0, 0));

            // If negative, pass (maxCached - index) to the body.
            var indexArg = new IntPort { Port = forNode.Port(0, 1) };
            if (!iterateUpward)
            {
                indexArg = Subtract(maxCached, indexArg);
                subtractNode = Context.lastSpawnedNode;
            }

            // Finally, we can create our For scope,
            // push onto the semantic stack, and build the body
            var scope = new ForScope
            {
                BreakFlow = new() { hasAdvanced = true },
                ContinueFlow = new(),
                ConditionalContext = conditional,
                SourceExec = forNode.Port(0, 0),

                // TODO: The negative iteration worked fine for positive numbers,
                //       but breaks on negative numbers. Whoops.. is it possible to
                //       come up with a solution that works for both?
                NeedsManualImplementation = !iterateUpward
            };

            SemanticStack.current.Push(scope);
            SemanticStack.current.Push(conditional);
            body(indexArg);

            // Write final values of promoted variables to their RR variables,
            // again set C# state to reference their outputs
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Merge the continue flow into the current exec flow, build the incrementors
            // (only if we have ports.. otherwise it's unreachable)
            ExecFlow.current.Merge(scope.ContinueFlow);
            if (ExecFlow.current.Ports.Count > 0)
                incrementors();

            // Again, we need to re-set the conditional context as before.
            conditional.WritePromotedVariables();
            conditional.ResetPromotedVariables(true);

            // Ensure continuity, check for async execs, and pop from the semantic stack.
            scope.EnsureContinuityAndCheckAsync(ExecFlow.current);
            SemanticStack.current.PopExpectedScope(conditional);
            SemanticStack.current.PopExpectedScope(scope);

            // And that should be everything, unless we need to build a manual implementation
            if (!scope.NeedsManualImplementation)
            {
                // All done. We can continue building nodes from the Done port.
                ExecFlow.current.Advance(Context.current, null, forNode.Port(0, 2));
                return;
            }

            // Otherwise it's time for some surgery on the graph.
            // We need to splice-in our own manual iterator
            var prevFlow = ExecFlow.current;
            ExecFlow.current = new();
            var indexVariable = __CreateNamedVariable<IntPort>("For_index", null!, VariableKind.Local);

            // Replace index connections with the new variable output
            var indexPortReplace = subtractNode?.Port(0, 0) ?? forNode.Port(0, 1);
            foreach (var conn in Context.current.Connections.Where(c => c.From.EquivalentTo(indexPortReplace)))
                conn.From = indexVariable.Value.Port;

            // Modify returns
            var returnScope = SemanticStack.current.GetNextScopeWithType<ReturnScope>();
            returnScope?.ReplacePort(indexPortReplace, () => indexVariable.Value);

            // Determine exec input & output connections
            // TODO: The assumption when we do this (both here & __ForEach) is that the body exec flow
            //       did actually advance. It would have to in order to require a manual implementation,
            //       as that only happens for these when a Delay chip has been spawned. But is this really safe?

            var execInTarget = maxCacheNode != null ? maxCacheNode.Port(0, 0) : forNode.Port(0, 0);
            var execInputFrom = Context.current.Connections
                .Where(c => c.To.EquivalentTo(execInTarget))
                .Select(c => c.From)
                .FirstOrDefault();

            var execOutputTo = Context.current.Connections
                .Where(c => c.From.EquivalentTo(forNode.Port(0, 0)))
                .Select(c => c.To)
                .FirstOrDefault();

            // Remove old nodes, setup new exec flow
            Context.current.RemoveNode(maxCacheNode);
            Context.current.RemoveNode(forNode);
            Context.current.RemoveNode(subtractNode);
            ExecFlow.current.Advance(Context.current, null, execInputFrom);

            // Initialize index variable
            indexVariable.Value = iterateUpward ? min : max;

            // Cache our "end point" value?
            // This is pretty much what we would do when iterating negatively.
            // But now we need it in both cases. So we just do it all over again :p
            var endCache = iterateUpward ? max : min;
            if (endCache.IsActualPort)
                endCache = RandomInt(endCache, endCache);

            // Check if we should enter the loop body
            var condition = iterateUpward ? LessThan(indexVariable.Value, endCache) : GreaterThan(indexVariable.Value, endCache);
            If(condition, () => { });
            var ifNode = Context.lastSpawnedNode;

            // Wire Then port to exec output destination
            ExecFlow.current.Advance(Context.current, execOutputTo, null);

            // Jump back onto the loop body exec flow, increment/decrement index, advance back to If node
            // Edge-case: Empty execution flow (like: for (..) { break; })
            //            In this case the increment will be unreachable, so don't spawn it.
            ExecFlow.current = prevFlow;
            if (ExecFlow.current.Ports.Count > 0)
            {

                indexVariable.Value = iterateUpward ? indexVariable.Value + 1
                                                    : indexVariable.Value - 1;

                ExecFlow.current.Advance(Context.current, ifNode.Port(0, 0), null);
            }

            // Continue building nodes from the break flow
            // (with the Else port added in)
            ExecFlow.current = scope.BreakFlow;
            ExecFlow.current.Ports.Add(ifNode.Port(0, 1));
        }

        public static NamedVariable<T> __CreateNamedVariable<T>(string name, T homeValue, VariableKind kind) where T : AnyPort, new()
        {
            // Don't apply automatic naming to cloud variables.
            if (kind == VariableKind.Cloud)
                return new NamedVariable<T>(name, homeValue, kind);

            // Otherwise make use of NamedAssignmentScope and AutoNamedVariable
            // to ensure the variable has a unique name.
            var scope = new NamedAssignmentScope { Identifier = name };
            SemanticStack.current.Push(scope);

            var result = new AutoNamedVariable<T>(homeValue, kind);
            SemanticStack.current.PopExpectedScope(scope);

            return result;
        }

        public static void MemberVariableChanged(object memberVariable)
        {
            // memberVariable must reference the value pin of a Variable node
            var memberVariablePort = PortConversionUtils.ToAnyPort(memberVariable);
            if (!memberVariablePort.IsActualPort) goto fail;

            var port = memberVariablePort.Port;
            var node = port.Node;

            if (!ChipTypeUtils.VariableTypes.Contains(node.Type)) goto fail;
            if (!port.EquivalentTo(node.Port(0, 1))) goto fail;

            // All checks pass, create the event receiver
            EventReceiver(node.VariableData.Name + " Changed");
            return;

        fail: // I didn't want to duplicate the message
            throw new ArgumentException("The memberVariable argument must refer to a variable output port!");
        }

        public static void MemberVariableChanged(object fieldVariable, AlternativeExec onChanged)
        {
            InlineGraph(() =>
            {
                MemberVariableChanged(fieldVariable);
                onChanged();
            });
        }

        [Obsolete("Renamed - use MemberVariableChanged instead.")]
        public static void FieldVariableChanged<T>(T fieldVariable) where T : AnyPort, new() => MemberVariableChanged(fieldVariable);
        [Obsolete("Renamed - use MemberVariableChanged instead.")]
        public static void FieldVariableChanged<T>(T fieldVariable, AlternativeExec onChanged) where T : AnyPort, new() => MemberVariableChanged(fieldVariable, onChanged);

        public static TResult __SwitchExpression<TResult>(AnyPort match, Func<TResult> defaultExpression, Dictionary<AnyPort, Func<TResult>> cases) where TResult : AnyPort, new()
        {
            // Ensure match type is supported
            var matchType = match.GetType();
            if (matchType != typeof(IntPort) && matchType != typeof(StringPort))
                throw new Exception($"Switch expressions are not supported for match type '{matchType.Name}'!");

            // If match is an actual port, we'll have to build this as a real switch chip.
            if (match.IsActualPort)
                return ValueAnySwitch(match, defaultExpression(), cases.ToDictionary(kvp => kvp.Key, kvp => kvp.Value()));

            // Otherwise, we can determine the result ahead of time.
            foreach (var kvp in cases)
            {
                var caseType = kvp.Key.GetType();

                // Validate case/match type equality..
                if (caseType != matchType)
                    throw new Exception($"Case type '{caseType.Name}' is not equal to the match type '{matchType.Name}'!");

                // Validate data port status..
                if (!kvp.Key.IsDataPort)
                    throw new Exception($"Cannot create switch cases with dynamic data! Be sure to pass a pure-data value.");

                // Check for data equality
                if (match.Data == kvp.Key.Data)
                    return kvp.Value();
            }

            // No cases matched, return the default.
            var result = defaultExpression();
            if (result == null)
                throw new Exception("Failed to match against pure-data value, but no default value was provided!");

            return result;
        }

        public static T __Ternary<T>(BoolPort condition, Func<T> whenTrue, Func<T> whenFalse) where T : AnyPort, new()
        {
            if (condition.IsDataPort)
                return condition.Data ? whenTrue() : whenFalse();

            return IfValue<T>(condition, whenTrue(), whenFalse());
        }
    }
}
#nullable disable