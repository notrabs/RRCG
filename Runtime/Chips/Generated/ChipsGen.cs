using System.Collections.Generic;
using UnityEngine;
using RRCGSource;
using RRCG;
using Light = RRCGSource.Light;

namespace RRCGGenerated
{
    public class ChipsGen
    {
        /// <summary>
        /// Outputs the magnitude of the number. Is always positive.
        /// </summary>
        public static float AbsoluteValue(float value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the magnitude of the number. Is always positive.
        /// </summary>
        public static int AbsoluteValue(int value)
        {
            return default;
        }

        /// <summary>
        /// Computes the arccosine of a number.
        /// </summary>
        public static float Acos(float value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static int Add(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static float Add(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Computes the sum of two or more inputs.
        /// </summary>
        internal static Vector3 Add(params Vector3[] value)
        {
            return default;
        }

        /// <summary>
        /// Adds a tag to the input object or player.
        /// </summary>
        public static void AddTag(Player target, string tag)
        {
            return;
        }

        /// <summary>
        /// Adds a tag to the input object or player.
        /// </summary>
        public static void AddTag(RecRoomObject target, string tag)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public static void AddTags(Player target, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Adds tags to the input object or player.
        /// </summary>
        public static void AddTags(RecRoomObject target, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Outputs the current line of sight parameters from the input AI.
        /// </summary>
        public static (string VisionType, float VisionRange, float VisionConeAngle, float HearingRange) AIGetLineOfSightParametersR1(AI aI)
        {
            return default;
        }

        /// <summary>
        /// Outputs the current combat target of an inputted AI.
        /// </summary>
        public static Combatant AIGetTargetR1(AI aI)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, AI target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, Combatant target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, PatrolPoint target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the input AI has line of sight to the input target.
        /// </summary>
        public static bool AIHasLineOfSightToTargetR1(AI aI, Vector3 target)
        {
            return default;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, AI lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, Combatant lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, RecRoomObject lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, PatrolPoint lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, Player lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
        /// </summary>
        public static void AILookAtR1(AI aI, Vector3 lookTarget, bool lookTargetIsDirection)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, AI target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, Combatant target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, RecRoomObject target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, PatrolPoint target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, Player target)
        {
            return;
        }

        /// <summary>
        /// Commands the AI to path to the input target destination.
        /// </summary>
        public static void AIPathToR1(AI aI, Vector3 target)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotateR1(AI aI, float rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotateR1(AI aI, int rotation)
        {
            return;
        }

        /// <summary>
        /// Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
        /// </summary>
        public static void AIRotateR1(AI aI, Vector3 rotation)
        {
            return;
        }

        /// <summary>
        /// Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
        /// </summary>
        public static void AISetLineOfSightParametersR1(AI aI, string visionType, float visionRange, float visionConeAngle, float hearingRange, bool requireLoSForTargeting)
        {
            return;
        }

        /// <summary>
        /// Sets the speed for an inputted AI. This same setting can be determined by configuring the AI itself.
        /// </summary>
        public static void AISetPathingSpeedR1(AI aI, float speed)
        {
            return;
        }

        /// <summary>
        /// Set an AIs Path Point.
        /// </summary>
        public static void AISetPatrolPointR1(AI aI, PatrolPoint patrolPoint)
        {
            return;
        }

        /// <summary>
        /// Sets the input AI’s current target.
        /// </summary>
        public static void AISetTargetR1(AI aI, Combatant target)
        {
            return;
        }

        /// <summary>
        /// RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
        /// </summary>
        public static void AIStartCombatBehaviorR1(AI aI)
        {
            return;
        }

        /// <summary>
        /// Tells the input AI to stop its C# defined combat behavior.
        /// </summary>
        public static void AIStopCombatBehaviorR1(AI aI)
        {
            return;
        }

        /// <summary>
        /// Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
        /// </summary>
        public static void AIStopLookingR1(AI aI)
        {
            return;
        }

        internal static AI AIVariableR1(AI port1, VariableData config)
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
        public static bool And(params bool[] input)
        {
            return default;
        }

        /// <summary>
        /// Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
        /// </summary>
        public static bool AngularVelocityAdd(RecRoomObject target, Vector3 angularVelocity, float speedMultiplier, float maxAngularSpeed)
        {
            return default;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObject target, Vector3 rotation, float velocityMultiplier, float maxAngularVelocityApplied)
        {
            return;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObject target, Quaternion rotation, float velocityMultiplier, float maxAngularVelocityApplied)
        {
            return;
        }

        /// <summary>
        /// Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
        /// </summary>
        public static bool AngularVelocitySet(RecRoomObject target, Vector3 angularVelocity, float speedMultiplier)
        {
            return default;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObject target, Vector3 rotation, float velocityMultiplier)
        {
            return;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObject target, Quaternion rotation, float velocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Returns the current frame of the given animation controller component.
        /// </summary>
        public static int AnimationGetFrame(AnimationController animator)
        {
            return default;
        }

        /// <summary>
        /// Returns whether or not the Animation Controller is currently playing.
        /// </summary>
        public static bool AnimationGetIsPlaying(AnimationController animator)
        {
            return default;
        }

        /// <summary>
        /// Returns the normalized speed of the given Animation Controller.
        /// </summary>
        public static float AnimationGetSpeed(AnimationController animator)
        {
            return default;
        }

        /// <summary>
        /// Returns the current time stamp of the given animation controller. The value is not impacted by the animation speed.
        /// </summary>
        public static float AnimationGetTimeStamp(AnimationController animator)
        {
            return default;
        }

        /// <summary>
        /// Pauses the Animation Controller. The Animation Controller resumes at the same moment next time play is activated.
        /// </summary>
        public static void AnimationPause(AnimationController animator)
        {
            return;
        }

        /// <summary>
        /// Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller&apos;s configuration menu.
        /// </summary>
        public static void AnimationPlay(AnimationController animator)
        {
            return;
        }

        /// <summary>
        /// Sets the Animation Controller&apos;s animation to a specific frame number.
        /// </summary>
        public static void AnimationSetFrame(AnimationController animator, int frameNumber)
        {
            return;
        }

        /// <summary>
        /// Sets the Animation Controller&apos;s play speed. Default value is 1. Negative values play the animation in reverse.
        /// </summary>
        public static void AnimationSetSpeed(AnimationController animator, float speed)
        {
            return;
        }

        /// <summary>
        /// Sets the time stamp of the given animation controller to the given time in seconds. The time stamp is not impacted by the animation speed.
        /// </summary>
        public static void AnimationSetTimeStamp(AnimationController animator, float timeStamp)
        {
            return;
        }

        /// <summary>
        /// Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
        /// </summary>
        public static void AnimationStop(AnimationController animator)
        {
            return;
        }

        /// <summary>
        /// Computes the arcsine of a number.
        /// </summary>
        public static float Asin(float value)
        {
            return default;
        }

        /// <summary>
        /// Computes the arctangent of a number.
        /// </summary>
        public static float Atan(float value)
        {
            return default;
        }

        /// <summary>
        /// Computes the 2-argument arctangent of a number.
        /// </summary>
        public static float Atan2(float y, float x)
        {
            return default;
        }

        /// <summary>
        /// Returns the intensity of the target Audio FX Zone object.
        /// </summary>
        public static float AudioFXZoneGetIntensity(AudioFXZone target)
        {
            return default;
        }

        /// <summary>
        /// Returns the priority of the target Audio FX Zone object.
        /// </summary>
        public static int AudioFXZoneGetPriority(AudioFXZone target)
        {
            return default;
        }

        /// <summary>
        /// Sets the effect of the target Audio FX Zone object.
        /// </summary>
        public static void AudioFXZoneSetEffect(AudioFXZone target)
        {
            return;
        }

        /// <summary>
        /// Sets the intensity of the target Audio FX Zone object.
        /// </summary>
        public static void AudioFXZoneSetIntensity(AudioFXZone target, float intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the priority of the target Audio FX Zone object.
        /// </summary>
        public static void AudioFXZoneSetPriority(AudioFXZone target, int priority)
        {
            return;
        }

        /// <summary>
        /// Returns the length in seconds of the given audio reference.
        /// </summary>
        public static float AudioGetLength(Audio audio)
        {
            return default;
        }

        /// <summary>
        /// Returns the most recent audio reference that the target Audio Player has started playing.
        /// </summary>
        public static Audio AudioPlayerGetAudio(AudioPlayer target)
        {
            return default;
        }

        /// <summary>
        /// Returns the furthest distance from the target Audio Player that the audio can be heard from.
        /// </summary>
        public static float AudioPlayerGetMaxRolloffDistance(AudioPlayer target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Audio Player is playing.
        /// </summary>
        public static bool AudioPlayerGetPlaying(AudioPlayer target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed multiplier of the target Audio Player.
        /// </summary>
        public static float AudioPlayerGetSpeed(AudioPlayer target)
        {
            return default;
        }

        /// <summary>
        /// Returns the current time stamp of the target Audio Player in seconds.
        /// </summary>
        public static float AudioPlayerGetTimeStamp(AudioPlayer target)
        {
            return default;
        }

        /// <summary>
        /// Returns the volume multiplier of the target Audio Player.
        /// </summary>
        public static float AudioPlayerGetVolume(AudioPlayer target)
        {
            return default;
        }

        public static void AudioPlayerPause(AudioPlayer target)
        {
            return;
        }

        public static void AudioPlayerPlay(AudioPlayer target, Audio audio)
        {
            return;
        }

        /// <summary>
        /// Sets the maximum distance that audio from the target Audio Player can be heard from.
        /// </summary>
        public static void AudioPlayerSetMaxRolloffDistance(AudioPlayer target, float maxRolloffDistance)
        {
            return;
        }

        /// <summary>
        /// Sets the speed multiplier that the target Audio Player will play at.
        /// </summary>
        public static void AudioPlayerSetSpeed(AudioPlayer target, float speed)
        {
            return;
        }

        /// <summary>
        /// Sets the time stamp of the target Audio Player in seconds.
        /// </summary>
        public static void AudioPlayerSetTimeStamp(AudioPlayer target, float timeStamp)
        {
            return;
        }

        /// <summary>
        /// Sets the volume multiplier that the target Audio Player will play at.
        /// </summary>
        public static void AudioPlayerSetVolume(AudioPlayer target, float volume)
        {
            return;
        }

        public static void AudioPlayerStop(AudioPlayer target)
        {
            return;
        }

        /// <summary>
        /// Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public static bool AwardConsumableR1(Consumable consumable, Player player, int quantity, AlternativeExec<bool> onAwardConsumableComplete)
        {
            return default;
        }

        /// <summary>
        /// Award some amount to the Player&apos;s balance of one room currency. Configure this chip to set the affected currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrencyDeprecatedR1(Player player, int amount, AlternativeExec<(bool Success, int TotalBalance)> onAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Award some amount to the Player&apos;s balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) AwardCurrencyR1(RoomCurrency currency, Player player, int amount, AlternativeExec<(bool Success, int TotalBalance)> onAwardCurrencyComplete)
        {
            return default;
        }

        /// <summary>
        /// Unlocks a room key for the target player. Multiple award room key requests from the same client are sent in bulk with a one-second cooldown.
        /// The Success port will be TRUE if the key was successfully unlocked for the player or if the player previously owned the key. If the key could not be awarded the Success port will be FALSE.
        /// Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
        /// </summary>
        public static bool AwardRoomKeyR1(RoomKey roomKey, Player player, AlternativeExec<bool> onAwardRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Defines values for the room&apos;s background objects.
        /// </summary>
        public static BackgroundObjects BackgroundObjectsConstant()
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target Beacon object.
        /// </summary>
        public static Color BeaconGetColor(Beacon target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Beacon object is enabled.
        /// </summary>
        public static bool BeaconGetEnabled(Beacon target)
        {
            return default;
        }

        /// <summary>
        /// Returns the height of the target Beacon object.
        /// </summary>
        public static float BeaconGetHeight(Beacon target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color of the target Beacon object.
        /// </summary>
        public static void BeaconSetColor(Beacon target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of the target Beacon object.
        /// </summary>
        public static void BeaconSetEnabled(Beacon target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the height of the target Beacon object.
        /// </summary>
        public static void BeaconSetHeight(Beacon target, float height)
        {
            return;
        }

        /// <summary>
        /// Computes a bitwise AND. The result has a bit set for every bit that is set in both of the inputs.
        /// </summary>
        public static int BitAnd(int port0, int port1)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of zeros at the beginning (most significant side) of the binary representation of an integer.
        /// </summary>
        public static int BitLeadingZeros(int value)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise NAND. (NOT AND) The result has a bit set for every bit that is not set in either of the inputs.
        /// </summary>
        public static int BitNand(int port0, int port1)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise NOT. The result has a bit set for every bit that is not set in the input.
        /// </summary>
        public static int BitNot(int port0)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise OR. The result has a bit set for every bit that is set in either of the inputs.
        /// </summary>
        public static int BitOr(int port0, int port1)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of set bits in the binary representation of an integer.
        /// </summary>
        public static int BitPopCount(int value)
        {
            return default;
        }

        /// <summary>
        /// Rotates digits in the binary representation of an integer to the left. As the leftmost bits fall off, they are used to fill the rightmost bits.
        /// </summary>
        public static int BitRotateLeft(int value, int shift)
        {
            return default;
        }

        /// <summary>
        /// Rotates digits in the binary representation of an integer to the right. As the rightmost bits fall off, they are used to fill the leftmost bits.
        /// </summary>
        public static int BitRotateRight(int value, int shift)
        {
            return default;
        }

        /// <summary>
        /// Shifts a value left by a number of bits. Leftmost bits are discarded, and rightmost bits are filled with zeros.
        /// </summary>
        public static int BitShiftLeft(int value, int shift)
        {
            return default;
        }

        /// <summary>
        /// Shifts a value right by a number of bits. Rightmost bits are discarded, and leftmost bits are filled with zeros. (Logical shift)
        /// </summary>
        public static int BitShiftRight(int value, int shift)
        {
            return default;
        }

        /// <summary>
        /// Counts the number of zeros at the end (least significant side) of the binary representation of an integer.
        /// </summary>
        public static int BitTrailingZeros(int value)
        {
            return default;
        }

        /// <summary>
        /// Computes a bitwise XOR. The result has a bit set for every bit that is set in exactly one of the inputs.
        /// </summary>
        public static int BitXor(int port0, int port1)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static bool BoolVariable(bool port1, VariableData config)
        {
            return default;
        }

        public static (T0 Item1, T1 Item2) BreakTuple<T0, T1>(RRTuple<T0, T1> tuple)
        {
            return default;
        }

        /// <summary>
        /// Outputs a target Button&apos;s Pressed property.
        /// </summary>
        public static bool ButtonGetIsPressed(Button target)
        {
            return default;
        }

        /// <summary>
        /// Outputs a target Button&apos;s Text property.
        /// </summary>
        public static string ButtonGetText(Button target)
        {
            return default;
        }

        /// <summary>
        /// Sets an input Button&apos;s Text property.
        /// </summary>
        public static void ButtonSetText(Button target, string text)
        {
            return;
        }

        /// <summary>
        /// Returns the least integral value greater than or equal to the input value.
        /// </summary>
        public static float Ceil(float value)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integer value greater than or equal to the input value.
        /// </summary>
        public static int CeilToInt(float value)
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
        public static float Clamp(float value, float min, float max)
        {
            return default;
        }

        /// <summary>
        /// Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
        /// </summary>
        public static int Clamp(int value, int min, int max)
        {
            return default;
        }

        /// <summary>
        /// Clears any active screen vignette on the given player.
        /// </summary>
        public static void ClearPlayerVignette(Player player)
        {
            return;
        }

        /// <summary>
        /// Clear the UI configuration displayed above a given player.
        /// </summary>
        public static void ClearPlayerWorldUI(Player player)
        {
            return;
        }

        public static void ClearScreen(TextScreen target)
        {
            return;
        }

        /// <summary>
        /// Gets distance in meters of an object/player from center specified in &quot;Overlap Sphere&quot; chip.
        /// </summary>
        public static float CollisionDataGetDistance(CollisionData target)
        {
            return default;
        }

        /// <summary>
        /// Gets unit vector specifying the direction of an object/player from center specified in &quot;Overlap Sphere&quot; chip.
        /// </summary>
        public static Vector3 CollisionDataGetNormal(CollisionData target)
        {
            return default;
        }

        /// <summary>
        /// Gets object of a collision data (or null for players) returned from &quot;Overlap Sphere&quot; chip.
        /// </summary>
        public static RecRoomObject CollisionDataGetObject(CollisionData target)
        {
            return default;
        }

        /// <summary>
        /// Gets player of a collision data (or null for objects) returned from &quot;Overlap Sphere&quot; chip.
        /// </summary>
        public static Player CollisionDataGetPlayer(CollisionData target)
        {
            return default;
        }

        /// <summary>
        /// Gets position of an object/player returned by &quot;Overlap Sphere&quot; chip.
        /// </summary>
        public static Vector3 CollisionDataGetPosition(CollisionData target)
        {
            return default;
        }

        public static bool CollisionDetectionVolumeGetEnabled(CollisionDetectionVolume target)
        {
            return default;
        }

        public static void CollisionDetectionVolumeSetEnabled(CollisionDetectionVolume target, bool enabled)
        {
            return;
        }

        public static Color ColorConstant()
        {
            return default;
        }

        /// <summary>
        /// Return hue, saturation, and value from the given color.
        /// </summary>
        public static (float Hue, float Saturation, float Value) ColorToHSV(Color color)
        {
            return default;
        }

        public static int ColorToIntDeprecated(Color color)
        {
            return default;
        }

        /// <summary>
        /// Return red, green, and blue from the given color.
        /// </summary>
        public static (float Red, float Green, float Blue) ColorToRGB(Color color)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Color ColorVariable(Color port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPositionR1(AI combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPositionR1(Combatant combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the ground position of an input combatant.
        /// </summary>
        public static Vector3 CombatantGetGroundPositionR1(Player combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(AI @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(Combatant @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Health property of the input combatant.
        /// </summary>
        public static (int Health, int Shield, int MaxHealth) CombatantGetHealthR1(Player @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAliveR1(AI @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAliveR1(Combatant @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input combatant is alive.
        /// </summary>
        public static bool CombatantGetIsAliveR1(Player @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant&apos;s current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocityR1(AI combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant&apos;s current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocityR1(Combatant combatant)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input combatant&apos;s current velocity and speed.
        /// </summary>
        public static (Vector3 Velocity, float Speed) CombatantGetVelocityR1(Player combatant)
        {
            return default;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, AI damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, Combatant damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(AI target, int damage, bool ignoreShield, Player damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, AI damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, Combatant damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Combatant target, int damage, bool ignoreShield, Player damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, AI damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, Combatant damageSource)
        {
            return;
        }

        /// <summary>
        /// Deals damage to the given target combatant with various parameters.
        /// </summary>
        public static void CombatantReceiveDamageR1(Player target, int damage, bool ignoreShield, Player damageSource)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealthR1(AI target, int health)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealthR1(Combatant target, int health)
        {
            return;
        }

        /// <summary>
        /// Sets the Health property of an input combatant.
        /// </summary>
        public static void CombatantSetHealthR1(Player target, int health)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealthR1(AI target, int maxHealth)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealthR1(Combatant target, int maxHealth)
        {
            return;
        }

        /// <summary>
        /// Sets the Max Health property of the input combatant.
        /// </summary>
        public static void CombatantSetMaxHealthR1(Player target, int maxHealth)
        {
            return;
        }

        /// <summary>
        /// Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
        /// </summary>
        public static (bool IsPlayer, Player Player, AI AI) CombatantSplitR1(Combatant combatant)
        {
            return default;
        }

        internal static Combatant CombatantVariableR1(Combatant port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Put a comment next to your circuits to explain what they&apos;re doing.
        /// </summary>
        public static void Comment()
        {
            return;
        }

        public static object CommunityEventConstant()
        {
            return default;
        }

        internal static object CommunityEventVariable(object port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
        /// </summary>
        public static void ConsumableActivateR1(Consumable consumable)
        {
            return;
        }

        public static Consumable ConsumableConstantR1(RoomConsumableData config)
        {
            return default;
        }

        /// <summary>
        /// Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
        /// </summary>
        public static void ConsumableDeactivateR1(Consumable consumable)
        {
            return;
        }

        internal static string ControlPanel()
        {
            return default;
        }

        /// <summary>
        /// Computes the cosine of a number.
        /// </summary>
        public static float Cos(float value)
        {
            return default;
        }

        /// <summary>
        /// Equip a Player with a costume.
        /// </summary>
        public static void CostumeEquip(Costume target, Player player)
        {
            return;
        }

        /// <summary>
        /// Get Player wearing a costume.
        /// </summary>
        public static Player CostumeGetWearer(Costume target)
        {
            return default;
        }

        /// <summary>
        /// Unequip a costume.
        /// </summary>
        public static Player CostumeUnequip(Costume target)
        {
            return default;
        }

        /// <summary>
        /// A single data table. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room to commit changes.
        /// </summary>
        public static void DataTable(object port0, DataTableDefinitionData config)
        {
            return;
        }

        /// <summary>
        /// Returns a list of row indices containing the given value within a specified Data Table. Configure the chip to select the data table and column.
        /// </summary>
        internal static List<int> DataTableGetAllRowsContaining(DataTableColumnData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the number of columns in the given data table, set by configuring the chip.
        /// </summary>
        public static int DataTableGetColumnCount(DataTableData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the first row containing the given value within a specified Data Table. Configure the chip to select the Data Table and column.
        /// </summary>
        internal static int DataTableGetFirstRowContaining(DataTableColumnData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the number of rows in the given data table, set by configuring the chip.
        /// </summary>
        public static int DataTableGetRowCount(DataTableData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the value in the specified row from the specified column. Use the configuration menu to set which Data Table and Column to read from, which will also determine the output pin type.
        /// </summary>
        internal static void DataTableReadCell(int row, DataTableColumnData config)
        {
            return;
        }

        /// <summary>
        /// Fires outputs based on the inputted time to delay. The Run exec fires as soon as the node is executed. The After Delay exec fires once the input delay duration has completed. After Canceled fires after the delay node’s Cancel exec has been fired. Cancel cancels all current delays running from this node, except for delays scheduled for the next tick.
        /// </summary>
        public static void Delay(float delay, AlternativeExec afterDelay, AlternativeExec cancel)
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
        internal static DestinationRoom DestinationRoomVariable(DestinationRoom port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the current Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
        /// </summary>
        public static Vector3 DialogueUIGetBillboardingPivotOffset(DialogueUI target)
        {
            return default;
        }

        /// <summary>
        /// Returns the current text of the target Dialogue UI’s main body for the local player, and whether or not it’s currently interactive.
        /// </summary>
        public static (string BodyText, bool IsInteractive) DialogueUIGetDialogueText(DialogueUI target)
        {
            return default;
        }

        /// <summary>
        /// Returns whether or not the target Dialogue UI is enabled for the local player.
        /// </summary>
        public static bool DialogueUIGetIsEnabled(DialogueUI target)
        {
            return default;
        }

        /// <summary>
        /// Returns whether or not the target Dialogue UI’s title bar is visible for the local player.
        /// </summary>
        public static bool DialogueUIGetTitleIsEnabled(DialogueUI target)
        {
            return default;
        }

        /// <summary>
        /// Returns the current title of the target Dialogue UI for the local player.
        /// </summary>
        public static string DialogueUIGetTitleText(DialogueUI target)
        {
            return default;
        }

        /// <summary>
        /// Sets the Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
        /// </summary>
        public static void DialogueUISetBillboardingPivotOffset(DialogueUI target, Vector3 offset)
        {
            return;
        }

        /// <summary>
        /// Set the visibility and text of up to four buttons on the target Dialogue UI for the local player. Text will truncate after 512 characters. Buttons are automatically interactive when enabled. Each button will fire a Button Pressed event in the Dialogue UI’s board scope when pressed. Button visibility is dependent on the Dialogue UI being enabled.
        /// </summary>
        public static void DialogueUISetButtonState(DialogueUI target, bool button1Enabled, string button1Text, bool button2Enabled, string button2Text, bool button3Enabled, string button3Text, bool button4Enabled, string button4Text)
        {
            return;
        }

        /// <summary>
        /// Sets the text of the target Dialogue UI’s main body for the local player. Text will truncate after 256 characters. If “Is interactive” is true, an arrow will appear in the lower right when the text has fully animated in, and the whole panel will be clickable for the player. The Next Pressed event will fire in the Dialogue UI’s board scope when this interactive panel is clicked.
        /// </summary>
        public static void DialogueUISetDialogueText(DialogueUI target, string bodyText, bool isInteractive)
        {
            return;
        }

        /// <summary>
        /// Toggles whether or not the target Dialogue UI is enabled for the local player.
        /// </summary>
        public static void DialogueUISetIsEnabled(DialogueUI target, bool isEnabled)
        {
            return;
        }

        /// <summary>
        /// Toggles visibility of the target Dialogue UI’s title bar for the local player. Visibility is dependent on the Dialogue UI being enabled.
        /// </summary>
        public static void DialogueUISetTitleIsEnabled(DialogueUI target, bool isEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the title field of the target Dialogue UI for the local player. Text will truncate after 48 characters.
        /// </summary>
        public static void DialogueUISetTitleText(DialogueUI target, string titleText)
        {
            return;
        }

        /// <summary>
        /// Returns the player who rolled the dice.
        /// </summary>
        public static Player DiceGetPlayerRolled(Die target)
        {
            return default;
        }

        /// <summary>
        /// Returns the result of the dice.
        /// </summary>
        public static int DiceGetResult(Die target)
        {
            return default;
        }

        /// <summary>
        /// Outputs an exec when the dice finished rolling.
        /// </summary>
        public static bool DiceGetRollFinished(Die target)
        {
            return default;
        }

        /// <summary>
        /// Displays a target UI configuration above a given player.
        /// </summary>
        public static void DisplayPlayerWorldUI(PlayerWorldUI target, Player player)
        {
            return;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(AI a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Combatant a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(RecRoomObject a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Player a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float Distance(Vector3 a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(AI a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Combatant a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(RecRoomObject a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Player a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 a, AI b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 a, Combatant b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 a, RecRoomObject b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 a, Player b)
        {
            return default;
        }

        /// <summary>
        /// Outputs the distance between the input objects.
        /// </summary>
        public static float DistanceDeprecated(Vector3 a, Vector3 b)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static int Divide(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static float Divide(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Find how many times a value contains another.
        /// </summary>
        public static Vector3 Divide(params Vector3[] value)
        {
            return default;
        }

        public static DestinationRoom DoorGetDestinationR1(RoomDoor target)
        {
            return default;
        }

        public static bool DoorGetLockedR1(RoomDoor target)
        {
            return default;
        }

        public static void DoorSetDestinationR1(RoomDoor target, DestinationRoom room)
        {
            return;
        }

        public static void DoorSetLockedR1(RoomDoor target, bool locked)
        {
            return;
        }

        /// <summary>
        /// Returns True if the target Emitter is looping.
        /// </summary>
        public static bool EmitterGetLooping(Emitter target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Emitter is playing.
        /// </summary>
        public static bool EmitterGetPlaying(Emitter target)
        {
            return default;
        }

        /// <summary>
        /// Returns the size multiplier of the target Emitter.
        /// </summary>
        public static float EmitterGetSize(Emitter target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed multiplier of the target Emitter.
        /// </summary>
        public static float EmitterGetSpeed(Emitter target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color for the particles emitted.
        /// </summary>
        public static void EmitterSetColor(Emitter target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for the particles emitted.
        /// </summary>
        public static void EmitterSetColorIdDeprecated(Emitter target, int value)
        {
            return;
        }

        /// <summary>
        /// Makes the emitter emit continuously or not.
        /// </summary>
        public static void EmitterSetLooping(Emitter target, bool value)
        {
            return;
        }

        /// <summary>
        /// Sets the size of the particles emitted.
        /// </summary>
        public static void EmitterSetSize(Emitter target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed particles are emitted.
        /// </summary>
        public static void EmitterSetSpeed(Emitter target, float value)
        {
            return;
        }

        /// <summary>
        /// Starts emitting particles.
        /// </summary>
        public static void EmitterStart(Emitter target)
        {
            return;
        }

        /// <summary>
        /// Stops emitting particles.
        /// </summary>
        public static void EmitterStop(Emitter target)
        {
            return;
        }

        /// <summary>
        /// Compares the input values and outputs True if they are the same. False if they are different.
        /// </summary>
        internal static bool Equals<T>(T value)
        {
            return default;
        }

        /// <summary>
        /// Compares the two input values and outputs True if they are the same. False if they are different.
        /// </summary>
        public static bool EqualsDeprecated<T>(T a, T b)
        {
            return default;
        }

        /// <summary>
        /// Display up to six interactive buttons that can access Inventory Items (Inventory Slots) or physical objects (Holster Slots.) Configure this chip to configure the settings for a slot. Output type will change based on Type setting.  Use with Player Set Equipment Slot Is Enabled and the various Player Equip chips.
        /// </summary>
        public static EquipmentSlot EquipmentSlotR2()
        {
            return default;
        }

        public static bool EquipObjectToDominantHand(Player player, RecRoomObject objectToEquip, bool forceEquip, bool steal)
        {
            return default;
        }

        public static bool EquipObjectToOffHand(Player player, RecRoomObject objectToEquip, bool forceEquip, bool steal)
        {
            return default;
        }

        /// <summary>
        /// Equips Share Camera to a player&apos;s dominant hand if the player is not already holding the Share Camera.
        /// Returns success if the target player is already holding their Share Camera in either hand.
        /// </summary>
        public static bool EquipShareCamera(Player player, bool forceEquip)
        {
            return default;
        }

        internal static void EventDefinition(EventDefinitionData config)
        {
            return;
        }

        /// <summary>
        /// Events are the entry points for all circuit graphs. Events are execution hooks for things like a player loading into the room, or knowing when a Button is pressed. After creating this chip, make sure to use the configure tool to choose the event you want to listen for. You can use the Event Defintion chip to create your own events to add to this list and use with the Event Sender chip.
        /// </summary>
        internal static void EventReceiver(EventReceiverData config)
        {
            return;
        }

        /// <summary>
        /// Use the Event Sender to fire your custom events defined in Event Defintions. After creating this chip, make sure to use the configure tool to change the event that you want to fire. You can also change who you want to send the event to from the config menu.
        /// </summary>
        internal static void EventSender(EventSenderData config)
        {
            return;
        }

        /// <summary>
        /// Executes the associated output of the compare value that matches the &apos;match&apos; input. Executes the default output if no match can be found.
        /// </summary>
        internal static void ExecutionIntegerSwitch(int match)
        {
            return;
        }

        /// <summary>
        /// Executes the associated output of the compare value that matches the &apos;match&apos; input. Executes the default output if no match can be found.
        /// </summary>
        internal static void ExecutionStringSwitch(string match)
        {
            return;
        }

        public static void ExplosionEmitterExplode(ExplosionEmitter target)
        {
            return;
        }

        public static int ExplosionEmitterGetDamage(ExplosionEmitter target)
        {
            return default;
        }

        public static Color ExplosionEmitterGetExplosionColor(ExplosionEmitter target)
        {
            return default;
        }

        public static float ExplosionEmitterGetExplosionRadius(ExplosionEmitter target)
        {
            return default;
        }

        /// <summary>
        /// Returns the player set by the Explosion Emitter Set Firing Player chip.
        /// </summary>
        public static Player ExplosionEmitterGetFiringPlayer(ExplosionEmitter target)
        {
            return default;
        }

        public static void ExplosionEmitterSetDamage(ExplosionEmitter target, int damage)
        {
            return;
        }

        public static void ExplosionEmitterSetExplosionColor(ExplosionEmitter target, Color color)
        {
            return;
        }

        public static void ExplosionEmitterSetExplosionRadius(ExplosionEmitter target, float radius)
        {
            return;
        }

        /// <summary>
        /// Sets the firing player of the target Explosion Emitter. If none is set, the component will use the authority player.
        /// </summary>
        public static void ExplosionEmitterSetFiringPlayer(ExplosionEmitter target, Player player)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static float FloatVariable(float port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integral value less than or equal to the input value.
        /// </summary>
        public static float Floor(float value)
        {
            return default;
        }

        /// <summary>
        /// Returns the smallest integer value less than or equal to the input value.
        /// </summary>
        public static int FloorToInt(float value)
        {
            return default;
        }

        /// <summary>
        /// Defines settings for room fog.
        /// </summary>
        public static Fog FogConstant(FogData config)
        {
            return default;
        }

        /// <summary>
        /// Iterates over the &quot;From&quot; pin (inclusive) to the &quot;To&quot; pin (exclusive).
        /// </summary>
        internal static int For(int from, int to, AlternativeExec<int> done)
        {
            return default;
        }

        /// <summary>
        /// Iterates over the input list. The loop exec fires for each element in the list. The Done exec fires once the end of the list has been reached.
        /// </summary>
        public static T ForEach<T>(List<T> items, AlternativeExec<T> done)
        {
            return default;
        }

        /// <summary>
        /// Converts the input Rec Room Object to the object&apos;s subtype.
        /// </summary>
        internal static T FromRecRoomObject<T>(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Defines a function.
        /// </summary>
        public static void FunctionDefinition()
        {
            return;
        }

        public static void FunctionOut()
        {
            return;
        }

        public static HUDElement GameHUDElementConstant()
        {
            return default;
        }

        /// <summary>
        /// Returns a list with all the inventory items in this room.
        /// </summary>
        public static List<InventoryItem> GetAllInventoryItemsInRoomR2()
        {
            return default;
        }

        /// <summary>
        /// Returns a List of Room Inventory Items that are tagged with the inputted tag.
        /// </summary>
        public static List<InventoryItem> GetAllInventoryItemsWithTagR2(string tag)
        {
            return default;
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
        /// Outpus List&lt;Player&gt; that continues every player with the specified role.
        /// </summary>
        public static List<Player> GetAllPlayersWithRoleR1(string roleName)
        {
            return default;
        }

        /// <summary>
        /// Returns the angular velocity in degrees per second of a Rec Room Object.
        /// </summary>
        public static Vector3 GetAngularVelocity(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Gets a player with the role. Returns invalid player if no player has the role.
        /// </summary>
        public static Player GetAnyPlayerWithRoleR1(string role)
        {
            return default;
        }

        /// <summary>
        /// Gets the authority player of the chip&apos;s current context.
        /// </summary>
        public static Player GetAuthority()
        {
            return default;
        }

        /// <summary>
        /// Outputs player counts if you&apos;re in an event that&apos;s actively broadcasting.
        /// </summary>
        public static (int AudienceCount, int BroadcasterCount, bool IsBroadcastActive) GetBroadcastingAttendance()
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(RecRoomObject origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Player origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Closest, int ClosestIndex, float Distance) GetClosest(Vector3 origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.
        /// </summary>
        public static (bool Success, int TotalBalance) GetCurrencyBalanceDeprecatedR1(Player player, AlternativeExec<(bool Success, int TotalBalance)> onGetBalanceComplete)
        {
            return default;
        }

        /// <summary>
        /// Returns the given player&apos;s balance of the given room currency.
        /// </summary>
        public static (bool Success, int TotalBalance) GetCurrencyBalanceR1(RoomCurrency currency, Player player, AlternativeExec<(bool Success, int TotalBalance)> onGetBalanceComplete)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(RecRoomObject origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Player origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (RecRoomObject Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<RecRoomObject> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Player Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<Player> targets)
        {
            return default;
        }

        /// <summary>
        /// Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
        /// </summary>
        public static (Vector3 Farthest, int FarthestIndex, float Distance) GetFarthest(Vector3 origin, List<Vector3> targets)
        {
            return default;
        }

        /// <summary>
        /// Gets the first tag of an object or player.
        /// </summary>
        public static string GetFirstTag(Player target)
        {
            return default;
        }

        /// <summary>
        /// Gets the first tag of an object or player.
        /// </summary>
        public static string GetFirstTag(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Returns the given universal time, formatted based on the C# DateTime format specifiers.
        /// </summary>
        public static string GetFormattedTime(float universalSeconds, string format)
        {
            return default;
        }

        /// <summary>
        /// Returns the given universal time, formatted based on the C# DateTime format specifiers.
        /// </summary>
        public static string GetFormattedTime(int universalSeconds, string format)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVector(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVector(Player target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVectorDeprecated(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Gets the forward direction of a target, output as a vector.
        /// </summary>
        public static Vector3 GetForwardVectorDeprecated(Player target)
        {
            return default;
        }

        public static Color GetHUDElementColor(HUDConstant target)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the local player has a HUD element of the given type currently enabled.
        /// </summary>
        public static bool GetHUDElementEnabled(HUDConstant target)
        {
            return default;
        }

        public static string GetHUDElementLabel(HUDConstant target)
        {
            return default;
        }

        public static int GetHUDElementMaxValue(HUDConstant target)
        {
            return default;
        }

        public static int GetHUDElementValue(HUDConstant target)
        {
            return default;
        }

        /// <summary>
        /// Gets the Inventory Item that matches the provided friendly name
        /// </summary>
        public static InventoryItem GetInventoryItemFromNameR2(string name)
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
        /// Gets the position of your avatar&apos;s view, output as a Vector3.
        /// </summary>
        public static Vector3 GetLocalCameraPosition()
        {
            return default;
        }

        /// <summary>
        /// Gets the rotation of your avatar&apos;s view, output as a quaternion.
        /// </summary>
        public static Quaternion GetLocalCameraRotation()
        {
            return default;
        }

        /// <summary>
        /// Gets the up direction from the local player&apos;s camera, output as a Vector3.
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
        /// Returns the party of the input player as List&lt;Player&gt;. If the player is not in a party, it will return a list containing only that player.
        /// </summary>
        public static List<Player> GetPartyOfPlayer(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the player&apos;s Account name (e.g Coach) in a form of a string. To get a display name, use To String.
        /// </summary>
        public static string GetPlayerAccountName(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets a Player based on an Account Name. (E.g. my account name is @Coach and if I input the string &quot;Coach&quot;, the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given account name.
        /// </summary>
        public static Player GetPlayerByAccountName(string name)
        {
            return default;
        }

        /// <summary>
        /// Gets a Player based on a display name. (E.g. my display name is Coach and if I input a string &quot;Coach&quot;, the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given display name.
        /// </summary>
        public static Player GetPlayerByDisplayName(string name)
        {
            return default;
        }

        public static string GetPlayerSeasonLeagueNameDeprecated(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player&apos;s world UI.
        /// </summary>
        public static bool GetPlayerWorldUIEnabled(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player&apos;s primary bar in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUIPrimaryBarColor(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player&apos;s primary bar in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUIPrimaryBarEnabled(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max value of the given player&apos;s primary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUIPrimaryBarMaxValue(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player&apos;s primary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUIPrimaryBarValue(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player&apos;s secondary bar in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUISecondaryBarColor(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player&apos;s secondary bar in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUISecondaryBarEnabled(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max value of the given player&apos;s secondary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUISecondaryBarMaxValue(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player&apos;s secondary bar in their current world UI.
        /// </summary>
        public static int GetPlayerWorldUISecondaryBarValue(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the given player&apos;s text in their current world UI.
        /// </summary>
        public static Color GetPlayerWorldUITextColor(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the enabled state of the given player&apos;s text in their current world UI.
        /// </summary>
        public static bool GetPlayerWorldUITextEnabled(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the value of the given player&apos;s text in their current world UI.
        /// </summary>
        public static string GetPlayerWorldUITextValue(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(AI target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(Combatant target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPosition(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(AI target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(Combatant target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3.
        /// </summary>
        public static Vector3 GetPositionDeprecated(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(AI target, AI referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(AI target, Combatant referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(AI target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(AI target, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Combatant target, AI referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Combatant target, Combatant referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Combatant target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Combatant target, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, AI referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, Combatant referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(RecRoomObject target, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Player target, AI referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Player target, Combatant referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Player target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
        /// </summary>
        public static Vector3 GetPositionInReferenceObjectSpace(Player target, Player referenceObject)
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
        public static Quaternion GetRotation(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotation(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotationDeprecated(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion.
        /// </summary>
        public static Quaternion GetRotationDeprecated(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public static Quaternion GetRotationInReferenceObjectSpace(RecRoomObject target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public static Quaternion GetRotationInReferenceObjectSpace(RecRoomObject target, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public static Quaternion GetRotationInReferenceObjectSpace(Player target, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
        /// </summary>
        public static Quaternion GetRotationInReferenceObjectSpace(Player target, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of tags the input object or player has.
        /// </summary>
        public static List<string> GetTags(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of tags the input object or player has.
        /// </summary>
        public static List<string> GetTags(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVector(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVector(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVectorDeprecated(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up direction of the input target, output as a vector3.
        /// </summary>
        public static Vector3 GetUpVectorDeprecated(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocity(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocity(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocityDeprecated(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Returns the velocity of a Player or a Rec Room Object.
        /// </summary>
        public static Vector3 GetVelocityDeprecated(Player target)
        {
            return default;
        }

        /// <summary>
        /// Sends a player to a community event.
        /// 
        /// If the event is not currently happening, shows the page for it on the watch.
        /// </summary>
        public static void GoToEvent(Player player, object communityEvent)
        {
            return;
        }

        /// <summary>
        /// Execution sends the specified player to a preconfigured destination. Use a destination constant or variable to specify the destination of this chip. Follow settings are a property of the destination.
        /// </summary>
        public static void GoToRoom(Player player, DestinationRoom destination)
        {
            return;
        }

        /// <summary>
        /// Transitions to the given state in the current state machine.
        /// </summary>
        public static void GoToState(State state)
        {
            return;
        }

        /// <summary>
        /// Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
        /// </summary>
        public static (bool HasHeldObject, RecRoomObject HeldObject) GrabberGetHeldObjectR2(Grabber target)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will attempt to grab the specified object. If Steal From Player is true, it will steal the object from a player who has it held or holstered. If Snap to Grabber is true, the object will be moved to the Grabber’s position. If Snap to Grabber is false, the distance between Grabber and object at the moment of execution will be maintained until the object is released.
        /// </summary>
        public static bool GrabberGrabObjectR2(Grabber target, RecRoomObject @object, bool stealFromPlayer, bool snapToGrabber)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
        /// </summary>
        public static RecRoomObject GrabberReleaseR2(Grabber target)
        {
            return default;
        }

        /// <summary>
        /// On execution, the target grabber will lock or unlock the object being held. If true, the held object will interactable for a player to steal.  If false, the held object will not be interactable for a player to steal.
        /// </summary>
        public static void GrabberSetPlayerCanStealFromGrabberR2(Grabber target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Grants the contents of a Reward to the specified Player.
        /// </summary>
        public static bool GrantReward(Player player, Reward reward, AlternativeExec<bool> onAwardComplete)
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
        public static bool GreaterOrEqual(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterOrEqual(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterOrEqualDeprecated(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than or equal to input B.
        /// </summary>
        public static bool GreaterOrEqualDeprecated(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThan(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThan(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThanDeprecated(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is greater than input B.
        /// </summary>
        public static bool GreaterThanDeprecated(float a, float b)
        {
            return default;
        }

        public static void GroundVehicleAddBoostFuel(GroundVehicle target, int boostAmount)
        {
            return;
        }

        public static void GroundVehicleApplyBoost(GroundVehicle target, AlternativeExec failure)
        {
            return;
        }

        public static int GroundVehicleGetBoostFuel(GroundVehicle target)
        {
            return default;
        }

        public static bool GroundVehicleGetDrivingEnabled(GroundVehicle target)
        {
            return default;
        }

        public static float GroundVehicleGetEngineTorqueMultiplier(GroundVehicle target)
        {
            return default;
        }

        public static Player GroundVehicleGetSeatedPlayer(GroundVehicle target, int seatIndex)
        {
            return default;
        }

        public static float GroundVehicleGetWheelFrictionMultiplier(GroundVehicle target)
        {
            return default;
        }

        public static void GroundVehicleSetDrivingEnabled(GroundVehicle target, bool enabled)
        {
            return;
        }

        public static void GroundVehicleSetEngineTorqueMultiplier(GroundVehicle target, float torqueMultiplier)
        {
            return;
        }

        public static void GroundVehicleSetSeatedPlayer(GroundVehicle target, int seatIndex, Player player, AlternativeExec failure)
        {
            return;
        }

        /// <summary>
        /// Wheel Friction affects how good the wheels are at gripping the ground - lower values decrease traction and make the wheels slip more and higher values can increase traction and make the wheels slip less. 1 is the default value for Wheel Friction.
        /// </summary>
        public static void GroundVehicleSetWheelFrictionMultiplier(GroundVehicle target, float frictionMultiplier)
        {
            return;
        }

        public static void GroundVehicleUnseatPlayer(GroundVehicle target, Player player, AlternativeExec failure)
        {
            return;
        }

        public static void GroundVehicleUnseatPlayerFromSeat(GroundVehicle target, int seatIndex, AlternativeExec failure)
        {
            return;
        }

        public static void GunHandleAddAutoAimRoleDeprecatedR1(GunHandle target, string role)
        {
            return;
        }

        public static void GunHandleApplyRecoil(GunHandle target, float angleX, float angleY, float duration, float returnDuration)
        {
            return;
        }

        /// <summary>
        /// Returns whether the given gun handle will fire continuously.
        /// </summary>
        public static bool GunHandleGetContinuousFire(GunHandle target)
        {
            return default;
        }

        public static int GunHandleGetCurrentAmmo(GunHandle target)
        {
            return default;
        }

        public static Vector3 GunHandleGetFiringDirection(GunHandle target, RecRoomObject source)
        {
            return default;
        }

        public static bool GunHandleGetIsReloading(GunHandle target)
        {
            return default;
        }

        public static int GunHandleGetMaxAmmo(GunHandle target)
        {
            return default;
        }

        public static float GunHandleGetRateOfFire(GunHandle target)
        {
            return default;
        }

        public static float GunHandleGetReloadDuration(GunHandle target)
        {
            return default;
        }

        public static bool GunHandleGetSupportsReload(GunHandle target)
        {
            return default;
        }

        public static void GunHandleRemoveAutoAimRoleDeprecated(GunHandle target, string role)
        {
            return;
        }

        public static void GunHandleSetADSEnabled(GunHandle target, bool enabled)
        {
            return;
        }

        public static void GunHandleSetAutoAimRolesDeprecated(GunHandle target, List<string> roles)
        {
            return;
        }

        /// <summary>
        /// Sets whether the given gun handle will fire continuously.
        /// </summary>
        public static void GunHandleSetContinuousFire(GunHandle target, bool continuousFire)
        {
            return;
        }

        public static void GunHandleSetCurrentAmmo(GunHandle target, int ammo)
        {
            return;
        }

        public static void GunHandleSetMaxAmmo(GunHandle target, int maxAmmo)
        {
            return;
        }

        public static void GunHandleSetRateOfFire(GunHandle target, float rateOfFire)
        {
            return;
        }

        public static void GunHandleSetReloadDuration(GunHandle target, float reloadDuration)
        {
            return;
        }

        public static void GunHandleSetSupportsReload(GunHandle target, bool canReload)
        {
            return;
        }

        /// <summary>
        /// Gets the primary action label on the target handle type object
        /// </summary>
        public static string HandleGetControlPrompt(Handle target)
        {
            return default;
        }

        /// <summary>
        /// Gets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle&apos;s configure menu for this to work.
        /// </summary>
        public static List<string> HandleGetPlayerFilterTagsR2(Handle target)
        {
            return default;
        }

        /// <summary>
        /// Sets the primary action label on the target handle type object
        /// </summary>
        public static void HandleSetControlPrompt(Handle target, string controlPrompt)
        {
            return;
        }

        /// <summary>
        /// Sets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle&apos;s configure menu for this to work.
        /// </summary>
        public static void HandleSetPlayerFilterTagsR2(Handle target, List<string> value)
        {
            return;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(Player target, string tag)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input object or player has the input tag.
        /// </summary>
        public static bool HasTag(RecRoomObject target, string tag)
        {
            return default;
        }

        /// <summary>
        /// Get current playback time for Target Holotar Projector
        /// </summary>
        public static float HolotarProjectorGetCurrentTime(HolotarProjector target)
        {
            return default;
        }

        /// <summary>
        /// Holotar Projector get playback volume
        /// </summary>
        public static float HolotarProjectorGetVolume(HolotarProjector target)
        {
            return default;
        }

        /// <summary>
        /// Pasue Holotar Projector at current playback time
        /// </summary>
        public static void HolotarProjectorPause(HolotarProjector target)
        {
            return;
        }

        /// <summary>
        /// Load &amp; play Holotar Recording from the start through the Target Projector. Play will always begin the clip from 0s
        /// </summary>
        public static void HolotarProjectorPlay(HolotarProjector target, HolotarRecording holotar)
        {
            return;
        }

        /// <summary>
        /// Resume playing the currently loaded clip on the Target Projector from the current time 
        /// </summary>
        public static void HolotarProjectorResume(HolotarProjector target)
        {
            return;
        }

        /// <summary>
        /// Set playback time for Target Projector when paused or playing
        /// </summary>
        public static void HolotarProjectorSetCurrentTime(HolotarProjector target, float time)
        {
            return;
        }

        /// <summary>
        /// Holotar Projector set playback volume
        /// </summary>
        public static void HolotarProjectorSetVolume(HolotarProjector target, float volume)
        {
            return;
        }

        /// <summary>
        /// Holotar Projector end play
        /// </summary>
        public static void HolotarProjectorStop(HolotarProjector target)
        {
            return;
        }

        /// <summary>
        /// Constant to record and save a Holotar clip
        /// </summary>
        public static HolotarRecording HolotarRecordingConstant()
        {
            return default;
        }

        public static bool HolsterObject(Player player, RecRoomObject objectToHolster, bool forceHolster, bool steal)
        {
            return default;
        }

        /// <summary>
        /// Return a color from the given hue, saturation, and value inputs. All inputs are in the range [0, 1].
        /// </summary>
        public static Color HSVToColor(float hue, float saturation, float value)
        {
            return default;
        }

        /// <summary>
        /// Takes a boolean condition as an input. If True, the &quot;Then&quot; exec pin fires. If False, the &quot;Else&quot; exec pin fires.
        /// </summary>
        internal static void If(bool condition, AlternativeExec @else)
        {
            return;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(Player target, string tag, AlternativeExec doesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
        /// </summary>
        public static void IfHasTag(RecRoomObject target, string tag, AlternativeExec doesNotHaveTag)
        {
            return;
        }

        /// <summary>
        /// I&apos;m Authority exec fires on the player&apos;s machine who has authority in the current context. At the room level, this is room authority, inside an object board, this is object authority. I&apos;m Not Authority exec fires for everyone else.
        /// </summary>
        public static void IfLocalPlayerIsAuthority(AlternativeExec imNotAuthority)
        {
            return;
        }

        /// <summary>
        /// I&apos;m Authority exec fires on the player&apos;s machine who has authority over the room. I&apos;m Not Authority exec fires for everyone else.
        /// </summary>
        public static void IfLocalPlayerIsRoomAuthority(AlternativeExec imNotAuthority)
        {
            return;
        }

        /// <summary>
        /// The &quot;Should Run&quot; port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
        /// </summary>
        public static void IfLocalPlayerShouldRun(Player actingPlayer, AlternativeExec shouldNotRun)
        {
            return;
        }

        /// <summary>
        /// Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
        /// </summary>
        public static void IfPlayerHasRoleR1(Player player, string role, AlternativeExec doesNotHaveRole)
        {
            return;
        }

        /// <summary>
        /// Outputs if a player is the local player or not.
        /// </summary>
        public static void IfPlayerIsLocal(Player player, AlternativeExec isNotLocal)
        {
            return;
        }

        /// <summary>
        /// Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
        /// </summary>
        public static void IfPlayerIsValid(Player player, AlternativeExec isNotValid)
        {
            return;
        }

        /// <summary>
        /// If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
        /// </summary>
        public static void IfPlayerIsValidAndLocal(Player player, AlternativeExec isNotValid, AlternativeExec isValidAndNotLocal)
        {
            return;
        }

        /// <summary>
        /// Outputs one input value based on the input condition. Outputs the &quot;Then&quot; input if the input condition is True. Outputs the &quot;Else&quot; input if the input condition is False. Only reads one of the inputs, not both.
        /// </summary>
        public static T IfValue<T>(bool @if, T then, T @else)
        {
            return default;
        }

        public static void In()
        {
            return;
        }

        /// <summary>
        /// Returns true when the current room instance is a player run event.
        /// </summary>
        public static bool InstanceGetIsEvent()
        {
            return default;
        }

        /// <summary>
        /// Returns true when the current room instance is part of a multi-instance event.
        /// </summary>
        public static bool InstanceGetIsMultiInstanceEvent()
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
        /// Returns the number of seconds since the current room instance was created.
        /// </summary>
        public static float InstanceGetLifetime()
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
        public static float InteractionVolumeGetHoldTime(InteractionVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the interaction prompt of an Interaction Volume.
        /// </summary>
        public static string InteractionVolumeGetInteractionPrompt(InteractionVolume target)
        {
            return default;
        }

        /// <summary>
        /// Returns False if the Interaction Volume is enabled, and True if it is locked.
        /// </summary>
        public static bool InteractionVolumeGetIsLocked(InteractionVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the normalized hold progress for the target Interaction Volume.
        /// </summary>
        public static float InteractionVolumeGetNormalizedHoldProgress(InteractionVolume target)
        {
            return default;
        }

        /// <summary>
        /// Sets the required hold time for the target Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetHoldTime(InteractionVolume target, float holdTime)
        {
            return;
        }

        /// <summary>
        /// Sets the interaction prompt of an Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetInteractionPrompt(InteractionVolume target, string interactionPrompt)
        {
            return;
        }

        /// <summary>
        /// Disables or enables an Interaction Volume (but reversed).
        /// </summary>
        public static void InteractionVolumeSetLocked(InteractionVolume target, bool locked)
        {
            return;
        }

        /// <summary>
        /// Sets the normalized hold progress for the target Interaction Volume.
        /// </summary>
        public static void InteractionVolumeSetNormalizedHoldProgress(InteractionVolume target, float normalizedHoldProgress)
        {
            return;
        }

        /// <summary>
        /// Converts the input int to a float.
        /// </summary>
        public static float IntToFloat(int value)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static int IntVariable(int port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Add an inventory item to the given player.
        /// </summary>
        public static (bool Success, int TotalCount) InventoryItemAddR2(InventoryItem inventoryItem, Player player, int quantity, AlternativeExec<(bool Success, int TotalCount)> complete)
        {
            return default;
        }

        public static InventoryItem InventoryItemConstantR2()
        {
            return default;
        }

        /// <summary>
        /// Get the count of how many of the given inventory item the given player owns.
        /// </summary>
        public static int InventoryItemGetCountR2(InventoryItem inventoryItem, Player player, AlternativeExec<int> complete)
        {
            return default;
        }

        /// <summary>
        /// Gets the friendly name, description, image, and tag names of the given inventory item.
        /// </summary>
        public static (string Name, string Description, bool SupportsUseAction, RecNetImage Image) InventoryItemGetDefinitionR2(InventoryItem inventoryItem)
        {
            return default;
        }

        /// <summary>
        /// Gets the image of the given inventory item
        /// </summary>
        public static RecNetImage InventoryItemGetImageR2(InventoryItem inventoryItem)
        {
            return default;
        }

        /// <summary>
        /// Remove an inventory item from the given player.
        /// </summary>
        public static (bool Success, int TotalCount) InventoryItemRemoveR2(InventoryItem inventoryItem, Player player, int quantity, AlternativeExec<(bool Success, int TotalCount)> complete)
        {
            return default;
        }

        /// <summary>
        /// Uses the given inventory item.
        /// </summary>
        public static void InventoryItemUseR2(InventoryItem inventoryItem)
        {
            return;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(float start, float end, float value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(Color start, Color end, Color value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is clamped between 0 and 1.
        /// </summary>
        public static float InverseLerp(Vector3 start, Vector3 end, Vector3 value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(float start, float end, float value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(Color start, Color end, Color value)
        {
            return default;
        }

        /// <summary>
        /// Computes an inverse linear interpolation. The output is not clamped.
        /// </summary>
        public static float InverseLerpUnclamped(Vector3 start, Vector3 end, Vector3 value)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Invisible Collision object is set to collide with players.
        /// </summary>
        public static bool InvisibleCollisionGetBlocksPlayers(InvisibleCollision target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Invisible Collision object is enabled.
        /// </summary>
        public static bool InvisibleCollisionGetEnabled(InvisibleCollision target)
        {
            return default;
        }

        /// <summary>
        /// Sets the player collision state of a target Invisible Collision object.
        /// </summary>
        public static void InvisibleCollisionSetBlocksPlayers(InvisibleCollision target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of a target Invisible Collision object.
        /// </summary>
        public static void InvisibleCollisionSetEnabled(InvisibleCollision target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Returns True if the input variable is not null. Certain variable types must be set before use because they can&apos;t have a default value. A Rec Room Object variable that isn&apos;t set isn&apos;t going to be valid.
        /// </summary>
        public static bool IsValid<T>(T port0)
        {
            return default;
        }

        public static Color LaserPointerGetColor(LaserPointer target)
        {
            return default;
        }

        public static bool LaserPointerGetEnabled(LaserPointer target)
        {
            return default;
        }

        public static float LaserPointerGetLength(LaserPointer target)
        {
            return default;
        }

        public static void LaserPointerSetColor(LaserPointer target, Color color)
        {
            return;
        }

        public static void LaserPointerSetEnabled(LaserPointer target, bool enabled)
        {
            return;
        }

        public static void LaserPointerSetLength(LaserPointer target, float length)
        {
            return;
        }

        /// <summary>
        /// Get the leaderboard stat for the given player on the given stat channel.
        /// </summary>
        public static int LeaderboardGetPlayerStat(Player player, int channel, AlternativeExec<int> onGetStatComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Leaderboard object is enabled.
        /// </summary>
        public static bool LeaderboardGetProjectorEnabled(LeaderboardProjector target)
        {
            return default;
        }

        /// <summary>
        /// Set the leaderboard stat for the local player on the given stat channel.
        /// </summary>
        public static void LeaderboardSetLocalPlayerStat(int channel, int value)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of the target Leaderboard object.
        /// </summary>
        public static void LeaderboardSetProjectorEnabled(LeaderboardProjector target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static float Lerp(float start, float end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Quaternion Lerp(Quaternion start, Quaternion end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Vector3 Lerp(Vector3 start, Vector3 end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is clamped between 0 and 1.
        /// </summary>
        public static Color Lerp(Color start, Color end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static float LerpUnclamped(float start, float end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Quaternion LerpUnclamped(Quaternion start, Quaternion end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Vector3 LerpUnclamped(Vector3 start, Vector3 end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
        /// </summary>
        public static Color LerpUnclamped(Color start, Color end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessOrEqual(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessOrEqual(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessOrEqualDeprecated(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than or equal to input B.
        /// </summary>
        public static bool LessOrEqualDeprecated(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThan(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThan(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThanDeprecated(int a, int b)
        {
            return default;
        }

        /// <summary>
        /// Returns True if input A is less than input B.
        /// </summary>
        public static bool LessThanDeprecated(float a, float b)
        {
            return default;
        }

        /// <summary>
        /// Returns the angle in degrees of the target Dome Light or Spotlight.
        /// </summary>
        public static float LightGetAngle(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target light.
        /// </summary>
        public static Color LightGetColor(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target light is emitting light.
        /// </summary>
        public static bool LightGetEnabled(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns the intensity of the target light.
        /// </summary>
        public static float LightGetIntensity(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns the range of the target light.
        /// </summary>
        public static float LightGetRange(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns the softness value of the target light.
        /// </summary>
        public static float LightGetSoftness(Light target)
        {
            return default;
        }

        /// <summary>
        /// Returns the specular contribution of the target light.
        /// </summary>
        public static float LightGetSpecularContribution(Light target)
        {
            return default;
        }

        /// <summary>
        /// Sets the angle of the spotlight&apos;s cone.
        /// </summary>
        public static void LightSetAngle(Light target, float angle)
        {
            return;
        }

        /// <summary>
        /// Sets the angle of the spotlight&apos;s cone.
        /// </summary>
        public static void LightSetAngleDeprecated(Light target, int angle)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a point light or a spotlight.
        /// </summary>
        public static void LightSetColor(Light target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a point light or a spotlight.
        /// </summary>
        public static void LightSetColorIdDeprecated(Light target, int color)
        {
            return;
        }

        /// <summary>
        /// Sets whether or not a Light is enabled and will emit light.
        /// </summary>
        public static void LightSetEnabled(Light target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the brightness level for a point light or a spotlight.
        /// </summary>
        public static void LightSetIntensity(Light target, float intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the brightness level for a point light or a spotlight.
        /// </summary>
        public static void LightSetIntensityDeprecated(Light target, int intensity)
        {
            return;
        }

        /// <summary>
        /// Sets the range of a point light or a spotlight.
        /// </summary>
        public static void LightSetRange(Light target, float range)
        {
            return;
        }

        /// <summary>
        /// Sets the range of a point light or a spotlight.
        /// </summary>
        public static void LightSetRangeDeprecated(Light target, int range)
        {
            return;
        }

        public static void LightSetSoftness(Light target, float softness)
        {
            return;
        }

        public static void LightSetSpecularContribution(Light target, float specularContribution)
        {
            return;
        }

        /// <summary>
        /// Turns off the point light or the spotlight.
        /// </summary>
        public static void LightTurnOff(Light target)
        {
            return;
        }

        /// <summary>
        /// Turns on the point light or the spotlight.
        /// </summary>
        public static void LightTurnOn(Light target)
        {
            return;
        }

        /// <summary>
        /// Adds a new element to the end of the target list containing the input value.
        /// </summary>
        public static void ListAdd<T>(List<T> target, T item)
        {
            return;
        }

        /// <summary>
        /// Adds a new element to the end of the target list containing the input value, but only if the element isn&apos;t already in the list.
        /// </summary>
        public static bool ListAddIfNotContains<T>(List<T> target, T item)
        {
            return default;
        }

        /// <summary>
        /// If all of the bool values in the list are True then return true.
        /// </summary>
        public static bool ListAllTrue(List<bool> target)
        {
            return default;
        }

        /// <summary>
        /// If any bool value in the list is True then return True.
        /// </summary>
        public static bool ListAnyTrue(List<bool> target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<bool> ListBoolVariable(List<bool> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Removes all elements from a list
        /// </summary>
        public static void ListClear<T>(List<T> list)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Color> ListColorVariable(List<Color> port1, VariableData config)
        {
            return default;
        }

        internal static List<object> ListCommunityEventVariable(List<object> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Combine lists together into one list.
        /// </summary>
        public static List<T> ListConcat<T>(List<T> list1, List<T> list2)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target list contains the input value.
        /// </summary>
        public static bool ListContains<T>(List<T> target, T item)
        {
            return default;
        }

        /// <summary>
        /// Returns a shallow clone of the given list.
        /// </summary>
        public static List<T> ListCopy<T>(List<T> target)
        {
            return default;
        }

        /// <summary>
        /// Creates a list from input values. Add more inputs by using the configure tool on the node and press &quot;Add Input&quot;. All items in a list must be of the same type.
        /// </summary>
        public static List<T> ListCreate<T>(params T[] item)
        {
            return default;
        }

        /// <summary>
        /// Stores a list of Destinations. Use constants to configure destinations.
        /// </summary>
        internal static List<DestinationRoom> ListDestinationRoomVariable(List<DestinationRoom> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs a copy of the input list containing only its unique elements.
        /// </summary>
        public static List<T> ListDistinct<T>(List<T> list)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static float ListDivide(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static int ListDivide(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Divides each element in the list by the next element.
        /// </summary>
        public static Vector3 ListDivide(List<Vector3> target)
        {
            return default;
        }

        /// <summary>
        /// Get a list of all elements that appear in the first list but not in the other lists.
        /// </summary>
        public static List<T> ListExcept<T>(List<T> value)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<float> ListFloatVariable(List<float> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Returns list of all indices of input item in target list if that list contains one or more instances of the item. Otherwise returns an empty list.
        /// </summary>
        public static List<int> ListGetAllIndicesOf<T>(List<T> target, T item)
        {
            return default;
        }

        /// <summary>
        /// Outputs the number of elements inside the input list.
        /// </summary>
        public static int ListGetCount<T>(List<T> list)
        {
            return default;
        }

        /// <summary>
        /// Gets a specified element from the input list. The &quot;Index&quot; is the location of the element in the list. The first element in the list is at index 0, the second element is at index 1.
        /// </summary>
        public static T ListGetElement<T>(List<T> list, int index)
        {
            return default;
        }

        /// <summary>
        /// Returns first index of the item in target list if that list contains it. Otherwise returns -1.
        /// </summary>
        public static int ListGetFirstIndexOf<T>(List<T> target, T item)
        {
            return default;
        }

        /// <summary>
        /// Insert a new element into the target list at the input index. The new element contains the input value.
        /// </summary>
        public static void ListInsert<T>(List<T> target, T item, int index)
        {
            return;
        }

        /// <summary>
        /// Get a list of the elements that appear in every input list.
        /// </summary>
        public static List<T> ListIntersect<T>(List<T> value)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<int> ListIntVariable(List<int> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs the highest value in the target list.
        /// </summary>
        public static float ListMax(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the highest value in the target list.
        /// </summary>
        public static int ListMax(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the lowest value in the target list.
        /// </summary>
        public static float ListMin(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the lowest value in the target list.
        /// </summary>
        public static int ListMin(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static float ListMultiply(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static int ListMultiply(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static Quaternion ListMultiply(List<Quaternion> target)
        {
            return default;
        }

        /// <summary>
        /// Multiplies each element in the list by the next element.
        /// </summary>
        public static Vector3 ListMultiply(List<Vector3> target)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<ObjectiveMarker> ListObjectiveMarkerVariable(List<ObjectiveMarker> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Player> ListPlayerVariable(List<Player> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Quaternion> ListQuaternionVariable(List<Quaternion> port1, VariableData config)
        {
            return default;
        }

        internal static List<RecRoomObject> ListRecRoomObjectVariable(List<RecRoomObject> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Remove an element in the target list at the input index.
        /// </summary>
        public static void ListRemoveAt<T>(List<T> target, int index)
        {
            return;
        }

        /// <summary>
        /// Removes all instances of item from list.
        /// </summary>
        public static void ListRemoveItemAll<T>(List<T> target, T item)
        {
            return;
        }

        /// <summary>
        /// Removes the first instance of the item in the list, and returns the index where it was found (-1 if not present)
        /// </summary>
        public static int ListRemoveItemFirst<T>(List<T> target, T item)
        {
            return default;
        }

        /// <summary>
        /// Removes the last element in a list.
        /// </summary>
        public static void ListRemoveLast<T>(List<T> target)
        {
            return;
        }

        /// <summary>
        /// A list of Rewards
        /// </summary>
        internal static List<Reward> ListRewardVariable(List<Reward> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Sets a value at a location in a list.
        /// </summary>
        public static void ListSetElement<T>(List<T> list, int index, T value)
        {
            return;
        }

        /// <summary>
        /// Randomize the order of the values in the given list.
        /// </summary>
        public static void ListShuffle<T>(List<T> target)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<float> target, bool ascending)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<int> target, bool ascending)
        {
            return;
        }

        /// <summary>
        /// Sorts the given list in place in either ascending or descending order.
        /// </summary>
        public static void ListSort(List<string> target, bool ascending)
        {
            return;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<string> ListStringVariable(List<string> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static float ListSubtract(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static int ListSubtract(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Subtracts each element in the list by the next element.
        /// </summary>
        public static Vector3 ListSubtract(List<Vector3> target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static float ListSum(List<float> target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static int ListSum(List<int> target)
        {
            return default;
        }

        /// <summary>
        /// Adds each element in the list by the next element.
        /// </summary>
        public static Vector3 ListSum(List<Vector3> target)
        {
            return default;
        }

        /// <summary>
        /// Combine lists together into one list and remove any duplicate elements.
        /// </summary>
        public static List<T> ListUnion<T>(List<T> value)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static List<Vector3> ListVector3Variable(List<Vector3> port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Clears the local player&apos;s override of target player&apos;s voice rolloff distance.
        /// 
        /// The local player&apos;s reckoning of the target player&apos;s voice rolloff returns to being based on that player&apos;s voice rolloff distance property.
        /// </summary>
        public static void LocalPlayerClearPlayerVoiceRolloffOverrideR2(Player player)
        {
            return;
        }

        /// <summary>
        /// Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
        /// </summary>
        public static void LocalPlayerDisableInteractionWithTargetPlayer(Player player)
        {
            return;
        }

        /// <summary>
        /// Enables the local player to interact with the provided player. To respond to interactions, configure a &quot;Event Receiver&quot; chip for the &quot;Local Player... Interaction&quot; events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player&apos;s interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
        /// </summary>
        public static void LocalPlayerEnableInteractionWithTargetPlayer(Player player, float requiredHoldDuration, string prompt)
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
        /// Checks if the local player is in third-person mode. This always returns false for platforms that do not support third person like VR.
        /// </summary>
        public static bool LocalPlayerGetIsThirdPersonActive()
        {
            return default;
        }

        /// <summary>
        /// Get the current displayed content on the Objective Log HUD UI
        /// </summary>
        public static (string HeaderText, Color HeaderTextColor, string BodyText, Color BodyTextColor) LocalPlayerGetObjectiveLogContent()
        {
            return default;
        }

        /// <summary>
        /// Get if the Objective Log HUD UI is currently enabled
        /// </summary>
        public static bool LocalPlayerGetObjectiveLogEnabled()
        {
            return default;
        }

        /// <summary>
        /// Check whether the local player is using a controller or not.
        /// </summary>
        public static bool LocalPlayerIsUsingController()
        {
            return default;
        }

        /// <summary>
        /// Check whether the local player is using keyboard and mouse controls or not.
        /// </summary>
        public static bool LocalPlayerIsUsingKeyboardAndMouse()
        {
            return default;
        }

        /// <summary>
        /// Check whether the local player is using touch controls or not.
        /// </summary>
        public static bool LocalPlayerIsUsingTouch()
        {
            return default;
        }

        /// <summary>
        /// Check whether the local player is in VR or not.
        /// </summary>
        public static bool LocalPlayerIsVR()
        {
            return default;
        }

        /// <summary>
        /// Override the voice rolloff distance of the target player as heard by the local player.
        /// 
        /// Other players&apos; perception of the target player&apos;s voice rolloff will be unaffected.
        /// </summary>
        public static void LocalPlayerOverridePlayerVoiceRolloffR2(Player player, float voiceRolloffDistance)
        {
            return;
        }

        /// <summary>
        /// Tries to set the local player to third or first person. If Active is true, the local player will be changed to third person. If Active is false, they will be changed to first person. No effect on platforms where third person is unsupported, like VR.
        /// </summary>
        public static void LocalPlayerRequestThirdPerson(bool active)
        {
            return;
        }

        /// <summary>
        /// Sets whether gravity should be disabled for the local player
        /// </summary>
        public static void LocalPlayerSetGravityDisabledR2(bool disabled)
        {
            return;
        }

        /// <summary>
        /// Sets whether specific locomotion visual feedback effects should play when in the corresponding state.
        /// </summary>
        public static void LocalPlayerSetLocomotionVFXEnabledR2(bool sprintWind, bool wallRunWind, bool slideStartWind, bool slideWind, bool slideSparks)
        {
            return;
        }

        /// <summary>
        /// Set the content to be displayed on the Objective Log HUD UI
        /// </summary>
        public static void LocalPlayerSetObjectiveLogContent(string headerText, Color headerTextColor, string bodyText, Color bodyTextColor)
        {
            return;
        }

        /// <summary>
        /// Set whether the Objective Log HUD UI is enabled
        /// </summary>
        public static void LocalPlayerSetObjectiveLogEnabled(bool enable)
        {
            return;
        }

        /// <summary>
        /// Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
        /// </summary>
        public static void LocalPlayerSetPlayerNametagVisibility(Player player, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Request that the local player perform a clamber or a mantle. Custom Locomotion must be enabled in the active Player Definition Board.
        /// </summary>
        public static void LocomotionRequestClamberR2(Vector3 ledgePosition, Vector3 wallNormal, RecRoomObject wallObject, bool mantle, float duration, float postClamberVelocityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Request that the local player crouch.
        /// </summary>
        public static void LocomotionRequestCrouchR2()
        {
            return;
        }

        public static void LocomotionRequestFlyStartR2()
        {
            return;
        }

        public static void LocomotionRequestFlyStopR2()
        {
            return;
        }

        /// <summary>
        /// Request that the local player&apos;s jump is cancelled or shortened.
        /// </summary>
        public static void LocomotionRequestJumpCutoffR2()
        {
            return;
        }

        /// <summary>
        /// Request that the local player jumps.
        /// </summary>
        public static void LocomotionRequestJumpR2(float maxJumpHeight, Vector3 direction)
        {
            return;
        }

        /// <summary>
        /// Request that the local player becomes prone.
        /// </summary>
        public static void LocomotionRequestProneR2()
        {
            return;
        }

        /// <summary>
        /// Used for custom locomotion in order to request starting a slide.
        /// </summary>
        public static void LocomotionRequestSlideR2(float slideSpeed, float minSlideSpeed, bool slideWithGravity)
        {
            return;
        }

        /// <summary>
        /// Used for custom locomotion in order to request starting a sprint. 
        /// </summary>
        public static void LocomotionRequestSprintStartR2()
        {
            return;
        }

        /// <summary>
        /// Request that the local player&apos;s sprint stops.
        /// </summary>
        public static void LocomotionRequestSprintStopR2()
        {
            return;
        }

        /// <summary>
        /// Requests that the local player stand.
        /// </summary>
        public static void LocomotionRequestStandR2()
        {
            return;
        }

        /// <summary>
        /// Request that the local player is steered in the given direction, at the given speed.
        /// </summary>
        public static void LocomotionRequestSteeringR2(Vector3 direction, float normalizedSpeed, float maxSteeringSpeed, float accelerationTime)
        {
            return;
        }

        /// <summary>
        /// Requests for the local player to start wall climbing. Will only start a wall climb if executed by the Locomotion Wall Climb Ready event.
        /// </summary>
        public static void LocomotionRequestWallClimbStartR2()
        {
            return;
        }

        /// <summary>
        /// Requests for the player to stop wall climbing, if they are currently wall climbing.
        /// </summary>
        public static void LocomotionRequestWallClimbStopR2()
        {
            return;
        }

        /// <summary>
        /// Request that the local player begin to wall run. Only works if called via an exec line from the WallRunReady event.  
        /// Not affected by CanWallRun. If you want that property to impact this request you should check it yourself.
        /// </summary>
        public static void LocomotionRequestWallRunR2(float gravityMultiplier)
        {
            return;
        }

        /// <summary>
        /// Request that the local player stop wall running. Not affected by CanWallRun directly. If you want that property to impact this request you should check it yourself.
        /// </summary>
        public static void LocomotionRequestWallRunStopR2()
        {
            return;
        }

        public static void LocomotionSetSteeringInputEnabled(bool enabled)
        {
            return;
        }

        /// <summary>
        /// Computes a logarithm.
        /// </summary>
        public static float Logarithm(float value, float @base)
        {
            return default;
        }

        /// <summary>
        /// Logs the given error message to the logging tab of your palette.
        /// </summary>
        public static void LogError(string error)
        {
            return;
        }

        /// <summary>
        /// Logs a string to the logging tab of your palette.
        /// </summary>
        public static void LogString(string text)
        {
            return;
        }

        public static RRTuple<T0, T1> MakeTuple<T0, T1>(T0 item0, T1 item1)
        {
            return default;
        }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        public static int Max(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        public static float Max(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        public static int Min(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        public static float Min(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the modulo of the first value when divided by the second.
        /// </summary>
        public static int Modulo(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the modulo of the first value when divided by the second.
        /// </summary>
        public static float Modulo(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static int Multiply(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static float Multiply(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static Quaternion Multiply(params Quaternion[] value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies the two or more input values and outputs the result.
        /// </summary>
        public static Vector3 Multiply(params Vector3[] value)
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
        public static bool Nand(bool input)
        {
            return default;
        }

        /// <summary>
        /// Checks if a path exists between two positions using the NavMesh. 
        /// 
        /// Use &quot;Max Distance&quot; to indicate how far away from the NavMesh the positions can be. Lower values increase precision and can cause valid paths to register false if the target positions are not close enough to the NavMesh, while higher values decrease precision and can return a false positive if the margin is wide enough to include points that are not near the NavMesh.
        /// </summary>
        public static bool NavMeshCanPathBetween(Vector3 startPosition, Vector3 endPosition, float maxDistance)
        {
            return default;
        }

        public static (bool IsValid, Vector3 HitPosition) NavMeshSamplePosition(Vector3 sourcePosition, float maxDistance)
        {
            return default;
        }

        /// <summary>
        /// Samples a 3D Perlin noise field and returns a value usually bounded in [0,1].
        /// </summary>
        public static float Noise(Vector3 point)
        {
            return default;
        }

        /// <summary>
        /// Outputs True when all inputs are False. Otherwise, outputs False.
        /// </summary>
        public static bool Nor(bool input)
        {
            return default;
        }

        /// <summary>
        /// Outputs the opposite of the input boolean.
        /// </summary>
        public static bool Not(bool value)
        {
            return default;
        }

        /// <summary>
        /// Compares the input values and outputs True if they are different. False if they are the same.
        /// </summary>
        public static bool NotEquals<T>(T value, T value1)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker target, Player playerOrObject)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
        /// </summary>
        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarker target, RecRoomObject playerOrObject)
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
        public static Color ObjectiveMarkerGetColor(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Current Distance returns the current distance of the local player from the target Objective Marker, regardless of whether the distance indicator is enabled.
        /// </summary>
        public static float ObjectiveMarkerGetCurrentDistance(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Distance Is Enabled returns whether or not the target Objective Marker’s distance indicator is visible for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetDistanceEnabled(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Enabled returns whether or not the target Objective Marker is enabled for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetEnabled(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Fade Threshold returns the current fade threshold of the target Objective Marker for the local player.
        /// </summary>
        public static float ObjectiveMarkerGetFadeThreshold(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Label returns the current text label of target Objective Marker for the local player as a string.
        /// </summary>
        public static string ObjectiveMarkerGetLabel(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Label Is Enabled returns whether or not the target Objective Marker’s text label is visible for the local player.
        /// </summary>
        public static bool ObjectiveMarkerGetLabelEnabled(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Position returns target Objective Marker’s current position for the local player as a vector
        /// </summary>
        public static Vector3 ObjectiveMarkerGetPosition(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Target Object returns the object targeted by target Objective Marker, if it’s tracking an object. If target Objective Marker is not tracking an object, returns Invalid Object.
        /// </summary>
        public static RecRoomObject ObjectiveMarkerGetTargetObject(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Get Target Player returns the player targeted by target Objective Marker, if it’s tracking a player. If target Objective Marker is not tracking a player, returns Invalid Player.
        /// </summary>
        public static Player ObjectiveMarkerGetTargetPlayer(ObjectiveMarker target)
        {
            return default;
        }

        /// <summary>
        /// Objective Marker Set Color sets target Objective Marker to the specified color for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetColor(ObjectiveMarker target, Color color)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Distance Enabled enables or disables the visibility of the target Objective Marker’s distance indicator for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetDistanceEnabled(ObjectiveMarker target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Enabled enables or disables the target Objective Marker for the local player. Use with Objective Marker constant.
        /// </summary>
        public static void ObjectiveMarkerSetEnabled(ObjectiveMarker target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Fade Threshold sets the fade threshold of the target Objective Marker for the local player. This threshold is the distance (in meters) at which the marker has fully faded from sight as a player approaches it. For finer control over the fade duration, configure the Objective Marker constant.
        /// </summary>
        public static void ObjectiveMarkerSetFadeThreshold(ObjectiveMarker target, float proximity)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Label sets the text label of target Objective Marker to the specified string for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetLabel(ObjectiveMarker target, string label)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Label Enabled enables or disables the visibility of the target Objective Marker’s text label for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetLabelEnabled(ObjectiveMarker target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Objective Marker Set Position sets the position of target Objective Marker to a position vector for the local player.
        /// </summary>
        public static void ObjectiveMarkerSetPosition(ObjectiveMarker target, Vector3 position)
        {
            return;
        }

        /// <summary>
        /// Outputs True if any input is True. Otherwise outputs False.
        /// </summary>
        public static bool Or(params bool[] input)
        {
            return default;
        }

        public static void Out()
        {
            return;
        }

        /// <summary>
        /// Get information about all the objects/players within a box defined by its center, extents, and orientation. (position, distance, direction, etc.)
        /// </summary>
        public static List<CollisionData> OverlapBox(Vector3 center, Vector3 extents, Quaternion orientation, RaycastData config)
        {
            return default;
        }

        /// <summary>
        /// Get information about all the objects/players within a certain distance of a point in space (position, distance, direction, etc.)
        /// </summary>
        public static List<CollisionData> OverlapSphere(Vector3 origin, float radius, RaycastData config)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a bool if able.
        /// </summary>
        public static (bool Result, bool ParseSuccess) ParseBool(string @string)
        {
            return default;
        }

        /// <summary>
        /// Attempt to parse the given string as a hexadecimal color in the &apos;#RRGGBB&apos; format.
        /// </summary>
        public static (Color Result, bool ParseSuccess) ParseColor(string @string)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a float if able.
        /// </summary>
        public static (float Result, bool ParseSuccess) ParseFloat(string @string)
        {
            return default;
        }

        /// <summary>
        /// Converts the input string to a integer if able.
        /// </summary>
        public static (int Result, bool ParseSuccess) ParseInt(string @string)
        {
            return default;
        }

        /// <summary>
        /// Parses the input date and time and returns the corresponding universal seconds. The chip will automatically try to find the correct format of the input data.
        /// </summary>
        public static (int UniversalSeconds, bool Success) ParseTime(string time)
        {
            return default;
        }

        public static bool PathfinderGetEnableGroundClampingR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Gets the maximum acceleration of the Pathfinder, in meters per second squared
        /// </summary>
        public static float PathfinderGetMaxAccelerationR2(Pathfinder pathfinder)
        {
            return default;
        }

        public static float PathfinderGetMaxAngularSpeedR2(Pathfinder pathfinder)
        {
            return default;
        }

        public static float PathfinderGetMaxLinearSpeedR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Gets the Pathfinder&apos;s current pathing state information
        /// * Is Pathing
        /// * Has Arrived
        /// * Within Slowdown Distance
        /// </summary>
        public static (bool IsPathing, bool HasArrived, bool WithinSlowdownDistance) PathfinderGetPathingStateR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Gets the current pathing target (target position, slowdown and arrival distances) of the Pathfinder
        /// </summary>
        public static (Vector3 TargetPosition, float SlowdownDistance, float ArrivalDistance) PathfinderGetPathingTargetR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Gets the Pathfinder&apos;s current rotation state information
        /// * Is Rotating
        /// * Has Arrived
        /// </summary>
        public static (bool IsRotating, bool HasArrived) PathfinderGetRotationStateR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Gets the current pathing target (target direction, slowdown and arrival angles in degress) of the Pathfinder
        /// </summary>
        public static (Vector3 TargetDirection, float SlowdownAngle, float ArrivalAngle) PathfinderGetRotationTargetR2(Pathfinder pathfinder)
        {
            return default;
        }

        public static List<string> PathfinderGetTagsToIgnoreR2(Pathfinder pathfinder)
        {
            return default;
        }

        /// <summary>
        /// Toggles enabling ground clamping for the pathfinder
        /// </summary>
        public static void PathfinderSetGroundClampingR2(Pathfinder pathfinder, bool enable)
        {
            return;
        }

        /// <summary>
        /// Sets the maximum linear acceleration of the Pathfinder, in meters per second squared
        /// </summary>
        public static void PathfinderSetMaxAccelerationR2(Pathfinder pathfinder, float maxAcceleration)
        {
            return;
        }

        /// <summary>
        /// Sets the maximum angular speed of the Pathfinder, in degrees per second
        /// </summary>
        public static void PathfinderSetMaxAngularSpeedR2(Pathfinder pathfinder, float maxAngularSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets the maximum linear speed of the Pathfinder, in meters per second
        /// </summary>
        public static void PathfinderSetMaxLinearSpeedR2(Pathfinder pathfinder, float maxLinearSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets the object tags that the pathfinder ignores on collision
        /// </summary>
        public static void PathfinderSetTagsToIgnoreR2(Pathfinder pathfinder, List<string> tagsToIgnore)
        {
            return;
        }

        /// <summary>
        /// Starts moving the Pathfinder towards the target position
        /// It will slow down once it is within Slowdown Distance of the target
        /// And stop once it is within Arrival Distance of the target
        /// </summary>
        public static void PathfinderStartPathingToPositionR2(Pathfinder pathfinder, Vector3 targetPosition, float slowdownDistance, float arrivalDistance)
        {
            return;
        }

        /// <summary>
        /// Starts rotating the Pathfinder towards the target direction
        /// Rotation target takes priority over automatically rotating to face the pathing direction
        /// It will slow down once it is within Slowdown Angle (in degrees) of the target
        /// And stop once it is within Arrival Angle (in degrees) of the target
        /// </summary>
        public static void PathfinderStartRotatingToDirectionR2(Pathfinder pathfinder, Vector3 targetDirection, float slowdownAngle, float arrivalAngle)
        {
            return;
        }

        /// <summary>
        /// Stops moving the Pathfinder
        /// </summary>
        public static void PathfinderStopPathingR2(Pathfinder pathfinder)
        {
            return;
        }

        /// <summary>
        /// Clears the target rotation of a Pathfinder
        /// Automatic rotation to face the pathing direction will resume
        /// </summary>
        public static void PathfinderStopRotatingR2(Pathfinder pathfinder)
        {
            return;
        }

        /// <summary>
        /// Gets the acceleration of a piston.
        /// </summary>
        public static float PistonGetAcceleration(Piston target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the current distance of the target Piston.
        /// </summary>
        public static float PistonGetDistance(Piston target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the max distance of the target Piston.
        /// </summary>
        public static float PistonGetMaxDistance(Piston target)
        {
            return default;
        }

        /// <summary>
        /// Returns the speed of a piston.
        /// </summary>
        public static float PistonGetSpeed(Piston target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the set distance of the Marker on a target Piston.
        /// </summary>
        public static float PistonGetTargetDistance(Piston target)
        {
            return default;
        }

        /// <summary>
        /// Sets the acceleration of the target Piston.
        /// </summary>
        public static void PistonSetAcceleration(Piston target, float value)
        {
            return;
        }

        /// <summary>
        /// Moves the target piston to the input distance.
        /// </summary>
        public static void PistonSetDistance(Piston target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the max distance of a target Piston.
        /// </summary>
        public static void PistonSetMaxDistance(Piston target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed of a target Piston.
        /// </summary>
        public static void PistonSetSpeed(Piston target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the Marker distance of a target Piston.
        /// </summary>
        public static void PistonSetTargetDistance(Piston target, float value)
        {
            return;
        }

        public static void PlayAudioAtPosition(Audio audio, Vector3 position, float volume, float playbackSpeed, bool is2D, PlayAudioAtPositionData config)
        {
            return;
        }

        /// <summary>
        /// Adds a tag to the list of player tags that the provided player can target with aim assist.
        /// By default, this list contains the #player tag.
        /// </summary>
        public static void PlayerAddAimAssistTag(Player player, string tag)
        {
            return;
        }

        /// <summary>
        /// Adds a Role to a Player.
        /// </summary>
        public static void PlayerAddRoleR1(Player target, string value)
        {
            return;
        }

        /// <summary>
        /// Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static bool PlayerAwardXP(Player player, int amount, AlternativeExec<bool> onAwardComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player&apos;s body.
        /// </summary>
        public static Quaternion PlayerBodyOrientation(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player&apos;s body in world space.
        /// </summary>
        public static Vector3 PlayerBodyPosition(Player target)
        {
            return default;
        }

        /// <summary>
        /// Clears any subtitle which is currently being displayed for the given player.
        /// </summary>
        public static void PlayerClearCurrentSubtitle(Player player)
        {
            return;
        }

        /// <summary>
        /// This is very similar to an object board that you would find on any object, except this is for all players! After placing, make sure to configure it and make sure it is active. Edit into this board and add any other chips you&apos;d like and know that each player will have the same logic on them when you hit done editing.
        /// </summary>
        public static void PlayerDefinitionBoardEmpty()
        {
            return;
        }

        /// <summary>
        /// For the target player, equip the specified Inventory Item to the specified Inventory Equipment Slot. If the Slot is of Inventory type, this chip will take effect whether or not the Slot is enabled, but the Slot must then be enabled separately.
        /// </summary>
        public static bool PlayerEquipInventoryItemR2(Player player, InventoryItem inventoryItem, EquipmentSlot inventoryEquipmentSlot, AlternativeExec<bool> onEquipComplete)
        {
            return default;
        }

        /// <summary>
        /// Gets the list of player tags that the provided player can target with aim assist.
        /// By default, this list contains the #player tag.
        /// </summary>
        public static List<string> PlayerGetAimAssistTags(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets the fraction from 0 to 1 of the standard air control that this player has. 
        /// This is multiplied by the air control value for the user&apos;s current state to calculate their acceleration. 
        /// Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
        /// </summary>
        public static float PlayerGetAirControlPercentageR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Searches the room for all players with the input tag and outputs them as a list.
        /// </summary>
        public static List<Player> PlayerGetAllWithTag(string tag)
        {
            return default;
        }

        public static bool PlayerGetCanFlyR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether a given player is allowed to teleport.
        /// 
        /// Note: The value of this property is independent of a player&apos;s platform. (This value can be true for screens players.)
        /// </summary>
        public static bool PlayerGetCanTeleportR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets whether the player can Wall Climb. Enforced via circuits.
        /// </summary>
        public static bool PlayerGetCanWallClimbR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the costume that the given player is currently wearing.
        /// </summary>
        public static Costume PlayerGetCostume(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether crouch input is enabled for a given player
        /// </summary>
        public static bool PlayerGetCrouchInputEnabledR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the crouch speed for a given player.
        /// </summary>
        public static float PlayerGetCrouchSpeedR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player has their right hand set as dominant.
        /// </summary>
        public static bool PlayerGetDominantHandIsRight(Player player)
        {
            return default;
        }

        /// <summary>
        /// For the target player, get whether the specified equipment slot is enabled.
        /// </summary>
        public static bool PlayerGetEquipmentSlotIsEnabledR2(Player player, EquipmentSlot equipmentSlot)
        {
            return default;
        }

        /// <summary>
        /// Gets equipped objects from a player.
        /// </summary>
        public static (RecRoomObject DominantHandObject, RecRoomObject OffHandObject, RecRoomObject LeftHipHolsterObject, RecRoomObject RightHipHolsterObject, RecRoomObject ShoulderHolsterObject) PlayerGetEquippedObjects(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets the first player with the input tag.
        /// </summary>
        public static Player PlayerGetFirstWithTag(string tag)
        {
            return default;
        }

        /// <summary>
        /// Returns whether manual sprint is required for a given player
        /// </summary>
        public static bool PlayerGetForceManualSprintR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether Virtual Height Mode is required for a given player
        /// </summary>
        public static bool PlayerGetForceVirtualHeightModeR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player will be forced to use walk mode if they are playing in VR. 
        /// </summary>
        public static bool PlayerGetForceVRWalkR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Outputs if a Player is authority of the input object.
        /// </summary>
        public static bool PlayerGetIsAuthorityOf(Player target, RecRoomObject @object)
        {
            return default;
        }

        /// <summary>
        /// Whether or not the player is currently clambering or mantling up a ledge
        /// </summary>
        public static bool PlayerGetIsClambering(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is crouching
        /// </summary>
        public static bool PlayerGetIsCrouching(Player player)
        {
            return default;
        }

        public static bool PlayerGetIsCustomFootstepAudioActive(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is flying.
        /// </summary>
        public static bool PlayerGetIsFlying(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling. Also returns the time (in seconds) since they were last grounded, or 0 if currently grounded. Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object. Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they&apos;re not.
        /// </summary>
        public static (bool IsGrounded, float TimeSinceLastGrounded, RecRoomObject SurfaceObject, Vector3 SurfaceNormal) PlayerGetIsGrounded(Player player)
        {
            return default;
        }

        public static (bool IsJumpingOrFalling, RecRoomObject ContactSurface) PlayerGetIsJumpingOrFalling(Player player)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player is the local player executing the chip on their machine.
        /// </summary>
        public static bool PlayerGetIsLocal(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is prone.
        /// </summary>
        public static bool PlayerGetIsProne(Player player)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room&apos;s contributors.
        /// </summary>
        public static bool PlayerGetIsRoomContributor(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room&apos;s hosts.
        /// </summary>
        public static bool PlayerGetIsRoomHost(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room&apos;s moderators.
        /// </summary>
        public static bool PlayerGetIsRoomMod(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input Player is one of the current room&apos;s owners.
        /// </summary>
        public static bool PlayerGetIsRoomOwner(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is sliding.
        /// </summary>
        public static bool PlayerGetIsSliding(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is sprinting.
        /// </summary>
        public static bool PlayerGetIsSprinting(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets whether the player is currently in the Wall Climb state.
        /// </summary>
        public static bool PlayerGetIsWallClimbing(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether the given player is wall running.
        /// </summary>
        public static bool PlayerGetIsWallRunning(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the jump height for a given player
        /// </summary>
        public static float PlayerGetJumpHeightR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether jump input is enabled for a given player
        /// </summary>
        public static bool PlayerGetJumpInputEnabledR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// (DEPRECATED: Use PlayerGetSteeringSpeed / GetWalkSpeed) Returns the steering speed requested by the player, squared, and normalized by the square of the default walk speed.
        /// </summary>
        public static float PlayerGetNormalizedSteeringSpeedDeprecated(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets the physics velocity for the given player. 
        /// Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources 
        /// Physics velocity will generally be reduced over time by drag from various sources.
        /// </summary>
        public static Vector3 PlayerGetPhysicsVelocityR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns a list of players that are set to the given radio channel.
        /// </summary>
        public static List<Player> PlayerGetPlayersInRadioChannel(int channel)
        {
            return default;
        }

        /// <summary>
        /// Gets the profile image of the given player.
        /// </summary>
        public static RecNetImage PlayerGetProfileImage(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the prone speed for a given player.
        /// </summary>
        public static float PlayerGetProneSpeedR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Get the radio channel number of a player. If a player is not in any, this node returns -1
        /// </summary>
        public static int PlayerGetRadioChannel(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the unique index of this player in the room, bounded by the room capacity.
        /// </summary>
        public static int PlayerGetRoomIndex(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the current Room Level of the specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static int PlayerGetRoomLevel(Player player)
        {
            return default;
        }

        public static Seat PlayerGetSeat(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the slide speed for a given player.
        /// </summary>
        public static float PlayerGetSlideSpeedR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns whether sprint input is enabled for a given player
        /// </summary>
        public static bool PlayerGetSprintInputEnabledR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the sprint speed for a given player
        /// </summary>
        public static float PlayerGetSprintSpeedR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Player Get Steering Direction
        /// </summary>
        public static Vector3 PlayerGetSteeringDirection(Player player)
        {
            return default;
        }

        public static bool PlayerGetSteeringInputEnabled(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the steering speed requested by the player. This value represents how fast a player is wanting to move in world units.
        /// </summary>
        public static float PlayerGetSteeringSpeed(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the teleport delay for a given player
        /// </summary>
        public static float PlayerGetTeleportDelayR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the max teleport distance for a given player
        /// </summary>
        public static float PlayerGetTeleportDistanceR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the offset of the given player&apos;s local time zone from UTC in seconds.
        /// </summary>
        public static int PlayerGetTimeZone(Player player)
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
        public static (float VoiceRolloffDistance, bool HasLocalOverride) PlayerGetVoiceRolloffDistanceR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets the current microphone volume from the given player.
        /// </summary>
        public static float PlayerGetVolume(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns the walk speed for a given player
        /// </summary>
        public static float PlayerGetWalkSpeedR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Gets the whether the player can Wall Run. Enforced via circuits.
        /// </summary>
        public static bool PlayerGetWallRunEnabledR2(Player player)
        {
            return default;
        }

        /// <summary>
        /// Returns current XP of specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
        /// </summary>
        public static int PlayerGetXP(Player player)
        {
            return default;
        }

        public static bool PlayerHasPurchasedRoomOfferR2(Player player, RoomOffer roomOffer, AlternativeExec<bool> onPlayerHasPurchasedRoomOfferComplete)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the input player has the input role.
        /// </summary>
        public static bool PlayerHasRoleR1(Player target, string value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the forward vector of a Player&apos;s head.
        /// </summary>
        public static Vector3 PlayerHeadForwardVector(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the height of a Player&apos;s head.
        /// </summary>
        public static float PlayerHeadHeight(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player&apos;s head.
        /// </summary>
        public static Quaternion PlayerHeadOrientation(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the position of a Player&apos;s head in world space.
        /// </summary>
        public static Vector3 PlayerHeadPosition(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the up vector of a Player&apos;s head.
        /// </summary>
        public static Vector3 PlayerHeadUpVector(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player&apos;s head.
        /// </summary>
        public static Vector3 PlayerHeadVelocity(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs if the Player is holding their Maker Pen.
        /// Useful for having different logic while creating.
        /// </summary>
        public static bool PlayerIsHoldingMakerPen(Player target)
        {
            return default;
        }

        public static bool PlayerIsInParty(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player&apos;s left hand finger.
        /// </summary>
        public static Vector3 PlayerLeftHandFingerDirection(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player&apos;s left hand in world space.
        /// </summary>
        public static Vector3 PlayerLeftHandPosition(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player&apos;s left hand.
        /// </summary>
        public static Quaternion PlayerLeftHandRotation(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player&apos;s left hand thumb.
        /// </summary>
        public static Vector3 PlayerLeftHandThumbDirection(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player&apos;s left hand.
        /// </summary>
        public static Vector3 PlayerLeftHandVelocity(Player target)
        {
            return default;
        }

        /// <summary>
        /// Returns true if the given player owns at least one of the given inventory item.
        /// </summary>
        public static bool PlayerOwnsInventoryItemR2(Player player, InventoryItem inventoryItem, AlternativeExec<bool> complete)
        {
            return default;
        }

        public static bool PlayerOwnsRoomKeyR1(Player player, RoomKey roomKey, AlternativeExec<bool> onPlayerOwnsRoomKeyComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a prompt to the specified player containing the prompt title and body, along with each of the answer choices on its own line. The player can choose a response and hit &quot;ok,&quot; triggering the On Prompt Complete event. Since there is a delay between sending a prompt and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        /// </summary>
        public static (bool Success, Player ReceivingPlayer, string Response, int ResponseIndex) PlayerPromptMultipleChoice(Player player, string promptTitle, string promptBody, List<string> answerChoices, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response, int ResponseIndex)> onPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// Sends a prompt to the specified player where they can input text, which is then returned by this chip&apos;s output. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
        /// </summary>
        public static (bool Success, Player ReceivingPlayer, string Response) PlayerPromptText(Player player, string promptTitle, string promptBody, AlternativeExec<(bool Success, Player ReceivingPlayer, string Response)> onPromptComplete)
        {
            return default;
        }

        /// <summary>
        /// Removes a tag from the list of player tags that the provided player can target with aim assist.
        /// By default, this list contains the #player tag.
        /// </summary>
        public static void PlayerRemoveAimAssistTag(Player player, string tag)
        {
            return;
        }

        /// <summary>
        /// Removes the input role from a target player.
        /// </summary>
        public static void PlayerRemoveRoleR1(Player target, string value)
        {
            return;
        }

        /// <summary>
        /// Resets the color of the given player&apos;s name tag to the default color.
        /// </summary>
        public static void PlayerResetNameColor(Player player)
        {
            return;
        }

        /// <summary>
        /// Outputs the direction of a Player&apos;s right hand finger.
        /// </summary>
        public static Vector3 PlayerRightHandFingerDirection(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the postion of a Player&apos;s right hand in world space.
        /// </summary>
        public static Vector3 PlayerRightHandPosition(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a Player&apos;s right hand.
        /// </summary>
        public static Quaternion PlayerRightHandRotation(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the direction of a Player&apos;s right hand thumb.
        /// </summary>
        public static Vector3 PlayerRightHandThumbDirection(Player target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the velocity of a Player&apos;s right hand.
        /// </summary>
        public static Vector3 PlayerRightHandVelocity(Player target)
        {
            return default;
        }

        /// <summary>
        /// Sets the list of player tags that the provided player can target with aim assist.
        /// By default, this list contains the #player tag.
        /// </summary>
        public static void PlayerSetAimAssistTags(Player player, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Sets the fraction from 0 to 1 of the standard air control that this player will have. 
        /// This is multiplied by the air control value for the user&apos;s current state to calculate their acceleration. 
        /// Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
        /// </summary>
        public static void PlayerSetAirControlPercentageR2(Player player, float airControlPercentage)
        {
            return;
        }

        public static void PlayerSetCanFlyR2(Player player, bool canFly)
        {
            return;
        }

        /// <summary>
        /// Sets whether a given player is allowed to teleport.
        /// 
        /// Note: Setting this to false does not prevent VR players from being in Teleport mode. It only prevents them from performing a teleport.
        /// </summary>
        public static void PlayerSetCanTeleportR2(Player player, bool canTeleport)
        {
            return;
        }

        /// <summary>
        /// Sets whether the player can Wall Climb. Enforced via circuits.
        /// </summary>
        public static void PlayerSetCanWallClimbR2(Player player, bool wallClimbEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets whether crouch input is enabled for a given player. Setting this to false will remove crouch button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetCrouchInputEnabledR2(Player player, bool crouchInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the crouch speed for a given player
        /// </summary>
        public static void PlayerSetCrouchSpeedR2(Player player, float crouchSpeed)
        {
            return;
        }

        /// <summary>
        /// Enables the specified equipment slot on the target player
        /// </summary>
        public static void PlayerSetEquipmentSlotIsEnabledR2(Player player, EquipmentSlot equipmentSlot, bool isEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets whether manual sprint is required for a given player.
        /// 
        /// Players can choose whether they want to use auto sprint in their settings.
        /// </summary>
        public static void PlayerSetForceManualSprintR2(Player player, bool forceManualSprint)
        {
            return;
        }

        /// <summary>
        /// Sets whether Virtual Height Mode is required for a given player.
        /// 
        /// Players can choose whether they want to use Physical Height Mode in their settings.
        /// </summary>
        public static void PlayerSetForceVirtualHeightModeR2(Player player, bool forceVirtualHeightMode)
        {
            return;
        }

        /// <summary>
        /// Forces the given player to use walk rather than teleport mode if they are playing in VR. This is useful when you need access to their walk inputs which won&apos;t fire if they are in teleport mode. You should consider adding a warning to your room so teleport players are aware that you&apos;re going to change their movement mode.
        /// </summary>
        public static void PlayerSetForceVRWalkR2(Player player, bool forceVRWalk)
        {
            return;
        }

        /// <summary>
        /// Sets the jump height for a given player
        /// </summary>
        public static void PlayerSetJumpHeightR2(Player player, float jumpHeight)
        {
            return;
        }

        /// <summary>
        /// Sets whether jump input is enabled for a given player. Setting this to false will remove jump button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetJumpInputEnabledR2(Player player, bool jumpInputEnabled)
        {
            return;
        }

        public static void PlayerSetNameColor(Player player, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the physics velocity for the given player.  
        /// Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources. 
        /// Physics velocity will generally be reduced over time by drag from various sources. 
        /// This node is similar Velocity Set. However, that node also zeroes the Steering Velocity.
        /// </summary>
        public static void PlayerSetPhysicsVelocityR2(Player player, Vector3 physicsVelocity)
        {
            return;
        }

        /// <summary>
        /// Sets the prone speed for a given player
        /// </summary>
        public static void PlayerSetProneSpeedR2(Player player, float proneSpeed)
        {
            return;
        }

        /// <summary>
        /// Assign a player to a radio channel. The channel needs to be a non-negative integer value. Players within the same channel will be able to communicate in team radio.
        /// </summary>
        public static void PlayerSetRadioChannel(Player player, int channel)
        {
            return;
        }

        /// <summary>
        /// Sets the slide speed for a given player
        /// </summary>
        public static void PlayerSetSlideSpeedR2(Player player, float slideSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets whether sprint input is enabled for a given player. Setting this to false will remove sprint button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetSprintInputEnabledR2(Player player, bool sprintInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the sprint speed for a given player
        /// </summary>
        public static void PlayerSetSprintSpeedR2(Player player, float sprintSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
        /// </summary>
        public static void PlayerSetSteeringInputEnabledR2(Player player, bool steeringInputEnabled)
        {
            return;
        }

        /// <summary>
        /// Sets the steering velocity for the given player.  
        /// Steering Velocity should generally be modified via Locomotion Steering Request. 
        /// Setting it directly may result in animation artifacts but can be done in special cases.
        /// </summary>
        public static void PlayerSetSteeringVelocityR2(Player player, Vector3 steeringVelocity)
        {
            return;
        }

        /// <summary>
        /// Sets the teleport delay for a given player
        /// </summary>
        public static void PlayerSetTeleportDelayR2(Player player, float teleportDelay)
        {
            return;
        }

        /// <summary>
        /// Sets the max teleport distance for a given player
        /// </summary>
        public static void PlayerSetTeleportDistanceR2(Player player, float teleportDistance)
        {
            return;
        }

        /// <summary>
        /// Sets the voice rolloff distance for a given player as heard by all other players.
        /// 
        /// Beyond this distance, the target player cannot be heard.
        /// </summary>
        public static void PlayerSetVoiceRolloffDistanceR2(Player player, float voiceRolloffDistance)
        {
            return;
        }

        /// <summary>
        /// Sets the walk speed for a given player
        /// </summary>
        public static void PlayerSetWalkSpeedR2(Player player, float walkSpeed)
        {
            return;
        }

        /// <summary>
        /// Sets the whether the player can Wall Run. Enforced via circuits.
        /// </summary>
        public static void PlayerSetWallRunEnabledR2(Player player, bool wallRunEnabled)
        {
            return;
        }

        /// <summary>
        /// Displays a subtitle for a specified duration. If there is already a subtitle showing, it will be replaced only if this subtitle has an equal or higher priority. If the string is more than 200 characters, it will be displayed in multiple subtitles, each lasting a fraction of the total duration. Escape characters are ignored.
        /// </summary>
        public static void PlayerShowSubtitle(Player player, string subtitle, float duration, int priority)
        {
            return;
        }

        /// <summary>
        /// Outputs True if the input Player subscribes to one of the current room&apos;s owners.
        /// </summary>
        public static (bool Result, int SecondsUntilEnabled) PlayerSubscribesToRoomOwnerDeprecated(Player target)
        {
            return default;
        }

        /// <summary>
        /// For the specified player, unequip anything which is equipped to the specified slot. If the slot is of Inventory type, this chip will take effect whether or not the slot is enabled.
        /// </summary>
        public static bool PlayerUnequipFromSlotR2(Player player, EquipmentSlot equipmentSlot, AlternativeExec<bool> onUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// For the target player, unequip the specified Inventory Item from any slot to which it is equipped.
        /// </summary>
        public static bool PlayerUnequipInventoryItemR2(Player player, InventoryItem inventoryItem, AlternativeExec<bool> onUnequipComplete)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player PlayerVariable(Player port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Player PlayerVariableDeprecated(Player port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Define a set of world-space UI elements that can appear above a player.
        /// </summary>
        public static PlayerWorldUI PlayerWorldUI(PlayerWorldUIData config)
        {
            return default;
        }

        /// <summary>
        /// Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
        /// </summary>
        public static void PlayHandleHaptics(Handle handle, int duration, float intensity)
        {
            return;
        }

        /// <summary>
        /// Multiplies a value by itself an input number of times.
        /// </summary>
        internal static int Power(int value)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a value by itself an input number of times.
        /// </summary>
        internal static float Power(float value)
        {
            return default;
        }

        public static void PrintTextToScreen(TextScreen target, string text, Color color)
        {
            return;
        }

        public static void ProjectileLauncherFireProjectile(ProjectileLauncher target, Vector3 direction)
        {
            return;
        }

        /// <summary>
        /// Returns the player set by the Projectile Launcher Set Firing Player chip.
        /// </summary>
        public static Player ProjectileLauncherGetFiringPlayer(ProjectileLauncher target)
        {
            return default;
        }

        public static int ProjectileLauncherGetProjectileCount(ProjectileLauncher target)
        {
            return default;
        }

        public static float ProjectileLauncherGetProjectileLifetime(ProjectileLauncher target)
        {
            return default;
        }

        public static float ProjectileLauncherGetProjectileSpeed(ProjectileLauncher target)
        {
            return default;
        }

        public static float ProjectileLauncherGetProjectileSpread(ProjectileLauncher target)
        {
            return default;
        }

        /// <summary>
        /// Sets the firing player of the target Projectile Launcher. If none is set, the component will use the authority player.
        /// </summary>
        public static void ProjectileLauncherSetFiringPlayer(ProjectileLauncher target, Player player)
        {
            return;
        }

        public static void ProjectileLauncherSetProjectileCount(ProjectileLauncher target, int count)
        {
            return;
        }

        public static void ProjectileLauncherSetProjectileLifetime(ProjectileLauncher target, float lifetime)
        {
            return;
        }

        public static void ProjectileLauncherSetProjectileSpeed(ProjectileLauncher target, float speed)
        {
            return;
        }

        public static void ProjectileLauncherSetProjectileSpread(ProjectileLauncher target, float spread)
        {
            return;
        }

        /// <summary>
        /// Sends a watch notification to a player. The player which it sends a notification to depends on who&apos;s machine fires the exec pin. Once this watch notification is opened, the player can type responses into the text box and send back responses. You can define the prompt title and the prompt itself via inputs, and can also receive the player’s response via an output pin.
        /// </summary>
        public static string PromptLocalPlayer(string promptTitle, string prompt, AlternativeExec<string> complete, AlternativeExec<string> failed)
        {
            return default;
        }

        /// <summary>
        /// Manually create a quaternion. Congratulations, you have reached peak math.
        /// </summary>
        public static Quaternion QuaternionCreate(float x, float y, float z, float w)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation which rotates &quot;Angle&quot; degrees around &quot;Axis&quot;.
        /// </summary>
        public static Quaternion QuaternionCreateAngleAxis(float angle, Vector3 axis)
        {
            return default;
        }

        /// <summary>
        /// Creates a quaternion from an input Vector3.
        /// </summary>
        public static Quaternion QuaternionCreateEulerAngles(Vector3 angles)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation which rotates from &quot;From&quot; to &quot;To&quot;.
        /// </summary>
        public static Quaternion QuaternionCreateFromTo(Vector3 from, Vector3 to)
        {
            return default;
        }

        /// <summary>
        /// Creates a rotation with the specified forward and upwards directions.
        /// </summary>
        public static Quaternion QuaternionCreateLook(Vector3 forward, Vector3 upwards)
        {
            return default;
        }

        /// <summary>
        /// The dot product between two rotations.
        /// </summary>
        public static float QuaternionDot(Quaternion lhs, Quaternion rhs)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input quaternion as a vector3.
        /// </summary>
        public static Vector3 QuaternionEulerAngles(Quaternion value)
        {
            return default;
        }

        /// <summary>
        /// Gets the rotation which rotates angle degrees around axis.
        /// </summary>
        public static (float Angle, Vector3 Axis) QuaternionGetAngleAxis(Quaternion quaternion)
        {
            return default;
        }

        /// <summary>
        /// Outputs the Inverse of rotation.
        /// </summary>
        public static Quaternion QuaternionInverse(Quaternion value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the input quaternion with the same rotation but with a magnitude of 1.
        /// </summary>
        public static Quaternion QuaternionNormalize(Quaternion value)
        {
            return default;
        }

        /// <summary>
        /// Rotates a rotation from &quot;From&quot; towards &quot;To&quot;.
        /// </summary>
        public static Quaternion QuaternionRotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
        {
            return default;
        }

        /// <summary>
        /// Split a quaternion into its four float components: x, y, z, and w. Congratulations, you have reached peak math.
        /// </summary>
        public static (float X, float Y, float Z, float W) QuaternionSplit(Quaternion quaternion)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Quaternion QuaternionVariable(Quaternion port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Configure this constant to add a set of custom Quick Chat phrases to your room, and enable them per-player with Quick Chat Table Set Enabled. Chat options will appear in the Quick Chat &gt; This Room category.
        /// </summary>
        public static QuickChatTable QuickChatTable()
        {
            return default;
        }

        /// <summary>
        /// Enable or disable the specified Quick Chat Table for the specified player. If a different set of custom Quick Chat phrases is already enabled, this will overwrite it.
        /// </summary>
        public static void QuickChatTableSetEnabled(QuickChatTable target, Player player, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Generates a random float from [&quot;Min&quot; to &quot;Max&quot;]. &quot;Min&quot; is inclusive, and &quot;Max&quot; is also inclusive. For example with a &quot;Min&quot; of 0 and a &quot;Max&quot; of 1, both 0 and 1 have the possibility of getting output because they are both included in the range.
        /// </summary>
        public static float RandomFloat(float min, float max)
        {
            return default;
        }

        public static T RandomFromList<T>(List<T> list)
        {
            return default;
        }

        /// <summary>
        /// Outputs a random value from a target list.
        /// </summary>
        public static T RandomFromListDeprecated<T>(List<T> list)
        {
            return default;
        }

        /// <summary>
        /// Generates a random integer from [&quot;Min&quot; to &quot;Max&quot;]. &quot;Min&quot; is inclusive, and &quot;Max&quot; is also inclusive. For example with a &quot;Min&quot; of 0 and a &quot;Max&quot; of 1, 0 and 1 will have a chance of being output.
        /// </summary>
        public static int RandomInt(int min, int max)
        {
            return default;
        }

        public static Color RangedWeaponGetColor(RangedWeapon target)
        {
            return default;
        }

        public static int RangedWeaponGetHeadDamage(RangedWeapon target)
        {
            return default;
        }

        public static int RangedWeaponGetLimbDamage(RangedWeapon target)
        {
            return default;
        }

        public static Color RangedWeaponGetProjectileColor(RangedWeapon target)
        {
            return default;
        }

        /// <summary>
        /// Returns the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        /// </summary>
        public static int RangedWeaponGetRecRoomObjectDamage(RangedWeapon target)
        {
            return default;
        }

        public static int RangedWeaponGetTorsoDamage(RangedWeapon target)
        {
            return default;
        }

        public static void RangedWeaponSetColor(RangedWeapon target, Color color)
        {
            return;
        }

        public static void RangedWeaponSetHeadDamage(RangedWeapon target, int damage)
        {
            return;
        }

        public static void RangedWeaponSetLimbDamage(RangedWeapon target, int damage)
        {
            return;
        }

        public static void RangedWeaponSetProjectileColor(RangedWeapon target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
        /// </summary>
        public static void RangedWeaponSetRecRoomObjectDamage(RangedWeapon target, int damage)
        {
            return;
        }

        public static void RangedWeaponSetTorsoDamage(RangedWeapon target, int damage)
        {
            return;
        }

        /// <summary>
        /// Fires an invisible ray from the &quot;Start Position&quot;, in the &quot;Direction&quot; specified. Returns True if any object or player is hit within the target &quot;Max Distance&quot;. Otherwise, returns False. You can configure the chip itself to ignore players or objects specifically.
        /// </summary>
        public static (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Raycast(Vector3 startPosition, Vector3 direction, float maxDistance, RaycastData config)
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
        /// Searches the room for all objects with the input tag and outputs a list of their direct children and all descendants in the hierarchy.
        /// </summary>
        public static List<RecRoomObject> RecRoomObjectGetAllChildrenWithTagR2(RecRoomObject @object, string tag)
        {
            return default;
        }

        /// <summary>
        /// Searches the room for all objects with the input tag and outputs them as a list.
        /// </summary>
        public static List<RecRoomObject> RecRoomObjectGetAllWithTag(string tag)
        {
            return default;
        }

        /// <summary>
        /// Searches the room for all objects with the input tag and outputs them as a list.
        /// 
        /// Objects are guaranteed to be returned in the same order for every player in an room. The order may change between instances of a room or when the room is reloaded.
        /// </summary>
        public static List<RecRoomObject> RecRoomObjectGetAllWithTagNew(string tag)
        {
            return default;
        }

        /// <summary>
        /// Outputs the authority Player of the input object.
        /// </summary>
        public static Player RecRoomObjectGetAuthority(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Gets the first object with the input tag.
        /// </summary>
        public static RecRoomObject RecRoomObjectGetFirstWithTag(string tag)
        {
            return default;
        }

        /// <summary>
        /// Gets the player currently holding this object. Does not account for when objects are equipped but not directly grabbed. Returns Invalid Player if the object is not being held.
        /// </summary>
        public static (bool IsHeld, Player HolderPlayer) RecRoomObjectGetHolderPlayer(RecRoomObject @object)
        {
            return default;
        }

        /// <summary>
        /// Outputs True on the player&apos;s machine who has authority of the input.
        /// </summary>
        public static bool RecRoomObjectGetIsLocalPlayerAuthority(RecRoomObject target)
        {
            return default;
        }

        /// <summary>
        /// Returns the player who last held or equipped an object.
        /// </summary>
        public static (Player Player, bool CurrentlyHeldOrEquipped) RecRoomObjectGetLastHoldingOrEquippingPlayer(RecRoomObject @object)
        {
            return default;
        }

        public static RecRoomObject RecRoomObjectGetRootObject(RecRoomObject targetObject)
        {
            return default;
        }

        /// <summary>
        /// Resets an object.
        /// </summary>
        public static void RecRoomObjectReset(RecRoomObject @object)
        {
            return;
        }

        /// <summary>
        /// Sets the authority player of the input Rec Room Object.
        /// </summary>
        public static void RecRoomObjectSetAuthority(RecRoomObject target, Player authority)
        {
            return;
        }

        internal static RecRoomObject RecRoomObjectVariable(RecRoomObject port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Outputs the remainder of the first value when divided by the second.
        /// </summary>
        public static int Remainder(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the remainder of the first value when divided by the second.
        /// </summary>
        public static float Remainder(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Remove a player from the radio channel they are in
        /// </summary>
        public static void RemovePlayerFromRadioChannel(Player player)
        {
            return;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public static void RemoveTag(Player target, string tag)
        {
            return;
        }

        /// <summary>
        /// Removes a tag from the input object or player.
        /// </summary>
        public static void RemoveTag(RecRoomObject target, string tag)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public static void RemoveTags(Player target, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Removes the input list of tags from the input object or player.
        /// </summary>
        public static void RemoveTags(RecRoomObject target, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Returns the total number of objects that have been spawned by the target replicator and are currently active.
        /// </summary>
        public static int ReplicatorGetActiveObjectsCountR2(Replicator target)
        {
            return default;
        }

        /// <summary>
        /// Returns the list of objects that have been spawned by the target replicator and are currently active.
        /// </summary>
        public static List<RecRoomObject> ReplicatorGetActiveObjectsR2(Replicator target)
        {
            return default;
        }

        /// <summary>
        /// If the target object was spawned by a replicator, it will be despawned and returned to the pool. If not, the chip will no-op.
        /// </summary>
        public static void ReplicatorReturnObjectR2(RecRoomObject target)
        {
            return;
        }

        /// <summary>
        /// Spawns a copy of the object assigned to the target replicator at the position and orientation specified. If “Assign to Player” is true, the resulting object will be assigned to the specified player such that no other players can interact with it, and the object will be automatically returned when that player leaves the room. 
        /// 
        /// When the object is spawned, On Spawn Complete will fire and pass through an object reference. If it fails, such as when the limit of objects has been hit, the object reference will be invalid and the Success bool will be false.
        /// </summary>
        public static (RecRoomObject Object, bool Success) ReplicatorSpawnNextObjectR2(Replicator target, Vector3 position, Quaternion orientation, bool assignToPlayer, Player player, AlternativeExec<(RecRoomObject Object, bool Success)> onSpawnComplete)
        {
            return default;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public static void RequestVelocitySetOverDuration(Player @object, float multiplier, Vector3 velocity, float duration)
        {
            return;
        }

        /// <summary>
        /// Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
        /// </summary>
        public static void RequestVelocitySetOverDuration(RecRoomObject @object, float multiplier, Vector3 velocity, float duration)
        {
            return;
        }

        /// <summary>
        /// Used to remove spaghetti from your creations. Consumes additional CPU heat.
        /// </summary>
        public static T Reroute<T>(T port0)
        {
            return default;
        }

        /// <summary>
        /// Reset the player&apos;s active world UI to its default values.
        /// </summary>
        public static void ResetPlayerWorldUI(Player player)
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
        public static bool Respawn(Player target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(Player target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(RecRoomObject target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool Respawn(RecRoomObject target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects)
        {
            return default;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Player target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects, AlternativeExec failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(Player target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects, AlternativeExec failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(RecRoomObject target, Vector3 position, Vector3 rotation, float spawnRadius, bool clearVelocity, bool useRezEffects, AlternativeExec failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void RespawnDeprecated(RecRoomObject target, Vector3 position, Quaternion rotation, float spawnRadius, bool clearVelocity, bool useRezEffects, AlternativeExec failed)
        {
            return;
        }

        public static bool RespawnPointAddAvoidRoleR1(PlayerSpawnPointV2 spawnPoint, string role)
        {
            return default;
        }

        public static void RespawnPointAddAvoidTag(PlayerSpawnPointV2 spawnPoint, string tag)
        {
            return;
        }

        public static bool RespawnPointAddSpawnRoleR1(PlayerSpawnPointV2 spawnPoint, string role)
        {
            return default;
        }

        public static void RespawnPointAddSpawnTag(PlayerSpawnPointV2 spawnPoint, string tag)
        {
            return;
        }

        public static bool RespawnPointGetActive(PlayerSpawnPointV2 target)
        {
            return default;
        }

        public static void RespawnPointRemoveAvoidRoleR1(PlayerSpawnPointV2 spawnPoint, string role)
        {
            return;
        }

        public static void RespawnPointRemoveAvoidTag(PlayerSpawnPointV2 spawnPoint, string tag)
        {
            return;
        }

        public static void RespawnPointRemoveSpawnRoleR1(PlayerSpawnPointV2 spawnPoint, string role)
        {
            return;
        }

        public static void RespawnPointRemoveSpawnTag(PlayerSpawnPointV2 spawnPoint, string tag)
        {
            return;
        }

        public static void RespawnPointRespawnPlayer(Player player, bool clearVelocity, bool useRezEffects)
        {
            return;
        }

        public static void RespawnPointRespawnPlayerAtRespawnPoint(PlayerSpawnPointV2 spawnPoint, Player player, bool clearVelocity, bool useRezEffects)
        {
            return;
        }

        public static void RespawnPointSetActive(PlayerSpawnPointV2 target, bool active)
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
        public static Color RGBToColor(float red, float green, float blue)
        {
            return default;
        }

        /// <summary>
        /// Clears the given player&apos;s local room background objects state override.
        /// </summary>
        public static void RoomBackgroundObjectsClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static bool RoomBackgroundObjectsModifyR1(BackgroundObjects backgroundObjectsConstant, AlternativeExec<bool> blendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared background objects state to the given configuration.
        /// </summary>
        public static void RoomBackgroundObjectsModifyR2(BackgroundObjects backgroundObjects, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room background objects state to the given configuration. This will take precedent over the room&apos;s shared background objects state.
        /// </summary>
        public static void RoomBackgroundObjectsPlayerOverrideR2(BackgroundObjects backgroundObjects, Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static void RoomBackgroundObjectsResetR1(AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Resets the room&apos;s shared background objects state to the room default.
        /// </summary>
        public static void RoomBackgroundObjectsResetR2(float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static RoomCurrency RoomCurrencyConstantR1(RoomCurrencyData config)
        {
            return default;
        }

        /// <summary>
        /// Clears the given player&apos;s local room fog state override.
        /// </summary>
        public static void RoomFogClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static bool RoomFogModifyR1(Fog fogConstant, AlternativeExec<bool> blendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared fog state to the given configuration.
        /// </summary>
        public static void RoomFogModifyR2(Fog fog, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room fog state to the given configuration. This will take precedent over the room&apos;s shared fog state.
        /// </summary>
        public static void RoomFogPlayerOverrideR2(Fog fog, Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static void RoomFogResetR1(AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Resets the room&apos;s shared fog state to the room default.
        /// </summary>
        public static void RoomFogResetR2(float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static bool RoomGetMatchmakingState()
        {
            return default;
        }

        /// <summary>
        /// Returns the player in the room with this unique index, bounded by the room capacity.
        /// </summary>
        public static Player RoomIndexGetPlayer(int roomIndex)
        {
            return default;
        }

        public static RoomKey RoomKeyConstantR1(RoomKeyData config)
        {
            return default;
        }

        /// <summary>
        /// HUD elements including progress bars, wheels, and counters. Configure to customize a single element, then enable &amp; modify with existing HUD chips. Can be configured to pull data from Room Progression if Progression is enabled in room settings.
        /// </summary>
        public static RoomLevelHUD RoomLevelHUD()
        {
            return default;
        }

        /// <summary>
        /// A specialized data table for use with Room Progression, with some cells and formatting choices reserved. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room via Data Table UI to commit changes.
        /// </summary>
        public static void RoomLevels(object levels)
        {
            return;
        }

        public static RoomOffer RoomOfferConstantR2()
        {
            return default;
        }

        public static bool RoomSetMatchmakingState(bool matchmakingPermitted, AlternativeExec<bool> onMatchmakingStateSet)
        {
            return default;
        }

        /// <summary>
        /// Clears the given player&apos;s local room skydome state override.
        /// </summary>
        public static void RoomSkydomeClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static bool RoomSkydomeModifyR1(Skydome skydomeConstant, AlternativeExec<bool> blendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared skydome state to the given configuration.
        /// </summary>
        public static void RoomSkydomeModifyR2(Skydome skydome, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room skydome state to the given configuration. This will take precedent over the room&apos;s shared skydome state.
        /// </summary>
        public static void RoomSkydomePlayerOverrideR2(Skydome skydome, Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static void RoomSkydomeResetR1(AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Resets the room&apos;s shared skydome state to the room default.
        /// </summary>
        public static void RoomSkydomeResetR2(float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Clears the given player&apos;s local room sun state override.
        /// </summary>
        public static void RoomSunClearPlayerOverrideR2(Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static bool RoomSunModifyR1(Sun sunConstant, SunDirection sunDirection, AlternativeExec<bool> blendFinished)
        {
            return default;
        }

        /// <summary>
        /// Changes the room&apos;s shared sun state to the given configuration.
        /// </summary>
        public static void RoomSunModifyR2(Sun sun, SunDirection sunDirection, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Overrides the given player&apos;s room sun state to the given configuration. This will take precedent over the room&apos;s shared sun state.
        /// </summary>
        public static void RoomSunPlayerOverrideR2(Sun sun, SunDirection sunDirection, Player player, float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        public static void RoomSunResetR1(AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Resets the room&apos;s shared sun state to the room default.
        /// </summary>
        public static void RoomSunResetR2(float blendTime, AlternativeExec blendFinished)
        {
            return;
        }

        /// <summary>
        /// Calculate the root of a given value, with the default root being 2 (meaning the square root).
        /// </summary>
        public static float Root(float value, float root)
        {
            return default;
        }

        public static RecRoomObject RootObject()
        {
            return default;
        }

        public static Player RootPlayer()
        {
            return default;
        }

        /// <summary>
        /// Rotate a Vector3 with a Quaternion.
        /// </summary>
        public static Vector3 RotateVector(Quaternion rotation, Vector3 point)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of a target Rotator in degrees.
        /// </summary>
        public static float RotatorGetRotation(Rotator target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the acceleration of a target Rotator.
        /// </summary>
        public static float RotatorGetRotationAcceleration(Rotator target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the speed of a target Rotator.
        /// </summary>
        public static float RotatorGetRotationSpeed(Rotator target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the rotation of the Marker on the target Rotator.
        /// </summary>
        public static float RotatorGetTargetRotation(Rotator target)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of a target Rotator.
        /// </summary>
        public static void RotatorSetRotation(Rotator target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the acceleration of a target Rotator.
        /// </summary>
        public static void RotatorSetRotationAcceleration(Rotator target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the speed of a target Rotator.
        /// </summary>
        public static void RotatorSetRotationSpeed(Rotator target, float value)
        {
            return;
        }

        /// <summary>
        /// Sets the rotation of the Marker on a target Rotator.
        /// </summary>
        public static void RotatorSetTargetRotation(Rotator target, float value)
        {
            return;
        }

        /// <summary>
        /// Rounds the input float to the nearest integral value.
        /// </summary>
        public static float Round(float value)
        {
            return default;
        }

        /// <summary>
        /// Rounds an input value to the nearest integer.
        /// </summary>
        public static int RoundToInt(float value)
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
        public static bool SeatGetLockPlayersIn(Seat target)
        {
            return default;
        }

        /// <summary>
        /// Returns True if the target Seat is set to lock players out.
        /// </summary>
        public static bool SeatGetLockPlayersOut(Seat target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the currently seated player of a target Seat.
        /// </summary>
        public static Player SeatGetSeatedPlayer(Seat target)
        {
            return default;
        }

        /// <summary>
        /// Prevents a Seated player from unseating themselves on a target Seat. Use circuits to unseat or unlock.
        /// </summary>
        public static void SeatSetLockPlayersIn(Seat target, bool lockPlayersIn)
        {
            return;
        }

        /// <summary>
        /// Prevents players from sitting in a target seat.
        /// </summary>
        public static void SeatSetLockPlayersOut(Seat target, bool lockPlayersOut)
        {
            return;
        }

        /// <summary>
        /// Seats an input player on a target Seat.
        /// </summary>
        public static void SeatSetSeatedPlayer(Seat target, Player player, AlternativeExec fail)
        {
            return;
        }

        /// <summary>
        /// Unseats a currently seated player on a target Seat.
        /// </summary>
        public static void SeatUnseatPlayer(Seat target)
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
        internal static void Sequence<T>(AlternativeExec _2, SequenceData config)
        {
            return;
        }

        /// <summary>
        /// Start a screen shake effect for the given player. This will have no effect on VR players.
        /// </summary>
        public static void SetCameraShake(Player player, float intensity, float duration)
        {
            return;
        }

        public static void SetHUDElementColor(HUDConstant target, Color color)
        {
            return;
        }

        /// <summary>
        /// Override all Game HUD Element properties using default values from Game HUD Element Constant input
        /// </summary>
        public static void SetHUDElementContent(HUDConstant target)
        {
            return;
        }

        public static void SetHUDElementEnabled(HUDConstant target, bool enabled)
        {
            return;
        }

        public static void SetHUDElementLabel(HUDConstant target, string label)
        {
            return;
        }

        public static void SetHUDElementLabelEnabled(HUDConstant target, bool enabled)
        {
            return;
        }

        public static void SetHUDElementMaxValue(HUDConstant target, int value)
        {
            return;
        }

        public static void SetHUDElementValue(HUDConstant target, int value)
        {
            return;
        }

        public static void SetHUDElementValueTextEnabled(HUDConstant target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
        /// </summary>
        public static void SetPlayerVignette(Player player, float time, Color color, float intensity)
        {
            return;
        }

        /// <summary>
        /// Set the color of the primary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarColor(Player player, Color color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the primary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarEnabled(Player player, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Set the max value of the primary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarMaxValue(Player player, int value)
        {
            return;
        }

        /// <summary>
        /// Set the value of the primary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUIPrimaryBarValue(Player player, int value)
        {
            return;
        }

        /// <summary>
        /// Set the color of the secondary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarColor(Player player, Color color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the secondary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarEnabled(Player player, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Set the max value of the secondary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarMaxValue(Player player, int value)
        {
            return;
        }

        /// <summary>
        /// Set the value of the secondary bar in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUISecondaryBarValue(Player player, int value)
        {
            return;
        }

        /// <summary>
        /// Set the color of the text in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextColor(Player player, Color color)
        {
            return;
        }

        /// <summary>
        /// Set the enabled state of the text in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextEnabled(Player player, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Set the value of the text in the given player&apos;s active world UI.
        /// </summary>
        public static void SetPlayerWorldUITextValue(Player player, string value)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPosition(Player target, Vector3 position)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPosition(RecRoomObject target, Vector3 position)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(Player target, Vector3 position, AlternativeExec failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static void SetPositionDeprecated(RecRoomObject target, Vector3 position, AlternativeExec failed)
        {
            return;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPositionInReferenceObjectSpace(Player target, Vector3 position, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPositionInReferenceObjectSpace(Player target, Vector3 position, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPositionInReferenceObjectSpace(RecRoomObject target, Vector3 position, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetPositionInReferenceObjectSpace(RecRoomObject target, Vector3 position, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Player target, Vector3 rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(Player target, Quaternion rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(RecRoomObject target, Vector3 rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetRotation(RecRoomObject target, Quaternion rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(Player target, Vector3 rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(Player target, Vector3 rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(Player target, Quaternion rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(Player target, Quaternion rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(RecRoomObject target, Vector3 rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(RecRoomObject target, Vector3 rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(RecRoomObject target, Quaternion rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
        /// </summary>
        public static bool SetRotationInReferenceObjectSpace(RecRoomObject target, Quaternion rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Player target, Vector3 position, Vector3 rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(Player target, Vector3 position, Quaternion rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(RecRoomObject target, Vector3 position, Vector3 rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
        /// </summary>
        public static bool SetTransform(RecRoomObject target, Vector3 position, Quaternion rotation)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Vector3 rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Vector3 rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Quaternion rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(Player target, Vector3 position, Quaternion rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Vector3 rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Vector3 rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Quaternion rotation, Player referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Sets the transform (position and rotation) of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated.  
        /// </summary>
        public static bool SetTransformInReferenceObjectSpace(RecRoomObject target, Vector3 position, Quaternion rotation, RecRoomObject referenceObject)
        {
            return default;
        }

        /// <summary>
        /// Choose from a selection of SFX, for use with the Audio Player.
        /// </summary>
        public static Audio SFXConstant(SFXConstantData config)
        {
            return default;
        }

        public static bool SFXGetIsPlaying(SFX target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the volume of an SFX object.
        /// </summary>
        public static int SFXGetVolume(SFX target)
        {
            return default;
        }

        /// <summary>
        /// Plays a sound from an SFX object.
        /// </summary>
        public static void SFXPlay(SFX target)
        {
            return;
        }

        /// <summary>
        /// Sets the volume for an SFX object.
        /// </summary>
        public static void SFXSetVolume(SFX target, int value)
        {
            return;
        }

        /// <summary>
        /// Stops the sound currently playing from an SFX object.
        /// </summary>
        public static void SFXStop(SFX target)
        {
            return;
        }

        /// <summary>
        /// Gets whether the target player has their Share Camera spawned
        /// </summary>
        public static bool ShareCameraGetIsSpawned(Player player)
        {
            return default;
        }

        /// <summary>
        /// Shows a player a banner notification. Appearance can be customized in the config menu!
        /// </summary>
        public static void ShowBannerNotification(Player player, string title, string mainText, float duration)
        {
            return;
        }

        /// <summary>
        /// Prints the input notification to the given player&apos;s screen.
        /// </summary>
        public static void ShowNotification<T>(Player player, string value)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePromptR1(RoomKey inRoomPurchasable, Player player)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePromptR1(Consumable inRoomPurchasable, Player player)
        {
            return;
        }

        /// <summary>
        /// Show player a purchase prompt for a Room Key or Room Consumable. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
        /// </summary>
        public static void ShowPurchasePromptR1(RoomCurrency inRoomPurchasable, Player player)
        {
            return;
        }

        public static void ShowPurchasePromptR2(RoomOffer inRoomPurchasable, Player player)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(Player player, Reward reward, float duration)
        {
            return;
        }

        /// <summary>
        /// Shows a player a notification about a single reward or a list of up to 4 rewards. Appearance can be customized in the config menu! Triggering this chip multiple times will queue the notifications up in order of execution, and each will play subsequently after the previous duration is reached.
        /// </summary>
        public static void ShowRewardNotification(Player player, List<Reward> reward, float duration)
        {
            return;
        }

        /// <summary>
        /// Computes the sine of a number.
        /// </summary>
        public static float Sin(float value)
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
        /// Spherically interpolates between quaternions or Vector3s &quot;Start&quot; and &quot;End&quot;. Progress is 0 to 1. Also a rare, but refreshing beverage.
        /// </summary>
        public static Quaternion Slerp(Quaternion start, Quaternion end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Spherically interpolates between quaternions or Vector3s &quot;Start&quot; and &quot;End&quot;. Progress is 0 to 1. Also a rare, but refreshing beverage.
        /// </summary>
        public static Vector3 Slerp(Vector3 start, Vector3 end, float progress)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards a target, with velocity based damping
        /// </summary>
        public static (float Result, float ResultVelocity) SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards a target, with velocity based damping
        /// </summary>
        public static (Vector3 Result, Vector3 ResultVelocity) SmoothDamp(Vector3 current, Vector3 target, Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return default;
        }

        public static void SpawnerInternalStartSpawningR1(RecRoomObject spawner, int amountOfObjectsToSpawn, float timeBetweenSpawns, Vector3 spawnPosition)
        {
            return;
        }

        public static void SpawnerResetR1(RecRoomObject port1)
        {
            return;
        }

        /// <summary>
        /// Fires an invisible sphere of the specified Radius from the Start Position, in the Direction specified. Returns true if any object or player is hit within the target Max Distance. Otherwise, returns false. You can configure the chip itself to ignore players or objects specifically.
        /// </summary>
        public static (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Spherecast(Vector3 startPosition, float radius, Vector3 direction, float maxDistance, RaycastData config)
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
        public static void StopCameraShake(Player player)
        {
            return;
        }

        public static bool StorefrontGetIsEnabledR2(Storefront storefront)
        {
            return default;
        }

        public static List<RoomOffer> StorefrontGetOffersListR2(Storefront storefront)
        {
            return default;
        }

        public static void StorefrontSetIsEnabledR2(Storefront storefront, bool isEnabled)
        {
            return;
        }

        public static void StorefrontSetOffersListR2(Storefront storefront, List<RoomOffer> offersList)
        {
            return;
        }

        /// <summary>
        /// Concatenate a given series of strings in order, with an optional separator.
        /// </summary>
        public static string StringConcat(params string[] separator)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target string contains the input value.
        /// </summary>
        public static bool StringContains(string @string, string sequence)
        {
            return default;
        }

        /// <summary>
        /// Use this chip to combine multiple strings together into a single string output. The &quot;Format&quot; input is part of final string output and can include other string inputs by using this syntax: {input pin # starting at 0}. For example, a &quot;Format&quot; input with a default value of “Hello, {0}!” with a single additional input pin with the value &quot;World&quot; is fully output as &quot;Hello, World!&quot;. If you had another input pin you would use {1} to denote the 2nd pin. You can add more string inputs by configuring the chip and pressing &quot;Add Input&quot;.
        /// </summary>
        internal static string StringFormat(string format, string value)
        {
            return default;
        }

        /// <summary>
        /// Outputs the index where the substring starts in the target string.
        /// </summary>
        public static int StringIndexOf(string @string, string substring)
        {
            return default;
        }

        /// <summary>
        /// Outputs the length of a target string in UTF-16 characters.
        /// </summary>
        public static int StringLength(string @string)
        {
            return default;
        }

        /// <summary>
        /// Replaces all instances of pattern within string with replacement.
        /// </summary>
        public static string StringReplace(string @string, string pattern, string replacement)
        {
            return default;
        }

        /// <summary>
        /// Splits the target string at the input character.
        /// </summary>
        public static List<string> StringSplit(string @string, string divider)
        {
            return default;
        }

        /// <summary>
        /// Splits the target string in two at the input index.
        /// </summary>
        public static List<string> StringSplitAtIndex(string @string, int index)
        {
            return default;
        }

        /// <summary>
        /// Outputs a list of strings which split up by whitespace.
        /// </summary>
        public static List<string> StringSplitWhitespace(string @string)
        {
            return default;
        }

        /// <summary>
        /// Allows you to extract individual parts from a string. You can think of this like a list of characters.
        /// </summary>
        public static string StringSubstring(string @string, int index, int length)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target string in lower case.
        /// </summary>
        public static string StringToLower(string @string)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target string in upper case.
        /// </summary>
        public static string StringToUpper(string @string)
        {
            return default;
        }

        /// <summary>
        /// Outputs the string with leading and trailing whitespace removed.
        /// </summary>
        public static string StringTrim(string @string)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static string StringVariable(string port1, VariableData config)
        {
            return default;
        }

        public static Audio StudioAudioConstant(SFXConstantData config)
        {
            return default;
        }

        public static void StudioEventSender(StudioObject studioObject, string @event)
        {
            return;
        }

        public static void StudioEventSenderBool(StudioObject studioObject, string @event, bool value)
        {
            return;
        }

        public static void StudioEventSenderFloat(StudioObject studioObject, string @event, float value)
        {
            return;
        }

        public static void StudioEventSenderInt(StudioObject studioObject, string @event, int value)
        {
            return;
        }

        public static void StudioEventSenderString(StudioObject studioObject, string @event, string value)
        {
            return;
        }

        public static void StudioEventSenderStringBool(StudioObject studioObject, string @event, string value0, bool value1)
        {
            return;
        }

        public static void StudioEventSenderStringFloat(StudioObject studioObject, string @event, string value0, float value1)
        {
            return;
        }

        public static void StudioEventSenderStringInt(StudioObject studioObject, string @event, string value0, int value1)
        {
            return;
        }

        public static void StudioEventSenderStringString(StudioObject studioObject, string @event, string value0, string value1)
        {
            return;
        }

        internal static void StudioFunction(StudioObject studioObject, StudioFunctionData config)
        {
            return;
        }

        public static bool StudioObjectGetPropertyBool(StudioObject studioObject, string property)
        {
            return default;
        }

        public static Color StudioObjectGetPropertyColor(StudioObject studioObject, string property)
        {
            return default;
        }

        public static float StudioObjectGetPropertyFloat(StudioObject studioObject, string property)
        {
            return default;
        }

        public static int StudioObjectGetPropertyInt(StudioObject studioObject, string property)
        {
            return default;
        }

        public static Quaternion StudioObjectGetPropertyQuaternion(StudioObject studioObject, string property)
        {
            return default;
        }

        public static string StudioObjectGetPropertyString(StudioObject studioObject, string property)
        {
            return default;
        }

        public static Vector3 StudioObjectGetPropertyVector3(StudioObject studioObject, string property)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static int Subtract(params int[] value)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static float Subtract(params float[] value)
        {
            return default;
        }

        /// <summary>
        /// Takes one input value away from the other.
        /// </summary>
        public static Vector3 Subtract(params Vector3[] value)
        {
            return default;
        }

        /// <summary>
        /// Defines values for the room&apos;s sun.
        /// </summary>
        public static Sun SunConstant()
        {
            return default;
        }

        public static bool SwingHandleGetIsSwinging(SwingHandle target)
        {
            return default;
        }

        /// <summary>
        /// Computes the tangent of a number.
        /// </summary>
        public static float Tan(float value)
        {
            return default;
        }

        /// <summary>
        /// Returns the color of the target Text gadget.
        /// </summary>
        public static Color TextGetColor(Text target)
        {
            return default;
        }

        /// <summary>
        /// Outputs the visible text for a Text object.
        /// </summary>
        public static string TextGetText(Text target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color for a Text object.
        /// </summary>
        public static void TextSetColor(Text target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the color for a Text object.
        /// </summary>
        public static void TextSetColorIdDeprecated(Text target, int color)
        {
            return;
        }

        /// <summary>
        /// Sets the material for a Text object.
        /// </summary>
        public static void TextSetMaterial(Text target, int material)
        {
            return;
        }

        /// <summary>
        /// Set the visible text for a Text object.
        /// </summary>
        public static void TextSetText(Text target, string text)
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
        /// Gets the number of seconds since 1970. Uses server&apos;s clock. This will be synchronized between players. This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        /// </summary>
        public static int TimeGetUniversalSeconds()
        {
            return default;
        }

        /// <summary>
        /// Gets the UTC time. Uses server&apos;s clock. This will be synchronized between players.
        /// </summary>
        public static (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUniversalTime()
        {
            return default;
        }

        /// <summary>
        /// Gets the number of seconds since 1970. Uses local player&apos;s system clock. This is not synchronized between players! This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
        /// </summary>
        public static int TimeGetUnsyncedUniversalSeconds()
        {
            return default;
        }

        /// <summary>
        /// Gets the UTC time. Uses local player&apos;s system clock. This is not synchronized between players!
        /// </summary>
        public static (int Year, int Month, int Day, int Hour, int Minute, int Second) TimeGetUnsyncedUniversalTime()
        {
            return default;
        }

        /// <summary>
        /// Covert a player or an AI value into a Combatant value.
        /// </summary>
        public static Combatant ToCombatantR1(AI playerOrAI)
        {
            return default;
        }

        /// <summary>
        /// Covert a player or an AI value into a Combatant value.
        /// </summary>
        public static Combatant ToCombatantR1(Player playerOrAI)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the toggle button is pressed.
        /// </summary>
        public static bool ToggleButtonGetIsPressed(ToggleButton target)
        {
            return default;
        }

        /// <summary>
        /// Sets a Toggle Button state to pressed.
        /// </summary>
        public static void ToggleButtonSetIsPressed(ToggleButton target, bool value)
        {
            return;
        }

        /// <summary>
        /// Sets a Toggle Button state to pressed.
        /// </summary>
        public static void ToggleButtonSetIsPressedDeprecated(ToggleButton target, bool value)
        {
            return;
        }

        /// <summary>
        /// Casts a target specific object to a Rec Room Object.
        /// </summary>
        public static RecRoomObject ToRecRoomObject<T>(T target)
        {
            return default;
        }

        /// <summary>
        /// Converts the input value to the string type. Example: the integer input 10 would output &quot;10&quot; as a string. Helpful for debugging purposes.
        /// </summary>
        public static string ToString<T>(T value)
        {
            return default;
        }

        /// <summary>
        /// Converts the input value to the string type. Example: the integer input 10 would output &quot;10&quot; as a string. Helpful for debugging purposes.
        /// </summary>
        public static string ToStringDeprecated<T>(T value)
        {
            return default;
        }

        /// <summary>
        /// Get the active touch position from the local player&apos;s interaction
        /// </summary>
        public static (bool IsTouchActive, Vector3 TouchPosition, Vector3 WorldPosition) TouchpadComponentGetActiveTouch(Touchpad target)
        {
            return default;
        }

        /// <summary>
        /// Sets the interaction label (used by Screen players)
        /// </summary>
        public static string TouchpadComponentGetInteractionLabel(Touchpad target)
        {
            return default;
        }

        /// <summary>
        /// Sets if the Touchpad can be interacted with or output touch events
        /// </summary>
        public static bool TouchpadComponentGetIsEnabled(Touchpad target)
        {
            return default;
        }

        /// <summary>
        /// Gets the interaction label (used by Screen players)
        /// </summary>
        public static void TouchpadComponentSetInteractionLabel(Touchpad target, string label)
        {
            return;
        }

        /// <summary>
        /// Gets if the Touchpad can be interacted with or output touch events
        /// </summary>
        public static void TouchpadComponentSetIsEnabled(Touchpad target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Returns the color of the target Motion Trail object.
        /// </summary>
        public static Color TrailGetColor(MotionTrail target)
        {
            return default;
        }

        /// <summary>
        /// Outputs True if the target Motion Trail object is enabled.
        /// </summary>
        public static bool TrailGetEnabled(MotionTrail target)
        {
            return default;
        }

        /// <summary>
        /// Returns the lifetime of the target Motion Trail object.
        /// </summary>
        public static float TrailGetLifetime(MotionTrail target)
        {
            return default;
        }

        /// <summary>
        /// Returns the max opacity of the target Motion Trail object.
        /// </summary>
        public static float TrailGetOpacity(MotionTrail target)
        {
            return default;
        }

        /// <summary>
        /// Sets the color of the target Motion Trail object.
        /// </summary>
        public static void TrailSetColor(MotionTrail target, Color color)
        {
            return;
        }

        /// <summary>
        /// Sets the enabled state of the target Motion Trail object.
        /// </summary>
        public static void TrailSetEnabled(MotionTrail target, bool enabled)
        {
            return;
        }

        /// <summary>
        /// Sets the lifetime of the target Motion Trail object.
        /// </summary>
        public static void TrailSetLifetime(MotionTrail target, float lifetime)
        {
            return;
        }

        /// <summary>
        /// Sets the max opacity of the target Motion Trail object.
        /// </summary>
        public static void TrailSetOpacity(MotionTrail target, float maxOpacity)
        {
            return;
        }

        public static string TriggerHandleGetControlPromptDeprecated(TriggerHandle target)
        {
            return default;
        }

        /// <summary>
        /// True if the primary action button is down; otherwise, False.
        /// </summary>
        public static bool TriggerHandleGetPrimaryActionHeld(TriggerHandle target)
        {
            return default;
        }

        public static void TriggerHandleSetControlPromptDeprecated(TriggerHandle target, string controlPrompt)
        {
            return;
        }

        /// <summary>
        /// Gets the role name that is being used as a filter for a Trigger Volume.
        /// </summary>
        public static string TriggerVolumeGetFilterRoleR1(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
        /// </summary>
        public static int TriggerVolumeGetObjectCount(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the tags that are being used as the object filter for a Trigger Volume.
        /// </summary>
        public static List<string> TriggerVolumeGetObjectFilterTags(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
        /// </summary>
        public static List<RecRoomObject> TriggerVolumeGetObjects(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
        /// </summary>
        public static int TriggerVolumeGetPlayerCount(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets the tags that are being used as the player filter for a Trigger Volume.
        /// </summary>
        public static List<string> TriggerVolumeGetPlayerFilterTagsR2(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume&apos;s events!
        /// </summary>
        public static List<Player> TriggerVolumeGetPlayers(TriggerVolume target)
        {
            return default;
        }

        /// <summary>
        /// Sets the role name that is being used as a filter for a Trigger Volume.
        /// </summary>
        public static void TriggerVolumeSetFilterRoleR1(TriggerVolume target, string value)
        {
            return;
        }

        /// <summary>
        /// Sets the tags that are being used as the object filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
        /// </summary>
        public static void TriggerVolumeSetObjectFilterTags(TriggerVolume target, List<string> tags)
        {
            return;
        }

        /// <summary>
        /// Sets the tags that are being used as the player filter for a Trigger  Volume. A player is considered by the Trigger Volume, if they have any of the tags in this list.
        /// </summary>
        public static void TriggerVolumeSetPlayerFilterTagsR2(TriggerVolume target, List<string> tags)
        {
            return;
        }

        public static bool UnequipFromPlayer(Player player, RecRoomObject @object)
        {
            return default;
        }

        public static List<RecRoomObject> UnequipFromSlotsR1(Player player, bool dominantHand, bool offHand, bool leftHipHolster, bool rightHipHolster, bool shoulderHolster)
        {
            return default;
        }

        public static bool UnequipObject(RecRoomObject @object)
        {
            return default;
        }

        /// <summary>
        /// Returns the associated input of the compare value that matches the &apos;match&apos; input. Returns the default value if no match can be found.
        /// </summary>
        public static T ValueIntegerSwitch<T>(int match, T @default)
        {
            return default;
        }

        /// <summary>
        /// Returns the associated input of the compare value that matches the &apos;match&apos; input. Returns the default value if no match can be found.
        /// </summary>
        public static T ValueStringSwitch<T>(string match, T @default)
        {
            return default;
        }

        /// <summary>
        /// Clamps a vector&apos;s magnitude to a given max length.
        /// Vector is unchanged if magnitude is already less.
        /// Max length cannot be negative.
        /// </summary>
        public static Vector3 Vector3ClampMagnitude(Vector3 vector, float maxLength)
        {
            return default;
        }

        /// <summary>
        /// Gets the point on the plane that is closest to a given position
        /// </summary>
        public static Vector3 Vector3ClosestPointOnPlane(Vector3 position, Vector3 planePosition, Vector3 planeNormal)
        {
            return default;
        }

        /// <summary>
        /// Creates a new vector from X, Y, Z values.
        /// </summary>
        public static Vector3 Vector3Create(float x, float y, float z)
        {
            return default;
        }

        /// <summary>
        /// The cross product of two vectors results in a third vector which is perpendicular to the two input vectors.
        /// </summary>
        public static Vector3 Vector3Cross(Vector3 lhs, Vector3 rhs)
        {
            return default;
        }

        /// <summary>
        /// Computes the dot product. Commonly used to determine if the camera is facing a particular direction.
        /// </summary>
        public static float Vector3Dot(Vector3 lhs, Vector3 rhs)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a vector by -1 to get its inverse.
        /// </summary>
        public static Vector3 Vector3Inverse(Vector3 value)
        {
            return default;
        }

        public static Vector3 Vector3InverseTransform(Vector3 worldPoint, Vector3 worldOrigin, Quaternion worldOrientation)
        {
            return default;
        }

        /// <summary>
        /// Moves a vector towards target, not moving more than max delta distance at a time
        /// </summary>
        public static Vector3 Vector3MoveTowards(Vector3 current, Vector3 target, float maxDelta)
        {
            return default;
        }

        /// <summary>
        /// Outputs the target vector, but its magnitude is 1.
        /// </summary>
        public static Vector3 Vector3Normalize(Vector3 value)
        {
            return default;
        }

        /// <summary>
        /// Projects a vector onto a normal
        /// </summary>
        public static Vector3 Vector3Project(Vector3 vector, Vector3 onNormal)
        {
            return default;
        }

        /// <summary>
        /// Projects a vector onto a plane
        /// </summary>
        public static Vector3 Vector3ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        public static Vector3 Vector3Scale(Vector3 value, int scalar)
        {
            return default;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        public static Vector3 Vector3Scale(Vector3 value, float scalar)
        {
            return default;
        }

        /// <summary>
        /// Breaks the X, Y, and Z values out of the input vector.
        /// </summary>
        public static (float X, float Y, float Z) Vector3Split(Vector3 vector3)
        {
            return default;
        }

        public static Vector3 Vector3Transform(Vector3 localPoint, Vector3 worldOrigin, Quaternion worldOrientation)
        {
            return default;
        }

        /// <summary>
        /// Reads or writes a variable in the current scope based on the name.
        /// </summary>
        internal static Vector3 Vector3Variable(Vector3 port1, VariableData config)
        {
            return default;
        }

        /// <summary>
        /// Gets the direction and magnitude of the Vector Component.
        /// </summary>
        public static Vector3 VectorComponentGetVector(VectorComponent direction, float magnitude)
        {
            return default;
        }

        /// <summary>
        /// Outputs the length of the input vector.
        /// </summary>
        public static float VectorGetMagnitude(Vector3 vector3)
        {
            return default;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(Player target, float multiplier, Vector3 velocity, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAdd(RecRoomObject target, float multiplier, Vector3 velocity, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAddDeprecated(Player target, float speed, Vector3 direction, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityAddDeprecated(RecRoomObject target, float speed, Vector3 direction, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target&apos;s velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(Player target, float additionalSpeed, float speedMultiplier, Vector3 direction, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// The input target&apos;s velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocityReflect(RecRoomObject target, float additionalSpeed, float speedMultiplier, Vector3 direction, float maximumSpeed)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(Player target, float multiplier, Vector3 velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySet(RecRoomObject target, float multiplier, Vector3 velocity)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(Player target, float speed, Vector3 direction)
        {
            return;
        }

        /// <summary>
        /// Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
        /// </summary>
        public static void VelocitySetDeprecated(RecRoomObject target, float speed, Vector3 direction)
        {
            return;
        }

        /// <summary>
        /// Return whether target welcome mat is enabled (true) or disabled (false)
        /// </summary>
        public static bool WelcomeMatGetEnabled(WelcomeMat target)
        {
            return default;
        }

        /// <summary>
        /// Set target welcome mat to be enabled (true) or disabled (false)
        /// </summary>
        public static void WelcomeMatSetEnabled(WelcomeMat target, bool enabled)
        {
            return;
        }

        public static bool Xor(bool input)
        {
            return default;
        }
    }
}