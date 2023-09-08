using System;
using System.Linq.Expressions;

namespace RRCGBuild
{
    public abstract class CircuitBuilder: ChipBuilder
    {
        public abstract Context BuildCircuitGraph();
        public abstract void CircuitGraph();

        public void StartNewGraph()
        {
            ExecFlow.current.Clear();
        }

        public void ClearExec()
        {
            ExecFlow.current.Clear();
        }

        public void ExistingCircuitBoard(StringPort boardName, Action circuitBoardFn)
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
    }
}





