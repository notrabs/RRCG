using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class Context
    {
        [JsonConverter(typeof(GuidConverter))]
        public string Id;

        public static Context current;
        public static Node lastSpawnedNode { get => Context.current.Nodes.FindLast(node => node.IsProperNode); }

        public List<Node> Nodes = new List<Node>();
        public List<Connection> Connections = new List<Connection>();

        [JsonIgnore]
        public Context ParentContext;
        public List<Context> SubContexts = new List<Context>();

        public string MetaExistingCircuitBoard;
        public List<CBFunction> MetaNewBoard;

        [JsonIgnore]
        internal Dictionary<string, object> SingletonChips = new Dictionary<string, object>();

        public Context()
        {
            Id = Guid.NewGuid().ToString();
        }

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

        public IEnumerable<Node> GetAllNodes()
        {
            IEnumerable<Node> nodes = Nodes;

            foreach (var child in SubContexts)
            {
                nodes = nodes.Concat(child.GetAllNodes());
            }

            return nodes;
        }

        public IEnumerable<Context> GetAllChildren()
        {
            IEnumerable<Context> children = new List<Context>().Concat(SubContexts);

            foreach (var child in SubContexts)
            {
                children = children.Concat(child.GetAllChildren());
            }

            return children;
        }

        private Dictionary<string, int> idCounters = new Dictionary<string, int>();
        public string GetUniqueId(string prefix)
        {
            if (ParentContext != null)
                return ParentContext.GetUniqueId(prefix);

            if (!idCounters.ContainsKey(prefix))
            {
                idCounters.Add(prefix, 1);
                return prefix;
            }

            return prefix + "_" + idCounters[prefix]++;
        }

        public void RemoveNode(Node node)
        {
            Nodes.Remove(node);
            Connections.RemoveAll(c => c.From.Node == node || c.To.Node == node);
        }

        public void RemoveConnection(Connection connection)
        {
            Connections.Remove(connection);
        }
    }

    public class CBFunction
    {
        public string Name = "";
        public List<(string, Type)> Inputs = new List<(string, Type)>();
        public List<(string, Type)> Outputs = new List<(string, Type)>();
    }
}