using System;

namespace RRCGSource
{
    public class EventDefinition
    {
        public EventDefinition() { }
        public EventDefinition(string baseEventName) { }

        public void SendLocal() { }
        public void SendOthers() { }
        public void SendAll() { }
        public void SendAuthority() { }
        public void SendRoomAuthority() { }
        public void SendPlayer(Player player) { }

        /// <summary>
        /// Places an EventReceiver chip to continue execution on.
        /// </summary>
        public void Receiver() { }

        /// <summary>
        /// Shorthand to create an inline receiver graph for this event. 
        /// The Receiver chip is already placed when the callback is called.
        /// </summary>
        public EventDefinition Receiver(AlternativeExec inlineGraph) => default;

    }

    public class EventDefinition<T0>
    {
        public EventDefinition(string param0Name = null) { }
        public EventDefinition(string baseEventName, string param0Name) { }

        public void SendLocal(T0 value0) { }
        public void SendOthers(T0 value0) { }
        public void SendAll(T0 value0) { }
        public void SendAuthority(T0 value0) { }
        public void SendRoomAuthority(T0 value0) { }
        public void SendPlayer(Player player, T0 value0) { }

        public T0 Receiver() => default;
        public EventDefinition<T0> Receiver(AlternativeExec<T0> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1>
    {
        public EventDefinition(string param0Name = null, string param1Name = null) { }
        public EventDefinition(string baseEventName, string param0Name, string param1Name) { }

        public void SendLocal(T0 value0, T1 value1) { }
        public void SendOthers(T0 value0, T1 value1) { }
        public void SendAll(T0 value0, T1 value1) { }
        public void SendAuthority(T0 value0, T1 value1) { }
        public void SendRoomAuthority(T0 value0, T1 value1) { }
        public void SendPlayer(Player player, T0 value0, T1 value1) { }

        public (T0, T1) Receiver() => default;
        public EventDefinition<T0, T1> Receiver(AlternativeExec<(T0, T1)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null) { }
        public EventDefinition(string baseEventName, string param0Name, string param1Name, string param2Name) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2) { }
        public void SendAll(T0 value0, T1 value1, T2 value2) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2) { }

        public (T0, T1, T2) Receiver() => default;
        public EventDefinition<T0, T1, T2> Receiver(AlternativeExec<(T0, T1, T2)> inlineGraph) => default;
    }


    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
    public class EventHelper
    {
        public EventHelper(string eventName) { }
        public EventHelper Definition() { return this; }

        [Obsolete("Use SendLocal() instead")]
        public void Sender() { }

        public void SendLocal() { }
        public void SendOthers() { }
        public void SendAll() { }
        public void SendAuthority() { }
        public void SendRoomAuthority() { }
        public void SendPlayer(Player player) { }

        public void Receiver() { }
    }

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
    public class EventHelper<T0>
    {
        public EventHelper(string eventName, string value0 = "value0") { }
        public EventHelper<T0> Definition() { return this; }

        [Obsolete("Use SendLocal() instead")]
        public void Sender(T0 value0) { }

        public void SendLocal(T0 value0) { }
        public void SendOthers(T0 value0) { }
        public void SendAll(T0 value0) { }
        public void SendAuthority(T0 value0) { }
        public void SendRoomAuthority(T0 value0) { }
        public void SendPlayer(Player player, T0 value0) { }

        public T0 Receiver() { return default; }
    }

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
    public class EventHelper<T0, T1>
    {
        public EventHelper(string eventName, string value0 = "value0", string value1 = "value1") { }
        public EventHelper<T0, T1> Definition() { return this; }

        [Obsolete("Use SendLocal() instead")]
        public void Sender(T0 value0, T1 value1) { }

        public void SendLocal(T0 value0, T1 value1) { }
        public void SendOthers(T0 value0, T1 value1) { }
        public void SendAll(T0 value0, T1 value1) { }
        public void SendAuthority(T0 value0, T1 value1) { }
        public void SendRoomAuthority(T0 value0, T1 value1) { }
        public void SendPlayer(Player player, T0 value0, T1 value1) { }

        public (T0, T1) Receiver() { return default; }
    }
}
