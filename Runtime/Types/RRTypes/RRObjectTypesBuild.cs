using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCGBuild
{
    public class RecRoomObjectPort : RecRoomObjectPortGen
    {
        public static implicit operator RecRoomObjectPort(TriggerHandlePort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(TriggerVolumePort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(StudioObjectPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(SeatPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(TextPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(LightPort data) => new RecRoomObjectPort() { Port = data.Port };
        public static implicit operator RecRoomObjectPort(InteractionVolumePort data) => new RecRoomObjectPort() { Port = data.Port };

        public static RecRoomObjectPort Invalid
        {
            get => CircuitBuilder.Singleton("RRCG_Invalid_RRO", () => new NamedVariable<RecRoomObjectPort>("RRCG_Invalid_RRO").Value);
        }
    }

    public class StudioObjectPort : StudioObjectPortGen
    {
        public static implicit operator StudioObjectPort(RecRoomObjectPort data) => new StudioObjectPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }

    //
    // Gadgets
    //

    public class WelcomeMatPort : WelcomeMatPortGen
    {
        public static implicit operator WelcomeMatPort(RecRoomObjectPort data) => new WelcomeMatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerHandlePort : TriggerHandlePortGen
    {
        public static implicit operator TriggerHandlePort(RecRoomObjectPort data) => new TriggerHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AudioPlayerPort : AudioPlayerPortGen
    {
        public static implicit operator AudioPlayerPort(RecRoomObjectPort data) => new AudioPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class BeaconPort : BeaconPortGen
    {
        public static implicit operator BeaconPort(RecRoomObjectPort data) => new BeaconPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ButtonPort : ButtonPortGen
    {
        public static implicit operator ButtonPort(RecRoomObjectPort data) => new ButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextScreenPort : TextScreenPortGen
    {
        public static implicit operator TextScreenPort(RecRoomObjectPort data) => new TextScreenPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class CostumePort : CostumePortGen
    {
        public static implicit operator CostumePort(RecRoomObjectPort data) => new CostumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class DiePort : DiePortGen
    {
        public static implicit operator DiePort(RecRoomObjectPort data) => new DiePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomDoorPort : RoomDoorPortGen
    {
        public static implicit operator RoomDoorPort(RecRoomObjectPort data) => new RoomDoorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class EmitterPort : EmitterPortGen
    {
        public static implicit operator EmitterPort(RecRoomObjectPort data) => new EmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ExplosionEmitterPort : ExplosionEmitterPortGen
    {
        public static implicit operator ExplosionEmitterPort(RecRoomObjectPort data) => new ExplosionEmitterPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GroundVehiclePort : GroundVehiclePortGen
    {
        public static implicit operator GroundVehiclePort(RecRoomObjectPort data) => new GroundVehiclePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HandlePort : HandlePortGen
    {
        public static implicit operator HandlePort(RecRoomObjectPort data) => new HandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
        public static implicit operator HandlePort(GunHandlePort data) => new HandlePort() { Data = data.Data, Port = data.Port };
        public static implicit operator HandlePort(TriggerHandlePort data) => new HandlePort() { Data = data.Data, Port = data.Port };
    }
    public class GunHandlePort : GunHandlePortGen
    {
        public static implicit operator GunHandlePort(RecRoomObjectPort data) => new GunHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HolotarProjectorPort : HolotarProjectorPortGen
    {
        public static implicit operator HolotarProjectorPort(RecRoomObjectPort data) => new HolotarProjectorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InteractionVolumePort : InteractionVolumePortGen
    {
        public static implicit operator InteractionVolumePort(RecRoomObjectPort data) => new InteractionVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class InvisibleCollisionPort : InvisibleCollisionPortGen
    {
        public static implicit operator InvisibleCollisionPort(RecRoomObjectPort data) => new InvisibleCollisionPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LaserPointerPort : LaserPointerPortGen
    {
        public static implicit operator LaserPointerPort(RecRoomObjectPort data) => new LaserPointerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PistonPort : PistonPortGen
    {
        public static implicit operator PistonPort(RecRoomObjectPort data) => new PistonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ProjectileLauncherPort : ProjectileLauncherPortGen
    {
        public static implicit operator ProjectileLauncherPort(RecRoomObjectPort data) => new ProjectileLauncherPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RemoteVideoPlayerPort : RemoteVideoPlayerPortGen
    {
        public static implicit operator RemoteVideoPlayerPort(RecRoomObjectPort data) => new RemoteVideoPlayerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class PlayerSpawnPointV2Port : PlayerSpawnPointV2PortGen
    {
        public static implicit operator PlayerSpawnPointV2Port(RecRoomObjectPort data) => new PlayerSpawnPointV2Port() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RotatorPort : RotatorPortGen
    {
        public static implicit operator RotatorPort(RecRoomObjectPort data) => new RotatorPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SeatPort : SeatPortGen
    {
        public static implicit operator SeatPort(RecRoomObjectPort data) => new SeatPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SFXPort : SFXPortGen
    {
        public static implicit operator SFXPort(RecRoomObjectPort data) => new SFXPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TextPort : TextPortGen
    {
        public static implicit operator TextPort(RecRoomObjectPort data) => new TextPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ToggleButtonPort : ToggleButtonPortGen
    {
        public static implicit operator ToggleButtonPort(RecRoomObjectPort data) => new ToggleButtonPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MotionTrailPort : MotionTrailPortGen
    {
        public static implicit operator MotionTrailPort(RecRoomObjectPort data) => new MotionTrailPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TriggerVolumePort : TriggerVolumePortGen
    {
        public static implicit operator TriggerVolumePort(RecRoomObjectPort data) => new TriggerVolumePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class VectorComponentPort : VectorComponentPortGen
    {
        public static implicit operator VectorComponentPort(RecRoomObjectPort data) => new VectorComponentPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class HUDConstantPort : HUDConstantPortGen
    {
        public static implicit operator HUDConstantPort(RecRoomObjectPort data) => new HUDConstantPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SteeringEnginePort : SteeringEnginePortGen
    {
        public static implicit operator SteeringEnginePort(RecRoomObjectPort data) => new SteeringEnginePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GiftDropShopItemPort : GiftDropShopItemPortGen
    {
        public static implicit operator GiftDropShopItemPort(RecRoomObjectPort data) => new GiftDropShopItemPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class ObjectiveMarkerPort : ObjectiveMarkerPortGen
    {
        public static implicit operator ObjectiveMarkerPort(RecRoomObjectPort data) => new ObjectiveMarkerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class MeleeZonePort : MeleeZonePortGen
    {
        public static implicit operator MeleeZonePort(RecRoomObjectPort data) => new MeleeZonePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class SwingHandlePort : SwingHandlePortGen
    {
        public static implicit operator SwingHandlePort(RecRoomObjectPort data) => new SwingHandlePort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class RoomLevelHUDPort : RoomLevelHUDPortGen
    {
        public static implicit operator RoomLevelHUDPort(RecRoomObjectPort data) => new RoomLevelHUDPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class TouchpadPort : TouchpadPortGen
    {
        public static implicit operator TouchpadPort(RecRoomObjectPort data) => new TouchpadPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class AnimationControllerPort : AnimationControllerPortGen
    {
        public static implicit operator AnimationControllerPort(RecRoomObjectPort data) => new AnimationControllerPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class LightPort : LightPortGen
    {
        public static implicit operator LightPort(RecRoomObjectPort data) => new LightPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
    public class GrabberPort : GrabberPortGen
    {
        public static implicit operator GrabberPort(RecRoomObjectPort data) => new GrabberPort() { Port = ChipBuilder.FromRecRoomObject<AnyPort>(data).Port };
    }
}
