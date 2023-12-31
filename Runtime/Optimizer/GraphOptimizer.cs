﻿using RRCG.Optimizer.ContextOptimizations;
using RRCGBuild;
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
            new IfOptimization(), new KnownSingletonChipsOptimization(), new VariableCollapserOptimization(),
            new AssociativeOperationCollapserOptimization()
        };

        public static Context Optimize(Context context)
        {
            optimizedStats = 0;
            var timer = new ProfilingTimer();

            var optimized = OptimizeContext(context);

            Debug.Log($"Optimized {optimizedStats} Nodes in {timer.Formatted}");

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
    }
}
