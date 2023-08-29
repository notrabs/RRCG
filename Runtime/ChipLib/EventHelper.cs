namespace RRCGSource
{
    public class EventHelper
    {
        private string eventName;
        public EventHelper(string eventName)
        {
            this.eventName = eventName;
        }
        public void Definition() { }
        public void Sender() { }
        public void Receiver() { }
    }

    public class EventHelper<T0>
    {
        private string eventName;
        private string value0;
        public EventHelper(string eventName, string value0)
        {
            this.eventName = eventName;
            this.value0 = value0;
        }

        public void Definition() { }
        public void Sender(T0 value0) { }
        public T0 Receiver() { return default; }
    }

    public class EventHelper<T0, T1>
    {
        private string eventName;
        private string value0;
        private string value1;
        public EventHelper(string eventName, string value0, string value1)
        {
            this.eventName = eventName;
            this.value0 = value0;
            this.value1 = value1;
        }

        public void Definition() { }
        public void Sender(T0 value0, T1 value1) { }
        public (T0, T1) Receiver() { return default; }
    }
}
