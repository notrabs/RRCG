using RRCG.Optimizer.ContextOptimizations;
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
        static IContextOptimization[] ContextOptimizations = new IContextOptimization[]
        {
            new IfNotOptimization(), new KnownSingletonChipsOptimization()
        };

        public static Context Optimize(Context context)
        {
            optimizedStats = 0;

            var optimized = OptimizeContext(context);

            Debug.Log("Optimized " + optimizedStats + " Nodes");

            return optimized;
        }
        static Context OptimizeContext(Context context)
        {
            var optimizedContext = context;

            foreach (var optimizer in ContextOptimizations)
                optimizedStats += optimizer.OptimizeContext(context);

            context.SubContexts = context.SubContexts.Select(OptimizeContext).ToList();
            return optimizedContext;
        }

        public static void RemoveNodeFromContext(Context context, Node node)
        {
            context.Nodes.Remove(node);
            context.Connections.RemoveAll(c => c.From.Node == node || c.To.Node == node);
        }
    }
}
