using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCG.Optimizer.ContextOptimizations
{
    class VariableCollapserOptimization : IContextOptimization
    {
        public int OptimizeContext(Context context)
        {
            int removedNodes = 0;

            // Map var name -> (instances where var is read only, instances where var is written)
            Dictionary<string, (List<Node>, List<Node>)> varUsageMap = new();

            // Initialize usage map
            foreach (var node in context.Nodes)
            {
                if (!ChipTypeUtils.VariableTypes.Contains(node.Type))
                    continue;

                if (!varUsageMap.ContainsKey(node.VariableData.Name))
                    varUsageMap[node.VariableData.Name] = (new List<Node>(), new List<Node>());

                (var readOnlyInstances, var writeInstances) = varUsageMap[node.VariableData.Name];
                var isReadOnly = context.Connections.Where(c => (c.To.Node == node && c.To.Index == 0) ||
                                                                (c.From.Node == node && c.From.Index == 0)).Count() <= 0;

                if (isReadOnly)
                    readOnlyInstances.Add(node);
                else
                    writeInstances.Add(node);
            }

            // Now go through and collapse each variable in the context.
            foreach ((var readOnlyInstances, var writeInstances) in varUsageMap.Values)
            {
                if (writeInstances.Count > 0)
                {
                    // Collapse all read-only instances into the first write instance.
                    while (readOnlyInstances.Count > 0)
                    {
                        CollapseVariable(context, readOnlyInstances[0], writeInstances[0]);
                        readOnlyInstances.RemoveAt(0);
                        removedNodes++;
                    }
                }
                else
                {
                    // Collapse all read-only instances into the first read-only instance.
                    while (readOnlyInstances.Count > 1)
                    {
                        CollapseVariable(context, readOnlyInstances[1], readOnlyInstances[0]);
                        readOnlyInstances.RemoveAt(1);
                        removedNodes++;
                    }
                }

                // Remove completely disconnected variables
                foreach (var node in readOnlyInstances.Concat(writeInstances))
                {
                    if (context.Connections.Any(c => c.From.Node == node || c.To.Node == node)) continue;

                    context.RemoveNode(node);
                    removedNodes++;
                }
            }

            return removedNodes;
        }

        void CollapseVariable(Context context, Node from, Node into)
        {
            foreach (var c in context.Connections.Where(c => c.From.Node == from))
                c.From.Node = into;

            context.RemoveNode(from);
        }
    }
}
