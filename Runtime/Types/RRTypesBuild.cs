
using RRCG;
using RRCGSource;
using System;
using UnityEngine;

namespace RRCGBuild
{
    public class AnyPort
    {
        public Port Port;
        public dynamic Data;

        public bool IsDataPort => Port == null;
        public bool IsActualPort => Port != null;

        public static implicit operator AnyPort(string data) => new AnyPort { Data = data };
        public static implicit operator AnyPort(int data) => new AnyPort { Data = data };
        public static implicit operator AnyPort(float data) => new AnyPort { Data = data };
        public static implicit operator AnyPort(bool data) => new AnyPort { Data = data };
        public static implicit operator AnyPort(Color data) => new AnyPort { Data = PortConversionUtils.EncodeColor(data) };

        public T AsData<T>()
        {
            if (IsActualPort) throw new Exception("Cannot convert actual port to data");
            return (T)Data;
        }

        /// <summary>
        /// Use this method ONLY in RRCG source code to trick the compiler into accepting your port.
        /// </summary>
        public T AsSourcePort<T>() => this as dynamic;
    }

    public class PortConversionUtils
    {
        public static int EncodeColor(Color color)
        {
            int r = (int)(color.r * 255);
            int g = (int)(color.g * 255);
            int b = (int)(color.b * 255);

            return (r << 16) + (g << 8) + b + 1000;
        }
    }

    public class PortBuilderAny : AnyPort { }
    public class ListPort<T> : AnyPort where T : AnyPort, new()
    {
        public T this[IntPort i]
        {
            get
            {
                return ChipBuilder.ListGetElement(this, i);
            }
            set
            {
                ChipBuilder.ListSetElement<T>(this, i, value);
            }
        }

        public IntPort Count
        {
            get { return ChipBuilder.ListGetCount(this); }
        }
    }
    public class RRTuplePort<T0, T1> : AnyPort { }
    public class ColorPort : AnyPort
    {
        public ColorPort() { }
        public ColorPort(float r, float g, float b) { Data = PortConversionUtils.EncodeColor(new Color(r, g, b)); }
        public ColorPort(float r, float g, float b, float a) { Data = PortConversionUtils.EncodeColor(new Color(r, g, b, a)); }

        public static implicit operator ColorPort(Color data) => new ColorPort { Data = PortConversionUtils.EncodeColor(data) };
    }
    public class LightPort : AnyPort { }
    public class StringPort : AnyPort
    {
        public StringPort() { }
        public StringPort(char c, int count) { Data = new string(c, count); }

        public static implicit operator StringPort(string data) => new StringPort { Data = data };
        public static explicit operator string(StringPort data) => data.AsData<string>();
    }
    public class IntPort : AnyPort
    {
        public static implicit operator IntPort(int data) => new IntPort { Data = data };
        public static explicit operator int(IntPort data) => data.AsData<int>();

        public static explicit operator string(IntPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(IntPort data) => (string)data;

        public static IntPort operator -(IntPort data)
        {
            if (data.IsDataPort) return new IntPort { Data = -data.Data };
            return ChipBuilder.Subtract(0, data);
        }
        public static IntPort operator +(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data + b.Data };
            return ChipBuilder.Add(a, b);
        }

        public static IntPort operator -(IntPort a, IntPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new IntPort { Data = a.Data - b.Data };
            return ChipBuilder.Subtract(a, b);
        }
    }
    public class FloatPort : AnyPort
    {
        public static implicit operator FloatPort(float data) => new FloatPort { Data = data };
        public static explicit operator float(FloatPort data) => data.AsData<float>();

        public static explicit operator string(FloatPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(FloatPort data) => (string)data;
        public static FloatPort operator -(FloatPort data)
        {
            if (data.IsDataPort) return new FloatPort { Data = -data.Data };
            return ChipBuilder.Subtract(0, data);
        }

        public static FloatPort operator +(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data + b.Data };
            return ChipBuilder.Add(a, b);
        }

        public static FloatPort operator -(FloatPort a, FloatPort b)
        {
            if (a.IsDataPort && b.IsDataPort) return new FloatPort { Data = a.Data - b.Data };
            return ChipBuilder.Subtract(a, b);
        }
    }
    public class BoolPort : AnyPort
    {
        public static implicit operator BoolPort(bool data) => new BoolPort { Data = data };
        public static explicit operator bool(BoolPort data) => data.AsData<bool>();

        public static explicit operator string(BoolPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(BoolPort data) => (string)data;
        public static BoolPort operator !(BoolPort data)
        {
            if (data.IsDataPort) return new BoolPort { Data = !data.Data };
            return ChipBuilder.Not(data);
        }
    }
    public class Vector3Port : AnyPort
    {
        public static Vector3Port zero { get => CircuitBuilder.Singleton("Vector3_zero", () => ChipBuilder.Vector3Create(0, 0, 0)); }
        public static Vector3Port up { get => CircuitBuilder.Singleton("Vector3_up", () => ChipBuilder.Vector3Create(0, 1, 0)); }

        public Vector3Port() { }

        public Vector3Port(FloatPort x, FloatPort y, FloatPort z)
        {
            Port = ChipBuilder.Vector3Create(x, y, z).Port;
        }

        public (FloatPort X, FloatPort Y, FloatPort Z) split
        {
            get
            {
                if (IsActualPort) return CircuitBuilder.Singleton("Vector3_split_" + Port.PortKey(), () => ChipBuilder.Vector3Split(this));

                var v = (Vector3)Data;
                return (v.x, v.y, v.z);
            }
        }

        public FloatPort x { get => split.X; }
        public FloatPort y { get => split.Y; }
        public FloatPort z { get => split.Z; }
    }
    public class QuaternionPort : AnyPort
    {
        public static QuaternionPort identity { get => CircuitBuilder.Singleton("Quaternion_identity", () => ChipBuilder.QuaternionCreate(0, 0, 0, 1)); }
    }
    public class ObjectPort : AnyPort { }
    public class AIPort : AnyPort { }
    public class WelcomeMatPort : AnyPort
    {
        public static implicit operator WelcomeMatPort(RecRoomObjectPort data) => new WelcomeMatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerHandlePort : AnyPort
    {
        public static implicit operator TriggerHandlePort(RecRoomObjectPort data) => new TriggerHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class StudioObjectPort : AnyPort
    {
        public static implicit operator StudioObjectPort(RecRoomObjectPort data) => new StudioObjectPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnalyticsPayloadPort : AnyPort { }
    public class PlayerPort : AnyPort
    {
        public static PlayerPort Local = new PlayerPort() { Port = null, Data = 1 };
        public static PlayerPort Invalid = new PlayerPort() { Port = null, Data = 0 };
    }
    public class RecRoomObjectPort : AnyPort
    {
        public static RecRoomObjectPort Invalid
        {
            get => CircuitBuilder.Singleton("RRCG_Invalid_RRO", () => new NamedVariable<RecRoomObjectPort>("RRCG_Invalid_RRO").Value);
        }
    }
    public class CombatantPort : AnyPort { }
    public class PatrolPointPort : AnyPort { }
    public class AudioPort : AnyPort
    {
        public SFXConstantData SFXData;

        public static AudioPort AudioSFXConstant(string clipName, float volume, float speedShift, float speedVariation)
        {
            ChipBuilder.SFXConstant();
            var node = Context.lastSpawnedNode;

            node.SFXConstantData = new SFXConstantData(clipName, volume, speedShift, speedVariation);

            return new AudioPort() { Port = node.Port(0, 0) };
        }

        public static AudioPort AudioSFXConstant(string clipName)
        {
            return AudioSFXConstant(clipName, 1f, 0f, 0f);
        }

        public static AudioPort SFX_Click { get => CircuitBuilder.Singleton("SFX_Click", () => AudioSFXConstant("Click")); }
        public static AudioPort SFX_Firework { get => CircuitBuilder.Singleton("SFX_Firework", () => AudioSFXConstant("Firework")); }
        public static AudioPort SFX_UIXP02 { get => CircuitBuilder.Singleton("SFX_UIXP02", () => AudioSFXConstant("UIXP02")); }
        public static AudioPort SFX_CrowdAww { get => CircuitBuilder.Singleton("SFX_CrowdAww", () => AudioSFXConstant("CrowdAww")); }
        public static AudioPort SFX_CrowdCheer { get => CircuitBuilder.Singleton("SFX_CrowdCheer", () => AudioSFXConstant("CrowdCheer")); }
        public static AudioPort SFX_TriggerMisfire { get => CircuitBuilder.Singleton("SFX_TriggerMisfire", () => AudioSFXConstant("TriggerMisfire")); }
        public static AudioPort SFX_UIScore01 { get => CircuitBuilder.Singleton("SFX_UIScore01", () => AudioSFXConstant("UIScore01")); }
        public static AudioPort SFX_UIScore04 { get => CircuitBuilder.Singleton("SFX_UIScore04", () => AudioSFXConstant("UIScore04")); }
    }
    public class AudioPlayerPort : AnyPort
    {
        public static implicit operator AudioPlayerPort(RecRoomObjectPort data) => new AudioPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ConsumablePort : AnyPort { }
    public class RoomKeyPort : AnyPort
    {
        public RoomKeyPort() { }
        public RoomKeyPort(string name)
        {
            ChipBuilder.RoomKeyConstant();
            var node = Context.lastSpawnedNode;
            node.RoomKey = name;

            Port = node.Port(0, 0);
        }
    }
    public class BackgroundObjectsPort : AnyPort { }
    public class BeaconPort : AnyPort
    {
        public static implicit operator BeaconPort(RecRoomObjectPort data) => new BeaconPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ButtonPort : AnyPort
    {
        public static implicit operator ButtonPort(RecRoomObjectPort data) => new ButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextScreenPort : AnyPort
    {
        public static implicit operator TextScreenPort(RecRoomObjectPort data) => new TextScreenPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class CollisionDataPort : AnyPort { }
    public class CostumePort : AnyPort
    {
        public static implicit operator CostumePort(RecRoomObjectPort data) => new CostumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class DestinationRoomPort : AnyPort { }
    public class DiePort : AnyPort
    {
        public static implicit operator DiePort(RecRoomObjectPort data) => new DiePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerWorldUIPort : AnyPort
    {
        public PlayerWorldUIPort() { }

        public PlayerWorldUIPort(string name, WorldUIBar primary, WorldUIBar secondary, string text, bool synced, bool enableWhileJoining)
        {
            ChipBuilder.PlayerWorldUI();
            var node = Context.lastSpawnedNode;

            Port = node.Port(0, 0);
        }
    }
    public class RoomDoorPort : AnyPort
    {
        public static implicit operator RoomDoorPort(RecRoomObjectPort data) => new RoomDoorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class EmitterPort : AnyPort
    {
        public static implicit operator EmitterPort(RecRoomObjectPort data) => new EmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ExplosionEmitterPort : AnyPort
    {
        public static implicit operator ExplosionEmitterPort(RecRoomObjectPort data) => new ExplosionEmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class FogPort : AnyPort { }
    public class HUDElementPort : AnyPort { }
    public class RewardPort : AnyPort { }
    public class GroundVehiclePort : AnyPort
    {
        public static implicit operator GroundVehiclePort(RecRoomObjectPort data) => new GroundVehiclePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GunHandlePort : AnyPort
    {
        public static implicit operator GunHandlePort(RecRoomObjectPort data) => new GunHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HolotarProjectorPort : AnyPort
    {
        public static implicit operator HolotarProjectorPort(RecRoomObjectPort data) => new HolotarProjectorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InteractionVolumePort : AnyPort
    {
        public static implicit operator InteractionVolumePort(RecRoomObjectPort data) => new InteractionVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InvisibleCollisionPort : AnyPort
    {
        public static implicit operator InvisibleCollisionPort(RecRoomObjectPort data) => new InvisibleCollisionPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LaserPointerPort : AnyPort
    {
        public static implicit operator LaserPointerPort(RecRoomObjectPort data) => new LaserPointerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PistonPort : AnyPort
    {
        public static implicit operator PistonPort(RecRoomObjectPort data) => new PistonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerOutfitSlotPort : AnyPort { }
    public class ProjectileLauncherPort : AnyPort
    {
        public static implicit operator ProjectileLauncherPort(RecRoomObjectPort data) => new ProjectileLauncherPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RemoteVideoPlayerPort : AnyPort
    {
        public static implicit operator RemoteVideoPlayerPort(RecRoomObjectPort data) => new RemoteVideoPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerSpawnPointV2Port : AnyPort
    {
        public static implicit operator PlayerSpawnPointV2Port(RecRoomObjectPort data) => new PlayerSpawnPointV2Port() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SkydomePort : AnyPort { }
    public class SunPort : AnyPort { }
    public class SunDirectionPort : AnyPort { }
    public class RotatorPort : AnyPort
    {
        public static implicit operator RotatorPort(RecRoomObjectPort data) => new RotatorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SeatPort : AnyPort
    {
        public static implicit operator SeatPort(RecRoomObjectPort data) => new SeatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SFXPort : AnyPort
    {
        public static implicit operator SFXPort(RecRoomObjectPort data) => new SFXPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextPort : AnyPort
    {
        public static implicit operator TextPort(RecRoomObjectPort data) => new TextPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ToggleButtonPort : AnyPort
    {
        public static implicit operator ToggleButtonPort(RecRoomObjectPort data) => new ToggleButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MotionTrailPort : AnyPort
    {
        public static implicit operator MotionTrailPort(RecRoomObjectPort data) => new MotionTrailPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerVolumePort : AnyPort
    {
        public static implicit operator TriggerVolumePort(RecRoomObjectPort data) => new TriggerVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class VectorComponentPort : AnyPort
    {
        public static implicit operator VectorComponentPort(RecRoomObjectPort data) => new VectorComponentPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomCurrencyPort : AnyPort
    {
        public RoomCurrencyPort() { }

        public RoomCurrencyPort(string name)
        {
            ChipBuilder.RoomCurrencyConstant();
            var node = Context.lastSpawnedNode;
            node.RoomCurrency = name;

            Port = node.Port(0, 0);
        }
    }
    public class HUDConstantPort : AnyPort
    {
        public static implicit operator HUDConstantPort(RecRoomObjectPort data) => new HUDConstantPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SteeringEnginePort : AnyPort
    {
        public static implicit operator SteeringEnginePort(RecRoomObjectPort data) => new SteeringEnginePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GiftDropShopItemPort : AnyPort
    {
        public static implicit operator GiftDropShopItemPort(RecRoomObjectPort data) => new GiftDropShopItemPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ObjectiveMarkerPort : AnyPort
    {
        public static implicit operator ObjectiveMarkerPort(RecRoomObjectPort data) => new ObjectiveMarkerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MeleeZonePort : AnyPort
    {
        public static implicit operator MeleeZonePort(RecRoomObjectPort data) => new MeleeZonePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SwingHandlePort : AnyPort
    {
        public static implicit operator SwingHandlePort(RecRoomObjectPort data) => new SwingHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomLevelHUDPort : AnyPort
    {
        public static implicit operator RoomLevelHUDPort(RecRoomObjectPort data) => new RoomLevelHUDPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TouchpadPort : AnyPort
    {
        public static implicit operator TouchpadPort(RecRoomObjectPort data) => new TouchpadPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnimationControllerPort : AnyPort
    {
        public static implicit operator AnimationControllerPort(RecRoomObjectPort data) => new AnimationControllerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InventoryItemPort : AnyPort { }
    public class StatePort : AnyPort { }
    public class GrabberPort : AnyPort { }
    public class EquipmentSlotPort : AnyPort { }
}
