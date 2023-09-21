using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RRCGSource
{
    public class AI { }
    public class WelcomeMat { }
    public class TriggerHandle { }
    public class StudioObject { }
    public class AnalyticsPayload { }
    public class Player
    {
        public static Player Local = new Player();
    }
    public class RecRoomObject { }
    public class Combatant { }
    public class PatrolPoint { }
    public class Audio
    {
        public static Audio SFX_Click { get; } 
        public static Audio SFX_Firework { get; }
        public static Audio SFX_UIXP02 { get; }
        public static Audio SFX_CrowdCheer { get; }
        public static Audio SFX_CrowdAww { get; }
    }
    public class AudioPlayer { }
    public class Consumable { }
    public class RoomKey { }
    public class BackgroundObjects { }
    public class Beacon { }
    public class Button { }
    public class TextScreen { }
    public class CollisionData { }
    public class Costume { }
    public class DestinationRoom { }
    public class Die { }
    public class PlayerWorldUI
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
    public class RoomDoor { }
    public class Emitter { }
    public class ExplosionEmitter { }
    public class Fog { }
    public class HUDElement { }
    public class Reward { }
    public class GroundVehicle { }
    public class GunHandle { }
    public class HolotarProjector { }
    public class InteractionVolume { }
    public class InvisibleCollision { }
    public class LaserPointer { }
    public class Piston { }
    public class PlayerOutfitSlot { }
    public class ProjectileLauncher { }
    public class RemoteVideoPlayer { }
    public class PlayerSpawnPointV2 { }
    public class Skydome { }
    public class Sun { }
    public class SunDirection { }
    public class Rotator { }
    public class Seat { }
    public class SFX { }
    public class Text
    {
        public static implicit operator Text(RecRoomObject data) => null;
    }
    public class ToggleButton { }
    public class MotionTrail { }
    public class TriggerVolume { }
    public class VectorComponent { }
    public class AnimationController { }
    public class RoomCurrency { }
    public class HUDConstant { }
    public class SteeringEngine { }
    public class GiftDropShopItem { }
    public class ObjectiveMarker { }
    public class MeleeZone { }
    public class SwingHandle { }
    public class RoomLevelHUD { }
    public class Touchpad { }

}