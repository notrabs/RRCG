using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG
{
    public static class TypeNameMapping
    {
        // TODO: Is there another way?
        //
        //       Now that we have access to the semantic model,
        //       we can be a bit more explicit in our type rewriting,
        //       but at the moment I can't think of any better way
        //       to make use of this (that works with the predefined types)
        //       other than a lookup.

        public static IReadOnlyDictionary<string, string> SourceToBuildRealmTypeNames = new Dictionary<string, string>()
        {
            // Source-realm name                Build-realm name
            { "System.Boolean",                 "RRCGBuild.BoolPort" },
            { "System.String",                  "RRCGBuild.StringPort" },
            { "System.Int32",                   "RRCGBuild.IntPort" },
            { "System.Single",                  "RRCGBuild.FloatPort" },
            { "RRCGSource.AI",                  "RRCGBuild.AIPort" },
            { "RRCGSource.Vector3",             "RRCGBuild.Vector3Port" },
            { "RRCGSource.Quaternion",          "RRCGBuild.QuaternionPort" },
            { "RRCGSource.TriggerHandle",       "RRCGBuild.TriggerHandlePort" },
            { "RRCGSource.WelcomeMat",          "RRCGBuild.WelcomeMatPort" },
            { "RRCGSource.StudioObject",        "RRCGBuild.StudioObjectPort" },
            { "RRCGSource.AnalyticsPayload",    "RRCGBuild.AnalyticsPayloadPort" },
            { "RRCGSource.Player",              "RRCGBuild.PlayerPort" },
            { "RRCGSource.RecRoomObject",       "RRCGBuild.RecRoomObjectPort" },
            { "RRCGSource.Combatant",           "RRCGBuild.CombatantPort" },
            { "RRCGSource.PatrolPoint",         "RRCGBuild.PatrolPointPort" },
            { "RRCGSource.Audio",               "RRCGBuild.AudioPort" },
            { "RRCGSource.AudioPlayer",         "RRCGBuild.AudioPlayerPort" },
            { "RRCGSource.Consumable",          "RRCGBuild.ConsumablePort" },
            { "RRCGSource.RoomKey",             "RRCGBuild.RoomKeyPort" },
            { "RRCGSource.BackgroundObjects",   "RRCGBuild.BackgroundObjectsPort" },
            { "RRCGSource.Color",               "RRCGBuild.ColorPort" },
            { "RRCGSource.Beacon",              "RRCGBuild.BeaconPort" },
            { "RRCGSource.Button",              "RRCGBuild.ButtonPort" },
            { "RRCGSource.TextScreen",          "RRCGBuild.TextScreenPort" },
            { "RRCGSource.CollisionData",       "RRCGBuild.CollisionDataPort" },
            { "RRCGSource.Costume",             "RRCGBuild.CostumePort" },
            { "RRCGSource.DestinationRoom",     "RRCGBuild.DestinationRoomPort" },
            { "RRCGSource.Die",                 "RRCGBuild.DiePort" },
            { "RRCGSource.RoomDoor",            "RRCGBuild.RoomDoorPort" },
            { "RRCGSource.Emitter",             "RRCGBuild.EmitterPort" },
            { "RRCGSource.ExplosionEmitter",    "RRCGBuild.ExplosionEmitterPort" },
            { "RRCGSource.Fog",                 "RRCGBuild.FogPort" },
            { "RRCGSource.HUDElement",          "RRCGBuild.HUDElementPort" },
            { "RRCGSource.Reward",              "RRCGBuild.RewardPort" },
            { "RRCGSource.GroundVehicle",       "RRCGBuild.GroundVehiclePort" },
            { "RRCGSource.GunHandle",           "RRCGBuild.GunHandlePort" },
            { "RRCGSource.HolotarProjector",    "RRCGBuild.HolotarProjectorPort" },
            { "RRCGSource.InteractionVolume",   "RRCGBuild.InteractionVolumePort" },
            { "RRCGSource.InvisibleCollision",  "RRCGBuild.InvisibleCollisionPort" },
            { "RRCGSource.LaserPointer",        "RRCGBuild.LaserPointerPort" },
            { "RRCGSource.Light",               "RRCGBuild.LightPort" },
            { "RRCGSource.Piston",              "RRCGBuild.PistonPort" },
            { "RRCGSource.PlayerOutfitSlot",    "RRCGBuild.PlayerOutfitSlotPort" },
            { "RRCGSource.PlayerWorldUI",       "RRCGBuild.PlayerWorldUIPort" },
            { "RRCGSource.ProjectileLauncher",  "RRCGBuild.ProjectileLauncherPort" },
            { "RRCGSource.RemoteVideoPlayer",   "RRCGBuild.RemoteVideoPlayerPort" },
            { "RRCGSource.PlayerSpawnPointV2",  "RRCGBuild.PlayerSpawnPointV2Port" },
            { "RRCGSource.Skydome",             "RRCGBuild.SkydomePort" },
            { "RRCGSource.Sun",                 "RRCGBuild.SunPort" },
            { "RRCGSource.SunDirection",        "RRCGBuild.SunDirectionPort" },
            { "RRCGSource.Rotator",             "RRCGBuild.RotatorPort" },
            { "RRCGSource.Seat",                "RRCGBuild.SeatPort" },
            { "RRCGSource.SFX",                 "RRCGBuild.SFXPort" },
            { "RRCGSource.Text",                "RRCGBuild.TextPort" },
            { "RRCGSource.ToggleButton",        "RRCGBuild.ToggleButtonPort" },
            { "RRCGSource.MotionTrail",         "RRCGBuild.MotionTrailPort" },
            { "RRCGSource.TriggerVolume",       "RRCGBuild.TriggerVolumePort" },
            { "RRCGSource.VectorComponent",     "RRCGBuild.VectorComponentPort" },
            { "RRCGSource.RoomCurrency",        "RRCGBuild.RoomCurrencyPort" },
            { "RRCGSource.HUDConstant",         "RRCGBuild.HUDConstantPort" },
            { "RRCGSource.SteeringEngine",      "RRCGBuild.SteeringEnginePort" },
            { "RRCGSource.GiftDropShopItem",    "RRCGBuild.GiftDropShopItemPort" },
            { "RRCGSource.ObjectiveMarker",     "RRCGBuild.ObjectiveMarkerPort" },
            { "RRCGSource.MeleeZone",           "RRCGBuild.MeleeZonePort" },
            { "RRCGSource.SwingHandle",         "RRCGBuild.SwingHandlePort" },
            { "RRCGSource.RoomLevelHUD",        "RRCGBuild.RoomLevelHUDPort" },
            { "RRCGSource.Touchpad",            "RRCGBuild.TouchpadPort" },
            { "RRCGSource.AnimationController", "RRCGBuild.AnimationControllerPort" },
        };
    }
}
