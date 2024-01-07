using RRCGSource;
using RRCG;

namespace RRCGSource
{
    public static class RoomEvent
    {
        /// <returns>deltaTime</returns>
        public static float Hz30() => default;
        public static void Hz30(AlternativeExec<float> onHz30) { }

        public static void TestEvent() { }
        public static void TestEvent(AlternativeExec<float> onTestEvent) { }

        /// <returns>The consumable requested for use by the user</returns>
        public static Consumable ConsumableUsed() => default;
        public static void ConsumableUsed(AlternativeExec<Consumable> onConsumableUsed) { }
    }
}
