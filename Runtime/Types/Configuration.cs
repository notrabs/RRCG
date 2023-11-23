using System;
using System.Collections.Generic;

namespace RRCG
{
    public static class RRCGConfigurationMap
    {
        public static Dictionary<string, string> ConfigurableChips = new Dictionary<string, string>() {
            { "SFXConstant", "SFXConstantData" },
            { "PlayAudioAtPosition", "PlayAudioAtPositionData" },
            { "PlayerWorldUI", "PlayerWorldUIData" },
            { "StudioFunction", "StudioFunctionData" },
            { "RoomKeyConstant", "RoomKeyData" },
            { "RoomCurrencyConstant", "RoomCurrencyData" },
            { "EventDefinition", "EventDefinitionData" },
            { "EventSender", "EventSenderData" },
            { "EventReceiver", "EventReceiverData" },
            { "Raycast", "RaycastData" },
            { "Spherecast", "RaycastData" },
            { "OverlapBox", "RaycastData" },
            { "OverlapSphere", "RaycastData" },
        };
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
        string ClipName,
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

    public record RoomKeyData(string Id);
    public record RoomCurrencyData(string Id);

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
}

namespace System.Runtime.CompilerServices
{
    // Without this class the record initializers don't work
    public class IsExternalInit { }
}

