using RRCGBuild;
using RRCGGenerated;
using System.Collections.Generic;
using System.Linq;

namespace RRCG.Optimizer.ContextOptimizations
{
    class AssociativeOperationCollapserOptimization : IContextOptimization
    {
        delegate bool TryCollapseDelegate(int index, List<AnyPort> from, List<AnyPort> into);

        static Dictionary<string, TryCollapseDelegate> CollapseImplementations = new()
        {
            { ChipType.Add, BasicCollapse },
            { ChipType.Multiply, BasicCollapse },
            { ChipType.StringConcat, StringConcatCollapse }
        };

        public int OptimizeContext(Context context)
        {
            // First, get the input connections for each node.
            var nodeToInputConnections = new Dictionary<Node, List<List<AnyPort>>>();
            var nodeInputsDirty = new Dictionary<Node, bool>();
            foreach (var node in context.Nodes)
            {
                nodeToInputConnections[node] = GetNodeInputConnections(context, node);
                nodeInputsDirty[node] = false;
            }

            // Now begin collapsing nodes
            var nodesToRemove = new List<Node>();
            foreach (var node in context.Nodes)
            {
                // Ensure this node is supported
                if (!CollapseImplementations.ContainsKey(node.Type))
                    continue;

                // We can't collapse into a node
                // that's going to be removed!
                if (nodesToRemove.Contains(node))
                    continue;

                // Try to find connected nodes to collapse into the current node.
                var connections = nodeToInputConnections[node];
                for (int group = 0; group < connections.Count; group++)
                {
                    for (int index = 0; index < connections[group].Count; index++)
                    {
                        // Must be actual port
                        var port = connections[group][index];
                        if (!port.IsActualPort) continue;

                        // Associated nodes type must match
                        var otherNode = port.Port.Node;
                        if (otherNode.Type != node.Type) continue;

                        // Try to collapse the node
                        if (!CollapseImplementations[node.Type](index, nodeToInputConnections[otherNode][group], connections[group]))
                            continue;

                        // We've collapsed the inputs of the other node
                        // into the current node.
                        nodeInputsDirty[node] = true;

                        // But can we delete the other node?
                        // We can only delete it if it was only connected to the current node.
                        // (if the node it was connected to will be removed, it's fine)
                        bool deletable = context.Connections.Where(c => c.From.Node == otherNode &&
                                                                        c.To.Node != node &&
                                                                        !nodesToRemove.Contains(c.To.Node)).Count() <= 0;

                        if (deletable && !nodesToRemove.Contains(otherNode))
                            nodesToRemove.Add(otherNode);

                        // Finally decrement index to check the same port again
                        index--;
                    }
                }
            }

            // Remove collapsed nodes
            foreach (var node in nodesToRemove)
                GraphOptimizer.RemoveNodeFromContext(context, node);

            // Apply new connection information
            foreach (var node in context.Nodes)
                if (nodeInputsDirty[node])
                    SetNodeInputConnections(context, node, nodeToInputConnections[node]);

            return nodesToRemove.Count;
        }

        // Collapse implementations
        static bool BasicCollapse(int index, List<AnyPort> from, List<AnyPort> into)
        {
            // Ensure we don't exceed the maximum inputs
            if (from.Count + into.Count > 64) return false;

            into.RemoveAt(index);
            into.InsertRange(index, from);
            return true;
        }

        static bool StringConcatCollapse(int index, List<AnyPort> from, List<AnyPort> into)
        {
            // Validate we aren't trying to collapse into the seperator port
            if (index == 0) return false;

            // Ensure we don't exceed the maximum inputs
            if ((from.Count - 1) + (into.Count - 1) > 64) return false;

            // Validate the seperator ports are equal
            if (!PortsEqualForCollapse(from[0], into[0])) return false;

            // Collapse the ports (excluding seperator)
            into.RemoveAt(index);
            into.InsertRange(index, from.Skip(1));
            return true;
        }

        static bool PortsEqualForCollapse(AnyPort a, AnyPort b)
        {
            // Actual port status must match
            if (a.IsActualPort != b.IsActualPort) return false;

            if (a.IsActualPort)
            {
                // Port source must match
                return a.Port.Group == b.Port.Group &&
                       a.Port.Index == b.Port.Index &&
                       a.Port.Node == b.Port.Node;
            }

            // Data must match
            return a.Data == b.Data;
        }

        // Gets all input connections, both default values & actual ports.
        List<List<AnyPort>> GetNodeInputConnections(Context context, Node node)
        {
            var groupToIndexToPort = new Dictionary<int, Dictionary<int, AnyPort>>();

            // Default values first
            foreach (var defaultValue in node.DefaultValues)
            {
                (int group, int index) = defaultValue.Key;

                if (!groupToIndexToPort.ContainsKey(group))
                    groupToIndexToPort[group] = new Dictionary<int, AnyPort>();

                groupToIndexToPort[group][index] = new AnyPort { Data = defaultValue.Value };
            }

            // Now connections (overwriting default values where necessary)
            foreach (var connection in context.Connections.Where(c => c.To.Node == node))
            {
                int group = connection.To.Group;
                int index = connection.To.Index;

                if (!groupToIndexToPort.ContainsKey(group))
                    groupToIndexToPort[group] = new Dictionary<int, AnyPort>();

                groupToIndexToPort[group][index] = new AnyPort { Port = connection.From };
            }

            // Finally, we should have all connections.
            // Crunch it all down into a 2D list.
            var connections = new List<List<AnyPort>>();
            if (groupToIndexToPort.Keys.Count <= 0)
                return connections;

            // Pre-fill groups (solves case where earlier groups have no connections)
            // (TODO: do we have to consider disconnected ports without a default value?)
            for (int i=0; i < groupToIndexToPort.Keys.Max() + 1; i++)
                connections.Add(new List<AnyPort>());

            foreach (int group in groupToIndexToPort.Keys.OrderBy(g => g))
                foreach (int index in groupToIndexToPort[group].Keys.OrderBy(i => i))
                    connections[group].Add(groupToIndexToPort[group][index]);

            return connections;
        }

        void SetNodeInputConnections(Context context, Node node, List<List<AnyPort>> groupToIndexToPort)
        {
            // Clear all connections
            node.DefaultValues.Clear();
            foreach (var connection in context.Connections.ToList()) // shallow copy
            {
                if (connection.To.Node == node)
                    context.Connections.Remove(connection);
            }

            // Re-connect input ports
            for (int group = 0; group < groupToIndexToPort.Count; group++)
            {
                for (int index = 0; index < groupToIndexToPort[group].Count; index++)
                {
                    node.ConnectInputPort(context,
                                          groupToIndexToPort[group][index],
                                          new Port { Node = node, Group = group, Index = index });
                }
            }

            node.InputCount = groupToIndexToPort.Sum(g => g.Count);
        }
    }
}
