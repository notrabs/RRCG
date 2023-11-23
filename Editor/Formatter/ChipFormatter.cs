using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.ContentSizeFitter;

namespace RRCG
{
    public static class ChipFormatter
    {
        static float PX_SCALE = 100f;

        static Dictionary<RRCGBuild.Node, Component> rrcgNodeToInstances;

        public static async Task<Vector2> OrganizeCircuits(Transform root, Context context, Dictionary<RRCGBuild.Node, Component> rrcgNodeToInstances)
        {
            ChipFormatter.rrcgNodeToInstances = rrcgNodeToInstances;
            var tempLayoutRoot = CreateRootContainer();

            try
            {
                var nodesToPlace = context.Nodes.ToList();

                var execConnections = context.Connections.Where(c => c.isExec).ToArray();
                var dataConnections = context.Connections.Where(c => !c.isExec).ToArray();
                var entryNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n) && execConnections.All(c => c.To.Node != n));
                var allExecConnectedNodes = context.Nodes.Where(n => execConnections.Any(c => c.From.Node == n || c.To.Node == n)).ToArray();

                // Calculate a structured version of the graph
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


                // Calculate the Layout of the structured graph
                foreach (var entryGroup in entryGroups)
                {
                    var entryContainer = CreateExecEntryLayout(tempLayoutRoot);

                    foreach (var execGroup in entryGroup.execGroups)
                    {
                        CreateExecsContainer(entryContainer, execGroup);
                    }
                }

                foreach (var node in nodesToPlace)
                {
                    CreateNodeContainer(tempLayoutRoot, node);
                }

                // Apply the calculated layout to the actual nodes
                for (int i = 0; i < 10; i++)
                {
                    LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)tempLayoutRoot.transform);
                }

                await Utils.awaitNextTick();

                var nodeDummys = tempLayoutRoot.GetComponentsInChildren<LayoutNodeReference>();

                foreach (var nodeDummy in nodeDummys)
                {
                    var dummyPosition = ((RectTransform)nodeDummy.transform).position;

                    var rrcgNode = nodeDummy.node;
                    var node = rrcgNodeToInstances[rrcgNode];

                    if (node == null) continue;

                    if (root != null) node.transform.rotation = root.rotation;

                    var isExec = allExecConnectedNodes.Contains(rrcgNode);
                    var depth = isExec ? 0.025f : 0.015f;

                    if (root != null)
                    {
                        // Align to Background Plane
                        node.transform.Rotate(new Vector3(0, -90, 0));

                        var point = new Vector3(depth, 0, 0) + new Vector3(0, dummyPosition.y / PX_SCALE, dummyPosition.x / PX_SCALE);
                        node.transform.position = root != null ? root.TransformPoint(point) : point;
                    }
                    else
                    {
                        // Align inside CircuitBoard
                        var point = new Vector3(depth, 0, 0) + new Vector3(dummyPosition.x / PX_SCALE, dummyPosition.y / PX_SCALE, 0);
                        node.transform.position = root != null ? root.TransformPoint(point) : point;
                    }
                }

                var size = ((RectTransform)tempLayoutRoot.transform).sizeDelta;

                return size / PX_SCALE;
            }
            finally
            {
                GameObject.DestroyImmediate(tempLayoutRoot);
            }
        }

        public static GameObject CreateRootContainer()
        {
            var tempObj = new GameObject("tempRoot");
            var vl = tempObj.AddComponent<VerticalLayoutGroup>();
            vl.padding.left = vl.padding.right = vl.padding.top = vl.padding.bottom = 10;

            ((RectTransform)tempObj.transform).pivot = new Vector2(0, 0);

            CreateContentSizeFitter(tempObj);
            return tempObj;
        }

        public static GameObject CreateExecEntryLayout(GameObject parent)
        {
            var tempObj = new GameObject("entry");
            tempObj.transform.parent = parent.transform;
            tempObj.AddComponent<HorizontalLayoutGroup>();
            CreateContentSizeFitter(tempObj);

            return tempObj;
        }


        public static GameObject CreateExecsContainer(GameObject parent, ExecGroup execs)
        {
            var tempObj = new GameObject("execs");
            tempObj.transform.parent = parent.transform;
            tempObj.AddComponent<VerticalLayoutGroup>();
            CreateContentSizeFitter(tempObj);

            foreach (var exec in execs.execs)
            {
                CreateExecContainer(tempObj, exec);
            }

            return tempObj;
        }

        public static GameObject CreateExecContainer(GameObject parent, ExecNode exec)
        {
            var tempObj = new GameObject("exec");
            tempObj.transform.parent = parent.transform;
            tempObj.AddComponent<HorizontalLayoutGroup>();
            CreateContentSizeFitter(tempObj);

            CreateDependencies(tempObj, exec.deps);
            CreateNodeContainer(tempObj, exec.execNode);

            return tempObj;
        }

        public static GameObject CreateDependencies(GameObject parent, List<List<Node>> deps)
        {
            var tempObj = new GameObject("deps");
            tempObj.transform.parent = parent.transform;
            var hl = tempObj.AddComponent<HorizontalLayoutGroup>();
            hl.padding.top = 10;
            CreateContentSizeFitter(tempObj);

            foreach (var col in deps.ToArray().Reverse())
            {
                CreateDependencyColumn(tempObj, col);
            }

            return tempObj;
        }

        public static GameObject CreateDependencyColumn(GameObject parent, List<Node> deps)
        {
            var tempObj = new GameObject("deps");
            tempObj.transform.parent = parent.transform;
            tempObj.AddComponent<VerticalLayoutGroup>();
            CreateContentSizeFitter(tempObj);

            foreach (var node in deps)
            {
                CreateNodeContainer(tempObj, node);
            }

            return tempObj;
        }


        public static GameObject CreateNodeContainer(GameObject parent, Node node)
        {
            var tempObj = new GameObject("node " + node.Name);
            tempObj.transform.parent = parent.transform;
            var rect = tempObj.AddComponent<RectTransform>();

            rect.sizeDelta = GetNodeSize(node) * PX_SCALE;

            var reference = tempObj.AddComponent<LayoutNodeReference>();
            reference.node = node;

            return tempObj;
        }

        public static Vector2 GetNodeSize(Node node)
        {
            var size = new Vector2(0.4f, 0.2f);

            if (rrcgNodeToInstances.ContainsKey(node))
            {
                size.x += rrcgNodeToInstances[node].gameObject.name.Length * 0.01f;
            }

            size.y += Math.Max(node.InputCount, node.SwitchCases?.Count ?? 0) * 0.03f;

            return size;
        }

        public static void CreateContentSizeFitter(GameObject obj)
        {
            var csf = obj.AddComponent<ContentSizeFitter>();
            csf.verticalFit = FitMode.MinSize;
            csf.horizontalFit = FitMode.MinSize;
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
