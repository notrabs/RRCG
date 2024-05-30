using RRCGSource;
using RRCG;

namespace RRCGSource
{
    public static class RoomEvent
    {
        /// <returns>deltaTime</returns>
        public static float Hz30() => default;
        public static void Hz30(AlternativeExec<float> onHz30) { }

        /// Update event running every graphics frame (may run multiple times per circuit tick)
        /// <returns>deltaTime</returns>
        public static float Update() => default;
        public static void Update(AlternativeExec<float> onHz30) { }

        /// <returns>The parameter configured by the user before sending Test Event</returns>
        public static string TestEvent() => default;
        public static void TestEvent(AlternativeExec<string> onTestEvent) { }

        /// <returns>The consumable requested for use by the user</returns>
        public static Consumable ConsumableUsed() => default;
        public static void ConsumableUsed(AlternativeExec<Consumable> onConsumableUsed) { }
    }
}
