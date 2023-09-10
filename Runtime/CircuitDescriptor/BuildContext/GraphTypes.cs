using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class Node
    {
        public string Name;
        public string Type;

        public string EventName { get; internal set; }
        public string VariableName { get; internal set; }
        public VariableKind VariableKind { get; internal set; }
        public object VariableHomeValue { get; internal set; }

        public int InputCount { get; internal set; }
        public Dictionary<Port, object> DefaultValues = new Dictionary<Port, object>();
        public Dictionary<string, Type> EventDefintion = null;
        public List<string> SwitchCases = null;

        // The scope of this conditional context
        public ConditionalContext MetaConditionalContext = null;

        public Node()
        {
            MetaConditionalContext = ConditionalContext.current;
        }

        public void ConnectInputPort(Context context, AnyPort port, Port input)
        {
            if (port.IsActualPort) context.Connections.Add(new Connection { From = port.Port, To = input });
            else DefaultValues.Add(input, port.Data);
        }

        public Port ConnectInputPort(AnyPort port, int inputIndex)
        {
            var input = new Port() { Node = this, Index = inputIndex };
            ConnectInputPort(Context.current, port, input);
            return input;
        }
    }

    public class Port
    {
        public Node Node;
        public int Group = 0;
        public int Index = 0;
    }

    public class Connection
    {
        public Port From;
        public Port To;

        public bool isExec = false;
    }
}