using RRCGBuild;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCG
{
    public class DotGraphBackend
    {
        public static string Build(Context context)
        {
            var defaultValues = new List<(int node, int group, int port, object value)>();
            for (int n = 0; n < context.Nodes.Count; n++)
            {
                foreach (var ((g, p), v) in context.Nodes[n].DefaultValues)
                {
                    defaultValues.Add((n, g, p, v));
                }
            }

            var dotGraph = $@"digraph RRCG {{

    // Nodes
{string.Join("\n", context.Nodes.Select((node, i) => $"    {i} [label=\"{GetNodeName(node)}\", shape=rect, style=rounded];"))}

    // Port default values
{string.Join("\n", defaultValues.Select((value, i) => $"    {context.Nodes.Count + i} [label=\"{value.value}\", color=\"{GetTypeColor(value.value)}\", shape=diamond];"))}

    // Edges
{string.Join("\n", context.Connections.Select((Connection, i) =>
$"    {context.Nodes.IndexOf(Connection.From.Node)} -> {context.Nodes.IndexOf(Connection.To.Node)} [color=\"{GetEdgeColor(Connection)}\", label=\"{GetEdgePortIdDescriptor(Connection)}\"];"))}

    // Default value connections
{string.Join("\n", defaultValues.Select((value, i) => $"    {context.Nodes.Count + i} -> {value.node} [color=black, label=\"{GetPortIdDescriptor(value.group, value.port)}\"];"))}
}}
";
            Debug.Log(dotGraph);
            return dotGraph;
        }

        private static string GetEdgeColor(Connection connection)
        {
            return connection.isExec ? "#F55C1A" : "black";
        }

        private static string GetPortIdDescriptor(int group, int port) =>
            group == 0 ? port.ToString() : $"[{group}, {port}]";

        private static string GetEdgePortIdDescriptor(Connection connection)
        {
            static string getPortIds(Port port) => GetPortIdDescriptor(port.Group, port.Index);
            return $"{getPortIds(connection.From)} → {getPortIds(connection.To)}";
        }

        private static string GetTypeColor(object defaultValue)
        {
            switch (defaultValue)
            {
                case int:
                    return "#2B6738";
                case float:
                    return "#186BDD";
                case bool:
                    return "#EA2E50";
                case string:
                    return "#784283";
                case Color:
                case Color32:
                    return "#14317D";
                default:
                    return "#F5C51F";
            }
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