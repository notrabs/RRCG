using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public delegate void AlternativeExec();

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

    public class ExecFlow
    {
        public static ExecFlow current;

        public List<Port> Ports = new List<Port>();

        public void Advance(Context context, Port inPort, Port outPort)
        {
            if (inPort != null)
            {
                foreach (Port port in Ports)
                {
                    context.Connections.Add(new Connection
                    {
                        From = port,
                        To = inPort,
                        isExec = true,
                    });
                }

            }

            Ports.Clear();

            if (outPort != null)
            {
                Ports.Add(outPort);
            }
        }


        public void Clear()
        {
            Ports.Clear();
        }

        public void Merge(ExecFlow flow)
        {
            Ports.AddRange(flow.Ports);
        }
    }

    public class Connection
    {
        public Port From;
        public Port To;

        public bool isExec = false;
    }

    public class Context
    {
        public static Context current;
        public static Node lastSpawnedNode { get => Context.current.Nodes.Last(); }

        public List<Node> Nodes = new List<Node>();
        public List<Connection> Connections = new List<Connection>();

        public string MetaExistingCircuitBoard;
        public Context ParentContext;
        public List<Context> SubContexts = new List<Context>();

        public void Merge(Context context)
        {
            this.Nodes.AddRange(context.Nodes);
            this.Connections.AddRange(context.Connections);
        }

        public IEnumerable<Context> GetAncestors()
        {
            Context parent = this;
            while (parent != null)
            {
                yield return parent;
                parent = parent.ParentContext;
            }
        }

        private int idCounter = 0;
        public int GetUniqueId()
        {
            if (ParentContext != null)
                return ParentContext.GetUniqueId();
            return idCounter++;
        }
    }


}