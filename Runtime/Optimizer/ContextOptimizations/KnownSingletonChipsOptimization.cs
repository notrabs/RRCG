using RRCGBuild;
using RRCGGenerated;
using System.Collections.Generic;

namespace RRCG.Optimizer.ContextOptimizations
{
    class KnownSingletonChipsOptimization : IContextOptimization
    {
        // These chip types all output the same value(s) regardless of any factor,
        // and as such you can get away with having only one per context (at the cost of messy wires).
        private static List<string> KnownSingletonTypes = new()
        {
            ChipType.GetAllPlayers, ChipType.GetAuthority, ChipType.GetBroadcastingAttendance,
            ChipType.GetLoadingPlayers, ChipType.GetLocalCameraForward, ChipType.GetLocalCameraPosition,
            ChipType.GetLocalCameraRotation, ChipType.GetLocalCameraUp, ChipType.GetLocalPlayer,
            ChipType.GetRoomAuthority, ChipType.GraphGetIsActive, ChipType.InstanceGetIsEvent,
            ChipType.InstanceGetIsPrivate, ChipType.InstanceGetMaxPlayers, ChipType.LocalPlayerGazeDirection,
            ChipType.LocalPlayerGazeOrigin, ChipType.TimeGetPreciseSeconds, ChipType.TimeGetUniversalSeconds,
            ChipType.TimeGetUniversalTime, ChipType.TimeGetUnsyncedUniversalSeconds, ChipType.TimeGetUnsyncedUniversalTime,
            ChipType.Self, 
        };

        public int OptimizeContext(Context context)
        {
            int removedNodes = 0;

            // Map node type -> instances of node type
            Dictionary<string, List<Node>> typeToNodes = new();

            foreach (var type in KnownSingletonTypes)
                typeToNodes[type] = new List<Node>();

            // Collect instances of each node type
            foreach (var node in context.Nodes)
            {
                if (!KnownSingletonTypes.Contains(node.Type))
                    continue;

                typeToNodes[node.Type].Add(node);
            }

            // Remove all but the first instance
            foreach (var kvp in typeToNodes)
            {
                var nodes = kvp.Value;

                // Rewire all connections from any node
                // in the list to originate from the first node
                foreach (var connection in context.Connections)
                {
                    if (nodes.Contains(connection.From.Node))
                        connection.From.Node = nodes[0];
                }

                // Remove all but the first node from the context
                for (int i=1; i < nodes.Count; i++)
                {
                    context.RemoveNode(nodes[i]);
                    removedNodes++;
                }
            }

            return removedNodes;
        }
    }
}
