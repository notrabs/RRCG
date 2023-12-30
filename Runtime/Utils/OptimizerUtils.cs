using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG.Optimizer
{
    public static class OptimizerUtils
    {
        /// <summary>
        /// Removes a node, if it has no more outgoing connections. 
        /// This is safe for data nodes, as they are non-reachable in this case.
        /// </summary>
        public static void RemoveDanglingDataNode(Context context, Node node)
        {
            if (context.Connections.Find(c => c.From.Node == node) == null) context.RemoveNode(node);
        }

    }
}
