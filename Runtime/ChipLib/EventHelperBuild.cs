namespace RRCGBuild
{

    public class EventHelper
    {
        private StringPort eventName;
        public EventHelper(StringPort eventName)
        {
            this.eventName = eventName;
        }
        public void Definition()
        {
            ChipBuilder.EventDefinition(eventName);
        }
        public void Sender()
        {
            ChipBuilder.EventSender(eventName);
        }
        public void Receiver()
        {
            ChipBuilder.EventReceiver(eventName);
        }
    }

    public class EventHelper<T0> where T0 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        public EventHelper(StringPort eventName, StringPort value0)
        {
            this.eventName = eventName;
            this.value0 = value0;
        }

        public void Definition()
        {
            ChipBuilder.EventDefinition<T0>(eventName, value0);
        }
        public void Sender(T0 value0)
        {
            ChipBuilder.EventSender<T0>(eventName, value0);
        }
        public T0 Receiver()
        {
            return ChipBuilder.EventReceiver<T0>(eventName);
        }
    }

    public class EventHelper<T0, T1>
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        private StringPort value1;
        public EventHelper(StringPort eventName, StringPort value0, StringPort value1)
        {
            this.eventName = eventName;
            this.value0 = value0;
            this.value1 = value1;
        }
        public void Definition()
        {
            ChipBuilder.EventDefinition<T0, T1>(eventName, value0, value1);
        }
        public void Sender(T0 value0, T1 value1)
        {
            ChipBuilder.EventSender<T0, T1>(eventName, value0, value1);
        }
        public (T0, T1) Receiver()
        {
            return ChipBuilder.EventReceiver<T0, T1>(eventName);
        }
    }
}
