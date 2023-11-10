using RRCGBuild;
using RRCGGenerated;
using System;
using System.Linq;

namespace RRCG.Optimizer.ContextOptimizations
{
    class IfNotOptimization : IContextOptimization
    {
        public int OptimizeContext(Context context)
        {
            int optimized = 0;

            foreach (var node in context.Nodes.ToList())
            {
                if (node.Type == ChipType.If)
                {
                    var connectionToIf = context.Connections.Find(c => c.To.Node == node && c.To.Index == 1 && c.From.Node.Type == ChipType.Not);
                    if (connectionToIf == null) continue;

                    var notNode = connectionToIf.From.Node;

                    var connectionToNot = context.Connections.Find(c => c.To.Node == notNode);
                    if (connectionToNot == null) continue;

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
                    {
                        GraphOptimizer.RemoveNodeFromContext(context, notNode);
                    }

                    optimized++;
                }
            }

            return optimized;
        }
    }
}
