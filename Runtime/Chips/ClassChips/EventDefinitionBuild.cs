﻿using RRCG;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public abstract class BaseEvent
    {
        protected string EventName;
        protected (StringPort, Type)[] EventDefinition;

        protected BaseEvent() { }

        protected void InitNewEvent(string eventName, params (StringPort, Type)[] eventDefinition)
        {
            var sourceName = SanitizeUtils.SantizeCV2Name(SemanticStackUtils.GetNamedAssignmentName("Event"));

            var eventNameBase = eventName ?? sourceName;

            EventName = Context.current.GetUniqueId($"RRCG_{eventNameBase}");
            EventDefinition = eventDefinition;

            ChipBuilder.EventDefinition(EventName, eventDefinition);
        }

        protected void InitExistingEvent(string eventName)
        {
            EventName = eventName;
        }

        public void SendLocal(params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.LOCAL, values);
        public void SendOthers(params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.OTHERS, values);
        public void SendAll(params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.ALL, values);
        public void SendAuthority(params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.AUTHORITY, values);
        public void SendRoomAuthority(params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.ROOM_AUTHORITY, values);
        public void SendPlayer(PlayerPort player, params AnyPort[] values) => ChipBuilder.EventSender(EventName, EventTarget.PLAYER, new[] { player }.Concat(values).ToArray());
    }

    // Access to the generic interface. It is up to the user to make sure the types are correct.
    internal class DynamicEventDefinition : BaseEvent
    {
        public DynamicEventDefinition(StringPort eventName, params (StringPort, Type)[] eventDefinition) => InitNewEvent(eventName.AsData<string>(), eventDefinition);

        public AnyPort[] Receiver()
        {
            ChipBuilder.EventReceiver(EventName);

            var node = Context.lastSpawnedNode;

            var ports = new List<AnyPort>();

            for (var i = 0; i < EventDefinition.Length; i++)
            {
                var portType = EventDefinition[i].Item2;

                var port = (AnyPort)Activator.CreateInstance(portType);

                port.Port = node.Port(0, 1 + i);

                ports.Add(port);
            }

            return ports.ToArray();
        }
    }

    public class EventDefinition : BaseEvent
    {
        public EventDefinition() => InitNewEvent(null);
        public EventDefinition(StringPort eventName) => InitNewEvent(eventName.AsData<string>());

        // The bool param is only used to make the signature different from the other constructors
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal() => base.SendLocal();
        public void SendOthers() => base.SendOthers();
        public void SendAll() => base.SendAll();
        public void SendAuthority() => base.SendAuthority();
        public void SendRoomAuthority() => base.SendRoomAuthority();
        public void SendPlayer(PlayerPort player) => base.SendPlayer(player);

        public void Receiver() => ChipBuilder.EventReceiver(EventName);
        public EventDefinition Receiver(AlternativeExec inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => { Receiver(); inlineGraph(); });
            return this;
        }

    }

    public class EventDefinition<T0> : BaseEvent
        where T0 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0) => base.SendLocal(value0);
        public void SendOthers(T0 value0) => base.SendOthers(value0);
        public void SendAll(T0 value0) => base.SendAll(value0);
        public void SendAuthority(T0 value0) => base.SendAuthority(value0);
        public void SendRoomAuthority(T0 value0) => base.SendRoomAuthority(value0);
        public void SendPlayer(PlayerPort player, T0 value0) => base.SendPlayer(player, value0);

        public T0 Receiver() => ChipBuilder.EventReceiver<T0>(EventName);
        public EventDefinition<T0> Receiver(AlternativeExec<T0> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1> : BaseEvent
           where T0 : AnyPort, new()
           where T1 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1) => base.SendLocal(value0, value1);
        public void SendOthers(T0 value0, T1 value1) => base.SendOthers(value0, value1);
        public void SendAll(T0 value0, T1 value1) => base.SendAll(value0, value1);
        public void SendAuthority(T0 value0, T1 value1) => base.SendAuthority(value0, value1);
        public void SendRoomAuthority(T0 value0, T1 value1) => base.SendRoomAuthority(value0, value1);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1) => base.SendPlayer(player, value0, value1);

        public (T0, T1) Receiver() => ChipBuilder.EventReceiver<T0, T1>(EventName);
        public EventDefinition<T0, T1> Receiver(AlternativeExec<(T0, T1)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2) => base.SendLocal(value0, value1, value2);
        public void SendOthers(T0 value0, T1 value1, T2 value2) => base.SendOthers(value0, value1, value2);
        public void SendAll(T0 value0, T1 value1, T2 value2) => base.SendAll(value0, value1, value2);
        public void SendAuthority(T0 value0, T1 value1, T2 value2) => base.SendAuthority(value0, value1, value2);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2) => base.SendRoomAuthority(value0, value1, value2);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2) => base.SendPlayer(player, value0, value1, value2);

        public (T0, T1, T2) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2>(EventName);
        public EventDefinition<T0, T1, T2> Receiver(AlternativeExec<(T0, T1, T2)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3) => base.SendLocal(value0, value1, value2, value3);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3) => base.SendOthers(value0, value1, value2, value3);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3) => base.SendAll(value0, value1, value2, value3);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3) => base.SendAuthority(value0, value1, value2, value3);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3) => base.SendRoomAuthority(value0, value1, value2, value3);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3) => base.SendPlayer(player, value0, value1, value2, value3);

        public (T0, T1, T2, T3) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3>(EventName);
        public EventDefinition<T0, T1, T2, T3> Receiver(AlternativeExec<(T0, T1, T2, T3)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendLocal(value0, value1, value2, value3, value4);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendOthers(value0, value1, value2, value3, value4);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendAll(value0, value1, value2, value3, value4);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendAuthority(value0, value1, value2, value3, value4);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendRoomAuthority(value0, value1, value2, value3, value4);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) => base.SendPlayer(player, value0, value1, value2, value3, value4);

        public (T0, T1, T2, T3, T4) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4> Receiver(AlternativeExec<(T0, T1, T2, T3, T4)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendLocal(value0, value1, value2, value3, value4, value5);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendOthers(value0, value1, value2, value3, value4, value5);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendAll(value0, value1, value2, value3, value4, value5);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendAuthority(value0, value1, value2, value3, value4, value5);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5);

        public (T0, T1, T2, T3, T4, T5) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendAll(value0, value1, value2, value3, value4, value5, value6);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6);

        public (T0, T1, T2, T3, T4, T5, T6) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7);

        public (T0, T1, T2, T3, T4, T5, T6, T7) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
       where T11 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null, StringPort param11Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name, StringPort param11Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
       where T11 : AnyPort, new()
       where T12 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null, StringPort param11Name = null, StringPort param12Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name, StringPort param11Name, StringPort param12Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
       where T11 : AnyPort, new()
       where T12 : AnyPort, new()
       where T13 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null, StringPort param11Name = null, StringPort param12Name = null, StringPort param13Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name, StringPort param11Name, StringPort param12Name, StringPort param13Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
       where T11 : AnyPort, new()
       where T12 : AnyPort, new()
       where T13 : AnyPort, new()
       where T14 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null, StringPort param11Name = null, StringPort param12Name = null, StringPort param13Name = null, StringPort param14Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13)),
            (param14Name ?? "value14", typeof(T14))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name, StringPort param11Name, StringPort param12Name, StringPort param13Name, StringPort param14Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13)),
            (param14Name ?? "value14", typeof(T14))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    public class EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : BaseEvent
       where T0 : AnyPort, new()
       where T1 : AnyPort, new()
       where T2 : AnyPort, new()
       where T3 : AnyPort, new()
       where T4 : AnyPort, new()
       where T5 : AnyPort, new()
       where T6 : AnyPort, new()
       where T7 : AnyPort, new()
       where T8 : AnyPort, new()
       where T9 : AnyPort, new()
       where T10 : AnyPort, new()
       where T11 : AnyPort, new()
       where T12 : AnyPort, new()
       where T13 : AnyPort, new()
       where T14 : AnyPort, new()
       where T15 : AnyPort, new()
    {
        public EventDefinition(StringPort param0Name = null, StringPort param1Name = null, StringPort param2Name = null, StringPort param3Name = null, StringPort param4Name = null, StringPort param5Name = null, StringPort param6Name = null, StringPort param7Name = null, StringPort param8Name = null, StringPort param9Name = null, StringPort param10Name = null, StringPort param11Name = null, StringPort param12Name = null, StringPort param13Name = null, StringPort param14Name = null, StringPort param15Name = null) => InitNewEvent(
            null,
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13)),
            (param14Name ?? "value14", typeof(T14)),
            (param15Name ?? "value15", typeof(T15))
        );
        public EventDefinition(StringPort eventName, StringPort param0Name, StringPort param1Name, StringPort param2Name, StringPort param3Name, StringPort param4Name, StringPort param5Name, StringPort param6Name, StringPort param7Name, StringPort param8Name, StringPort param9Name, StringPort param10Name, StringPort param11Name, StringPort param12Name, StringPort param13Name, StringPort param14Name, StringPort param15Name) => InitNewEvent(
            eventName.AsData<string>(),
            (param0Name ?? "value0", typeof(T0)),
            (param1Name ?? "value1", typeof(T1)),
            (param2Name ?? "value2", typeof(T2)),
            (param3Name ?? "value3", typeof(T3)),
            (param4Name ?? "value4", typeof(T4)),
            (param5Name ?? "value5", typeof(T5)),
            (param6Name ?? "value6", typeof(T6)),
            (param7Name ?? "value7", typeof(T7)),
            (param8Name ?? "value8", typeof(T8)),
            (param9Name ?? "value9", typeof(T9)),
            (param10Name ?? "value10", typeof(T10)),
            (param11Name ?? "value11", typeof(T11)),
            (param12Name ?? "value12", typeof(T12)),
            (param13Name ?? "value13", typeof(T13)),
            (param14Name ?? "value14", typeof(T14)),
            (param15Name ?? "value15", typeof(T15))
        );
        internal EventDefinition(bool _, string existingEvent) => InitExistingEvent(existingEvent);

        public void SendLocal(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendLocal(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        public void SendOthers(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendOthers(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        public void SendAll(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendAll(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        public void SendAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        public void SendRoomAuthority(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendRoomAuthority(value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        public void SendPlayer(PlayerPort player, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) => base.SendPlayer(player, value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

        public (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) Receiver() => ChipBuilder.EventReceiver<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(EventName);
        public EventDefinition<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Receiver(AlternativeExec<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> inlineGraph)
        {
            CircuitBuilder.InlineGraph(() => inlineGraph(Receiver()));
            return this;
        }
    }

    //
    // Old classes
    //

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
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

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
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

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
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

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
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

    [Obsolete("Use new EventDefinition() or ExistingEvent() instead")]
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
