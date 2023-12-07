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
            if (node.VariableData != null) return node.VariableData.Name;
            if (node.EventDefinitionData != null) return $"{node.Name} ({node.EventDefinitionData.EventName})";
            if (node.EventReceiverData != null) return $"{node.Name} ({node.EventReceiverData.EventName})";
            if (node.EventSenderData != null) return $"{node.Name} ({node.EventSenderData.EventName})";
            return node.Name;
        }
    }
}