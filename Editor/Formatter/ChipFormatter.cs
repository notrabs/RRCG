using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCG.Formatter
{
    public static class ChipFormatter
    {
        static Dictionary<Node, Component> rrcgNodeToInstances;

        public static Vector2 OrganizeCircuits(Transform root, Context context, Dictionary<Node, Component> rrcgNodeToInstances)
        {
            ChipFormatter.rrcgNodeToInstances = rrcgNodeToInstances;
            var nodesToPlace = context.Nodes.ToList();

            var execConnections = context.Connections.Where(c => c.isExec).ToArray();
            var dataConnections = context.Connections.Where(c => !c.isExec).ToArray();
            var entryNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n) && execConnections.All(c => c.To.Node != n));
            var allExecConnectedNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n || c.To.Node == n)).ToArray();

            //
            // Calculate a structured version of the graph
            //

            var entryGroups = new List<EntryGroup>();

            foreach (var entryNode in entryNodes)
            {
                var entryGroup = new EntryGroup();
                entryGroups.Add(entryGroup);

                var bfs = new List<Node>() { entryNode };

                while (bfs.Count > 0)
                {
                    var execGroup = new ExecGroup();
                    entryGroup.execGroups.Add(execGroup);

                    execGroup.execs = bfs.Select(n => new ExecNode() { execNode = n }).ToList();

                    nodesToPlace.RemoveAll(n => bfs.Contains(n));

                    bfs = nodesToPlace.Where(n => execConnections.Any(c => c.To.Node == n && bfs.Contains(c.From.Node))).ToList();
                }


                // Search for data dependencies
                foreach (var execGroup in entryGroup.execGroups)
                {
                    foreach (var exec in execGroup.execs)
                    {
                        bfs = new List<Node> { exec.execNode };

                        while ((bfs = nodesToPlace.Where(n => !allExecConnectedNodes.Contains(n) && dataConnections.Any(c => c.From.Node == n && bfs.Contains(c.To.Node))).ToList()).Count > 0)
                        {
                            exec.deps.Add(bfs.ToList());
                            nodesToPlace.RemoveAll(n => bfs.Contains(n));
                        }
                    }
                }
            }

            //
            // Convert the structured graph into layouts
            //

            var rootLayout = new ChipLayoutVertical();
            rootLayout.Padding = new ChipLayoutPadding(0.2f);

            foreach (var entryGroup in entryGroups)
            {
                var entryContainer = rootLayout.AddChild(new ChipLayoutHorizontal());

                foreach (var execGroup in entryGroup.execGroups)
                {
                    entryContainer.AddChild(CreateExecsContainer(execGroup));
                }
            }

            var singleNodesContainer = rootLayout.AddChild(new ChipLayoutHorizontal());

            foreach (var node in nodesToPlace)
            {
                singleNodesContainer.AddChild(CreateNodeContainer(node, false));
            }

            //
            // Apply the calculated layout to the actual nodes
            //

            var totalSize = rootLayout.CalculateLayout(new Vector2());

            var rootPos = root != null ?
                // rootPos needs to be the top-left corner of the plane
                root.TransformPoint(new Vector3(0, totalSize.y, 0)) :
                // Place the circuit boards in front of the In/Out chips in circuit boards
                new Vector3(0, 0, -0.2f);
            var rootRot = root != null ?
                // Align the Circuits to the plane
                root.rotation * Quaternion.Euler(0, -90, 0) :
                // chips in circuit boards have no rotation
                new Quaternion();

            rootLayout.ApplyLayoutToChips(rootPos, rootRot);

            return totalSize;
        }


        public static ChipLayout CreateExecsContainer(ExecGroup execs)
        {
            var container = new ChipLayoutVertical();

            foreach (var exec in execs.execs)
            {
                container.AddChild(CreateExecContainer(exec));
            }

            return container;
        }

        public static ChipLayout CreateExecContainer(ExecNode exec)
        {
            var container = new ChipLayoutHorizontal();

            container.AddChild(CreateDependencies(exec.deps));
            container.AddChild(CreateNodeContainer(exec.execNode, true));

            return container;
        }

        public static ChipLayout CreateDependencies(List<List<Node>> deps)
        {
            var container = new ChipLayoutHorizontal();
            container.Padding = new ChipLayoutPadding(0.1f, 0, 0, 0);

            foreach (var col in deps.ToArray().Reverse())
            {
                container.AddChild(CreateDependencyColumn(col));
            }

            return container;
        }

        public static ChipLayout CreateDependencyColumn(List<Node> deps)
        {
            var container = new ChipLayoutVertical();

            foreach (var node in deps)
            {
                container.AddChild(CreateNodeContainer(node, false));
            }

            return container;
        }


        public static ChipLayoutNode CreateNodeContainer(Node node, bool isExec)
        {
            return new ChipLayoutNode(node, rrcgNodeToInstances[node].gameObject, isExec);
        }
    }

    public class EntryGroup
    {
        public List<ExecGroup> execGroups = new List<ExecGroup>();

    }

    public class ExecGroup
    {
        public List<ExecNode> execs = new List<ExecNode>();
    }

    public class ExecNode
    {
        public Node execNode;

        public List<List<Node>> deps = new List<List<Node>>();
    }
}
