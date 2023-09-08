using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
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