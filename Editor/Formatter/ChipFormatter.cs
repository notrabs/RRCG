using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCG.Formatter
{
    public static class ChipFormatter
    {
        public static Vector2 Organize(Transform root, Context context)
        {
            var timer = new ProfilingTimer();

            var rootSize = OrganizeContext(root, context);

            foreach (var childContext in context.GetAllChildren())
                OrganizeContext(null, childContext);

            Debug.Log($"Finished Formatting in {timer.Formatted}");

            return rootSize;
        }

        public static Vector2 OrganizeContext(Transform root, Context context)
        {
            var nodesToPlace = context.Nodes.ToList();

            //
            // Allocate some data for faster queries later
            //

            var execConnections = context.Connections.Where(c => c.isExec).OrderBy(c => c.From, new PortComparer()).ToArray();
            var dataConnections = context.Connections.Where(c => !c.isExec).OrderBy(c => c.To, new PortComparer()).ToArray();
            var allExecConnectedNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n || c.To.Node == n)).ToArray();
            var entryNodes = allExecConnectedNodes.Where(n => execConnections.All(c => c.To.Node != n));

            var execInNodes = new Dictionary<Node, List<Node>>();
            var execOutNodes = new Dictionary<Node, List<Node>>();

            foreach (var execConnection in execConnections)
            {
                if (!execInNodes.ContainsKey(execConnection.To.Node)) execInNodes[execConnection.To.Node] = new List<Node>();
                if (!execOutNodes.ContainsKey(execConnection.From.Node)) execOutNodes[execConnection.From.Node] = new List<Node>();

                execInNodes[execConnection.To.Node].Add(execConnection.From.Node);
                execOutNodes[execConnection.From.Node].Add(execConnection.To.Node);
            }

            // only contains pure data nodes (without execs)
            var dataInNodes = new Dictionary<Node, List<Node>>();
            var dataOutNodes = new Dictionary<Node, List<Node>>();

            foreach (var dataConnection in dataConnections)
            {
                if (!dataInNodes.ContainsKey(dataConnection.To.Node)) dataInNodes[dataConnection.To.Node] = new List<Node>();
                if (!dataOutNodes.ContainsKey(dataConnection.From.Node)) dataOutNodes[dataConnection.From.Node] = new List<Node>();

                if (!allExecConnectedNodes.Contains(dataConnection.From.Node))
                    dataInNodes[dataConnection.To.Node].Add(dataConnection.From.Node);

                if (!allExecConnectedNodes.Contains(dataConnection.To.Node))
                    dataOutNodes[dataConnection.From.Node].Add(dataConnection.To.Node);
            }

            //
            // Calculate an abstract version of the formatted graph, describing its semantic structure
            //

            var entryBranches = new List<ExecBranch>();

            var EMPTY_NODES = new List<Node>();

            foreach (var entryNode in entryNodes)
            {
                var entryBranch = new ExecBranch();
                entryBranches.Add(entryBranch);

                // Step 1: Compute a DFS of the graph. 
                // This establises a trunk. The structure is constructed in "shells", so any branch will only have at most one branching node as its last child after this step.
                // In a later step these inner "shells" will be pulled out as needed according to their dependency relationships.

                {
                    Action<Node, ExecBranch> Visit = null;
                    Visit = (node, branch) =>
                    {
                        // Check if the node is already placed
                        if (!nodesToPlace.Remove(node)) return;

                        var execGroup = new ExecOrBranchGroup { execNode = node };
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

                // Step 2: Collapse the graph.
                // Try to find dependencies from the outer "shells" of the graph into an inner graph
                // This is a heuristic for a topological sorting, that works reasonably well for the main path

                {
                    Action<ExecBranch> VisitBranch = null;
                    Func<ExecOrBranchGroup, ExecOrBranchGroup> VisitExecGroup = null;

                    VisitBranch = (branch) =>
                    {
                        // Use a manual for loop, as more execGroups will be inserted when groups are "pulled out"
                        for (var i = 0; i < branch.execGroups.Count; i++)
                        {
                            var newGroup = VisitExecGroup(branch.execGroups[i]);

                            if (newGroup != null) branch.execGroups.Insert(i + 1, newGroup);
                        }
                    };

                    VisitExecGroup = (execGroup) =>
                    {
                        for (var i = execGroup.branches.Count - 1; i >= 0; i--)
                        {
                            VisitBranch(execGroup.branches[i]);
                        }

                        if (execGroup.branches.Count > 1)
                        {
                            var nodesInBranches = execGroup.branches.Select(branch => branch.GetAllNodes().ToArray()).ToArray();
                            var nodeToBranch = new Dictionary<Node, int>();

                            int nodesBranchIndex = 0;
                            foreach (var nodes in nodesInBranches)
                            {
                                foreach (var node in nodes) nodeToBranch.Add(node, nodesBranchIndex);
                                nodesBranchIndex++;
                            }

                            for (var targetBranchIndex = execGroup.branches.Count - 2; targetBranchIndex >= 0; targetBranchIndex--)
                            {
                                if (nodesInBranches[targetBranchIndex].Any((nodeInBranch) =>
                                {
                                    var inNodes = execInNodes.GetValueOrDefault(nodeInBranch, EMPTY_NODES);
                                    return inNodes.Any(inNode => nodeToBranch.GetValueOrDefault(inNode, -1) > targetBranchIndex);
                                }))
                                {
                                    // targetBranchIndex shall be pulled out into a newGroup
                                    var pulledOutBranches = execGroup.branches.GetRange(0, targetBranchIndex + 1);
                                    var newGroup = new ExecOrBranchGroup() { branches = pulledOutBranches.ToList() };

                                    execGroup.branches.RemoveRange(0, targetBranchIndex + 1);
                                    execGroup.ThroughLinePadding = true;

                                    return newGroup;
                                }
                            }
                        }
                        return null;
                    };

                    VisitBranch(entryBranch);
                }

                // Step 3: Search for data dependencies
                // This assigns all the data-only nodes to their first usage in an exec chip

                foreach (var execGroup in entryBranch.GetAllExecGroups())
                {
                    if (execGroup.execNode == null) continue;

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

                    var execDataOut = dataOutNodes.GetValueOrDefault(execGroup.execNode, EMPTY_NODES);

                    if (execGroup.deps.Any(nodes => nodes.Any(n => execDataOut.Contains(n)))) execGroup.HasLoopingDependency = true;
                }
            }

            //
            // Convert the abstract graph into layouts
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

            var totalSize = rootLayout.Calculate();

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

        public static ChipLayout CreateExecGroupContainer(ExecOrBranchGroup execGroup)
        {
            var container = new ChipLayoutHorizontal();

            if (execGroup.execNode != null)
            {
                var deps = CreateDependencies(execGroup.deps);
                var node = CreateNodeContainer(execGroup.execNode, true);

                if (execGroup.HasLoopingDependency)
                {
                    // place looping dependencies below node
                    var vertical = new ChipLayoutVertical();
                    container.AddChild(vertical);

                    vertical.AddChild(node);
                    vertical.AddChild(deps);

                    deps.Padding = new ChipLayoutPadding(0);
                    node.Alignment = ChipLayoutAlignment.CENTER;
                    deps.Alignment = ChipLayoutAlignment.CENTER;
                }
                else
                {
                    // place dependencies left of node
                    container.AddChild(deps);
                    container.AddChild(node);
                }

            }

            if (execGroup.branches.Count > 0)
            {
                var branchContainer = new ChipLayoutVertical();
                if (execGroup.ThroughLinePadding) branchContainer.Padding = branchContainer.Padding with { Top = 0.1f };

                foreach (var branch in execGroup.branches) branchContainer.AddChild(CreateBranchContainer(branch));

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
            return new ChipLayoutNode(node, isExec);
        }
    }

    //
    // Abstract Layout Graph types (describing the semantic structure)
    //

    public class ExecBranch
    {
        public List<ExecOrBranchGroup> execGroups = new List<ExecOrBranchGroup>();

        public IEnumerable<ExecOrBranchGroup> GetAllExecGroups()
        {
            IEnumerable<ExecOrBranchGroup> all = new List<ExecOrBranchGroup>();

            foreach (var execGroup in execGroups)
            {
                all = all.Concat(execGroup.GetAllExecGroups());
            }

            return all;
        }

        public IEnumerable<Node> GetAllNodes()
        {
            foreach (var execGroup in execGroups)
            {
                foreach (var node in execGroup.GetAllNodes()) yield return node;
            }
        }
    }

    public class ExecOrBranchGroup
    {
        public Node execNode;

        public List<List<Node>> deps = new List<List<Node>>();

        public List<ExecBranch> branches = new List<ExecBranch>();

        // True if the group has been "pulled out" from in the formatting process
        // This indicates that some padding should be left before the first branch
        public bool ThroughLinePadding = false;

        // True if at least one of the dependencies reads and writes to the execNode
        public bool HasLoopingDependency = false;

        public IEnumerable<ExecOrBranchGroup> GetAllExecGroups()
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

        public IEnumerable<Node> GetAllNodes()
        {
            if (execNode != null) yield return execNode;

            foreach (var branch in branches)
            {
                foreach (var node in branch.GetAllNodes()) yield return node;
            }
        }
    }
}
