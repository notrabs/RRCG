using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCGBuild
{
    public class ChipBuilder : RRCGGenerated.ChipBuilderGen
    {
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

            if (eventName.Port != null)
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

            if (param0.Port != null)
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

            if (param0.Port != null || param1.Port != null)
            {
                throw new Exception("Can't create EventDefinitions with dynamic data. Make sure to pass a string value!");
            }

            node.EventDefintion.Add(param0.Data, typeof(T0));
            node.EventDefintion.Add(param1.Data, typeof(T1));
        }

        public static StringPort Concat(params StringPort[] ports)
        {
            Node node = new Node { Name = "StringConcatenateNode", InputCount = ports.Length };
            Context.current.Nodes.Add(node);

            for (int i = 0; i < ports.Length; i++)
            {
                node.ConnectInputPort(Context.current, ports[i], new Port
                {
                    Node = node,
                    Index = i
                });
            }

            return new StringPort { Port = new Port { Node = node } };
        }

        public static IntPort Add(params IntPort[] ports)
        {
            Node node = new Node { Name = "AddNode", InputCount = ports.Length };
            Context.current.Nodes.Add(node);

            for (int i = 0; i < ports.Length; i++)
            {
                node.ConnectInputPort(Context.current, ports[i], new Port
                {
                    Node = node,
                    Index = i
                });
            }

            return new IntPort { Port = new Port { Node = node } };
        }

        public static void If(BoolPort test, AlternativeExec ifBranch, AlternativeExec elseBranch)
        {
            Node node = new Node { Name = "BranchNode" };
            Context.current.Nodes.Add(node);

            node.ConnectInputPort(Context.current, test, new Port
            {
                Node = node,
                Index = 1
            });

            ExecFlow.current.Advance(Context.current, new Port { Node = node }, new Port { Node = node });

            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node });
            ifBranch();
            var ifFlow = ExecFlow.current;


            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port { Node = node, Index = 1 });
            elseBranch();
            var elseFlow = ExecFlow.current;

            ExecFlow.current.Clear();
            ExecFlow.current.Merge(ifFlow);
            ExecFlow.current.Merge(elseFlow);
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
            if (match is IntPort) ExecutionIntegerSwitch((IntPort)match, failed, branches.ToDictionary(item => (IntPort)item.Key, item => item.Value));
            else if (match is StringPort) ExecutionStringSwitch((StringPort)match, failed, branches.ToDictionary(item => (StringPort)item.Key, item => item.Value));
            else throw new Exception("Can't create Switch Cases with dynamic data. Make sure to pass a string value!");
        }

        public static T Self<T>() where T : AnyPort, new()
        {
            var self = Self();

            return new T() { Port = self.Port };
        }
    }
}


