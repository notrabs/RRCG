using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;
using RRCG;

namespace RRCGGenerated
{
    public class AIPortGen : AnyPort
    {
        public (StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange) GetLineOfSightParameters()
        {
            return CircuitBuilder.Singleton("RRCG_AI_GetLineOfSightParameters_" + Port.PortKey(), () => ChipBuilder.AIGetLineOfSightParameters((AIPort)this));
        }

        public CombatantPort GetTarget()
        {
            return CircuitBuilder.Singleton("RRCG_AI_GetTarget_" + Port.PortKey(), () => ChipBuilder.AIGetTarget((AIPort)this));
        }

        public BoolPort HasLineOfSightToTarget(AIPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTarget(CombatantPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTarget(RecRoomObjectPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTarget(PatrolPointPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTarget(PlayerPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTarget(Vector3Port Target)
        {
            return ChipBuilder.AIHasLineOfSightToTarget((AIPort)this, Target);
        }

        public void LookAt(AIPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAt(CombatantPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAt(RecRoomObjectPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAt(PatrolPointPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAt(PlayerPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAt(Vector3Port LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAt((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void PathTo(AIPort Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void PathTo(CombatantPort Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void PathTo(RecRoomObjectPort Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void PathTo(PatrolPointPort Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void PathTo(PlayerPort Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void PathTo(Vector3Port Target)
        {
            ChipBuilder.AIPathTo((AIPort)this, Target);
        }

        public void Rotate(FloatPort Rotation)
        {
            ChipBuilder.AIRotate((AIPort)this, Rotation);
        }

        public void Rotate(IntPort Rotation)
        {
            ChipBuilder.AIRotate((AIPort)this, Rotation);
        }

        public void Rotate(Vector3Port Rotation)
        {
            ChipBuilder.AIRotate((AIPort)this, Rotation);
        }

        public void SetLineOfSightParameters(StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange, BoolPort RequireLoSfortargeting)
        {
            ChipBuilder.AISetLineOfSightParameters((AIPort)this, VisionType, VisionRange, VisionConeAngle, HearingRange, RequireLoSfortargeting);
        }

        public void SetPathingSpeed(FloatPort Speed)
        {
            ChipBuilder.AISetPathingSpeed((AIPort)this, Speed);
        }

        public void SetPatrolPoint(PatrolPointPort PatrolPoint)
        {
            ChipBuilder.AISetPatrolPoint((AIPort)this, PatrolPoint);
        }

        public void SetTarget(CombatantPort Target)
        {
            ChipBuilder.AISetTarget((AIPort)this, Target);
        }

        public void StartCombatBehavior()
        {
            ChipBuilder.AIStartCombatBehavior((AIPort)this);
        }

        public void StopCombatBehavior()
        {
            ChipBuilder.AIStopCombatBehavior((AIPort)this);
        }

        public void StopLooking()
        {
            ChipBuilder.AIStopLooking((AIPort)this);
        }

        public AIPort Variable()
        {
            return ChipBuilder.AIVariable((AIPort)this);
        }

        public Vector3Port CombatantGetGroundPosition()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((AIPort)this));
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((AIPort)this));
        }

        public BoolPort CombatantGetIsAlive()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((AIPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((AIPort)this));
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantSetHealth(IntPort Health)
        {
            ChipBuilder.CombatantSetHealth((AIPort)this, Health);
        }

        public void CombatantSetMaxHealth(IntPort MaxHealth)
        {
            ChipBuilder.CombatantSetMaxHealth((AIPort)this, MaxHealth);
        }

        public FloatPort Distance(AIPort B)
        {
            return ChipBuilder.Distance((AIPort)this, B);
        }

        public FloatPort Distance(CombatantPort B)
        {
            return ChipBuilder.Distance((AIPort)this, B);
        }

        public FloatPort Distance(RecRoomObjectPort B)
        {
            return ChipBuilder.Distance((AIPort)this, B);
        }

        public FloatPort Distance(PlayerPort B)
        {
            return ChipBuilder.Distance((AIPort)this, B);
        }

        public FloatPort Distance(Vector3Port B)
        {
            return ChipBuilder.Distance((AIPort)this, B);
        }

        public FloatPort DistanceDeprecated(AIPort B)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, B);
        }

        public FloatPort DistanceDeprecated(CombatantPort B)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, B);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort B)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, B);
        }

        public FloatPort DistanceDeprecated(PlayerPort B)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, B);
        }

        public FloatPort DistanceDeprecated(Vector3Port B)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, B);
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_AI_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((AIPort)this));
        }

        public Vector3Port GetPositionDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_AI_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((AIPort)this));
        }

        public CombatantPort ToCombatant()
        {
            return CircuitBuilder.Singleton("RRCG_AI_ToCombatant_" + Port.PortKey(), () => ChipBuilder.ToCombatant((AIPort)this));
        }
    }

    public class AnalyticsPayloadPortGen : AnyPort
    {
    }

    public class AnimationControllerPortGen : AnyPort
    {
        public IntPort AnimationGetFrame()
        {
            return CircuitBuilder.Singleton("RRCG_AnimationController_AnimationGetFrame_" + Port.PortKey(), () => ChipBuilder.AnimationGetFrame((AnimationControllerPort)this));
        }

        public BoolPort AnimationGetIsPlaying()
        {
            return CircuitBuilder.Singleton("RRCG_AnimationController_AnimationGetIsPlaying_" + Port.PortKey(), () => ChipBuilder.AnimationGetIsPlaying((AnimationControllerPort)this));
        }

        public FloatPort AnimationGetSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_AnimationController_AnimationGetSpeed_" + Port.PortKey(), () => ChipBuilder.AnimationGetSpeed((AnimationControllerPort)this));
        }

        public FloatPort AnimationGetTimeStamp()
        {
            return CircuitBuilder.Singleton("RRCG_AnimationController_AnimationGetTimeStamp_" + Port.PortKey(), () => ChipBuilder.AnimationGetTimeStamp((AnimationControllerPort)this));
        }

        public void AnimationPause()
        {
            ChipBuilder.AnimationPause((AnimationControllerPort)this);
        }

        public void AnimationPlay()
        {
            ChipBuilder.AnimationPlay((AnimationControllerPort)this);
        }

        public void AnimationSetFrame(IntPort FrameNumber)
        {
            ChipBuilder.AnimationSetFrame((AnimationControllerPort)this, FrameNumber);
        }

        public void AnimationSetSpeed(FloatPort Speed)
        {
            ChipBuilder.AnimationSetSpeed((AnimationControllerPort)this, Speed);
        }

        public void AnimationSetTimeStamp(FloatPort TimeStamp)
        {
            ChipBuilder.AnimationSetTimeStamp((AnimationControllerPort)this, TimeStamp);
        }

        public void AnimationStop()
        {
            ChipBuilder.AnimationStop((AnimationControllerPort)this);
        }
    }

    public class AudioPortGen : AnyPort
    {
        public FloatPort GetLength()
        {
            return CircuitBuilder.Singleton("RRCG_Audio_GetLength_" + Port.PortKey(), () => ChipBuilder.AudioGetLength((AudioPort)this));
        }

        public void PlayAudioAtPosition(Vector3Port Position, FloatPort Volume, FloatPort PlaybackSpeed, BoolPort Is2D, PlayAudioAtPositionData config)
        {
            ChipBuilder.PlayAudioAtPosition((AudioPort)this, Position, Volume, PlaybackSpeed, Is2D, config);
        }
    }

    public class AudioPlayerPortGen : AnyPort
    {
        public AudioPort GetAudio()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetAudio_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetAudio((AudioPlayerPort)this));
        }

        public FloatPort GetMaxRolloffDistance()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetMaxRolloffDistance_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetMaxRolloffDistance((AudioPlayerPort)this));
        }

        public BoolPort GetPlaying()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetPlaying_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetPlaying((AudioPlayerPort)this));
        }

        public FloatPort GetSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetSpeed_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetSpeed((AudioPlayerPort)this));
        }

        public FloatPort GetTimeStamp()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetTimeStamp_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetTimeStamp((AudioPlayerPort)this));
        }

        public FloatPort GetVolume()
        {
            return CircuitBuilder.Singleton("RRCG_AudioPlayer_GetVolume_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetVolume((AudioPlayerPort)this));
        }

        public void Pause()
        {
            ChipBuilder.AudioPlayerPause((AudioPlayerPort)this);
        }

        public void Play(AudioPort Audio)
        {
            ChipBuilder.AudioPlayerPlay((AudioPlayerPort)this, Audio);
        }

        public void SetMaxRolloffDistance(FloatPort MaxRolloffDistance)
        {
            ChipBuilder.AudioPlayerSetMaxRolloffDistance((AudioPlayerPort)this, MaxRolloffDistance);
        }

        public void SetSpeed(FloatPort Speed)
        {
            ChipBuilder.AudioPlayerSetSpeed((AudioPlayerPort)this, Speed);
        }

        public void SetTimeStamp(FloatPort TimeStamp)
        {
            ChipBuilder.AudioPlayerSetTimeStamp((AudioPlayerPort)this, TimeStamp);
        }

        public void SetVolume(FloatPort Volume)
        {
            ChipBuilder.AudioPlayerSetVolume((AudioPlayerPort)this, Volume);
        }

        public void Stop()
        {
            ChipBuilder.AudioPlayerStop((AudioPlayerPort)this);
        }
    }

    public class BackgroundObjectsPortGen : AnyPort
    {
        public BoolPort RoomBackgroundObjectsModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomBackgroundObjectsModify((BackgroundObjectsPort)this, BlendFinished);
        }
    }

    public class BeaconPortGen : AnyPort
    {
        public ColorPort GetColor()
        {
            return CircuitBuilder.Singleton("RRCG_Beacon_GetColor_" + Port.PortKey(), () => ChipBuilder.BeaconGetColor((BeaconPort)this));
        }

        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Beacon_GetEnabled_" + Port.PortKey(), () => ChipBuilder.BeaconGetEnabled((BeaconPort)this));
        }

        public FloatPort GetHeight()
        {
            return CircuitBuilder.Singleton("RRCG_Beacon_GetHeight_" + Port.PortKey(), () => ChipBuilder.BeaconGetHeight((BeaconPort)this));
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.BeaconSetColor((BeaconPort)this, Color);
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.BeaconSetEnabled((BeaconPort)this, Enabled);
        }

        public void SetHeight(FloatPort Height)
        {
            ChipBuilder.BeaconSetHeight((BeaconPort)this, Height);
        }
    }

    public class ButtonPortGen : AnyPort
    {
        public BoolPort GetIsPressed()
        {
            return CircuitBuilder.Singleton("RRCG_Button_GetIsPressed_" + Port.PortKey(), () => ChipBuilder.ButtonGetIsPressed((ButtonPort)this));
        }

        public StringPort GetText()
        {
            return CircuitBuilder.Singleton("RRCG_Button_GetText_" + Port.PortKey(), () => ChipBuilder.ButtonGetText((ButtonPort)this));
        }

        public void SetText(StringPort Text)
        {
            ChipBuilder.ButtonSetText((ButtonPort)this, Text);
        }
    }

    public class CollisionDataPortGen : AnyPort
    {
        public FloatPort GetDistance()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionData_GetDistance_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetDistance((CollisionDataPort)this));
        }

        public Vector3Port GetNormal()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionData_GetNormal_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetNormal((CollisionDataPort)this));
        }

        public RecRoomObjectPort GetObject()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionData_GetObject_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetObject((CollisionDataPort)this));
        }

        public PlayerPort GetPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionData_GetPlayer_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPlayer((CollisionDataPort)this));
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionData_GetPosition_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPosition((CollisionDataPort)this));
        }
    }

    public class CollisionDetectionVolumePortGen : AnyPort
    {
        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_CollisionDetectionVolume_GetEnabled_" + Port.PortKey(), () => ChipBuilder.CollisionDetectionVolumeGetEnabled((CollisionDetectionVolumePort)this));
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.CollisionDetectionVolumeSetEnabled((CollisionDetectionVolumePort)this, Enabled);
        }
    }

    public class CombatantPortGen : AnyPort
    {
        public Vector3Port GetGroundPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((CombatantPort)this));
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) GetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((CombatantPort)this));
        }

        public BoolPort GetIsAlive()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((CombatantPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) GetVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((CombatantPort)this));
        }

        public void ReceiveDamage(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void ReceiveDamage(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void ReceiveDamage(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void SetHealth(IntPort Health)
        {
            ChipBuilder.CombatantSetHealth((CombatantPort)this, Health);
        }

        public void SetMaxHealth(IntPort MaxHealth)
        {
            ChipBuilder.CombatantSetMaxHealth((CombatantPort)this, MaxHealth);
        }

        public (BoolPort IsPlayer, PlayerPort Player, AIPort AI) Split()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_Split_" + Port.PortKey(), () => ChipBuilder.CombatantSplit((CombatantPort)this));
        }

        public CombatantPort Variable()
        {
            return ChipBuilder.CombatantVariable((CombatantPort)this);
        }

        public FloatPort Distance(AIPort B)
        {
            return ChipBuilder.Distance((CombatantPort)this, B);
        }

        public FloatPort Distance(CombatantPort B)
        {
            return ChipBuilder.Distance((CombatantPort)this, B);
        }

        public FloatPort Distance(RecRoomObjectPort B)
        {
            return ChipBuilder.Distance((CombatantPort)this, B);
        }

        public FloatPort Distance(PlayerPort B)
        {
            return ChipBuilder.Distance((CombatantPort)this, B);
        }

        public FloatPort Distance(Vector3Port B)
        {
            return ChipBuilder.Distance((CombatantPort)this, B);
        }

        public FloatPort DistanceDeprecated(AIPort B)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, B);
        }

        public FloatPort DistanceDeprecated(CombatantPort B)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, B);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort B)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, B);
        }

        public FloatPort DistanceDeprecated(PlayerPort B)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, B);
        }

        public FloatPort DistanceDeprecated(Vector3Port B)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, B);
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((CombatantPort)this));
        }

        public Vector3Port GetPositionDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((CombatantPort)this));
        }
    }

    public class ConsumablePortGen : AnyPort
    {
        public BoolPort AwardConsumable(PlayerPort Player, IntPort Quantity, AlternativeExec<BoolPort> OnAwardConsumableComplete)
        {
            return ChipBuilder.AwardConsumable((ConsumablePort)this, Player, Quantity, OnAwardConsumableComplete);
        }

        public void Activate()
        {
            ChipBuilder.ConsumableActivate((ConsumablePort)this);
        }

        public void Deactivate()
        {
            ChipBuilder.ConsumableDeactivate((ConsumablePort)this);
        }

        public void ShowPurchasePrompt(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePrompt((ConsumablePort)this, Player);
        }
    }

    public class CostumePortGen : AnyPort
    {
        public void Equip(PlayerPort Player)
        {
            ChipBuilder.CostumeEquip((CostumePort)this, Player);
        }

        public PlayerPort GetWearer()
        {
            return CircuitBuilder.Singleton("RRCG_Costume_GetWearer_" + Port.PortKey(), () => ChipBuilder.CostumeGetWearer((CostumePort)this));
        }

        public PlayerPort Unequip()
        {
            return ChipBuilder.CostumeUnequip((CostumePort)this);
        }
    }

    public class DestinationRoomPortGen : AnyPort
    {
        public DestinationRoomPort Variable()
        {
            return ChipBuilder.DestinationRoomVariable((DestinationRoomPort)this);
        }
    }

    public class DialogueUIPortGen : AnyPort
    {
        public (StringPort BodyText, BoolPort IsInteractive) GetDialogueText()
        {
            return CircuitBuilder.Singleton("RRCG_DialogueUI_GetDialogueText_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetDialogueText((DialogueUIPort)this));
        }

        public BoolPort GetIsEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_DialogueUI_GetIsEnabled_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetIsEnabled((DialogueUIPort)this));
        }

        public BoolPort GetTitleIsEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleIsEnabled_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetTitleIsEnabled((DialogueUIPort)this));
        }

        public StringPort GetTitleText()
        {
            return CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleText_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetTitleText((DialogueUIPort)this));
        }

        public void SetButtonState(BoolPort Button1Enabled, StringPort Button1Text, BoolPort Button2Enabled, StringPort Button2Text, BoolPort Button3Enabled, StringPort Button3Text, BoolPort Button4Enabled, StringPort Button4Text)
        {
            ChipBuilder.DialogueUISetButtonState((DialogueUIPort)this, Button1Enabled, Button1Text, Button2Enabled, Button2Text, Button3Enabled, Button3Text, Button4Enabled, Button4Text);
        }

        public void SetDialogueText(StringPort BodyText, BoolPort IsInteractive)
        {
            ChipBuilder.DialogueUISetDialogueText((DialogueUIPort)this, BodyText, IsInteractive);
        }

        public void SetIsEnabled(BoolPort IsEnabled)
        {
            ChipBuilder.DialogueUISetIsEnabled((DialogueUIPort)this, IsEnabled);
        }

        public void SetTitleIsEnabled(BoolPort IsEnabled)
        {
            ChipBuilder.DialogueUISetTitleIsEnabled((DialogueUIPort)this, IsEnabled);
        }

        public void SetTitleText(StringPort TitleText)
        {
            ChipBuilder.DialogueUISetTitleText((DialogueUIPort)this, TitleText);
        }
    }

    public class DiePortGen : AnyPort
    {
        public PlayerPort DiceGetPlayerRolled()
        {
            return CircuitBuilder.Singleton("RRCG_Die_DiceGetPlayerRolled_" + Port.PortKey(), () => ChipBuilder.DiceGetPlayerRolled((DiePort)this));
        }

        public IntPort DiceGetResult()
        {
            return CircuitBuilder.Singleton("RRCG_Die_DiceGetResult_" + Port.PortKey(), () => ChipBuilder.DiceGetResult((DiePort)this));
        }

        public BoolPort DiceGetRollFinished()
        {
            return CircuitBuilder.Singleton("RRCG_Die_DiceGetRollFinished_" + Port.PortKey(), () => ChipBuilder.DiceGetRollFinished((DiePort)this));
        }
    }

    public class EmitterPortGen : AnyPort
    {
        public BoolPort GetLooping()
        {
            return CircuitBuilder.Singleton("RRCG_Emitter_GetLooping_" + Port.PortKey(), () => ChipBuilder.EmitterGetLooping((EmitterPort)this));
        }

        public BoolPort GetPlaying()
        {
            return CircuitBuilder.Singleton("RRCG_Emitter_GetPlaying_" + Port.PortKey(), () => ChipBuilder.EmitterGetPlaying((EmitterPort)this));
        }

        public FloatPort GetSize()
        {
            return CircuitBuilder.Singleton("RRCG_Emitter_GetSize_" + Port.PortKey(), () => ChipBuilder.EmitterGetSize((EmitterPort)this));
        }

        public FloatPort GetSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Emitter_GetSpeed_" + Port.PortKey(), () => ChipBuilder.EmitterGetSpeed((EmitterPort)this));
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.EmitterSetColor((EmitterPort)this, Color);
        }

        public void SetColorId(IntPort Value)
        {
            ChipBuilder.EmitterSetColorId((EmitterPort)this, Value);
        }

        public void SetLooping(BoolPort Value)
        {
            ChipBuilder.EmitterSetLooping((EmitterPort)this, Value);
        }

        public void SetSize(FloatPort Value)
        {
            ChipBuilder.EmitterSetSize((EmitterPort)this, Value);
        }

        public void SetSpeed(FloatPort Value)
        {
            ChipBuilder.EmitterSetSpeed((EmitterPort)this, Value);
        }

        public void Start()
        {
            ChipBuilder.EmitterStart((EmitterPort)this);
        }

        public void Stop()
        {
            ChipBuilder.EmitterStop((EmitterPort)this);
        }
    }

    public class EquipmentSlotPortGen : AnyPort
    {
    }

    public class ExplosionEmitterPortGen : AnyPort
    {
        public void Explode()
        {
            ChipBuilder.ExplosionEmitterExplode((ExplosionEmitterPort)this);
        }

        public IntPort GetDamage()
        {
            return CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetDamage_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetDamage((ExplosionEmitterPort)this));
        }

        public ColorPort GetExplosionColor()
        {
            return CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionColor_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionColor((ExplosionEmitterPort)this));
        }

        public FloatPort GetExplosionRadius()
        {
            return CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionRadius_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionRadius((ExplosionEmitterPort)this));
        }

        public PlayerPort GetFiringPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetFiringPlayer_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetFiringPlayer((ExplosionEmitterPort)this));
        }

        public void SetDamage(IntPort Damage)
        {
            ChipBuilder.ExplosionEmitterSetDamage((ExplosionEmitterPort)this, Damage);
        }

        public void SetExplosionColor(ColorPort Color)
        {
            ChipBuilder.ExplosionEmitterSetExplosionColor((ExplosionEmitterPort)this, Color);
        }

        public void SetExplosionRadius(FloatPort Radius)
        {
            ChipBuilder.ExplosionEmitterSetExplosionRadius((ExplosionEmitterPort)this, Radius);
        }

        public void SetFiringPlayer(PlayerPort Player)
        {
            ChipBuilder.ExplosionEmitterSetFiringPlayer((ExplosionEmitterPort)this, Player);
        }
    }

    public class FogPortGen : AnyPort
    {
        public BoolPort RoomFogModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomFogModify((FogPort)this, BlendFinished);
        }
    }

    public class GiftDropShopItemPortGen : AnyPort
    {
    }

    public class GrabberPortGen : AnyPort
    {
        public (BoolPort HasHeldObject, RecRoomObjectPort HeldObject) GetHeldObject()
        {
            return CircuitBuilder.Singleton("RRCG_Grabber_GetHeldObject_" + Port.PortKey(), () => ChipBuilder.GrabberGetHeldObject((GrabberPort)this));
        }

        public BoolPort GrabObject(RecRoomObjectPort Object, BoolPort StealfromPlayer, BoolPort SnaptoGrabber)
        {
            return ChipBuilder.GrabberGrabObject((GrabberPort)this, Object, StealfromPlayer, SnaptoGrabber);
        }

        public RecRoomObjectPort Release()
        {
            return ChipBuilder.GrabberRelease((GrabberPort)this);
        }

        public void SetPlayerCanStealFromGrabber(BoolPort Enabled)
        {
            ChipBuilder.GrabberSetPlayerCanStealFromGrabber((GrabberPort)this, Enabled);
        }
    }

    public class GroundVehiclePortGen : AnyPort
    {
        public void AddBoostFuel(IntPort Boostamount)
        {
            ChipBuilder.GroundVehicleAddBoostFuel((GroundVehiclePort)this, Boostamount);
        }

        public void ApplyBoost(AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleApplyBoost((GroundVehiclePort)this, Failure);
        }

        public IntPort GetBoostFuel()
        {
            return CircuitBuilder.Singleton("RRCG_GroundVehicle_GetBoostFuel_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetBoostFuel((GroundVehiclePort)this));
        }

        public BoolPort GetDrivingEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_GroundVehicle_GetDrivingEnabled_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetDrivingEnabled((GroundVehiclePort)this));
        }

        public FloatPort GetEngineTorqueMultiplier()
        {
            return CircuitBuilder.Singleton("RRCG_GroundVehicle_GetEngineTorqueMultiplier_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetEngineTorqueMultiplier((GroundVehiclePort)this));
        }

        public PlayerPort GetSeatedPlayer(IntPort Seatindex)
        {
            return ChipBuilder.GroundVehicleGetSeatedPlayer((GroundVehiclePort)this, Seatindex);
        }

        public FloatPort GetWheelFrictionMultiplier()
        {
            return CircuitBuilder.Singleton("RRCG_GroundVehicle_GetWheelFrictionMultiplier_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetWheelFrictionMultiplier((GroundVehiclePort)this));
        }

        public void SetDrivingEnabled(BoolPort Enabled)
        {
            ChipBuilder.GroundVehicleSetDrivingEnabled((GroundVehiclePort)this, Enabled);
        }

        public void SetEngineTorqueMultiplier(FloatPort Torquemultiplier)
        {
            ChipBuilder.GroundVehicleSetEngineTorqueMultiplier((GroundVehiclePort)this, Torquemultiplier);
        }

        public void SetSeatedPlayer(IntPort Seatindex, PlayerPort Player, AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleSetSeatedPlayer((GroundVehiclePort)this, Seatindex, Player, Failure);
        }

        public void SetWheelFrictionMultiplier(FloatPort Frictionmultiplier)
        {
            ChipBuilder.GroundVehicleSetWheelFrictionMultiplier((GroundVehiclePort)this, Frictionmultiplier);
        }

        public void UnseatPlayer(PlayerPort Player, AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleUnseatPlayer((GroundVehiclePort)this, Player, Failure);
        }

        public void UnseatPlayerFromSeat(IntPort Seatindex, AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleUnseatPlayerFromSeat((GroundVehiclePort)this, Seatindex, Failure);
        }
    }

    public class GunHandlePortGen : AnyPort
    {
        public void AddAutoAimRole(StringPort Role)
        {
            ChipBuilder.GunHandleAddAutoAimRole((GunHandlePort)this, Role);
        }

        public void ApplyRecoil(FloatPort AngleX, FloatPort AngleY, FloatPort Duration, FloatPort ReturnDuration)
        {
            ChipBuilder.GunHandleApplyRecoil((GunHandlePort)this, AngleX, AngleY, Duration, ReturnDuration);
        }

        public IntPort GetCurrentAmmo()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetCurrentAmmo_" + Port.PortKey(), () => ChipBuilder.GunHandleGetCurrentAmmo((GunHandlePort)this));
        }

        public Vector3Port GetFiringDirection(RecRoomObjectPort Source)
        {
            return ChipBuilder.GunHandleGetFiringDirection((GunHandlePort)this, Source);
        }

        public BoolPort GetIsReloading()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetIsReloading_" + Port.PortKey(), () => ChipBuilder.GunHandleGetIsReloading((GunHandlePort)this));
        }

        public IntPort GetMaxAmmo()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetMaxAmmo_" + Port.PortKey(), () => ChipBuilder.GunHandleGetMaxAmmo((GunHandlePort)this));
        }

        public FloatPort GetRateOfFire()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetRateOfFire_" + Port.PortKey(), () => ChipBuilder.GunHandleGetRateOfFire((GunHandlePort)this));
        }

        public FloatPort GetReloadDuration()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetReloadDuration_" + Port.PortKey(), () => ChipBuilder.GunHandleGetReloadDuration((GunHandlePort)this));
        }

        public BoolPort GetSupportsReload()
        {
            return CircuitBuilder.Singleton("RRCG_GunHandle_GetSupportsReload_" + Port.PortKey(), () => ChipBuilder.GunHandleGetSupportsReload((GunHandlePort)this));
        }

        public void RemoveAutoAimRole(StringPort Role)
        {
            ChipBuilder.GunHandleRemoveAutoAimRole((GunHandlePort)this, Role);
        }

        public void SetADSEnabled(BoolPort Enabled)
        {
            ChipBuilder.GunHandleSetADSEnabled((GunHandlePort)this, Enabled);
        }

        public void SetAutoAimRoles(ListPort<StringPort> Roles)
        {
            ChipBuilder.GunHandleSetAutoAimRoles((GunHandlePort)this, Roles);
        }

        public void SetCurrentAmmo(IntPort Ammo)
        {
            ChipBuilder.GunHandleSetCurrentAmmo((GunHandlePort)this, Ammo);
        }

        public void SetMaxAmmo(IntPort MaxAmmo)
        {
            ChipBuilder.GunHandleSetMaxAmmo((GunHandlePort)this, MaxAmmo);
        }

        public void SetRateOfFire(FloatPort RateOfFire)
        {
            ChipBuilder.GunHandleSetRateOfFire((GunHandlePort)this, RateOfFire);
        }

        public void SetReloadDuration(FloatPort ReloadDuration)
        {
            ChipBuilder.GunHandleSetReloadDuration((GunHandlePort)this, ReloadDuration);
        }

        public void SetSupportsReload(BoolPort CanReload)
        {
            ChipBuilder.GunHandleSetSupportsReload((GunHandlePort)this, CanReload);
        }

        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((GunHandlePort)this, Duration, Intensity);
        }
    }

    public class HolotarProjectorPortGen : AnyPort
    {
    }

    public class HUDConstantPortGen : AnyPort
    {
        public ColorPort GetGameHUDElementColor()
        {
            return CircuitBuilder.Singleton("RRCG_HUDConstant_GetGameHUDElementColor_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementColor((HUDConstantPort)this));
        }

        public StringPort GetGameHUDElementLabel()
        {
            return CircuitBuilder.Singleton("RRCG_HUDConstant_GetGameHUDElementLabel_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementLabel((HUDConstantPort)this));
        }

        public IntPort GetGameHUDElementMaxValue()
        {
            return CircuitBuilder.Singleton("RRCG_HUDConstant_GetGameHUDElementMaxValue_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementMaxValue((HUDConstantPort)this));
        }

        public IntPort GetGameHUDElementValue()
        {
            return CircuitBuilder.Singleton("RRCG_HUDConstant_GetGameHUDElementValue_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementValue((HUDConstantPort)this));
        }

        public void SetGameHUDElementColor(ColorPort Color)
        {
            ChipBuilder.SetGameHUDElementColor((HUDConstantPort)this, Color);
        }

        public void SetGameHUDElementLabel(StringPort Label)
        {
            ChipBuilder.SetGameHUDElementLabel((HUDConstantPort)this, Label);
        }

        public void SetGameHUDElementLabelEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetGameHUDElementLabelEnabled((HUDConstantPort)this, Enabled);
        }

        public void SetGameHUDElementMaxValue(IntPort Value)
        {
            ChipBuilder.SetGameHUDElementMaxValue((HUDConstantPort)this, Value);
        }

        public void SetGameHUDElementValue(IntPort Value)
        {
            ChipBuilder.SetGameHUDElementValue((HUDConstantPort)this, Value);
        }

        public void SetGameHUDElementValueTextEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetGameHUDElementValueTextEnabled((HUDConstantPort)this, Enabled);
        }

        public void SetHUDElementEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetHUDElementEnabled((HUDConstantPort)this, Enabled);
        }
    }

    public class HUDElementPortGen : AnyPort
    {
        public void GameHUDElementSetAllValues()
        {
            ChipBuilder.GameHUDElementSetAllValues((HUDElementPort)this);
        }
    }

    public class InteractionVolumePortGen : AnyPort
    {
        public FloatPort GetHoldTime()
        {
            return CircuitBuilder.Singleton("RRCG_InteractionVolume_GetHoldTime_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetHoldTime((InteractionVolumePort)this));
        }

        public StringPort GetInteractionPrompt()
        {
            return CircuitBuilder.Singleton("RRCG_InteractionVolume_GetInteractionPrompt_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetInteractionPrompt((InteractionVolumePort)this));
        }

        public BoolPort GetIsLocked()
        {
            return CircuitBuilder.Singleton("RRCG_InteractionVolume_GetIsLocked_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetIsLocked((InteractionVolumePort)this));
        }

        public FloatPort GetNormalizedHoldProgress()
        {
            return CircuitBuilder.Singleton("RRCG_InteractionVolume_GetNormalizedHoldProgress_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetNormalizedHoldProgress((InteractionVolumePort)this));
        }

        public void SetHoldTime(FloatPort HoldTime)
        {
            ChipBuilder.InteractionVolumeSetHoldTime((InteractionVolumePort)this, HoldTime);
        }

        public void SetInteractionPrompt(StringPort InteractionPrompt)
        {
            ChipBuilder.InteractionVolumeSetInteractionPrompt((InteractionVolumePort)this, InteractionPrompt);
        }

        public void SetLocked(BoolPort Locked)
        {
            ChipBuilder.InteractionVolumeSetLocked((InteractionVolumePort)this, Locked);
        }

        public void SetNormalizedHoldProgress(FloatPort NormalizedHoldProgress)
        {
            ChipBuilder.InteractionVolumeSetNormalizedHoldProgress((InteractionVolumePort)this, NormalizedHoldProgress);
        }
    }

    public class InventoryItemPortGen : AnyPort
    {
        public (BoolPort Success, IntPort TotalCount) Add(PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            return ChipBuilder.InventoryItemAdd((InventoryItemPort)this, Player, Quantity, Complete);
        }

        public IntPort GetCount(PlayerPort Player, AlternativeExec<IntPort> Complete)
        {
            return ChipBuilder.InventoryItemGetCount((InventoryItemPort)this, Player, Complete);
        }

        public (StringPort Name, StringPort Description, BoolPort SupportsUseAction) GetDefinition()
        {
            return CircuitBuilder.Singleton("RRCG_InventoryItem_GetDefinition_" + Port.PortKey(), () => ChipBuilder.InventoryItemGetDefinition((InventoryItemPort)this));
        }

        public (BoolPort Success, IntPort TotalCount) Remove(PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            return ChipBuilder.InventoryItemRemove((InventoryItemPort)this, Player, Quantity, Complete);
        }

        public void Use()
        {
            ChipBuilder.InventoryItemUse((InventoryItemPort)this);
        }
    }

    public class InvisibleCollisionPortGen : AnyPort
    {
        public BoolPort GetBlocksPlayers()
        {
            return CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetBlocksPlayers_" + Port.PortKey(), () => ChipBuilder.InvisibleCollisionGetBlocksPlayers((InvisibleCollisionPort)this));
        }

        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetEnabled_" + Port.PortKey(), () => ChipBuilder.InvisibleCollisionGetEnabled((InvisibleCollisionPort)this));
        }

        public void SetBlocksPlayers(BoolPort Enabled)
        {
            ChipBuilder.InvisibleCollisionSetBlocksPlayers((InvisibleCollisionPort)this, Enabled);
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.InvisibleCollisionSetEnabled((InvisibleCollisionPort)this, Enabled);
        }
    }

    public class LaserPointerPortGen : AnyPort
    {
        public ColorPort GetColor()
        {
            return CircuitBuilder.Singleton("RRCG_LaserPointer_GetColor_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetColor((LaserPointerPort)this));
        }

        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_LaserPointer_GetEnabled_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetEnabled((LaserPointerPort)this));
        }

        public FloatPort GetLength()
        {
            return CircuitBuilder.Singleton("RRCG_LaserPointer_GetLength_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetLength((LaserPointerPort)this));
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.LaserPointerSetColor((LaserPointerPort)this, Color);
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.LaserPointerSetEnabled((LaserPointerPort)this, Enabled);
        }

        public void SetLength(FloatPort Length)
        {
            ChipBuilder.LaserPointerSetLength((LaserPointerPort)this, Length);
        }
    }

    public class LightPortGen : AnyPort
    {
        public FloatPort GetAngle()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetAngle_" + Port.PortKey(), () => ChipBuilder.LightGetAngle((LightPort)this));
        }

        public ColorPort GetColor()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetColor_" + Port.PortKey(), () => ChipBuilder.LightGetColor((LightPort)this));
        }

        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetEnabled_" + Port.PortKey(), () => ChipBuilder.LightGetEnabled((LightPort)this));
        }

        public FloatPort GetIntensity()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetIntensity_" + Port.PortKey(), () => ChipBuilder.LightGetIntensity((LightPort)this));
        }

        public FloatPort GetRange()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetRange_" + Port.PortKey(), () => ChipBuilder.LightGetRange((LightPort)this));
        }

        public FloatPort GetSoftness()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetSoftness_" + Port.PortKey(), () => ChipBuilder.LightGetSoftness((LightPort)this));
        }

        public FloatPort GetSpecularContribution()
        {
            return CircuitBuilder.Singleton("RRCG_Light_GetSpecularContribution_" + Port.PortKey(), () => ChipBuilder.LightGetSpecularContribution((LightPort)this));
        }

        public void SetAngle(FloatPort Angle)
        {
            ChipBuilder.LightSetAngle((LightPort)this, Angle);
        }

        public void SetAngleInt(IntPort Angle)
        {
            ChipBuilder.LightSetAngleInt((LightPort)this, Angle);
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.LightSetColor((LightPort)this, Color);
        }

        public void SetColorId(IntPort Color)
        {
            ChipBuilder.LightSetColorId((LightPort)this, Color);
        }

        public void SetIntensity(FloatPort Intensity)
        {
            ChipBuilder.LightSetIntensity((LightPort)this, Intensity);
        }

        public void SetIntensityInt(IntPort Intensity)
        {
            ChipBuilder.LightSetIntensityInt((LightPort)this, Intensity);
        }

        public void SetRange(FloatPort Range)
        {
            ChipBuilder.LightSetRange((LightPort)this, Range);
        }

        public void SetRangeInt(IntPort Range)
        {
            ChipBuilder.LightSetRangeInt((LightPort)this, Range);
        }

        public void SetSoftness(FloatPort Softness)
        {
            ChipBuilder.LightSetSoftness((LightPort)this, Softness);
        }

        public void SetSpecularContribution(FloatPort SpecularContribution)
        {
            ChipBuilder.LightSetSpecularContribution((LightPort)this, SpecularContribution);
        }

        public void TurnOff()
        {
            ChipBuilder.LightTurnOff((LightPort)this);
        }

        public void TurnOn()
        {
            ChipBuilder.LightTurnOn((LightPort)this);
        }
    }

    public class MeleeZonePortGen : AnyPort
    {
    }

    public class MotionTrailPortGen : AnyPort
    {
        public ColorPort TrailGetColor()
        {
            return CircuitBuilder.Singleton("RRCG_MotionTrail_TrailGetColor_" + Port.PortKey(), () => ChipBuilder.TrailGetColor((MotionTrailPort)this));
        }

        public BoolPort TrailGetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_MotionTrail_TrailGetEnabled_" + Port.PortKey(), () => ChipBuilder.TrailGetEnabled((MotionTrailPort)this));
        }

        public FloatPort TrailGetLifetime()
        {
            return CircuitBuilder.Singleton("RRCG_MotionTrail_TrailGetLifetime_" + Port.PortKey(), () => ChipBuilder.TrailGetLifetime((MotionTrailPort)this));
        }

        public FloatPort TrailGetOpacity()
        {
            return CircuitBuilder.Singleton("RRCG_MotionTrail_TrailGetOpacity_" + Port.PortKey(), () => ChipBuilder.TrailGetOpacity((MotionTrailPort)this));
        }

        public void TrailSetColor(ColorPort Color)
        {
            ChipBuilder.TrailSetColor((MotionTrailPort)this, Color);
        }

        public void TrailSetEnabled(BoolPort Enabled)
        {
            ChipBuilder.TrailSetEnabled((MotionTrailPort)this, Enabled);
        }

        public void TrailSetLifetime(FloatPort Lifetime)
        {
            ChipBuilder.TrailSetLifetime((MotionTrailPort)this, Lifetime);
        }

        public void TrailSetOpacity(FloatPort MaxOpacity)
        {
            ChipBuilder.TrailSetOpacity((MotionTrailPort)this, MaxOpacity);
        }
    }

    public class ObjectiveMarkerPortGen : AnyPort
    {
        public void AttachToPlayerOrObject(PlayerPort PlayerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, PlayerOrObject);
        }

        public void AttachToPlayerOrObject(RecRoomObjectPort PlayerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, PlayerOrObject);
        }

        public ColorPort GetColor()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetColor_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetColor((ObjectiveMarkerPort)this));
        }

        public FloatPort GetCurrentDistance()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetCurrentDistance_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetCurrentDistance((ObjectiveMarkerPort)this));
        }

        public BoolPort GetDistanceEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetDistanceEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetDistanceEnabled((ObjectiveMarkerPort)this));
        }

        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetEnabled((ObjectiveMarkerPort)this));
        }

        public FloatPort GetFadeThreshold()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetFadeThreshold_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetFadeThreshold((ObjectiveMarkerPort)this));
        }

        public StringPort GetLabel()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabel_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabel((ObjectiveMarkerPort)this));
        }

        public BoolPort GetLabelEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabelEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabelEnabled((ObjectiveMarkerPort)this));
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetPosition_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetPosition((ObjectiveMarkerPort)this));
        }

        public RecRoomObjectPort GetTargetObject()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetObject_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetObject((ObjectiveMarkerPort)this));
        }

        public PlayerPort GetTargetPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetPlayer_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetPlayer((ObjectiveMarkerPort)this));
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.ObjectiveMarkerSetColor((ObjectiveMarkerPort)this, Color);
        }

        public void SetDistanceEnabled(BoolPort Enabled)
        {
            ChipBuilder.ObjectiveMarkerSetDistanceEnabled((ObjectiveMarkerPort)this, Enabled);
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.ObjectiveMarkerSetEnabled((ObjectiveMarkerPort)this, Enabled);
        }

        public void SetFadeThreshold(FloatPort Proximity)
        {
            ChipBuilder.ObjectiveMarkerSetFadeThreshold((ObjectiveMarkerPort)this, Proximity);
        }

        public void SetLabel(StringPort Label)
        {
            ChipBuilder.ObjectiveMarkerSetLabel((ObjectiveMarkerPort)this, Label);
        }

        public void SetLabelEnabled(BoolPort Enabled)
        {
            ChipBuilder.ObjectiveMarkerSetLabelEnabled((ObjectiveMarkerPort)this, Enabled);
        }

        public void SetPosition(Vector3Port Position)
        {
            ChipBuilder.ObjectiveMarkerSetPosition((ObjectiveMarkerPort)this, Position);
        }
    }

    public class PatrolPointPortGen : AnyPort
    {
    }

    public class PistonPortGen : AnyPort
    {
        public FloatPort GetAcceleration()
        {
            return CircuitBuilder.Singleton("RRCG_Piston_GetAcceleration_" + Port.PortKey(), () => ChipBuilder.PistonGetAcceleration((PistonPort)this));
        }

        public FloatPort GetDistance()
        {
            return CircuitBuilder.Singleton("RRCG_Piston_GetDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetDistance((PistonPort)this));
        }

        public FloatPort GetMaxDistance()
        {
            return CircuitBuilder.Singleton("RRCG_Piston_GetMaxDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetMaxDistance((PistonPort)this));
        }

        public FloatPort GetSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Piston_GetSpeed_" + Port.PortKey(), () => ChipBuilder.PistonGetSpeed((PistonPort)this));
        }

        public FloatPort GetTargetDistance()
        {
            return CircuitBuilder.Singleton("RRCG_Piston_GetTargetDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetTargetDistance((PistonPort)this));
        }

        public void SetAcceleration(FloatPort Value)
        {
            ChipBuilder.PistonSetAcceleration((PistonPort)this, Value);
        }

        public void SetDistance(FloatPort Value)
        {
            ChipBuilder.PistonSetDistance((PistonPort)this, Value);
        }

        public void SetMaxDistance(FloatPort Value)
        {
            ChipBuilder.PistonSetMaxDistance((PistonPort)this, Value);
        }

        public void SetSpeed(FloatPort Value)
        {
            ChipBuilder.PistonSetSpeed((PistonPort)this, Value);
        }

        public void SetTargetDistance(FloatPort Value)
        {
            ChipBuilder.PistonSetTargetDistance((PistonPort)this, Value);
        }
    }

    public class PlayerPortGen : AnyPort
    {
        public void AddTag(StringPort Tag)
        {
            ChipBuilder.AddTag((PlayerPort)this, Tag);
        }

        public void AddTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.AddTags((PlayerPort)this, Tags);
        }

        public (BoolPort Success, IntPort TotalBalance) AwardCurrency(IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrency((PlayerPort)this, Amount, OnAwardCurrencyComplete);
        }

        public void ClearPlayerVignette()
        {
            ChipBuilder.ClearPlayerVignette((PlayerPort)this);
        }

        public void ClearPlayerWorldUI()
        {
            ChipBuilder.ClearPlayerWorldUI((PlayerPort)this);
        }

        public Vector3Port CombatantGetGroundPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((PlayerPort)this));
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((PlayerPort)this));
        }

        public BoolPort CombatantGetIsAlive()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((PlayerPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((PlayerPort)this));
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamage(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamage((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantSetHealth(IntPort Health)
        {
            ChipBuilder.CombatantSetHealth((PlayerPort)this, Health);
        }

        public void CombatantSetMaxHealth(IntPort MaxHealth)
        {
            ChipBuilder.CombatantSetMaxHealth((PlayerPort)this, MaxHealth);
        }

        public FloatPort Distance(AIPort B)
        {
            return ChipBuilder.Distance((PlayerPort)this, B);
        }

        public FloatPort Distance(CombatantPort B)
        {
            return ChipBuilder.Distance((PlayerPort)this, B);
        }

        public FloatPort Distance(RecRoomObjectPort B)
        {
            return ChipBuilder.Distance((PlayerPort)this, B);
        }

        public FloatPort Distance(PlayerPort B)
        {
            return ChipBuilder.Distance((PlayerPort)this, B);
        }

        public FloatPort Distance(Vector3Port B)
        {
            return ChipBuilder.Distance((PlayerPort)this, B);
        }

        public FloatPort DistanceDeprecated(AIPort B)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, B);
        }

        public FloatPort DistanceDeprecated(CombatantPort B)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, B);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort B)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, B);
        }

        public FloatPort DistanceDeprecated(PlayerPort B)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, B);
        }

        public FloatPort DistanceDeprecated(Vector3Port B)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, B);
        }

        public BoolPort EquipObjectToDominantHand(RecRoomObjectPort ObjectToEquip, BoolPort ForceEquip, BoolPort Steal)
        {
            return ChipBuilder.EquipObjectToDominantHand((PlayerPort)this, ObjectToEquip, ForceEquip, Steal);
        }

        public BoolPort EquipObjectToOffHand(RecRoomObjectPort ObjectToEquip, BoolPort ForceEquip, BoolPort Steal)
        {
            return ChipBuilder.EquipObjectToOffHand((PlayerPort)this, ObjectToEquip, ForceEquip, Steal);
        }

        public (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<RecRoomObjectPort> Targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, Targets);
        }

        public (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<PlayerPort> Targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, Targets);
        }

        public (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<Vector3Port> Targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, Targets);
        }

        public (BoolPort Success, IntPort TotalBalance) GetCurrencyBalance(AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnGetBalanceComplete)
        {
            return ChipBuilder.GetCurrencyBalance((PlayerPort)this, OnGetBalanceComplete);
        }

        public (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<RecRoomObjectPort> Targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, Targets);
        }

        public (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<PlayerPort> Targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, Targets);
        }

        public (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<Vector3Port> Targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, Targets);
        }

        public StringPort GetFirstTag()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetFirstTag_" + Port.PortKey(), () => ChipBuilder.GetFirstTag((PlayerPort)this));
        }

        public Vector3Port GetForwardVector()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetForwardVector_" + Port.PortKey(), () => ChipBuilder.GetForwardVector((PlayerPort)this));
        }

        public Vector3Port GetForwardVectorDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetForwardVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((PlayerPort)this));
        }

        public ListPort<PlayerPort> GetPartyOfPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetPartyOfPlayer_" + Port.PortKey(), () => ChipBuilder.GetPartyOfPlayer((PlayerPort)this));
        }

        public StringPort GetAccountName()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetAccountName_" + Port.PortKey(), () => ChipBuilder.GetPlayerAccountName((PlayerPort)this));
        }

        public StringPort GetSeasonLeagueName()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetSeasonLeagueName_" + Port.PortKey(), () => ChipBuilder.GetPlayerSeasonLeagueName((PlayerPort)this));
        }

        public BoolPort GetWorldUIEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUIEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIEnabled((PlayerPort)this));
        }

        public ColorPort GetWorldUIPrimaryBarColor()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarColor((PlayerPort)this));
        }

        public BoolPort GetWorldUIPrimaryBarEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this));
        }

        public IntPort GetWorldUIPrimaryBarMaxValue()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarMaxValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this));
        }

        public IntPort GetWorldUIPrimaryBarValue()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarValue((PlayerPort)this));
        }

        public ColorPort GetWorldUISecondaryBarColor()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarColor((PlayerPort)this));
        }

        public BoolPort GetWorldUISecondaryBarEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarEnabled((PlayerPort)this));
        }

        public IntPort GetWorldUISecondaryBarMaxValue()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarMaxValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this));
        }

        public IntPort GetWorldUISecondaryBarValue()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarValue((PlayerPort)this));
        }

        public ColorPort GetWorldUITextColor()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextColor((PlayerPort)this));
        }

        public BoolPort GetWorldUITextEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextEnabled((PlayerPort)this));
        }

        public StringPort GetWorldUITextValue()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextValue((PlayerPort)this));
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((PlayerPort)this));
        }

        public Vector3Port GetPositionDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((PlayerPort)this));
        }

        public QuaternionPort GetRotation()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetRotation_" + Port.PortKey(), () => ChipBuilder.GetRotation((PlayerPort)this));
        }

        public QuaternionPort GetRotationDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetRotationDeprecated_" + Port.PortKey(), () => ChipBuilder.GetRotationDeprecated((PlayerPort)this));
        }

        public ListPort<StringPort> GetTags()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetTags_" + Port.PortKey(), () => ChipBuilder.GetTags((PlayerPort)this));
        }

        public Vector3Port GetUpVector()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetUpVector_" + Port.PortKey(), () => ChipBuilder.GetUpVector((PlayerPort)this));
        }

        public Vector3Port GetUpVectorDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetUpVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetUpVectorDeprecated((PlayerPort)this));
        }

        public Vector3Port GetVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetVelocity_" + Port.PortKey(), () => ChipBuilder.GetVelocity((PlayerPort)this));
        }

        public Vector3Port GetVelocityDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetVelocityDeprecated_" + Port.PortKey(), () => ChipBuilder.GetVelocityDeprecated((PlayerPort)this));
        }

        public void GoToRoom(DestinationRoomPort Destination)
        {
            ChipBuilder.GoToRoom((PlayerPort)this, Destination);
        }

        public BoolPort GrantReward(RewardPort Reward, AlternativeExec<BoolPort> OnAwardComplete)
        {
            return ChipBuilder.GrantReward((PlayerPort)this, Reward, OnAwardComplete);
        }

        public BoolPort HasTag(StringPort Tag)
        {
            return ChipBuilder.HasTag((PlayerPort)this, Tag);
        }

        public BoolPort HolsterObject(RecRoomObjectPort ObjectToHolster, BoolPort ForceHolster, BoolPort Steal)
        {
            return ChipBuilder.HolsterObject((PlayerPort)this, ObjectToHolster, ForceHolster, Steal);
        }

        public void IfHasTag(StringPort Tag, AlternativeExec DoesNotHaveTag)
        {
            ChipBuilder.IfHasTag((PlayerPort)this, Tag, DoesNotHaveTag);
        }

        public void IfLocalPlayerShouldRun(AlternativeExec ShouldNotRun)
        {
            ChipBuilder.IfLocalPlayerShouldRun((PlayerPort)this, ShouldNotRun);
        }

        public void IfPlayerHasRole(StringPort Role, AlternativeExec DoesNotHaveRole)
        {
            ChipBuilder.IfPlayerHasRole((PlayerPort)this, Role, DoesNotHaveRole);
        }

        public void IfPlayerIsLocal(AlternativeExec IsNotLocal)
        {
            ChipBuilder.IfPlayerIsLocal((PlayerPort)this, IsNotLocal);
        }

        public void IfPlayerIsValid(AlternativeExec IsNotValid)
        {
            ChipBuilder.IfPlayerIsValid((PlayerPort)this, IsNotValid);
        }

        public void IfPlayerIsValidAndLocal(AlternativeExec IsNotValid, AlternativeExec IsValidAndNotLocal)
        {
            ChipBuilder.IfPlayerIsValidAndLocal((PlayerPort)this, IsNotValid, IsValidAndNotLocal);
        }

        public IntPort LeaderboardGetPlayerStat(IntPort Channel, AlternativeExec<IntPort> OnGetStatComplete)
        {
            return ChipBuilder.LeaderboardGetPlayerStat((PlayerPort)this, Channel, OnGetStatComplete);
        }

        public void LocalPlayerDisableInteractionWithTargetPlayer()
        {
            ChipBuilder.LocalPlayerDisableInteractionWithTargetPlayer((PlayerPort)this);
        }

        public void LocalPlayerEnableInteractionWithTargetPlayer(FloatPort RequiredHoldDuration, StringPort Prompt)
        {
            ChipBuilder.LocalPlayerEnableInteractionWithTargetPlayer((PlayerPort)this, RequiredHoldDuration, Prompt);
        }

        public void LocalPlayerSetPlayerNametagVisibility(BoolPort Enabled)
        {
            ChipBuilder.LocalPlayerSetPlayerNametagVisibility((PlayerPort)this, Enabled);
        }

        public void AddRole(StringPort Value)
        {
            ChipBuilder.PlayerAddRole((PlayerPort)this, Value);
        }

        public BoolPort AwardXP(IntPort Amount, AlternativeExec<BoolPort> OnAwardComplete)
        {
            return ChipBuilder.PlayerAwardXP((PlayerPort)this, Amount, OnAwardComplete);
        }

        public QuaternionPort BodyOrientation()
        {
            return CircuitBuilder.Singleton("RRCG_Player_BodyOrientation_" + Port.PortKey(), () => ChipBuilder.PlayerBodyOrientation((PlayerPort)this));
        }

        public Vector3Port BodyPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_BodyPosition_" + Port.PortKey(), () => ChipBuilder.PlayerBodyPosition((PlayerPort)this));
        }

        public void ClearCurrentSubtitle()
        {
            ChipBuilder.PlayerClearCurrentSubtitle((PlayerPort)this);
        }

        public BoolPort EquipInventoryItem(InventoryItemPort InventoryItem, EquipmentSlotPort InventoryEquipmentSlot, AlternativeExec<BoolPort> OnEquipComplete)
        {
            return ChipBuilder.PlayerEquipInventoryItem((PlayerPort)this, InventoryItem, InventoryEquipmentSlot, OnEquipComplete);
        }

        public BoolPort GetCanTeleport()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetCanTeleport_" + Port.PortKey(), () => ChipBuilder.PlayerGetCanTeleport((PlayerPort)this));
        }

        public CostumePort GetCostume()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetCostume_" + Port.PortKey(), () => ChipBuilder.PlayerGetCostume((PlayerPort)this));
        }

        public BoolPort GetCrouchInputEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetCrouchInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetCrouchInputEnabled((PlayerPort)this));
        }

        public BoolPort GetDominantHandIsRight()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetDominantHandIsRight_" + Port.PortKey(), () => ChipBuilder.PlayerGetDominantHandIsRight((PlayerPort)this));
        }

        public BoolPort GetEquipmentSlotIsEnabled(EquipmentSlotPort EquipmentSlot)
        {
            return ChipBuilder.PlayerGetEquipmentSlotIsEnabled((PlayerPort)this, EquipmentSlot);
        }

        public (RecRoomObjectPort DominantHandObject, RecRoomObjectPort OffHandObject, RecRoomObjectPort LeftHipHolsterObject, RecRoomObjectPort RightHipHolsterObject, RecRoomObjectPort ShoulderHolsterObject) GetEquippedObjects()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetEquippedObjects_" + Port.PortKey(), () => ChipBuilder.PlayerGetEquippedObjects((PlayerPort)this));
        }

        public BoolPort GetForceManualSprint()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetForceManualSprint_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceManualSprint((PlayerPort)this));
        }

        public BoolPort GetForceVirtualHeightMode()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetForceVirtualHeightMode_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceVirtualHeightMode((PlayerPort)this));
        }

        public BoolPort GetForceVRWalk()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetForceVRWalk_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceVRWalk((PlayerPort)this));
        }

        public BoolPort GetIsAuthorityOf(RecRoomObjectPort Object)
        {
            return ChipBuilder.PlayerGetIsAuthorityOf((PlayerPort)this, Object);
        }

        public BoolPort GetIsClambering()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsClambering_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsClambering((PlayerPort)this));
        }

        public BoolPort GetIsCrouching()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsCrouching_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsCrouching((PlayerPort)this));
        }

        public (BoolPort IsGrounded, FloatPort TimeSinceLastGrounded, RecRoomObjectPort SurfaceObject, Vector3Port SurfaceNormal) GetIsGrounded()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsGrounded_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsGrounded((PlayerPort)this));
        }

        public (BoolPort IsJumpingOrFalling, RecRoomObjectPort ContactSurface) GetIsJumpingOrFalling()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsJumpingOrFalling_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsJumpingOrFalling((PlayerPort)this));
        }

        public BoolPort GetIsLocal()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsLocal_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsLocal((PlayerPort)this));
        }

        public BoolPort GetIsProne()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsProne_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsProne((PlayerPort)this));
        }

        public BoolPort GetIsRoomOwner()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsRoomOwner_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsRoomOwner((PlayerPort)this));
        }

        public BoolPort GetIsSliding()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsSliding_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsSliding((PlayerPort)this));
        }

        public BoolPort GetIsSprinting()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetIsSprinting_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsSprinting((PlayerPort)this));
        }

        public FloatPort GetJumpHeight()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetJumpHeight_" + Port.PortKey(), () => ChipBuilder.PlayerGetJumpHeight((PlayerPort)this));
        }

        public BoolPort GetJumpInputEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetJumpInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetJumpInputEnabled((PlayerPort)this));
        }

        public FloatPort GetNormalizedSteeringSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetNormalizedSteeringSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetNormalizedSteeringSpeed((PlayerPort)this));
        }

        public IntPort GetRadioChannel()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetRadioChannel_" + Port.PortKey(), () => ChipBuilder.PlayerGetRadioChannel((PlayerPort)this));
        }

        public IntPort GetRoomIndex()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetRoomIndex_" + Port.PortKey(), () => ChipBuilder.PlayerGetRoomIndex((PlayerPort)this));
        }

        public IntPort GetRoomLevel()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetRoomLevel_" + Port.PortKey(), () => ChipBuilder.PlayerGetRoomLevel((PlayerPort)this));
        }

        public SeatPort GetSeat()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetSeat_" + Port.PortKey(), () => ChipBuilder.PlayerGetSeat((PlayerPort)this));
        }

        public BoolPort GetSprintInputEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetSprintInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetSprintInputEnabled((PlayerPort)this));
        }

        public FloatPort GetSprintSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetSprintSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetSprintSpeed((PlayerPort)this));
        }

        public Vector3Port GetSteeringDirection()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetSteeringDirection_" + Port.PortKey(), () => ChipBuilder.PlayerGetSteeringDirection((PlayerPort)this));
        }

        public FloatPort GetTeleportDelay()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetTeleportDelay_" + Port.PortKey(), () => ChipBuilder.PlayerGetTeleportDelay((PlayerPort)this));
        }

        public FloatPort GetTeleportDistance()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetTeleportDistance_" + Port.PortKey(), () => ChipBuilder.PlayerGetTeleportDistance((PlayerPort)this));
        }

        public IntPort GetTimeZone()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetTimeZone_" + Port.PortKey(), () => ChipBuilder.PlayerGetTimeZone((PlayerPort)this));
        }

        public FloatPort GetVoiceRolloffDistance()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetVoiceRolloffDistance_" + Port.PortKey(), () => ChipBuilder.PlayerGetVoiceRolloffDistance((PlayerPort)this));
        }

        public BoolPort GetWalkInputEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWalkInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetWalkInputEnabled((PlayerPort)this));
        }

        public FloatPort GetWalkSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetWalkSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetWalkSpeed((PlayerPort)this));
        }

        public IntPort GetXP()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetXP_" + Port.PortKey(), () => ChipBuilder.PlayerGetXP((PlayerPort)this));
        }

        public BoolPort HasRole(StringPort Value)
        {
            return ChipBuilder.PlayerHasRole((PlayerPort)this, Value);
        }

        public Vector3Port HeadForwardVector()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadForwardVector_" + Port.PortKey(), () => ChipBuilder.PlayerHeadForwardVector((PlayerPort)this));
        }

        public FloatPort HeadHeight()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadHeight_" + Port.PortKey(), () => ChipBuilder.PlayerHeadHeight((PlayerPort)this));
        }

        public QuaternionPort HeadOrientation()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadOrientation_" + Port.PortKey(), () => ChipBuilder.PlayerHeadOrientation((PlayerPort)this));
        }

        public Vector3Port HeadPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadPosition_" + Port.PortKey(), () => ChipBuilder.PlayerHeadPosition((PlayerPort)this));
        }

        public Vector3Port HeadUpVector()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadUpVector_" + Port.PortKey(), () => ChipBuilder.PlayerHeadUpVector((PlayerPort)this));
        }

        public Vector3Port HeadVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Player_HeadVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerHeadVelocity((PlayerPort)this));
        }

        public BoolPort IsHoldingMakerPen()
        {
            return CircuitBuilder.Singleton("RRCG_Player_IsHoldingMakerPen_" + Port.PortKey(), () => ChipBuilder.PlayerIsHoldingMakerPen((PlayerPort)this));
        }

        public BoolPort IsInParty()
        {
            return CircuitBuilder.Singleton("RRCG_Player_IsInParty_" + Port.PortKey(), () => ChipBuilder.PlayerIsInParty((PlayerPort)this));
        }

        public BoolPort IsRoomHost()
        {
            return CircuitBuilder.Singleton("RRCG_Player_IsRoomHost_" + Port.PortKey(), () => ChipBuilder.PlayerIsRoomHost((PlayerPort)this));
        }

        public BoolPort IsRoomMod()
        {
            return CircuitBuilder.Singleton("RRCG_Player_IsRoomMod_" + Port.PortKey(), () => ChipBuilder.PlayerIsRoomMod((PlayerPort)this));
        }

        public Vector3Port LeftHandFingerDirection()
        {
            return CircuitBuilder.Singleton("RRCG_Player_LeftHandFingerDirection_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_LeftHandPosition_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandPosition((PlayerPort)this));
        }

        public QuaternionPort LeftHandRotation()
        {
            return CircuitBuilder.Singleton("RRCG_Player_LeftHandRotation_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandRotation((PlayerPort)this));
        }

        public Vector3Port LeftHandThumbDirection()
        {
            return CircuitBuilder.Singleton("RRCG_Player_LeftHandThumbDirection_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Player_LeftHandVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandVelocity((PlayerPort)this));
        }

        public BoolPort OwnsInventoryItem(InventoryItemPort InventoryItem, AlternativeExec<BoolPort> Complete)
        {
            return ChipBuilder.PlayerOwnsInventoryItem((PlayerPort)this, InventoryItem, Complete);
        }

        public BoolPort OwnsRoomKey(RoomKeyPort RoomKey, AlternativeExec<BoolPort> OnPlayerOwnsRoomKeyComplete)
        {
            return ChipBuilder.PlayerOwnsRoomKey((PlayerPort)this, RoomKey, OnPlayerOwnsRoomKeyComplete);
        }

        public (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex) PromptMultipleChoice(StringPort PromptTitle, StringPort PromptBody, ListPort<StringPort> AnswerChoices, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex)> OnPromptComplete)
        {
            return ChipBuilder.PlayerPromptMultipleChoice((PlayerPort)this, PromptTitle, PromptBody, AnswerChoices, OnPromptComplete);
        }

        public void RemoveRole(StringPort Value)
        {
            ChipBuilder.PlayerRemoveRole((PlayerPort)this, Value);
        }

        public void ResetNameColor()
        {
            ChipBuilder.PlayerResetNameColor((PlayerPort)this);
        }

        public Vector3Port RightHandFingerDirection()
        {
            return CircuitBuilder.Singleton("RRCG_Player_RightHandFingerDirection_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port RightHandPosition()
        {
            return CircuitBuilder.Singleton("RRCG_Player_RightHandPosition_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandPosition((PlayerPort)this));
        }

        public QuaternionPort RightHandRotation()
        {
            return CircuitBuilder.Singleton("RRCG_Player_RightHandRotation_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandRotation((PlayerPort)this));
        }

        public Vector3Port RightHandThumbDirection()
        {
            return CircuitBuilder.Singleton("RRCG_Player_RightHandThumbDirection_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port RightHandVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_Player_RightHandVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandVelocity((PlayerPort)this));
        }

        public void SetCanTeleport(BoolPort CanTeleport)
        {
            ChipBuilder.PlayerSetCanTeleport((PlayerPort)this, CanTeleport);
        }

        public void SetCrouchInputEnabled(BoolPort CrouchInputEnabled)
        {
            ChipBuilder.PlayerSetCrouchInputEnabled((PlayerPort)this, CrouchInputEnabled);
        }

        public void SetEquipmentSlotIsEnabled(EquipmentSlotPort EquipmentSlot, BoolPort IsEnabled)
        {
            ChipBuilder.PlayerSetEquipmentSlotIsEnabled((PlayerPort)this, EquipmentSlot, IsEnabled);
        }

        public void SetForceManualSprint(BoolPort ForceManualSprint)
        {
            ChipBuilder.PlayerSetForceManualSprint((PlayerPort)this, ForceManualSprint);
        }

        public void SetForceVirtualHeightMode(BoolPort ForceVirtualHeightMode)
        {
            ChipBuilder.PlayerSetForceVirtualHeightMode((PlayerPort)this, ForceVirtualHeightMode);
        }

        public void SetForceVRWalk(BoolPort ForceVRWalk)
        {
            ChipBuilder.PlayerSetForceVRWalk((PlayerPort)this, ForceVRWalk);
        }

        public void SetJumpHeight(FloatPort JumpHeight)
        {
            ChipBuilder.PlayerSetJumpHeight((PlayerPort)this, JumpHeight);
        }

        public void SetJumpInputEnabled(BoolPort JumpInputEnabled)
        {
            ChipBuilder.PlayerSetJumpInputEnabled((PlayerPort)this, JumpInputEnabled);
        }

        public void SetNameColor(ColorPort Color)
        {
            ChipBuilder.PlayerSetNameColor((PlayerPort)this, Color);
        }

        public void SetRadioChannel(IntPort Channel)
        {
            ChipBuilder.PlayerSetRadioChannel((PlayerPort)this, Channel);
        }

        public void SetSprintInputEnabled(BoolPort SprintInputEnabled)
        {
            ChipBuilder.PlayerSetSprintInputEnabled((PlayerPort)this, SprintInputEnabled);
        }

        public void SetSprintSpeed(FloatPort SprintSpeed)
        {
            ChipBuilder.PlayerSetSprintSpeed((PlayerPort)this, SprintSpeed);
        }

        public void SetTeleportDelay(FloatPort TeleportDelay)
        {
            ChipBuilder.PlayerSetTeleportDelay((PlayerPort)this, TeleportDelay);
        }

        public void SetTeleportDistance(FloatPort TeleportDistance)
        {
            ChipBuilder.PlayerSetTeleportDistance((PlayerPort)this, TeleportDistance);
        }

        public void SetVoiceRolloffDistance(FloatPort VoiceRolloffDistance)
        {
            ChipBuilder.PlayerSetVoiceRolloffDistance((PlayerPort)this, VoiceRolloffDistance);
        }

        public void SetWalkInputEnabled(BoolPort WalkInputEnabled)
        {
            ChipBuilder.PlayerSetWalkInputEnabled((PlayerPort)this, WalkInputEnabled);
        }

        public void SetWalkSpeed(FloatPort WalkSpeed)
        {
            ChipBuilder.PlayerSetWalkSpeed((PlayerPort)this, WalkSpeed);
        }

        public void ShowSubtitle(StringPort Subtitle, FloatPort Duration, IntPort Priority)
        {
            ChipBuilder.PlayerShowSubtitle((PlayerPort)this, Subtitle, Duration, Priority);
        }

        public (BoolPort Result, IntPort SecondsUntilEnabled) SubscribesToRoomOwner()
        {
            return CircuitBuilder.Singleton("RRCG_Player_SubscribesToRoomOwner_" + Port.PortKey(), () => ChipBuilder.PlayerSubscribesToRoomOwner((PlayerPort)this));
        }

        public BoolPort UnequipFromSlot(EquipmentSlotPort EquipmentSlot, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipFromSlot((PlayerPort)this, EquipmentSlot, OnUnequipComplete);
        }

        public BoolPort UnequipInventoryItem(InventoryItemPort InventoryItem, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipInventoryItem((PlayerPort)this, InventoryItem, OnUnequipComplete);
        }

        public PlayerPort Variable()
        {
            return ChipBuilder.PlayerVariable((PlayerPort)this);
        }

        public PlayerPort VariableDeprecated()
        {
            return ChipBuilder.PlayerVariableDeprecated((PlayerPort)this);
        }

        public void RemovePlayerFromRadioChannel()
        {
            ChipBuilder.RemovePlayerFromRadioChannel((PlayerPort)this);
        }

        public void RemoveTag(StringPort Tag)
        {
            ChipBuilder.RemoveTag((PlayerPort)this, Tag);
        }

        public void RemoveTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.RemoveTags((PlayerPort)this, Tags);
        }

        public void RequestVelocitySetOverDuration(FloatPort Multiplier, Vector3Port Velocity, FloatPort Duration)
        {
            ChipBuilder.RequestVelocitySetOverDuration((PlayerPort)this, Multiplier, Velocity, Duration);
        }

        public void ResetPlayerWorldUI()
        {
            ChipBuilder.ResetPlayerWorldUI((PlayerPort)this);
        }

        public BoolPort Respawn(Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            return ChipBuilder.Respawn((PlayerPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects);
        }

        public BoolPort Respawn(Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            return ChipBuilder.Respawn((PlayerPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects);
        }

        public void RespawnDeprecated(Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            ChipBuilder.RespawnDeprecated((PlayerPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects, Failed);
        }

        public void RespawnDeprecated(Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            ChipBuilder.RespawnDeprecated((PlayerPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects, Failed);
        }

        public void RespawnPointRespawnPlayer(BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            ChipBuilder.RespawnPointRespawnPlayer((PlayerPort)this, ClearVelocity, UseRezEffects);
        }

        public void SetCameraShake(FloatPort Intensity, FloatPort Duration)
        {
            ChipBuilder.SetCameraShake((PlayerPort)this, Intensity, Duration);
        }

        public void SetVignette(FloatPort Time, ColorPort Color, FloatPort Intensity)
        {
            ChipBuilder.SetPlayerVignette((PlayerPort)this, Time, Color, Intensity);
        }

        public void SetWorldUIPrimaryBarColor(ColorPort Color)
        {
            ChipBuilder.SetPlayerWorldUIPrimaryBarColor((PlayerPort)this, Color);
        }

        public void SetWorldUIPrimaryBarEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this, Enabled);
        }

        public void SetWorldUIPrimaryBarMaxValue(IntPort Value)
        {
            ChipBuilder.SetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this, Value);
        }

        public void SetWorldUIPrimaryBarValue(IntPort Value)
        {
            ChipBuilder.SetPlayerWorldUIPrimaryBarValue((PlayerPort)this, Value);
        }

        public void SetWorldUISecondaryBarColor(ColorPort Color)
        {
            ChipBuilder.SetPlayerWorldUISecondaryBarColor((PlayerPort)this, Color);
        }

        public void SetWorldUISecondaryBarEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetPlayerWorldUISecondaryBarEnabled((PlayerPort)this, Enabled);
        }

        public void SetWorldUISecondaryBarMaxValue(IntPort Value)
        {
            ChipBuilder.SetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this, Value);
        }

        public void SetWorldUISecondaryBarValue(IntPort Value)
        {
            ChipBuilder.SetPlayerWorldUISecondaryBarValue((PlayerPort)this, Value);
        }

        public void SetWorldUITextColor(ColorPort Color)
        {
            ChipBuilder.SetPlayerWorldUITextColor((PlayerPort)this, Color);
        }

        public void SetWorldUITextEnabled(BoolPort Enabled)
        {
            ChipBuilder.SetPlayerWorldUITextEnabled((PlayerPort)this, Enabled);
        }

        public void SetWorldUITextValue(StringPort Value)
        {
            ChipBuilder.SetPlayerWorldUITextValue((PlayerPort)this, Value);
        }

        public BoolPort SetPosition(Vector3Port Position)
        {
            return ChipBuilder.SetPosition((PlayerPort)this, Position);
        }

        public void SetPositionDeprecated(Vector3Port Position, AlternativeExec Failed)
        {
            ChipBuilder.SetPositionDeprecated((PlayerPort)this, Position, Failed);
        }

        public BoolPort SetRotation(Vector3Port Rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, Rotation);
        }

        public BoolPort SetRotation(QuaternionPort Rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, Vector3Port Rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, Position, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, QuaternionPort Rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, Position, Rotation);
        }

        public void ShowNotification<T>(StringPort Value)
            where T : AnyPort, new()
        {
            ChipBuilder.ShowNotification<T>((PlayerPort)this, Value);
        }

        public void ShowRewardNotification(RewardPort Reward, FloatPort Duration)
        {
            ChipBuilder.ShowRewardNotification((PlayerPort)this, Reward, Duration);
        }

        public void ShowRewardNotification(ListPort<RewardPort> Reward, FloatPort Duration)
        {
            ChipBuilder.ShowRewardNotification((PlayerPort)this, Reward, Duration);
        }

        public void StopCameraShake()
        {
            ChipBuilder.StopCameraShake((PlayerPort)this);
        }

        public CombatantPort ToCombatant()
        {
            return CircuitBuilder.Singleton("RRCG_Player_ToCombatant_" + Port.PortKey(), () => ChipBuilder.ToCombatant((PlayerPort)this));
        }

        public BoolPort UnequipFromPlayer(RecRoomObjectPort Object)
        {
            return ChipBuilder.UnequipFromPlayer((PlayerPort)this, Object);
        }

        public ListPort<RecRoomObjectPort> UnequipFromSlots(BoolPort DominantHand, BoolPort OffHand, BoolPort LeftHipHolster, BoolPort RightHipHolster, BoolPort ShoulderHolster)
        {
            return ChipBuilder.UnequipFromSlots((PlayerPort)this, DominantHand, OffHand, LeftHipHolster, RightHipHolster, ShoulderHolster);
        }

        public void VelocityAdd(FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAdd((PlayerPort)this, Speed, Direction, MaximumSpeed);
        }

        public void VelocityAddNew(FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAddNew((PlayerPort)this, Multiplier, Velocity, MaximumSpeed);
        }

        public void VelocityReflect(FloatPort AdditionalSpeed, FloatPort SpeedMultiplier, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityReflect((PlayerPort)this, AdditionalSpeed, SpeedMultiplier, Direction, MaximumSpeed);
        }

        public void VelocitySet(FloatPort Multiplier, Vector3Port Velocity)
        {
            ChipBuilder.VelocitySet((PlayerPort)this, Multiplier, Velocity);
        }

        public void VelocitySetDeprecated(FloatPort Speed, Vector3Port Direction)
        {
            ChipBuilder.VelocitySetDeprecated((PlayerPort)this, Speed, Direction);
        }
    }

    public class PlayerOutfitSlotPortGen : AnyPort
    {
    }

    public class PlayerSpawnPointV2PortGen : AnyPort
    {
        public BoolPort RespawnPointAddAvoidRole(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddAvoidRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void RespawnPointAddAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public BoolPort RespawnPointAddSpawnRole(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddSpawnRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void RespawnPointAddSpawnTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddSpawnTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public BoolPort RespawnPointGetActive()
        {
            return CircuitBuilder.Singleton("RRCG_PlayerSpawnPointV2_RespawnPointGetActive_" + Port.PortKey(), () => ChipBuilder.RespawnPointGetActive((PlayerSpawnPointV2Port)this));
        }

        public void RespawnPointRemoveAvoidRole(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveAvoidRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void RespawnPointRemoveAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointRemoveAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RespawnPointRemoveSpawnRole(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveSpawnRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void RespawnPointRemoveSpawnTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointRemoveSpawnTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RespawnPointRespawnPlayerAtRespawnPoint(PlayerPort Player, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            ChipBuilder.RespawnPointRespawnPlayerAtRespawnPoint((PlayerSpawnPointV2Port)this, Player, ClearVelocity, UseRezEffects);
        }

        public void RespawnPointSetActive(BoolPort Active)
        {
            ChipBuilder.RespawnPointSetActive((PlayerSpawnPointV2Port)this, Active);
        }
    }

    public class PlayerWorldUIPortGen : AnyPort
    {
        public void DisplayPlayerWorldUI(PlayerPort Player)
        {
            ChipBuilder.DisplayPlayerWorldUI((PlayerWorldUIPort)this, Player);
        }
    }

    public class ProjectileLauncherPortGen : AnyPort
    {
        public void FireProjectile(Vector3Port Direction)
        {
            ChipBuilder.ProjectileLauncherFireProjectile((ProjectileLauncherPort)this, Direction);
        }

        public PlayerPort GetFiringPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetFiringPlayer_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetFiringPlayer((ProjectileLauncherPort)this));
        }

        public IntPort GetHandDamage()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetHandDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetHandDamage((ProjectileLauncherPort)this));
        }

        public IntPort GetHeadDamage()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetHeadDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetHeadDamage((ProjectileLauncherPort)this));
        }

        public ColorPort GetProjectileColor()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileColor_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileColor((ProjectileLauncherPort)this));
        }

        public IntPort GetProjectileCount()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileCount_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileCount((ProjectileLauncherPort)this));
        }

        public FloatPort GetProjectileLifetime()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileLifetime_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileLifetime((ProjectileLauncherPort)this));
        }

        public FloatPort GetProjectileSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpeed_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpeed((ProjectileLauncherPort)this));
        }

        public FloatPort GetProjectileSpread()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpread_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpread((ProjectileLauncherPort)this));
        }

        public IntPort GetRecRoomObjectDamage()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetRecRoomObjectDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetRecRoomObjectDamage((ProjectileLauncherPort)this));
        }

        public IntPort GetTorsoDamage()
        {
            return CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetTorsoDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetTorsoDamage((ProjectileLauncherPort)this));
        }

        public void SetFiringPlayer(PlayerPort Player)
        {
            ChipBuilder.ProjectileLauncherSetFiringPlayer((ProjectileLauncherPort)this, Player);
        }

        public void SetHandDamage(IntPort Damage)
        {
            ChipBuilder.ProjectileLauncherSetHandDamage((ProjectileLauncherPort)this, Damage);
        }

        public void SetHeadDamage(IntPort Damage)
        {
            ChipBuilder.ProjectileLauncherSetHeadDamage((ProjectileLauncherPort)this, Damage);
        }

        public void SetProjectileColor(ColorPort Color)
        {
            ChipBuilder.ProjectileLauncherSetProjectileColor((ProjectileLauncherPort)this, Color);
        }

        public void SetProjectileCount(IntPort Count)
        {
            ChipBuilder.ProjectileLauncherSetProjectileCount((ProjectileLauncherPort)this, Count);
        }

        public void SetProjectileLifetime(FloatPort Lifetime)
        {
            ChipBuilder.ProjectileLauncherSetProjectileLifetime((ProjectileLauncherPort)this, Lifetime);
        }

        public void SetProjectileSpeed(FloatPort Speed)
        {
            ChipBuilder.ProjectileLauncherSetProjectileSpeed((ProjectileLauncherPort)this, Speed);
        }

        public void SetProjectileSpread(FloatPort Spread)
        {
            ChipBuilder.ProjectileLauncherSetProjectileSpread((ProjectileLauncherPort)this, Spread);
        }

        public void SetRecRoomObjectDamage(IntPort Damage)
        {
            ChipBuilder.ProjectileLauncherSetRecRoomObjectDamage((ProjectileLauncherPort)this, Damage);
        }

        public void SetTorsoDamage(IntPort Damage)
        {
            ChipBuilder.ProjectileLauncherSetTorsoDamage((ProjectileLauncherPort)this, Damage);
        }
    }

    public class RecRoomObjectPortGen : AnyPort
    {
        public void AddTag(StringPort Tag)
        {
            ChipBuilder.AddTag((RecRoomObjectPort)this, Tag);
        }

        public void AddTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.AddTags((RecRoomObjectPort)this, Tags);
        }

        public BoolPort AngularVelocityAdd(Vector3Port AngularVelocity, FloatPort SpeedMultiplier, FloatPort MaxAngularSpeed)
        {
            return ChipBuilder.AngularVelocityAdd((RecRoomObjectPort)this, AngularVelocity, SpeedMultiplier, MaxAngularSpeed);
        }

        public void AngularVelocityAddDeprecated(Vector3Port Rotation, FloatPort VelocityMultiplier, FloatPort MaxAngularVelocityApplied)
        {
            ChipBuilder.AngularVelocityAddDeprecated((RecRoomObjectPort)this, Rotation, VelocityMultiplier, MaxAngularVelocityApplied);
        }

        public void AngularVelocityAddDeprecated(QuaternionPort Rotation, FloatPort VelocityMultiplier, FloatPort MaxAngularVelocityApplied)
        {
            ChipBuilder.AngularVelocityAddDeprecated((RecRoomObjectPort)this, Rotation, VelocityMultiplier, MaxAngularVelocityApplied);
        }

        public BoolPort AngularVelocitySet(Vector3Port AngularVelocity, FloatPort SpeedMultiplier)
        {
            return ChipBuilder.AngularVelocitySet((RecRoomObjectPort)this, AngularVelocity, SpeedMultiplier);
        }

        public void AngularVelocitySetDeprecated(Vector3Port Rotation, FloatPort VelocityMultiplier)
        {
            ChipBuilder.AngularVelocitySetDeprecated((RecRoomObjectPort)this, Rotation, VelocityMultiplier);
        }

        public void AngularVelocitySetDeprecated(QuaternionPort Rotation, FloatPort VelocityMultiplier)
        {
            ChipBuilder.AngularVelocitySetDeprecated((RecRoomObjectPort)this, Rotation, VelocityMultiplier);
        }

        public FloatPort Distance(AIPort B)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, B);
        }

        public FloatPort Distance(CombatantPort B)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, B);
        }

        public FloatPort Distance(RecRoomObjectPort B)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, B);
        }

        public FloatPort Distance(PlayerPort B)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, B);
        }

        public FloatPort Distance(Vector3Port B)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, B);
        }

        public FloatPort DistanceDeprecated(AIPort B)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, B);
        }

        public FloatPort DistanceDeprecated(CombatantPort B)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, B);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort B)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, B);
        }

        public FloatPort DistanceDeprecated(PlayerPort B)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, B);
        }

        public FloatPort DistanceDeprecated(Vector3Port B)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, B);
        }

        public T FromRecRoomObject<T>()
            where T : AnyPort, new()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_FromRecRoomObject_" + Port.PortKey(), () => ChipBuilder.FromRecRoomObject<T>((RecRoomObjectPort)this));
        }

        public Vector3Port GetAngularVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAngularVelocity_" + Port.PortKey(), () => ChipBuilder.GetAngularVelocity((RecRoomObjectPort)this));
        }

        public (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<RecRoomObjectPort> Targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, Targets);
        }

        public (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<PlayerPort> Targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, Targets);
        }

        public (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<Vector3Port> Targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, Targets);
        }

        public (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<RecRoomObjectPort> Targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, Targets);
        }

        public (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<PlayerPort> Targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, Targets);
        }

        public (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<Vector3Port> Targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, Targets);
        }

        public StringPort GetFirstTag()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetFirstTag_" + Port.PortKey(), () => ChipBuilder.GetFirstTag((RecRoomObjectPort)this));
        }

        public Vector3Port GetForwardVector()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVector_" + Port.PortKey(), () => ChipBuilder.GetForwardVector((RecRoomObjectPort)this));
        }

        public Vector3Port GetForwardVectorDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((RecRoomObjectPort)this));
        }

        public Vector3Port GetPosition()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((RecRoomObjectPort)this));
        }

        public Vector3Port GetPositionDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((RecRoomObjectPort)this));
        }

        public QuaternionPort GetRotation()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotation_" + Port.PortKey(), () => ChipBuilder.GetRotation((RecRoomObjectPort)this));
        }

        public QuaternionPort GetRotationDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotationDeprecated_" + Port.PortKey(), () => ChipBuilder.GetRotationDeprecated((RecRoomObjectPort)this));
        }

        public ListPort<StringPort> GetTags()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetTags_" + Port.PortKey(), () => ChipBuilder.GetTags((RecRoomObjectPort)this));
        }

        public Vector3Port GetUpVector()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVector_" + Port.PortKey(), () => ChipBuilder.GetUpVector((RecRoomObjectPort)this));
        }

        public Vector3Port GetUpVectorDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetUpVectorDeprecated((RecRoomObjectPort)this));
        }

        public Vector3Port GetVelocity()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocity_" + Port.PortKey(), () => ChipBuilder.GetVelocity((RecRoomObjectPort)this));
        }

        public Vector3Port GetVelocityDeprecated()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocityDeprecated_" + Port.PortKey(), () => ChipBuilder.GetVelocityDeprecated((RecRoomObjectPort)this));
        }

        public BoolPort HasTag(StringPort Tag)
        {
            return ChipBuilder.HasTag((RecRoomObjectPort)this, Tag);
        }

        public void IfHasTag(StringPort Tag, AlternativeExec DoesNotHaveTag)
        {
            ChipBuilder.IfHasTag((RecRoomObjectPort)this, Tag, DoesNotHaveTag);
        }

        public PlayerPort GetAuthority()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAuthority_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetAuthority((RecRoomObjectPort)this));
        }

        public (BoolPort IsHeld, PlayerPort HolderPlayer) GetHolderPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetHolderPlayer_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetHolderPlayer((RecRoomObjectPort)this));
        }

        public BoolPort GetIsLocalPlayerAuthority()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetIsLocalPlayerAuthority_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetIsLocalPlayerAuthority((RecRoomObjectPort)this));
        }

        public (PlayerPort Player, BoolPort CurrentlyHeldOrEquipped) GetLastHoldingOrEquippingPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_GetLastHoldingOrEquippingPlayer_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetLastHoldingOrEquippingPlayer((RecRoomObjectPort)this));
        }

        public void Reset()
        {
            ChipBuilder.RecRoomObjectReset((RecRoomObjectPort)this);
        }

        public void SetAuthority(PlayerPort Authority)
        {
            ChipBuilder.RecRoomObjectSetAuthority((RecRoomObjectPort)this, Authority);
        }

        public RecRoomObjectPort Variable()
        {
            return ChipBuilder.RecRoomObjectVariable((RecRoomObjectPort)this);
        }

        public void RemoveTag(StringPort Tag)
        {
            ChipBuilder.RemoveTag((RecRoomObjectPort)this, Tag);
        }

        public void RemoveTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.RemoveTags((RecRoomObjectPort)this, Tags);
        }

        public void RequestVelocitySetOverDuration(FloatPort Multiplier, Vector3Port Velocity, FloatPort Duration)
        {
            ChipBuilder.RequestVelocitySetOverDuration((RecRoomObjectPort)this, Multiplier, Velocity, Duration);
        }

        public BoolPort Respawn(Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            return ChipBuilder.Respawn((RecRoomObjectPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects);
        }

        public BoolPort Respawn(Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            return ChipBuilder.Respawn((RecRoomObjectPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects);
        }

        public void RespawnDeprecated(Vector3Port Position, Vector3Port Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            ChipBuilder.RespawnDeprecated((RecRoomObjectPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects, Failed);
        }

        public void RespawnDeprecated(Vector3Port Position, QuaternionPort Rotation, FloatPort SpawnRadius, BoolPort ClearVelocity, BoolPort UseRezEffects, AlternativeExec Failed)
        {
            ChipBuilder.RespawnDeprecated((RecRoomObjectPort)this, Position, Rotation, SpawnRadius, ClearVelocity, UseRezEffects, Failed);
        }

        public BoolPort SetPosition(Vector3Port Position)
        {
            return ChipBuilder.SetPosition((RecRoomObjectPort)this, Position);
        }

        public void SetPositionDeprecated(Vector3Port Position, AlternativeExec Failed)
        {
            ChipBuilder.SetPositionDeprecated((RecRoomObjectPort)this, Position, Failed);
        }

        public BoolPort SetRotation(Vector3Port Rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, Rotation);
        }

        public BoolPort SetRotation(QuaternionPort Rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, Vector3Port Rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, Position, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, QuaternionPort Rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, Position, Rotation);
        }

        public void SpawnerInternalStartSpawning(IntPort Amountofobjectstospawn, FloatPort Timebetweenspawns, Vector3Port SpawnPosition)
        {
            ChipBuilder.SpawnerInternalStartSpawning((RecRoomObjectPort)this, Amountofobjectstospawn, Timebetweenspawns, SpawnPosition);
        }

        public void SpawnerReset()
        {
            ChipBuilder.SpawnerReset((RecRoomObjectPort)this);
        }

        public BoolPort UnequipObject()
        {
            return ChipBuilder.UnequipObject((RecRoomObjectPort)this);
        }

        public void VelocityAdd(FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAdd((RecRoomObjectPort)this, Speed, Direction, MaximumSpeed);
        }

        public void VelocityAddNew(FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAddNew((RecRoomObjectPort)this, Multiplier, Velocity, MaximumSpeed);
        }

        public void VelocityReflect(FloatPort AdditionalSpeed, FloatPort SpeedMultiplier, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityReflect((RecRoomObjectPort)this, AdditionalSpeed, SpeedMultiplier, Direction, MaximumSpeed);
        }

        public void VelocitySet(FloatPort Multiplier, Vector3Port Velocity)
        {
            ChipBuilder.VelocitySet((RecRoomObjectPort)this, Multiplier, Velocity);
        }

        public void VelocitySetDeprecated(FloatPort Speed, Vector3Port Direction)
        {
            ChipBuilder.VelocitySetDeprecated((RecRoomObjectPort)this, Speed, Direction);
        }
    }

    public class RemoteVideoPlayerPortGen : AnyPort
    {
    }

    public class RewardPortGen : AnyPort
    {
    }

    public class RoomCurrencyPortGen : AnyPort
    {
        public (BoolPort Success, IntPort TotalBalance) AwardCurrencyNew(PlayerPort Player, IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrencyNew((RoomCurrencyPort)this, Player, Amount, OnAwardCurrencyComplete);
        }

        public (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceNew(PlayerPort Player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnGetBalanceComplete)
        {
            return ChipBuilder.GetCurrencyBalanceNew((RoomCurrencyPort)this, Player, OnGetBalanceComplete);
        }

        public void ShowPurchasePrompt(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePrompt((RoomCurrencyPort)this, Player);
        }
    }

    public class RoomDoorPortGen : AnyPort
    {
        public DestinationRoomPort DoorGetDestination()
        {
            return CircuitBuilder.Singleton("RRCG_RoomDoor_DoorGetDestination_" + Port.PortKey(), () => ChipBuilder.DoorGetDestination((RoomDoorPort)this));
        }

        public BoolPort DoorGetLocked()
        {
            return CircuitBuilder.Singleton("RRCG_RoomDoor_DoorGetLocked_" + Port.PortKey(), () => ChipBuilder.DoorGetLocked((RoomDoorPort)this));
        }

        public void DoorSetDestination(DestinationRoomPort Room)
        {
            ChipBuilder.DoorSetDestination((RoomDoorPort)this, Room);
        }

        public void DoorSetLocked(BoolPort Locked)
        {
            ChipBuilder.DoorSetLocked((RoomDoorPort)this, Locked);
        }
    }

    public class RoomKeyPortGen : AnyPort
    {
        public BoolPort AwardRoomKey(PlayerPort Player, AlternativeExec<BoolPort> OnAwardRoomKeyComplete)
        {
            return ChipBuilder.AwardRoomKey((RoomKeyPort)this, Player, OnAwardRoomKeyComplete);
        }

        public void ShowPurchasePrompt(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePrompt((RoomKeyPort)this, Player);
        }
    }

    public class RoomLevelHUDPortGen : AnyPort
    {
    }

    public class RoomOfferPortGen : AnyPort
    {
    }

    public class RotatorPortGen : AnyPort
    {
        public FloatPort GetRotation()
        {
            return CircuitBuilder.Singleton("RRCG_Rotator_GetRotation_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotation((RotatorPort)this));
        }

        public FloatPort GetRotationAcceleration()
        {
            return CircuitBuilder.Singleton("RRCG_Rotator_GetRotationAcceleration_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotationAcceleration((RotatorPort)this));
        }

        public FloatPort GetRotationSpeed()
        {
            return CircuitBuilder.Singleton("RRCG_Rotator_GetRotationSpeed_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotationSpeed((RotatorPort)this));
        }

        public FloatPort GetTargetRotation()
        {
            return CircuitBuilder.Singleton("RRCG_Rotator_GetTargetRotation_" + Port.PortKey(), () => ChipBuilder.RotatorGetTargetRotation((RotatorPort)this));
        }

        public void SetRotation(FloatPort Value)
        {
            ChipBuilder.RotatorSetRotation((RotatorPort)this, Value);
        }

        public void SetRotationAcceleration(FloatPort Value)
        {
            ChipBuilder.RotatorSetRotationAcceleration((RotatorPort)this, Value);
        }

        public void SetRotationSpeed(FloatPort Value)
        {
            ChipBuilder.RotatorSetRotationSpeed((RotatorPort)this, Value);
        }

        public void SetTargetRotation(FloatPort Value)
        {
            ChipBuilder.RotatorSetTargetRotation((RotatorPort)this, Value);
        }
    }

    public class SeatPortGen : AnyPort
    {
        public BoolPort GetLockPlayersIn()
        {
            return CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersIn_" + Port.PortKey(), () => ChipBuilder.SeatGetLockPlayersIn((SeatPort)this));
        }

        public BoolPort GetLockPlayersOut()
        {
            return CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersOut_" + Port.PortKey(), () => ChipBuilder.SeatGetLockPlayersOut((SeatPort)this));
        }

        public PlayerPort GetSeatedPlayer()
        {
            return CircuitBuilder.Singleton("RRCG_Seat_GetSeatedPlayer_" + Port.PortKey(), () => ChipBuilder.SeatGetSeatedPlayer((SeatPort)this));
        }

        public void SetLockPlayersIn(BoolPort LockPlayersIn)
        {
            ChipBuilder.SeatSetLockPlayersIn((SeatPort)this, LockPlayersIn);
        }

        public void SetLockPlayersOut(BoolPort LockPlayersOut)
        {
            ChipBuilder.SeatSetLockPlayersOut((SeatPort)this, LockPlayersOut);
        }

        public void SetSeatedPlayer(PlayerPort Player, AlternativeExec Fail)
        {
            ChipBuilder.SeatSetSeatedPlayer((SeatPort)this, Player, Fail);
        }

        public void UnseatPlayer()
        {
            ChipBuilder.SeatUnseatPlayer((SeatPort)this);
        }
    }

    public class SFXPortGen : AnyPort
    {
        public BoolPort GetIsPlaying()
        {
            return CircuitBuilder.Singleton("RRCG_SFX_GetIsPlaying_" + Port.PortKey(), () => ChipBuilder.SFXGetIsPlaying((SFXPort)this));
        }

        public IntPort GetVolume()
        {
            return CircuitBuilder.Singleton("RRCG_SFX_GetVolume_" + Port.PortKey(), () => ChipBuilder.SFXGetVolume((SFXPort)this));
        }

        public void Play()
        {
            ChipBuilder.SFXPlay((SFXPort)this);
        }

        public void SetVolume(IntPort Value)
        {
            ChipBuilder.SFXSetVolume((SFXPort)this, Value);
        }

        public void Stop()
        {
            ChipBuilder.SFXStop((SFXPort)this);
        }
    }

    public class SkydomePortGen : AnyPort
    {
        public BoolPort RoomSkydomeModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSkydomeModify((SkydomePort)this, BlendFinished);
        }
    }

    public class StatePortGen : AnyPort
    {
        public void GoToState()
        {
            ChipBuilder.GoToState((StatePort)this);
        }
    }

    public class SteeringEnginePortGen : AnyPort
    {
    }

    public class StudioObjectPortGen : AnyPort
    {
        public void StudioEventSender(StringPort Event)
        {
            ChipBuilder.StudioEventSender((StudioObjectPort)this, Event);
        }

        public void StudioEventSenderBool(StringPort Event, BoolPort Value)
        {
            ChipBuilder.StudioEventSenderBool((StudioObjectPort)this, Event, Value);
        }

        public void StudioEventSenderFloat(StringPort Event, FloatPort Value)
        {
            ChipBuilder.StudioEventSenderFloat((StudioObjectPort)this, Event, Value);
        }

        public void StudioEventSenderInt(StringPort Event, IntPort Value)
        {
            ChipBuilder.StudioEventSenderInt((StudioObjectPort)this, Event, Value);
        }

        public void StudioEventSenderString(StringPort Event, StringPort Value)
        {
            ChipBuilder.StudioEventSenderString((StudioObjectPort)this, Event, Value);
        }

        public void StudioEventSenderStringBool(StringPort Event, StringPort Value0, BoolPort Value1)
        {
            ChipBuilder.StudioEventSenderStringBool((StudioObjectPort)this, Event, Value0, Value1);
        }

        public void StudioEventSenderStringFloat(StringPort Event, StringPort Value0, FloatPort Value1)
        {
            ChipBuilder.StudioEventSenderStringFloat((StudioObjectPort)this, Event, Value0, Value1);
        }

        public void StudioEventSenderStringInt(StringPort Event, StringPort Value0, IntPort Value1)
        {
            ChipBuilder.StudioEventSenderStringInt((StudioObjectPort)this, Event, Value0, Value1);
        }

        public void StudioEventSenderStringString(StringPort Event, StringPort Value0, StringPort Value1)
        {
            ChipBuilder.StudioEventSenderStringString((StudioObjectPort)this, Event, Value0, Value1);
        }

        public BoolPort GetPropertyBool(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyBool((StudioObjectPort)this, Property);
        }

        public FloatPort GetPropertyFloat(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyFloat((StudioObjectPort)this, Property);
        }

        public IntPort GetPropertyInt(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyInt((StudioObjectPort)this, Property);
        }

        public StringPort GetPropertyString(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyString((StudioObjectPort)this, Property);
        }
    }

    public class SunPortGen : AnyPort
    {
        public BoolPort RoomSunModify(SunDirectionPort SunDirection, AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSunModify((SunPort)this, SunDirection, BlendFinished);
        }
    }

    public class SunDirectionPortGen : AnyPort
    {
    }

    public class SwingHandlePortGen : AnyPort
    {
        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((SwingHandlePort)this, Duration, Intensity);
        }

        public BoolPort GetIsSwinging()
        {
            return CircuitBuilder.Singleton("RRCG_SwingHandle_GetIsSwinging_" + Port.PortKey(), () => ChipBuilder.SwingHandleGetIsSwinging((SwingHandlePort)this));
        }
    }

    public class TextPortGen : AnyPort
    {
        public ColorPort GetColor()
        {
            return CircuitBuilder.Singleton("RRCG_Text_GetColor_" + Port.PortKey(), () => ChipBuilder.TextGetColor((TextPort)this));
        }

        public StringPort GetText()
        {
            return CircuitBuilder.Singleton("RRCG_Text_GetText_" + Port.PortKey(), () => ChipBuilder.TextGetText((TextPort)this));
        }

        public void SetColor(ColorPort Color)
        {
            ChipBuilder.TextSetColor((TextPort)this, Color);
        }

        public void SetColorId(IntPort Color)
        {
            ChipBuilder.TextSetColorId((TextPort)this, Color);
        }

        public void SetMaterial(IntPort Material)
        {
            ChipBuilder.TextSetMaterial((TextPort)this, Material);
        }

        public void SetText(StringPort Text)
        {
            ChipBuilder.TextSetText((TextPort)this, Text);
        }
    }

    public class TextScreenPortGen : AnyPort
    {
        public void ClearScreen()
        {
            ChipBuilder.ClearScreen((TextScreenPort)this);
        }

        public void PrintTextToScreen(StringPort Text, ColorPort Color)
        {
            ChipBuilder.PrintTextToScreen((TextScreenPort)this, Text, Color);
        }
    }

    public class ToggleButtonPortGen : AnyPort
    {
        public BoolPort GetIsPressed()
        {
            return CircuitBuilder.Singleton("RRCG_ToggleButton_GetIsPressed_" + Port.PortKey(), () => ChipBuilder.ToggleButtonGetIsPressed((ToggleButtonPort)this));
        }

        public void SetIsPressed(BoolPort Value)
        {
            ChipBuilder.ToggleButtonSetIsPressed((ToggleButtonPort)this, Value);
        }
    }

    public class TouchpadPortGen : AnyPort
    {
        public (BoolPort IsTouchActive, Vector3Port TouchPosition, Vector3Port WorldPosition) ComponentGetActiveTouch()
        {
            return CircuitBuilder.Singleton("RRCG_Touchpad_ComponentGetActiveTouch_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetActiveTouch((TouchpadPort)this));
        }

        public StringPort ComponentGetInteractionLabel()
        {
            return CircuitBuilder.Singleton("RRCG_Touchpad_ComponentGetInteractionLabel_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetInteractionLabel((TouchpadPort)this));
        }

        public BoolPort ComponentGetIsEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_Touchpad_ComponentGetIsEnabled_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetIsEnabled((TouchpadPort)this));
        }

        public void ComponentSetInteractionLabel(StringPort Label)
        {
            ChipBuilder.TouchpadComponentSetInteractionLabel((TouchpadPort)this, Label);
        }

        public void ComponentSetIsEnabled(BoolPort Enabled)
        {
            ChipBuilder.TouchpadComponentSetIsEnabled((TouchpadPort)this, Enabled);
        }
    }

    public class TriggerHandlePortGen : AnyPort
    {
        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((TriggerHandlePort)this, Duration, Intensity);
        }

        public StringPort GetControlPrompt()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerHandle_GetControlPrompt_" + Port.PortKey(), () => ChipBuilder.TriggerHandleGetControlPrompt((TriggerHandlePort)this));
        }

        public BoolPort GetPrimaryActionHeld()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerHandle_GetPrimaryActionHeld_" + Port.PortKey(), () => ChipBuilder.TriggerHandleGetPrimaryActionHeld((TriggerHandlePort)this));
        }

        public void SetControlPrompt(StringPort ControlPrompt)
        {
            ChipBuilder.TriggerHandleSetControlPrompt((TriggerHandlePort)this, ControlPrompt);
        }
    }

    public class TriggerVolumePortGen : AnyPort
    {
        public StringPort GetFilterRole()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetFilterRole_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetFilterRole((TriggerVolumePort)this));
        }

        public ListPort<StringPort> GetFilterTags()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetFilterTags_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetFilterTags((TriggerVolumePort)this));
        }

        public IntPort GetObjectCount()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjectCount_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetObjectCount((TriggerVolumePort)this));
        }

        public ListPort<RecRoomObjectPort> GetObjects()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjects_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetObjects((TriggerVolumePort)this));
        }

        public IntPort GetPlayerCount()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayerCount_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetPlayerCount((TriggerVolumePort)this));
        }

        public ListPort<PlayerPort> GetPlayers()
        {
            return CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayers_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetPlayers((TriggerVolumePort)this));
        }

        public void SetFilterRole(StringPort Value)
        {
            ChipBuilder.TriggerVolumeSetFilterRole((TriggerVolumePort)this, Value);
        }

        public void SetFilterTags(ListPort<StringPort> Value)
        {
            ChipBuilder.TriggerVolumeSetFilterTags((TriggerVolumePort)this, Value);
        }
    }

    public class VectorComponentPortGen : AnyPort
    {
        public Vector3Port GetVector(FloatPort Magnitude)
        {
            return ChipBuilder.VectorComponentGetVector((VectorComponentPort)this, Magnitude);
        }
    }

    public class WelcomeMatPortGen : AnyPort
    {
        public BoolPort GetEnabled()
        {
            return CircuitBuilder.Singleton("RRCG_WelcomeMat_GetEnabled_" + Port.PortKey(), () => ChipBuilder.WelcomeMatGetEnabled((WelcomeMatPort)this));
        }

        public void SetEnabled(BoolPort Enabled)
        {
            ChipBuilder.WelcomeMatSetEnabled((WelcomeMatPort)this, Enabled);
        }
    }
}