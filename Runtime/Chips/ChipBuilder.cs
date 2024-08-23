using RRCG;
using RRCGGenerated;
using RRCGSource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCGBuild
{
    public class ChipBuilder : RRCGGenerated.ChipBuilderGen
    {
        // 
        // Event Nodes
        // 
        #region EventNodes
        public static void EventReceiver(StringPort eventName)
        {
            EventReceiver(new EventReceiverData(eventName.AsData<string>()));
        }

        public static T0 EventReceiver<T0>(StringPort eventName) where T0 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return new T0() { Port = node.Port(0, 1) };
        }

        public static (T0, T1) EventReceiver<T0, T1>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) }
            );
        }
        public static (T0, T1, T2) EventReceiver<T0, T1, T2>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) }
            );
        }
        public static (T0, T1, T2, T3) EventReceiver<T0, T1, T2, T3>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) }
            );
        }

        public static (T0, T1, T2, T3, T4) EventReceiver<T0, T1, T2, T3, T4>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5) EventReceiver<T0, T1, T2, T3, T4, T5>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6) EventReceiver<T0, T1, T2, T3, T4, T5, T6>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
            where T11 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) },
                new T11() { Port = node.Port(0, 12) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
            where T11 : AnyPort, new()
            where T12 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) },
                new T11() { Port = node.Port(0, 12) },
                new T12() { Port = node.Port(0, 13) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
            where T11 : AnyPort, new()
            where T12 : AnyPort, new()
            where T13 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) },
                new T11() { Port = node.Port(0, 12) },
                new T12() { Port = node.Port(0, 13) },
                new T13() { Port = node.Port(0, 14) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
            where T11 : AnyPort, new()
            where T12 : AnyPort, new()
            where T13 : AnyPort, new()
            where T14 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) },
                new T11() { Port = node.Port(0, 12) },
                new T12() { Port = node.Port(0, 13) },
                new T13() { Port = node.Port(0, 14) },
                new T14() { Port = node.Port(0, 15) }
            );
        }

        public static (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
            where T8 : AnyPort, new()
            where T9 : AnyPort, new()
            where T10 : AnyPort, new()
            where T11 : AnyPort, new()
            where T12 : AnyPort, new()
            where T13 : AnyPort, new()
            where T14 : AnyPort, new()
            where T15 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (
                new T0() { Port = node.Port(0, 1) },
                new T1() { Port = node.Port(0, 2) },
                new T2() { Port = node.Port(0, 3) },
                new T3() { Port = node.Port(0, 4) },
                new T4() { Port = node.Port(0, 5) },
                new T5() { Port = node.Port(0, 6) },
                new T6() { Port = node.Port(0, 7) },
                new T7() { Port = node.Port(0, 8) },
                new T8() { Port = node.Port(0, 9) },
                new T9() { Port = node.Port(0, 10) },
                new T10() { Port = node.Port(0, 11) },
                new T11() { Port = node.Port(0, 12) },
                new T12() { Port = node.Port(0, 13) },
                new T13() { Port = node.Port(0, 14) },
                new T14() { Port = node.Port(0, 15) },
                new T15() { Port = node.Port(0, 16) }
            );
        }

        internal static void EventSender(StringPort eventName, EventTarget eventTarget, params AnyPort[] inputs)
        {
            EventSender(new EventSenderData(eventName.AsData<string>(), eventTarget));
            var node = Context.lastSpawnedNode;

            for (var i = 0; i < inputs.Length; i++)
                node.ConnectInputPort(inputs[i], node.Port(0, 1 + i));
        }

        internal static void EventDefinition(StringPort eventName, params (StringPort, Type)[] eventDefinition)
        {
            EventDefinition(new EventDefinitionData(
                eventName.AsData<string>(),
                eventDefinition.Select(t => (t.Item1.AsData<string>(), t.Item2)).ToArray()
            ));
        }

        #endregion

        // 
        // Dynamic Pin Nodes
        // 
        #region DynamicPinNodes

        public static StringPort Concat(params StringPort[] ports)
        {
            ChipBuilderGen.StringConcat("", ports[0]);
            return ConnectDynamicPins(1, ports);
        }

        public static IntPort Add(params IntPort[] ports)
        {
            ChipBuilderGen.Add(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Add(params FloatPort[] ports)
        {
            ChipBuilderGen.Add(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static Vector3Port Add(params Vector3Port[] ports)
        {
            ChipBuilderGen.Add(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Subtract(params IntPort[] ports)
        {
            ChipBuilderGen.Subtract(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Subtract(params FloatPort[] ports)
        {
            ChipBuilderGen.Subtract(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static Vector3Port Subtract(params Vector3Port[] ports)
        {
            ChipBuilderGen.Subtract(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Multiply(params IntPort[] ports)
        {
            ChipBuilderGen.Multiply(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Multiply(params FloatPort[] ports)
        {
            ChipBuilderGen.Multiply(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static QuaternionPort Multiply(params QuaternionPort[] ports)
        {
            ChipBuilderGen.Multiply(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Divide(params IntPort[] ports)
        {
            ChipBuilderGen.Divide(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Divide(params FloatPort[] ports)
        {
            ChipBuilderGen.Divide(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Modulo(params IntPort[] ports)
        {
            ChipBuilderGen.Modulo(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Modulo(params FloatPort[] ports)
        {
            ChipBuilderGen.Modulo(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Remainder(params IntPort[] ports)
        {
            ChipBuilderGen.Remainder(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Remainder(params FloatPort[] ports)
        {
            ChipBuilderGen.Remainder(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Min(params IntPort[] ports)
        {
            ChipBuilderGen.Min(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Min(params FloatPort[] ports)
        {
            ChipBuilderGen.Min(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        public static IntPort Max(params IntPort[] ports)
        {
            ChipBuilderGen.Max(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static FloatPort Max(params FloatPort[] ports)
        {
            ChipBuilderGen.Max(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        
        public static StringPort StringFormat(StringPort Format, params StringPort[] Values)
        {
            if (Format.IsDataPort && Values.All(v => v.IsDataPort))
            {
                // We probably could just return the result of string.Format here, but that method
                // supports more advanced features (spacing, control alignment, etc) that the in-game
                // chip doesn't support. So to preserve semantics we explicitly only handle {0}, {1} etc.

                var result = Format.AsData<string>();
                for (int i = 0; i < Values.Length; i++)
                    result = result.Replace($"{{{i}}}", Values[i].AsData<string>());

                return result;
            }

            ChipBuilderGen.StringFormat(Format, Values.FirstOrDefault());
            return ConnectDynamicPins(1, Values);
        }

        public static ListPort<T> ListCreate<T>(params T[] ports) where T : AnyPort, new()
        {
            ChipBuilderGen.ListCreate<T>(ports.FirstOrDefault());
            var node = Context.lastSpawnedNode;

            ConnectDynamicPins(0, ports);
            return new ListPort<T> { Port = new Port { Node = node } };
        }

        public static BoolPort And(params BoolPort[] ports)
        {
            ChipBuilderGen.And(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static BoolPort Or(params BoolPort[] ports)
        {
            ChipBuilderGen.Or(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        // Assumes first pin has already been connected
        private static T ConnectDynamicPins<T>(int offset, params T[] ports) where T : AnyPort, new()
        {
            var node = Context.lastSpawnedNode;
            node.InputCount = ports.Length + offset;

            for (int i = 1; i < ports.Length; i++)
            {
                node.ConnectInputPort(ports[i], new Port
                {
                    Node = node,
                    Index = i + offset
                });
            }

            return new T { Port = new Port { Node = node } };
        }
        #endregion

        // 
        // Control Flow
        // 
        #region ControlFlowNodes

        public static void If(BoolPort test, AlternativeExec ifBranch, AlternativeExec elseBranch)
        {
            var prevFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ChipBuilderGen.If(test, () => { });
            var node = Context.lastSpawnedNode;

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node });
            ifBranch();
            var ifFlow = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node, Index = 1 });
            elseBranch();
            var elseFlow = ExecFlow.current;

            ExecFlow.current = prevFlow;

            if (ifFlow.hasAdvancedOrCleared || elseFlow.hasAdvancedOrCleared)
            {
                ExecFlow.current.Advance(Context.current, new Port { Node = node }, new Port { Node = node });

                ExecFlow.current.Clear();
                ExecFlow.current.Merge(ifFlow);
                ExecFlow.current.Merge(elseFlow);
            }
            else
            {
                Context.current.RemoveNode(node);
            }
        }

        public static void For(AlternativeExec<IntPort> forEach, IntPort from, IntPort to)
        {
            var index = ChipBuilderGen.For(from, to, (_) => { });
            var node = Context.lastSpawnedNode;

            forEach(index);

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(node.Port(0, 2));
        }

        public static void ExecutionIntegerSwitch(IntPort match, AlternativeExec failed, Dictionary<IntPort, AlternativeExec> branches, ConditionalContext conditional = null)
        {
            TypedExecutionSwitch(ExecutionIntegerSwitch, match, failed, branches, conditional);
        }

        public static void ExecutionStringSwitch(StringPort match, AlternativeExec failed, Dictionary<StringPort, AlternativeExec> branches, ConditionalContext conditional = null)
        {
            TypedExecutionSwitch(ExecutionStringSwitch, match, failed, branches, conditional);
        }

        static void TypedExecutionSwitch<T>(Action<T> switchNode, T match, AlternativeExec failed, Dictionary<T, AlternativeExec> branches, ConditionalContext conditional = null) where T : AnyPort, new()
        {
            // Build switch node
            switchNode(match);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();

            // Keep track of previous exec flow for merging later.
            // We re-use this to preserve its state.
            var execFlow = ExecFlow.current;
            execFlow.Clear();

            // Build each branch
            var evaluatedBranches = new List<AlternativeExec>();
            int branchIndex = 0;
            var branchDelegates = branches.Values.Prepend(failed).ToList();

            foreach (var branch in branchDelegates)
            {
                // Don't build branches we've already built
                if (evaluatedBranches.Contains(branch)) continue;

                // Create exec flow with respective port(s) & add switch cases
                ExecFlow.current = new ExecFlow();

                for (int i = 0; i < branchDelegates.Count; i++)
                {
                    // Looking for all match values that point at this branch...
                    if (branchDelegates.ElementAt(i) != branch) continue;

                    // Add respective port
                    ExecFlow.current.Ports.Add(node.Port(0, i));

                    // Edge-case: don't add switch case for Failed pin
                    if (i == 0) continue;

                    var data = branches.Keys.ElementAt(i - 1); // -1 because we have Failed prepended
                    if (data.IsActualPort)
                        throw new Exception($"Can't create Switch Cases with actual ports. Make sure to pass a pure-data {typeof(T).Name} value!");

                    node.SwitchCases.Add(data.Data.ToString());
                }

                // Finally we can build the branch
                branch();
                evaluatedBranches.Add(branch);

                // Reset promoted variables C# state to their RR variables
                // between branches if we have a conditional context.
                // SwitchScope.Break / __Goto should handle the writing in all cases
                conditional?.ResetPromotedVariables(true);

                // Merge execution flow & continue
                execFlow.Merge(ExecFlow.current);
                branchIndex++;
            }

            // Finally restore the execution flow & continue building from there.
            ExecFlow.current = execFlow;
        }

        /// <summary>
        /// Helper for ExecutionAnySwitch/ValueAnySwitch that ensures type safety.
        /// </summary>
        private static TMatch SwitchCase<TMatch>(AnyPort data) where TMatch : AnyPort, new()
        {
            if (data is not TMatch match)
                throw new Exception($"Match value was not of type {typeof(TMatch).Name}!");

            if (!match.IsDataPort)
                throw new Exception("Can't create switch cases with dynamic data! Be sure to pass a pure-data value.");

            return match;
        }

        public static void ExecutionAnySwitch(AnyPort match, AlternativeExec failed, Dictionary<AnyPort, AlternativeExec> branches, ConditionalContext conditional = null)
        {
            if (match is IntPort matchInt) ExecutionIntegerSwitch(matchInt, failed, branches.ToDictionary(item => SwitchCase<IntPort>(item.Key), item => item.Value), conditional);
            else if (match is StringPort matchStr) ExecutionStringSwitch(matchStr, failed, branches.ToDictionary(item => SwitchCase<StringPort>(item.Key), item => item.Value), conditional);
            else throw new Exception("Unsupported match type! Make sure to pass an int or string value!");
        }

        public static TResult ValueAnySwitch<TResult>(AnyPort match, TResult defaultValue, Dictionary<AnyPort, TResult> cases) where TResult : AnyPort, new()
        {
            if (match is IntPort matchInt) return ValueIntegerSwitch(matchInt, defaultValue, cases.ToDictionary(item => SwitchCase<IntPort>(item.Key), item => item.Value));
            else if (match is StringPort matchStr) return ValueStringSwitch(matchStr, defaultValue, cases.ToDictionary(item => SwitchCase<StringPort>(item.Key), item => item.Value));
            else throw new Exception("Unsupported match type! Make sure to pass an int or string value!");
        }

        public static T ValueIntegerSwitch<T>(IntPort match, T defaultValue, Dictionary<IntPort, T> cases) where T : AnyPort, new()
        {
            return TypedValueSwitch(ValueIntegerSwitch, match, defaultValue, cases);
        }

        public static T ValueStringSwitch<T>(StringPort match, T defaultValue, Dictionary<StringPort, T> cases) where T : AnyPort, new()
        {
            return TypedValueSwitch(ValueStringSwitch, match, defaultValue, cases);
        }

        static TResult TypedValueSwitch<TMatch, TResult>(Func<TMatch, TResult, TResult> switchNode, TMatch match, TResult defaultValue, Dictionary<TMatch, TResult> cases)
            where TMatch : AnyPort, new()
            where TResult : AnyPort, new()
        {
            var switchValue = switchNode(match, defaultValue);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();
            node.InputCount += cases.Count();

            var portIndex = 2;
            foreach (var switchCase in cases)
            {
                if (switchCase.Key.IsActualPort) throw new Exception($"Can't create Switch Cases with dynamic data. Make sure to pass a pure-data {typeof(TMatch).Name} value!");

                node.SwitchCases.Add(switchCase.Key.Data.ToString());
                node.ConnectInputPort(switchCase.Value, portIndex);

                portIndex++;
            }

            return new TResult() { Port = switchValue.Port };
        }


        #endregion

        //
        // Deprecated
        //
        #region Deprecated

        [Obsolete("Use the PascalCase variant instead")]
        public static ListPort<RecRoomObjectPort> RecRoomObjectGetAllwithTag(StringPort tag)
        {
            return RecRoomObjectGetAllWithTag(tag);
        }

        [Obsolete("Use the PascalCase variant instead")]
        public static RecRoomObjectPort RecRoomObjectGetFirstwithTag(StringPort tag)
        {
            return RecRoomObjectGetFirstWithTag(tag);
        }

        [Obsolete("Use the PascalCase variant instead")]
        public static BoolPort GreaterorEqual(IntPort a, IntPort b)
        {
            return GreaterOrEqual(a, b);
        }
        [Obsolete("Use the PascalCase variant instead")]
        public static BoolPort GreaterorEqual(FloatPort a, FloatPort b)
        {
            return GreaterOrEqual(a, b);
        }
        [Obsolete("Use the PascalCase variant instead")]
        public static BoolPort LessorEqual(IntPort a, IntPort b)
        {
            return LessOrEqual(a, b);
        }
        [Obsolete("Use the PascalCase variant instead")]
        public static BoolPort LessorEqual(FloatPort a, FloatPort b)
        {
            return LessOrEqual(a, b);
        }

        #endregion

        //
        // Math Nodes
        //
        #region MathNodes

        public static FloatPort Power(FloatPort value, FloatPort power)
        {
            if (value.IsDataPort && power.IsDataPort)
                return new FloatPort { Data = Mathf.Pow(value.Data, power.Data) };

            var port = ChipBuilderGen.Power(value);
            Context.lastSpawnedNode.InputCount = 2;
            Context.lastSpawnedNode.ConnectInputPort(power, 1);
            return port;
        }

        public static IntPort Power(IntPort value, IntPort power)
        {
            if (value.IsDataPort && power.IsDataPort)
                return new IntPort { Data = (int)Mathf.Pow(value.Data, power.Data) };

            var port = ChipBuilderGen.Power(value);
            Context.lastSpawnedNode.InputCount = 2;
            Context.lastSpawnedNode.ConnectInputPort(power, 1);
            return port;
        }

        public static new FloatPort Round(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Round(value.Data) };
            return ChipBuilderGen.Round(value);
        }

        public static new FloatPort Ceil(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Ceil(value.Data) };
            return ChipBuilderGen.Ceil(value);
        }

        public static new IntPort CeilToInt(FloatPort value)
        {
            if (value.IsDataPort) return new IntPort { Data = Mathf.CeilToInt(value.Data) };
            return ChipBuilderGen.CeilToInt(value);
        }

        public static new FloatPort Floor(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Floor(value.Data) };
            return ChipBuilderGen.Floor(value);
        }

        public static new IntPort FloorToInt(FloatPort value)
        {
            if (value.IsDataPort) return new IntPort { Data = Mathf.FloorToInt(value.Data) };
            return ChipBuilderGen.FloorToInt(value);
        }

        // Circuits V2 (a)sin/cos chips work in degrees,
        // so we replicate the behaviour in the constant calculations.
        public static new FloatPort Sin(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Sin(value.Data * Mathf.Deg2Rad) };
            return ChipBuilderGen.Sin(value);
        }

        public static new FloatPort Cos(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Cos(value.Data * Mathf.Deg2Rad) };
            return ChipBuilderGen.Cos(value);
        }

        public static new FloatPort Asin(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Asin(value.Data) * Mathf.Rad2Deg };
            return ChipBuilderGen.Asin(value);
        }

        public static new FloatPort Acos(FloatPort value)
        {
            if (value.IsDataPort) return new FloatPort { Data = Mathf.Acos(value.Data) * Mathf.Rad2Deg };
            return ChipBuilderGen.Acos(value);
        }

        public static new IntPort BitShiftLeft(IntPort value, IntPort shift)
        {
            if (value.IsDataPort && shift.IsDataPort) return new IntPort { Data = value.Data << shift.Data };
            return ChipBuilderGen.BitShiftLeft(value, shift);
        }

        public static new IntPort BitShiftRight(IntPort value, IntPort shift)
        {
            if (value.IsDataPort && shift.IsDataPort) return new IntPort { Data = value.Data >> shift.Data };
            return ChipBuilderGen.BitShiftRight(value, shift);
        }

        #endregion MathNodes


        //
        // Data Table
        //
        #region DataTable

        public static T DataTableReadCell<T>(IntPort Row, DataTableColumnData config) where T : AnyPort, new()
        {
            DataTableReadCell(Row, config);
            Context.lastSpawnedNode.InputCount = 1;
            return new T() { Port = Context.lastSpawnedNode.Port(0, 0) };
        }

        public static IntPort DataTableGetFirstRowContaining<T>(T Value, DataTableColumnData config) where T : AnyPort, new()
        {
            var output = DataTableGetFirstRowContaining(config);
            Context.lastSpawnedNode.InputCount = 1;
            Context.lastSpawnedNode.ConnectInputPort(Value, 0);
            return output;
        }

        public static ListPort<IntPort> DataTableGetAllRowsContaining<T>(T Value, DataTableColumnData config) where T : AnyPort, new()
        {
            var output = DataTableGetAllRowsContaining(config);
            Context.lastSpawnedNode.InputCount = 1;
            Context.lastSpawnedNode.ConnectInputPort(Value, 0);
            return output;
        }

        #endregion

        //
        // Shorthands
        //
        #region Shorthands
        public static BoolPort LocalPlayerIsAuthority => Equals(GetAuthority(), PlayerPort.Local);
        public static BoolPort LocalPlayerIsRoomAuthority => Equals(GetRoomAuthority(), PlayerPort.Local);
        #endregion

        // 
        // Misc
        // 
        #region Misc

        public static BoolPort Equals(params object[] ports)
        {
            // casting magic needed to override the C# Equals method

            AnyPort firstPort;
            if (ports[0] is AnyPort) firstPort = (AnyPort)ports[0];
            else firstPort = new AnyPort() { Data = ports[0] };

            ChipBuilderGen.Equals(firstPort);

            var node = Context.lastSpawnedNode;
            node.InputCount = ports.Length;

            for (int i = 1; i < ports.Length; i++)
            {
                AnyPort port;
                if (ports[i] is AnyPort) port = (AnyPort)ports[i];
                else port = new AnyPort() { Data = ports[i] };

                node.ConnectInputPort(port, i);
            }

            return new BoolPort { Port = new Port { Node = node } };
        }

        public static T Self<T>() where T : AnyPort, new()
        {
            var self = Self();

            return new T() { Port = self.Port };
        }

        public static void Sequence(params AlternativeExec[] branches)
        {
            // TODO: Support conditional assignments

            // Validate number of branches
            if (branches.Length <= 0)
                throw new InvalidOperationException("Must have at least one branch for Sequence");

            if (branches.Length > 63)
                throw new InvalidOperationException("Maximum of 63 Sequence branches. One is reserved by RRCG to continue execution.");

            // Build Sequence chip
            ChipBuilderGen.Sequence<AnyPort>(() => { }, new(branches.Length + 1));
            var sequenceNode = Context.lastSpawnedNode;

            // Build branches
            for (int i=0; i < branches.Length; i++)
            {
                ExecFlow.current.Ports.Clear();
                ExecFlow.current.Ports.Add(sequenceNode.Port(0, i));

                branches[i]();
            }

            // And continue on the final, reserved pin
            ExecFlow.current.Clear();
            ExecFlow.current.Ports.Add(sequenceNode.Port(0, branches.Length));
        }

        #endregion Misc
    }
}


