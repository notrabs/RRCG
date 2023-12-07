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
                var isReadOnly = context.Connections.Where(c => c.To.Node == node && c.To.Index == 0).Count() <= 0;

                if (isReadOnly)
                    readOnlyInstances.Add(node);
                else
                    writeInstances.Add(node);
            }

            // Now go through and collapse each variable in the context.
            foreach ((var readOnlyInstances, var writeInstances) in varUsageMap.Values)
            {
                // Case A. At least one write instance.
                // All read only instances will be collapsed
                // into the first write instance.
                if (writeInstances.Count > 0)
                {
                    foreach (var node in readOnlyInstances)
                    {
                        CollapseVariable(context, node, writeInstances[0]);
                        removedNodes++;
                    }

                    continue;
                }

                // Case B. No write instances, but at least one read only instance.
                // All read only instances will be
                // collapsed into the first read only instance.
                if (writeInstances.Count <= 0 && readOnlyInstances.Count > 0)
                {
                    for (int i = 1; i < readOnlyInstances.Count; i++)
                    {
                        CollapseVariable(context, readOnlyInstances[i], readOnlyInstances[0]);
                        removedNodes++;
                    }

                    continue;
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
