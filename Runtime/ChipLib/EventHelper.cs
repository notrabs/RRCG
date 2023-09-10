namespace RRCGSource
{
    public class EventHelper
    {
        public EventHelper(string eventName) { }
        public void Definition() { }
        public void Sender() { }
        public void Receiver() { }
    }

    public class EventHelper<T0>
    {
        public EventHelper(string eventName, string value0){ }
        public void Definition() { }
        public void Sender(T0 value0) { }
        public T0 Receiver() { return default; }
    }

    public class EventHelper<T0, T1>
    {
        public EventHelper(string eventName, string value0, string value1) { }
        public void Definition() { }
        public void Sender(T0 value0, T1 value1) { }
        public (T0, T1) Receiver() { return default; }
    }
}
