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
        public int InputCount { get; internal set; }

        public Dictionary<Port, object> DefaultValues = new Dictionary<Port, object>();

        public Dictionary<string, Type> EventDefintion = null;

        public List<string> SwitchCases = null;

        public void ConnectInputPort(Context context, AnyPort port, Port input)
        {
            if (port.Port != null)
            {
                context.Connections.Add(new Connection { From = port.Port, To = input });
            }
            else
            {
                DefaultValues.Add(input, port.Data);
            }
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