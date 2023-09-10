

using System;

namespace RRCGSource
{
    /// <summary>
    /// An Event Function will be called through an event, with all logic only present once in the graph
    /// </summary>
    public class EventFunction : Attribute { }

    public abstract class CircuitDescriptor : Chips
    {
        public abstract void CircuitGraph();

        public void StartNewGraph() { }
        public void ClearExec() { }

        /// <summary>
        /// Define a new graph from your current context without destroying your current execution state.
        /// </summary>
        public void InlineGraph(AlternativeExec graphFn) { }

        public static Action EventFunction(AlternativeExec fn)
        {
            return default;
        }

        public void ExistingCircuitBoard(string boardName, AlternativeExec circuitBoardFn)
        {
            circuitBoardFn();
        }

        public PinType ExistingDataInput<PinType>(string portName)
        {
            return default;
        }
        public void ExistingDataOutput<PinType>(string portName, PinType value)
        {
        }

        public void ExistingExecInput(string portName)
        {
        }

        public void ExistingExecOutput(string portName)
        {
        }
    }
}