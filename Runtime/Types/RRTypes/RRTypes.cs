using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCGSource
{
    public abstract class AnyObject
    {
        public bool IsValid { get; }
    }
    public class RRTuple<T0, T1> : AnyObject { }

    public class AI : AIGen { }
    public class WelcomeMat : WelcomeMatGen { }
    public class TriggerHandle : TriggerHandleGen
    {
        public static implicit operator TriggerHandle(RecRoomObject data) => null;
    }
    public class StudioObject : StudioObjectGen
    {
        public static implicit operator StudioObject(RecRoomObject data) => null;
    }
    public class AnalyticsPayload : AnalyticsPayloadGen { }
    public class Player : PlayerGen
    {
        public static Player Local = new Player();
        public static Player Invalid = null;
    }
    public class RecRoomObject : RecRoomObjectGen
    {
        public static implicit operator RecRoomObject(TriggerHandle data) => null;
        public static implicit operator RecRoomObject(StudioObject data) => null;
        public static implicit operator RecRoomObject(Seat data) => null;
        public static implicit operator RecRoomObject(Text data) => null;

        public static RecRoomObject Invalid = null;
    }
    public class Combatant : CombatantGen { }
    public class PatrolPoint : PatrolPointGen { }
    public class AudioPlayer : AudioPlayerGen { }
    public class Consumable : ConsumableGen { }
    public class RoomKey : RoomKeyGen { }
    public class BackgroundObjects : BackgroundObjectsGen { }
    public class Beacon : BeaconGen { }
    public class Button : ButtonGen { }
    public class TextScreen : TextScreenGen { }
    public class CollisionData : CollisionDataGen
    {
        public float Distance => default;
        public Vector3 Normal => default;
        public RecRoomObject Object => default;
        public Player Player => default;
        public Vector3 Position => default;
    }
    public class Costume : CostumeGen { }
    public class DestinationRoom : DestinationRoomGen { }
    public class Die : DieGen { }
    public class PlayerWorldUI : PlayerWorldUIGen { }
    public class RoomDoor : RoomDoorGen { }
    public class Emitter : EmitterGen { }
    public class ExplosionEmitter : ExplosionEmitterGen { }
    public class Fog : FogGen { }
    public class HUDElement : HUDElementGen { }
    public class Reward : RewardGen { }
    public class GroundVehicle : GroundVehicleGen { }
    public class GunHandle : GunHandleGen { }
    public class HolotarProjector : HolotarProjectorGen { }
    public class InteractionVolume : InteractionVolumeGen { }
    public class InvisibleCollision : InvisibleCollisionGen { }
    public class LaserPointer : LaserPointerGen { }
    public class Piston : PistonGen { }
    public class PlayerOutfitSlot : PlayerOutfitSlotGen { }
    public class ProjectileLauncher : ProjectileLauncherGen { }
    public class RemoteVideoPlayer : RemoteVideoPlayerGen { }
    public class PlayerSpawnPointV2 : PlayerSpawnPointV2Gen { }
    public class Skydome : SkydomeGen { }
    public class Sun : SunGen { }
    public class SunDirection : SunDirectionGen { }
    public class Rotator : RotatorGen { }
    public class Seat : SeatGen
    {
        public static implicit operator Seat(RecRoomObject data) => null;
    }
    public class SFX : SFXGen { }
    public class Text : TextGen
    {
        public static implicit operator Text(RecRoomObject data) => null;
    }
    public class ToggleButton : ToggleButtonGen { }
    public class MotionTrail : MotionTrailGen { }
    public class TriggerVolume : TriggerVolumeGen { }
    public class VectorComponent : VectorComponentGen { }
    public class AnimationController : AnimationControllerGen { }
    public class RoomCurrency : RoomCurrencyGen { }
    public class HUDConstant : HUDConstantGen { }
    public class SteeringEngine : SteeringEngineGen { }
    public class GiftDropShopItem : GiftDropShopItemGen { }
    public class ObjectiveMarker : ObjectiveMarkerGen { }
    public class MeleeZone : MeleeZoneGen { }
    public class SwingHandle : SwingHandleGen { }
    public class RoomLevelHUD : RoomLevelHUDGen { }
    public class Touchpad : TouchpadGen { }
    public class InventoryItem : InventoryItemGen { }
    public class State : StateGen { }
    public class Grabber : GrabberGen { }
    public class EquipmentSlot : EquipmentSlotGen { }
    public class DialogueUI : DialogueUIGen { }
    public class CollisionDetectionVolume : CollisionDetectionVolumeGen { }
    public class RoomOffer : RoomOfferGen { }
}
