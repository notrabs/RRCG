using RRCGGenerated;

namespace RRCG
{
    public class ChipTypeUtils
    {
        // All Variable types
        public static readonly string[] VariableTypes = new string[]
        {
            ChipType.AIVariable, ChipType.BoolVariable, ChipType.ColorVariable,
            ChipType.CombatantVariable, ChipType.DestinationRoomVariable, ChipType.FloatVariable,
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
    }
}
