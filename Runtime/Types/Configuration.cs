using RRCGBuild;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RRCG
{
    public static class RRCGConfigurationMap
    {
        private static Dictionary<string, string> ConfigurableChips = new Dictionary<string, string>() {
            { "SFXConstant", "SFXConstantData" },
            { "StudioAudioConstant", "SFXConstantData" },
            { "PlayAudioAtPosition", "PlayAudioAtPositionData" },
            { "PlayerWorldUI", "PlayerWorldUIData" },
            { "StudioFunction", "StudioFunctionData" },
            { "RoomKeyConstantR1", "RoomKeyData" },
            { "RoomCurrencyConstantR1", "RoomCurrencyData" },
            { "ConsumableConstantR1", "RoomConsumableData" },
            { "EventDefinition", "EventDefinitionData" },
            { "EventSender", "EventSenderData" },
            { "EventReceiver", "EventReceiverData" },
            { "Raycast", "RaycastData" },
            { "Spherecast", "RaycastData" },
            { "OverlapBox", "RaycastData" },
            { "OverlapSphere", "RaycastData" },
            { "FogConstant", "FogData" },
            { "DataTable", "DataTableDefinitionData" },
            { "DataTableReadCell", "DataTableColumnData" },
            { "DataTableGetFirstRowContaining", "DataTableColumnData" },
            { "DataTableGetAllRowsContaining", "DataTableColumnData" },
            { "DataTableGetRowCount", "DataTableData" },
            { "DataTableGetColumnCount", "DataTableData" },
        };

        public static string GetConfigType(string chipName)
        {
            if (chipName.Contains("Variable")) return "VariableData";
            if (ConfigurableChips.ContainsKey(chipName)) return ConfigurableChips[chipName];
            return null;
        }
    }

    public record Vector3Data(float X, float Y, float Z);
    public record QuaternionData(float X, float Y, float Z, float W);
    public record TransformData(
        Vector3Data Position,
        QuaternionData Rotation
    )
    {
        public TransformData(
            Vector3 Position,
            Quaternion Rotation
        ) : this(
            new Vector3Data(Position.x, Position.y, Position.z),
            new QuaternionData(Rotation.x, Rotation.y, Rotation.z, Rotation.w))
        { }
    }

    public record WorldUIBar(
        bool Enabled = false,
        int Value = 0,
        int MaxValue = 100,
        bool Animated = true
    );

    public record PlayerWorldUIData(
            string Name,
            WorldUIBar Primary = null,
            WorldUIBar Secondary = null,
            string Text = "",
            bool Synced = true,
            bool EnableWhileJoining = false
    );

    public record SFXConstantData(
        string ClipNameOrId,
        float Volume = 1.0f,
        float SpeedShift = 0.0f,
        float SpeedVariation = 0.0f
    );

    public record PlayAudioAtPositionData(
        int AudioChannel = 1,
        float MaxRolloffDistance = 80,
        int RolloffCurve = 0,
        bool Synced = false
    );

    public record StudioFunctionData(
        string PrefabName,
        string FunctionName
    );

    public record RoomKeyData(Guid Id);
    public record RoomCurrencyData(Guid Id);
    public record RoomConsumableData(Guid Id);

    public record EventDefinitionData(
       string EventName,
       (string, Type)[] EventDefinition
    );

    public record EventReceiverData(
       string EventName
    );

    public record EventSenderData(
        string EventName,
        EventTarget EventTarget
    );

    public record RaycastData(
        bool IgnorePlayers = false,
        bool IgnoreObjects = false
    );

    public record VariableData(
        string Name,
        VariableKind Kind,
        Type Type,
        object HomeValue
    );

    public record DataTableColumnData(
        string DataTableName,
        string ColumnName
    );

    public record FogData(
        int Color,
        float StartDistance,
        float FadeDistance
    );

    public record DataTableDefinitionData(
        string Name,
        (Type Type, string Name, object[] Cells)[] Columns
    );

    // Couldn't come up with a descriptive name for this one.
    // This one is for Data Table Get Row/Column count.
    // It refers to a specific Data Table, but not to a column.
    public record DataTableData(
        string DataTableName
    );
}

namespace System.Runtime.CompilerServices
{
    // Without this class the record initializers don't work
    public class IsExternalInit { }
}

