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

        static bool OptimizeIfNode(Context context, Node node)
        {
            var connectionToIf = context.Connections.Find(c => c.To.Node == node && c.To.Index == 1);
            if (connectionToIf == null) return false;

            var prevNode = connectionToIf.From.Node;

            switch (prevNode.Type)
            {
                case ChipType.Not:
                    return OptimizeNotIf(context, node, connectionToIf, prevNode);
            }

            return false;
        }

        static bool OptimizeNotIf(Context context, Node node, Connection connectionToIf, Node notNode)
        {
            var connectionToNot = context.Connections.Find(c => c.To.Node == notNode);
            if (connectionToNot == null) return false;

            connectionToIf.From = connectionToNot.From;

            bool hasMoreConnections = false;
            foreach (var c in context.Connections)
            {
                if (c.From.Node == node)
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


        static bool OptimizeIfValueNode(Context context, Node node)
        {
            var connectionToIf = context.Connections.Find(c => c.To.Node == node && c.To.Index == 0 && c.From.Node.Type == ChipType.Not);
            if (connectionToIf == null) return false;

            var notNode = connectionToIf.From.Node;

            var connectionToNot = context.Connections.Find(c => c.To.Node == notNode);
            if (connectionToNot == null) return false;

            connectionToIf.From = connectionToNot.From;

            bool hasMoreConnections = false;
            foreach (var c in context.Connections)
            {
                if (c.To.Node == node)
                {
                    if (c.To.Index == 1) c.To.Index = 2;
                    else if (c.To.Index == 2) c.To.Index = 1;
                    else if (c.To.Index != 0) throw new Exception("Optimization Error: can't swap if value case");
                }

                if (c.From.Node == notNode) hasMoreConnections = true;
            }

            // Swap default values
            var prevDefaultValues = new Dictionary<(int, int), object>(node.DefaultValues);
            node.DefaultValues = new();

            // Restore bool input
            if (prevDefaultValues.TryGetValue((0, 0), out var test))
                node.DefaultValues[(0, 0)] = test;

            // Swap "Then" > "Else"
            if (prevDefaultValues.TryGetValue((0, 1), out var whenTrue))
                node.DefaultValues[(0, 2)] = whenTrue;

            // Swap "Else" > "Then"
            if (prevDefaultValues.TryGetValue((0, 2), out var whenFalse))
                node.DefaultValues[(0, 1)] = whenFalse;

            if (!hasMoreConnections)
                context.RemoveNode(notNode);

            return true;
        }
    }
}
