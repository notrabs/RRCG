#nullable enable
using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG
{
    public static class GraphUtils
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
        /// Copies a data port from one node to another, by either copying the default value or an existing data connection.
        /// Removes/Overwrites existing connections.
        /// </summary>
        public static void CopyDataInputPort(Context context, Port fromPort, Port toPort)
        {
            var fromNode = fromPort.Node;
            var toNode = toPort.Node;

            var fromKey = (fromPort.Group, fromPort.Index);
            var toKey = (toPort.Group, toPort.Index);

            // copy the default value state
            if (fromNode.DefaultValues.ContainsKey(fromKey))
                toNode.DefaultValues[toKey] = fromNode.DefaultValues[fromKey];
            else toNode.DefaultValues.Remove(toKey);

            // copy the connection state
            var existingConnectionFromPort = context.Connections.Find(c => c.To.EquivalentTo(fromPort));
            var existingConnectionToPort = context.Connections.Find(c => c.To.EquivalentTo(toPort));

            if (existingConnectionFromPort != null)
            {
                // If the target port is already connected, rewrite the connection instead of creating a new one.
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

        /// <see cref="BuildWithAnalysis(Action)"/>
        public class GraphAnalysis
        {
            public Port? ExecEntry { get; init; }
            public IReadOnlyList<Node> Nodes { get; init; }
            public ExecFlow FinalExecFlow { get; init; }

            public GraphAnalysis(Port? entry, List<Node> nodes, ExecFlow finalFlow)
            {
                ExecEntry = entry;
                Nodes = nodes;
                FinalExecFlow = finalFlow;
            }
        }

        /// <see cref="BuildWithAnalysis{TReturn}(Func{TReturn})"/>
        public class GraphAnalysis<TReturn> : GraphAnalysis
        {
            public TReturn ReturnValue { get; init; }

            public GraphAnalysis(Port? entry, List<Node> nodes, ExecFlow finalFlow, TReturn returnData)
                : base(entry, nodes, finalFlow)
            {
                ReturnValue = returnData;
            }
        }

        /// <summary>
        /// Builds the graph, and returns the execution entry port, and the nodes that were generated.
        /// </summary>
        public static GraphAnalysis<TReturn> BuildWithAnalysis<TReturn>(Func<TReturn> graph)
        {
            return CircuitBuilder.InlineGraph(() =>
            {
                // Use a temporary node to determine the entry point.
                // The ExecFlow will contain the "Run" output port of the delay.
                ChipBuilder.Delay(0f, () => { }, () => { });
                var tempNode = Context.lastSpawnedNode;
                var context = Context.current;

                // Take note of the current nodes, build the
                // graph, and record the difference.
                var currentNodes = Context.current.Nodes.ToList(); // shallow copy
                var returnData = graph();
                var newNodes = Context.current.Nodes.Except(currentNodes).ToList();

                // Query the context for the entry point.
                var port = context.Connections
                                  .Where(c => c.From.EquivalentTo(tempNode.Port(0, 0)))
                                  .FirstOrDefault()?.To;

                // Finally, remove the temporary node and return.
                Context.current.RemoveNode(tempNode);
                return new GraphAnalysis<TReturn>(port, newNodes, ExecFlow.current, returnData);
            });
        }

        /// <inheritdoc/>
        public static GraphAnalysis BuildWithAnalysis(Action graph)
        {
            // Doing this weird thing to avoid duplicate code.
            return BuildWithAnalysis<dynamic>(() => { graph(); return null!; });
        }
    }
}
#nullable disable