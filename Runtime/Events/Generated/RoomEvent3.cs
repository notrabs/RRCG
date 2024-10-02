using RRCGSource;
using System;

namespace RRCGSource
{
    public class RoomEvent3
    {
        /// <summary>
        /// Consumable Purchased
        /// </summary>
        public static void ConsumablePurchased(AlternativeExec<(Consumable consumable, int quantity)> onConsumablePurchased)
        {
        }

        /// <summary>
        /// Consumable Used
        /// </summary>
        public static void ConsumableUsed(AlternativeExec<Consumable> onConsumableUsed)
        {
        }

        /// <summary>
        /// DEPRECATED Local Player Spawned
        /// </summary>
        public static void DEPRECATEDLocalPlayerSpawned(AlternativeExec onDEPRECATEDLocalPlayerSpawned)
        {
        }

        /// <summary>
        /// DEPRECATED Player Left
        /// </summary>
        public static void DEPRECATEDPlayerLeft(AlternativeExec<Player> onDEPRECATEDPlayerLeft)
        {
        }

        /// <summary>
        /// Level Reached
        /// </summary>
        public static void LevelReached(AlternativeExec<int> onLevelReached)
        {
        }

        /// <summary>
        /// Player Joined
        /// </summary>
        public static void PlayerJoined(AlternativeExec<Player> onPlayerJoined)
        {
        }

        /// <summary>
        /// Player Leaving
        /// </summary>
        public static void PlayerLeaving(AlternativeExec<Player> onPlayerLeaving)
        {
        }

        /// <summary>
        /// Player Left
        /// </summary>
        public static void PlayerLeft(AlternativeExec<Player> onPlayerLeft)
        {
        }

        /// <summary>
        /// Room Authority Changed
        /// </summary>
        public static void RoomAuthorityChanged(AlternativeExec<Player> onRoomAuthorityChanged)
        {
        }

        /// <summary>
        /// Room Key Purchased
        /// </summary>
        public static void RoomKeyPurchased(AlternativeExec<RoomKey> onRoomKeyPurchased)
        {
        }

        /// <summary>
        /// Room Loaded
        /// </summary>
        public static void RoomLoaded(AlternativeExec onRoomLoaded)
        {
        }

        /// <summary>
        /// Room Reset
        /// </summary>
        public static void RoomReset(AlternativeExec onRoomReset)
        {
        }

        /// <summary>
        /// Test Event
        /// </summary>
        public static void TestEvent(AlternativeExec<string> onTestEvent)
        {
        }

        /// <summary>
        /// Update 30Hz
        /// </summary>
        public static void Update30Hz(AlternativeExec<float> onUpdate30Hz)
        {
        }
    }
}