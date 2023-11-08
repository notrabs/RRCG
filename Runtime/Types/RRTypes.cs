using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RRCGSource
{
    public abstract class AnyObject { }
    public class RRTuple<T0, T1> : AnyObject { }

    public class AI : AnyObject { }
    public class WelcomeMat : AnyObject { }
    public class TriggerHandle : AnyObject
    {
        public static implicit operator TriggerHandle(RecRoomObject data) => null;
    }
    public class StudioObject : AnyObject
    {
        public static implicit operator StudioObject(RecRoomObject data) => null;
    }
    public class AnalyticsPayload : AnyObject { }
    public class Player : AnyObject
    {
        public static Player Local = new Player();
        public static Player Invalid = null;
    }
    public class RecRoomObject : AnyObject
    {
        public static RecRoomObject Invalid = null;
    }
    public class Combatant : AnyObject { }
    public class PatrolPoint : AnyObject { }
    public class Audio : AnyObject
    {
        public static Audio SFX_Click { get; }
        public static Audio SFX_Firework { get; }
        public static Audio SFX_UIXP02 { get; }
        public static Audio SFX_CrowdCheer { get; }
        public static Audio SFX_CrowdAww { get; }
        public static Audio SFX_TriggerMisfire { get; }
        public static Audio SFX_UIScore01 { get; }
        public static Audio SFX_UIScore04 { get; }
    }
    public class AudioPlayer : AnyObject { }
    public class Consumable : AnyObject { }
    public class RoomKey : AnyObject { }
    public class BackgroundObjects : AnyObject { }
    public class Beacon : AnyObject { }
    public class Button : AnyObject { }
    public class TextScreen : AnyObject { }
    public class CollisionData : AnyObject { }
    public class Costume : AnyObject { }
    public class DestinationRoom : AnyObject { }
    public class Die : AnyObject { }
    public class PlayerWorldUI : AnyObject
    {
        public struct WorldUIBar
        {
            bool Enabled;
            int Value;
            int MaxValue;
            bool Animated;
        }

        public PlayerWorldUI(string name, WorldUIBar primary, WorldUIBar secondary, string text, bool synced, bool enableWhileJoining) { }
    }
    public class RoomDoor : AnyObject { }
    public class Emitter : AnyObject { }
    public class ExplosionEmitter : AnyObject { }
    public class Fog : AnyObject { }
    public class HUDElement : AnyObject { }
    public class Reward : AnyObject { }
    public class GroundVehicle : AnyObject { }
    public class GunHandle : AnyObject { }
    public class HolotarProjector : AnyObject { }
    public class InteractionVolume : AnyObject { }
    public class InvisibleCollision : AnyObject { }
    public class LaserPointer : AnyObject { }
    public class Piston : AnyObject { }
    public class PlayerOutfitSlot : AnyObject { }
    public class ProjectileLauncher : AnyObject { }
    public class RemoteVideoPlayer : AnyObject { }
    public class PlayerSpawnPointV2 : AnyObject { }
    public class Skydome : AnyObject { }
    public class Sun : AnyObject { }
    public class SunDirection : AnyObject { }
    public class Rotator : AnyObject { }
    public class Seat : AnyObject
    {
        public static implicit operator Seat(RecRoomObject data) => null;
    }
    public class SFX : AnyObject { }
    public class Text : AnyObject
    {
        public static implicit operator Text(RecRoomObject data) => null;
    }
    public class ToggleButton : AnyObject { }
    public class MotionTrail : AnyObject { }
    public class TriggerVolume : AnyObject { }
    public class VectorComponent : AnyObject { }
    public class AnimationController : AnyObject { }
    public class RoomCurrency : AnyObject
    {
        public RoomCurrency(string name) { }
    }
    public class HUDConstant : AnyObject { }
    public class SteeringEngine : AnyObject { }
    public class GiftDropShopItem : AnyObject { }
    public class ObjectiveMarker : AnyObject { }
    public class MeleeZone : AnyObject { }
    public class SwingHandle : AnyObject { }
    public class RoomLevelHUD : AnyObject { }
    public class Touchpad : AnyObject { }
    public class InventoryItem : AnyObject { }
    public class State : AnyObject { }
    public class Grabber : AnyObject { }
    public class EquipmentSlot : AnyObject { }
    public class DialogueUI : AnyObject { }
    public class CollisionDetectionVolume : AnyObject { }
}
