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

            var execConnections = context.Connections.Where(c => c.isExec).OrderBy(c => c.From, new PortComparer()).ToArray();
            var dataConnections = context.Connections.Where(c => !c.isExec).OrderBy(c => c.To, new PortComparer()).ToArray();
            var allExecConnectedNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n || c.To.Node == n)).ToArray();
            var entryNodes = allExecConnectedNodes.Where(n => execConnections.All(c => c.To.Node != n));

            // Dicts for faster queries
            var execInNodes = new Dictionary<Node, List<Node>>();
            var execOutNodes = new Dictionary<Node, List<Node>>();

            foreach (var execConnection in execConnections)
            {
                if (!execInNodes.ContainsKey(execConnection.To.Node)) execInNodes[execConnection.To.Node] = new List<Node>();
                if (!execOutNodes.ContainsKey(execConnection.From.Node)) execOutNodes[execConnection.From.Node] = new List<Node>();

                execInNodes[execConnection.To.Node].Add(execConnection.From.Node);
                execOutNodes[execConnection.From.Node].Add(execConnection.To.Node);
            }

            var dataInNodes = new Dictionary<Node, List<Node>>();

            foreach (var dataConnection in dataConnections)
            {
                if (allExecConnectedNodes.Contains(dataConnection.From.Node)) continue;

                if (!dataInNodes.ContainsKey(dataConnection.To.Node)) dataInNodes[dataConnection.To.Node] = new List<Node>();

                dataInNodes[dataConnection.To.Node].Add(dataConnection.From.Node);
            }

            //
            // Calculate a structured version of the graph
            //

            var entryBranches = new List<ExecBranch>();

            var EMPTY_NODES = new List<Node>();

            foreach (var entryNode in entryNodes)
            {
                var entryBranch = new ExecBranch();
                entryBranches.Add(entryBranch);

                {
                    Action<Node, ExecBranch> Visit = null;
                    Visit = (node, branch) =>
                    {
                        // Check if the node is already placed
                        if (!nodesToPlace.Remove(node)) return;

                        var execGroup = new ExecGroup { execNode = node };
                        branch.execGroups.Add(execGroup);

                        var nextNodes = execOutNodes.GetValueOrDefault(node, EMPTY_NODES);

                        if (nextNodes.Count == 0) return;

                        if (nextNodes.Count == 1)
                        {
                            Visit(nextNodes[0], branch);
                            return;
                        }

                        foreach (var nextNode in nextNodes)
                        {
                            var newBranch = new ExecBranch();
                            execGroup.branches.Add(newBranch);
                            Visit(nextNode, newBranch);
                        }
                    };

                    Visit(entryNode, entryBranch);
                }

                // Search for data dependencies
                foreach (var execGroup in entryBranch.GetAllExecGroups())
                {
                    var bfs = new List<Node> { execGroup.execNode };

                    List<Node> UpdateBfs()
                    {
                        var deps = bfs.SelectMany(n => dataInNodes.GetValueOrDefault(n, EMPTY_NODES)).ToArray();
                        return nodesToPlace.Where(n => deps.Contains(n)).ToList();
                    }

                    while ((bfs = UpdateBfs()).Count > 0)
                    {
                        execGroup.deps.Add(bfs.ToList());
                        nodesToPlace.RemoveAll(n => bfs.Contains(n));
                    }
                }
            }

            //
            // Convert the structured graph into layouts
            //

            var rootLayout = new ChipLayoutVertical();
            rootLayout.Padding = new ChipLayoutPadding(0.2f);

            foreach (var entryBranch in entryBranches)
            {
                rootLayout.AddChild(CreateBranchContainer(entryBranch));
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


        public static ChipLayout CreateBranchContainer(ExecBranch branch)
        {
            var container = new ChipLayoutHorizontal();

            foreach (var execGroup in branch.execGroups)
            {
                container.AddChild(CreateExecGroupContainer(execGroup));
            }

            return container;
        }

        public static ChipLayout CreateExecGroupContainer(ExecGroup exec)
        {
            var container = new ChipLayoutHorizontal();

            container.AddChild(CreateDependencies(exec.deps));
            container.AddChild(CreateNodeContainer(exec.execNode, true));

            if (exec.branches.Count > 0)
            {
                var branchContainer = new ChipLayoutVertical();

                foreach (var branch in exec.branches) branchContainer.AddChild(CreateBranchContainer(branch));

                container.AddChild(branchContainer);
            }

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
    public class PortComparer : IComparer<Port>
    {
        public int Compare(Port a, Port b)
        {
            var compareGroup = a.Group.CompareTo(b.Group);
            if (compareGroup != 0) return compareGroup;
            return a.Index.CompareTo(b.Index);
        }
    }

    public class ExecBranch
    {
        public List<ExecGroup> execGroups = new List<ExecGroup>();

        public IEnumerable<ExecGroup> GetAllExecGroups()
        {
            IEnumerable<ExecGroup> all = new List<ExecGroup>();

            foreach (var execGroup in execGroups)
            {
                all = all.Concat(execGroup.GetAllExecGroups());
            }

            return all;
        }
    }

    public class ExecGroup
    {
        public Node execNode;

        public List<List<Node>> deps = new List<List<Node>>();

        public List<ExecBranch> branches = new List<ExecBranch>();

        public IEnumerable<ExecGroup> GetAllExecGroups()
        {
            yield return this;
            foreach (var branch in branches)
            {
                foreach (var execGroup in branch.GetAllExecGroups())
                {
                    yield return execGroup;
                }
            }
        }
    }
}
