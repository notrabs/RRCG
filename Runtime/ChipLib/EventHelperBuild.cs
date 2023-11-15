using RRCG;
using RRCGBuild;

namespace RRCGBuild
{

    public class EventHelper
    {
        private StringPort eventName;
        public EventHelper(StringPort eventName)
        {
            this.eventName = eventName;
        }
        public EventHelper Definition()
        {
            ChipBuilder.EventDefinition(eventName);
            return this;
        }

        public void Sender() => SendLocal();

        public void SendLocal() => ChipBuilder.EventSender(eventName, EventTarget.LOCAL);
        public void SendOthers() => ChipBuilder.EventSender(eventName, EventTarget.OTHERS);
        public void SendAll() => ChipBuilder.EventSender(eventName, EventTarget.ALL);
        public void SendAuthority() => ChipBuilder.EventSender(eventName, EventTarget.AUTHORITY);
        public void SendRoomAuthority() => ChipBuilder.EventSender(eventName, EventTarget.ROOM_AUTHORITY);
        public void SendPlayer(PlayerPort player) => ChipBuilder.EventSender(eventName, EventTarget.PLAYER, player);

        public void Receiver() => ChipBuilder.EventReceiver(eventName);
    }

    public class EventHelper<T0> where T0 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        public EventHelper(StringPort eventName, StringPort value0 = null)
        {
            this.eventName = eventName;
            this.value0 = value0 ?? "value0";
        }

        public EventHelper<T0> Definition()
        {
            ChipBuilder.EventDefinition(eventName, (value0, typeof(T0)));
            return this;
        }
        public void Sender(T0 value0) => SendLocal(value0);

        public void SendLocal(T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.LOCAL, value0);
        public void SendOthers(T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.OTHERS, value0);
        public void SendAll(T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.ALL, value0);
        public void SendAuthority(T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.AUTHORITY, value0);
        public void SendRoomAuthority(T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.ROOM_AUTHORITY, value0);
        public void SendPlayer(PlayerPort player, T0 value0) => ChipBuilder.EventSender(eventName, EventTarget.PLAYER, player, value0);

        public T0 Receiver() => ChipBuilder.EventReceiver<T0>(eventName);
    }

    public class EventHelper<T0, T1>
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        private StringPort value1;
        public EventHelper(
            StringPort eventName,
            StringPort value0 = null,
            StringPort value1 = null
        )
        {
            this.eventName = eventName;
            this.value0 = value0 ?? "value0";
            this.value1 = value1 ?? "value1";
        }
        public EventHelper<T0, T1> Definition()
        {
            ChipBuilder.EventDefinition(
                eventName,
                (value0, typeof(T0)),
                (value1, typeof(T1))
            );
            return this;
        }
        public void Sender(T0 value0, T1 value1) => SendLocal(value0, value1);

        public void SendLocal(T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.LOCAL, value0, value1);
        public void SendOthers(T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.OTHERS, value0, value1);
        public void SendAll(T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.ALL, value0, value1);
        public void SendAuthority(T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.AUTHORITY, value0, value1);
        public void SendRoomAuthority(T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.ROOM_AUTHORITY, value0, value1);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1) => ChipBuilder.EventSender(eventName, EventTarget.PLAYER, player, value0, value1);

        public (T0, T1) Receiver() => ChipBuilder.EventReceiver<T0, T1>(eventName);
    }

    public class EventHelper<T0, T1, T2>
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        private StringPort value1;
        private StringPort value2;
        public EventHelper(
            StringPort eventName,
            StringPort value0 = null,
            StringPort value1 = null,
            StringPort value2 = null
        )
        {
            this.eventName = eventName;
            this.value0 = value0 ?? "value0";
            this.value1 = value1 ?? "value1";
            this.value2 = value2 ?? "value2";
        }
        public EventHelper<T0, T1, T2> Definition()
        {
            ChipBuilder.EventDefinition(
                eventName,
                (value0, typeof(T0)),
                (value1, typeof(T1)),
                (value2, typeof(T2))
            );
            return this;
        }
        public void Sender(T0 value0, T1 value1, T2 value2) => SendLocal(value0, value1, value2);

        public void SendLocal(T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.LOCAL, value0, value1, value2);
        public void SendOthers(T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.OTHERS, value0, value1, value2);
        public void SendAll(T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.ALL, value0, value1, value2);
        public void SendAuthority(T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.AUTHORITY, value0, value1, value2);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.ROOM_AUTHORITY, value0, value1, value2);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2) => ChipBuilder.EventSender(eventName, EventTarget.PLAYER, player, value0, value1, value2);

        public (T0, T1, T2) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2>(eventName);
    }

    public class EventHelper<T0, T1, T2, T3>
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
    {
        private StringPort eventName;
        private StringPort value0;
        private StringPort value1;
        private StringPort value2;
        private StringPort value3;
        public EventHelper(
            StringPort eventName,
            StringPort value0 = null,
            StringPort value1 = null,
            StringPort value2 = null,
            StringPort value3 = null
        )
        {
            this.eventName = eventName;
            this.value0 = value0 ?? "value0";
            this.value1 = value1 ?? "value1";
            this.value2 = value2 ?? "value2";
            this.value3 = value3 ?? "value3";
        }
        public EventHelper<T0, T1, T2, T3> Definition()
        {
            ChipBuilder.EventDefinition(
                eventName,
                (value0, typeof(T0)),
                (value1, typeof(T1)),
                (value2, typeof(T2)),
                (value3, typeof(T3))
            );
            return this;
        }
        public void Sender(T0 value0, T1 value1, T2 value2, T3 value3) => SendLocal(value0, value1, value2, value3);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.LOCAL, value0, value1, value2, value3);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.OTHERS, value0, value1, value2, value3);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.ALL, value0, value1, value2, value3);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.AUTHORITY, value0, value1, value2, value3);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.ROOM_AUTHORITY, value0, value1, value2, value3);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3) => ChipBuilder.EventSender(eventName, EventTarget.PLAYER, player, value0, value1, value2, value3);

        public (T0, T1, T2, T3) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3>(eventName);
    }

}
