using System.Collections.Generic;
using UnityEngine;
using RRCGSource;
using RRCG;

namespace RRCGGenerated
{
    public abstract class AIGen : AnyObject
    {
        public Vector3 CombatantGetGroundPositionR1
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public bool CombatantGetIsAliveR1
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) CombatantGetVelocityR1
        {
            /// <summary>
            /// Outputs the input combatant&apos;s current velocity and speed.
            /// </summary>
            get => default;
        }

        public int CombatantSetMaxHealthR1
        {
            /// <summary>
            /// Sets the Max Health property of the input combatant.
            /// </summary>
            set
            {
            }
        }

        public (string VisionType, float VisionRange, float VisionConeAngle, float HearingRange) LineOfSightParametersR1
        {
            /// <summary>
            /// Outputs the current line of sight parameters from the input AI.
            /// </summary>
            get => default;
        }

        public float PathingSpeedR1
        {
            /// <summary>
            /// Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
            /// </summary>
            set
            {
            }
        }

        public PatrolPoint PatrolPointR1
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

        public Combatant TargetR1
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

        public Combatant ToCombatantR1
        {
            /// <summary>
            /// Covert a player or an AI value into a Combatant value.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(AI Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(Combatant Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(PatrolPoint Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public bool HasLineOfSightToTargetR1(Vector3 Target)
        {
            return default;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(AI LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(Combatant LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(RecRoomObject LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(PatrolPoint LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(Player LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public void LookAtR1(Vector3 LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(AI Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(Combatant Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(RecRoomObject Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(PatrolPoint Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(Player Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public void PathToR1(Vector3 Target)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public void RotateR1(float Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public void RotateR1(int Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public void RotateR1(Vector3 Rotation)
        {
            return;
        }

        /// <summary>
        /// Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
        /// </summary>
        public void SetLineOfSightParametersR1(string VisionType, float VisionRange, float VisionConeAngle, float HearingRange, bool RequireLoSfortargeting)
        {
            return;
        }

        /// <summary>
        /// RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
        /// </summary>
        public void StartCombatBehaviorR1()
        {
            return;
        }

        /// <summary>
        /// Tells the input AI to stop its C# defined combat behavior.
        /// </summary>
        public void StopCombatBehaviorR1()
        {
            return;
        }

        /// <summary>
        /// Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
        /// </summary>
        public void StopLookingR1()
        {
            return;
        }

        internal AI VariableR1(VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public (int Health, int Shield, int MaxHealth) CombatantGetHealthR1()
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public void CombatantSetHealthR1(int Health)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(AI ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Combatant ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }
    }

    public abstract class AnimationControllerGen : AnyObject
    {
        public int Frame
        {
            /// <summary>
            /// Returns the current frame of the given animation controller component.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Animation Controller&apos;s animation to a specific frame number.
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
            /// Sets the Animation Controller&apos;s play speed. Default value is 1. Negative values play the animation in reverse.
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
        public void Pause()
        {
            return;
        }

        /// <summary>
        /// Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller&apos;s configuration menu.
        /// </summary>
        public void Play()
        {
            return;
        }

        /// <summary>
        /// Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
        /// </summary>
        public void Stop()
        {
            return;
        }
    }

    public abstract class AudioGen : AnyObject
    {
        public float Length
        {
            /// <summary>
            /// Returns the length in seconds of the given audio reference.
            /// </summary>
            get => default;
        }

        public void PlayAudioAtPosition(Vector3 Position, float Volume, float PlaybackSpeed, bool Is2D, PlayAudioAtPositionData config)
        {
            return;
        }
    }

    public abstract class AudioFXZoneGen : AnyObject
    {
        public float Intensity
        {
            /// <summary>
            /// Returns the intensity of the target Audio FX Zone object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the intensity of the target Audio FX Zone object.
            /// </summary>
            set
            {
            }
        }

        public int Priority
        {
            /// <summary>
            /// Returns the priority of the target Audio FX Zone object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the priority of the target Audio FX Zone object.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Sets the effect of the target Audio FX Zone object.
        /// </summary>
        public void SetEffect()
        {
            return;
        }
    }

    public abstract class AudioPlayerGen : AnyObject
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

        public void Pause()
        {
            return;
        }

        public void Play(Audio Audio)
        {
            return;
        }

        public void Stop()
        {
            return;
        }
    }

    public abstract class BackgroundObjectsGen : AnyObject
    {
        public bool RoomBackgroundObjectsModifyR1(AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared background objects state to the given configuration.
        /// </summary>
        public void RoomBackgroundObjectsModifyR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room background objects state to the given configuration. This will take precedent over the room&apos;s shared background objects state.
        /// </summary>
        public void RoomBackgroundObjectsPlayerOverrideR2(Player Player, float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }
    }

    public abstract class BeaconGen : AnyObject
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

    public abstract class ButtonGen : AnyObject
    {
        public bool IsPressed
        {
            /// <summary>
            /// Outputs a target Button&apos;s Pressed property.
            /// </summary>
            get => default;
        }

        public string Text
        {
            /// <summary>
            /// Outputs a target Button&apos;s Text property.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets an input Button&apos;s Text property.
            /// </summary>
            set
            {
            }
        }
    }

    public abstract class CollisionDataGen : AnyObject
    {
        public float Distance
        {
            /// <summary>
            /// Gets distance in meters of an object/player from center specified in &quot;Overlap Sphere&quot; chip.
            /// </summary>
            get => default;
        }

        public Vector3 Normal
        {
            /// <summary>
            /// Gets unit vector specifying the direction of an object/player from center specified in &quot;Overlap Sphere&quot; chip.
            /// </summary>
            get => default;
        }

        public RecRoomObject Object
        {
            /// <summary>
            /// Gets object of a collision data (or null for players) returned from &quot;Overlap Sphere&quot; chip.
            /// </summary>
            get => default;
        }

        public Player Player
        {
            /// <summary>
            /// Gets player of a collision data (or null for objects) returned from &quot;Overlap Sphere&quot; chip.
            /// </summary>
            get => default;
        }

        public Vector3 Position
        {
            /// <summary>
            /// Gets position of an object/player returned by &quot;Overlap Sphere&quot; chip.
            /// </summary>
            get => default;
        }
    }

    public abstract class CollisionDetectionVolumeGen : AnyObject
    {
        public bool Enabled
        {
            get => default;
            set
            {
            }
        }
    }

    public abstract class CombatantGen : AnyObject
    {
        public Vector3 GroundPositionR1
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public bool IsAliveR1
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public int MaxHealthR1
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

        public (bool IsPlayer, Player Player, AI AI) SplitR1
        {
            /// <summary>
            /// Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) VelocityR1
        {
            /// <summary>
            /// Outputs the input combatant&apos;s current velocity and speed.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public (int Health, int Shield, int MaxHealth) GetHealthR1()
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void ReceiveDamageR1(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void ReceiveDamageR1(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void ReceiveDamageR1(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public void SetHealthR1(int Health)
        {
            return;
        }

        internal Combatant VariableR1(VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(AI ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Combatant ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }
    }

    public abstract class ConsumableGen : AnyObject
    {
        /// <summary>
        /// Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public bool AwardConsumableR1(Player Player, int Quantity, AlternativeExec<bool> OnAwardConsumableComplete)
        {
            return default;
        }

        /// <summary>
        /// Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
        /// </summary>
        public void ActivateR1()
        {
            return;
        }

        /// <summary>
        /// Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
        /// </summary>
        public void DeactivateR1()
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public void ShowPurchasePromptR1(Player Player)
        {
            return;
        }
    }

    public abstract class CostumeGen : AnyObject
    {
        public Player Wearer
        {
            /// <summary>
            /// Get Player wearing a costume.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Equip a Player with a costume.
        /// </summary>
        public void Equip(Player Player)
        {
            return;
        }

        /// <summary>
        /// Unequip a costume.
        /// </summary>
        public Player Unequip()
        {
            return default;
        }
    }

    public abstract class DestinationRoomGen : AnyObject
    {
        /// <summary>
        /// Stores a destination room. Destination cannot be configured from variable - for that, use a Constant.
        /// </summary>
        internal DestinationRoom Variable(VariableData config)
        {
            return default;
        }
    }

    public abstract class DialogueUIGen : AnyObject
    {
        public Vector3 BillboardingPivotOffset
        {
            /// <summary>
            /// Returns the current Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
            /// </summary>
            set
            {
            }
        }

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
        public void SetButtonState(bool Button1Enabled, string Button1Text, bool Button2Enabled, string Button2Text, bool Button3Enabled, string Button3Text, bool Button4Enabled, string Button4Text)
        {
            return;
        }

        /// <summary>
        /// Sets the text of the target Dialogue UI’s main body for the local player. Text will truncate after 256 characters. If “Is interactive” is true, an arrow will appear in the lower right when the text has fully animated in, and the whole panel will be clickable for the player. The Next Pressed event will fire in the Dialogue UI’s board scope when this interactive panel is clicked.
        /// </summary>
        public void SetDialogueText(string BodyText, bool IsInteractive)
        {
            return;
        }
    }

    public abstract class DieGen : AnyObject
    {
        public Player PlayerRolled
        {
            /// <summary>
            /// Returns the player who rolled the dice.
            /// </summary>
            get => default;
        }

        public int Result
        {
            /// <summary>
            /// Returns the result of the dice.
            /// </summary>
            get => default;
        }

        public bool RollFinished
        {
            /// <summary>
            /// Outputs an exec when the dice finished rolling.
            /// </summary>
            get => default;
        }
    }

    public abstract class EmitterGen : AnyObject
    {
        public Color Color
        {
            /// <summary>
            /// Sets the color for the particles emitted.
            /// </summary>
            set
            {
            }
        }

        public int ColorIdDeprecated
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
        public void Start()
        {
            return;
        }

        /// <summary>
        /// Stops emitting particles.
        /// </summary>
        public void Stop()
        {
            return;
        }
    }

    public abstract class EquipmentSlotGen : AnyObject
    {
    }

    public abstract class ExplosionEmitterGen : AnyObject
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

        public void Explode()
        {
            return;
        }
    }

    public abstract class FogGen : AnyObject
    {
        public bool RoomFogModifyR1(AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared fog state to the given configuration.
        /// </summary>
        public void RoomFogModifyR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room fog state to the given configuration. This will take precedent over the room&apos;s shared fog state.
        /// </summary>
        public void RoomFogPlayerOverrideR2(Player Player, float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }
    }

    public abstract class GrabberGen : AnyObject
    {
        public (bool HasHeldObject, RecRoomObject HeldObject) HeldObjectR2
        {
            /// <summary>
            /// Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
            /// </summary>
            get => default;
        }

        public bool PlayerCanStealFromGrabberR2
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
        public bool GrabObjectR2(RecRoomObject Object, bool StealfromPlayer, bool SnaptoGrabber)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
        /// </summary>
        public RecRoomObject ReleaseR2()
        {
            return default;
        }
    }

    public abstract class GroundVehicleGen : AnyObject
    {
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

        public void AddBoostFuel(int Boostamount)
        {
            return;
        }

        public void ApplyBoost(AlternativeExec Failure)
        {
            return;
        }

        public Player GetSeatedPlayer(int Seatindex)
        {
            return default;
        }

        public void SetSeatedPlayer(int Seatindex, Player Player, AlternativeExec Failure)
        {
            return;
        }

        public void UnseatPlayer(Player Player, AlternativeExec Failure)
        {
            return;
        }

        public void UnseatPlayerFromSeat(int Seatindex, AlternativeExec Failure)
        {
            return;
        }
    }

    public abstract class GunHandleGen : AnyObject
    {
        public bool ADSEnabled
        {
            set
            {
            }
        }

        public List<string> AutoAimRolesDeprecated
        {
            set
            {
            }
        }

        public bool ContinuousFire
        {
            /// <summary>
            /// Returns whether the given gun handle will fire continuously.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether the given gun handle will fire continuously.
            /// </summary>
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

        public string RemoveAutoAimRoleDeprecated
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

        public void AddAutoAimRoleDeprecatedR1(string Role)
        {
            return;
        }

        public void ApplyRecoil(float AngleX, float AngleY, float Duration, float ReturnDuration)
        {
            return;
        }

        public Vector3 GetFiringDirection(RecRoomObject Source)
        {
            return default;
        }
    }

    public abstract class HandleGen : AnyObject
    {
        public string ControlPrompt
        {
            /// <summary>
            /// Gets the primary action label on the target handle type object
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the primary action label on the target handle type object
            /// </summary>
            set
            {
            }
        }

        public List<string> PlayerFilterTagsR2
        {
            /// <summary>
            /// Gets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle&apos;s configure menu for this to work.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle&apos;s configure menu for this to work.
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public void PlayHandleHaptics(int Duration, float Intensity)
        {
            return;
        }
    }

    public abstract class HolotarProjectorGen : AnyObject
    {
        public float CurrentTime
        {
            /// <summary>
            /// Get current playback time for Target Holotar Projector
            /// </summary>
            get => default;
            /// <summary>
            /// Set playback time for Target Projector when paused or playing
            /// </summary>
            set
            {
            }
        }

        public float Volume
        {
            /// <summary>
            /// Holotar Projector get playback volume
            /// </summary>
            get => default;
            /// <summary>
            /// Holotar Projector set playback volume
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Pasue Holotar Projector at current playback time
        /// </summary>
        public void Pause()
        {
            return;
        }

        /// <summary>
        /// Load &amp; play Holotar Recording from the start through the Target Projector. Play will always begin the clip from 0s
        /// </summary>
        public void Play(HolotarRecording Holotar)
        {
            return;
        }

        /// <summary>
        /// Resume playing the currently loaded clip on the Target Projector from the current time 
        /// </summary>
        public void Resume()
        {
            return;
        }

        /// <summary>
        /// Holotar Projector end play
        /// </summary>
        public void Stop()
        {
            return;
        }
    }

    public abstract class HolotarRecordingGen : AnyObject
    {
    }

    public abstract class HUDConstantGen : AnyObject
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
            /// <summary>
            /// Returns true if the local player has a HUD element of the given type currently enabled.
            /// </summary>
            get => default;
            set
            {
            }
        }

        public string Label
        {
            get => default;
            set
            {
            }
        }

        public bool LabelEnabled
        {
            set
            {
            }
        }

        public int MaxValue
        {
            get => default;
            set
            {
            }
        }

        public int Value
        {
            get => default;
            set
            {
            }
        }

        public bool ValueTextEnabled
        {
            set
            {
            }
        }

        /// <summary>
        /// Override all Game HUD Element properties using default values from Game HUD Element Constant input
        /// </summary>
        public void SetContent()
        {
            return;
        }
    }

    public abstract class HUDElementGen : AnyObject
    {
    }

    public abstract class InteractionVolumeGen : AnyObject
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

    public abstract class InventoryItemGen : AnyObject
    {
        public (string Name, string Description, bool SupportsUseAction, RecNetImage Image) DefinitionR2
        {
            /// <summary>
            /// Gets the friendly name, description, image, and tag names of the given inventory item.
            /// </summary>
            get => default;
        }

        public RecNetImage ImageR2
        {
            /// <summary>
            /// Gets the image of the given inventory item
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Add an inventory item to the given player.
        /// </summary>
        public (bool Success, int TotalCount) AddR2(Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// Get the count of how many of the given inventory item the given player owns.
        /// </summary>
        public int GetCountR2(Player Player, AlternativeExec<int> Complete)
        {
            return default;
        }

        /// <summary>
        /// Remove an inventory item from the given player.
        /// </summary>
        public (bool Success, int TotalCount) RemoveR2(Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// Uses the given inventory item.
        /// </summary>
        public void UseR2()
        {
            return;
        }
    }

    public abstract class InvisibleCollisionGen : AnyObject
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

    public abstract class LaserPointerGen : AnyObject
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

    public abstract class LeaderboardProjectorGen : AnyObject
    {
        public bool LeaderboardGetProjectorEnabled
        {
            /// <summary>
            /// Outputs True if the target Leaderboard object is enabled.
            /// </summary>
            get => default;
        }

        public bool LeaderboardSetProjectorEnabled
        {
            /// <summary>
            /// Sets the enabled state of the target Leaderboard object.
            /// </summary>
            set
            {
            }
        }
    }

    public abstract class LightGen : AnyObject
    {
        public float Angle
        {
            /// <summary>
            /// Returns the angle in degrees of the target Dome Light or Spotlight.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the angle of the spotlight&apos;s cone.
            /// </summary>
            set
            {
            }
        }

        public int AngleDeprecated
        {
            /// <summary>
            /// Sets the angle of the spotlight&apos;s cone.
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

        public int ColorIdDeprecated
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

        public int IntensityDeprecated
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

        public int RangeDeprecated
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
        public void TurnOff()
        {
            return;
        }

        /// <summary>
        /// Turns on the point light or the spotlight.
        /// </summary>
        public void TurnOn()
        {
            return;
        }
    }

    public abstract class MotionTrailGen : AnyObject
    {
        public Color Color
        {
            /// <summary>
            /// Returns the color of the target Motion Trail object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the color of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public bool Enabled
        {
            /// <summary>
            /// Outputs True if the target Motion Trail object is enabled.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the enabled state of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public float Lifetime
        {
            /// <summary>
            /// Returns the lifetime of the target Motion Trail object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the lifetime of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }

        public float Opacity
        {
            /// <summary>
            /// Returns the max opacity of the target Motion Trail object.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the max opacity of the target Motion Trail object.
            /// </summary>
            set
            {
            }
        }
    }

    public abstract class ObjectiveMarkerGen : AnyObject
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
        public void AttachToPlayerOrObject(Player PlayerOrObject)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public void AttachToPlayerOrObject(RecRoomObject PlayerOrObject)
        {
            return;
        }
    }

    public abstract class PathfinderGen : AnyObject
    {
        public bool EnableGroundClampingR2
        {
            get => default;
        }

        public bool GroundClampingR2
        {
            /// <summary>
            /// Toggles enabling ground clamping for the pathfinder
            /// </summary>
            set
            {
            }
        }

        public float MaxAccelerationR2
        {
            /// <summary>
            /// Gets the maximum acceleration of the Pathfinder, in meters per second squared
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the maximum linear acceleration of the Pathfinder, in meters per second squared
            /// </summary>
            set
            {
            }
        }

        public float MaxAngularSpeedR2
        {
            get => default;
            /// <summary>
            /// Sets the maximum angular speed of the Pathfinder, in degrees per second
            /// </summary>
            set
            {
            }
        }

        public float MaxLinearSpeedR2
        {
            get => default;
            /// <summary>
            /// Sets the maximum linear speed of the Pathfinder, in meters per second
            /// </summary>
            set
            {
            }
        }

        public (bool IsPathing, bool HasArrived, bool WithinSlowdownDistance) PathingStateR2
        {
            /// <summary>
            /// Gets the Pathfinder&apos;s current pathing state information
            /// * Is Pathing
            /// * Has Arrived
            /// * Within Slowdown Distance
            /// </summary>
            get => default;
        }

        public (Vector3 TargetPosition, float SlowdownDistance, float ArrivalDistance) PathingTargetR2
        {
            /// <summary>
            /// Gets the current pathing target (target position, slowdown and arrival distances) of the Pathfinder
            /// </summary>
            get => default;
        }

        public (bool IsRotating, bool HasArrived) RotationStateR2
        {
            /// <summary>
            /// Gets the Pathfinder&apos;s current rotation state information
            /// * Is Rotating
            /// * Has Arrived
            /// </summary>
            get => default;
        }

        public (Vector3 TargetDirection, float SlowdownAngle, float ArrivalAngle) RotationTargetR2
        {
            /// <summary>
            /// Gets the current pathing target (target direction, slowdown and arrival angles in degress) of the Pathfinder
            /// </summary>
            get => default;
        }

        public List<string> TagsToIgnoreR2
        {
            get => default;
            /// <summary>
            /// Sets the object tags that the pathfinder ignores on collision
            /// </summary>
            set
            {
            }
        }

        /// <summary>
        /// Starts moving the Pathfinder towards the target position
        /// It will slow down once it is within Slowdown Distance of the target
        /// And stop once it is within Arrival Distance of the target
        /// </summary>
        public void StartPathingToPositionR2(Vector3 TargetPosition, float SlowdownDistance, float ArrivalDistance)
        {
            return;
        }

        /// <summary>
        /// Starts rotating the Pathfinder towards the target direction
        /// Rotation target takes priority over automatically rotating to face the pathing direction
        /// It will slow down once it is within Slowdown Angle (in degrees) of the target
        /// And stop once it is within Arrival Angle (in degrees) of the target
        /// </summary>
        public void StartRotatingToDirectionR2(Vector3 TargetDirection, float SlowdownAngle, float ArrivalAngle)
        {
            return;
        }

        /// <summary>
        /// Stops moving the Pathfinder
        /// </summary>
        public void StopPathingR2()
        {
            return;
        }

        /// <summary>
        /// Clears the target rotation of a Pathfinder
        /// Automatic rotation to face the pathing direction will resume
        /// </summary>
        public void StopRotatingR2()
        {
            return;
        }
    }

    public abstract class PatrolPointGen : AnyObject
    {
    }

    public abstract class PistonGen : AnyObject
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

    public abstract class PlayerGen : AnyObject
    {
        public string AccountName
        {
            /// <summary>
            /// Outputs the player&apos;s Account name (e.g Coach) in a form of a string. To get a display name, use To String.
            /// </summary>
            get => default;
        }

        public string AddAimAssistTag
        {
            /// <summary>
            /// Adds a tag to the list of player tags that the provided player can target with aim assist.
            /// By default, this list contains the #player tag.
            /// </summary>
            set
            {
            }
        }

        public List<string> AimAssistTags
        {
            /// <summary>
            /// Sets the list of player tags that the provided player can target with aim assist.
            /// By default, this list contains the #player tag.
            /// </summary>
            set
            {
            }
        }

        public float AirControlPercentageR2
        {
            /// <summary>
            /// Gets the fraction from 0 to 1 of the standard air control that this player has. 
            /// This is multiplied by the air control value for the user&apos;s current state to calculate their acceleration. 
            /// Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the fraction from 0 to 1 of the standard air control that this player will have. 
            /// This is multiplied by the air control value for the user&apos;s current state to calculate their acceleration. 
            /// Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
            /// </summary>
            set
            {
            }
        }

        public Quaternion BodyOrientation
        {
            /// <summary>
            /// Outputs the rotation of a Player&apos;s body.
            /// </summary>
            get => default;
        }

        public Vector3 BodyPosition
        {
            /// <summary>
            /// Outputs the postion of a Player&apos;s body in world space.
            /// </summary>
            get => default;
        }

        public bool CanFlyR2
        {
            get => default;
            set
            {
            }
        }

        public bool CanTeleportR2
        {
            /// <summary>
            /// Returns whether a given player is allowed to teleport.
            /// 
            /// Note: The value of this property is independent of a player&apos;s platform. (This value can be true for screens players.)
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether a given player is allowed to teleport.
            /// 
            /// Note: Setting this to false does not prevent VR players from being in Teleport mode. It only prevents them from performing a teleport.
            /// </summary>
            set
            {
            }
        }

        public bool CanWallClimbR2
        {
            /// <summary>
            /// Gets whether the player can Wall Climb. Enforced via circuits.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether the player can Wall Climb. Enforced via circuits.
            /// </summary>
            set
            {
            }
        }

        public Vector3 CombatantGetGroundPositionR1
        {
            /// <summary>
            /// Outputs the ground position of an input combatant.
            /// </summary>
            get => default;
        }

        public bool CombatantGetIsAliveR1
        {
            /// <summary>
            /// Outputs True if the input combatant is alive.
            /// </summary>
            get => default;
        }

        public (Vector3 Velocity, float Speed) CombatantGetVelocityR1
        {
            /// <summary>
            /// Outputs the input combatant&apos;s current velocity and speed.
            /// </summary>
            get => default;
        }

        public int CombatantSetMaxHealthR1
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

        public bool CrouchInputEnabledR2
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

        public float CrouchSpeedR2
        {
            /// <summary>
            /// Returns the crouch speed for a given player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the crouch speed for a given player
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

        public bool ForceManualSprintR2
        {
            /// <summary>
            /// Returns whether manual sprint is required for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether manual sprint is required for a given player.
            /// 
            /// Players can choose whether they want to use auto sprint in their settings.
            /// </summary>
            set
            {
            }
        }

        public bool ForceVirtualHeightModeR2
        {
            /// <summary>
            /// Returns whether Virtual Height Mode is required for a given player
            /// </summary>
            get => default;
            /// <summary>
            /// Sets whether Virtual Height Mode is required for a given player.
            /// 
            /// Players can choose whether they want to use Physical Height Mode in their settings.
            /// </summary>
            set
            {
            }
        }

        public bool ForceVRWalkR2
        {
            /// <summary>
            /// Returns whether the given player will be forced to use walk mode if they are playing in VR. 
            /// </summary>
            get => default;
            /// <summary>
            /// Forces the given player to use walk rather than teleport mode if they are playing in VR. This is useful when you need access to their walk inputs which won&apos;t fire if they are in teleport mode. You should consider adding a warning to your room so teleport players are aware that you&apos;re going to change their movement mode.
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

        public AlternativeExec<(bool Success, int TotalBalance)> GetCurrencyBalanceDeprecatedR1
        {
            /// <summary>
            /// Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.
            /// </summary>
            set
            {
            }
        }

        public object GoToEvent
        {
            /// <summary>
            /// Sends a player to a community event.
            /// 
            /// If the event is not currently happening, shows the page for it on the watch.
            /// </summary>
            set
            {
            }
        }

        public DestinationRoom GoToRoom
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
            /// Outputs the forward vector of a Player&apos;s head.
            /// </summary>
            get => default;
        }

        public float HeadHeight
        {
            /// <summary>
            /// Outputs the height of a Player&apos;s head.
            /// </summary>
            get => default;
        }

        public Quaternion HeadOrientation
        {
            /// <summary>
            /// Outputs the rotation of a Player&apos;s head.
            /// </summary>
            get => default;
        }

        public Vector3 HeadPosition
        {
            /// <summary>
            /// Outputs the position of a Player&apos;s head in world space.
            /// </summary>
            get => default;
        }

        public Vector3 HeadUpVector
        {
            /// <summary>
            /// Outputs the up vector of a Player&apos;s head.
            /// </summary>
            get => default;
        }

        public Vector3 HeadVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player&apos;s head.
            /// </summary>
            get => default;
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

        public bool IsCustomFootstepAudioActive
        {
            get => default;
        }

        public bool IsFlying
        {
            /// <summary>
            /// Returns whether the given player is flying.
            /// </summary>
            get => default;
        }

        public (bool IsGrounded, float TimeSinceLastGrounded, RecRoomObject SurfaceObject, Vector3 SurfaceNormal) IsGrounded
        {
            /// <summary>
            /// Returns whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling. Also returns the time (in seconds) since they were last grounded, or 0 if currently grounded. Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object. Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they&apos;re not.
            /// </summary>
            get => default;
        }

        public bool IsHoldingMakerPen
        {
            /// <summary>
            /// Outputs if the Player is holding their Maker Pen.
            /// Useful for having different logic while creating.
            /// </summary>
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

        public bool IsRoomContributor
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room&apos;s contributors.
            /// </summary>
            get => default;
        }

        public bool IsRoomHost
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room&apos;s hosts.
            /// </summary>
            get => default;
        }

        public bool IsRoomMod
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room&apos;s moderators.
            /// </summary>
            get => default;
        }

        public bool IsRoomOwner
        {
            /// <summary>
            /// Outputs True if the input Player is one of the current room&apos;s owners.
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

        public bool IsWallClimbing
        {
            /// <summary>
            /// Gets whether the player is currently in the Wall Climb state.
            /// </summary>
            get => default;
        }

        public bool IsWallRunning
        {
            /// <summary>
            /// Returns whether the given player is wall running.
            /// </summary>
            get => default;
        }

        public float JumpHeightR2
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

        public bool JumpInputEnabledR2
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
            /// Outputs the direction of a Player&apos;s left hand finger.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandPosition
        {
            /// <summary>
            /// Outputs the postion of a Player&apos;s left hand in world space.
            /// </summary>
            get => default;
        }

        public Quaternion LeftHandRotation
        {
            /// <summary>
            /// Outputs the rotation of a Player&apos;s left hand.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandThumbDirection
        {
            /// <summary>
            /// Outputs the direction of a Player&apos;s left hand thumb.
            /// </summary>
            get => default;
        }

        public Vector3 LeftHandVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player&apos;s left hand.
            /// </summary>
            get => default;
        }

        public float LocalPlayerOverridePlayerVoiceRolloffR2
        {
            /// <summary>
            /// Override the voice rolloff distance of the target player as heard by the local player.
            /// 
            /// Other players&apos; perception of the target player&apos;s voice rolloff will be unaffected.
            /// </summary>
            set
            {
            }
        }

        public Color NameColor
        {
            set
            {
            }
        }

        public float NormalizedSteeringSpeedDeprecated
        {
            /// <summary>
            /// (DEPRECATED: Use PlayerGetSteeringSpeed / GetWalkSpeed) Returns the steering speed requested by the player, squared, and normalized by the square of the default walk speed.
            /// </summary>
            get => default;
        }

        public List<Player> PartyOfPlayer
        {
            /// <summary>
            /// Returns the party of the input player as List&lt;Player&gt;. If the player is not in a party, it will return a list containing only that player.
            /// </summary>
            get => default;
        }

        public Vector3 PhysicsVelocityR2
        {
            /// <summary>
            /// Gets the physics velocity for the given player. 
            /// Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources 
            /// Physics velocity will generally be reduced over time by drag from various sources.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the physics velocity for the given player.  
            /// Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources. 
            /// Physics velocity will generally be reduced over time by drag from various sources. 
            /// This node is similar Velocity Set. However, that node also zeroes the Steering Velocity.
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

        public RecNetImage ProfileImage
        {
            /// <summary>
            /// Gets the profile image of the given player.
            /// </summary>
            get => default;
        }

        public float ProneSpeedR2
        {
            /// <summary>
            /// Returns the prone speed for a given player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the prone speed for a given player
            /// </summary>
            set
            {
            }
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

        public string RemoveAimAssistTag
        {
            /// <summary>
            /// Removes a tag from the list of player tags that the provided player can target with aim assist.
            /// By default, this list contains the #player tag.
            /// </summary>
            set
            {
            }
        }

        public Vector3 RightHandFingerDirection
        {
            /// <summary>
            /// Outputs the direction of a Player&apos;s right hand finger.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandPosition
        {
            /// <summary>
            /// Outputs the postion of a Player&apos;s right hand in world space.
            /// </summary>
            get => default;
        }

        public Quaternion RightHandRotation
        {
            /// <summary>
            /// Outputs the rotation of a Player&apos;s right hand.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandThumbDirection
        {
            /// <summary>
            /// Outputs the direction of a Player&apos;s right hand thumb.
            /// </summary>
            get => default;
        }

        public Vector3 RightHandVelocity
        {
            /// <summary>
            /// Outputs the velocity of a Player&apos;s right hand.
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

        public string SeasonLeagueNameDeprecated
        {
            get => default;
        }

        public Seat Seat
        {
            get => default;
        }

        public bool ShareCameraGetIsSpawned
        {
            /// <summary>
            /// Gets whether the target player has their Share Camera spawned
            /// </summary>
            get => default;
        }

        public float SlideSpeedR2
        {
            /// <summary>
            /// Returns the slide speed for a given player.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the slide speed for a given player
            /// </summary>
            set
            {
            }
        }

        public bool SprintInputEnabledR2
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

        public float SprintSpeedR2
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

        public bool SteeringInputEnabled
        {
            get => default;
        }

        public bool SteeringInputEnabledR2
        {
            /// <summary>
            /// Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
            /// </summary>
            set
            {
            }
        }

        public float SteeringSpeed
        {
            /// <summary>
            /// Returns the steering speed requested by the player. This value represents how fast a player is wanting to move in world units.
            /// </summary>
            get => default;
        }

        public Vector3 SteeringVelocityR2
        {
            /// <summary>
            /// Sets the steering velocity for the given player.  
            /// Steering Velocity should generally be modified via Locomotion Steering Request. 
            /// Setting it directly may result in animation artifacts but can be done in special cases.
            /// </summary>
            set
            {
            }
        }

        public (bool Result, int SecondsUntilEnabled) SubscribesToRoomOwnerDeprecated
        {
            /// <summary>
            /// Outputs True if the input Player subscribes to one of the current room&apos;s owners.
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

        public float TeleportDelayR2
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

        public float TeleportDistanceR2
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
            /// Returns the offset of the given player&apos;s local time zone from UTC in seconds.
            /// </summary>
            get => default;
        }

        public Combatant ToCombatantR1
        {
            /// <summary>
            /// Covert a player or an AI value into a Combatant value.
            /// </summary>
            get => default;
        }

        public RecRoomObject UnequipFromPlayer
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

        public float VoiceRolloffDistanceR2
        {
            /// <summary>
            /// Sets the voice rolloff distance for a given player as heard by all other players.
            /// 
            /// Beyond this distance, the target player cannot be heard.
            /// </summary>
            set
            {
            }
        }

        public float Volume
        {
            /// <summary>
            /// Gets the current microphone volume from the given player.
            /// </summary>
            get => default;
        }

        public float WalkSpeedR2
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

        public bool WallRunEnabledR2
        {
            /// <summary>
            /// Gets the whether the player can Wall Run. Enforced via circuits.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the whether the player can Wall Run. Enforced via circuits.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUIEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player&apos;s world UI.
            /// </summary>
            get => default;
        }

        public Color WorldUIPrimaryBarColor
        {
            /// <summary>
            /// Returns the color of the given player&apos;s primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the primary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUIPrimaryBarEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player&apos;s primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the primary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUIPrimaryBarMaxValue
        {
            /// <summary>
            /// Returns the max value of the given player&apos;s primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the max value of the primary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUIPrimaryBarValue
        {
            /// <summary>
            /// Returns the value of the given player&apos;s primary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the primary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public Color WorldUISecondaryBarColor
        {
            /// <summary>
            /// Returns the color of the given player&apos;s secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the secondary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUISecondaryBarEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player&apos;s secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the secondary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUISecondaryBarMaxValue
        {
            /// <summary>
            /// Returns the max value of the given player&apos;s secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the max value of the secondary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public int WorldUISecondaryBarValue
        {
            /// <summary>
            /// Returns the value of the given player&apos;s secondary bar in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the secondary bar in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public Color WorldUITextColor
        {
            /// <summary>
            /// Returns the color of the given player&apos;s text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the color of the text in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public bool WorldUITextEnabled
        {
            /// <summary>
            /// Returns the enabled state of the given player&apos;s text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the enabled state of the text in the given player&apos;s active world UI.
            /// </summary>
            set
            {
            }
        }

        public string WorldUITextValue
        {
            /// <summary>
            /// Returns the value of the given player&apos;s text in their current world UI.
            /// </summary>
            get => default;
            /// <summary>
            /// Set the value of the text in the given player&apos;s active world UI.
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
        /// Adds a tag to the input object or player.
        /// </summary>
        public void AddTag(string Tag)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public void AddTags(List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Award some amount to the Player&apos;s balance of one room currency. Configure this chip to set the affected currency.
        /// </summary>
        public (bool Success, int TotalBalance) AwardCurrencyDeprecatedR1(int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Clears any active screen vignette on the given player.
        /// </summary>
        public void ClearPlayerVignette()
        {
            return;
        }

        /// <summary>
        /// Clear the UI configuration displayed above a given player.
        /// </summary>
        public void ClearPlayerWorldUI()
        {
            return;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public (int Health, int Shield, int MaxHealth) CombatantGetHealthR1()
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public void CombatantReceiveDamageR1(int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public void CombatantSetHealthR1(int Health)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        public bool EquipObjectToDominantHand(RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        public bool EquipObjectToOffHand(RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// Equips Share Camera to a player&apos;s dominant hand if the player is not already holding the Share Camera.
        /// Returns success if the target player is already holding their Share Camera in either hand.
        /// </summary>
        public bool EquipShareCamera(bool ForceEquip)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Player Closest, int ClosestIndex, float Distance) GetClosest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Player Farthest, int FarthestIndex, float Distance) GetFarthest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(AI ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Combatant ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public Quaternion GetRotationInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public Quaternion GetRotationInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Grants the contents of a Reward to the specified Player.
        /// </summary>
        public bool GrantReward(Reward Reward, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public bool HasTag(string Tag)
        {
            return default;
        }

        public bool HolsterObject(RecRoomObject ObjectToHolster, bool ForceHolster, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public void IfHasTag(string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// The &quot;Should Run&quot; port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
        /// </summary>
        public void IfLocalPlayerShouldRun(AlternativeExec ShouldNotRun)
        {
            return;
        }

        /// <summary>
        /// Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
        /// </summary>
        public void IfPlayerHasRoleR1(string Role, AlternativeExec DoesNotHaveRole)
        {
            return;
        }

        /// <summary>
        /// Outputs if a player is the local player or not.
        /// </summary>
        public void IfPlayerIsLocal(AlternativeExec IsNotLocal)
        {
            return;
        }

        /// <summary>
        /// Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
        /// </summary>
        public void IfPlayerIsValid(AlternativeExec IsNotValid)
        {
            return;
        }

        /// <summary>
        /// If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
        /// </summary>
        public void IfPlayerIsValidAndLocal(AlternativeExec IsNotValid, AlternativeExec IsValidAndNotLocal)
        {
            return;
        }

        /// <summary>
        /// Get the leaderboard stat for the given player on the given stat channel.
        /// </summary>
        public int LeaderboardGetPlayerStat(int Channel, AlternativeExec<int> OnGetStatComplete)
        {
            return default;
        }

        /// <summary>
        /// Clears the local player&apos;s override of target player&apos;s voice rolloff distance.
        /// 
        /// The local player&apos;s reckoning of the target player&apos;s voice rolloff returns to being based on that player&apos;s voice rolloff distance property.
        /// </summary>
        public void LocalPlayerClearPlayerVoiceRolloffOverrideR2()
        {
            return;
        }

        /// <summary>
        /// Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
        /// </summary>
        public void LocalPlayerDisableInteractionWithTargetPlayer()
        {
            return;
        }

        /// <summary>
        /// Enables the local player to interact with the provided player. To respond to interactions, configure a &quot;Event Receiver&quot; chip for the &quot;Local Player... Interaction&quot; events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player&apos;s interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
        /// </summary>
        public void LocalPlayerEnableInteractionWithTargetPlayer(float RequiredHoldDuration, string Prompt)
        {
            return;
        }

        /// <summary>
        /// Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
        /// </summary>
        public void LocalPlayerSetPlayerNametagVisibility(bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Adds a Role to a Player.
        /// </summary>
        public void AddRoleR1(string Value)
        {
            return;
        }

        /// <summary>
        /// Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public bool AwardXP(int Amount, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Clears any subtitle which is currently being displayed for the given player.
        /// </summary>
        public void ClearCurrentSubtitle()
        {
            return;
        }

        /// <summary>
        /// For the target player, equip the specified Inventory Item to the specified Inventory Equipment Slot. If the Slot is of Inventory type, this chip will take effect whether or not the Slot is enabled, but the Slot must then be enabled separately.
        /// </summary>
        public bool EquipInventoryItemR2(InventoryItem InventoryItem, EquipmentSlot InventoryEquipmentSlot, AlternativeExec<bool> OnEquipComplete)
        {
            return default;
        }

        /// <summary>
        /// Gets the list of player tags that the provided player can target with aim assist.
        /// By default, this list contains the #player tag.
        /// </summary>
        public List<string> GetAimAssistTags()
        {
            return default;
        }

        /// <summary>
        /// For the target player, get whether the specified equipment slot is enabled.
        /// </summary>
        public bool GetEquipmentSlotIsEnabledR2(EquipmentSlot EquipmentSlot)
        {
            return default;
        }

        /// <summary>
        /// Outputs if a Player is authority of the input object.
        /// </summary>
        public bool GetIsAuthorityOf(RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// Returns the voice rolloff distance for the target player, as reckoned by the local player.
        /// 
        /// If the local player has set an override for the target player&apos;s voice rolloff distance, the &quot;Has Local Override&quot; bool returns true, and the overridden value is returned.
        /// 
        /// Otherwise, the synced value of that player&apos;s voice rolloff distance is returned, and the bool returns false.
        /// </summary>
        public (float VoiceRolloffDistance, bool HasLocalOverride) GetVoiceRolloffDistanceR2()
        {
            return default;
        }

        public bool HasPurchasedRoomOfferR2(RoomOffer RoomOffer, AlternativeExec<bool> OnPlayerHasPurchasedRoomOfferComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player has the input role.
        /// </summary>
        public bool HasRoleR1(string Value)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player owns at least one of the given inventory item.
        /// </summary>
        public bool OwnsInventoryItemR2(InventoryItem InventoryItem, AlternativeExec<bool> Complete)
        {
            return default;
        }

        public bool OwnsRoomKeyR1(RoomKey RoomKey, AlternativeExec<bool> OnPlayerOwnsRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a prompt to the specified player containing the prompt title and body, along with each of the answer choices on its own line. The player can choose a response and hit &quot;ok,&quot; triggering the On Prompt Complete event. Since there is a delay between sending a prompt and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        /// </summary>
        public (bool Success, Player ReceivingPlayer, string Response, int ResponseIndex) PromptMultipleChoice(string PromptTitle, string PromptBody, List<string> AnswerChoices, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response, int ResponseIndex)> OnPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a prompt to the specified player where they can input text, which is then returned by this chip&apos;s output. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        /// </summary>
        public (bool Success, Player ReceivingPlayer, string Response) PromptText(string PromptTitle, string PromptBody, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response)> OnPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// Removes the input role from a target player.
        /// </summary>
        public void RemoveRoleR1(string Value)
        {
            return;
        }

        /// <summary>
        /// Resets the color of the given player&apos;s name tag to the default color.
        /// </summary>
        public void ResetNameColor()
        {
            return;
        }

        /// <summary>
        /// Enables the specified equipment slot on the target player
        /// </summary>
        public void SetEquipmentSlotIsEnabledR2(EquipmentSlot EquipmentSlot, bool IsEnabled)
        {
            return;
        }

        /// <summary>
        /// Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
        /// </summary>
        public void ShowSubtitle(string Subtitle, float Duration, int Priority)
        {
            return;
        }

        /// <summary>
        /// For the specified player, unequip anything which is equipped to the specified slot. If the slot is of Inventory type, this chip will take effect whether or not the slot is enabled.
        /// </summary>
        public bool UnequipFromSlotR2(EquipmentSlot EquipmentSlot, AlternativeExec<bool> OnUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// For the target player, unequip the specified Inventory Item from any slot to which it is equipped.
        /// </summary>
        public bool UnequipInventoryItemR2(InventoryItem InventoryItem, AlternativeExec<bool> OnUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal Player Variable(VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal Player VariableDeprecated(VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Remove a player from the radio channel they are in
        /// </summary>
        public void RemovePlayerFromRadioChannel()
        {
            return;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public void RemoveTag(string Tag)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public void RemoveTags(List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public void RequestVelocitySetOverDuration(float Multiplier, Vector3 Velocity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Reset the player&apos;s active world UI to its default values.
        /// </summary>
        public void ResetPlayerWorldUI()
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool Respawn(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool Respawn(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void RespawnDeprecated(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void RespawnDeprecated(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        public void RespawnPointRespawnPlayer(bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }

        /// <summary>
        /// Clears the given player&apos;s local room background objects state override.
        /// </summary>
        public void RoomBackgroundObjectsClearPlayerOverrideR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Clears the given player&apos;s local room fog state override.
        /// </summary>
        public void RoomFogClearPlayerOverrideR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Clears the given player&apos;s local room skydome state override.
        /// </summary>
        public void RoomSkydomeClearPlayerOverrideR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Clears the given player&apos;s local room sun state override.
        /// </summary>
        public void RoomSunClearPlayerOverrideR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Start a screen shake effect for the given player. This will have no effect on VR players.
        /// </summary>
        public void SetCameraShake(float Intensity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
        /// </summary>
        public void SetVignette(float Time, Color Color, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void SetPositionDeprecated(Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetPositionInReferenceObjectSpace(Vector3 Position, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetPositionInReferenceObjectSpace(Vector3 Position, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetRotation(Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetRotation(Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Vector3 Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Vector3 Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Quaternion Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Quaternion Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetTransform(Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetTransform(Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Vector3 Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Vector3 Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Quaternion Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Quaternion Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Shows a player a banner notification. Appearance can be customized in the config menu!
        /// </summary>
        public void ShowBannerNotification(string Title, string MainText, float Duration)
        {
            return;
        }

        /// <summary>
        /// Prints the input notification to the given player&apos;s screen.
        /// </summary>
        public void ShowNotification<T>(string Value)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public void ShowRewardNotification(Reward Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public void ShowRewardNotification(List<Reward> Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Stop any current screen shake for the given player.
        /// </summary>
        public void StopCameraShake()
        {
            return;
        }

        public List<RecRoomObject> UnequipFromSlotsR1(bool DominantHand, bool OffHand, bool LeftHipHolster, bool RightHipHolster, bool ShoulderHolster)
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityAdd(float Multiplier, Vector3 Velocity, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityAddDeprecated(float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target&apos;s velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityReflect(float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocitySet(float Multiplier, Vector3 Velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocitySetDeprecated(float Speed, Vector3 Direction)
        {
            return;
        }
    }

    public abstract class PlayerOutfitSlotGen : AnyObject
    {
    }

    public abstract class PlayerSpawnPointV2Gen : AnyObject
    {
        public bool Active
        {
            get => default;
            set
            {
            }
        }

        public bool AddAvoidRoleR1(string Role)
        {
            return default;
        }

        public void AddAvoidTag(string Tag)
        {
            return;
        }

        public bool AddSpawnRoleR1(string Role)
        {
            return default;
        }

        public void AddSpawnTag(string Tag)
        {
            return;
        }

        public void RemoveAvoidRoleR1(string Role)
        {
            return;
        }

        public void RemoveAvoidTag(string Tag)
        {
            return;
        }

        public void RemoveSpawnRoleR1(string Role)
        {
            return;
        }

        public void RemoveSpawnTag(string Tag)
        {
            return;
        }

        public void RespawnPlayerAtRespawnPoint(Player Player, bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }
    }

    public abstract class PlayerWorldUIGen : AnyObject
    {
        /// <summary>
        /// Displays a target UI configuration above a given player.
        /// </summary>
        public void DisplayPlayerWorldUI(Player Player)
        {
            return;
        }
    }

    public abstract class ProjectileLauncherGen : AnyObject
    {
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

        public void FireProjectile(Vector3 Direction)
        {
            return;
        }
    }

    public abstract class QuickChatTableGen : AnyObject
    {
        /// <summary>
        /// Enable or disable the specified Quick Chat Table for the specified player. If a different set of custom Quick Chat phrases is already enabled, this will overwrite it.
        /// </summary>
        public void SetEnabled(Player Player, bool Enabled)
        {
            return;
        }
    }

    public abstract class RangedWeaponGen : AnyObject
    {
        public Color Color
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

        public int LimbDamage
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

    public abstract class RecNetImageGen : AnyObject
    {
    }

    public abstract class RecRoomObjectGen : AnyObject
    {
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
            /// Outputs True on the player&apos;s machine who has authority of the input.
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

        public RecRoomObject RootObject
        {
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
        /// Adds a tag to the input object or player.
        /// </summary>
        public void AddTag(string Tag)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public void AddTags(List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
        /// </summary>
        public bool AngularVelocityAdd(Vector3 AngularVelocity, float SpeedMultiplier, float MaxAngularSpeed)
        {
            return default;
        }

        public void AngularVelocityAddDeprecated(Vector3 Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        public void AngularVelocityAddDeprecated(Quaternion Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        /// <summary>
        /// Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
        /// </summary>
        public bool AngularVelocitySet(Vector3 AngularVelocity, float SpeedMultiplier)
        {
            return default;
        }

        public void AngularVelocitySetDeprecated(Vector3 Rotation, float VelocityMultiplier)
        {
            return;
        }

        public void AngularVelocitySetDeprecated(Quaternion Rotation, float VelocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float Distance(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public float DistanceDeprecated(Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Converts the input Rec Room Object to the object&apos;s subtype.
        /// </summary>
        internal T FromRecRoomObject<T>()
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Player Closest, int ClosestIndex, float Distance) GetClosest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Player Farthest, int FarthestIndex, float Distance) GetFarthest(List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(AI ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Combatant ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public Vector3 GetPositionInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public Quaternion GetRotationInReferenceObjectSpace(RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public Quaternion GetRotationInReferenceObjectSpace(Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public bool HasTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public void IfHasTag(string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// Resets an object.
        /// </summary>
        public void Reset()
        {
            return;
        }

        internal RecRoomObject Variable(VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public void RemoveTag(string Tag)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public void RemoveTags(List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// If the target object was spawned by a replicator, it will be despawned and returned to the pool. If not, the chip will no-op.
        /// </summary>
        public void ReplicatorReturnObjectR2()
        {
            return;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public void RequestVelocitySetOverDuration(float Multiplier, Vector3 Velocity, float Duration)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool Respawn(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool Respawn(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void RespawnDeprecated(Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void RespawnDeprecated(Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public void SetPositionDeprecated(Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetPositionInReferenceObjectSpace(Vector3 Position, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetPositionInReferenceObjectSpace(Vector3 Position, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetRotation(Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetRotation(Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Vector3 Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Vector3 Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Quaternion Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public bool SetRotationInReferenceObjectSpace(Quaternion Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetTransform(Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public bool SetTransform(Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Vector3 Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Vector3 Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Quaternion Rotation, Player ReferenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public bool SetTransformInReferenceObjectSpace(Vector3 Position, Quaternion Rotation, RecRoomObject ReferenceObject)
        {
            return default;
        }

        public void SpawnerInternalStartSpawningR1(int Amountofobjectstospawn, float Timebetweenspawns, Vector3 SpawnPosition)
        {
            return;
        }

        public void SpawnerResetR1()
        {
            return;
        }

        public bool UnequipObject()
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityAdd(float Multiplier, Vector3 Velocity, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityAddDeprecated(float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target&apos;s velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocityReflect(float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocitySet(float Multiplier, Vector3 Velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public void VelocitySetDeprecated(float Speed, Vector3 Direction)
        {
            return;
        }
    }

    public abstract class ReplicatorGen : AnyObject
    {
        public int ActiveObjectsCountR2
        {
            /// <summary>
            /// Returns the total number of objects that have been spawned by the target replicator and are currently active.
            /// </summary>
            get => default;
        }

        public List<RecRoomObject> ActiveObjectsR2
        {
            /// <summary>
            /// Returns the list of objects that have been spawned by the target replicator and are currently active.
            /// </summary>
            get => default;
        }

        /// <summary>
        /// Spawns a copy of the object assigned to the target replicator at the position and orientation specified. If “Assign to Player” is true, the resulting object will be assigned to the specified player such that no other players can interact with it, and the object will be automatically returned when that player leaves the room. 
        /// 
        /// When the object is spawned, On Spawn Complete will fire and pass through an object reference. If it fails, such as when the limit of objects has been hit, the object reference will be invalid and the Success bool will be false.
        /// </summary>
        public (RecRoomObject Object, bool Success) SpawnNextObjectR2(Vector3 Position, Quaternion Orientation, bool AssigntoPlayer, Player Player, AlternativeExec<(RecRoomObject Object, bool Success)> OnSpawnComplete)
        {
            return default;
        }
    }

    public abstract class RewardGen : AnyObject
    {
    }

    public abstract class RoomCurrencyGen : AnyObject
    {
        /// <summary>
        /// Award some amount to the Player&apos;s balance of the given room currency.
        /// </summary>
        public (bool Success, int TotalBalance) AwardCurrencyR1(Player Player, int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Returns the given player&apos;s balance of the given room currency.
        /// </summary>
        public (bool Success, int TotalBalance) GetCurrencyBalanceR1(Player Player, AlternativeExec<(bool Success, int TotalBalance)> OnGetBalanceComplete)
        {
            return default;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public void ShowPurchasePromptR1(Player Player)
        {
            return;
        }
    }

    public abstract class RoomDoorGen : AnyObject
    {
        public DestinationRoom DestinationR1
        {
            get => default;
            set
            {
            }
        }

        public bool LockedR1
        {
            get => default;
            set
            {
            }
        }
    }

    public abstract class RoomKeyGen : AnyObject
    {
        /// <summary>
        /// Unlocks a room key for the target player. Multiple award room key requests from the same client are sent in bulk with a one-second cooldown.
        /// The Success port will be TRUE if the key was successfully unlocked for the player or if the player previously owned the key. If the key could not be awarded the Success port will be FALSE.
        /// Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public bool AwardRoomKeyR1(Player Player, AlternativeExec<bool> OnAwardRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public void ShowPurchasePromptR1(Player Player)
        {
            return;
        }
    }

    public abstract class RoomLevelHUDGen : AnyObject
    {
    }

    public abstract class RoomOfferGen : AnyObject
    {
        public void ShowPurchasePromptR2(Player Player)
        {
            return;
        }
    }

    public abstract class RotatorGen : AnyObject
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

    public abstract class SeatGen : AnyObject
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
        public void SetSeatedPlayer(Player Player, AlternativeExec Fail)
        {
            return;
        }

        /// <summary>
        /// Unseats a currently seated player on a target Seat.
        /// </summary>
        public void UnseatPlayer()
        {
            return;
        }
    }

    public abstract class SFXGen : AnyObject
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
        public void Play()
        {
            return;
        }

        /// <summary>
        /// Stops the sound currently playing from an SFX object.
        /// </summary>
        public void Stop()
        {
            return;
        }
    }

    public abstract class SkydomeGen : AnyObject
    {
        public bool RoomSkydomeModifyR1(AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared skydome state to the given configuration.
        /// </summary>
        public void RoomSkydomeModifyR2(float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room skydome state to the given configuration. This will take precedent over the room&apos;s shared skydome state.
        /// </summary>
        public void RoomSkydomePlayerOverrideR2(Player Player, float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }
    }

    public abstract class StateGen : AnyObject
    {
        /// <summary>
        /// Transitions to the given state in the current state machine.
        /// </summary>
        public void GoToState()
        {
            return;
        }
    }

    public abstract class StorefrontGen : AnyObject
    {
        public bool IsEnabledR2
        {
            get => default;
            set
            {
            }
        }

        public List<RoomOffer> OffersListR2
        {
            get => default;
            set
            {
            }
        }
    }

    public abstract class StudioObjectGen : AnyObject
    {
        public StudioFunctionData StudioFunction
        {
            set
            {
            }
        }

        public void StudioEventSender(string Event)
        {
            return;
        }

        public void StudioEventSenderBool(string Event, bool Value)
        {
            return;
        }

        public void StudioEventSenderFloat(string Event, float Value)
        {
            return;
        }

        public void StudioEventSenderInt(string Event, int Value)
        {
            return;
        }

        public void StudioEventSenderString(string Event, string Value)
        {
            return;
        }

        public void StudioEventSenderStringBool(string Event, string Value0, bool Value1)
        {
            return;
        }

        public void StudioEventSenderStringFloat(string Event, string Value0, float Value1)
        {
            return;
        }

        public void StudioEventSenderStringInt(string Event, string Value0, int Value1)
        {
            return;
        }

        public void StudioEventSenderStringString(string Event, string Value0, string Value1)
        {
            return;
        }

        public bool GetPropertyBool(string Property)
        {
            return default;
        }

        public Color GetPropertyColor(string Property)
        {
            return default;
        }

        public float GetPropertyFloat(string Property)
        {
            return default;
        }

        public int GetPropertyInt(string Property)
        {
            return default;
        }

        public Quaternion GetPropertyQuaternion(string Property)
        {
            return default;
        }

        public string GetPropertyString(string Property)
        {
            return default;
        }

        public Vector3 GetPropertyVector3(string Property)
        {
            return default;
        }
    }

    public abstract class SunGen : AnyObject
    {
        public bool RoomSunModifyR1(SunDirection SunDirection, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared sun state to the given configuration.
        /// </summary>
        public void RoomSunModifyR2(SunDirection SunDirection, float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room sun state to the given configuration. This will take precedent over the room&apos;s shared sun state.
        /// </summary>
        public void RoomSunPlayerOverrideR2(SunDirection SunDirection, Player Player, float BlendTime, AlternativeExec BlendFinished)
        {
            return;
        }
    }

    public abstract class SunDirectionGen : AnyObject
    {
    }

    public abstract class SwingHandleGen : AnyObject
    {
        public bool IsSwinging
        {
            get => default;
        }
    }

    public abstract class TextGen : AnyObject
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

        public int ColorIdDeprecated
        {
            /// <summary>
            /// Sets the color for a Text object.
            /// </summary>
            set
            {
            }
        }

        public int Material
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

    public abstract class TextScreenGen : AnyObject
    {
        public void ClearScreen()
        {
            return;
        }

        public void PrintTextToScreen(string Text, Color Color)
        {
            return;
        }
    }

    public abstract class ToggleButtonGen : AnyObject
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

        public bool IsPressedDeprecated
        {
            /// <summary>
            /// Sets a Toggle Button state to pressed.
            /// </summary>
            set
            {
            }
        }
    }

    public abstract class TouchpadGen : AnyObject
    {
        public (bool IsTouchActive, Vector3 TouchPosition, Vector3 WorldPosition) ActiveTouch
        {
            /// <summary>
            /// Get the active touch position from the local player&apos;s interaction
            /// </summary>
            get => default;
        }

        public string InteractionLabel
        {
            /// <summary>
            /// Sets the interaction label (used by Screen players)
            /// </summary>
            get => default;
            /// <summary>
            /// Gets the interaction label (used by Screen players)
            /// </summary>
            set
            {
            }
        }

        public bool IsEnabled
        {
            /// <summary>
            /// Sets if the Touchpad can be interacted with or output touch events
            /// </summary>
            get => default;
            /// <summary>
            /// Gets if the Touchpad can be interacted with or output touch events
            /// </summary>
            set
            {
            }
        }
    }

    public abstract class TriggerHandleGen : AnyObject
    {
        public string ControlPromptDeprecated
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
    }

    public abstract class TriggerVolumeGen : AnyObject
    {
        public string FilterRoleR1
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

        public int ObjectCount
        {
            /// <summary>
            /// Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
            /// </summary>
            get => default;
        }

        public List<string> ObjectFilterTags
        {
            /// <summary>
            /// Gets the tags that are being used as the object filter for a Trigger Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the tags that are being used as the object filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
            /// </summary>
            set
            {
            }
        }

        public List<RecRoomObject> Objects
        {
            /// <summary>
            /// Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
            /// </summary>
            get => default;
        }

        public int PlayerCount
        {
            /// <summary>
            /// Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
            /// </summary>
            get => default;
        }

        public List<string> PlayerFilterTagsR2
        {
            /// <summary>
            /// Gets the tags that are being used as the player filter for a Trigger Volume.
            /// </summary>
            get => default;
            /// <summary>
            /// Sets the tags that are being used as the player filter for a Trigger  Volume. A player is considered by the Trigger Volume, if they have any of the tags in this list.
            /// </summary>
            set
            {
            }
        }

        public List<Player> Players
        {
            /// <summary>
            /// Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
            /// </summary>
            get => default;
        }
    }

    public abstract class VectorComponentGen : AnyObject
    {
        /// <summary>
        /// Gets the direction and magnitude of the Vector Component.
        /// </summary>
        public Vector3 GetVector(float Magnitude)
        {
            return default;
        }
    }

    public abstract class WelcomeMatGen : AnyObject
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