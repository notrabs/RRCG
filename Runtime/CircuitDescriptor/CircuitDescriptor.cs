

using RRCGBuild;
using System;
using System.Threading.Tasks;

namespace RRCGSource
{
    /// <summary>
    /// An Event Function will be called through an event, with all logic only present once in the graph
    /// </summary>
    public class EventFunction : Attribute { }

    /// <summary>
    /// A Shared Properties chips will only placed once in the world.
    /// </summary>
    public class SharedProperty : Attribute { }

    public abstract class CircuitDescriptor : Chips
    {
        public abstract void CircuitGraph();

        public void StartNewGraph() { }
        public void ClearExec() { }

        /// <summary>
        /// Define a new graph from your current context without destroying your current execution state.
        /// </summary>
        public void InlineGraph(AlternativeExec graphFn) { }

        public static Action EventFunction(AlternativeExec fn) { return default; }

        /// <summary>
        /// Constructs a simple circuit board from a function. If the function contains executable chips, the board will have one exec input and output.
        /// </summary>
        public void CircuitBoard(Action circuitBoardFn) { }
        public T CircuitBoard<T>(Func<T> circuitBoardFn) { return default; }
        public void CircuitBoard<P0>(Action<P0> circuitBoardFn, P0 value0) { }
        public T CircuitBoard<P0, T>(Func<P0, T> circuitBoardFn, P0 value0) { return default; }
        public void CircuitBoard<P0, P1>(Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) { }
        public T CircuitBoard<P0, P1, T>(Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) { return default; }

        public void ExistingCircuitBoard(string boardName, AlternativeExec circuitBoardFn) { }

        public PinType ExistingDataInput<PinType>(string portName) { return default; }
        public void ExistingDataOutput<PinType>(string portName, PinType value) { }
        public void ExistingExecInput(string portName) { }
        public void ExistingExecOutput(string portName) { }
    }
}