using System.Collections.Generic;
using UnityEngine;
using RRCGSource;

namespace RRCGGenerated
{
    public class ChipsGen
    {
        /// <summary>
        /// Outputs the magnitude of the number. Is always positive.
        /// </summary>
        public static float AbsoluteValue(float Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the magnitude of the number. Is always positive.
        /// </summary>
        public static int AbsoluteValue(int Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the arccosine of a number.
        /// </summary>
        public static float Acos(float Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static int Add(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static float Add(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static Vector3 Add(params Vector3[] Value)
        {
            return default;
        }

        /// <summary>
        /// Adds a tag to the input object or player.
        /// </summary>
        public static void AddTag(Player Target, string Tag)
        {
            return;
        }

        /// <summary>
        /// Adds a tag to the input object or player.
        /// </summary>
        public static void AddTag(RecRoomObject Target, string Tag)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public static void AddTags(Player Target, List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public static void AddTags(RecRoomObject Target, List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Outputs the current line of sight parameters from the input AI.
        /// </summary>
        public static (string VisionType, float VisionRange, float VisionConeAngle, float HearingRange) AIGetLineofSightParameters(AI AI)
        {
            return default;
        }

        /// <summary>
        /// Outputs the current combat target of an inputted AI.
        /// </summary>
        public static Combatant AIGetTarget(AI AI)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, AI Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, Combatant Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, PatrolPoint Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineofSightToTarget(AI AI, Vector3 Target)
        {
            return default;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, AI LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, Combatant LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, RecRoomObject LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, PatrolPoint LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, Player LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAt(AI AI, Vector3 LookTarget, bool LookTargetisDirection)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, AI Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, Combatant Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, RecRoomObject Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, PatrolPoint Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, Player Target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathTo(AI AI, Vector3 Target)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotate(AI AI, float Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotate(AI AI, int Rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotate(AI AI, Vector3 Rotation)
        {
            return;
        }

        /// <summary>
        /// Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
        /// </summary>
        public static void AISetLineofSightParameters(AI AI, string VisionType, float VisionRange, float VisionConeAngle, float HearingRange, bool RequireLoSfortargeting)
        {
            return;
        }

        /// <summary>
        /// Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
        /// </summary>
        public static void AISetPathingSpeed(AI AI, float Speed)
        {
            return;
        }

        /// <summary>
        /// Set an AIs Path Point.
        /// </summary>
        public static void AISetPatrolPoint(AI AI, PatrolPoint PatrolPoint)
        {
            return;
        }

        /// <summary>
        /// Sets the input AI’s current target.
        /// </summary>
        public static void AISetTarget(AI AI, Combatant Target)
        {
            return;
        }

        /// <summary>
        /// RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
        /// </summary>
        public static void AIStartCombatBehavior(AI AI)
        {
            return;
        }

        /// <summary>
        /// Tells the input AI to stop its C# defined combat behavior.
        /// </summary>
        public static void AIStopCombatBehavior(AI AI)
        {
            return;
        }

        /// <summary>
        /// Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
        /// </summary>
        public static void AIStopLooking(AI AI)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static AI AIVariable(AI Port0)
        {
            return default;
        }

        /// <summary>
        /// Choose from a selection of ambient audio tracks, for use with the Audio Player.
        /// </summary>
        public static Audio AmbienceConstant()
        {
            return default;
        }

        /// <summary>
        /// Outputs True when all inputs are True. If any input is False, it outputs False.
        /// </summary>
        public static bool And(params bool[] Input)
        {
            return default;
        }

        /// <summary>
        /// Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
        /// </summary>
        public static bool AngularVelocityAdd(RecRoomObject Target, Vector3 AngularVelocity, float SpeedMultiplier, float MaxAngularSpeed)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AngularVelocityAddDeprecated(RecRoomObject Target, Vector3 Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AngularVelocityAddDeprecated(RecRoomObject Target, Quaternion Rotation, float VelocityMultiplier, float MaxAngularVelocityApplied)
        {
            return;
        }

        /// <summary>
        /// Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
        /// </summary>
        public static bool AngularVelocitySet(RecRoomObject Target, Vector3 AngularVelocity, float SpeedMultiplier)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AngularVelocitySetDeprecated(RecRoomObject Target, Vector3 Rotation, float VelocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AngularVelocitySetDeprecated(RecRoomObject Target, Quaternion Rotation, float VelocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Returns whether or not the Animation Controller is currently playing.
        /// </summary>
        public static bool AnimationGetIsPlaying(AnimationController Animator)
        {
            return default;
        }

        /// <summary>
        /// Returns the normalized speed of the given Animation Controller.
        /// </summary>
        public static float AnimationGetSpeed(AnimationController Animator)
        {
            return default;
        }

        /// <summary>
        /// Pauses the Animation Controller. The Animation Controller resumes at the same moment next time play is activated.
        /// </summary>
        public static void AnimationPause(AnimationController Animator)
        {
            return;
        }

        /// <summary>
        /// Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller's configuration menu.
        /// </summary>
        public static void AnimationPlay(AnimationController Animator)
        {
            return;
        }

        /// <summary>
        /// Sets the Animation Controller's animation to a specific frame number.
        /// </summary>
        public static void AnimationSetFrame(AnimationController Animator, int FrameNumber)
        {
            return;
        }

        /// <summary>
        /// Sets the Animation Controller's play speed. Default value is 1. Negative values play the animation in reverse.
        /// </summary>
        public static void AnimationSetSpeed(AnimationController Animator, float Speed)
        {
            return;
        }

        /// <summary>
        /// Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
        /// </summary>
        public static void AnimationStop(AnimationController Animator)
        {
            return;
        }

        /// <summary>
        /// Computes the arcsine of a number.
        /// </summary>
        public static float Asin(float Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the arctangent of a number.
        /// </summary>
        public static float Atan(float Value)
        {
            return default;
        }

        /// <summary>
        /// Computes the 2-argument arctangent of a number.
        /// </summary>
        public static float Atan2(float Y, float X)
        {
            return default;
        }

        /// <summary>
        /// Returns the length in seconds of the given audio reference.
        /// </summary>
        public static float AudioGetLength(Audio Audio)
        {
            return default;
        }

        /// <summary>
        /// Returns the most recent audio reference that the target Audio Player has started playing.
        /// </summary>
        public static Audio AudioPlayerGetAudio(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the furthest distance from the target Audio Player that the audio can be heard from.
        /// </summary>
        public static float AudioPlayerGetMaxRolloffDistance(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Audio Player is playing.
        /// </summary>
        public static bool AudioPlayerGetPlaying(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed multiplier of the target Audio Player.
        /// </summary>
        public static float AudioPlayerGetSpeed(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the current time stamp of the target Audio Player in seconds.
        /// </summary>
        public static float AudioPlayerGetTimeStamp(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the volume multiplier of the target Audio Player.
        /// </summary>
        public static float AudioPlayerGetVolume(AudioPlayer Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AudioPlayerPause(AudioPlayer Target)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AudioPlayerPlay(AudioPlayer Target, Audio Audio)
        {
            return;
        }

        /// <summary>
        /// Sets the maximum distance that audio from the target Audio Player can be heard from.
        /// </summary>
        public static void AudioPlayerSetMaxRolloffDistance(AudioPlayer Target, float MaxRolloffDistance)
        {
            return;
        }

        /// <summary>
        /// Sets the speed multiplier that the target Audio Player will play at.
        /// </summary>
        public static void AudioPlayerSetSpeed(AudioPlayer Target, float Speed)
        {
            return;
        }

        /// <summary>
        /// Sets the time stamp of the target Audio Player in seconds.
        /// </summary>
        public static void AudioPlayerSetTimeStamp(AudioPlayer Target, float TimeStamp)
        {
            return;
        }

        /// <summary>
        /// Sets the volume multiplier that the target Audio Player will play at.
        /// </summary>
        public static void AudioPlayerSetVolume(AudioPlayer Target, float Volume)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void AudioPlayerStop(AudioPlayer Target)
        {
            return;
        }

        /// <summary>
        /// Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public static bool AwardConsumable(Consumable Consumable, Player Player, int Quantity, AlternativeExec<bool> OnAwardConsumableComplete)
        {
            return default;
        }

        /// <summary>
        /// Award some amount to the Player's balance of one room currency. Configure this chip to set the affected currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrency(Player Player, int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Award some amount to the Player's balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrencyNew(RoomCurrency Currency, Player Player, int Amount, AlternativeExec<(bool Success, int TotalBalance)> OnAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Unlocks a room key for the target player. Multiple award room key requests from the same client are sent in bulk with a one-second cooldown.
        public static bool AwardRoomKey(RoomKey RoomKey, Player Player, AlternativeExec<bool> OnAwardRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Defines values for the room's background objects.
        /// </summary>
        public static BackgroundObjects BackgroundObjectsConstant()
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target Beacon object.
        /// </summary>
        public static Color BeaconGetColor(Beacon Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Beacon object is enabled.
        /// </summary>
        public static bool BeaconGetEnabled(Beacon Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the height of the target Beacon object.
        /// </summary>
        public static float BeaconGetHeight(Beacon Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color of the target Beacon object.
        /// </summary>
        public static void BeaconSetColor(Beacon Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of the target Beacon object.
        /// </summary>
        public static void BeaconSetEnabled(Beacon Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the height of the target Beacon object.
        /// </summary>
        public static void BeaconSetHeight(Beacon Target, float Height)
        {
            return;
        }

        /// <summary>
        /// Computes a bitwise AND. The result has a bit set for every bit that is set in both of the inputs.
        /// </summary>
        public static int BitAnd(int Port0, int Port1)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of zeros at the beginning (most significant side) of the binary representation of an integer.
        /// </summary>
        public static int BitLeadingZeros(int Value)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise NAND. (NOT AND) The result has a bit set for every bit that is not set in either of the inputs.
        /// </summary>
        public static int BitNand(int Port0, int Port1)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise NOT. The result has a bit set for every bit that is not set in the input.
        /// </summary>
        public static int BitNot(int Port0)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise OR. The result has a bit set for every bit that is set in either of the inputs.
        /// </summary>
        public static int BitOr(int Port0, int Port1)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of set bits in the binary representation of an integer.
        /// </summary>
        public static int BitPopCount(int Value)
        {
            return default;
        }

        /// <summary>
        /// Rotates digits in the binary representation of an integer to the left. As the leftmost bits fall off, they are used to fill the rightmost bits.
        /// </summary>
        public static int BitRotateLeft(int Value, int Shift)
        {
            return default;
        }

        /// <summary>
        /// Rotates digits in the binary representation of an integer to the right. As the rightmost bits fall off, they are used to fill the leftmost bits.
        /// </summary>
        public static int BitRotateRight(int Value, int Shift)
        {
            return default;
        }

        /// <summary>
        /// Shifts a value left by a number of bits. Leftmost bits are discarded, and rightmost bits are filled with zeros.
        /// </summary>
        public static int BitShiftLeft(int Value, int Shift)
        {
            return default;
        }

        /// <summary>
        /// Shifts a value right by a number of bits. Rightmost bits are discarded, and leftmost bits are filled with zeros. (Logical shift)
        /// </summary>
        public static int BitShiftRight(int Value, int Shift)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of zeros at the end (least significant side) of the binary representation of an integer.
        /// </summary>
        public static int BitTrailingZeros(int Value)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise XOR. The result has a bit set for every bit that is set in exactly one of the inputs.
        /// </summary>
        public static int BitXor(int Port0, int Port1)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static bool boolVariable(bool Port0)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static (T0 Item1, T1 Item2) BreakTuple<T0, T1>(object Tuple)
        {
            return default;
        }

        /// <summary>
        /// Outputs a target Button's Pressed property.
        /// </summary>
        public static bool ButtonGetIsPressed(Button Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs a target Button's Text property.
        /// </summary>
        public static string ButtonGetText(Button Target)
        {
            return default;
        }

        /// <summary>
        /// Sets an input Button's Text property.
        /// </summary>
        public static void ButtonSetText(Button Target, string Text)
        {
            return;
        }

        /// <summary>
        /// Returns the least integral value greater than or equal to the input value.
        /// </summary>
        public static float Ceil(float Value)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integer value greater than or equal to the input value.
        /// </summary>
        public static int CeiltoInt(float Value)
        {
            return default;
        }

        /// <summary>
        /// Use as a way to encapsulate your logic. You can have as many inputs and outputs as you like. Use the Edit tool to open up the Circuit Board and add nodes inside it to encapsulate the logic. Hit done editing on your Maker Pen to leave the Circuit Board context.
        /// </summary>
        internal static void CircuitBoard()
        {
            return;
        }

        /// <summary>
        /// Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
        /// </summary>
        public static float Clamp(float Value, float Min, float Max)
        {
            return default;
        }

        /// <summary>
        /// Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
        /// </summary>
        public static int Clamp(int Value, int Min, int Max)
        {
            return default;
        }

        /// <summary>
        /// Clears any active screen vignette on the given player.
        /// </summary>
        public static void ClearPlayerVignette(Player Player)
        {
            return;
        }

        /// <summary>
        /// Clear the UI configuration displayed above a given player.
        /// </summary>
        public static void ClearPlayerWorldUI(Player Player)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ClearScreen(TextScreen Target)
        {
            return;
        }

        /// <summary>
        /// Gets distance in meters of an object/player from center specified in "Overlap Sphere" chip.
        /// </summary>
        public static float CollisionDataGetDistance(CollisionData Target)
        {
            return default;
        }

        /// <summary>
        /// Gets unit vector specifying the direction of an object/player from center specified in "Overlap Sphere" chip.
        /// </summary>
        public static Vector3 CollisionDataGetNormal(CollisionData Target)
        {
            return default;
        }

        /// <summary>
        /// Gets object of a collision data (or null for players) returned from "Overlap Sphere" chip.
        /// </summary>
        public static RecRoomObject CollisionDataGetObject(CollisionData Target)
        {
            return default;
        }

        /// <summary>
        /// Gets player of a collision data (or null for objects) returned from "Overlap Sphere" chip.
        /// </summary>
        public static Player CollisionDataGetPlayer(CollisionData Target)
        {
            return default;
        }

        /// <summary>
        /// Gets position of an object/player returned by "Overlap Sphere" chip.
        /// </summary>
        public static Vector3 CollisionDataGetPosition(CollisionData Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color ColorConstant()
        {
            return default;
        }

        /// <summary>
        /// Return hue, saturation, and value from the given color.
        /// </summary>
        public static (float Hue, float Saturation, float Value) ColorToHSV(Color Color)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ColorToInt(Color Color)
        {
            return default;
        }

        /// <summary>
        /// Return red, green, and blue from the given color.
        /// </summary>
        public static (float Red, float Green, float Blue) ColorToRGB(Color Color)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Color ColorVariable(Color Port0)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPosition(AI Combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPosition(Combatant Combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPosition(Player Combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealth(AI Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealth(Combatant Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealth(Player Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAlive(AI Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAlive(Combatant Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAlive(Player Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant's current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocity(AI Combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant's current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocity(Combatant Combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant's current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocity(Player Combatant)
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(AI Target, int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(AI Target, int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(AI Target, int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Combatant Target, int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Combatant Target, int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Combatant Target, int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Player Target, int Damage, bool IgnoreShield, AI DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Player Target, int Damage, bool IgnoreShield, Combatant DamageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamage(Player Target, int Damage, bool IgnoreShield, Player DamageSource)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealth(AI Target, int Health)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealth(Combatant Target, int Health)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealth(Player Target, int Health)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealth(AI Target, int MaxHealth)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealth(Combatant Target, int MaxHealth)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealth(Player Target, int MaxHealth)
        {
            return;
        }

        /// <summary>
        /// Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
        /// </summary>
        public static (bool IsPlayer, Player Player, AI AI) CombatantSplit(Combatant Combatant)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static Combatant CombatantVariable(Combatant Port0)
        {
            return default;
        }

        /// <summary>
        /// Put a comment next to your circuits to explain what they're doing.
        /// </summary>
        public static void Comment()
        {
            return;
        }

        /// <summary>
        /// Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
        /// </summary>
        public static void ConsumableActivate(Consumable Consumable)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Consumable ConsumableConstant()
        {
            return default;
        }

        /// <summary>
        /// Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
        /// </summary>
        public static void ConsumableDeactivate(Consumable Consumable)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static string ControlPanel()
        {
            return default;
        }

        /// <summary>
        /// Computes the cosine of a number.
        /// </summary>
        public static float Cos(float Value)
        {
            return default;
        }

        /// <summary>
        /// Equip a Player with a costume.
        /// </summary>
        public static void CostumeEquip(Costume Target, Player Player)
        {
            return;
        }

        /// <summary>
        /// Get Player wearing a costume.
        /// </summary>
        public static Player CostumeGetWearer(Costume Target)
        {
            return default;
        }

        /// <summary>
        /// Unequip a costume.
        /// </summary>
        public static Player CostumeUnequip(Costume Target)
        {
            return default;
        }

        /// <summary>
        /// A single data table. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room to commit changes.
        /// </summary>
        public static void DataTable(object Port0)
        {
            return;
        }

        /// <summary>
        /// Returns a list of row indices containing the given value within a specified Data Table. Configure the chip to select the data table and column.
        /// </summary>
        public static List<int> DataTableGetAllRowsContaining()
        {
            return default;
        }

        /// <summary>
        /// Returns the number of columns in the given data table, set by configuring the chip.
        /// </summary>
        public static int DataTableGetColumnCount()
        {
            return default;
        }

        /// <summary>
        /// Returns the first row containing the given value within a specified Data Table. Configure the chip to select the Data Table and column.
        /// </summary>
        public static int DataTableGetFirstRowContaining()
        {
            return default;
        }

        /// <summary>
        /// Returns the number of rows in the given data table, set by configuring the chip.
        /// </summary>
        public static int DataTableGetRowCount()
        {
            return default;
        }

        /// <summary>
        /// Returns the value in the specified row from the specified column. Use the configuration menu to set which Data Table and Column to read from, which will also determine the output pin type.
        /// </summary>
        public static void DataTableReadCell(int Row)
        {
            return;
        }

        /// <summary>
        /// Fires outputs based on the inputted time to delay. The Run exec fires as soon as the node is executed. The After Delay exec fires once the input delay duration has completed. After Canceled fires after the delay node’s Cancel exec has been fired. Cancel cancels all current delays running from this node, except for delays scheduled for the next tick.
        /// </summary>
        public static void Delay(float Delay, AlternativeExec AfterDelay, AlternativeExec Cancel)
        {
            return;
        }

        /// <summary>
        /// Configure this constant to choose a destination, specifying room, subroom, and welcome mat. If destination room is different than current room, only Entry Subrooms may be targeted. Party follow options may vary by destination. Use this chip with Go To Room.
        /// </summary>
        public static DestinationRoom DestinationRoomConstant()
        {
            return default;
        }

        /// <summary>
        /// Stores a destination room. Destination cannot be configured from variable - for that, use a Constant.
        /// </summary>
        internal static DestinationRoom DestinationRoomVariable(DestinationRoom Port0)
        {
            return default;
        }

        /// <summary>
        /// Returns the player who rolled the dice.
        /// </summary>
        public static Player DiceGetPlayerRolled(Die Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the result of the dice.
        /// </summary>
        public static int DiceGetResult(Die Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs an exec when the dice finished rolling.
        /// </summary>
        public static bool DiceGetRollfinished(Die Target)
        {
            return default;
        }

        /// <summary>
        /// Displays a target UI configuration above a given player.
        /// </summary>
        public static void DisplayPlayerWorldUI(PlayerWorldUI Target, Player Player)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 A, AI B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 A, Combatant B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 A, RecRoomObject B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 A, Player B)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 A, Vector3 B)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static int Divide(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static float Divide(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static Vector3 Divide(params Vector3[] Value)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DestinationRoom DoorGetDestination(RoomDoor Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool DoorGetLocked(RoomDoor Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DoorSetDestination(RoomDoor Target, DestinationRoom Room)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DoorSetLocked(RoomDoor Target, bool Locked)
        {
            return;
        }

        /// <summary>
        /// Returns True if the target Emitter is looping.
        /// </summary>
        public static bool EmitterGetLooping(Emitter Target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Emitter is playing.
        /// </summary>
        public static bool EmitterGetPlaying(Emitter Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the size multiplier of the target Emitter.
        /// </summary>
        public static float EmitterGetSize(Emitter Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed multiplier of the target Emitter.
        /// </summary>
        public static float EmitterGetSpeed(Emitter Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color for the particles emitted.
        /// </summary>
        public static void EmitterSetColor(Emitter Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for the particles emitted.
        /// </summary>
        public static void EmitterSetColorId(Emitter Target, int Value)
        {
            return;
        }

        /// <summary>
        /// Makes the emitter emit continuously or not.
        /// </summary>
        public static void EmitterSetLooping(Emitter Target, bool Value)
        {
            return;
        }

        /// <summary>
        /// Sets the size of the particles emitted.
        /// </summary>
        public static void EmitterSetSize(Emitter Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed particles are emitted.
        /// </summary>
        public static void EmitterSetSpeed(Emitter Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Starts emitting particles.
        /// </summary>
        public static void EmitterStart(Emitter Target)
        {
            return;
        }

        /// <summary>
        /// Stops emitting particles.
        /// </summary>
        public static void EmitterStop(Emitter Target)
        {
            return;
        }

        /// <summary>
        /// Compares the input values and outputs True if they are the same. False if they are different.
        /// </summary>
        internal static bool Equals<T>(T Value)
        {
            return default;
        }

        /// <summary>
        /// Compares the two input values and outputs True if they are the same. False if they are different.
        /// </summary>
        public static bool EqualsDeprecated<T>(T A, T B)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool EquipObjecttoDominantHand(Player Player, RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool EquipObjecttoOffHand(Player Player, RecRoomObject ObjectToEquip, bool ForceEquip, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static void EventDefinition()
        {
            return;
        }

        /// <summary>
        /// Events are the entry points for all circuit graphs. Events are execution hooks for things like a player loading into the room, or knowing when a Button is pressed. After creating this chip, make sure to use the configure tool to choose the event you want to listen for. You can use the Event Defintion chip to create your own events to add to this list and use with the Event Sender chip.
        /// </summary>
        internal static void EventReceiver()
        {
            return;
        }

        /// <summary>
        /// Use the Event Sender to fire your custom events defined in Event Defintions. After creating this chip, make sure to use the configure tool to change the event that you want to fire. You can also change who you want to send the event to from the config menu.
        /// </summary>
        internal static void EventSender()
        {
            return;
        }

        /// <summary>
        /// Executes the associated output of the compare value that matches the 'match' input. Executes the default output if no match can be found.
        /// </summary>
        internal static void ExecutionIntegerSwitch(int Match)
        {
            return;
        }

        /// <summary>
        /// Executes the associated output of the compare value that matches the 'match' input. Executes the default output if no match can be found.
        /// </summary>
        internal static void ExecutionStringSwitch(string Match)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExplosionEmitterExplode(ExplosionEmitter Target)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ExplosionEmitterGetDamage(ExplosionEmitter Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color ExplosionEmitterGetExplosionColor(ExplosionEmitter Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float ExplosionEmitterGetExplosionRadius(ExplosionEmitter Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the player set by the Explosion Emitter Set Firing Player chip.
        /// </summary>
        public static Player ExplosionEmitterGetFiringPlayer(ExplosionEmitter Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExplosionEmitterSetDamage(ExplosionEmitter Target, int Damage)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExplosionEmitterSetExplosionColor(ExplosionEmitter Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExplosionEmitterSetExplosionRadius(ExplosionEmitter Target, float Radius)
        {
            return;
        }

        /// <summary>
        /// Sets the firing player of the target Explosion Emitter. If none is set, the component will use the authority player.
        /// </summary>
        public static void ExplosionEmitterSetFiringPlayer(ExplosionEmitter Target, Player Player)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static float floatVariable(float Port0)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integral value less than or equal to the input value.
        /// </summary>
        public static float Floor(float Value)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integer value less than or equal to the input value.
        /// </summary>
        public static int FloortoInt(float Value)
        {
            return default;
        }

        /// <summary>
        /// Defines settings for room fog.
        /// </summary>
        public static Fog FogConstant()
        {
            return default;
        }

        /// <summary>
        /// Iterates over the "From" pin (inclusive) to the "To" pin (exclusive).
        /// </summary>
        public static int For(int From, int To, AlternativeExec<int> Done)
        {
            return default;
        }

        /// <summary>
        /// Iterates over the input list. The loop exec fires for each element in the list. The Done exec fires once the end of the list has been reached.
        /// </summary>
        public static T ForEach<T>(List<T> Items, AlternativeExec<T> Done)
        {
            return default;
        }

        /// <summary>
        /// Converts the input Rec Room Object to the object's subtype.
        /// </summary>
        internal static T FromRecRoomObject<T>(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static HUDElement GameHUDElementConstant()
        {
            return default;
        }

        /// <summary>
        /// Override all Game HUD Element properties using default values from Game HUD Element Constant input
        /// </summary>
        public static void GameHUDElementSetAllValues(HUDElement Target)
        {
            return;
        }

        /// <summary>
        /// Outputs a list of all the players in the room currently.
        /// </summary>
        public static List<Player> GetAllPlayers()
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of all the players in the room currently.
        /// </summary>
        public static List<Player> GetAllPlayersDeprecated()
        {
            return default;
        }

        /// <summary>
        /// Outpus List<Player> that continues every player with the specified role.
        /// </summary>
        public static List<Player> GetAllPlayersWithRole(string RoleName)
        {
            return default;
        }

        /// <summary>
        /// Returns the angular velocity in degrees per second of a Rec Room Object.
        /// </summary>
        public static Vector3 GetAngularVelocity(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Gets a player with the role. Returns invalid player if no player has the role.
        /// </summary>
        public static Player GetAnyPlayerwithRole(string Role)
        {
            return default;
        }

        /// <summary>
        /// Gets the authority player of the chip's current context.
        /// </summary>
        public static Player GetAuthority()
        {
            return default;
        }

        /// <summary>
        /// Outputs player counts if you're in an event that's actively broadcasting.
        /// </summary>
        public static (int AudienceCount, int BroadcasterCount, bool IsBroadcastActive) GetBroadcastingAttendance()
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Player Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(Player Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Player Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Vector3 Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(Vector3 Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Vector3 Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.
        /// </summary>
        public static (bool Success, int TotalBalance) GetCurrencyBalance(Player Player, AlternativeExec<(bool Success, int TotalBalance)> OnGetBalanceComplete)
        {
            return default;
        }

        /// <summary>
        /// Returns the given player's balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) GetCurrencyBalanceNew(RoomCurrency Currency, Player Player, AlternativeExec<(bool Success, int TotalBalance)> OnGetBalanceComplete)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Player Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Player Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Player Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 Origin, List<RecRoomObject> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 Origin, List<Player> Targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 Origin, List<Vector3> Targets)
        {
            return default;
        }

        /// <summary>
        /// Gets the first tag of an object or player.
        /// </summary>
        public static string GetFirstTag(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the first tag of an object or player.
        /// </summary>
        public static string GetFirstTag(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the given universal time, formatted based on the C# DateTime format specifiers.
        /// </summary>
        public static string GetFormattedTime(float UniversalSeconds, string Format)
        {
            return default;
        }

        /// <summary>
        /// Returns the given universal time, formatted based on the C# DateTime format specifiers.
        /// </summary>
        public static string GetFormattedTime(int UniversalSeconds, string Format)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVector(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVector(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVectorDeprecated(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVectorDeprecated(Player Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color GetGameHUDElementColor(HUDConstant Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetGameHUDElementLabel(HUDConstant Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GetGameHUDElementMaxValue(HUDConstant Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GetGameHUDElementValue(HUDConstant Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the number of players that are currently loading into the room.
        /// </summary>
        public static int GetLoadingPlayers()
        {
            return default;
        }

        /// <summary>
        /// Gets the direction your avatar is looking, output as a Vector3.
        /// </summary>
        public static Vector3 GetLocalCameraForward()
        {
            return default;
        }

        /// <summary>
        /// Gets the position of your avatar's view, output as a Vector3.
        /// </summary>
        public static Vector3 GetLocalCameraPosition()
        {
            return default;
        }

        /// <summary>
        /// Gets the rotation of your avatar's view, output as a quaternion.
        /// </summary>
        public static Quaternion GetLocalCameraRotation()
        {
            return default;
        }

        /// <summary>
        /// Gets the up direction from the local player's camera, output as a Vector3.
        /// </summary>
        public static Vector3 GetLocalCameraUp()
        {
            return default;
        }

        /// <summary>
        /// Outputs the player running this chip on their machine.
        /// </summary>
        public static Player GetLocalPlayer()
        {
            return default;
        }

        /// <summary>
        /// Returns a new line string.
        /// </summary>
        public static string GetNewLine()
        {
            return default;
        }

        /// <summary>
        /// Returns the party of the input player as List<Player>. If the player is not in a party, it will return a list containing only that player.
        /// </summary>
        public static List<Player> GetPartyOfPlayer(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the player's Account name (e.g Coach) in a form of a string. To get a display name, use To String.
        /// </summary>
        public static string GetPlayerAccountName(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Gets a Player based on an Account Name. (E.g. my account name is @Coach and if I input the string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given account name.
        /// </summary>
        public static Player GetPlayerByAccountName(string Name)
        {
            return default;
        }

        /// <summary>
        /// Gets a Player based on a display name. (E.g. my display name is Coach and if I input a string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given display name.
        /// </summary>
        public static Player GetPlayerByDisplayName(string Name)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetPlayerSeasonLeagueName(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player's world UI.
        /// </summary>
        public static bool GetPlayerWorldUIEnabled(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player's primary bar in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUIPrimaryBarColor(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player's primary bar in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUIPrimaryBarEnabled(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max value of the given player's primary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUIPrimaryBarMaxValue(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player's primary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUIPrimaryBarValue(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player's secondary bar in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUISecondaryBarColor(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player's secondary bar in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUISecondaryBarEnabled(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max value of the given player's secondary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUISecondaryBarMaxValue(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player's secondary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUISecondaryBarValue(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player's text in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUITextColor(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player's text in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUITextEnabled(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player's text in their current world UI.
        /// </summary>
        public static string GetPlayerWorldUITextValue(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(AI Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(Combatant Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(AI Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(Combatant Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the player who is the room authority.
        /// </summary>
        public static Player GetRoomAuthority()
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotation(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotation(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotationDeprecated(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotationDeprecated(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of tags the input object or player has.
        /// </summary>
        public static List<string> GetTags(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of tags the input object or player has.
        /// </summary>
        public static List<string> GetTags(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVector(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVector(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVectorDeprecated(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVectorDeprecated(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocity(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocity(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocityDeprecated(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocityDeprecated(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Execution sends the specified player to a preconfigured destination. Use a destination constant or variable to specify the destination of this chip. Follow settings are a property of the destination.
        /// </summary>
        public static void GoToRoom(Player Player, DestinationRoom Destination)
        {
            return;
        }

        /// <summary>
        /// Transitions to the given state in the current state machine.
        /// </summary>
        public static void GoToState(State State)
        {
            return;
        }

        /// <summary>
        /// Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
        /// </summary>
        public static (bool HasHeldObject, RecRoomObject HeldObject) GrabberGetHeldObject(Grabber Target)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will attempt to grab the specified object. If Steal From Player is true, it will steal the object from a player who has it held or holstered. If Snap to Grabber is true, the object will be moved to the Grabber’s position. If Snap to Grabber is false, the distance between Grabber and object at the moment of execution will be maintained until the object is released.
        /// </summary>
        public static bool GrabberGrabObject(Grabber Target, RecRoomObject Object, bool StealfromPlayer, bool SnaptoGrabber)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
        /// </summary>
        public static RecRoomObject GrabberRelease(Grabber Target)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target grabber will lock or unlock the object being held. If true, the held object will interactable for a player to steal.  If false, the held object will not be interactable for a player to steal.
        /// </summary>
        public static void GrabberSetPlayerCanStealFromGrabber(Grabber Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Grants the contents of a Reward to the specified Player.
        /// </summary>
        public static bool GrantReward(Player Player, Reward Reward, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the current circuit graph is active. When inactive, circuit events will not run.
        /// </summary>
        public static bool GraphGetIsActive()
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterorEqual(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterorEqual(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThan(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThan(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThanDepreacted(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThanDepreacted(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterThanOrEqualDepreacted(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterThanOrEqualDepreacted(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleAddBoostFuel(GroundVehicle Target, int Boostamount)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleApplyBoost(GroundVehicle Target, AlternativeExec Failure)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GroundVehicleGetBoostFuel(GroundVehicle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool GroundVehicleGetDrivingEnabled(GroundVehicle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float GroundVehicleGetEngineTorqueMultiplier(GroundVehicle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Player GroundVehicleGetSeatedPlayer(GroundVehicle Target, int Seatindex)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float GroundVehicleGetWheelFrictionMultiplier(GroundVehicle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleSetDrivingEnabled(GroundVehicle Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleSetEngineTorqueMultiplier(GroundVehicle Target, float Torquemultiplier)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleSetSeatedPlayer(GroundVehicle Target, int Seatindex, Player Player, AlternativeExec Failure)
        {
            return;
        }

        /// <summary>
        /// Wheel Friction affects how good the wheels are at gripping the ground - lower values decrease traction and make the wheels slip more and higher values can increase traction and make the wheels slip less. 1 is the default value for Wheel Friction.
        /// </summary>
        public static void GroundVehicleSetWheelFrictionMultiplier(GroundVehicle Target, float Frictionmultiplier)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleUnseatPlayer(GroundVehicle Target, Player Player, AlternativeExec Failure)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GroundVehicleUnseatPlayerFromSeat(GroundVehicle Target, int Seatindex, AlternativeExec Failure)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleAddAutoAimRole(GunHandle Target, string Role)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleApplyRecoil(GunHandle Target, float AngleX, float AngleY, float Duration, float ReturnDuration)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GunHandleGetCurrentAmmo(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Vector3 GunHandleGetFiringDirection(GunHandle Target, RecRoomObject Source)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool GunHandleGetIsReloading(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GunHandleGetMaxAmmo(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float GunHandleGetRateOfFire(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float GunHandleGetReloadDuration(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool GunHandleGetSupportsReload(GunHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleRemoveAutoAimRole(GunHandle Target, string Role)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetADSEnabled(GunHandle Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetAutoAimRoles(GunHandle Target, List<string> Roles)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetCurrentAmmo(GunHandle Target, int Ammo)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetMaxAmmo(GunHandle Target, int MaxAmmo)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetRateOfFire(GunHandle Target, float RateOfFire)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetReloadDuration(GunHandle Target, float ReloadDuration)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GunHandleSetSupportsReload(GunHandle Target, bool CanReload)
        {
            return;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(Player Target, string Tag)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(RecRoomObject Target, string Tag)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool HolsterObject(Player Player, RecRoomObject ObjectToHolster, bool ForceHolster, bool Steal)
        {
            return default;
        }

        /// <summary>
        /// Return a color from the given hue, saturation, and value inputs. All inputs are in the range [0, 1].
        /// </summary>
        public static Color HSVToColor(float Hue, float Saturation, float Value)
        {
            return default;
        }

        /// <summary>
        /// Takes a boolean condition as an input. If True, the "Then" exec pin fires. If False, the "Else" exec pin fires.
        /// </summary>
        internal static void If(bool Condition, AlternativeExec Else)
        {
            return;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(Player Target, string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(RecRoomObject Target, string Tag, AlternativeExec DoesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// I'm Authority exec fires on the player's machine who has authority in the current context. At the room level, this is room authority, inside an object board, this is object authority. I'm Not Authority exec fires for everyone else.
        /// </summary>
        public static void IfLocalPlayerIsAuthority(AlternativeExec ImNotAuthority)
        {
            return;
        }

        /// <summary>
        /// I'm Authority exec fires on the player's machine who has authority over the room. I'm Not Authority exec fires for everyone else.
        /// </summary>
        public static void IfLocalPlayerIsRoomAuthority(AlternativeExec ImNotAuthority)
        {
            return;
        }

        /// <summary>
        /// The "Should Run" port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
        /// </summary>
        public static void IfLocalPlayerShouldRun(Player ActingPlayer, AlternativeExec ShouldNotRun)
        {
            return;
        }

        /// <summary>
        /// Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
        /// </summary>
        public static void IfPlayerHasRole(Player Player, string Role, AlternativeExec DoesNotHaveRole)
        {
            return;
        }

        /// <summary>
        /// Outputs if a player is the local player or not.
        /// </summary>
        public static void IfPlayerIsLocal(Player Player, AlternativeExec IsNotLocal)
        {
            return;
        }

        /// <summary>
        /// Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
        /// </summary>
        public static void IfPlayerIsValid(Player Player, AlternativeExec IsNotValid)
        {
            return;
        }

        /// <summary>
        /// If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
        /// </summary>
        public static void IfPlayerIsValidAndLocal(Player Player, AlternativeExec IsNotValid, AlternativeExec IsValidAndNotLocal)
        {
            return;
        }

        /// <summary>
        /// Outputs one input value based on the input condition. Outputs the "Then" input if the input condition is True. Outputs the "Else" input if the input condition is False. Only reads one of the inputs, not both.
        /// </summary>
        public static T IfValue<T>(bool If, T Then, T Else)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void In()
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool InstanceGetIsEvent()
        {
            return default;
        }

        /// <summary>
        /// Returns True if the current room instance is private.
        /// </summary>
        public static bool InstanceGetIsPrivate()
        {
            return default;
        }

        /// <summary>
        /// Returns the maximum number of players that can fit in this room, as set in subroom settings.
        /// </summary>
        public static int InstanceGetMaxPlayers()
        {
            return default;
        }

        /// <summary>
        /// Gets the required hold time for the target Interaction Volume.
        /// </summary>
        public static float InteractionVolumeGetHoldTime(InteractionVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the interaction prompt of an Interaction Volume.
        /// </summary>
        public static string InteractionVolumeGetInteractionPrompt(InteractionVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Returns False if the Interaction Volume is enabled, and True if it is locked.
        /// </summary>
        public static bool InteractionVolumeGetIsLocked(InteractionVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the normalized hold progress for the target Interaction Volume.
        /// </summary>
        public static float InteractionVolumeGetNormalizedHoldProgress(InteractionVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the required hold time for the target Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetHoldTime(InteractionVolume Target, float HoldTime)
        {
            return;
        }

        /// <summary>
        /// Sets the interaction prompt of an Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetInteractionPrompt(InteractionVolume Target, string InteractionPrompt)
        {
            return;
        }

        /// <summary>
        /// Disables or enables an Interaction Volume (but reversed).
        /// </summary>
        public static void InteractionVolumeSetLocked(InteractionVolume Target, bool Locked)
        {
            return;
        }

        /// <summary>
        /// Sets the normalized hold progress for the target Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetNormalizedHoldProgress(InteractionVolume Target, float NormalizedHoldProgress)
        {
            return;
        }

        /// <summary>
        /// Converts the input int to a float.
        /// </summary>
        public static float InttoFloat(int Value)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static int intVariable(int Port0)
        {
            return default;
        }

        /// <summary>
        /// Add an inventory item to the given player.
        /// </summary>
        public static (bool Success, int TotalCount) InventoryItemAdd(InventoryItem InventoryItem, Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InventoryItem InventoryItemConstant()
        {
            return default;
        }

        /// <summary>
        /// Get the count of how many of the given inventory item the given player owns.
        /// </summary>
        public static int InventoryItemGetCount(InventoryItem InventoryItem, Player Player, AlternativeExec<int> Complete)
        {
            return default;
        }

        /// <summary>
        /// Gets the friendly name and description of the given inventory item.
        /// </summary>
        public static (string Name, string Description, bool SupportsUseAction) InventoryItemGetDefinition(InventoryItem InventoryItem)
        {
            return default;
        }

        /// <summary>
        /// Remove an inventory item from the given player.
        /// </summary>
        public static (bool Success, int TotalCount) InventoryItemRemove(InventoryItem InventoryItem, Player Player, int Quantity, AlternativeExec<(bool Success, int TotalCount)> Complete)
        {
            return default;
        }

        /// <summary>
        /// Uses the given inventory item.
        /// </summary>
        public static void InventoryItemUse(InventoryItem InventoryItem)
        {
            return;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(float Start, float End, float Value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(Color Start, Color End, Color Value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(Vector3 Start, Vector3 End, Vector3 Value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(float Start, float End, float Value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(Color Start, Color End, Color Value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(Vector3 Start, Vector3 End, Vector3 Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Invisible Collision object is set to collide with players.
        /// </summary>
        public static bool InvisibleCollisionGetBlocksPlayers(InvisibleCollision Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Invisible Collision object is enabled.
        /// </summary>
        public static bool InvisibleCollisionGetEnabled(InvisibleCollision Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the player collision state of a target Invisible Collision object.
        /// </summary>
        public static void InvisibleCollisionSetBlocksPlayers(InvisibleCollision Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of a target Invisible Collision object.
        /// </summary>
        public static void InvisibleCollisionSetEnabled(InvisibleCollision Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Returns True if the input variable is not null. Certain variable types must be set before use because they can't have a default value. A Rec Room Object variable that isn't set isn't going to be valid.
        /// </summary>
        public static bool IsValid<T>(T Port0)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color LaserPointerGetColor(LaserPointer Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool LaserPointerGetEnabled(LaserPointer Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float LaserPointerGetLength(LaserPointer Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LaserPointerSetColor(LaserPointer Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LaserPointerSetEnabled(LaserPointer Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LaserPointerSetLength(LaserPointer Target, float Length)
        {
            return;
        }

        /// <summary>
        /// Get the leaderboard stat for the given player on the given stat channel.
        /// </summary>
        public static int LeaderboardGetPlayerStat(Player Player, int Channel, AlternativeExec<int> OnGetStatComplete)
        {
            return default;
        }

        /// <summary>
        /// Set the leaderboard stat for the local player on the given stat channel.
        /// </summary>
        public static void LeaderboardSetLocalPlayerStat(int Channel, int Value)
        {
            return;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static float Lerp(float Start, float End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Quaternion Lerp(Quaternion Start, Quaternion End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Vector3 Lerp(Vector3 Start, Vector3 End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Color Lerp(Color Start, Color End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static float LerpUnclamped(float Start, float End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Quaternion LerpUnclamped(Quaternion Start, Quaternion End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Vector3 LerpUnclamped(Vector3 Start, Vector3 End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Color LerpUnclamped(Color Start, Color End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessorEqual(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessorEqual(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThan(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThan(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThanDepreacted(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThanDepreacted(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessThanOrEqualDepreacted(int A, int B)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessThanOrEqualDepreacted(float A, float B)
        {
            return default;
        }

        /// <summary>
        /// Returns the angle in degrees of the target Dome Light or Spotlight.
        /// </summary>
        public static float LightGetAngle(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target light.
        /// </summary>
        public static Color LightGetColor(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target light is emitting light.
        /// </summary>
        public static bool LightGetEnabled(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the intensity of the target light.
        /// </summary>
        public static float LightGetIntensity(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the range of the target light.
        /// </summary>
        public static float LightGetRange(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the softness value of the target light.
        /// </summary>
        public static float LightGetSoftness(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the specular contribution of the target light.
        /// </summary>
        public static float LightGetSpecularContribution(Light Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the angle of the spotlight's cone.
        /// </summary>
        public static void LightSetAngle(Light Target, float Angle)
        {
            return;
        }

        /// <summary>
        /// Sets the angle of the spotlight's cone.
        /// </summary>
        public static void LightSetAngleInt(Light Target, int Angle)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a point light or a spotlight.
        /// </summary>
        public static void LightSetColor(Light Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a point light or a spotlight.
        /// </summary>
        public static void LightSetColorId(Light Target, int Color)
        {
            return;
        }

        /// <summary>
        /// Sets the brightness level for a point light or a spotlight.
        /// </summary>
        public static void LightSetIntensity(Light Target, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the brightness level for a point light or a spotlight.
        /// </summary>
        public static void LightSetIntensityInt(Light Target, int Intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the range of a point light or a spotlight.
        /// </summary>
        public static void LightSetRange(Light Target, float Range)
        {
            return;
        }

        /// <summary>
        /// Sets the range of a point light or a spotlight.
        /// </summary>
        public static void LightSetRangeInt(Light Target, int Range)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LightSetSoftness(Light Target, float Softness)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LightSetSpecularContribution(Light Target, float SpecularContribution)
        {
            return;
        }

        /// <summary>
        /// Turns off the point light or the spotlight.
        /// </summary>
        public static void LightTurnOff(Light Target)
        {
            return;
        }

        /// <summary>
        /// Turns on the point light or the spotlight.
        /// </summary>
        public static void LightTurnOn(Light Target)
        {
            return;
        }

        /// <summary>
        /// Adds a new element to the end of the target list containing the input value.
        /// </summary>
        public static void ListAdd<T>(List<T> Target, T Item)
        {
            return;
        }

        /// <summary>
        /// If all of the bool values in the list are True then return true.
        /// </summary>
        public static bool ListAllTrue(List<bool> Target)
        {
            return default;
        }

        /// <summary>
        /// If any bool value in the list is True then return True.
        /// </summary>
        public static bool ListAnyTrue(List<bool> Target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<bool> ListBoolVariable(List<bool> Port0)
        {
            return default;
        }

        /// <summary>
        /// Removes all elements from a list
        /// </summary>
        public static void ListClear<T>(List<T> List)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Color> ListColorVariable(List<Color> Port0)
        {
            return default;
        }

        /// <summary>
        /// Combine lists together into one list.
        /// </summary>
        public static List<T> ListConcat<T>(List<T> List1, List<T> List2)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target list contains the input value.
        /// </summary>
        public static bool ListContains<T>(List<T> Target, T Item)
        {
            return default;
        }

        /// <summary>
        /// Returns a shallow clone of the given list.
        /// </summary>
        public static List<T> ListCopy<T>(List<T> Target)
        {
            return default;
        }

        /// <summary>
        /// Creates a list from input values. Add more inputs by using the configure tool on the node and press "Add Input". All items in a list must be of the same type.
        /// </summary>
        public static List<T> ListCreate<T>(params T[] Item)
        {
            return default;
        }

        /// <summary>
        /// Stores a list of Destinations. Use constants to configure destinations.
        /// </summary>
        internal static List<DestinationRoom> ListDestinationRoomVariable(List<DestinationRoom> Port0)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static float ListDivide(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static int ListDivide(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static Vector3 ListDivide(List<Vector3> Target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<float> ListFloatVariable(List<float> Port0)
        {
            return default;
        }

        /// <summary>
        /// Returns list of all indices of input item in target list if that list contains one or more instances of the item. Otherwise returns an empty list.
        /// </summary>
        public static List<int> ListGetAllIndicesOf<T>(List<T> Target, T Item)
        {
            return default;
        }

        /// <summary>
        /// Outputs the number of elements inside the input list.
        /// </summary>
        public static int ListGetCount<T>(List<T> List)
        {
            return default;
        }

        /// <summary>
        /// Gets a specified element from the input list. The "Index" is the location of the element in the list. The first element in the list is at index 0, the second element is at index 1.
        /// </summary>
        public static T ListGetElement<T>(List<T> List, int Index)
        {
            return default;
        }

        /// <summary>
        /// Returns first index of the item in target list if that list contains it. Otherwise returns -1.
        /// </summary>
        public static int ListGetFirstIndexOf<T>(List<T> Target, T Item)
        {
            return default;
        }

        /// <summary>
        /// Insert a new element into the target list at the input index. The new element contains the input value.
        /// </summary>
        public static void ListInsert<T>(List<T> Target, T Item, int Index)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<int> ListIntVariable(List<int> Port0)
        {
            return default;
        }

        /// <summary>
        /// Outputs the highest value in the target list.
        /// </summary>
        public static float ListMax(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the highest value in the target list.
        /// </summary>
        public static int ListMax(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the lowest value in the target list.
        /// </summary>
        public static float ListMin(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the lowest value in the target list.
        /// </summary>
        public static int ListMin(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static float ListMultiply(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static int ListMultiply(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static Quaternion ListMultiply(List<Quaternion> Target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static Vector3 ListMultiply(List<Vector3> Target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<ObjectiveMarker> ListObjectiveMarkerVariable(List<ObjectiveMarker> Port0)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Player> ListPlayerVariable(List<Player> Port0)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Quaternion> ListQuaternionVariable(List<Quaternion> Port0)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static List<RecRoomObject> ListRecRoomObjectVariable(List<RecRoomObject> Port0)
        {
            return default;
        }

        /// <summary>
        /// Remove an element in the target list at the input index.
        /// </summary>
        public static void ListRemoveAt<T>(List<T> Target, int Index)
        {
            return;
        }

        /// <summary>
        /// Removes all instances of item from list.
        /// </summary>
        public static void ListRemoveItemAll<T>(List<T> Target, T Item)
        {
            return;
        }

        /// <summary>
        /// Removes the first instance of the item in the list, and returns the index where it was found (-1 if not present)
        /// </summary>
        public static int ListRemoveItemFirst<T>(List<T> Target, T Item)
        {
            return default;
        }

        /// <summary>
        /// Removes the last element in a list.
        /// </summary>
        public static void ListRemoveLast<T>(List<T> Target)
        {
            return;
        }

        /// <summary>
        /// A list of Rewards
        /// </summary>
        internal static List<Reward> ListRewardVariable(List<Reward> Port0)
        {
            return default;
        }

        /// <summary>
        /// Sets a value at a location in a list.
        /// </summary>
        public static void ListSetElement<T>(List<T> List, int Index, T Value)
        {
            return;
        }

        /// <summary>
        /// Randomize the order of the values in the given list.
        /// </summary>
        public static void ListShuffle<T>(List<T> Target)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<float> Target, bool Ascending)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<int> Target, bool Ascending)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<string> Target, bool Ascending)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<string> ListStringVariable(List<string> Port0)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static float ListSubtract(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static int ListSubtract(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static Vector3 ListSubtract(List<Vector3> Target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static float ListSum(List<float> Target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static int ListSum(List<int> Target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static Vector3 ListSum(List<Vector3> Target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Vector3> ListVector3Variable(List<Vector3> Port0)
        {
            return default;
        }

        /// <summary>
        /// Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
        /// </summary>
        public static void LocalPlayerDisableInteractionwithTargetPlayer(Player Player)
        {
            return;
        }

        /// <summary>
        /// Enables the local player to interact with the provided player. To respond to interactions, configure a "Event Receiver" chip for the "Local Player... Interaction" events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player's interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
        /// </summary>
        public static void LocalPlayerEnableInteractionwithTargetPlayer(Player Player, float RequiredHoldDuration, string Prompt)
        {
            return;
        }

        /// <summary>
        /// Outputs the direction of Local Player Gaze.
        /// </summary>
        public static Vector3 LocalPlayerGazeDirection()
        {
            return default;
        }

        /// <summary>
        /// Outputs the origin of Local Player Gaze.
        /// </summary>
        public static Vector3 LocalPlayerGazeOrigin()
        {
            return default;
        }

        /// <summary>
        /// Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
        /// </summary>
        public static void LocalPlayerSetPlayerNametagVisibility(Player Player, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Computes a logarithm.
        /// </summary>
        public static float Logarithm(float Value, float Base)
        {
            return default;
        }

        /// <summary>
        /// Logs the given error message to the logging tab of your palette.
        /// </summary>
        public static void LogError(string Error)
        {
            return;
        }

        /// <summary>
        /// Logs a string to the logging tab of your palette.
        /// </summary>
        public static void LogString(string Text)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static object MakeTuple<T0, T1>(T0 Item1, T1 Item2)
        {
            return default;
        }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        public static int Max(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        public static float Max(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        public static int Min(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        public static float Min(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the remainder of the first value is divided by the second.
        /// </summary>
        public static int Modulo(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the remainder of the first value is divided by the second.
        /// </summary>
        public static float Modulo(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static int Multiply(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static float Multiply(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static Quaternion Multiply(params Quaternion[] Value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static Vector3 Multiply(params Vector3[] Value)
        {
            return default;
        }

        /// <summary>
        /// Choose from a selection of music tracks, for use with the Audio Player.
        /// </summary>
        public static Audio MusicConstant()
        {
            return default;
        }

        /// <summary>
        /// Outputs False only when all inputs are True. If any input is False, it outputs True.
        /// </summary>
        public static bool Nand(bool Input)
        {
            return default;
        }

        /// <summary>
        /// Samples a 3D Perlin noise field and returns a value usually bounded in [0,1].
        /// </summary>
        public static float Noise(Vector3 Point)
        {
            return default;
        }

        /// <summary>
        /// Outputs True when all inputs are False. Otherwise, outputs False.
        /// </summary>
        public static bool Nor(bool Input)
        {
            return default;
        }

        /// <summary>
        /// Outputs the opposite of the input boolean.
        /// </summary>
        public static bool Not(bool Value)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker Target, Player PlayerOrObject)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker Target, RecRoomObject PlayerOrObject)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Constant defines the default appearance of an Objective Marker. Use with Objective Marker Set Enabled, Objective Marker Set Position, and the other Objective Marker chips.
        /// </summary>
        public static ObjectiveMarker ObjectiveMarkerConstant()
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Color returns the current color of target Objective Marker for the local player.
        /// </summary>
        public static Color ObjectiveMarkerGetColor(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Current Distance returns the current distance of the local player from the target Objective Marker, regardless of whether the distance indicator is enabled.
        /// </summary>
        public static float ObjectiveMarkerGetCurrentDistance(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Distance Is Enabled returns whether or not the target Objective Marker’s distance indicator is visible for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetDistanceEnabled(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Enabled returns whether or not the target Objective Marker is enabled for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetEnabled(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Fade Threshold returns the current fade threshold of the target Objective Marker for the local player.
        /// </summary>
        public static float ObjectiveMarkerGetFadeThreshold(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Label returns the current text label of target Objective Marker for the local player as a string.
        /// </summary>
        public static string ObjectiveMarkerGetLabel(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Label Is Enabled returns whether or not the target Objective Marker’s text label is visible for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetLabelEnabled(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Position returns target Objective Marker’s current position for the local player as a vector
        /// </summary>
        public static Vector3 ObjectiveMarkerGetPosition(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Target Object returns the object targeted by target Objective Marker, if it’s tracking an object. If target Objective Marker is not tracking an object, returns Invalid Object.
        /// </summary>
        public static RecRoomObject ObjectiveMarkerGetTargetObject(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Target Player returns the player targeted by target Objective Marker, if it’s tracking a player. If target Objective Marker is not tracking a player, returns Invalid Player.
        /// </summary>
        public static Player ObjectiveMarkerGetTargetPlayer(ObjectiveMarker Target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Set Color sets target Objective Marker to the specified color for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetColor(ObjectiveMarker Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Distance Enabled enables or disables the visibility of the target Objective Marker’s distance indicator for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetDistanceEnabled(ObjectiveMarker Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Enabled enables or disables the target Objective Marker for the local player. Use with Objective Marker constant.
        /// </summary>
        public static void ObjectiveMarkerSetEnabled(ObjectiveMarker Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Fade Threshold sets the fade threshold of the target Objective Marker for the local player. This threshold is the distance (in meters) at which the marker has fully faded from sight as a player approaches it. For finer control over the fade duration, configure the Objective Marker constant.
        /// </summary>
        public static void ObjectiveMarkerSetFadeThreshold(ObjectiveMarker Target, float Proximity)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Label sets the text label of target Objective Marker to the specified string for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetLabel(ObjectiveMarker Target, string Label)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Label Enabled enables or disables the visibility of the target Objective Marker’s text label for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetLabelEnabled(ObjectiveMarker Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Position sets the position of target Objective Marker to a position vector for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetPosition(ObjectiveMarker Target, Vector3 Position)
        {
            return;
        }

        /// <summary>
        /// Outputs True if any input is True. Otherwise outputs False.
        /// </summary>
        public static bool Or(params bool[] Input)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Out()
        {
            return;
        }

        /// <summary>
        /// Get information about all the objects/players within a box defined by its center, extents, and orientation. (position, distance, direction, etc.)
        /// </summary>
        public static List<CollisionData> OverlapBox(Vector3 Center, Vector3 Extents, Quaternion Orientation)
        {
            return default;
        }

        /// <summary>
        /// Get information about all the objects/players within a certain distance of a point in space (position, distance, direction, etc.)
        /// </summary>
        public static List<CollisionData> OverlapSphere(Vector3 Origin, float Radius)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a bool if able.
        /// </summary>
        public static (bool Result, bool ParseSuccess) ParseBool(string String)
        {
            return default;
        }

        /// <summary>
        /// Attempt to parse the given string as a hexadecimal color in the '#RRGGBB' format.
        /// </summary>
        public static (Color Result, bool ParseSuccess) ParseColor(string String)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a float if able.
        /// </summary>
        public static (float Result, bool ParseSuccess) ParseFloat(string String)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a integer if able.
        /// </summary>
        public static (int Result, bool ParseSuccess) ParseInt(string String)
        {
            return default;
        }

        /// <summary>
        /// Gets the acceleration of a piston.
        /// </summary>
        public static float PistonGetAcceleration(Piston Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the current distance of the target Piston.
        /// </summary>
        public static float PistonGetDistance(Piston Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the max distance of the target Piston.
        /// </summary>
        public static float PistonGetMaxDistance(Piston Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed of a piston.
        /// </summary>
        public static float PistonGetSpeed(Piston Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the set distance of the Marker on a target Piston.
        /// </summary>
        public static float PistonGetTargetDistance(Piston Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the acceleration of the target Piston.
        /// </summary>
        public static void PistonSetAcceleration(Piston Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Moves the target piston to the input distance.
        /// </summary>
        public static void PistonSetDistance(Piston Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the max distance of a target Piston.
        /// </summary>
        public static void PistonSetMaxDistance(Piston Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed of a target Piston.
        /// </summary>
        public static void PistonSetSpeed(Piston Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the Marker distance of a target Piston.
        /// </summary>
        public static void PistonSetTargetDistance(Piston Target, float Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PlayAudioAtPosition(Audio Audio, Vector3 Position, float Volume, float PlaybackSpeed, bool Is2D)
        {
            return;
        }

        /// <summary>
        /// Adds a Role to a Player.
        /// </summary>
        public static void PlayerAddRole(Player Target, string Value)
        {
            return;
        }

        /// <summary>
        /// Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static bool PlayerAwardXP(Player Player, int Amount, AlternativeExec<bool> OnAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player's body.
        /// </summary>
        public static Quaternion PlayerBodyOrientation(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player's body in world space.
        /// </summary>
        public static Vector3 PlayerBodyPosition(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Clears any subtitle which is currently being displayed for the given player.
        /// </summary>
        public static void PlayerClearCurrentSubtitle(Player Player)
        {
            return;
        }

        /// <summary>
        /// This is very similar to an object board that you would find on any object, except this is for all players! After placing, make sure to configure it and make sure it is active. Edit into this board and add any other chips you'd like and know that each player will have the same logic on them when you hit done editing.
        /// </summary>
        public static void PlayerDefinitionBoard()
        {
            return;
        }

        /// <summary>
        /// For the target player, equip the specified Inventory Item to the specified Inventory Equipment Slot. If the Slot is of Inventory type, this chip will take effect whether or not the Slot is enabled, but the Slot must then be enabled separately.
        /// </summary>
        public static bool PlayerEquipInventoryItem(Player Player, InventoryItem InventoryItem, object InventoryEquipmentSlot, AlternativeExec<bool> OnEquipComplete)
        {
            return default;
        }

        /// <summary>
        /// Searches the room for all players with the input tag and outputs them as a list.
        /// </summary>
        public static List<Player> PlayerGetAllwithTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Returns whether a given player is allowed to teleport.
        public static bool PlayerGetCanTeleport(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the costume that the given player is currently wearing.
        /// </summary>
        public static Costume PlayerGetCostume(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether crouch input is enabled for a given player
        /// </summary>
        public static bool PlayerGetCrouchInputEnabled(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player has their right hand set as dominant.
        /// </summary>
        public static bool PlayerGetDominantHandIsRight(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Gets equipped objects from a player.
        /// </summary>
        public static (RecRoomObject DominantHandObject, RecRoomObject OffHandObject, RecRoomObject LeftHipHolsterObject, RecRoomObject RightHipHolsterObject, RecRoomObject ShoulderHolsterObject) PlayerGetEquippedObjects(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Gets the first player with the input tag.
        /// </summary>
        public static Player PlayerGetFirstwithTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Returns whether manual sprint is required for a given player
        /// </summary>
        public static bool PlayerGetForceManualSprint(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Outputs if a Player is authority of the input object.
        /// </summary>
        public static bool PlayerGetIsAuthorityOf(Player Target, RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static (bool IsJumpingOrFalling, RecRoomObject ContactSurface) PlayerGetIsJumpingOrFalling(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player is the local player executing the chip on their machine.
        /// </summary>
        public static bool PlayerGetIsLocal(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room's owners.
        /// </summary>
        public static bool PlayerGetIsRoomOwner(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the jump height for a given player
        /// </summary>
        public static float PlayerGetJumpHeight(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether jump input is enabled for a given player
        /// </summary>
        public static bool PlayerGetJumpInputEnabled(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Get the radio channel number of a player. If a player is not in any, this node returns -1
        /// </summary>
        public static int PlayerGetRadioChannel(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the unique index of this player in the room, bounded by the room capacity.
        /// </summary>
        public static int PlayerGetRoomIndex(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the current Room Level of the specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static int PlayerGetRoomLevel(Player Player)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Seat PlayerGetSeat(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether sprint input is enabled for a given player
        /// </summary>
        public static bool PlayerGetSprintInputEnabled(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the sprint speed for a given player
        /// </summary>
        public static float PlayerGetSprintSpeed(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Player Get Steering Direction
        /// </summary>
        public static Vector3 PlayerGetSteeringDirection(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the teleport delay for a given player
        /// </summary>
        public static float PlayerGetTeleportDelay(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the max teleport distance for a given player
        /// </summary>
        public static float PlayerGetTeleportDistance(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the offset of the given player's local time zone from UTC in seconds.
        /// </summary>
        public static int PlayerGetTimeZone(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the voice rolloff distance for a given player
        /// </summary>
        public static float PlayerGetVoiceRolloffDistance(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether walk input is enabled for a given player
        /// </summary>
        public static bool PlayerGetWalkInputEnabled(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns the walk speed for a given player
        /// </summary>
        public static float PlayerGetWalkSpeed(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Returns current XP of specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static int PlayerGetXP(Player Player)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player has the input role.
        /// </summary>
        public static bool PlayerHasRole(Player Target, string Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the forward vector of a Player's head.
        /// </summary>
        public static Vector3 PlayerHeadForwardVector(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the height of a Player's head.
        /// </summary>
        public static float PlayerHeadHeight(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player's head.
        /// </summary>
        public static Quaternion PlayerHeadOrientation(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of a Player's head in world space.
        /// </summary>
        public static Vector3 PlayerHeadPosition(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up vector of a Player's head.
        /// </summary>
        public static Vector3 PlayerHeadUpVector(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player's head.
        /// </summary>
        public static Vector3 PlayerHeadVelocity(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the Player is holding their Maker Pen.
        public static bool PlayerIsHoldingMakerPen(Player Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool PlayerIsInParty(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room's hosts.
        /// </summary>
        public static bool PlayerIsRoomHost(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room's moderators.
        /// </summary>
        public static bool PlayerIsRoomMod(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player's left hand finger.
        /// </summary>
        public static Vector3 PlayerLeftHandFingerDirection(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player's left hand in world space.
        /// </summary>
        public static Vector3 PlayerLeftHandPosition(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player's left hand.
        /// </summary>
        public static Quaternion PlayerLeftHandRotation(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player's left hand thumb.
        /// </summary>
        public static Vector3 PlayerLeftHandThumbDirection(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player's left hand.
        /// </summary>
        public static Vector3 PlayerLeftHandVelocity(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player owns at least one of the given inventory item.
        /// </summary>
        public static bool PlayerOwnsInventoryItem(Player Player, InventoryItem InventoryItem, AlternativeExec<bool> Complete)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool PlayerOwnsRoomKey(Player Player, RoomKey RoomKey, AlternativeExec<bool> OnPlayerOwnsRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a watch notification to the specified player containing the prompt title and body, along with each of the answer choices on its own line. Once this watch notification is opened, the player can choose a response and hit "ok," triggering the On Prompt Complete event. Since there is a delay between sending a notification and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses
        /// </summary>
        public static (bool Success, Player ReceivingPlayer, string Response, int ResponseIndex) PlayerPromptMultipleChoice(Player Player, string PromptTitle, string PromptBody, List<string> AnswerChoices, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response, int ResponseIndex)> OnPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PlayerReferenceBoard()
        {
            return;
        }

        /// <summary>
        /// Removes the input role from a target player.
        /// </summary>
        public static void PlayerRemoveRole(Player Target, string Value)
        {
            return;
        }

        /// <summary>
        /// Resets the color of the given player's name tag to the default color.
        /// </summary>
        public static void PlayerResetNameColor(Player Player)
        {
            return;
        }

        /// <summary>
        /// Outputs the direction of a Player's right hand finger.
        /// </summary>
        public static Vector3 PlayerRightHandFingerDirection(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player's right hand in world space.
        /// </summary>
        public static Vector3 PlayerRightHandPosition(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player's right hand.
        /// </summary>
        public static Quaternion PlayerRightHandRotation(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player's right hand thumb.
        /// </summary>
        public static Vector3 PlayerRightHandThumbDirection(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player's right hand.
        /// </summary>
        public static Vector3 PlayerRightHandVelocity(Player Target)
        {
            return default;
        }

        /// <summary>
        /// Sets whether a given player is allowed to teleport.
        public static void PlayerSetCanTeleport(Player Player, bool CanTeleport)
        {
            return;
        }

        /// <summary>
        /// Sets whether crouch input is enabled for a given player. Setting this to false will remove crouch button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetCrouchInputEnabled(Player Player, bool CrouchInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets whether manual sprint is required for a given player.
        public static void PlayerSetForceManualSprint(Player Player, bool ForceManualSprint)
        {
            return;
        }

        /// <summary>
        /// Sets the jump height for a given player
        /// </summary>
        public static void PlayerSetJumpHeight(Player Player, float JumpHeight)
        {
            return;
        }

        /// <summary>
        /// Sets whether jump input is enabled for a given player. Setting this to false will remove jump button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetJumpInputEnabled(Player Player, bool JumpInputEnabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PlayerSetNameColor(Player Player, Color Color)
        {
            return;
        }

        /// <summary>
        /// Assign a player to a radio channel. The channel needs to be a non-negative integer value. Players within the same channel will be able to communicate in team radio.
        /// </summary>
        public static void PlayerSetRadioChannel(Player Player, int Channel)
        {
            return;
        }

        /// <summary>
        /// Sets whether sprint input is enabled for a given player. Setting this to false will remove sprint button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetSprintInputEnabled(Player Player, bool SprintInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the sprint speed for a given player
        /// </summary>
        public static void PlayerSetSprintSpeed(Player Player, float SprintSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets the teleport delay for a given player
        /// </summary>
        public static void PlayerSetTeleportDelay(Player Player, float TeleportDelay)
        {
            return;
        }

        /// <summary>
        /// Sets the max teleport distance for a given player
        /// </summary>
        public static void PlayerSetTeleportDistance(Player Player, float TeleportDistance)
        {
            return;
        }

        /// <summary>
        /// Sets the voice rolloff distance for a given player. Beyond this distance, they cannot be heard.
        /// </summary>
        public static void PlayerSetVoiceRolloffDistance(Player Player, float VoiceRolloffDistance)
        {
            return;
        }

        /// <summary>
        /// Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetWalkInputEnabled(Player Player, bool WalkInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the walk speed for a given player
        /// </summary>
        public static void PlayerSetWalkSpeed(Player Player, float WalkSpeed)
        {
            return;
        }

        /// <summary>
        /// Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
        /// </summary>
        public static void PlayerShowSubtitle(Player Player, string Subtitle, float Duration, int Priority)
        {
            return;
        }

        /// <summary>
        /// Outputs True if the input Player subscribes to one of the current room's owners.
        /// </summary>
        public static (bool Result, int SecondsUntilEnabled) PlayerSubscribesToRoomOwner(Player Target)
        {
            return default;
        }

        /// <summary>
        /// For the target player, unequip the specified Inventory Item from any slot to which it is equipped.
        /// </summary>
        public static bool PlayerUnequipInventoryItem(Player Player, InventoryItem InventoryItem, AlternativeExec<bool> OnUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player PlayerVariable(Player Port0)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player PlayerVariableDeprecated(Player Port0)
        {
            return default;
        }

        /// <summary>
        /// Define a set of world-space UI elements that can appear above a player.
        /// </summary>
        public static PlayerWorldUI PlayerWorldUI()
        {
            return default;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(TriggerHandle Handle, int Duration, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(GunHandle Handle, int Duration, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(SwingHandle Handle, int Duration, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Multiplies a value by itself an input number of times.
        /// </summary>
        public static int Power(int Value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a value by itself an input number of times.
        /// </summary>
        public static float Power(float Value)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PrintTextToScreen(TextScreen Target, string Text, Color Color)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherFireProjectile(ProjectileLauncher Target, Vector3 Direction)
        {
            return;
        }

        /// <summary>
        /// Returns the player set by the Projectile Launcher Set Firing Player chip.
        /// </summary>
        public static Player ProjectileLauncherGetFiringPlayer(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ProjectileLauncherGetHandDamage(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ProjectileLauncherGetHeadDamage(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Color ProjectileLauncherGetProjectileColor(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ProjectileLauncherGetProjectileCount(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float ProjectileLauncherGetProjectileLifetime(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float ProjectileLauncherGetProjectileSpeed(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float ProjectileLauncherGetProjectileSpread(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        /// </summary>
        public static int ProjectileLauncherGetRecRoomObjectDamage(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ProjectileLauncherGetTorsoDamage(ProjectileLauncher Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the firing player of the target Projectile Launcher. If none is set, the component will use the authority player.
        /// </summary>
        public static void ProjectileLauncherSetFiringPlayer(ProjectileLauncher Target, Player Player)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetHandDamage(ProjectileLauncher Target, int Damage)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetHeadDamage(ProjectileLauncher Target, int Damage)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetProjectileColor(ProjectileLauncher Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetProjectileCount(ProjectileLauncher Target, int Count)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetProjectileLifetime(ProjectileLauncher Target, float Lifetime)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetProjectileSpeed(ProjectileLauncher Target, float Speed)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetProjectileSpread(ProjectileLauncher Target, float Spread)
        {
            return;
        }

        /// <summary>
        /// Sets the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        /// </summary>
        public static void ProjectileLauncherSetRecRoomObjectDamage(ProjectileLauncher Target, int Damage)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProjectileLauncherSetTorsoDamage(ProjectileLauncher Target, int Damage)
        {
            return;
        }

        /// <summary>
        /// Sends a watch notification to a player. The player which it sends a notification to depends on who's machine fires the exec pin. Once this watch notification is opened, the player can type responses into the text box and send back responses. You can define the prompt title and the prompt itself via inputs, and can also receive the player’s response via an output pin.
        /// </summary>
        public static string PromptLocalPlayer(string PromptTitle, string Prompt, AlternativeExec<string> Complete, AlternativeExec<string> Failed)
        {
            return default;
        }

        /// <summary>
        /// Manually create a quaternion. Congratulations, you have reached peak math.
        /// </summary>
        public static Quaternion QuaternionCreate(float X, float Y, float Z, float W)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation which rotates "Angle" degrees around "Axis".
        /// </summary>
        public static Quaternion QuaternionCreateAngleAxis(float Angle, Vector3 Axis)
        {
            return default;
        }

        /// <summary>
        /// Creates a quaternion from an input Vector3.
        /// </summary>
        public static Quaternion QuaternionCreateEulerAngles(Vector3 Angles)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation which rotates from "From" to "To".
        /// </summary>
        public static Quaternion QuaternionCreateFromTo(Vector3 From, Vector3 To)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation with the specified forward and upwards directions.
        /// </summary>
        public static Quaternion QuaternionCreateLook(Vector3 Forward, Vector3 Upwards)
        {
            return default;
        }

        /// <summary>
        /// The dot product between two rotations.
        /// </summary>
        public static float QuaternionDot(Quaternion Lhs, Quaternion Rhs)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input quaternion as a vector3.
        /// </summary>
        public static Vector3 QuaternionEulerAngles(Quaternion Value)
        {
            return default;
        }

        /// <summary>
        /// Gets the rotation which rotates angle degrees around axis.
        /// </summary>
        public static (float Angle, Vector3 Axis) QuaternionGetAngleAxis(Quaternion Quaternion)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Inverse of rotation.
        /// </summary>
        public static Quaternion QuaternionInverse(Quaternion Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input quaternion with the same rotation but with a magnitude of 1.
        /// </summary>
        public static Quaternion QuaternionNormalize(Quaternion Value)
        {
            return default;
        }

        /// <summary>
        /// Rotates a rotation from "From" towards "To".
        /// </summary>
        public static Quaternion QuaternionRotateTowards(Quaternion From, Quaternion To, float MaxDegreesDelta)
        {
            return default;
        }

        /// <summary>
        /// Split a quaternion into its four float components: x, y, z, and w. Congratulations, you have reached peak math.
        /// </summary>
        public static (float X, float Y, float Z, float W) QuaternionSplit(Quaternion Quaternion)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Quaternion QuaternionVariable(Quaternion Port0)
        {
            return default;
        }

        /// <summary>
        /// Generates a random float from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, both 0 and 1 have the possibility of getting output because they are both included in the range.
        /// </summary>
        public static float RandomFloat(float Min, float Max)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static T RandomFromList<T>(List<T> List)
        {
            return default;
        }

        /// <summary>
        /// Outputs a random value from a target list.
        /// </summary>
        public static T RandomFromListDeprecated<T>(List<T> List)
        {
            return default;
        }

        /// <summary>
        /// Generates a random integer from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, 0 and 1 will have a chance of being output.
        /// </summary>
        public static int RandomInt(int Min, int Max)
        {
            return default;
        }

        /// <summary>
        /// Fires an invisible ray from the "Start Position", in the "Direction" specified. Returns True if any object or player is hit within the target "Max Distance". Otherwise, returns False. You can configure the chip itself to ignore players or objects specifically.
        /// </summary>
        public static (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Raycast(Vector3 StartPosition, Vector3 Direction, float MaxDistance)
        {
            return default;
        }

        /// <summary>
        /// Recalcualtes and updates the current room authority based on parameters such as their network connection and platform.
        /// </summary>
        public static bool RecalculateRoomAuthority()
        {
            return default;
        }

        /// <summary>
        /// Searches the room for all objects with the input tag and outputs them as a list.
        /// </summary>
        public static List<RecRoomObject> RecRoomObjectGetAllwithTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Outputs the authority Player of the input object.
        /// </summary>
        public static Player RecRoomObjectGetAuthority(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the first object with the input tag.
        /// </summary>
        public static RecRoomObject RecRoomObjectGetFirstwithTag(string Tag)
        {
            return default;
        }

        /// <summary>
        /// Gets the player currently holding this object. Does not account for when objects are equipped but not directly grabbed. Returns Invalid Player if the object is not being held.
        /// </summary>
        public static (bool IsHeld, Player HolderPlayer) RecRoomObjectGetHolderPlayer(RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True on the player's machine who has authority of the input.
        /// </summary>
        public static bool RecRoomObjectGetIsLocalPlayerAuthority(RecRoomObject Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the player who last held or equipped an object.
        /// </summary>
        public static (Player Player, bool CurrentlyHeldOrEquipped) RecRoomObjectGetLastHoldingOrEquippingPlayer(RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// Resets an object.
        /// </summary>
        public static void RecRoomObjectReset(RecRoomObject Object)
        {
            return;
        }

        /// <summary>
        /// Sets the authority player of the input Rec Room Object.
        /// </summary>
        public static void RecRoomObjectSetAuthority(RecRoomObject Target, Player Authority)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static RecRoomObject RecRoomObjectVariable(RecRoomObject Port0)
        {
            return default;
        }

        /// <summary>
        /// Remove a player from the radio channel they are in
        /// </summary>
        public static void RemovePlayerFromRadioChannel(Player Player)
        {
            return;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public static void RemoveTag(Player Target, string Tag)
        {
            return;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public static void RemoveTag(RecRoomObject Target, string Tag)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public static void RemoveTags(Player Target, List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public static void RemoveTags(RecRoomObject Target, List<string> Tags)
        {
            return;
        }

        /// <summary>
        /// Used to remove spaghetti from your creations. Consumes additional CPU heat.
        /// </summary>
        public static T Reroute<T>(T Port0)
        {
            return default;
        }

        /// <summary>
        /// Reset the player's active world UI to its default values.
        /// </summary>
        public static void ResetPlayerWorldUI(Player Player)
        {
            return;
        }

        /// <summary>
        /// Resets the Room.
        /// </summary>
        public static void ResetRoom()
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Player Target, Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Player Target, Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(RecRoomObject Target, Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(RecRoomObject Target, Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Player Target, Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Player Target, Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(RecRoomObject Target, Vector3 Position, Vector3 Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(RecRoomObject Target, Vector3 Position, Quaternion Rotation, float SpawnRadius, bool ClearVelocity, bool UseRezEffects, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RespawnPointAddAvoidRole(PlayerSpawnPointV2 SpawnPoint, string Role)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointAddAvoidTag(PlayerSpawnPointV2 SpawnPoint, string Tag)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RespawnPointAddSpawnRole(PlayerSpawnPointV2 SpawnPoint, string Role)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointAddSpawnTag(PlayerSpawnPointV2 SpawnPoint, string Tag)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RespawnPointGetActive(PlayerSpawnPointV2 Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRemoveAvoidRole(PlayerSpawnPointV2 SpawnPoint, string Role)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRemoveAvoidTag(PlayerSpawnPointV2 SpawnPoint, string Tag)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRemoveSpawnRole(PlayerSpawnPointV2 SpawnPoint, string Role)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRemoveSpawnTag(PlayerSpawnPointV2 SpawnPoint, string Tag)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRespawnPlayer(Player Player, bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointRespawnPlayerAtRespawnPoint(PlayerSpawnPointV2 SpawnPoint, Player Player, bool ClearVelocity, bool UseRezEffects)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RespawnPointSetActive(PlayerSpawnPointV2 Target, bool Active)
        {
            return;
        }

        /// <summary>
        /// Get a reference to a single Reward. Rewards can be created in the Rewards tab of the Room Settings menu
        /// </summary>
        public static Reward Reward()
        {
            return default;
        }

        /// <summary>
        /// Return a color from the given red, green, and blue inputs. All inputs are in the range [0, 1].
        /// </summary>
        public static Color RGBToColor(float Red, float Green, float Blue)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomBackgroundObjectsModify(BackgroundObjects BackgroundObjectsConstant, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RoomBackgroundObjectsReset(AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static RoomCurrency RoomCurrencyConstant()
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomFogModify(Fog FogConstant, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RoomFogReset(AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomGetMatchmakingState()
        {
            return default;
        }

        /// <summary>
        /// Returns the player in the room with this unique index, bounded by the room capacity.
        /// </summary>
        public static Player RoomIndexGetPlayer(int RoomIndex)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RoomKey RoomKeyConstant()
        {
            return default;
        }

        /// <summary>
        /// HUD elements including progress bars, wheels, and counters. Configure to customize a single element, then enable & modify with existing HUD chips. Can be configured to pull data from Room Progression if Progression is enabled in room settings.
        /// </summary>
        public static RoomLevelHUD RoomLevelHUD()
        {
            return default;
        }

        /// <summary>
        /// A specialized data table for use with Room Progression, with some cells and formatting choices reserved. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room via Data Table UI to commit changes.
        /// </summary>
        public static void RoomLevels(object Levels)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomSetMatchmakingState(bool MatchmakingPermitted, AlternativeExec<bool> OnMatchmakingStateSet)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomSkydomeModify(Skydome SkydomeConstant, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RoomSkydomeReset(AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool RoomSunModify(Sun SunConstant, SunDirection SunDirection, AlternativeExec<bool> BlendFinished)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RoomSunReset(AlternativeExec BlendFinished)
        {
            return;
        }

        /// <summary>
        /// Calculate the root of a given value, with the default root being 2 (meaning the square root).
        /// </summary>
        public static float Root(float Value, float Root)
        {
            return default;
        }

        /// <summary>
        /// Rotate a Vector3 with a Quaternion.
        /// </summary>
        public static Vector3 RotateVector(Quaternion Rotation, Vector3 Point)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a target Rotator in degrees.
        /// </summary>
        public static float RotatorGetRotation(Rotator Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the acceleration of a target Rotator.
        /// </summary>
        public static float RotatorGetRotationAcceleration(Rotator Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the speed of a target Rotator.
        /// </summary>
        public static float RotatorGetRotationSpeed(Rotator Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the Marker on the target Rotator.
        /// </summary>
        public static float RotatorGetTargetRotation(Rotator Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of a target Rotator.
        /// </summary>
        public static void RotatorSetRotation(Rotator Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the acceleration of a target Rotator.
        /// </summary>
        public static void RotatorSetRotationAcceleration(Rotator Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed of a target Rotator.
        /// </summary>
        public static void RotatorSetRotationSpeed(Rotator Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Sets the rotation of the Marker on a target Rotator.
        /// </summary>
        public static void RotatorSetTargetRotation(Rotator Target, float Value)
        {
            return;
        }

        /// <summary>
        /// Rounds the input float to the nearest integral value.
        /// </summary>
        public static float Round(float Value)
        {
            return default;
        }

        /// <summary>
        /// Rounds an input value to the nearest integer.
        /// </summary>
        public static int RoundtoInt(float Value)
        {
            return default;
        }

        /// <summary>
        /// Record and store custom a custom audio sample, for use with the Audio Player.
        /// </summary>
        public static Audio SampleAudioConstant()
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Seat is set to lock players in.
        /// </summary>
        public static bool SeatGetLockPlayersIn(Seat Target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Seat is set to lock players out.
        /// </summary>
        public static bool SeatGetLockPlayersOut(Seat Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the currently seated player of a target Seat.
        /// </summary>
        public static Player SeatGetSeatedPlayer(Seat Target)
        {
            return default;
        }

        /// <summary>
        /// Prevents a Seated player from unseating themselves on a target Seat. Use circuits to unseat or unlock.
        /// </summary>
        public static void SeatSetLockPlayersIn(Seat Target, bool LockPlayersIn)
        {
            return;
        }

        /// <summary>
        /// Prevents players from sitting in a target seat.
        /// </summary>
        public static void SeatSetLockPlayersOut(Seat Target, bool LockPlayersOut)
        {
            return;
        }

        /// <summary>
        /// Seats an input player on a target Seat.
        /// </summary>
        public static void SeatSetSeatedPlayer(Seat Target, Player Player, AlternativeExec Fail)
        {
            return;
        }

        /// <summary>
        /// Unseats a currently seated player on a target Seat.
        /// </summary>
        public static void SeatUnseatPlayer(Seat Target)
        {
            return;
        }

        /// <summary>
        /// Outputs the object of the current context. For example, a self node inside a light outputs that specific light of the light type. This can only be placed inside an object board of a specific object or a player or object definition board.
        /// </summary>
        internal static int Self()
        {
            return default;
        }

        /// <summary>
        /// Executes all output ports in order.
        /// </summary>
        public static void Sequence<T>(AlternativeExec _2)
        {
            return;
        }

        /// <summary>
        /// Start a screen shake effect for the given player. This will have no effect on VR players.
        /// </summary>
        public static void SetCameraShake(Player Player, float Intensity, float Duration)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementColor(HUDConstant Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementLabel(HUDConstant Target, string Label)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementLabelEnabled(HUDConstant Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementMaxValue(HUDConstant Target, int Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementValue(HUDConstant Target, int Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetGameHUDElementValueTextEnabled(HUDConstant Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetHUDElementEnabled(HUDConstant Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
        /// </summary>
        public static void SetPlayerVignette(Player Player, float Time, Color Color, float Intensity)
        {
            return;
        }

        /// <summary>
        /// Set the color of the primary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarColor(Player Player, Color Color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the primary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarEnabled(Player Player, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Set the max value of the primary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarMaxValue(Player Player, int Value)
        {
            return;
        }

        /// <summary>
        /// Set the value of the primary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarValue(Player Player, int Value)
        {
            return;
        }

        /// <summary>
        /// Set the color of the secondary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarColor(Player Player, Color Color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the secondary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarEnabled(Player Player, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Set the max value of the secondary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarMaxValue(Player Player, int Value)
        {
            return;
        }

        /// <summary>
        /// Set the value of the secondary bar in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarValue(Player Player, int Value)
        {
            return;
        }

        /// <summary>
        /// Set the color of the text in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextColor(Player Player, Color Color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the text in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextEnabled(Player Player, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Set the value of the text in the given player's active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextValue(Player Player, string Value)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPosition(Player Target, Vector3 Position)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPosition(RecRoomObject Target, Vector3 Position)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(Player Target, Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(RecRoomObject Target, Vector3 Position, AlternativeExec Failed)
        {
            return;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Player Target, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Player Target, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(RecRoomObject Target, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(RecRoomObject Target, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Player Target, Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Player Target, Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(RecRoomObject Target, Vector3 Position, Vector3 Rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(RecRoomObject Target, Vector3 Position, Quaternion Rotation)
        {
            return default;
        }

        /// <summary>
        /// Choose from a selection of SFX, for use with the Audio Player.
        /// </summary>
        public static Audio SFXConstant()
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool SFXGetIsPlaying(SFX Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the volume of an SFX object.
        /// </summary>
        public static int SFXGetVolume(SFX Target)
        {
            return default;
        }

        /// <summary>
        /// Plays a sound from an SFX object.
        /// </summary>
        public static void SFXPlay(SFX Target)
        {
            return;
        }

        /// <summary>
        /// Sets the volume for an SFX object.
        /// </summary>
        public static void SFXSetVolume(SFX Target, int Value)
        {
            return;
        }

        /// <summary>
        /// Stops the sound currently playing from an SFX object.
        /// </summary>
        public static void SFXStop(SFX Target)
        {
            return;
        }

        /// <summary>
        /// Prints the input notification to the given player's screen.
        /// </summary>
        public static void ShowNotification<T>(Player Player, string Value)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePrompt(RoomKey InRoomPurchasable, Player Player)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePrompt(Consumable InRoomPurchasable, Player Player)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePrompt(RoomCurrency InRoomPurchasable, Player Player)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(Player Player, Reward Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(Player Player, List<Reward> Reward, float Duration)
        {
            return;
        }

        /// <summary>
        /// Computes the sine of a number.
        /// </summary>
        public static float Sin(float Value)
        {
            return default;
        }

        /// <summary>
        /// Defines values for the room skydome.
        /// </summary>
        public static Skydome SkydomeConstant()
        {
            return default;
        }

        /// <summary>
        /// Spherically interpolates between quaternions or Vector3s "Start" and "End". Progress is 0 to 1. Also a rare, but refreshing beverage.
        /// </summary>
        public static Quaternion Slerp(Quaternion Start, Quaternion End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Spherically interpolates between quaternions or Vector3s "Start" and "End". Progress is 0 to 1. Also a rare, but refreshing beverage.
        /// </summary>
        public static Vector3 Slerp(Vector3 Start, Vector3 End, float Progress)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards a target, with velocity based damping
        /// </summary>
        public static (float Result, float ResultVelocity) SmoothDamp(float Current, float Target, float CurrentVelocity, float SmoothTime, float MaxSpeed, float DeltaTime)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards a target, with velocity based damping
        /// </summary>
        public static (Vector3 Result, Vector3 ResultVelocity) SmoothDamp(Vector3 Current, Vector3 Target, Vector3 CurrentVelocity, float SmoothTime, float MaxSpeed, float DeltaTime)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SpawnerInternalStartSpawning(RecRoomObject Spawner, int Amountofobjectstospawn, float Timebetweenspawns, Vector3 SpawnPosition)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SpawnerReset(RecRoomObject Port0)
        {
            return;
        }

        /// <summary>
        /// Fires an invisible sphere of the specified Radius from the Start Position, in the Direction specified. Returns true if any object or player is hit within the target Max Distance. Otherwise, returns false. You can configure the chip itself to ignore players or objects specifically.
        /// </summary>
        public static (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Spherecast(Vector3 StartPosition, float Radius, Vector3 Direction, float MaxDistance)
        {
            return default;
        }

        /// <summary>
        /// Place this chip inside a State Machine chip to represent a state.
        /// </summary>
        public static void State()
        {
            return;
        }

        /// <summary>
        /// A constant representing a state in a state machine.
        /// </summary>
        public static State StateConstant()
        {
            return default;
        }

        /// <summary>
        /// Manage state transitions by editing into this chip and populating it with connected State chips.
        /// </summary>
        public static void StateMachine()
        {
            return;
        }

        /// <summary>
        /// Stop any current screen shake for the given player.
        /// </summary>
        public static void StopCameraShake(Player Player)
        {
            return;
        }

        /// <summary>
        /// Concatenate a given series of strings in order, with an optional separator.
        /// </summary>
        public static string StringConcat(params string[] Separator)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target string contains the input value.
        /// </summary>
        public static bool StringContains(string String, string Sequence)
        {
            return default;
        }

        /// <summary>
        /// Use this chip to combine multiple strings together into a single string output. The "Format" input is part of final string output and can include other string inputs by using this syntax: {input pin # starting at 0}. For example, a "Format" input with a default value of “Hello, {0}!” with a single additional input pin with the value "World" is fully output as "Hello, World!". If you had another input pin you would use {1} to denote the 2nd pin. You can add more string inputs by configuring the chip and pressing "Add Input".
        /// </summary>
        public static string StringFormat(string Format, string Value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the index where the substring starts in the target string.
        /// </summary>
        public static int StringIndexOf(string String, string Substring)
        {
            return default;
        }

        /// <summary>
        /// Outputs the length of a target string in UTF-16 characters.
        /// </summary>
        public static int StringLength(string String)
        {
            return default;
        }

        /// <summary>
        /// Replaces all instances of pattern within string with replacement.
        /// </summary>
        public static string StringReplace(string String, string Pattern, string Replacement)
        {
            return default;
        }

        /// <summary>
        /// Splits the target string at the input character.
        /// </summary>
        public static List<string> StringSplit(string String, string Divider)
        {
            return default;
        }

        /// <summary>
        /// Splits the target string in two at the input index.
        /// </summary>
        public static List<string> StringSplitAtIndex(string String, int Index)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of strings which split up by whitespace.
        /// </summary>
        public static List<string> StringSplitWhitespace(string String)
        {
            return default;
        }

        /// <summary>
        /// Allows you to extract individual parts from a string. You can think of this like a list of characters.
        /// </summary>
        public static string StringSubstring(string String, int Index, int Length)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target string in lower case.
        /// </summary>
        public static string StringToLower(string String)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target string in upper case.
        /// </summary>
        public static string StringToUpper(string String)
        {
            return default;
        }

        /// <summary>
        /// Outputs the string with leading and trailing whitespace removed.
        /// </summary>
        public static string StringTrim(string String)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static string stringVariable(string Port0)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Audio StudioAudioConstant()
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSender(StudioObject StudioObject, string Event)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderBool(StudioObject StudioObject, string Event, bool Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderFloat(StudioObject StudioObject, string Event, float Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderInt(StudioObject StudioObject, string Event, int Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderString(StudioObject StudioObject, string Event, string Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderStringBool(StudioObject StudioObject, string Event, string Value0, bool Value1)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderStringFloat(StudioObject StudioObject, string Event, string Value0, float Value1)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderStringInt(StudioObject StudioObject, string Event, string Value0, int Value1)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StudioEventSenderStringString(StudioObject StudioObject, string Event, string Value0, string Value1)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool StudioObjectGetPropertyBool(StudioObject StudioObject, string Property)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float StudioObjectGetPropertyFloat(StudioObject StudioObject, string Property)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int StudioObjectGetPropertyInt(StudioObject StudioObject, string Property)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string StudioObjectGetPropertyString(StudioObject StudioObject, string Property)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static int Subtract(params int[] Value)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static float Subtract(params float[] Value)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static Vector3 Subtract(params Vector3[] Value)
        {
            return default;
        }

        /// <summary>
        /// Defines values for the room's sun.
        /// </summary>
        public static Sun SunConstant()
        {
            return default;
        }

        /// <summary>
        /// Computes the tangent of a number.
        /// </summary>
        public static float Tan(float Value)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target Text gadget.
        /// </summary>
        public static Color TextGetColor(Text Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the visible text for a Text object.
        /// </summary>
        public static string TextGetText(Text Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color for a Text object.
        /// </summary>
        public static void TextSetColor(Text Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a Text object.
        /// </summary>
        public static void TextSetColorId(Text Target, int Color)
        {
            return;
        }

        /// <summary>
        /// Sets the material for a Text object.
        /// </summary>
        public static void TextSetMaterial(Text Target, int Material)
        {
            return;
        }

        /// <summary>
        /// Set the visible text for a Text object.
        /// </summary>
        public static void TextSetText(Text Target, string Text)
        {
            return;
        }

        /// <summary>
        /// Gets the amount of seconds since a player launched Rec Room.
        /// </summary>
        public static float TimeGetPreciseSeconds()
        {
            return default;
        }

        /// <summary>
        /// Gets the number of seconds since 1970. Uses server's clock. This will be synchronized between players. This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        /// </summary>
        public static int TimeGetUniversalSeconds()
        {
            return default;
        }

        /// <summary>
        /// Gets the UTC time. Uses server's clock. This will be synchronized between players.
        /// </summary>
        public static (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUniversalTime()
        {
            return default;
        }

        /// <summary>
        /// Gets the number of seconds since 1970. Uses local player's system clock. This is not synchronized between players! This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        /// </summary>
        public static int TimeGetUnsyncedUniversalSeconds()
        {
            return default;
        }

        /// <summary>
        /// Gets the UTC time. Uses local player's system clock. This is not synchronized between players!
        /// </summary>
        public static (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUnsyncedUniversalTime()
        {
            return default;
        }

        /// <summary>
        /// Covert a player or an AI value into a Combatant value.
        /// </summary>
        public static Combatant ToCombatant(AI PlayerorAI)
        {
            return default;
        }

        /// <summary>
        /// Covert a player or an AI value into a Combatant value.
        /// </summary>
        public static Combatant ToCombatant(Player PlayerorAI)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the toggle button is pressed.
        /// </summary>
        public static bool ToggleButtonGetIsPressed(ToggleButton Target)
        {
            return default;
        }

        /// <summary>
        /// Sets a Toggle Button state to pressed.
        /// </summary>
        public static void ToggleButtonSetIsPressed(ToggleButton Target, bool Value)
        {
            return;
        }

        /// <summary>
        /// Casts a target specific object to a Rec Room Object.
        /// </summary>
        public static RecRoomObject ToRecRoomObject<T>(T Target)
        {
            return default;
        }

        /// <summary>
        /// Converts the input value to the string type. Example: the integer input 10 would output "10" as a string. Helpful for debugging purposes.
        /// </summary>
        public static string ToString<T>(T Value)
        {
            return default;
        }

        /// <summary>
        /// Converts the input value to the string type. Example: the integer input 10 would output "10" as a string. Helpful for debugging purposes.
        /// </summary>
        public static string ToStringDepreacted<T>(T Value)
        {
            return default;
        }

        /// <summary>
        /// Get the active touch position from the local player's interaction
        /// </summary>
        public static (bool IsTouchActive, Vector3 TouchPosition, Vector3 WorldPosition) TouchpadComponentGetActiveTouch(Touchpad Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the interaction label (used by Screen players)
        /// </summary>
        public static string TouchpadComponentGetInteractionLabel(Touchpad Target)
        {
            return default;
        }

        /// <summary>
        /// Sets if the Touchpad can be interacted with or output touch events
        /// </summary>
        public static bool TouchpadComponentGetIsEnabled(Touchpad Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the interaction label (used by Screen players)
        /// </summary>
        public static void TouchpadComponentSetInteractionLabel(Touchpad Target, string Label)
        {
            return;
        }

        /// <summary>
        /// Gets if the Touchpad can be interacted with or output touch events
        /// </summary>
        public static void TouchpadComponentSetIsEnabled(Touchpad Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Returns the color of the target Motion Trail object.
        /// </summary>
        public static Color TrailGetColor(MotionTrail Target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Motion Trail object is enabled.
        /// </summary>
        public static bool TrailGetEnabled(MotionTrail Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the lifetime of the target Motion Trail object.
        /// </summary>
        public static float TrailGetLifetime(MotionTrail Target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max opacity of the target Motion Trail object.
        /// </summary>
        public static float TrailGetOpacity(MotionTrail Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color of the target Motion Trail object.
        /// </summary>
        public static void TrailSetColor(MotionTrail Target, Color Color)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of the target Motion Trail object.
        /// </summary>
        public static void TrailSetEnabled(MotionTrail Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the lifetime of the target Motion Trail object.
        /// </summary>
        public static void TrailSetLifetime(MotionTrail Target, float Lifetime)
        {
            return;
        }

        /// <summary>
        /// Sets the max opacity of the target Motion Trail object.
        /// </summary>
        public static void TrailSetOpacity(MotionTrail Target, float MaxOpacity)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string TriggerHandleGetControlPrompt(TriggerHandle Target)
        {
            return default;
        }

        /// <summary>
        /// True if the primary action button is down; otherwise, False.
        /// </summary>
        public static bool TriggerHandleGetPrimaryActionHeld(TriggerHandle Target)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void TriggerHandleSetControlPrompt(TriggerHandle Target, string ControlPrompt)
        {
            return;
        }

        /// <summary>
        /// Gets the role name that is being used as a filter for a Trigger Volume.
        /// </summary>
        public static string TriggerVolumeGetFilterRole(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the tags that are being used as a filter for a Trigger Volume.
        /// </summary>
        public static List<string> TriggerVolumeGetFilterTags(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        /// </summary>
        public static int TriggerVolumeGetObjectCount(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        /// </summary>
        public static List<RecRoomObject> TriggerVolumeGetObjects(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        /// </summary>
        public static int TriggerVolumeGetPlayerCount(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
        /// </summary>
        public static List<Player> TriggerVolumeGetPlayers(TriggerVolume Target)
        {
            return default;
        }

        /// <summary>
        /// Sets the role name that is being used as a filter for a Trigger Volume.
        /// </summary>
        public static void TriggerVolumeSetFilterRole(TriggerVolume Target, string Value)
        {
            return;
        }

        /// <summary>
        /// Sets the tags that are being used as a filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
        /// </summary>
        public static void TriggerVolumeSetFilterTags(TriggerVolume Target, List<string> Value)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool UnequipFromPlayer(Player Player, RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static List<RecRoomObject> UnequipfromSlots(Player Player, bool DominantHand, bool OffHand, bool LeftHipHolster, bool RightHipHolster, bool ShoulderHolster)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool UnequipObject(RecRoomObject Object)
        {
            return default;
        }

        /// <summary>
        /// Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.
        /// </summary>
        public static T ValueIntegerSwitch<T>(int Match, T Default)
        {
            return default;
        }

        /// <summary>
        /// Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.
        /// </summary>
        public static T ValueStringSwitch<T>(string Match, T Default)
        {
            return default;
        }

        /// <summary>
        /// Clamps a vector's magnitude to a given max length.
        public static Vector3 Vector3ClampMagnitude(Vector3 Vector, float MaxLength)
        {
            return default;
        }

        /// <summary>
        /// Gets the point on the plane that is closest to a given position
        /// </summary>
        public static Vector3 Vector3ClosestPointOnPlane(Vector3 Position, Vector3 PlanePosition, Vector3 PlaneNormal)
        {
            return default;
        }

        /// <summary>
        /// Creates a new vector from X, Y, Z values.
        /// </summary>
        public static Vector3 Vector3Create(float X, float Y, float Z)
        {
            return default;
        }

        /// <summary>
        /// The cross product of two vectors results in a third vector which is perpendicular to the two input vectors.
        /// </summary>
        public static Vector3 Vector3Cross(Vector3 Lhs, Vector3 Rhs)
        {
            return default;
        }

        /// <summary>
        /// Computes the dot product. Commonly used to determine if the camera is facing a particular direction.
        /// </summary>
        public static float Vector3Dot(Vector3 Lhs, Vector3 Rhs)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Vector3 Vector3InverseTransform(Vector3 WorldPoint, Vector3 WorldOrigin, Quaternion WorldOrientation)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards target, not moving more than max delta distance at a time
        /// </summary>
        public static Vector3 Vector3MoveTowards(Vector3 Current, Vector3 Target, float MaxDelta)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target vector, but its magnitude is 1.
        /// </summary>
        public static Vector3 Vector3Normalize(Vector3 Value)
        {
            return default;
        }

        /// <summary>
        /// Projects a vector onto a normal
        /// </summary>
        public static Vector3 Vector3Project(Vector3 Vector, Vector3 OnNormal)
        {
            return default;
        }

        /// <summary>
        /// Projects a vector onto a plane
        /// </summary>
        public static Vector3 Vector3ProjectOnPlane(Vector3 Vector, Vector3 PlaneNormal)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        public static Vector3 Vector3Scale(Vector3 Value, int Scalar)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        public static Vector3 Vector3Scale(Vector3 Value, float Scalar)
        {
            return default;
        }

        /// <summary>
        /// Breaks the X, Y, and Z values out of the input vector.
        /// </summary>
        public static (float X, float Y, float Z) Vector3Split(Vector3 Vector3)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Vector3 Vector3Transform(Vector3 LocalPoint, Vector3 WorldOrigin, Quaternion WorldOrientation)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Vector3 Vector3Variable(Vector3 Port0)
        {
            return default;
        }

        /// <summary>
        /// Gets the direction and magnitude of the Vector Component.
        /// </summary>
        public static Vector3 VectorComponentGetVector(VectorComponent Direction, float Magnitude)
        {
            return default;
        }

        /// <summary>
        /// Outputs the length of the input vector.
        /// </summary>
        public static float VectorGetMagnitude(Vector3 Vector3)
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(Player Target, float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(RecRoomObject Target, float Speed, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(Player Target, float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(RecRoomObject Target, float AdditionalSpeed, float SpeedMultiplier, Vector3 Direction, float MaximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(Player Target, float Speed, Vector3 Direction)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(RecRoomObject Target, float Speed, Vector3 Direction)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(Player Target, float Speed, Vector3 Direction)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(RecRoomObject Target, float Speed, Vector3 Direction)
        {
            return;
        }

        /// <summary>
        /// Return whether target welcome mat is enabled (true) or disabled (false)
        /// </summary>
        public static bool WelcomeMatGetEnabled(WelcomeMat Target)
        {
            return default;
        }

        /// <summary>
        /// Set target welcome mat to be enabled (true) or disabled (false)
        /// </summary>
        public static void WelcomeMatSetEnabled(WelcomeMat Target, bool Enabled)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Xor(bool Input)
        {
            return default;
        }
    }
}