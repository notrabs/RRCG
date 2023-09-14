using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RRCGBuild
{
    public class EventFunction : Attribute { }
    public class SharedProperty : Attribute { }

    public abstract class CircuitBuilder : ChipBuilder
    {
        internal readonly Dictionary<string, EventHelper> __RRCG_EVENT_FUNCTIONS = new Dictionary<string, EventHelper>();
        internal readonly Dictionary<string, object> __RRCG_SHARED_PROPERTIES = new Dictionary<string, object>();

        public abstract void CircuitGraph();

        //
        // Exec Flow Helpers
        //

        public void StartNewGraph()
        {
            ExecFlow.current = new ExecFlow();
        }

        public void ClearExec()
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

        protected void __DispatchEventFunction(string name, Action fn)
        {
            if (!__RRCG_EVENT_FUNCTIONS.ContainsKey(name))
            {
                __RRCG_EVENT_FUNCTIONS[name] = new EventHelper("RRCG_EventFunction_" + name);

                InlineGraph(() =>
                {
                    __RRCG_EVENT_FUNCTIONS[name].Definition();
                    __RRCG_EVENT_FUNCTIONS[name].Receiver();
                    fn();
                });
            }

            __RRCG_EVENT_FUNCTIONS[name].Sender();
        }
        protected T __DispatchSharedPropertyFunction<T>(string name, Func<T> fn) where T : AnyPort
        {
            if (!__RRCG_SHARED_PROPERTIES.ContainsKey(name))
            {
                InlineGraph(() =>
                {
                    __RRCG_SHARED_PROPERTIES[name] = fn();
                });
            }

            return __RRCG_SHARED_PROPERTIES[name] as T;
        }

        //
        // Circuit Board Helpers
        //

        private object __CircuitBoard(Delegate circuitBoardFn, params dynamic[] parameters)
        {
            var prevContext = Context.current;
            var prevExecFlow = ExecFlow.current;

            var cbContext = new Context();
            prevContext.SubContexts.Add(cbContext);
            cbContext.ParentContext = prevContext;
            Context.current = cbContext;
            ConditionalContext.Push(new RootConditionalContext());
            ExecFlow.current = new ExecFlow();

            var returnType = circuitBoardFn.GetMethodInfo().ReturnType;

            var isVoid = returnType == typeof(void);
            var isPort = returnType.BaseType == typeof(AnyPort);
            var isTuple = returnType.IsGenericType && returnType.GetGenericTypeDefinition().BaseType.Name.StartsWith("ValueType");

            if (!(isVoid || isPort || isTuple)) throw new Exception("CircuitBoard() only works with port types or tuples!");

            // Construct Inner Context

            In();
            var inNode = Context.lastSpawnedNode;

            ExecFlow.current.Ports.Add(inNode.Port(0, 0));

            var inNodePorts = parameters.Select((p, index) =>
            {
                dynamic port = Activator.CreateInstance(p.GetType());
                port.Port = inNode.Port(1, index);
                port.Data = p.Data;
                return port;
            });

            var cbResult = circuitBoardFn.DynamicInvoke(inNodePorts.ToArray());

            var hasExec = ExecFlow.current.hasAdvanced;

            Out();
            var outNode = Context.lastSpawnedNode;

            if (hasExec) ExecFlow.current.Advance(Context.current, new Port() { Node = outNode, Group = 0, Index = 0 }, null);

            if (isPort)
            {
                outNode.ConnectInputPort(Context.current, cbResult as AnyPort, outNode.Port(1, 0));
            }
            else if (isTuple)
            {
                var outNodeInputIndex = 0;
                foreach (var toOutPort in cbResult.GetType().GetProperties().Select(p => p.GetValue(cbResult)))
                {
                    outNode.ConnectInputPort(Context.current, toOutPort as AnyPort, outNode.Port(1, outNodeInputIndex));
                    outNodeInputIndex++;
                }
            }

            // Set context interface

            cbContext.MetaNewBoard = new List<CBFunction>();

            var execFunction = new CBFunction() { Name = "Exec" };
            cbContext.MetaNewBoard.Add(execFunction);

            var dataFunction = new CBFunction() { Name = "Data" };
            cbContext.MetaNewBoard.Add(execFunction);

            if (hasExec)
            {
                execFunction.Inputs.Add(("Exec", typeof(void)));
                execFunction.Outputs.Add(("Exec", typeof(void)));
            }

            int parameterIndex = 0;
            foreach (var parameter in parameters)
            {
                dataFunction.Inputs.Add(("value" + parameterIndex, parameter.GetType()));
                parameterIndex++;
            }

            if (isPort)
            {
                dataFunction.Outputs.Add(("value0", cbResult.GetType()));
            }
            else if (isTuple)
            {
                int outputIndex = 0;
                foreach (var outPort in cbResult.GetType().GetProperties().Select(p => p.GetValue(cbResult)))
                {
                    dataFunction.Outputs.Add(("value" + outputIndex, outPort.GetType()));
                    outputIndex++;
                }
            }


            // Construct CB

            Context.current = prevContext;
            ExecFlow.current = prevExecFlow;

            ChipBuilder.CircuitBoard();
            var cbNode = Context.lastSpawnedNode;
            cbNode.CircuitBoardId = cbContext.Id.ToString();

            if (hasExec) ExecFlow.current.Advance(Context.current, cbNode.Port(0, 0), cbNode.Port(0, 0));

            foreach (var parameter in parameters) cbNode.ConnectInputPort(Context.current, parameter, cbNode.Port(1, parameterIndex));

            if (isVoid) return null;
            if (isPort)
            {
                dynamic port = Activator.CreateInstance(cbResult.GetType());
                port.Port = cbNode.Port(1, 0);
                port.Data = (cbResult as AnyPort).Data;
                return port;
            }
            else
            {
                var cbOutPorts = parameters.Select((p, index) =>
                {
                    dynamic port = Activator.CreateInstance(p.GetType());
                    port.Port = cbNode.Port(1, index);
                    port.Data = p.Data;
                    return port;
                });

                var tuple = TupleUtils.UnwrapTuple(cbResult.GetType(), cbOutPorts.ToArray());
                return tuple;
            }
        }

        public void CircuitBoard(Action circuitBoardFn) => __CircuitBoard(circuitBoardFn);
        public T CircuitBoard<T>(Func<T> circuitBoardFn) => (T)__CircuitBoard(circuitBoardFn);
        public void CircuitBoard<P0>(Action<P0> circuitBoardFn, P0 value0) => __CircuitBoard(circuitBoardFn, value0);
        public T CircuitBoard<P0, T>(Func<P0, T> circuitBoardFn, P0 value0) => (T)__CircuitBoard(circuitBoardFn, value0);
        public void CircuitBoard<P0, P1>(Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) => __CircuitBoard(circuitBoardFn, value0, value1);
        public T CircuitBoard<P0, P1, T>(Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) => (T)__CircuitBoard(circuitBoardFn, value0, value1);

        public void ExistingCircuitBoard(StringPort boardName, AlternativeExec circuitBoardFn)
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

        public PortType ExistingDataInput<PortType>(StringPort portName)
        {
            return default;
        }
        public void ExistingDataOutput<PortType>(StringPort portName, PortType value)
        {
        }

        public void ExistingExecInput(StringPort portName)
        {
        }

        public void ExistingExecOutput(StringPort portName)
        {
        }

        //
        // Compilation Helpers
        //

        public void Return(ExecFlow returnFlow)
        {
            returnFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();
        }

        public void Return<T>(ExecFlow returnFlow, out T returnData, T expression)
        {
            returnFlow.Merge(ExecFlow.current);
            ExecFlow.current.Clear();

            returnData = expression;
        }

        public T Assign<T>(out T variable, T value)
        {
            var assignedValue = value;

            if (ConditionalContext.current != null)
            {
                //ConditionalContext.current.ConnectValuePort(value);
            }

            variable = assignedValue;
            return assignedValue;
        }
    }
}





