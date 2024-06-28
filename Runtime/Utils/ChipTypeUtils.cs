using RRCGBuild;
using RRCGGenerated;
using System.Collections.Generic;
using System.Linq;

namespace RRCG
{
    public class ChipTypeUtils
    {
        // All Variable types
        public static readonly string[] VariableTypes = new string[]
        {
            ChipType.AIVariableR1, ChipType.BoolVariable, ChipType.ColorVariable,
            ChipType.CombatantVariableR1, ChipType.DestinationRoomVariable, ChipType.FloatVariable,
            ChipType.IntVariable, ChipType.ListBoolVariable, ChipType.ListColorVariable,
            ChipType.ListDestinationRoomVariable, ChipType.ListFloatVariable, ChipType.ListIntVariable,
            ChipType.ListObjectiveMarkerVariable, ChipType.ListPlayerVariable, ChipType.ListQuaternionVariable,
            ChipType.ListRecRoomObjectVariable, ChipType.ListRewardVariable, ChipType.ListStringVariable,
            ChipType.ListVector3Variable, ChipType.PlayerVariable, ChipType.PlayerVariableDeprecated,
            ChipType.QuaternionVariable, ChipType.RecRoomObjectVariable, ChipType.StringVariable, ChipType.Vector3Variable
        };

        // These chips lack the grey title bar on top. 
        // The formatter can use this information to align their exec pins
        public static readonly string[] HeadlessChips = new string[]
        {
            ChipType.EventDefinition, ChipType.EventSender, ChipType.EventReceiver,
            ChipType.StudioEventSender, ChipType.StudioEventSenderBool,
            ChipType.StudioEventSenderFloat, ChipType.StudioEventSenderInt,
            ChipType.StudioEventSenderString, ChipType.StudioEventSenderStringBool,
            ChipType.StudioEventSenderStringFloat, ChipType.StudioEventSenderStringInt,
            ChipType.StudioEventSenderStringString
        };

        private static Dictionary<string, (int Group, int Index)[]> AsyncExecPorts = new()
        {
            { ChipType.AwardConsumableR1, new[] { (0, 1) } },
            { ChipType.AwardCurrencyDeprecatedR1, new[] { (0, 1) } },
            { ChipType.AwardCurrencyR1, new[] { (0, 1) } },
            { ChipType.AwardRoomKeyR1, new[] { (0, 1) } },
            { ChipType.Delay, new[] { (0, 1) } },
            { ChipType.GetCurrencyBalanceDeprecatedR1, new[] { (0, 1) } },
            { ChipType.GetCurrencyBalanceR1, new[] { (0, 1) } },
            { ChipType.GrantReward, new[] { (0, 1) } },
            { ChipType.LeaderboardGetPlayerStat, new[] { (0, 1) } },
            { ChipType.PlayerAwardXP, new[] { (0, 1) } },
            { ChipType.PlayerOwnsRoomKeyR1, new[] { (0, 1) } },
            { ChipType.PlayerPromptMultipleChoice, new[] { (0, 1) } },
            { ChipType.PlayerPromptText, new[] { (0, 1) } },
            { ChipType.PromptLocalPlayer, new[] { (0, 1), (0, 3) } },
            { ChipType.RoomBackgroundObjectsModifyR1, new[] { (0, 1) } },
            { ChipType.RoomBackgroundObjectsResetR1, new[] { (0, 1) } },
            { ChipType.RoomFogModifyR1, new[] { (0, 1) } },
            { ChipType.RoomFogResetR1, new[] { (0, 1) } },
            { ChipType.RoomSetMatchmakingState, new[] { (0, 1) } },
            { ChipType.RoomSkydomeModifyR1, new[] { (0, 1) } },
            { ChipType.RoomSkydomeResetR1, new[] { (0, 1) } },
            { ChipType.RoomSunModifyR1, new[] { (0, 1) } },
            { ChipType.RoomSunResetR1, new[] { (0, 1) } },
            { ChipType.InventoryItemAddR2, new[] { (0, 1) } },
            { ChipType.InventoryItemGetCountR2, new[] { (0, 1) } },
            { ChipType.InventoryItemRemoveR2, new[] { (0, 1) } },
            { ChipType.PlayerEquipInventoryItemR2, new[] { (0, 1) } },
            { ChipType.PlayerHasPurchasedRoomOfferR2, new[] { (0, 1) } },
            { ChipType.PlayerOwnsInventoryItemR2, new[] { (0, 1) } },
            { ChipType.PlayerUnequipFromSlotR2, new[] { (0, 1) } },
            { ChipType.PlayerUnequipInventoryItemR2, new[] { (0, 1) } },
            { ChipType.ReplicatorSpawnNextObjectR2, new[] { (0, 1) } },
            { ChipType.RoomBackgroundObjectsClearPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomBackgroundObjectsModifyR2, new[] { (0, 1) } },
            { ChipType.RoomBackgroundObjectsPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomBackgroundObjectsResetR2, new[] { (0, 1) } },
            { ChipType.RoomFogClearPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomFogModifyR2, new[] { (0, 1) } },
            { ChipType.RoomFogPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomFogResetR2, new[] { (0, 1) } },
            { ChipType.RoomSkydomeClearPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomSkydomeModifyR2, new[] { (0, 1) } },
            { ChipType.RoomSkydomePlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomSkydomeResetR2, new[] { (0, 1) } },
            { ChipType.RoomSunClearPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomSunModifyR2, new[] { (0, 1) } },
            { ChipType.RoomSunPlayerOverrideR2, new[] { (0, 1) } },
            { ChipType.RoomSunResetR2, new[] { (0, 1) } },
        };

        /// <summary>
        /// Returns true if the provided exec output port may run asynchronously.
        /// </summary>
        public static bool IsExecPortAsync(Port exec)
        {
            if (!AsyncExecPorts.TryGetValue(exec.Node.Type, out var ports))
                return false;

            return ports.Any(p => exec.Group == p.Group && exec.Index == p.Index);
        }
    }
}
