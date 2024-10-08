using RRCG;
using System;

namespace RRCGBuild
{
    public static class RoomEvent
    {
        public static FloatPort Hz30() => ChipBuilder.EventReceiver<FloatPort>(RoomEvents.Hz30);
        public static void Hz30(AlternativeExec<FloatPort> onHz30) => CircuitBuilder.InlineGraph(() => onHz30(Hz30()));

        public static FloatPort Update() => ChipBuilder.EventReceiver<FloatPort>(RoomEvents.Update);
        public static void Update(AlternativeExec<FloatPort> onUpdate) => CircuitBuilder.InlineGraph(() => onUpdate(Update()));

        public static StringPort TestEvent() => ChipBuilder.EventReceiver<StringPort>(RoomEvents.TestEvent);
        public static void TestEvent(AlternativeExec<StringPort> onTestEvent) => CircuitBuilder.InlineGraph(() => { onTestEvent(TestEvent()); });

        public static ConsumablePort ConsumableUsed() => ChipBuilder.EventReceiver<ConsumablePort>(RoomEvents.ConsumableUsed);
        public static void ConsumableUsed(AlternativeExec<ConsumablePort> onConsumableUsed) => CircuitBuilder.InlineGraph(() => onConsumableUsed(ConsumableUsed()));
    }
}