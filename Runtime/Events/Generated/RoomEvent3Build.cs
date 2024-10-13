using RRCGSource;
using UnityEngine;
using System;

namespace RRCGBuild
{
    public class RoomEvent3
    {
        public static void ConsumablePurchased(AlternativeExec<(ConsumablePort consumable, IntPort quantity)> onConsumablePurchased)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onConsumablePurchased(ChipBuilder.EventReceiver<(ConsumablePort consumable, IntPort quantity)>(Guid.ParseExact("b5678272-adbe-4e59-a833-bd156fd8f7fa", "D")));
            }

            );
        }

        public static void ConsumableUsed(AlternativeExec<ConsumablePort> onConsumableUsed)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onConsumableUsed(ChipBuilder.EventReceiver<ConsumablePort>(Guid.ParseExact("304464c2-e4ec-408c-9b6e-26788d9b0526", "D")));
            }

            );
        }

        public static void DEPRECATEDLocalPlayerSpawned(AlternativeExec onDEPRECATEDLocalPlayerSpawned)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                ChipBuilder.EventReceiver(Guid.ParseExact("3c0c12fe-d760-48a3-b44e-b96850f82a4a", "D"));
                onDEPRECATEDLocalPlayerSpawned();
            }

            );
        }

        public static void DEPRECATEDPlayerLeft(AlternativeExec<PlayerPort> onDEPRECATEDPlayerLeft)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onDEPRECATEDPlayerLeft(ChipBuilder.EventReceiver<PlayerPort>(Guid.ParseExact("f52effba-2c1b-4f0b-a661-7079b45710ff", "D")));
            }

            );
        }

        public static void LevelReached(AlternativeExec<IntPort> onLevelReached)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onLevelReached(ChipBuilder.EventReceiver<IntPort>(Guid.ParseExact("456a88e0-ed1d-4928-8af3-cb566ce19488", "D")));
            }

            );
        }

        public static void PlayerJoined(AlternativeExec<PlayerPort> onPlayerJoined)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onPlayerJoined(ChipBuilder.EventReceiver<PlayerPort>(Guid.ParseExact("a68a4b00-adf5-4aef-801a-fa6264771a9f", "D")));
            }

            );
        }

        public static void PlayerLeaving(AlternativeExec<PlayerPort> onPlayerLeaving)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onPlayerLeaving(ChipBuilder.EventReceiver<PlayerPort>(Guid.ParseExact("e8a19063-e8a2-40b0-a955-b0a23712aefa", "D")));
            }

            );
        }

        public static void PlayerLeft(AlternativeExec<PlayerPort> onPlayerLeft)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onPlayerLeft(ChipBuilder.EventReceiver<PlayerPort>(Guid.ParseExact("dd292b5d-5218-4d4a-abf4-aa9dbe283e50", "D")));
            }

            );
        }

        public static void RoomAuthorityChanged(AlternativeExec<PlayerPort> onRoomAuthorityChanged)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onRoomAuthorityChanged(ChipBuilder.EventReceiver<PlayerPort>(Guid.ParseExact("dc968273-75aa-455e-9aa4-58f4e9548e62", "D")));
            }

            );
        }

        public static void RoomKeyPurchased(AlternativeExec<RoomKeyPort> onRoomKeyPurchased)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onRoomKeyPurchased(ChipBuilder.EventReceiver<RoomKeyPort>(Guid.ParseExact("a6c9db82-c995-41f4-9e9e-2fa6241a21bf", "D")));
            }

            );
        }

        public static void RoomLoaded(AlternativeExec onRoomLoaded)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                ChipBuilder.EventReceiver(Guid.ParseExact("5efce997-30d2-431f-b156-c4ebda8fb1ad", "D"));
                onRoomLoaded();
            }

            );
        }

        public static void RoomReset(AlternativeExec onRoomReset)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                ChipBuilder.EventReceiver(Guid.ParseExact("ba20b726-fbc4-400b-b6fd-f88804063378", "D"));
                onRoomReset();
            }

            );
        }

        public static void TestEvent(AlternativeExec<StringPort> onTestEvent)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onTestEvent(ChipBuilder.EventReceiver<StringPort>(Guid.ParseExact("888ab607-ac44-422e-b3d7-94a219450484", "D")));
            }

            );
        }

        public static void Update30Hz(AlternativeExec<FloatPort> onUpdate30Hz)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                onUpdate30Hz(ChipBuilder.EventReceiver<FloatPort>(Guid.ParseExact("1ac8f2f7-ca6e-4530-b19a-1b9a8de3954d", "D")));
            }

            );
        }
    }
}