using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCG.Optimizer.ContextOptimizations
{
    class IfOptimization : IContextOptimization
    {
        delegate bool IfNotOptimizationImpl(Context context, Node node);

        static Dictionary<string, IfNotOptimizationImpl> Implementations = new()
        {
            { ChipType.If, OptimizeIfNode },
            { ChipType.IfValue, OptimizeIfValueNode }
        };

        public int OptimizeContext(Context context)
        {
            int optimized = 0;

            foreach (var node in context.Nodes.ToList())
            {
                var hasBeenOptimized = false;

                // Optimize in a loop, to optimize notIfs that are followed by more optimizable conditions
                do
                {
                    hasBeenOptimized = Implementations.ContainsKey(node.Type) && Implementations[node.Type](context, node);
                    if (hasBeenOptimized) optimized++;
                } while (hasBeenOptimized);
            }

            return optimized;
        }

        static bool OptimizeIfNode(Context context, Node ifNode)
        {
            var connectionToIf = context.Connections.Find(c => c.To.Node == ifNode && c.To.Index == 1);
            if (connectionToIf == null) return false;

            var prevNode = connectionToIf.From.Node;

            switch (prevNode.Type)
            {
                case ChipType.Not:
                    return OptimizeNotIf(context, ifNode, connectionToIf, prevNode);
                case ChipType.Equals:
                    return OptimizeEqualsIf(context, ifNode, connectionToIf, prevNode);
                case ChipType.PlayerGetIsLocal:
                    return OptimizePlayerGetIsLocalIf(context, ifNode, prevNode);
                case ChipType.PlayerHasRole:
                    return OptimizePlayerHasRoleIf(context, ifNode, prevNode);
                // TODO: IfLocalPlayerShouldRun (does anyone even use this chip voluntarily?)
                // TODO: IfPlayerIsValid (this needs the type knowledge of the actual isValid input. maybe we can attach this to the node during compilation?)
                // TODO: IfPlayerIsValidAndLocal (warning, this chip has three outputs! and it requires type knowledge of the isValid chip)
            }

            return false;
        }

        /// <summary>
        /// Checks if an Equals+If can be replaced with either IfLocalPlayerIsAuthority or IfLocalPlayerIsRoomAuthority
        /// </summary>
        static bool OptimizeEqualsIf(Context context, Node ifNode, Connection connectionToIf, Node equalsNode)
        {
            if (equalsNode.InputCount != 2) return false;

            var inputConnections = context.Connections.Where(c => c.To.Node == equalsNode).OrderBy(c => c.To, new PortComparer()).ToArray();
            var inputNodes = inputConnections.Select(c => c.From.Node).ToArray();

            string replaceType = null;

            if (inputNodes.Length == 0) return false;
            if (inputNodes.Length == 1)
            {
                var unconnectedIndex = inputConnections[0].To.Index == 0 ? 1 : 0;

                switch (inputNodes[0].Type)
                {
                    case ChipType.GetAuthority:
                        replaceType = ChipType.IfLocalPlayerIsAuthority;
                        break;
                    case ChipType.GetRoomAuthority:
                        replaceType = ChipType.IfLocalPlayerIsRoomAuthority;
                        break;
                    default:
                        return false;
                }

                var unconnectedPortKey = (0, unconnectedIndex);

                // Check if the unconnected port is the "Local Player" default value
                if (!equalsNode.DefaultValues.ContainsKey(unconnectedPortKey) ||
                    equalsNode.DefaultValues[(0, unconnectedIndex)] is not int ||
                    (int)equalsNode.DefaultValues[(0, unconnectedIndex)] != 1) return false;
            }
            else
            {
                Node checkNode;

                if (inputNodes[0].Type == ChipType.GetLocalPlayer) checkNode = inputNodes[1];
                else if (inputNodes[1].Type == ChipType.GetLocalPlayer) checkNode = inputNodes[0];
                else return false;

                switch (checkNode.Type)
                {
                    case ChipType.GetAuthority:
                        replaceType = ChipType.IfLocalPlayerIsAuthority;
                        break;
                    case ChipType.GetRoomAuthority:
                        replaceType = ChipType.IfLocalPlayerIsRoomAuthority;
                        break;
                    default:
                        return false;
                }
            }

            ifNode.Type = replaceType;
            ifNode.InputCount = 1;
            context.RemoveConnection(connectionToIf);

            OptimizerUtils.RemoveDanglingDataNode(context, equalsNode);
            foreach (var nodeToRemove in inputNodes) OptimizerUtils.RemoveDanglingDataNode(context, nodeToRemove);

            return true;
        }

        static bool OptimizePlayerGetIsLocalIf(Context context, Node ifNode, Node isLocalNode)
        {
            ifNode.Type = ChipType.IfPlayerIsLocal;
            OptimizerUtils.CopyDataInputPort(context, isLocalNode.Port(0, 0), ifNode.Port(0, 1));

            OptimizerUtils.RemoveDanglingDataNode(context, isLocalNode);

            return true;
        }

        static bool OptimizePlayerHasRoleIf(Context context, Node ifNode, Node hasRoleNode)
        {
            ifNode.Type = ChipType.IfPlayerHasRole;
            ifNode.InputCount += 1;
            OptimizerUtils.CopyDataInputPort(context, hasRoleNode.Port(0, 0), ifNode.Port(0, 1));
            OptimizerUtils.CopyDataInputPort(context, hasRoleNode.Port(0, 1), ifNode.Port(0, 2));

            OptimizerUtils.RemoveDanglingDataNode(context, hasRoleNode);

            return true;
        }

        static bool OptimizeNotIf(Context context, Node ifNode, Connection connectionToIf, Node notNode)
        {
            var connectionToNot = context.Connections.Find(c => c.To.Node == notNode);
            if (connectionToNot == null) return false;

            connectionToIf.From = connectionToNot.From;

            bool hasMoreConnections = false;
            foreach (var c in context.Connections)
            {
                if (c.From.Node == ifNode)
                {
                    if (c.From.Index == 0) c.From.Index = 1;
                    else if (c.From.Index == 1) c.From.Index = 0;
                    else throw new Exception("Optimization Error: can't swap if case");
                }

                if (c.From.Node == notNode) hasMoreConnections = true;
            }

            if (!hasMoreConnections)
                context.RemoveNode(notNode);

            return true;
        }

        static bool OptimizeIfValueNode(Context context, Node ifNode)
        {
            var connectionToIf = context.Connections.Find(c => c.To.Node == ifNode && c.To.Index == 0 && c.From.Node.Type == ChipType.Not);
            if (connectionToIf == null) return false;

            var notNode = connectionToIf.From.Node;

            var connectionToNot = context.Connections.Find(c => c.To.Node == notNode);
            if (connectionToNot == null) return false;

            connectionToIf.From = connectionToNot.From;

            bool hasMoreConnections = false;
            foreach (var c in context.Connections)
            {
                if (c.To.Node == ifNode)
                {
                    if (c.To.Index == 1) c.To.Index = 2;
                    else if (c.To.Index == 2) c.To.Index = 1;
                    else if (c.To.Index != 0) throw new Exception("Optimization Error: can't swap if value case");
                }

                if (c.From.Node == notNode) hasMoreConnections = true;
            }

            // Swap default values
            var prevDefaultValues = new Dictionary<(int, int), object>(ifNode.DefaultValues);
            ifNode.DefaultValues = new();

            // Restore bool input
            if (prevDefaultValues.TryGetValue((0, 0), out var test))
                ifNode.DefaultValues[(0, 0)] = test;

            // Swap "Then" > "Else"
            if (prevDefaultValues.TryGetValue((0, 1), out var whenTrue))
                ifNode.DefaultValues[(0, 2)] = whenTrue;

            // Swap "Else" > "Then"
            if (prevDefaultValues.TryGetValue((0, 2), out var whenFalse))
                ifNode.DefaultValues[(0, 1)] = whenFalse;

            if (!hasMoreConnections)
                context.RemoveNode(notNode);

            return true;
        }
    }
}
