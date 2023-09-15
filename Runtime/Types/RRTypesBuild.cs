
using System;

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

    public class PortBuilderAny : AnyPort { }
    public class ListPort<T> : AnyPort { }
    public class ColorPort : AnyPort { }
    public class LightPort : AnyPort { }
    public class StringPort : AnyPort
    {
        public static implicit operator StringPort(string data) => new StringPort { Data = data };
        public static explicit operator string(StringPort data) => data.AsData<string>();
    }
    public class IntPort : AnyPort
    {
        public static implicit operator IntPort(int data) => new IntPort { Data = data };
        public static explicit operator int(IntPort data) => data.AsData<int>();

        public static explicit operator string(IntPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(IntPort data) => (string)data;
    }
    public class FloatPort : AnyPort
    {
        public static implicit operator FloatPort(float data) => new FloatPort { Data = data };
        public static explicit operator float(FloatPort data) => data.AsData<float>();

        public static explicit operator string(FloatPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(FloatPort data) => (string)data;
    }
    public class BoolPort : AnyPort
    {
        public static implicit operator BoolPort(bool data) => new BoolPort { Data = data };
        public static explicit operator bool(BoolPort data) => data.AsData<bool>();

        public static explicit operator string(BoolPort data) => data.AsData<int>().ToString();
        public static explicit operator StringPort(BoolPort data) => (string)data;
    }
    public class Vector3Port : AnyPort { }
    public class QuaternionPort : AnyPort { }
    public class ObjectPort : AnyPort { }
    public class AIPort : AnyPort { }
    public class WelcomeMatPort : AnyPort { }
    public class TriggerHandlePort : AnyPort { }
    public class StudioObjectPort : AnyPort { }
    public class AnalyticsPayloadPort : AnyPort { }
    public class PlayerPort : AnyPort
    {
        public static PlayerPort Local = new PlayerPort() { Port = null, Data = 1 };
    }
    public class RecRoomObjectPort : AnyPort { }
    public class CombatantPort : AnyPort { }
    public class PatrolPointPort : AnyPort { }
    public class AudioPort : AnyPort { }
    public class AudioPlayerPort : AnyPort { }
    public class ConsumablePort : AnyPort { }
    public class RoomKeyPort : AnyPort { }
    public class BackgroundObjectsPort : AnyPort { }
    public class BeaconPort : AnyPort { }
    public class ButtonPort : AnyPort { }
    public class TextScreenPort : AnyPort { }
    public class CollisionDataPort : AnyPort { }
    public class CostumePort : AnyPort { }
    public class DestinationRoomPort : AnyPort { }
    public class DiePort : AnyPort { }
    public class PlayerWorldUIPort : AnyPort { }
    public class RoomDoorPort : AnyPort { }
    public class EmitterPort : AnyPort { }
    public class ExplosionEmitterPort : AnyPort { }
    public class FogPort : AnyPort { }
    public class HUDElementPort : AnyPort { }
    public class RewardPort : AnyPort { }
    public class GroundVehiclePort : AnyPort { }
    public class GunHandlePort : AnyPort { }
    public class HolotarProjectorPort : AnyPort { }
    public class InteractionVolumePort : AnyPort { }
    public class InvisibleCollisionPort : AnyPort { }
    public class LaserPointerPort : AnyPort { }
    public class PistonPort : AnyPort { }
    public class PlayerOutfitSlotPort : AnyPort { }
    public class ProjectileLauncherPort : AnyPort { }
    public class RemoteVideoPlayerPort : AnyPort { }
    public class PlayerSpawnPointV2Port : AnyPort { }
    public class SkydomePort : AnyPort { }
    public class SunPort : AnyPort { }
    public class SunDirectionPort : AnyPort { }
    public class RotatorPort : AnyPort { }
    public class SeatPort : AnyPort { }
    public class SFXPort : AnyPort { }
    public class TextPort : AnyPort
    {
        public static implicit operator TextPort(RecRoomObjectPort data) => new TextPort() { Port = ChipBuilder.FromRecRoomObject(data).Port };
    }
    public class ToggleButtonPort : AnyPort { }
    public class MotionTrailPort : AnyPort { }
    public class TriggerVolumePort : AnyPort { }
    public class VectorComponentPort : AnyPort { }
    public class RoomCurrencyPort : AnyPort { }
    public class HUDConstantPort : AnyPort { }
    public class SteeringEnginePort : AnyPort { }
    public class GiftDropShopItemPort : AnyPort { }
    public class ObjectiveMarkerPort : AnyPort { }
    public class MeleeZonePort : AnyPort { }
    public class SwingHandlePort : AnyPort { }
    public class RoomLevelHUDPort : AnyPort { }
    public class TouchpadPort : AnyPort { }
    public class AnimationControllerPort : AnyPort { }
}
