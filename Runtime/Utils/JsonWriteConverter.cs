using Newtonsoft.Json;
using System;

internal abstract class JsonWriteConverter : JsonConverter
{
    public abstract override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
    }

    public override bool CanRead
    {
        get { return false; }
    }

    public override bool CanConvert(Type objectType) { return true; }

}
