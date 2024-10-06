using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using static RRCG.GraphUtils;

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
        public Context? ParentContext { get; internal set; }
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
            // Adding items to this Context will remove them from the other.
            // So, we take a shallow copy of everything:

            var copyNodes = context.Nodes.ToList(); // shallow copy
            var copyConnections = context.Connections.ToList(); // shallow copy
            var copySubcontexts = context.SubContexts.ToList(); // shallow copy

            foreach (var node in copyNodes)
                AddNode(node);

            foreach (var connection in copyConnections)
                AddConnection(connection);

            foreach (var subcontext in copySubcontexts)
                AddSubContext(subcontext);
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

        public void AddNode(Node node)
        {
            if (node.Context != null)
                node.Context.RemoveNode(node);

            node.Context = this;
            Nodes.Add(node);
        }

        public void RemoveNode(Node node)
        {
            if (node.Context != this)
                throw new InvalidOperationException("Node did not belong to this context!");

            node.Context = null;
            Nodes.Remove(node);
            Connections.RemoveAll(c => c.From.Node == node || c.To.Node == node);
        }

        public virtual void AddConnection(Connection connection)
        {
            // Only throw an exception, if the context is a concrete context. The connections will be checked again, once an Analysis context is merged into a real one
            if (connection.From.Node.Context != this && !(connection.From.Node.Context is GraphAnalysisContext))
                throw new Exception("Can't connect from a node in another context!");

            // Only throw an exception, if the context is a concrete context. The connections will be checked again, once an Analysis context is merged into a real one
            if (connection.To.Node.Context != this && !(connection.To.Node.Context is GraphAnalysisContext))
                throw new Exception("Can't connect to a node in another context!");

            Connections.Add(connection);
        }

        public void RemoveConnection(Connection connection)
        {
            Connections.Remove(connection);
        }

        public void AddSubContext(Context subContext)
        {
            if (subContext == this)
                throw new InvalidOperationException("A context cannot be its own parent!");

            if (subContext.ParentContext != null)
                subContext.ParentContext.RemoveSubContext(subContext);

            subContext.ParentContext = this;
            SubContexts.Add(subContext);
        }

        public void RemoveSubContext(Context subContext)
        {
            if (subContext.ParentContext != this)
                throw new InvalidOperationException("Subcontext did not belong to this context!");

            subContext.ParentContext = null;
            SubContexts.Remove(subContext);
        }
    }

    public class CBFunction
    {
        public string Name = "";
        public List<(string, Type)> Inputs = new List<(string, Type)>();
        public List<(string, Type)> Outputs = new List<(string, Type)>();
    }
}