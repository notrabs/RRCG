using Newtonsoft.Json;
using RRCG;
using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class Node
    {
        [JsonConverter(typeof(GuidConverter))]
        public string Id;

        [JsonConverter(typeof(GuidConverter))]
        public string Type;

        public string Name;

        // Flag indicating whether the Node should appear in Context.lastSpawnedNode
        // This can be set to false by the compiler to insert nodes that shouldn't be visible to logic after a spawning function.
        [JsonIgnore]
        internal bool IsProperNode = true;

        public int InputCount { get; internal set; }

        // Configuration data
        public TransformData TransformData = null;
        public SFXConstantData SFXConstantData = null;
        public PlayAudioAtPositionData PlayAudioAtPositionData = null;
        public PlayerWorldUIData PlayerWorldUIData = null;
        public StudioFunctionData StudioFunctionData = null;
        public RoomKeyData RoomKeyData = null;
        public RoomCurrencyData RoomCurrencyData = null;
        public RoomConsumableData RoomConsumableData = null;
        public EventDefinitionData EventDefinitionData = null;
        public EventSenderData EventSenderData = null;
        public EventReceiverData EventReceiverData = null;
        public RaycastData RaycastData = null;
        public VariableData VariableData = null;
        public DataTableColumnData DataTableColumnData = null;
        public FogData FogData = null;

        [JsonConverter(typeof(DefaultValuesConverter))]
        public Dictionary<(int Group, int Port), object> DefaultValues = new Dictionary<(int Group, int Port), object>();
        public List<string> SwitchCases = null;

        [JsonConverter(typeof(GuidConverter))]
        public string CircuitBoardId;

        public Node()
        {
            Id = Guid.NewGuid().ToString();
        }

        public void ConnectInputPort(Context context, AnyPort port, Port input)
        {
            if (port == null) return;

            port = port.AsConnectable();

            if (port.IsActualPort)
            {
                context.Connections.Add(new Connection { From = port.Port, To = input });
                DefaultValues.Remove((input.Group, input.Index));
            }
            else DefaultValues.Add((input.Group, input.Index), port.Data);
        }

        public Port ConnectInputPort(AnyPort port, int inputIndex)
        {
            var input = new Port() { Node = this, Index = inputIndex };
            ConnectInputPort(Context.current, port, input);
            return input;
        }

        public Port Port(int Group, int Index)
        {
            return new Port() { Node = this, Group = Group, Index = Index };
        }
    }

    public class Port
    {
        [JsonConverter(typeof(NodeAsIdConverter))]
        public Node Node;
        public int Group = 0;
        public int Index = 0;

        public bool EquivalentTo(Port b)
        {
            return Group == b.Group &&
                   Index == b.Index &&
                   Node == b.Node;
        }
    }

    public class Connection
    {
        public Port From;
        public Port To;

        public bool isExec = false;
    }

    //
    // Misc Utils for the graph types
    //

    /// <summary>
    /// Use to sort ports by their group and index
    /// </summary>
    public class PortComparer : IComparer<Port>
    {
        public int Compare(Port a, Port b)
        {
            var compareGroup = a.Group.CompareTo(b.Group);
            if (compareGroup != 0) return compareGroup;
            return a.Index.CompareTo(b.Index);
        }
    }

    internal class NodeAsIdConverter : JsonWriteConverter
    {
        public override void WriteJson(JsonWriter writer, object valueObj, JsonSerializer serializer)
        {
            Guid parsed;

            if (Guid.TryParse(((Node)valueObj).Id, out parsed))
            {
                var id = Convert.ToBase64String(parsed.ToByteArray());
                writer.WriteValue(id);
            }
            else
            {
                writer.WriteValue(((Node)valueObj).Id);
            }
        }
    }

    internal class GuidConverter : JsonWriteConverter
    {
        public override void WriteJson(JsonWriter writer, object valueObj, JsonSerializer serializer)
        {
            Guid parsed;

            if (Guid.TryParse((string)valueObj, out parsed))
            {
                var id = Convert.ToBase64String(parsed.ToByteArray());
                writer.WriteValue(id);
            }
            else
            {
                writer.WriteValue(valueObj);
            }
        }
    }
    internal class DefaultValuesConverter : JsonWriteConverter
    {
        public override void WriteJson(JsonWriter writer, object valueObj, JsonSerializer serializer)
        {
            if (valueObj == null)
            {
                writer.WriteValue("null");
                return;
            }

            var dict = (Dictionary<(int Group, int Port), object>)valueObj;
            var entries = dict
                .Where(keyValue => keyValue.Value != null)
                .Select(keyValue =>
                {
                    var port = new int[] { keyValue.Key.Group, keyValue.Key.Port };
                    return new object[] { port, keyValue.Value.GetType().ToString(), keyValue.Value };
                });

            writer.WriteRawValue(JsonConvert.SerializeObject(entries.ToArray()));
        }
    }
}