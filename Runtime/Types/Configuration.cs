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
        };
    }

    public struct WorldUIBar
    {
        public bool Enabled;
        public int Value;
        public int MaxValue;
        public bool Animated;

        public WorldUIBar(bool Enabled = false, int Value = 0, int MaxValue = 100, bool Animated = true)
        {
            this.Enabled = Enabled;
            this.Value = Value;
            this.MaxValue = MaxValue;
            this.Animated = Animated;
        }
    }

    public struct PlayerWorldUIData
    {
        public string Name;

        public WorldUIBar Primary;
        public WorldUIBar Secondary;

        public string Text;
        public bool Synced;
        public bool EnableWhileJoining;

        public PlayerWorldUIData(
            string Name,
            WorldUIBar Primary = new WorldUIBar(),
            WorldUIBar Secondary = new WorldUIBar(),
            string Text = "",
            bool Synced = true,
            bool EnableWhileJoining = false
        )
        {
            this.Name = Name;
            this.Primary = Primary;
            this.Secondary = Secondary;
            this.Text = Text;
            this.Synced = Synced;
            this.EnableWhileJoining = EnableWhileJoining;
        }
    }

    public struct SFXConstantData
    {
        public string ClipName;
        public float Volume;
        public float SpeedShift;
        public float SpeedVariation;

        public SFXConstantData(string ClipName, float Volume = 1.0f, float SpeedShift = 0.0f, float SpeedVariation = 0.0f)
        {
            this.ClipName = ClipName;
            this.Volume = Volume;
            this.SpeedShift = SpeedShift;
            this.SpeedVariation = SpeedVariation;
        }
    }

    public struct PlayAudioAtPositionData
    {
        public int AudioChannel;
        public float MaxRolloffDistance;
        public int RolloffCurve;
        public bool Synced;

        public PlayAudioAtPositionData(int AudioChannel = 1, float MaxRolloffDistance = 80, int RolloffCurve = 0, bool Synced = false)
        {
            this.AudioChannel = AudioChannel;
            this.MaxRolloffDistance = MaxRolloffDistance;
            this.RolloffCurve = RolloffCurve;
            this.Synced = Synced;
        }
    }

    public struct StudioFunctionData
    {
        public string PrefabName;
        public string FunctionName;

        public StudioFunctionData(string PrefabName, string FunctionName)
        {
            this.PrefabName = PrefabName;
            this.FunctionName = FunctionName;
        }
    }

    public struct RoomKeyData
    {
        public string Id;

        public RoomKeyData(string Id)
        {
            this.Id = Id;
        }
    }

    public struct RoomCurrencyData
    {
        public string Id;

        public RoomCurrencyData(string Id)
        {
            this.Id = Id;
        }
    }
}
