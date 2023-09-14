using Newtonsoft.Json;
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

        public string EventName { get; internal set; }
        public string VariableName { get; internal set; }
        public VariableKind VariableKind { get; internal set; }
        public object VariableHomeValue { get; internal set; }

        public int InputCount { get; internal set; }

        [JsonConverter(typeof(DefaultValuesConverter))]
        public Dictionary<(int Group, int Port), object> DefaultValues = new Dictionary<(int Group, int Port), object>();
        public Dictionary<string, Type> EventDefintion = null;
        public List<string> SwitchCases = null;

        // The scope of this conditional context
        public ConditionalContext MetaConditionalContext = null;

        public Node()
        {
            Id = Guid.NewGuid().ToString();
            MetaConditionalContext = ConditionalContext.current;
        }

        public void ConnectInputPort(Context context, AnyPort port, Port input)
        {
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
    }

    public class Port
    {
        [JsonConverter(typeof(NodeAsIdConverter))]
        public Node Node;
        public int Group = 0;
        public int Index = 0;
    }

    public class Connection
    {
        public Port From;
        public Port To;

        public bool isExec = false;
    }

    internal class NodeAsIdConverter : JsonWriteConverter
    {
        public override void WriteJson(JsonWriter writer, object valueObj, JsonSerializer serializer)
        {
            var id = Convert.ToBase64String(Guid.Parse(((Node)valueObj).Id).ToByteArray());
            writer.WriteValue(id);
        }
    }

    internal class GuidConverter : JsonWriteConverter
    {
        public override void WriteJson(JsonWriter writer, object valueObj, JsonSerializer serializer)
        {
            var id = Convert.ToBase64String((Guid.Parse((string)valueObj)).ToByteArray());
            writer.WriteValue(id);
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
                .Select(keyValue => new object[] { new int[] { keyValue.Key.Group, keyValue.Key.Port }, keyValue.Value.GetType().ToString(), keyValue.Value });

            writer.WriteRawValue(JsonConvert.SerializeObject(entries.ToArray()));
        }
    }
}