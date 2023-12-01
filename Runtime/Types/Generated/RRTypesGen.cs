using System.Collections.Generic;
using UnityEngine;
using RRCGSource;
using RRCG;

namespace RRCGGenerated
{
    public class AIGen : AnyObject
    {
        public Vector3 CombatantGetGroundPosition
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public (int Health, int Shield, int MaxHealth) CombatantGetHealth
        {
            /// <summary>
            /// Outputs the Health property of the input combatant.
            /// </summary>
            get => default;
        }

        public bool CombatantGetIsAlive
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) CombatantGetVelocity
        {
            /// <summary>
            /// Outputs the input combatant's current velocity and speed.
            /// </summary>
            get => default;
        }

        public AI CombatantSetHealth
        {
            /// <summary>
            /// Sets the Health property of an input combatant.
            /// </summary>
            set
            {
            }
        }

        public AI CombatantSetMaxHealth
        {
            /// <summary>
            /// Sets the Max Health property of the input combatant.
            /// </summary>
            set
            {
            }
        }

        public (string VisionType, float VisionRange, float VisionConeAngle, float HearingRange) LineOfSightParameters
        {
            /// <summary>
            /// Outputs the current line of sight parameters from the input AI.
            /// </summary>
            get => default;
        }

        public AI PathingSpeed
        {
            /// <summary>
            /// Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
            /// </summary>
            set
            {
            }
        }

        public AI PatrolPoint
        {
            /// <summary>
            /// Set an AIs Path Point.
            /// </summary>
            set
            {
            }
        }

        public Vector3 Position
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 PositionDeprecated
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public Combatant Target
        {
            /// <summary>
            /// Outputs the current combat target of an inputted AI.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the input AI’s current target.
            /// </summary>
            set
            {
            }
        }

        public Combatant ToCombatant
        {
            /// <summary>
            /// Covert a player or an AI value into a Combatant value.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(AI Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(Combatant Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(PatrolPoint Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool HasLineOfSightToTarget(Vector3 Target)
        {
            return default;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(AI LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(Combatant LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(RecRoomObject LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(PatrolPoint LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(Player LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void LookAt(Vector3 LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(AI Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(Combatant Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(RecRoomObject Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(PatrolPoint Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(Player Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void PathTo(Vector3 Target)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void Rotate(float Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void Rotate(int Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void Rotate(Vector3 Rotation)
        {
            return;
        }

        /// <summary>
        /// Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
        /// </summary>
        public static void SetLineOfSightParameters(string VisionType, float VisionRange, float VisionConeAngle, float HearingRange, bool RequireLoSfortargeting)
        {
            return;
        }

        /// <summary>
        /// RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
        /// </summary>
        public static void StartCombatBehavior()
        {
            return;
        }

        /// <summary>
        /// Tells the input AI to stop its C# defined combat behavior.
        /// </summary>
        public static void StopCombatBehavior()
        {
            return;
        }

        /// <summary>
        /// Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
        /// </summary>
        public static void StopLooking()
        {
            return;
        }

        internal static AI Variable()
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 B)
        {
            return default;
        }
    }

    public class AnalyticsPayloadGen : AnyObject
    {
    }

    public class AnimationControllerGen : AnyObject
    {
        public int Frame
        {
            /// <summary>
            /// Returns the current frame of the given animation controller component.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Animation Controller's animation to a specific frame number.
            /// </summary>
            set
            {
            }
        }

        public bool IsPlaying
        {
            /// <summary>
            /// Returns whether or not the Animation Controller is currently playing.
            /// </summary>
            get => default;
        }

        public float Speed
        {
            /// <summary>
            /// Returns the normalized speed of the given Animation Controller.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Animation Controller's play speed. Default value is 1. Negative values play the animation in reverse.
            /// </summary>
            set
            {
            }
        }

        public float TimeStamp
        {
            /// <summary>
            /// Returns the current time stamp of the given animation controller. The value is not impacted by the animation speed.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the time stamp of the given animation controller to the given time in seconds. The time stamp is not impacted by the animation speed.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Pauses the Animation Controller. The Animation Controller resumes at the same moment next time play is activated.
        /// </summary>
        public static void Pause()
        {
            return;
        }

        /// <summary>
        /// Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller's configuration menu.
        /// </summary>
        public static void Play()
        {
            return;
        }

        /// <summary>
        /// Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
        /// </summary>
        public static void Stop()
        {
            return;
        }
    }

    public class AudioGen : AnyObject
    {
        public float Length
        {
            /// <summary>
            /// Returns the length in seconds of the given audio reference.
            /// </summary>
            get => default;
        }

        public static void PlayAudioAtPosition(Vector3 Position, float Volume, float PlaybackSpeed, bool Is2D, PlayAudioAtPositionData config)
        {
            return;
        }
    }

    public class AudioPlayerGen : AnyObject
    {
        public Audio Audio
        {
            /// <summary>
            /// Returns the most recent audio reference that the target Audio Player has started playing.
            /// </summary>
            get => default;
        }

        public float MaxRolloffDistance
        {
            /// <summary>
            /// Returns the furthest distance from the target Audio Player that the audio can be heard from.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the maximum distance that audio from the target Audio Player can be heard from.
            /// </summary>
            set
            {
            }
        }

        public bool Playing
        {
            /// <summary>
            /// Returns True if the target Audio Player is playing.
            /// </summary>
            get => default;
        }

        public float Speed
        {
            /// <summary>
            /// Returns the speed multiplier of the target Audio Player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the speed multiplier that the target Audio Player will play at.
            /// </summary>
            set
            {
            }
        }

        public float TimeStamp
        {
            /// <summary>
            /// Returns the current time stamp of the target Audio Player in seconds.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the time stamp of the target Audio Player in seconds.
            /// </summary>
            set
            {
            }
        }

        public float Volume
        {
            /// <summary>
            /// Returns the volume multiplier of the target Audio Player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the volume multiplier that the target Audio Player will play at.
            /// </summary>
            set
            {
            }
        }

        public static void Pause()
        {
            return;
        }

        public static void Play(Audio Audio)
        {
            return;
        }

        public static void Stop()
        {
            return;
        }
    }

    public class BackgroundObjectsGen : AnyObject
    {
        public BackgroundObjects RoomBackgroundObjectsModify
        {
            set
            {
            }
        }
    }

    public class BeaconGen : AnyObject
    {
        public Color Color
        {
            /// <summary>
            /// Returns the color of the target Beacon object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the color of the target Beacon object.
            /// </summary>
            set
            {
            }
        }

        public bool Enabled
        {
            /// <summary>
            /// Outputs True if the target Beacon object is enabled.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the enabled state of the target Beacon object.
            /// </summary>
            set
            {
            }
        }

        public float Height
        {
            /// <summary>
            /// Returns the height of the target Beacon object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the height of the target Beacon object.
            /// </summary>
            set
            {
            }
        }
    }

    public class ButtonGen : AnyObject
    {
        public bool IsPressed
        {
            /// <summary>
            /// Outputs a target Button's Pressed property.
            /// </summary>
            get => default;
        }

        public string Text
        {
            /// <summary>
            /// Outputs a target Button's Text property.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets an input Button's Text property.
            /// </summary>
            set
            {
            }
        }
    }

    public class CollisionDataGen : AnyObject
    {
        public float Distance
        {
            /// <summary>
            /// Gets distance in meters of an object/player from center specified in "Overlap Sphere" chip.
            /// </summary>
            get => default;
        }

        public Vector3 Normal
        {
            /// <summary>
            /// Gets unit vector specifying the direction of an object/player from center specified in "Overlap Sphere" chip.
            /// </summary>
            get => default;
        }

        public RecRoomObject Object
        {
            /// <summary>
            /// Gets object of a collision data (or null for players) returned from "Overlap Sphere" chip.
            /// </summary>
            get => default;
        }

        public Player Player
        {
            /// <summary>
            /// Gets player of a collision data (or null for objects) returned from "Overlap Sphere" chip.
            /// </summary>
            get => default;
        }

        public Vector3 Position
        {
            /// <summary>
            /// Gets position of an object/player returned by "Overlap Sphere" chip.
            /// </summary>
            get => default;
        }
    }

    public class CollisionDetectionVolumeGen : AnyObject
    {
        public bool Enabled
        {
            get => default;
            set
            {
            }
        }
    }

    public class CombatantGen : AnyObject
    {
        public Vector3 GroundPosition
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public (int Health, int Shield, int MaxHealth) Health
        {
            /// <summary>
            /// Outputs the Health property of the input combatant.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Health property of an input combatant.
            /// </summary>
            set
            {
            }
        }

        public bool IsAlive
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public Combatant MaxHealth
        {
            /// <summary>
            /// Sets the Max Health property of the input combatant.
            /// </summary>
            set
            {
            }
        }

        public Vector3 Position
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 PositionDeprecated
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public (bool IsPlayer, Player Player, AI AI) Split
        {
            /// <summary>
            /// Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) Velocity
        {
            /// <summary>
            /// Outputs the input combatant's current velocity and speed.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void ReceiveDamage(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void ReceiveDamage(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void ReceiveDamage(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        internal static Combatant Variable()
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 B)
        {
            return default;
        }
    }

    public class ConsumableGen : AnyObject
    {
        public Consumable ShowPurchasePrompt
        {
            /// <summary>
            /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public static bool AwardConsumable(Player Player, int Quantity, AlternativeExec<bool> OnAwardConsumableComplete)
        {
            return default;
        }

        /// <summary>
        /// Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
        /// </summary>
        public static void Activate()
        {
            return;
        }

        /// <summary>
        /// Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
        /// </summary>
        public static void Deactivate()
        {
            return;
        }
    }

    public class CostumeGen : AnyObject
    {
        public Costume Equip
        {
            /// <summary>
            /// Equip a Player with a costume.
            /// </summary>
            set
            {
            }
        }

        public Player Wearer
        {
            /// <summary>
            /// Get Player wearing a costume.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Unequip a costume.
        /// </summary>
        public static Player Unequip()
        {
            return default;
        }
    }

    public class DestinationRoomGen : AnyObject
    {
        /// <summary>
        /// Stores a destination room. Destination cannot be configured from variable - for that, use a Constant.
        /// </summary>
        internal static DestinationRoom Variable()
        {
            return default;
        }
    }

    public class DialogueUIGen : AnyObject
    {
        public (string BodyText, bool IsInteractive) DialogueText
        {
            /// <summary>
            /// Returns the current text of the target Dialogue UI’s main body for the local player, and whether or not it’s currently interactive.
            /// </summary>
            get => default;
        }

        public bool IsEnabled
        {
            /// <summary>
            /// Returns whether or not the target Dialogue UI is enabled for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Toggles whether or not the target Dialogue UI is enabled for the local player.             
            /// </summary>
            set
            {
            }
        }

        public bool TitleIsEnabled
        {
            /// <summary>
            /// Returns whether or not the target Dialogue UI’s title bar is visible for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Toggles visibility of the target Dialogue UI’s title bar for the local player. Visibility is dependent on the Dialogue UI being enabled.
            /// </summary>
            set
            {
            }
        }

        public string TitleText
        {
            /// <summary>
            /// Returns the current title of the target Dialogue UI for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the title field of the target Dialogue UI for the local player. Text will truncate after 48 characters.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Set the visibility and text of up to four buttons on the target Dialogue UI for the local player. Text will truncate after 512 characters. Buttons are automatically interactive when enabled. Each button will fire a Button Pressed event in the Dialogue UI’s board scope when pressed. Button visibility is dependent on the Dialogue UI being enabled.
        /// </summary>
        public static void SetButtonState(bool Button1Enabled, string Button1Text, bool Button2Enabled, string Button2Text, bool Button3Enabled, string Button3Text, bool Button4Enabled, string Button4Text)
        {
            return;
        }

        /// <summary>
        /// Sets the text of the target Dialogue UI’s main body for the local player. Text will truncate after 256 characters. If “Is interactive” is true, an arrow will appear in the lower right when the text has fully animated in, and the whole panel will be clickable for the player. The Next Pressed event will fire in the Dialogue UI’s board scope when this interactive panel is clicked.
        /// </summary>
        public static void SetDialogueText(string BodyText, bool IsInteractive)
        {
            return;
        }
    }

    public class DieGen : AnyObject
    {
        public Player DiceGetPlayerRolled
        {
            /// <summary>
            /// Returns the player who rolled the dice.
            /// </summary>
            get => default;
        }

        public int DiceGetResult
        {
            /// <summary>
            /// Returns the result of the dice.
            /// </summary>
            get => default;
        }

        public bool DiceGetRollFinished
        {
            /// <summary>
            /// Outputs an exec when the dice finished rolling.
            /// </summary>
            get => default;
        }
    }

    public class EmitterGen : AnyObject
    {
        public Emitter Color
        {
            /// <summary>
            /// Sets the color for the particles emitted.
            /// </summary>
            set
            {
            }
        }

        public Emitter ColorId
        {
            /// <summary>
            /// Sets the color for the particles emitted.
            /// </summary>
            set
            {
            }
        }

        public bool Looping
        {
            /// <summary>
            /// Returns True if the target Emitter is looping.
            /// </summary>
            get => default;
            /// <summary>
            /// Makes the emitter emit continuously or not.
            /// </summary>
            set
            {
            }
        }

        public bool Playing
        {
            /// <summary>
            /// Returns True if the target Emitter is playing.
            /// </summary>
            get => default;
        }

        public float Size
        {
            /// <summary>
            /// Returns the size multiplier of the target Emitter.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the size of the particles emitted.
            /// </summary>
            set
            {
            }
        }

        public float Speed
        {
            /// <summary>
            /// Returns the speed multiplier of the target Emitter.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the speed particles are emitted.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Starts emitting particles.
        /// </summary>
        public static void Start()
        {
            return;
        }

        /// <summary>
        /// Stops emitting particles.
        /// </summary>
        public static void Stop()
        {
            return;
        }
    }

    public class EquipmentSlotGen : AnyObject
    {
    }

    public class ExplosionEmitterGen : AnyObject
    {
        public int Damage
        {
            get => default;
            set
            {
            }
        }

        public Color ExplosionColor
        {
            get => default;
            set
            {
            }
        }

        public float ExplosionRadius
        {
            get => default;
            set
            {
            }
        }

        public Player FiringPlayer
        {
            /// <summary>
            /// Returns the player set by the Explosion Emitter Set Firing Player chip.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the firing player of the target Explosion Emitter. If none is set, the component will use the authority player.
            /// </summary>
            set
            {
            }
        }

        public static void Explode()
        {
            return;
        }
    }

    public class FogGen : AnyObject
    {
        public Fog RoomFogModify
        {
            set
            {
            }
        }
    }

    public class GiftDropShopItemGen : AnyObject
    {
    }

    public class GrabberGen : AnyObject
    {
        public (bool HasHeldObject, RecRoomObject HeldObject) HeldObject
        {
            /// <summary>
            /// Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
            /// </summary>
            get => default;
        }

        public Grabber PlayerCanStealFromGrabber
        {
            /// <summary>
            /// On execution, the target grabber will lock or unlock the object being held. If true, the held object will interactable for a player to steal.  If false, the held object will not be interactable for a player to steal.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// On execution, the target Grabber will attempt to grab the specified object. If Steal From Player is true, it will steal the object from a player who has it held or holstered. If Snap to Grabber is true, the object will be moved to the Grabber’s position. If Snap to Grabber is false, the distance between Grabber and object at the moment of execution will be maintained until the object is released.
        /// </summary>
        public static bool GrabObject(RecRoomObject Object, bool StealfromPlayer, bool SnaptoGrabber)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
        /// </summary>
        public static RecRoomObject Release()
        {
            return default;
        }
    }

    public class GroundVehicleGen : AnyObject
    {
        public GroundVehicle AddBoostFuel
        {
            set
            {
            }
        }

        public GroundVehicle ApplyBoost
        {
            set
            {
            }
        }

        public int BoostFuel
        {
            get => default;
        }

        public bool DrivingEnabled
        {
            get => default;
            set
            {
            }
        }

        public float EngineTorqueMultiplier
        {
            get => default;
            set
            {
            }
        }

        public float WheelFrictionMultiplier
        {
            get => default;
            /// <summary>
            /// Wheel Friction affects how good the wheels are at gripping the ground - lower values decrease traction and make the wheels slip more and higher values can increase traction and make the wheels slip less. 1 is the default value for Wheel Friction.
            /// </summary>
            set
            {
            }
        }

        public static Player GetSeatedPlayer(int Seatindex)
        {
            return default;
        }

        public static void SetSeatedPlayer(int Seatindex, Player Player, AlternativeExec Failure)
        {
            return;
        }

        public static void UnseatPlayer(Player Player, AlternativeExec Failure)
        {
            return;
        }

        public static void UnseatPlayerFromSeat(int Seatindex, AlternativeExec Failure)
        {
            return;
        }
    }

    public class GunHandleGen : AnyObject
    {
        public GunHandle AddAutoAimRole
        {
            set
            {
            }
        }

        public GunHandle ADSEnabled
        {
            set
            {
            }
        }

        public GunHandle AutoAimRoles
        {
            set
            {
            }
        }

        public int CurrentAmmo
        {
            get => default;
            set
            {
            }
        }

        public bool IsReloading
        {
            get => default;
        }

        public int MaxAmmo
        {
            get => default;
            set
            {
            }
        }

        public float RateOfFire
        {
            get => default;
            set
            {
            }
        }

        public float ReloadDuration
        {
            get => default;
            set
            {
            }
        }

        public GunHandle RemoveAutoAimRole
        {
            set
            {
            }
        }

        public bool SupportsReload
        {
            get => default;
            set
            {
            }
        }

        public static void ApplyRecoil(float AngleX, float AngleY, float Duration, float ReturnDuration)
        {
            return;
        }

        public static Vector3 GetFiringDirection(RecRoomObject Source)
        {
            return default;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(int Duration, float Intensity)
        {
            return;
        }
    }

    public class HolotarProjectorGen : AnyObject
    {
    }

    public class HUDConstantGen : AnyObject
    {
        public Color GameHUDElementColor
        {
            get => default;
            set
            {
            }
        }

        public string GameHUDElementLabel
        {
            get => default;
            set
            {
            }
        }

        public HUDConstant GameHUDElementLabelEnabled
        {
            set
            {
            }
        }

        public int GameHUDElementMaxValue
        {
            get => default;
            set
            {
            }
        }

        public int GameHUDElementValue
        {
            get => default;
            set
            {
            }
        }

        public HUDConstant GameHUDElementValueTextEnabled
        {
            set
            {
            }
        }

        public HUDConstant HUDElementEnabled
        {
            set
            {
            }
        }
    }

    public class HUDElementGen : AnyObject
    {
        /// <summary>
        /// Override all Game HUD Element properties using default values from Game HUD Element Constant input
        /// </summary>
        public static void GameHUDElementSetAllValues()
        {
            return;
        }
    }

    public class InteractionVolumeGen : AnyObject
    {
        public float HoldTime
        {
            /// <summary>
            /// Gets the required hold time for the target Interaction Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the required hold time for the target Interaction Volume.
            /// </summary>
            set
            {
            }
        }

        public string InteractionPrompt
        {
            /// <summary>
            /// Gets the interaction prompt of an Interaction Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the interaction prompt of an Interaction Volume.
            /// </summary>
            set
            {
            }
        }

        public bool IsLocked
        {
            /// <summary>
            /// Returns False if the Interaction Volume is enabled, and True if it is locked.
            /// </summary>
            get => default;
        }

        public InteractionVolume Locked
        {
            /// <summary>
            /// Disables or enables an Interaction Volume (but reversed).
            /// </summary>
            set
            {
            }
        }

        public float NormalizedHoldProgress
        {
            /// <summary>
            /// Gets the normalized hold progress for the target Interaction Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the normalized hold progress for the target Interaction Volume.
            /// </summary>
            set
            {
            }
        }
    }

    public class InventoryItemGen : AnyObject
    {
        public (string Name, string Description, bool SupportsUseAction) Definition
        {
            /// <summary>
            /// Gets the friendly name and description of the given inventory item.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Add an inventory item to the given player.
        /// </summary>
        public static (bool Success, int TotalCount) Add(Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// Get the count of how many of the given inventory item the given player owns.
        /// </summary>
        public static int GetCount(Player Player, AlternativeExec<int> Complete)
        {
            return default;
        }

        /// <summary>
        /// Remove an inventory item from the given player.
        /// </summary>
        public static (bool Success, int TotalCount) Remove(Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// Uses the given inventory item.
        /// </summary>
        public static void Use()
        {
            return;
        }
    }

    public class InvisibleCollisionGen : AnyObject
    {
        public bool BlocksPlayers
        {
            /// <summary>
            /// Outputs True if the target Invisible Collision object is set to collide with players.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the player collision state of a target Invisible Collision object.
            /// </summary>
            set
            {
            }
        }

        public bool Enabled
        {
            /// <summary>
            /// Outputs True if the target Invisible Collision object is enabled.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the enabled state of a target Invisible Collision object.
            /// </summary>
            set
            {
            }
        }
    }

    public class LaserPointerGen : AnyObject
    {
        public Color Color
        {
            get => default;
            set
            {
            }
        }

        public bool Enabled
        {
            get => default;
            set
            {
            }
        }

        public float Length
        {
            get => default;
            set
            {
            }
        }
    }

    public class LightGen : AnyObject
    {
        public float Angle
        {
            /// <summary>
            /// Returns the angle in degrees of the target Dome Light or Spotlight.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the angle of the spotlight's cone.
            /// </summary>
            set
            {
            }
        }

        public Light AngleInt
        {
            /// <summary>
            /// Sets the angle of the spotlight's cone.
            /// </summary>
            set
            {
            }
        }

        public Color Color
        {
            /// <summary>
            /// Returns the color of the target light.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the color for a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public Light ColorId
        {
            /// <summary>
            /// Sets the color for a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public bool Enabled
        {
            /// <summary>
            /// Returns True if the target light is emitting light.
            /// </summary>
            get => default;
        }

        public float Intensity
        {
            /// <summary>
            /// Returns the intensity of the target light.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the brightness level for a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public Light IntensityInt
        {
            /// <summary>
            /// Sets the brightness level for a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public float Range
        {
            /// <summary>
            /// Returns the range of the target light.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the range of a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public Light RangeInt
        {
            /// <summary>
            /// Sets the range of a point light or a spotlight.
            /// </summary>
            set
            {
            }
        }

        public float Softness
        {
            /// <summary>
            /// Returns the softness value of the target light.
            /// </summary>
            get => default;
            set
            {
            }
        }

        public float SpecularContribution
        {
            /// <summary>
            /// Returns the specular contribution of the target light.
            /// </summary>
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Turns off the point light or the spotlight.
        /// </summary>
        public static void TurnOff()
        {
            return;
        }

        /// <summary>
        /// Turns on the point light or the spotlight.
        /// </summary>
        public static void TurnOn()
        {
            return;
        }
    }

    public class MeleeZoneGen : AnyObject
    {
    }

    public class MotionTrailGen : AnyObject
    {
        public Color TrailGetColor
        {
            /// <summary>
            /// Returns the color of the target Motion Trail object.
            /// </summary>
            get => default;
        }

        public bool TrailGetEnabled
        {
            /// <summary>
            /// Outputs True if the target Motion Trail object is enabled.
            /// </summary>
            get => default;
        }

        public float TrailGetLifetime
        {
            /// <summary>
            /// Returns the lifetime of the target Motion Trail object.
            /// </summary>
            get => default;
        }

        public float TrailGetOpacity
        {
            /// <summary>
            /// Returns the max opacity of the target Motion Trail object.
            /// </summary>
            get => default;
        }

        public MotionTrail TrailSetColor
        {
            /// <summary>
            /// Sets the color of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public MotionTrail TrailSetEnabled
        {
            /// <summary>
            /// Sets the enabled state of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public MotionTrail TrailSetLifetime
        {
            /// <summary>
            /// Sets the lifetime of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public MotionTrail TrailSetOpacity
        {
            /// <summary>
            /// Sets the max opacity of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }
    }

    public class ObjectiveMarkerGen : AnyObject
    {
        public Color Color
        {
            /// <summary>
            /// Objective Marker Get Color returns the current color of target Objective Marker for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Color sets target Objective Marker to the specified color for the local player.
            /// </summary>
            set
            {
            }
        }

        public float CurrentDistance
        {
            /// <summary>
            /// Objective Marker Get Current Distance returns the current distance of the local player from the target Objective Marker, regardless of whether the distance indicator is enabled.
            /// </summary>
            get => default;
        }

        public bool DistanceEnabled
        {
            /// <summary>
            /// Objective Marker Get Distance Is Enabled returns whether or not the target Objective Marker’s distance indicator is visible for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Distance Enabled enables or disables the visibility of the target Objective Marker’s distance indicator for the local player.
            /// </summary>
            set
            {
            }
        }

        public bool Enabled
        {
            /// <summary>
            /// Objective Marker Get Enabled returns whether or not the target Objective Marker is enabled for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Enabled enables or disables the target Objective Marker for the local player. Use with Objective Marker constant.
            /// </summary>
            set
            {
            }
        }

        public float FadeThreshold
        {
            /// <summary>
            /// Objective Marker Get Fade Threshold returns the current fade threshold of the target Objective Marker for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Fade Threshold sets the fade threshold of the target Objective Marker for the local player. This threshold is the distance (in meters) at which the marker has fully faded from sight as a player approaches it. For finer control over the fade duration, configure the Objective Marker constant.
            /// </summary>
            set
            {
            }
        }

        public string Label
        {
            /// <summary>
            /// Objective Marker Get Label returns the current text label of target Objective Marker for the local player as a string.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Label sets the text label of target Objective Marker to the specified string for the local player.
            /// </summary>
            set
            {
            }
        }

        public bool LabelEnabled
        {
            /// <summary>
            /// Objective Marker Get Label Is Enabled returns whether or not the target Objective Marker’s text label is visible for the local player.
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Label Enabled enables or disables the visibility of the target Objective Marker’s text label for the local player.
            /// </summary>
            set
            {
            }
        }

        public Vector3 Position
        {
            /// <summary>
            /// Objective Marker Get Position returns target Objective Marker’s current position for the local player as a vector
            /// </summary>
            get => default;
            /// <summary>
            /// Objective Marker Set Position sets the position of target Objective Marker to a position vector for the local player.
            /// </summary>
            set
            {
            }
        }

        public RecRoomObject TargetObject
        {
            /// <summary>
            /// Objective Marker Get Target Object returns the object targeted by target Objective Marker, if it’s tracking an object. If target Objective Marker is not tracking an object, returns Invalid Object.
            /// </summary>
            get => default;
        }

        public Player TargetPlayer
        {
            /// <summary>
            /// Objective Marker Get Target Player returns the player targeted by target Objective Marker, if it’s tracking a player. If target Objective Marker is not tracking a player, returns Invalid Player.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void AttachToPlayerOrObject(Player PlayerOrObject)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void AttachToPlayerOrObject(RecRoomObject PlayerOrObject)
        {
            return;
        }
    }

    public class PatrolPointGen : AnyObject
    {
    }

    public class PistonGen : AnyObject
    {
        public float Acceleration
        {
            /// <summary>
            /// Gets the acceleration of a piston.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the acceleration of the target Piston.
            /// </summary>
            set
            {
            }
        }

        public float Distance
        {
            /// <summary>
            /// Outputs the current distance of the target Piston.
            /// </summary>
            get => default;
            /// <summary>
            /// Moves the target piston to the input distance.
            /// </summary>
            set
            {
            }
        }

        public float MaxDistance
        {
            /// <summary>
            /// Outputs the max distance of the target Piston.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the max distance of a target Piston.
            /// </summary>
            set
            {
            }
        }

        public float Speed
        {
            /// <summary>
            /// Returns the speed of a piston.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the speed of a target Piston.
            /// </summary>
            set
            {
            }
        }

        public float TargetDistance
        {
            /// <summary>
            /// Outputs the set distance of the Marker on a target Piston.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Marker distance of a target Piston.
            /// </summary>
            set
            {
            }
        }
    }

    public class PlayerGen : AnyObject
    {
        public string AccountName
        {
            /// <summary>
            /// Outputs the player's Account name (e.g Coach) in a form of a string. To get a display name, use To String.
            /// </summary>
            get => default;
        }

        public Player AddRole
        {
            /// <summary>
            /// Adds a Role to a Player.
            /// </summary>
            set
            {
            }
        }

        public Player AddTag
        {
            /// <summary>
            /// Adds a tag to the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Player AddTags
        {
            /// <summary>
            /// Adds tags to the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Quaternion BodyOrientation
        {
            /// <summary>
            /// Outputs the rotation of a Player's body.
            /// </summary>
            get => default;
        }

        public Vector3 BodyPosition
        {
            /// <summary>
            /// Outputs the postion of a Player's body in world space.
            /// </summary>
            get => default;
        }

        public bool CanTeleport
        {
            /// <summary>
            /// Returns whether a given player is allowed to teleport.
            get => default;
            /// <summary>
            /// Sets whether a given player is allowed to teleport.
            set
            {
            }
        }

        public Vector3 CombatantGetGroundPosition
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public (int Health, int Shield, int MaxHealth) CombatantGetHealth
        {
            /// <summary>
            /// Outputs the Health property of the input combatant.
            /// </summary>
            get => default;
        }

        public bool CombatantGetIsAlive
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) CombatantGetVelocity
        {
            /// <summary>
            /// Outputs the input combatant's current velocity and speed.
            /// </summary>
            get => default;
        }

        public Player CombatantSetHealth
        {
            /// <summary>
            /// Sets the Health property of an input combatant.
            /// </summary>
            set
            {
            }
        }

        public Player CombatantSetMaxHealth
        {
            /// <summary>
            /// Sets the Max Health property of the input combatant.
            /// </summary>
            set
            {
            }
        }

        public Costume Costume
        {
            /// <summary>
            /// Returns the costume that the given player is currently wearing.
            /// </summary>
            get => default;
        }

        public bool CrouchInputEnabled
        {
            /// <summary>
            /// Returns whether crouch input is enabled for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether crouch input is enabled for a given player. Setting this to false will remove crouch button prompts / UI elements on supported platforms.
            /// </summary>
            set
            {
            }
        }

        public bool DominantHandIsRight
        {
            /// <summary>
            /// Returns true if the given player has their right hand set as dominant.
            /// </summary>
            get => default;
        }

        public (RecRoomObject DominantHandObject, RecRoomObject OffHandObject, RecRoomObject LeftHipHolsterObject, RecRoomObject RightHipHolsterObject, RecRoomObject ShoulderHolsterObject) EquippedObjects
        {
            /// <summary>
            /// Gets equipped objects from a player.
            /// </summary>
            get => default;
        }

        public string FirstTag
        {
            /// <summary>
            /// Gets the first tag of an object or player.
            /// </summary>
            get => default;
        }

        public bool ForceManualSprint
        {
            /// <summary>
            /// Returns whether manual sprint is required for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether manual sprint is required for a given player.
            set
            {
            }
        }

        public bool ForceVirtualHeightMode
        {
            /// <summary>
            /// Returns whether Virtual Height Mode is required for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether Virtual Height Mode is required for a given player.
            set
            {
            }
        }

        public bool ForceVRWalk
        {
            /// <summary>
            /// Returns whether the given player will be forced to use walk mode if they are playing in VR. 
            /// </summary>
            get => default;
            /// <summary>
            /// Forces the given player to use walk rather than teleport mode if they are playing in VR. This is useful when you need access to their walk inputs which won't fire if they are in teleport mode. You should consider adding a warning to your room so teleport players are aware that you're going to change their movement mode.
            /// </summary>
            set
            {
            }
        }

        public Vector3 ForwardVector
        {
            /// <summary>
            /// Gets the forward direction of a target, output as a vector.
            /// </summary>
            get => default;
        }

        public Vector3 ForwardVectorDeprecated
        {
            /// <summary>
            /// Gets the forward direction of a target, output as a vector.
            /// </summary>
            get => default;
        }

        public Player GetCurrencyBalance
        {
            /// <summary>
            /// Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.
            /// </summary>
            set
            {
            }
        }

        public Player GoToRoom
        {
            /// <summary>
            /// Execution sends the specified player to a preconfigured destination. Use a destination constant or variable to specify the destination of this chip. Follow settings are a property of the destination.
            /// </summary>
            set
            {
            }
        }

        public Vector3 HeadForwardVector
        {
            /// <summary>
            /// Outputs the forward vector of a Player's head.
            /// </summary>
            get => default;
        }

        public float HeadHeight
        {
            /// <summary>
            /// Outputs the height of a Player's head.
            /// </summary>
            get => default;
        }

        public Quaternion HeadOrientation
        {
            /// <summary>
            /// Outputs the rotation of a Player's head.
            /// </summary>
            get => default;
        }

        public Vector3 HeadPosition
        {
            /// <summary>
            /// Outputs the position of a Player's head in world space.
            /// </summary>
            get => default;
        }

        public Vector3 HeadUpVector
        {
            /// <summary>
            /// Outputs the up vector of a Player's head.
            /// </summary>
            get => default;
        }

        public Vector3 HeadVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player's head.
            /// </summary>
            get => default;
        }

        public Player IfLocalPlayerShouldRun
        {
            /// <summary>
            /// The "Should Run" port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
            /// </summary>
            set
            {
            }
        }

        public Player IfPlayerIsLocal
        {
            /// <summary>
            /// Outputs if a player is the local player or not.
            /// </summary>
            set
            {
            }
        }

        public Player IfPlayerIsValid
        {
            /// <summary>
            /// Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
            /// </summary>
            set
            {
            }
        }

        public bool IsClambering
        {
            /// <summary>
            /// Whether or not the player is currently clambering or mantling up a ledge
            /// </summary>
            get => default;
        }

        public bool IsCrouching
        {
            /// <summary>
            /// Returns whether the given player is crouching
            /// </summary>
            get => default;
        }

        public (bool IsGrounded, float TimeSinceLastGrounded, RecRoomObject SurfaceObject, Vector3 SurfaceNormal) IsGrounded
        {
            /// <summary>
            /// Returns whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling. Also returns the time (in seconds) since they were last grounded, or 0 if currently grounded. Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object. Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they're not.
            /// </summary>
            get => default;
        }

        public bool IsHoldingMakerPen
        {
            /// <summary>
            /// Outputs if the Player is holding their Maker Pen.
            get => default;
        }

        public bool IsInParty
        {
            get => default;
        }

        public (bool IsJumpingOrFalling, RecRoomObject ContactSurface) IsJumpingOrFalling
        {
            get => default;
        }

        public bool IsLocal
        {
            /// <summary>
            /// Outputs True if the input player is the local player executing the chip on their machine.
            /// </summary>
            get => default;
        }

        public bool IsProne
        {
            /// <summary>
            /// Returns whether the given player is prone.
            /// </summary>
            get => default;
        }

        public bool IsRoomHost
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room's hosts.
            /// </summary>
            get => default;
        }

        public bool IsRoomMod
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room's moderators.
            /// </summary>
            get => default;
        }

        public bool IsRoomOwner
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room's owners.
            /// </summary>
            get => default;
        }

        public bool IsSliding
        {
            /// <summary>
            /// Returns whether the given player is sliding.
            /// </summary>
            get => default;
        }

        public bool IsSprinting
        {
            /// <summary>
            /// Returns whether the given player is sprinting.
            /// </summary>
            get => default;
        }

        public float JumpHeight
        {
            /// <summary>
            /// Returns the jump height for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the jump height for a given player
            /// </summary>
            set
            {
            }
        }

        public bool JumpInputEnabled
        {
            /// <summary>
            /// Returns whether jump input is enabled for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether jump input is enabled for a given player. Setting this to false will remove jump button prompts / UI elements on supported platforms.
            /// </summary>
            set
            {
            }
        }

        public Vector3 LeftHandFingerDirection
        {
            /// <summary>
            /// Outputs the direction of a Player's left hand finger.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandPosition
        {
            /// <summary>
            /// Outputs the postion of a Player's left hand in world space.
            /// </summary>
            get => default;
        }

        public Quaternion LeftHandRotation
        {
            /// <summary>
            /// Outputs the rotation of a Player's left hand.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandThumbDirection
        {
            /// <summary>
            /// Outputs the direction of a Player's left hand thumb.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player's left hand.
            /// </summary>
            get => default;
        }

        public Player LocalPlayerSetPlayerNametagVisibility
        {
            /// <summary>
            /// Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
            /// </summary>
            set
            {
            }
        }

        public Player NameColor
        {
            set
            {
            }
        }

        public float NormalizedSteeringSpeed
        {
            /// <summary>
            /// Returns the normalized (zero to one) steering speed requested by the player. This value represents how fast a player is wanting to move relative to their max speed.
            /// </summary>
            get => default;
        }

        public List<Player> PartyOfPlayer
        {
            /// <summary>
            /// Returns the party of the input player as List<Player>. If the player is not in a party, it will return a list containing only that player.
            /// </summary>
            get => default;
        }

        public Vector3 Position
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
            /// </summary>
            set
            {
            }
        }

        public Vector3 PositionDeprecated
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public int RadioChannel
        {
            /// <summary>
            /// Get the radio channel number of a player. If a player is not in any, this node returns -1
            /// </summary>
            get => default;
            /// <summary>
            /// Assign a player to a radio channel. The channel needs to be a non-negative integer value. Players within the same channel will be able to communicate in team radio.
            /// </summary>
            set
            {
            }
        }

        public Player RemoveRole
        {
            /// <summary>
            /// Removes the input role from a target player.
            /// </summary>
            set
            {
            }
        }

        public Player RemoveTag
        {
            /// <summary>
            /// Removes a tag from the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Player RemoveTags
        {
            /// <summary>
            /// Removes the input list of tags from the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Vector3 RightHandFingerDirection
        {
            /// <summary>
            /// Outputs the direction of a Player's right hand finger.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandPosition
        {
            /// <summary>
            /// Outputs the postion of a Player's right hand in world space.
            /// </summary>
            get => default;
        }

        public Quaternion RightHandRotation
        {
            /// <summary>
            /// Outputs the rotation of a Player's right hand.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandThumbDirection
        {
            /// <summary>
            /// Outputs the direction of a Player's right hand thumb.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player's right hand.
            /// </summary>
            get => default;
        }

        public int RoomIndex
        {
            /// <summary>
            /// Returns the unique index of this player in the room, bounded by the room capacity.
            /// </summary>
            get => default;
        }

        public int RoomLevel
        {
            /// <summary>
            /// Returns the current Room Level of the specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
            /// </summary>
            get => default;
        }

        public Quaternion Rotation
        {
            /// <summary>
            /// Outputs the rotation of the target as a quaternion.
            /// </summary>
            get => default;
        }

        public Quaternion RotationDeprecated
        {
            /// <summary>
            /// Outputs the rotation of the target as a quaternion.
            /// </summary>
            get => default;
        }

        public string SeasonLeagueName
        {
            get => default;
        }

        public Seat Seat
        {
            get => default;
        }

        public bool SprintInputEnabled
        {
            /// <summary>
            /// Returns whether sprint input is enabled for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether sprint input is enabled for a given player. Setting this to false will remove sprint button prompts / UI elements on supported platforms.
            /// </summary>
            set
            {
            }
        }

        public float SprintSpeed
        {
            /// <summary>
            /// Returns the sprint speed for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the sprint speed for a given player
            /// </summary>
            set
            {
            }
        }

        public Vector3 SteeringDirection
        {
            /// <summary>
            /// Player Get Steering Direction
            /// </summary>
            get => default;
        }

        public (bool Result, int SecondsUntilEnabled) SubscribesToRoomOwner
        {
            /// <summary>
            /// Outputs True if the input Player subscribes to one of the current room's owners.
            /// </summary>
            get => default;
        }

        public List<string> Tags
        {
            /// <summary>
            /// Outputs a list of tags the input object or player has.
            /// </summary>
            get => default;
        }

        public float TeleportDelay
        {
            /// <summary>
            /// Returns the teleport delay for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the teleport delay for a given player
            /// </summary>
            set
            {
            }
        }

        public float TeleportDistance
        {
            /// <summary>
            /// Returns the max teleport distance for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the max teleport distance for a given player
            /// </summary>
            set
            {
            }
        }

        public int TimeZone
        {
            /// <summary>
            /// Returns the offset of the given player's local time zone from UTC in seconds.
            /// </summary>
            get => default;
        }

        public Combatant ToCombatant
        {
            /// <summary>
            /// Covert a player or an AI value into a Combatant value.
            /// </summary>
            get => default;
        }

        public Player UnequipFromPlayer
        {
            set
            {
            }
        }

        public Vector3 UpVector
        {
            /// <summary>
            /// Outputs the up direction of the input target, output as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 UpVectorDeprecated
        {
            /// <summary>
            /// Outputs the up direction of the input target, output as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 Velocity
        {
            /// <summary>
            /// Returns the velocity of a Player or a Rec Room Object.
            /// </summary>
            get => default;
        }

        public Vector3 VelocityDeprecated
        {
            /// <summary>
            /// Returns the velocity of a Player or a Rec Room Object.
            /// </summary>
            get => default;
        }

        public float VoiceRolloffDistance
        {
            /// <summary>
            /// Returns the voice rolloff distance for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the voice rolloff distance for a given player. Beyond this distance, they cannot be heard.
            /// </summary>
            set
            {
            }
        }

        public bool WalkInputEnabled
        {
            /// <summary>
            /// Returns whether walk input is enabled for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
            /// </summary>
            set
            {
            }
        }

        public float WalkSpeed
        {
            /// <summary>
            /// Returns the walk speed for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the walk speed for a given player
            /// </summary>
            set
            {
            }
        }

        public bool WorldUIEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player's world UI.
            /// </summary>
            get => default;
        }

        public Color WorldUIPrimaryBarColor
        {
            /// <summary>
            /// Returns the color of the given player's primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the primary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUIPrimaryBarEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player's primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the primary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUIPrimaryBarMaxValue
        {
            /// <summary>
            /// Returns the max value of the given player's primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the max value of the primary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUIPrimaryBarValue
        {
            /// <summary>
            /// Returns the value of the given player's primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the primary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public Color WorldUISecondaryBarColor
        {
            /// <summary>
            /// Returns the color of the given player's secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the secondary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUISecondaryBarEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player's secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the secondary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUISecondaryBarMaxValue
        {
            /// <summary>
            /// Returns the max value of the given player's secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the max value of the secondary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUISecondaryBarValue
        {
            /// <summary>
            /// Returns the value of the given player's secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the secondary bar in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public Color WorldUITextColor
        {
            /// <summary>
            /// Returns the color of the given player's text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the text in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUITextEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player's text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the text in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public string WorldUITextValue
        {
            /// <summary>
            /// Returns the value of the given player's text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the text in the given player's active world UI.
            /// </summary>
            set
            {
            }
        }

        public int XP
        {
            /// <summary>
            /// Returns current XP of specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Award some amount to the Player's balance of one room currency. Configure this chip to set the affected currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrency(int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Clears any active screen vignette on the given player.
        /// </summary>
        public static void ClearPlayerVignette()
        {
            return;
        }

        /// <summary>
        /// Clear the UI configuration displayed above a given player.
        /// </summary>
        public static void ClearPlayerWorldUI()
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        public static bool EquipObjectToDominantHand(RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        public static bool EquipObjectToOffHand(RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Grants the contents of a Reward to the specified Player.
        /// </summary>
        public static bool GrantReward(Reward Reward, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(string Tag)
        {
            return default;
        }

        public static bool HolsterObject(RecRoomObject ObjectToHolster, bool ForceHolster, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
        /// </summary>
        public static void IfPlayerHasRole(string Role, AlternativeExec DoesNotHaveRole)
        {
            return;
        }

        /// <summary>
        /// If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
        /// </summary>
        public static void IfPlayerIsValidAndLocal(AlternativeExec IsNotValid, AlternativeExec IsValidAndNotLocal)
        {
            return;
        }

        /// <summary>
        /// Get the leaderboard stat for the given player on the given stat channel.
        /// </summary>
        public static int LeaderboardGetPlayerStat(int Channel, AlternativeExec<int> OnGetStatComplete)
        {
            return default;
        }

        /// <summary>
        /// Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
        /// </summary>
        public static void LocalPlayerDisableInteractionWithTargetPlayer()
        {
            return;
        }

        /// <summary>
        /// Enables the local player to interact with the provided player. To respond to interactions, configure a "Event Receiver" chip for the "Local Player... Interaction" events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player's interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
        /// </summary>
        public static void LocalPlayerEnableInteractionWithTargetPlayer(float RequiredHoldDuration, string Prompt)
        {
            return;
        }

        /// <summary>
        /// Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static bool AwardXP(int Amount, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Clears any subtitle which is currently being displayed for the given player.
        /// </summary>
        public static void ClearCurrentSubtitle()
        {
            return;
        }

        /// <summary>
        /// For the target player, equip the specified Inventory Item to the specified Inventory Equipment Slot. If the Slot is of Inventory type, this chip will take effect whether or not the Slot is enabled, but the Slot must then be enabled separately.
        /// </summary>
        public static bool EquipInventoryItem(InventoryItem InventoryItem, EquipmentSlot InventoryEquipmentSlot, AlternativeExec<bool> OnEquipComplete)
        {
            return default;
        }

        /// <summary>
        /// For the target player, get whether the specified equipment slot is enabled.
        /// </summary>
        public static bool GetEquipmentSlotIsEnabled(EquipmentSlot EquipmentSlot)
        {
            return default;
        }

        /// <summary>
        /// Outputs if a Player is authority of the input object.
        /// </summary>
        public static bool GetIsAuthorityOf(RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player has the input role.
        /// </summary>
        public static bool HasRole(string Value)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player owns at least one of the given inventory item.
        /// </summary>
        public static bool OwnsInventoryItem(InventoryItem InventoryItem, AlternativeExec<bool> Complete)
        {
            return default;
        }

        public static bool OwnsRoomKey(RoomKey RoomKey, AlternativeExec<bool> OnPlayerOwnsRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a watch notification to the specified player containing the prompt title and body, along with each of the answer choices on its own line. Once this watch notification is opened, the player can choose a response and hit "ok," triggering the On Prompt Complete event. Since there is a delay between sending a notification and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses
        /// </summary>
        public static (bool Success, Player ReceivingPlayer, string Response, int ResponseIndex) PromptMultipleChoice(string PromptTitle, string PromptBody, List<string> AnswerChoices, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response, int ResponseIndex)> OnPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// Resets the color of the given player's name tag to the default color.
        /// </summary>
        public static void ResetNameColor()
        {
            return;
        }

        /// <summary>
        /// Enables the specified equipment slot on the target player
        /// </summary>
        public static void SetEquipmentSlotIsEnabled(EquipmentSlot EquipmentSlot, bool IsEnabled)
        {
            return;
        }

        /// <summary>
        /// Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
        /// </summary>
        public static void ShowSubtitle(string Subtitle, float Duration, int Priority)
        {
            return;
        }

        /// <summary>
        /// For the specified player, unequip anything which is equipped to the specified slot. If the slot is of Inventory type, this chip will take effect whether or not the slot is enabled.
        /// </summary>
        public static bool UnequipFromSlot(EquipmentSlot EquipmentSlot, AlternativeExec<bool> OnUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// For the target player, unequip the specified Inventory Item from any slot to which it is equipped.
        /// </summary>
        public static bool UnequipInventoryItem(InventoryItem InventoryItem, AlternativeExec<bool> OnUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player Variable()
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player VariableDeprecated()
        {
            return default;
        }

        /// <summary>
        /// Remove a player from the radio channel they are in
        /// </summary>
        public static void RemovePlayerFromRadioChannel()
        {
            return;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public static void RequestVelocitySetOverDuration(float Multiplier, Vector3 Velocity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Reset the player's active world UI to its default values.
        /// </summary>
        public static void ResetPlayerWorldUI()
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        public static void RespawnPointRespawnPlayer(bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }

        /// <summary>
        /// Start a screen shake effect for the given player. This will have no effect on VR players.
        /// </summary>
        public static void SetCameraShake(float Intensity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
        /// </summary>
        public static void SetVignette(float Time, Color Color, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Prints the input notification to the given player's screen.
        /// </summary>
        public static void ShowNotification<T>(string Value)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(Reward Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(List<Reward> Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Stop any current screen shake for the given player.
        /// </summary>
        public static void StopCameraShake()
        {
            return;
        }

        public static List<RecRoomObject> UnequipFromSlots(bool DominantHand, bool OffHand, bool LeftHipHolster, bool RightHipHolster, bool ShoulderHolster)
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAddNew(float Multiplier, Vector3 Velocity, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(float Multiplier, Vector3 Velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(float Speed, Vector3 Direction)
        {
            return;
        }
    }

    public class PlayerOutfitSlotGen : AnyObject
    {
    }

    public class PlayerSpawnPointV2Gen : AnyObject
    {
        public PlayerSpawnPointV2 RespawnPointAddAvoidRole
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointAddAvoidTag
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointAddSpawnRole
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointAddSpawnTag
        {
            set
            {
            }
        }

        public bool RespawnPointGetActive
        {
            get => default;
        }

        public PlayerSpawnPointV2 RespawnPointRemoveAvoidRole
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointRemoveAvoidTag
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointRemoveSpawnRole
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointRemoveSpawnTag
        {
            set
            {
            }
        }

        public PlayerSpawnPointV2 RespawnPointSetActive
        {
            set
            {
            }
        }

        public static void RespawnPointRespawnPlayerAtRespawnPoint(Player Player, bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }
    }

    public class PlayerWorldUIGen : AnyObject
    {
        public PlayerWorldUI DisplayPlayerWorldUI
        {
            /// <summary>
            /// Displays a target UI configuration above a given player.
            /// </summary>
            set
            {
            }
        }
    }

    public class ProjectileLauncherGen : AnyObject
    {
        public ProjectileLauncher FireProjectile
        {
            set
            {
            }
        }

        public Player FiringPlayer
        {
            /// <summary>
            /// Returns the player set by the Projectile Launcher Set Firing Player chip.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the firing player of the target Projectile Launcher. If none is set, the component will use the authority player.
            /// </summary>
            set
            {
            }
        }

        public int HandDamage
        {
            get => default;
            set
            {
            }
        }

        public int HeadDamage
        {
            get => default;
            set
            {
            }
        }

        public Color ProjectileColor
        {
            get => default;
            set
            {
            }
        }

        public int ProjectileCount
        {
            get => default;
            set
            {
            }
        }

        public float ProjectileLifetime
        {
            get => default;
            set
            {
            }
        }

        public float ProjectileSpeed
        {
            get => default;
            set
            {
            }
        }

        public float ProjectileSpread
        {
            get => default;
            set
            {
            }
        }

        public int RecRoomObjectDamage
        {
            /// <summary>
            /// Returns the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
            /// </summary>
            set
            {
            }
        }

        public int TorsoDamage
        {
            get => default;
            set
            {
            }
        }
    }

    public class RecRoomObjectGen : AnyObject
    {
        public RecRoomObject AddTag
        {
            /// <summary>
            /// Adds a tag to the input object or player.
            /// </summary>
            set
            {
            }
        }

        public RecRoomObject AddTags
        {
            /// <summary>
            /// Adds tags to the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Vector3 AngularVelocity
        {
            /// <summary>
            /// Returns the angular velocity in degrees per second of a Rec Room Object.
            /// </summary>
            get => default;
        }

        public Player Authority
        {
            /// <summary>
            /// Outputs the authority Player of the input object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the authority player of the input Rec Room Object.
            /// </summary>
            set
            {
            }
        }

        public string FirstTag
        {
            /// <summary>
            /// Gets the first tag of an object or player.
            /// </summary>
            get => default;
        }

        public Vector3 ForwardVector
        {
            /// <summary>
            /// Gets the forward direction of a target, output as a vector.
            /// </summary>
            get => default;
        }

        public Vector3 ForwardVectorDeprecated
        {
            /// <summary>
            /// Gets the forward direction of a target, output as a vector.
            /// </summary>
            get => default;
        }

        public (bool IsHeld, Player HolderPlayer) HolderPlayer
        {
            /// <summary>
            /// Gets the player currently holding this object. Does not account for when objects are equipped but not directly grabbed. Returns Invalid Player if the object is not being held.
            /// </summary>
            get => default;
        }

        public bool IsLocalPlayerAuthority
        {
            /// <summary>
            /// Outputs True on the player's machine who has authority of the input.
            /// </summary>
            get => default;
        }

        public (Player Player, bool CurrentlyHeldOrEquipped) LastHoldingOrEquippingPlayer
        {
            /// <summary>
            /// Returns the player who last held or equipped an object.
            /// </summary>
            get => default;
        }

        public Vector3 Position
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
            /// </summary>
            set
            {
            }
        }

        public Vector3 PositionDeprecated
        {
            /// <summary>
            /// Outputs the position of the input object as a vector3.
            /// </summary>
            get => default;
        }

        public RecRoomObject RemoveTag
        {
            /// <summary>
            /// Removes a tag from the input object or player.
            /// </summary>
            set
            {
            }
        }

        public RecRoomObject RemoveTags
        {
            /// <summary>
            /// Removes the input list of tags from the input object or player.
            /// </summary>
            set
            {
            }
        }

        public Quaternion Rotation
        {
            /// <summary>
            /// Outputs the rotation of the target as a quaternion.
            /// </summary>
            get => default;
        }

        public Quaternion RotationDeprecated
        {
            /// <summary>
            /// Outputs the rotation of the target as a quaternion.
            /// </summary>
            get => default;
        }

        public List<string> Tags
        {
            /// <summary>
            /// Outputs a list of tags the input object or player has.
            /// </summary>
            get => default;
        }

        public Vector3 UpVector
        {
            /// <summary>
            /// Outputs the up direction of the input target, output as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 UpVectorDeprecated
        {
            /// <summary>
            /// Outputs the up direction of the input target, output as a vector3.
            /// </summary>
            get => default;
        }

        public Vector3 Velocity
        {
            /// <summary>
            /// Returns the velocity of a Player or a Rec Room Object.
            /// </summary>
            get => default;
        }

        public Vector3 VelocityDeprecated
        {
            /// <summary>
            /// Returns the velocity of a Player or a Rec Room Object.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
        /// </summary>
        public static bool AngularVelocityAdd(Vector3 AngularVelocity, float SpeedMultiplier, float MaxAngularSpeed)
        {
            return default;
        }

        public static void AngularVelocityAddDeprecated(Vector3 Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        public static void AngularVelocityAddDeprecated(Quaternion Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        /// <summary>
        /// Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
        /// </summary>
        public static bool AngularVelocitySet(Vector3 AngularVelocity, float SpeedMultiplier)
        {
            return default;
        }

        public static void AngularVelocitySetDeprecated(Vector3 Rotation, float VelocityMultiplier)
        {
            return;
        }

        public static void AngularVelocitySetDeprecated(Quaternion Rotation, float VelocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Converts the input Rec Room Object to the object's subtype.
        /// </summary>
        internal static T FromRecRoomObject<T>()
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// Resets an object.
        /// </summary>
        public static void Reset()
        {
            return;
        }

        internal static RecRoomObject Variable()
        {
            return default;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public static void RequestVelocitySetOverDuration(float Multiplier, Vector3 Velocity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        public static void SpawnerInternalStartSpawning(int Amountofobjectstospawn, float Timebetweenspawns, Vector3 SpawnPosition)
        {
            return;
        }

        public static void SpawnerReset()
        {
            return;
        }

        public static bool UnequipObject()
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAddNew(float Multiplier, Vector3 Velocity, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(float Multiplier, Vector3 Velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(float Speed, Vector3 Direction)
        {
            return;
        }
    }

    public class RemoteVideoPlayerGen : AnyObject
    {
    }

    public class RewardGen : AnyObject
    {
    }

    public class RoomCurrencyGen : AnyObject
    {
        public RoomCurrency ShowPurchasePrompt
        {
            /// <summary>
            /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Award some amount to the Player's balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrencyNew(Player Player, int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Returns the given player's balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) GetCurrencyBalanceNew(Player Player, AlternativeExec<(bool Success, int TotalBalance)> OnGetBalanceComplete)
        {
            return default;
        }
    }

    public class RoomDoorGen : AnyObject
    {
        public DestinationRoom DoorGetDestination
        {
            get => default;
        }

        public bool DoorGetLocked
        {
            get => default;
        }

        public RoomDoor DoorSetDestination
        {
            set
            {
            }
        }

        public RoomDoor DoorSetLocked
        {
            set
            {
            }
        }
    }

    public class RoomKeyGen : AnyObject
    {
        public RoomKey ShowPurchasePrompt
        {
            /// <summary>
            /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Unlocks a room key for the target player. Multiple award room key requests from the same client are sent in bulk with a one-second cooldown.
        public static bool AwardRoomKey(Player Player, AlternativeExec<bool> OnAwardRoomKeyComplete)
        {
            return default;
        }
    }

    public class RoomLevelHUDGen : AnyObject
    {
    }

    public class RoomOfferGen : AnyObject
    {
    }

    public class RotatorGen : AnyObject
    {
        public float Rotation
        {
            /// <summary>
            /// Outputs the rotation of a target Rotator in degrees.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the rotation of a target Rotator.
            /// </summary>
            set
            {
            }
        }

        public float RotationAcceleration
        {
            /// <summary>
            /// Outputs the acceleration of a target Rotator.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the acceleration of a target Rotator.
            /// </summary>
            set
            {
            }
        }

        public float RotationSpeed
        {
            /// <summary>
            /// Outputs the speed of a target Rotator.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the speed of a target Rotator.
            /// </summary>
            set
            {
            }
        }

        public float TargetRotation
        {
            /// <summary>
            /// Outputs the rotation of the Marker on the target Rotator.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the rotation of the Marker on a target Rotator.
            /// </summary>
            set
            {
            }
        }
    }

    public class SeatGen : AnyObject
    {
        public bool LockPlayersIn
        {
            /// <summary>
            /// Returns True if the target Seat is set to lock players in.
            /// </summary>
            get => default;
            /// <summary>
            /// Prevents a Seated player from unseating themselves on a target Seat. Use circuits to unseat or unlock.
            /// </summary>
            set
            {
            }
        }

        public bool LockPlayersOut
        {
            /// <summary>
            /// Returns True if the target Seat is set to lock players out.
            /// </summary>
            get => default;
            /// <summary>
            /// Prevents players from sitting in a target seat.
            /// </summary>
            set
            {
            }
        }

        public Player SeatedPlayer
        {
            /// <summary>
            /// Outputs the currently seated player of a target Seat.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Seats an input player on a target Seat.
        /// </summary>
        public static void SetSeatedPlayer(Player Player, AlternativeExec Fail)
        {
            return;
        }

        /// <summary>
        /// Unseats a currently seated player on a target Seat.
        /// </summary>
        public static void UnseatPlayer()
        {
            return;
        }
    }

    public class SFXGen : AnyObject
    {
        public bool IsPlaying
        {
            get => default;
        }

        public int Volume
        {
            /// <summary>
            /// Outputs the volume of an SFX object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the volume for an SFX object.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Plays a sound from an SFX object.
        /// </summary>
        public static void Play()
        {
            return;
        }

        /// <summary>
        /// Stops the sound currently playing from an SFX object.
        /// </summary>
        public static void Stop()
        {
            return;
        }
    }

    public class SkydomeGen : AnyObject
    {
        public Skydome RoomSkydomeModify
        {
            set
            {
            }
        }
    }

    public class StateGen : AnyObject
    {
        /// <summary>
        /// Transitions to the given state in the current state machine.
        /// </summary>
        public static void GoToState()
        {
            return;
        }
    }

    public class SteeringEngineGen : AnyObject
    {
    }

    public class StudioObjectGen : AnyObject
    {
        public StudioObject StudioEventSender
        {
            set
            {
            }
        }

        public static void StudioEventSenderBool(string Event, bool Value)
        {
            return;
        }

        public static void StudioEventSenderFloat(string Event, float Value)
        {
            return;
        }

        public static void StudioEventSenderInt(string Event, int Value)
        {
            return;
        }

        public static void StudioEventSenderString(string Event, string Value)
        {
            return;
        }

        public static void StudioEventSenderStringBool(string Event, string Value0, bool Value1)
        {
            return;
        }

        public static void StudioEventSenderStringFloat(string Event, string Value0, float Value1)
        {
            return;
        }

        public static void StudioEventSenderStringInt(string Event, string Value0, int Value1)
        {
            return;
        }

        public static void StudioEventSenderStringString(string Event, string Value0, string Value1)
        {
            return;
        }

        public static bool GetPropertyBool(string Property)
        {
            return default;
        }

        public static float GetPropertyFloat(string Property)
        {
            return default;
        }

        public static int GetPropertyInt(string Property)
        {
            return default;
        }

        public static string GetPropertyString(string Property)
        {
            return default;
        }
    }

    public class SunGen : AnyObject
    {
        public static bool RoomSunModify(SunDirection SunDirection, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }
    }

    public class SunDirectionGen : AnyObject
    {
    }

    public class SwingHandleGen : AnyObject
    {
        public bool IsSwinging
        {
            get => default;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(int Duration, float Intensity)
        {
            return;
        }
    }

    public class TextGen : AnyObject
    {
        public Color Color
        {
            /// <summary>
            /// Returns the color of the target Text gadget.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the color for a Text object.
            /// </summary>
            set
            {
            }
        }

        public Text ColorId
        {
            /// <summary>
            /// Sets the color for a Text object.
            /// </summary>
            set
            {
            }
        }

        public Text Material
        {
            /// <summary>
            /// Sets the material for a Text object.
            /// </summary>
            set
            {
            }
        }

        public string Text
        {
            /// <summary>
            /// Outputs the visible text for a Text object.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the visible text for a Text object.
            /// </summary>
            set
            {
            }
        }
    }

    public class TextScreenGen : AnyObject
    {
        public static void ClearScreen()
        {
            return;
        }

        public static void PrintTextToScreen(string Text, Color Color)
        {
            return;
        }
    }

    public class ToggleButtonGen : AnyObject
    {
        public bool IsPressed
        {
            /// <summary>
            /// Outputs True if the toggle button is pressed.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets a Toggle Button state to pressed.
            /// </summary>
            set
            {
            }
        }
    }

    public class TouchpadGen : AnyObject
    {
        public (bool IsTouchActive, Vector3 TouchPosition, Vector3 WorldPosition) ComponentGetActiveTouch
        {
            /// <summary>
            /// Get the active touch position from the local player's interaction
            /// </summary>
            get => default;
        }

        public string ComponentGetInteractionLabel
        {
            /// <summary>
            /// Sets the interaction label (used by Screen players)
            /// </summary>
            get => default;
        }

        public bool ComponentGetIsEnabled
        {
            /// <summary>
            /// Sets if the Touchpad can be interacted with or output touch events
            /// </summary>
            get => default;
        }

        public Touchpad ComponentSetInteractionLabel
        {
            /// <summary>
            /// Gets the interaction label (used by Screen players)
            /// </summary>
            set
            {
            }
        }

        public Touchpad ComponentSetIsEnabled
        {
            /// <summary>
            /// Gets if the Touchpad can be interacted with or output touch events
            /// </summary>
            set
            {
            }
        }
    }

    public class TriggerHandleGen : AnyObject
    {
        public string ControlPrompt
        {
            get => default;
            set
            {
            }
        }

        public bool PrimaryActionHeld
        {
            /// <summary>
            /// True if the primary action button is down; otherwise, False.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(int Duration, float Intensity)
        {
            return;
        }
    }

    public class TriggerVolumeGen : AnyObject
    {
        public string FilterRole
        {
            /// <summary>
            /// Gets the role name that is being used as a filter for a Trigger Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the role name that is being used as a filter for a Trigger Volume.
            /// </summary>
            set
            {
            }
        }

        public List<string> FilterTags
        {
            /// <summary>
            /// Gets the tags that are being used as a filter for a Trigger Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the tags that are being used as a filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
            /// </summary>
            set
            {
            }
        }

        public int ObjectCount
        {
            /// <summary>
            /// Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
            /// </summary>
            get => default;
        }

        public List<RecRoomObject> Objects
        {
            /// <summary>
            /// Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
            /// </summary>
            get => default;
        }

        public int PlayerCount
        {
            /// <summary>
            /// Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
            /// </summary>
            get => default;
        }

        public List<Player> Players
        {
            /// <summary>
            /// Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
            /// </summary>
            get => default;
        }
    }

    public class VectorComponentGen : AnyObject
    {
        /// <summary>
        /// Gets the direction and magnitude of the Vector Component.
        /// </summary>
        public static Vector3 GetVector(float Magnitude)
        {
            return default;
        }
    }

    public class WelcomeMatGen : AnyObject
    {
        public bool Enabled
        {
            /// <summary>
            /// Return whether target welcome mat is enabled (true) or disabled (false)
            /// </summary>
            get => default;
            /// <summary>
            /// Set target welcome mat to be enabled (true) or disabled (false)
            /// </summary>
            set
            {
            }
        }
    }
}