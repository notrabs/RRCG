using RRCG;

namespace RRCGBuild
{
    public static class RoomEvent
    {
        public static FloatPort Hz30() => ChipBuilder.EventReceiver<FloatPort>(RoomEvents.Hz30);
        public static void Hz30(AlternativeExec<FloatPort> onHz30) => CircuitBuilder.InlineGraph(() => onHz30(Hz30()));

        public static void TestEvent() => ChipBuilder.EventReceiver(RoomEvents.TestEvent);
        public static void TestEvent(AlternativeExec onTestEvent) => CircuitBuilder.InlineGraph(() => { TestEvent(); onTestEvent(); });

        public static ConsumablePort ConsumableUsed() => ChipBuilder.EventReceiver<ConsumablePort>(RoomEvents.ConsumableUsed);
        public static void ConsumableUsed(AlternativeExec<ConsumablePort> onConsumableUsed) => CircuitBuilder.InlineGraph(() => onConsumableUsed(ConsumableUsed()));
    }
}