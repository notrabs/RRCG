using RRCGGenerated;

namespace RRCGSource
{
    public class RecRoomObject : RecRoomObjectGen
    {
        public static implicit operator RecRoomObject(TriggerHandle data) => default;
        public static implicit operator RecRoomObject(TriggerVolume data) => default;
        public static implicit operator RecRoomObject(StudioObject data) => default;
        public static implicit operator RecRoomObject(Seat data) => default;
        public static implicit operator RecRoomObject(Text data) => default;
        public static implicit operator RecRoomObject(Light data) => default;
        public static implicit operator RecRoomObject(InteractionVolume data) => default;

        public static RecRoomObject Invalid = null;
    }

    public class StudioObject: StudioObjectGen
    {
        public static implicit operator StudioObject(RecRoomObject data) => default;
    }

    //
    // Gadgets
    //

    public class WelcomeMat: WelcomeMatGen
    {
        public static implicit operator WelcomeMat(RecRoomObject data) => default;
    }
    public class TriggerHandle: TriggerHandleGen
    {
        public static implicit operator TriggerHandle(RecRoomObject data) => default;
    }
    public class AudioPlayer: AudioPlayerGen
    {
        public static implicit operator AudioPlayer(RecRoomObject data) => default;
    }
    public class Beacon: BeaconGen
    {
        public static implicit operator Beacon(RecRoomObject data) => default;
    }
    public class Button: ButtonGen
    {
        public static implicit operator Button(RecRoomObject data) => default;
    }
    public class TextScreen: TextScreenGen
    {
        public static implicit operator TextScreen(RecRoomObject data) => default;
    }
    public class Costume: CostumeGen
    {
        public static implicit operator Costume(RecRoomObject data) => default;
    }
    public class Die: DieGen
    {
        public static implicit operator Die(RecRoomObject data) => default;
    }
    public class RoomDoor: RoomDoorGen
    {
        public static implicit operator RoomDoor(RecRoomObject data) => default;
    }
    public class Emitter: EmitterGen
    {
        public static implicit operator Emitter(RecRoomObject data) => default;
    }
    public class ExplosionEmitter: ExplosionEmitterGen
    {
        public static implicit operator ExplosionEmitter(RecRoomObject data) => default;
    }
    public class GroundVehicle: GroundVehicleGen
    {
        public static implicit operator GroundVehicle(RecRoomObject data) => default;
    }
    public class GunHandle: GunHandleGen
    {
        public static implicit operator GunHandle(RecRoomObject data) => default;
    }
    public class HolotarProjector: HolotarProjectorGen
    {
        public static implicit operator HolotarProjector(RecRoomObject data) => default;
    }
    public class InteractionVolume: InteractionVolumeGen
    {
        public static implicit operator InteractionVolume(RecRoomObject data) => default;
    }
    public class InvisibleCollision: InvisibleCollisionGen
    {
        public static implicit operator InvisibleCollision(RecRoomObject data) => default;
    }
    public class LaserPointer: LaserPointerGen
    {
        public static implicit operator LaserPointer(RecRoomObject data) => default;
    }
    public class Piston: PistonGen
    {
        public static implicit operator Piston(RecRoomObject data) => default;
    }
    public class ProjectileLauncher: ProjectileLauncherGen
    {
        public static implicit operator ProjectileLauncher(RecRoomObject data) => default;
    }
    public class RemoteVideoPlayer: RemoteVideoPlayerGen
    {
        public static implicit operator RemoteVideoPlayer(RecRoomObject data) => default;
    }
    public class PlayerSpawnPointV2: PlayerSpawnPointV2Gen
    {
        public static implicit operator PlayerSpawnPointV2(RecRoomObject data) => default;
    }
    public class Rotator: RotatorGen
    {
        public static implicit operator Rotator(RecRoomObject data) => default;
    }
    public class Seat: SeatGen
    {
        public static implicit operator Seat(RecRoomObject data) => default;
    }
    public class SFX: SFXGen
    {
        public static implicit operator SFX(RecRoomObject data) => default;
    }
    public class Text: TextGen
    {
        public static implicit operator Text(RecRoomObject data) => default;
    }
    public class ToggleButton: ToggleButtonGen
    {
        public static implicit operator ToggleButton(RecRoomObject data) => default;
    }
    public class MotionTrail: MotionTrailGen
    {
        public static implicit operator MotionTrail(RecRoomObject data) => default;
    }
    public class TriggerVolume: TriggerVolumeGen
    {
        public static implicit operator TriggerVolume(RecRoomObject data) => default;
    }
    public class VectorComponent: VectorComponentGen
    {
        public static implicit operator VectorComponent(RecRoomObject data) => default;
    }
    public class HUDConstant: HUDConstantGen
    {
        public static implicit operator HUDConstant(RecRoomObject data) => default;
    }
    public class SteeringEngine: SteeringEngineGen
    {
        public static implicit operator SteeringEngine(RecRoomObject data) => default;
    }
    public class GiftDropShopItem: GiftDropShopItemGen
    {
        public static implicit operator GiftDropShopItem(RecRoomObject data) => default;
    }
    public class ObjectiveMarker: ObjectiveMarkerGen
    {
        public static implicit operator ObjectiveMarker(RecRoomObject data) => default;
    }
    public class MeleeZone: MeleeZoneGen
    {
        public static implicit operator MeleeZone(RecRoomObject data) => default;
    }
    public class SwingHandle: SwingHandleGen
    {
        public static implicit operator SwingHandle(RecRoomObject data) => default;
    }
    public class RoomLevelHUD: RoomLevelHUDGen
    {
        public static implicit operator RoomLevelHUD(RecRoomObject data) => default;
    }
    public class Touchpad: TouchpadGen
    {
        public static implicit operator Touchpad(RecRoomObject data) => default;
    }
    public class AnimationController: AnimationControllerGen
    {
        public static implicit operator AnimationController(RecRoomObject data) => default;
    }
    public class Light: AnimationControllerGen
    {
        public static implicit operator Light(RecRoomObject data) => default;
    }
}
