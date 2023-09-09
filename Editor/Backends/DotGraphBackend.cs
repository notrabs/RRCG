using RRCGBuild;
using System.Linq;
using UnityEngine;

namespace RRCG
{
    public class DotGraphBackend
    {
        public static void Build(Context context)
        {
            var dotGraph = $@"digraph RRCG {{
{string.Join("\n", context.Nodes.Select((node, i) => $"    {i} [label=\"{GetNodeName(node)}\"];"))}

{string.Join("\n", context.Connections.Select((Connection, i) => $"   {context.Nodes.IndexOf(Connection.From.Node)} -> {context.Nodes.IndexOf(Connection.To.Node)};"))}
}}
";
            Debug.Log(dotGraph);
            GUIUtility.systemCopyBuffer = dotGraph;
            Debug.Log("dotGraph copied");
        }

        private static string GetNodeName(Node node)
        {
            if (node.VariableName != null) return node.VariableName;
            if (node.EventName != null) return $"{node.Name} ({node.EventName})";
            return node.Name;
        }
    }
}