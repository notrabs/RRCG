

using RRCGBuild;
using System;
using System.Threading.Tasks;

namespace RRCGSource
{
    /// <summary>
    /// An Event Function will be called through an event, with all logic only present once in the graph
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class EventFunction : Attribute { }

    /// <summary>
    /// A Shared Properties chips will only placed once in the world.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class SharedProperty : Attribute { }

    /// <summary>
    /// A CircuitGraph method is an additional entry point to your graph. It will be built after the main graph and must be a parameterless function.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CircuitGraph : Attribute { }

    /// <summary>
    /// Fields declared with this attribute will be placed as variable chips.
    /// The initializer will become the home value.
    /// </summary>
    /// <see cref="CircuitDescriptor.FieldVariableChanged{T}(T)"/>
    [AttributeUsage(AttributeTargets.Field)]
    public class Variable : Attribute { }

    /// <summary>
    /// Fields declared with this attribute will be placed as synced variable chips.
    /// The initializer will become the home value.
    /// </summary>
    /// <see cref="CircuitDescriptor.FieldVariableChanged{T}(T)"/>
    [AttributeUsage(AttributeTargets.Field)]
    public class SyncedVariable : Attribute { }

    /// <summary>
    /// Fields declared with this attribute will be placed as cloud variable chips.
    /// Home values are not supported with cloud variables!
    /// </summary>
    /// <see cref="CircuitDescriptor.FieldVariableChanged{T}(T)"/>
    [AttributeUsage(AttributeTargets.Field)]
    public class CloudVariable : Attribute
    {
        public CloudVariable(params string[] names) { }
    }

    /// <summary>
    /// A compiled RRCG class containing parts of a circuit.
    /// </summary>
    public abstract class CircuitLibrary: CircuitDescriptor {
        public override void CircuitGraph()
        {
            // A library needs no entry point. Maybe it makes sense to clean up the structure here some day.
            // The CircuitDescriptor would make more sense to inherit from CircuitLibrary
        }
    }

    /// <summary>
    /// A RRCG class describing a complete circuit from an entry point.
    /// </summary>
    public abstract class CircuitDescriptor : Chips
    {
        /// <summary>
        /// The entry point to your circuit graph.
        /// </summary>
        public abstract void CircuitGraph();

        /// <summary>
        /// Starts a new Circuit Graph without modyfing the current one.
        /// </summary>
        public static void StartNewGraph() { }

        /// <summary>
        /// Clears the current exec flow. (this marks the existing exec flow as "cleared", which can be useful to detect if a changes have occured).
        /// </summary>
        public static void ClearExec() { }

        /// <summary>
        /// Define a new graph from your current context without destroying your current execution state.
        /// </summary>
        public static void InlineGraph(AlternativeExec graphFn) { }
        /// <inheritdoc cref="InlineGraph(AlternativeExec)" />
        public static T InlineGraph<T>(Func<T> graphFn) { return default; }

        /// <summary>
        /// Constructs a simple circuit board from a function. If the function contains executable chips, the board will have one exec input and output.
        /// </summary>
        public static void CircuitBoard(Action circuitBoardFn) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<T>(Func<T> circuitBoardFn) { return default; }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static void CircuitBoard<P0>(Action<P0> circuitBoardFn, P0 value0) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<P0, T>(Func<P0, T> circuitBoardFn, P0 value0) { return default; }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static void CircuitBoard<P0, P1>(Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<P0, P1, T>(Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) { return default; }

        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static void CircuitBoard(string name, Action circuitBoardFn) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<T>(string name, Func<T> circuitBoardFn) { return default; }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static void CircuitBoard<P0>(string name, Action<P0> circuitBoardFn, P0 value0) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<P0, T>(string name, Func<P0, T> circuitBoardFn, P0 value0) { return default; }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static void CircuitBoard<P0, P1>(string name, Action<P0, P1> circuitBoardFn, P0 value0, P1 value1) { }
        /// <inheritdoc cref="CircuitBoard(Action)" />
        public static T CircuitBoard<P0, P1, T>(string name, Func<P0, P1, T> circuitBoardFn, P0 value0, P1 value1) { return default; }

        /// <summary>
        /// Use this function to place circuits inside an existing board. The boardName must be unique.
        /// </summary>
        public static void ExistingCircuitBoard(string boardName, AlternativeExec circuitBoardFn) { }

        public static PinType ExistingDataInput<PinType>(string portName) { return default; }
        public static void ExistingDataOutput<PinType>(string portName, PinType value) { }
        public static void ExistingExecInput(string portName) { }
        public static void ExistingExecOutput(string portName) { }

        /// <summary>
        /// Shorthand to create an event receiver for a studio event. Automatically creates an EventDefinition if needed.
        /// </summary>
        public static void StudioEventReceiver(string eventName) { }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room
        /// </summary>
        public static EventDefinition ExistingEvent(string eventName) { return default; }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With one Event parameter.
        /// </summary>
        public static EventDefinition<T0> ExistingEvent<T0>(string eventName) { return default; }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With two Event parameter.
        /// </summary>
        public static EventDefinition<T0, T1> ExistingEvent<T0, T1>(string eventName) { return default; }

        /// <summary>
        /// Returns an Instance of the Event class for an already exising Event in the room. 
        /// With three Event parameter.
        /// </summary>
        public static EventDefinition<T0, T1, T2> ExistingEvent<T0, T1, T2>(string eventName) { return default; }

        /// <summary>
        /// Helper method to ensure the provided function only runs once per context.
        /// The key parameter should be unique. Calls to Singleton with a key that was already used in the context
        /// will not invoke the creator method.
        /// </summary>
        public static void Singleton(string key, Action creator) { }

        /// <summary>
        /// Helper method to ensure the provided function only runs once per context.
        /// The key parameter should be unique. Calls to Singleton with a key that was already used in the context
        /// will not invoke the creator method -- instead, the value returned from the original invocation will
        /// be passed back to the caller.
        /// </summary>
        public static T Singleton<T>(string key, Func<T> creator) { return default; }

        /// <summary>
        /// Allows you to use the changed event for variables created with [Variable], [SyncedVariable], [CloudVariable], etc.
        /// Pass the field as the argument and the corresponding Event Receiver will be placed.
        /// </summary>
        public static void FieldVariableChanged<T>(T fieldVariable) { }
        /// <inheritdoc cref="FieldVariableChanged{T}(T)"/>
        public static void FieldVariableChanged<T>(T fieldVariable, AlternativeExec onChanged) { }
    }
}