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

        /// <summary>
        /// Copies a data port from one node to another, by either copying the default value or another data connection.
        /// Removes/Overwrites existing connections.
        /// </summary>
        public static void CopyDataInputPort(Context context, Port fromPort, Port toPort)
        {
            var fromNode = fromPort.Node;
            var toNode = toPort.Node;

            var fromKey = (fromPort.Group, fromPort.Index);
            var toKey = (fromPort.Group, fromPort.Index);

            // copy the default value state
            if (fromNode.DefaultValues.ContainsKey(fromKey))
                toNode.DefaultValues[toKey] = fromNode.DefaultValues[fromKey];
            else toNode.DefaultValues.Remove(toKey);

            // copy the connection state
            var existingConnectionFromPort = context.Connections.Find(c => c.To.EquivalentTo(fromPort));
            var existingConnectionToPort = context.Connections.Find(c => c.To.EquivalentTo(toPort));

            if (existingConnectionFromPort != null)
            {
                // Rewrite the existing connection or create a new connection to copy the connection to fromPort
                if (existingConnectionToPort != null) existingConnectionToPort.From = existingConnectionFromPort.From;
                else
                {
                    context.Connections.Add(new Connection { From = existingConnectionFromPort.From, To = toPort });
                    toNode.DefaultValues.Remove(toKey);
                }
            }
            else if (existingConnectionToPort != null)
            {
                // connection removal is only needed if the target port is connected
                context.RemoveConnection(existingConnectionToPort);
            }
        }

    }
}
