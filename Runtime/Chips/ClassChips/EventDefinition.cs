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

    public class EventDefinition<T0, T1, T2, T3>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3) { }

        public (T0, T1, T2, T3) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3> Receiver(AlternativeExec<(T0, T1, T2, T3)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }

        public (T0, T1, T2, T3, T4) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4> Receiver(AlternativeExec<(T0, T1, T2, T3, T4)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }

        public (T0, T1, T2, T3, T4, T5) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }

        public (T0, T1, T2, T3, T4, T5, T6) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null, string param11Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null, string param11Name = null, string param12Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null, string param11Name = null, string param12Name = null, string param13Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12, string param13) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null, string param11Name = null, string param12Name = null, string param13Name = null, string param14Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12, string param13, string param14) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> inlineGraph) => default;
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public EventDefinition(string param0Name = null, string param1Name = null, string param2Name = null, string param3Name = null, string param4Name = null, string param5Name = null, string param6Name = null, string param7Name = null, string param8Name = null, string param9Name = null, string param10Name = null, string param11Name = null, string param12Name = null, string param13Name = null, string param14Name = null, string param15Name = null) { }
        public EventDefinition(string baseEventName, string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12, string param13, string param14, string param15) { }

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }
        public void SendPlayer(Player player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) { }

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) Receiver() => default;
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> inlineGraph) => default;
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
