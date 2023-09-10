using System;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class EventFunction : Attribute { }

    public abstract class CircuitBuilder : ChipBuilder
    {
        internal readonly Dictionary<string, EventHelper> __RRCG_EVENT_FUNCTIONS = new Dictionary<string, EventHelper>();

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
        public void InlineGraph(AlternativeExec graphFn)
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

        //
        // Circuit Board Helpers
        //

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





