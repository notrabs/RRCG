using RRCGBuild;
using RRCGGenerated;
using System;
using System.Linq;
using UnityEngine;

namespace RRCG.Optimizer
{
    public class GraphOptimizer
    {
        static int optimizedStats = 0;

        public static Context Optimize(Context context)
        {
            optimizedStats = 0;

            var optimized = OptimizeContext(context);

            Debug.Log("Optimized " + optimizedStats + " Nodes");

            return optimized;
        }
        static Context OptimizeContext(Context context)
        {
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
                        RemoveNodeFromContext(context, notNode);
                    }

                    optimizedStats++;
                }
            }

            context.SubContexts = context.SubContexts.Select(Optimize).ToList();

            return context;
        }

        public static void RemoveNodeFromContext(Context context, Node node)
        {
            context.Nodes.Remove(node);
            context.Connections.RemoveAll(c => c.From.Node == node || c.To.Node == node);
        }
    }
}
