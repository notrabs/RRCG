using RRCGGenerated;
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
            EventReceiver();

            if (eventName.Port != null)
            {
                throw new Exception("Can't create EventReceivers with dynamic data. Make sure to pass a string value!");
            }

            Context.lastSpawnedNode.EventName = eventName.Data;
        }

        public static T0 EventReceiver<T0>(StringPort eventName) where T0 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return new T0() { Port = new Port { Node = node, Index = 1 } };
        }

        public static (T0, T1) EventReceiver<T0, T1>(StringPort eventName)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            EventReceiver(eventName);
            var node = Context.lastSpawnedNode;

            return (new T0() { Port = new Port { Node = node, Index = 1 } }, new T1() { Port = new Port { Node = node, Index = 2 } });
        }

        public static void EventSender(StringPort eventName)
        {
            EventSender();

            if (eventName.Port != null)
            {
                throw new Exception("Can't create EventSenders with dynamic data. Make sure to pass a string value!");
            }

            Context.lastSpawnedNode.EventName = eventName.Data;
        }

        public static void EventSender<T0>(StringPort eventName, T0 value0) where T0 : AnyPort
        {
            EventSender(eventName);
            var node = Context.lastSpawnedNode;

            node.ConnectInputPort(Context.current, value0, new Port { Node = node, Index = 1 });
        }

        public static void EventSender<T0, T1>(StringPort eventName, T0 value0, T1 value1) where T0 : AnyPort where T1 : AnyPort
        {
            EventSender(eventName);
            var node = Context.lastSpawnedNode;

            node.ConnectInputPort(Context.current, value0, new Port { Node = node, Index = 1 });
            node.ConnectInputPort(Context.current, value1, new Port { Node = node, Index = 2 });
        }

        public static void EventDefinition(StringPort eventName)
        {
            EventDefinition();
            var node = Context.lastSpawnedNode;

            if (eventName.IsActualPort)
            {
                throw new Exception("Can't create EventDefinitions with dynamic data. Make sure to pass a string value!");
            }

            node.EventName = eventName.Data;
            node.EventDefintion = new Dictionary<string, Type>();
        }


        public static void EventDefinition<T0>(StringPort eventName, StringPort param0) where T0 : AnyPort, new()
        {
            EventDefinition(eventName);
            var node = Context.lastSpawnedNode;

            if (param0.IsActualPort)
            {
                throw new Exception("Can't create EventDefinitions with dynamic data. Make sure to pass a string value!");
            }

            node.EventDefintion.Add(param0.Data, typeof(T0));
        }

        public static void EventDefinition<T0, T1>(StringPort eventName, StringPort param0, StringPort param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            EventDefinition(eventName);
            var node = Context.lastSpawnedNode;

            if (param0.IsActualPort || param1.IsActualPort)
            {
                throw new Exception("Can't create EventDefinitions with dynamic data. Make sure to pass a string value!");
            }

            node.EventDefintion.Add(param0.Data, typeof(T0));
            node.EventDefintion.Add(param1.Data, typeof(T1));
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
        public static string Add(params string[] ports)
        {
            return String.Join("", ports);
        }
        public static StringPort Add(params StringPort[] ports)
        {
            return Concat(ports);
        }

        public static int Add(params int[] ports)
        {
            return ports.Sum();
        }
        public static IntPort Add(params IntPort[] ports)
        {
            ChipBuilderGen.Add(ports[0]);
            return ConnectDynamicPins(0, ports);
        }
        public static float Add(params float[] ports)
        {
            return ports.Sum();
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
        public static T ListCreate<T>(params T[] ports) where T : AnyPort, new()
        {
            ChipBuilderGen.ListCreate(ports[0]);
            return ConnectDynamicPins(0, ports);
        }

        // Assumes first pin has already been connected
        private static T ConnectDynamicPins<T>(int offset, params T[] ports) where T : AnyPort, new()
        {
            var node = Context.lastSpawnedNode;
            node.InputCount = ports.Length + offset;

            for (int i = 1; i < ports.Length; i++)
            {
                node.ConnectInputPort(Context.current, ports[i], new Port
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
            var conditionalContext = ConditionalContext.Push(new IfConditionalContext() { test = test, currentBranch = true });
            ifBranch();
            var ifFlow = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node, Index = 1 });
            conditionalContext.currentBranch = false;
            elseBranch();
            ConditionalContext.Pop();
            var elseFlow = ExecFlow.current;

            ExecFlow.current = prevFlow;

            if (ifFlow.hasAdvanced || elseFlow.hasAdvanced)
            {
                ExecFlow.current.Advance(Context.current, new Port { Node = node }, new Port { Node = node });

                ExecFlow.current.Clear();
                ExecFlow.current.Merge(ifFlow);
                ExecFlow.current.Merge(elseFlow);
            }
            else
            {
                Context.current.Nodes.Remove(node);
            }
        }

        public static void ExecutionIntegerSwitch(IntPort match, AlternativeExec failed, Dictionary<IntPort, AlternativeExec> branches)
        {
            ExecutionIntegerSwitch(match);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();

            var execFlow = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node });
            failed();
            var defaultFlow = ExecFlow.current;

            execFlow.Merge(defaultFlow);

            int branchIndex = 0;
            foreach (var branch in branches)
            {
                if (branch.Key.Port != null) throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a string value!");
                node.SwitchCases.Add(branch.Key.Data.ToString());

                ExecFlow.current = new ExecFlow();
                ExecFlow.current.Ports.Add(new Port { Node = node, Index = 1 + branchIndex });
                branch.Value();
                var branchFlow = ExecFlow.current;

                execFlow.Merge(branchFlow);

                branchIndex++;
            }
        }

        public static void ExecutionStringSwitch(StringPort match, AlternativeExec failed, Dictionary<StringPort, AlternativeExec> branches)
        {
            ExecutionStringSwitch(match);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();

            var execFlow = ExecFlow.current;

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node });
            failed();
            var defaultFlow = ExecFlow.current;

            execFlow.Merge(defaultFlow);

            int branchIndex = 0;
            foreach (var branch in branches)
            {
                if (branch.Key.Port != null) throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a string value!");
                node.SwitchCases.Add(branch.Key.Data.ToString());

                ExecFlow.current = new ExecFlow();
                ExecFlow.current.Ports.Add(new Port { Node = node, Index = 1 + branchIndex });
                branch.Value();
                var branchFlow = ExecFlow.current;

                execFlow.Merge(branchFlow);

                branchIndex++;
            }
        }

        public static void ExecutionAnySwitch(AnyPort match, AlternativeExec failed, Dictionary<AnyPort, AlternativeExec> branches)
        {
            if (match is IntPort) ExecutionIntegerSwitch((IntPort)match, failed, branches.ToDictionary(item => new IntPort() { Data = item.Key.Data }, item => item.Value));
            else if (match is StringPort) ExecutionStringSwitch((StringPort)match, failed, branches.ToDictionary(item => new StringPort() { Data = item.Key.Data }, item => item.Value));
            else throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a int or string value!");
        }

        public static T ValueIntegerSwitch<T>(IntPort match, T defaultValue, Dictionary<IntPort, T> cases) where T : AnyPort, new()
        {
            var switchValue = ValueIntegerSwitch(match, defaultValue);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();
            node.InputCount += cases.Count();

            var portIndex = 2;
            foreach (var switchCase in cases)
            {
                if (switchCase.Key.IsActualPort) throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a int value!");

                node.SwitchCases.Add(switchCase.Key.Data.ToString());
                node.ConnectInputPort(switchCase.Value, portIndex);

                portIndex++;
            }

            return new T() { Port = switchValue.Port };
        }

        public static T ValueStringSwitch<T>(StringPort match, T defaultValue, Dictionary<StringPort, T> cases) where T : AnyPort, new()
        {
            var switchValue = ValueStringSwitch(match, defaultValue);
            var node = Context.lastSpawnedNode;
            node.SwitchCases = new List<string>();
            node.InputCount += cases.Count();

            var portIndex = 2;
            foreach (var switchCase in cases)
            {
                if (switchCase.Key.IsActualPort) throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a string value!");

                node.SwitchCases.Add(switchCase.Key.Data);
                node.ConnectInputPort(switchCase.Value, portIndex);

                portIndex++;
            }

            return new T() { Port = switchValue.Port };
        }


        #endregion

        // 
        // Misc
        // 

        public static BoolPort Equals(params object[] ports)
        {
            ChipBuilderGen.Equals((AnyPort)ports[0]);
            var node = Context.lastSpawnedNode;
            node.InputCount = ports.Length;

            for (int i = 1; i < ports.Length; i++)
            {
                // casting magic needed to override the C# Equals method
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
    }
}


