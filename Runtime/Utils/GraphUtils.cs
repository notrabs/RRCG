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
                    context.AddConnection(new Connection { From = existingConnectionFromPort.From, To = toPort });
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
            public GraphAnalysisContext AnalyzedContext { get; init; }
            public ExecFlow FinalExecFlow { get; init; }

            public GraphAnalysis(Port? entry, GraphAnalysisContext context, ExecFlow finalFlow)
            {
                ExecEntry = entry;
                AnalyzedContext = context;
                FinalExecFlow = finalFlow;
            }
        }

        /// <see cref="BuildWithAnalysis{TReturn}(Func{TReturn})"/>
        public class GraphAnalysis<TReturn> : GraphAnalysis
        {
            public TReturn ReturnValue { get; init; }

            public GraphAnalysis(Port? entry, GraphAnalysisContext context, ExecFlow finalFlow, TReturn returnData)
                : base(entry, context, finalFlow)
            {
                ReturnValue = returnData;
            }
        }

        public class GraphAnalysisContext : Context
        {
            public override void AddConnection(Connection connection)
            {
                // In a GraphAnalysisContext, we'll happily accept
                // any connection, regardless of whether or not the
                // associated Nodes are in different contexts.
                Connections.Add(connection);
            }
        }

        /// <summary>
        /// Builds the graph, and returns the execution entry port, and the nodes that were generated.
        /// </summary>
        public static GraphAnalysis<TReturn> BuildWithAnalysis<TReturn>(Func<TReturn> graph)
        {
            // Backup ExecFlow & context
            var prevExecFlow = ExecFlow.current;
            var prevContext = Context.current;

            // Create new ExecFlow & context.
            // We'll use a special context, GraphAnalysisContext,
            // which allows any connection to be made.
            var analysisContext = new GraphAnalysisContext();
            ExecFlow.current = new ExecFlow();
            Context.current = analysisContext;

            // Use a temporary node to determine the entry point.
            // The ExecFlow will contain the "Run" output port of the delay.
            ChipBuilder.Delay(0f, () => { }, () => { });
            var tempNode = Context.lastSpawnedNode;

            // Now we can build the graph, and take note
            // of the return data.
            var returnData = graph();

            if (Context.current != analysisContext)
                throw new Exception("Context changed unexpectedly!");

            // Query the context for the entry point,
            // then remove the temporary node.
            var entryPort = analysisContext.Connections
                              .Where(c => c.From.EquivalentTo(tempNode.Port(0, 0)))
                              .FirstOrDefault()?.To;
            analysisContext.RemoveNode(tempNode);

            // Restore Context/ExecFlow, and return.
            var finalExecFlow = ExecFlow.current;
            ExecFlow.current = prevExecFlow;
            Context.current = prevContext;
            return new GraphAnalysis<TReturn>(entryPort, analysisContext, finalExecFlow, returnData);
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