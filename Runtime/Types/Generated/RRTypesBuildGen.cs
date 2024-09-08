using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;
using RRCG;

namespace RRCGGenerated
{
    public abstract class AIPortGen : AnyPort
    {
        public Vector3Port CombatantGetGroundPositionR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetGroundPositionR1_" + PortKey(), () => ChipBuilder.CombatantGetGroundPositionR1((AIPort)this));
        }

        public BoolPort CombatantGetIsAliveR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetIsAliveR1_" + PortKey(), () => ChipBuilder.CombatantGetIsAliveR1((AIPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocityR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetVelocityR1_" + PortKey(), () => ChipBuilder.CombatantGetVelocityR1((AIPort)this));
        }

        public IntPort CombatantSetMaxHealthR1
        {
            set => ChipBuilder.CombatantSetMaxHealthR1((AIPort)this, value);
        }

        public (StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange) LineOfSightParametersR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetLineOfSightParametersR1_" + PortKey(), () => ChipBuilder.AIGetLineOfSightParametersR1((AIPort)this));
        }

        public FloatPort PathingSpeedR1
        {
            set => ChipBuilder.AISetPathingSpeedR1((AIPort)this, value);
        }

        public PatrolPointPort PatrolPointR1
        {
            set => ChipBuilder.AISetPatrolPointR1((AIPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetPosition_" + PortKey(), () => ChipBuilder.GetPosition((AIPort)this));
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetPositionDeprecated_" + PortKey(), () => ChipBuilder.GetPositionDeprecated((AIPort)this));
        }

        public CombatantPort TargetR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetTargetR1_" + PortKey(), () => ChipBuilder.AIGetTargetR1((AIPort)this));
            set => ChipBuilder.AISetTargetR1((AIPort)this, value);
        }

        public CombatantPort ToCombatantR1
        {
            get => CircuitBuilder.Singleton("RRCG_AI_ToCombatantR1_" + PortKey(), () => ChipBuilder.ToCombatantR1((AIPort)this));
        }

        public BoolPort HasLineOfSightToTargetR1(AIPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTargetR1(CombatantPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTargetR1(RecRoomObjectPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTargetR1(PatrolPointPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTargetR1(PlayerPort Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public BoolPort HasLineOfSightToTargetR1(Vector3Port Target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, Target);
        }

        public void LookAtR1(AIPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAtR1(CombatantPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAtR1(RecRoomObjectPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAtR1(PatrolPointPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAtR1(PlayerPort LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void LookAtR1(Vector3Port LookTarget, BoolPort LookTargetisDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, LookTarget, LookTargetisDirection);
        }

        public void PathToR1(AIPort Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void PathToR1(CombatantPort Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void PathToR1(RecRoomObjectPort Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void PathToR1(PatrolPointPort Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void PathToR1(PlayerPort Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void PathToR1(Vector3Port Target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, Target);
        }

        public void RotateR1(FloatPort Rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, Rotation);
        }

        public void RotateR1(IntPort Rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, Rotation);
        }

        public void RotateR1(Vector3Port Rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, Rotation);
        }

        public void SetLineOfSightParametersR1(StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange, BoolPort RequireLoSfortargeting)
        {
            ChipBuilder.AISetLineOfSightParametersR1((AIPort)this, VisionType, VisionRange, VisionConeAngle, HearingRange, RequireLoSfortargeting);
        }

        public void StartCombatBehaviorR1()
        {
            ChipBuilder.AIStartCombatBehaviorR1((AIPort)this);
        }

        public void StopCombatBehaviorR1()
        {
            ChipBuilder.AIStopCombatBehaviorR1((AIPort)this);
        }

        public void StopLookingR1()
        {
            ChipBuilder.AIStopLookingR1((AIPort)this);
        }

        public AIPort VariableR1(VariableData config)
        {
            return ChipBuilder.AIVariableR1((AIPort)this, config);
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealthR1()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetHealthR1_" + PortKey(), () => ChipBuilder.CombatantGetHealthR1((AIPort)this));
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantSetHealthR1(IntPort Health)
        {
            ChipBuilder.CombatantSetHealthR1((AIPort)this, Health);
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

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, ReferenceObject);
        }
    }

    public abstract class AnimationControllerPortGen : AnyPort
    {
        public IntPort Frame
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetFrame_" + PortKey(), () => ChipBuilder.AnimationGetFrame((AnimationControllerPort)this));
            set => ChipBuilder.AnimationSetFrame((AnimationControllerPort)this, value);
        }

        public BoolPort IsPlaying
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetIsPlaying_" + PortKey(), () => ChipBuilder.AnimationGetIsPlaying((AnimationControllerPort)this));
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetSpeed_" + PortKey(), () => ChipBuilder.AnimationGetSpeed((AnimationControllerPort)this));
            set => ChipBuilder.AnimationSetSpeed((AnimationControllerPort)this, value);
        }

        public FloatPort TimeStamp
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetTimeStamp_" + PortKey(), () => ChipBuilder.AnimationGetTimeStamp((AnimationControllerPort)this));
            set => ChipBuilder.AnimationSetTimeStamp((AnimationControllerPort)this, value);
        }

        public void Pause()
        {
            ChipBuilder.AnimationPause((AnimationControllerPort)this);
        }

        public void Play()
        {
            ChipBuilder.AnimationPlay((AnimationControllerPort)this);
        }

        public void Stop()
        {
            ChipBuilder.AnimationStop((AnimationControllerPort)this);
        }
    }

    public abstract class AudioPortGen : AnyPort
    {
        public FloatPort Length
        {
            get => CircuitBuilder.Singleton("RRCG_Audio_GetLength_" + PortKey(), () => ChipBuilder.AudioGetLength((AudioPort)this));
        }

        public void PlayAudioAtPosition(Vector3Port Position, FloatPort Volume, FloatPort PlaybackSpeed, BoolPort Is2D, PlayAudioAtPositionData config)
        {
            ChipBuilder.PlayAudioAtPosition((AudioPort)this, Position, Volume, PlaybackSpeed, Is2D, config);
        }
    }

    public abstract class AudioFXZonePortGen : AnyPort
    {
        public FloatPort Intensity
        {
            get => CircuitBuilder.Singleton("RRCG_AudioFXZone_GetIntensity_" + PortKey(), () => ChipBuilder.AudioFXZoneGetIntensity((AudioFXZonePort)this));
            set => ChipBuilder.AudioFXZoneSetIntensity((AudioFXZonePort)this, value);
        }

        public IntPort Priority
        {
            get => CircuitBuilder.Singleton("RRCG_AudioFXZone_GetPriority_" + PortKey(), () => ChipBuilder.AudioFXZoneGetPriority((AudioFXZonePort)this));
            set => ChipBuilder.AudioFXZoneSetPriority((AudioFXZonePort)this, value);
        }

        public void SetEffect()
        {
            ChipBuilder.AudioFXZoneSetEffect((AudioFXZonePort)this);
        }
    }

    public abstract class AudioPlayerPortGen : AnyPort
    {
        public AudioPort Audio
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetAudio_" + PortKey(), () => ChipBuilder.AudioPlayerGetAudio((AudioPlayerPort)this));
        }

        public FloatPort MaxRolloffDistance
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetMaxRolloffDistance_" + PortKey(), () => ChipBuilder.AudioPlayerGetMaxRolloffDistance((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetMaxRolloffDistance((AudioPlayerPort)this, value);
        }

        public BoolPort Playing
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetPlaying_" + PortKey(), () => ChipBuilder.AudioPlayerGetPlaying((AudioPlayerPort)this));
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetSpeed_" + PortKey(), () => ChipBuilder.AudioPlayerGetSpeed((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetSpeed((AudioPlayerPort)this, value);
        }

        public FloatPort TimeStamp
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetTimeStamp_" + PortKey(), () => ChipBuilder.AudioPlayerGetTimeStamp((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetTimeStamp((AudioPlayerPort)this, value);
        }

        public FloatPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetVolume_" + PortKey(), () => ChipBuilder.AudioPlayerGetVolume((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetVolume((AudioPlayerPort)this, value);
        }

        public void Pause()
        {
            ChipBuilder.AudioPlayerPause((AudioPlayerPort)this);
        }

        public void Play(AudioPort Audio)
        {
            ChipBuilder.AudioPlayerPlay((AudioPlayerPort)this, Audio);
        }

        public void Stop()
        {
            ChipBuilder.AudioPlayerStop((AudioPlayerPort)this);
        }
    }

    public abstract class BackgroundObjectsPortGen : AnyPort
    {
        public BoolPort RoomBackgroundObjectsModifyR1(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomBackgroundObjectsModifyR1((BackgroundObjectsPort)this, BlendFinished);
        }

        public void RoomBackgroundObjectsModifyR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsModifyR2((BackgroundObjectsPort)this, BlendTime, BlendFinished);
        }

        public void RoomBackgroundObjectsPlayerOverrideR2(PlayerPort Player, FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsPlayerOverrideR2((BackgroundObjectsPort)this, Player, BlendTime, BlendFinished);
        }
    }

    public abstract class BeaconPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetColor_" + PortKey(), () => ChipBuilder.BeaconGetColor((BeaconPort)this));
            set => ChipBuilder.BeaconSetColor((BeaconPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetEnabled_" + PortKey(), () => ChipBuilder.BeaconGetEnabled((BeaconPort)this));
            set => ChipBuilder.BeaconSetEnabled((BeaconPort)this, value);
        }

        public FloatPort Height
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetHeight_" + PortKey(), () => ChipBuilder.BeaconGetHeight((BeaconPort)this));
            set => ChipBuilder.BeaconSetHeight((BeaconPort)this, value);
        }
    }

    public abstract class ButtonPortGen : AnyPort
    {
        public BoolPort IsPressed
        {
            get => CircuitBuilder.Singleton("RRCG_Button_GetIsPressed_" + PortKey(), () => ChipBuilder.ButtonGetIsPressed((ButtonPort)this));
        }

        public StringPort Text
        {
            get => CircuitBuilder.Singleton("RRCG_Button_GetText_" + PortKey(), () => ChipBuilder.ButtonGetText((ButtonPort)this));
            set => ChipBuilder.ButtonSetText((ButtonPort)this, value);
        }
    }

    public abstract class CollisionDataPortGen : AnyPort
    {
        public FloatPort Distance
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetDistance_" + PortKey(), () => ChipBuilder.CollisionDataGetDistance((CollisionDataPort)this));
        }

        public Vector3Port Normal
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetNormal_" + PortKey(), () => ChipBuilder.CollisionDataGetNormal((CollisionDataPort)this));
        }

        public RecRoomObjectPort Object
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetObject_" + PortKey(), () => ChipBuilder.CollisionDataGetObject((CollisionDataPort)this));
        }

        public PlayerPort Player
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetPlayer_" + PortKey(), () => ChipBuilder.CollisionDataGetPlayer((CollisionDataPort)this));
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetPosition_" + PortKey(), () => ChipBuilder.CollisionDataGetPosition((CollisionDataPort)this));
        }
    }

    public abstract class CollisionDetectionVolumePortGen : AnyPort
    {
        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionDetectionVolume_GetEnabled_" + PortKey(), () => ChipBuilder.CollisionDetectionVolumeGetEnabled((CollisionDetectionVolumePort)this));
            set => ChipBuilder.CollisionDetectionVolumeSetEnabled((CollisionDetectionVolumePort)this, value);
        }
    }

    public abstract class CombatantPortGen : AnyPort
    {
        public Vector3Port GroundPositionR1
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetGroundPositionR1_" + PortKey(), () => ChipBuilder.CombatantGetGroundPositionR1((CombatantPort)this));
        }

        public BoolPort IsAliveR1
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetIsAliveR1_" + PortKey(), () => ChipBuilder.CombatantGetIsAliveR1((CombatantPort)this));
        }

        public IntPort MaxHealthR1
        {
            set => ChipBuilder.CombatantSetMaxHealthR1((CombatantPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetPosition_" + PortKey(), () => ChipBuilder.GetPosition((CombatantPort)this));
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetPositionDeprecated_" + PortKey(), () => ChipBuilder.GetPositionDeprecated((CombatantPort)this));
        }

        public (BoolPort IsPlayer, PlayerPort Player, AIPort AI) SplitR1
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_SplitR1_" + PortKey(), () => ChipBuilder.CombatantSplitR1((CombatantPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) VelocityR1
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetVelocityR1_" + PortKey(), () => ChipBuilder.CombatantGetVelocityR1((CombatantPort)this));
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) GetHealthR1()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetHealthR1_" + PortKey(), () => ChipBuilder.CombatantGetHealthR1((CombatantPort)this));
        }

        public void ReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void ReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void ReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void SetHealthR1(IntPort Health)
        {
            ChipBuilder.CombatantSetHealthR1((CombatantPort)this, Health);
        }

        public CombatantPort VariableR1(VariableData config)
        {
            return ChipBuilder.CombatantVariableR1((CombatantPort)this, config);
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

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, ReferenceObject);
        }
    }

    public abstract class ConsumablePortGen : AnyPort
    {
        public BoolPort AwardConsumableR1(PlayerPort Player, IntPort Quantity, AlternativeExec<BoolPort> OnAwardConsumableComplete)
        {
            return ChipBuilder.AwardConsumableR1((ConsumablePort)this, Player, Quantity, OnAwardConsumableComplete);
        }

        public void ActivateR1()
        {
            ChipBuilder.ConsumableActivateR1((ConsumablePort)this);
        }

        public void DeactivateR1()
        {
            ChipBuilder.ConsumableDeactivateR1((ConsumablePort)this);
        }

        public void ShowPurchasePromptR1(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePromptR1((ConsumablePort)this, Player);
        }
    }

    public abstract class CostumePortGen : AnyPort
    {
        public PlayerPort Wearer
        {
            get => CircuitBuilder.Singleton("RRCG_Costume_GetWearer_" + PortKey(), () => ChipBuilder.CostumeGetWearer((CostumePort)this));
        }

        public void Equip(PlayerPort Player)
        {
            ChipBuilder.CostumeEquip((CostumePort)this, Player);
        }

        public PlayerPort Unequip()
        {
            return ChipBuilder.CostumeUnequip((CostumePort)this);
        }
    }

    public abstract class DestinationRoomPortGen : AnyPort
    {
        public DestinationRoomPort Variable(VariableData config)
        {
            return ChipBuilder.DestinationRoomVariable((DestinationRoomPort)this, config);
        }
    }

    public abstract class DialogueUIPortGen : AnyPort
    {
        public Vector3Port BillboardingPivotOffset
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetBillboardingPivotOffset_" + PortKey(), () => ChipBuilder.DialogueUIGetBillboardingPivotOffset((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetBillboardingPivotOffset((DialogueUIPort)this, value);
        }

        public (StringPort BodyText, BoolPort IsInteractive) DialogueText
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetDialogueText_" + PortKey(), () => ChipBuilder.DialogueUIGetDialogueText((DialogueUIPort)this));
        }

        public BoolPort IsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetIsEnabled_" + PortKey(), () => ChipBuilder.DialogueUIGetIsEnabled((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetIsEnabled((DialogueUIPort)this, value);
        }

        public BoolPort TitleIsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleIsEnabled_" + PortKey(), () => ChipBuilder.DialogueUIGetTitleIsEnabled((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetTitleIsEnabled((DialogueUIPort)this, value);
        }

        public StringPort TitleText
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleText_" + PortKey(), () => ChipBuilder.DialogueUIGetTitleText((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetTitleText((DialogueUIPort)this, value);
        }

        public void SetButtonState(BoolPort Button1Enabled, StringPort Button1Text, BoolPort Button2Enabled, StringPort Button2Text, BoolPort Button3Enabled, StringPort Button3Text, BoolPort Button4Enabled, StringPort Button4Text)
        {
            ChipBuilder.DialogueUISetButtonState((DialogueUIPort)this, Button1Enabled, Button1Text, Button2Enabled, Button2Text, Button3Enabled, Button3Text, Button4Enabled, Button4Text);
        }

        public void SetDialogueText(StringPort BodyText, BoolPort IsInteractive)
        {
            ChipBuilder.DialogueUISetDialogueText((DialogueUIPort)this, BodyText, IsInteractive);
        }
    }

    public abstract class DiePortGen : AnyPort
    {
        public PlayerPort PlayerRolled
        {
            get => CircuitBuilder.Singleton("RRCG_Die_GetPlayerRolled_" + PortKey(), () => ChipBuilder.DiceGetPlayerRolled((DiePort)this));
        }

        public IntPort Result
        {
            get => CircuitBuilder.Singleton("RRCG_Die_GetResult_" + PortKey(), () => ChipBuilder.DiceGetResult((DiePort)this));
        }

        public BoolPort RollFinished
        {
            get => CircuitBuilder.Singleton("RRCG_Die_GetRollFinished_" + PortKey(), () => ChipBuilder.DiceGetRollFinished((DiePort)this));
        }
    }

    public abstract class EmitterPortGen : AnyPort
    {
        public ColorPort Color
        {
            set => ChipBuilder.EmitterSetColor((EmitterPort)this, value);
        }

        public IntPort ColorIdDeprecated
        {
            set => ChipBuilder.EmitterSetColorIdDeprecated((EmitterPort)this, value);
        }

        public BoolPort Looping
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetLooping_" + PortKey(), () => ChipBuilder.EmitterGetLooping((EmitterPort)this));
            set => ChipBuilder.EmitterSetLooping((EmitterPort)this, value);
        }

        public BoolPort Playing
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetPlaying_" + PortKey(), () => ChipBuilder.EmitterGetPlaying((EmitterPort)this));
        }

        public FloatPort Size
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetSize_" + PortKey(), () => ChipBuilder.EmitterGetSize((EmitterPort)this));
            set => ChipBuilder.EmitterSetSize((EmitterPort)this, value);
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetSpeed_" + PortKey(), () => ChipBuilder.EmitterGetSpeed((EmitterPort)this));
            set => ChipBuilder.EmitterSetSpeed((EmitterPort)this, value);
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

    public abstract class EquipmentSlotPortGen : AnyPort
    {
    }

    public abstract class ExplosionEmitterPortGen : AnyPort
    {
        public IntPort Damage
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetDamage_" + PortKey(), () => ChipBuilder.ExplosionEmitterGetDamage((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetDamage((ExplosionEmitterPort)this, value);
        }

        public ColorPort ExplosionColor
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionColor_" + PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionColor((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetExplosionColor((ExplosionEmitterPort)this, value);
        }

        public FloatPort ExplosionRadius
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionRadius_" + PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionRadius((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetExplosionRadius((ExplosionEmitterPort)this, value);
        }

        public PlayerPort FiringPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetFiringPlayer_" + PortKey(), () => ChipBuilder.ExplosionEmitterGetFiringPlayer((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetFiringPlayer((ExplosionEmitterPort)this, value);
        }

        public void Explode()
        {
            ChipBuilder.ExplosionEmitterExplode((ExplosionEmitterPort)this);
        }
    }

    public abstract class FogPortGen : AnyPort
    {
        public BoolPort RoomFogModifyR1(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomFogModifyR1((FogPort)this, BlendFinished);
        }

        public void RoomFogModifyR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomFogModifyR2((FogPort)this, BlendTime, BlendFinished);
        }

        public void RoomFogPlayerOverrideR2(PlayerPort Player, FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomFogPlayerOverrideR2((FogPort)this, Player, BlendTime, BlendFinished);
        }
    }

    public abstract class GrabberPortGen : AnyPort
    {
        public (BoolPort HasHeldObject, RecRoomObjectPort HeldObject) HeldObjectR2
        {
            get => CircuitBuilder.Singleton("RRCG_Grabber_GetHeldObjectR2_" + PortKey(), () => ChipBuilder.GrabberGetHeldObjectR2((GrabberPort)this));
        }

        public BoolPort PlayerCanStealFromGrabberR2
        {
            set => ChipBuilder.GrabberSetPlayerCanStealFromGrabberR2((GrabberPort)this, value);
        }

        public BoolPort GrabObjectR2(RecRoomObjectPort Object, BoolPort StealfromPlayer, BoolPort SnaptoGrabber)
        {
            return ChipBuilder.GrabberGrabObjectR2((GrabberPort)this, Object, StealfromPlayer, SnaptoGrabber);
        }

        public RecRoomObjectPort ReleaseR2()
        {
            return ChipBuilder.GrabberReleaseR2((GrabberPort)this);
        }
    }

    public abstract class GroundVehiclePortGen : AnyPort
    {
        public IntPort BoostFuel
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetBoostFuel_" + PortKey(), () => ChipBuilder.GroundVehicleGetBoostFuel((GroundVehiclePort)this));
        }

        public BoolPort DrivingEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetDrivingEnabled_" + PortKey(), () => ChipBuilder.GroundVehicleGetDrivingEnabled((GroundVehiclePort)this));
            set => ChipBuilder.GroundVehicleSetDrivingEnabled((GroundVehiclePort)this, value);
        }

        public FloatPort EngineTorqueMultiplier
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetEngineTorqueMultiplier_" + PortKey(), () => ChipBuilder.GroundVehicleGetEngineTorqueMultiplier((GroundVehiclePort)this));
            set => ChipBuilder.GroundVehicleSetEngineTorqueMultiplier((GroundVehiclePort)this, value);
        }

        public FloatPort WheelFrictionMultiplier
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetWheelFrictionMultiplier_" + PortKey(), () => ChipBuilder.GroundVehicleGetWheelFrictionMultiplier((GroundVehiclePort)this));
            set => ChipBuilder.GroundVehicleSetWheelFrictionMultiplier((GroundVehiclePort)this, value);
        }

        public void AddBoostFuel(IntPort Boostamount)
        {
            ChipBuilder.GroundVehicleAddBoostFuel((GroundVehiclePort)this, Boostamount);
        }

        public void ApplyBoost(AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleApplyBoost((GroundVehiclePort)this, Failure);
        }

        public PlayerPort GetSeatedPlayer(IntPort Seatindex)
        {
            return ChipBuilder.GroundVehicleGetSeatedPlayer((GroundVehiclePort)this, Seatindex);
        }

        public void SetSeatedPlayer(IntPort Seatindex, PlayerPort Player, AlternativeExec Failure)
        {
            ChipBuilder.GroundVehicleSetSeatedPlayer((GroundVehiclePort)this, Seatindex, Player, Failure);
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

    public abstract class GunHandlePortGen : AnyPort
    {
        public BoolPort ADSEnabled
        {
            set => ChipBuilder.GunHandleSetADSEnabled((GunHandlePort)this, value);
        }

        public ListPort<StringPort> AutoAimRolesDeprecated
        {
            set => ChipBuilder.GunHandleSetAutoAimRolesDeprecated((GunHandlePort)this, value);
        }

        public BoolPort ContinuousFire
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetContinuousFire_" + PortKey(), () => ChipBuilder.GunHandleGetContinuousFire((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetContinuousFire((GunHandlePort)this, value);
        }

        public IntPort CurrentAmmo
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetCurrentAmmo_" + PortKey(), () => ChipBuilder.GunHandleGetCurrentAmmo((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetCurrentAmmo((GunHandlePort)this, value);
        }

        public BoolPort IsReloading
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetIsReloading_" + PortKey(), () => ChipBuilder.GunHandleGetIsReloading((GunHandlePort)this));
        }

        public IntPort MaxAmmo
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetMaxAmmo_" + PortKey(), () => ChipBuilder.GunHandleGetMaxAmmo((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetMaxAmmo((GunHandlePort)this, value);
        }

        public FloatPort RateOfFire
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetRateOfFire_" + PortKey(), () => ChipBuilder.GunHandleGetRateOfFire((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetRateOfFire((GunHandlePort)this, value);
        }

        public FloatPort ReloadDuration
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetReloadDuration_" + PortKey(), () => ChipBuilder.GunHandleGetReloadDuration((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetReloadDuration((GunHandlePort)this, value);
        }

        public StringPort RemoveAutoAimRoleDeprecated
        {
            set => ChipBuilder.GunHandleRemoveAutoAimRoleDeprecated((GunHandlePort)this, value);
        }

        public BoolPort SupportsReload
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetSupportsReload_" + PortKey(), () => ChipBuilder.GunHandleGetSupportsReload((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetSupportsReload((GunHandlePort)this, value);
        }

        public void AddAutoAimRoleDeprecatedR1(StringPort Role)
        {
            ChipBuilder.GunHandleAddAutoAimRoleDeprecatedR1((GunHandlePort)this, Role);
        }

        public void ApplyRecoil(FloatPort AngleX, FloatPort AngleY, FloatPort Duration, FloatPort ReturnDuration)
        {
            ChipBuilder.GunHandleApplyRecoil((GunHandlePort)this, AngleX, AngleY, Duration, ReturnDuration);
        }

        public Vector3Port GetFiringDirection(RecRoomObjectPort Source)
        {
            return ChipBuilder.GunHandleGetFiringDirection((GunHandlePort)this, Source);
        }
    }

    public abstract class HandlePortGen : AnyPort
    {
        public StringPort ControlPrompt
        {
            get => CircuitBuilder.Singleton("RRCG_Handle_GetControlPrompt_" + PortKey(), () => ChipBuilder.HandleGetControlPrompt((HandlePort)this));
            set => ChipBuilder.HandleSetControlPrompt((HandlePort)this, value);
        }

        public ListPort<StringPort> PlayerFilterTagsR2
        {
            get => CircuitBuilder.Singleton("RRCG_Handle_GetPlayerFilterTagsR2_" + PortKey(), () => ChipBuilder.HandleGetPlayerFilterTagsR2((HandlePort)this));
            set => ChipBuilder.HandleSetPlayerFilterTagsR2((HandlePort)this, value);
        }

        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((HandlePort)this, Duration, Intensity);
        }
    }

    public abstract class HolotarProjectorPortGen : AnyPort
    {
        public FloatPort CurrentTime
        {
            get => CircuitBuilder.Singleton("RRCG_HolotarProjector_GetCurrentTime_" + PortKey(), () => ChipBuilder.HolotarProjectorGetCurrentTime((HolotarProjectorPort)this));
            set => ChipBuilder.HolotarProjectorSetCurrentTime((HolotarProjectorPort)this, value);
        }

        public FloatPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_HolotarProjector_GetVolume_" + PortKey(), () => ChipBuilder.HolotarProjectorGetVolume((HolotarProjectorPort)this));
            set => ChipBuilder.HolotarProjectorSetVolume((HolotarProjectorPort)this, value);
        }

        public void Pause()
        {
            ChipBuilder.HolotarProjectorPause((HolotarProjectorPort)this);
        }

        public void Play(HolotarRecordingPort Holotar)
        {
            ChipBuilder.HolotarProjectorPlay((HolotarProjectorPort)this, Holotar);
        }

        public void Resume()
        {
            ChipBuilder.HolotarProjectorResume((HolotarProjectorPort)this);
        }

        public void Stop()
        {
            ChipBuilder.HolotarProjectorStop((HolotarProjectorPort)this);
        }
    }

    public abstract class HolotarRecordingPortGen : AnyPort
    {
    }

    public abstract class HUDConstantPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetColor_" + PortKey(), () => ChipBuilder.GetHUDElementColor((HUDConstantPort)this));
            set => ChipBuilder.SetHUDElementColor((HUDConstantPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetEnabled_" + PortKey(), () => ChipBuilder.GetHUDElementEnabled((HUDConstantPort)this));
            set => ChipBuilder.SetHUDElementEnabled((HUDConstantPort)this, value);
        }

        public StringPort Label
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetLabel_" + PortKey(), () => ChipBuilder.GetHUDElementLabel((HUDConstantPort)this));
            set => ChipBuilder.SetHUDElementLabel((HUDConstantPort)this, value);
        }

        public BoolPort LabelEnabled
        {
            set => ChipBuilder.SetHUDElementLabelEnabled((HUDConstantPort)this, value);
        }

        public IntPort MaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetMaxValue_" + PortKey(), () => ChipBuilder.GetHUDElementMaxValue((HUDConstantPort)this));
            set => ChipBuilder.SetHUDElementMaxValue((HUDConstantPort)this, value);
        }

        public IntPort Value
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetValue_" + PortKey(), () => ChipBuilder.GetHUDElementValue((HUDConstantPort)this));
            set => ChipBuilder.SetHUDElementValue((HUDConstantPort)this, value);
        }

        public BoolPort ValueTextEnabled
        {
            set => ChipBuilder.SetHUDElementValueTextEnabled((HUDConstantPort)this, value);
        }

        public void SetContent()
        {
            ChipBuilder.SetHUDElementContent((HUDConstantPort)this);
        }
    }

    public abstract class HUDElementPortGen : AnyPort
    {
    }

    public abstract class InteractionVolumePortGen : AnyPort
    {
        public FloatPort HoldTime
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetHoldTime_" + PortKey(), () => ChipBuilder.InteractionVolumeGetHoldTime((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetHoldTime((InteractionVolumePort)this, value);
        }

        public StringPort InteractionPrompt
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetInteractionPrompt_" + PortKey(), () => ChipBuilder.InteractionVolumeGetInteractionPrompt((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetInteractionPrompt((InteractionVolumePort)this, value);
        }

        public BoolPort IsLocked
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetIsLocked_" + PortKey(), () => ChipBuilder.InteractionVolumeGetIsLocked((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetLocked((InteractionVolumePort)this, value);
        }

        public FloatPort NormalizedHoldProgress
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetNormalizedHoldProgress_" + PortKey(), () => ChipBuilder.InteractionVolumeGetNormalizedHoldProgress((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetNormalizedHoldProgress((InteractionVolumePort)this, value);
        }
    }

    public abstract class InventoryItemPortGen : AnyPort
    {
        public (StringPort Name, StringPort Description, BoolPort SupportsUseAction, RecNetImagePort Image) DefinitionR2
        {
            get => CircuitBuilder.Singleton("RRCG_InventoryItem_GetDefinitionR2_" + PortKey(), () => ChipBuilder.InventoryItemGetDefinitionR2((InventoryItemPort)this));
        }

        public RecNetImagePort ImageR2
        {
            get => CircuitBuilder.Singleton("RRCG_InventoryItem_GetImageR2_" + PortKey(), () => ChipBuilder.InventoryItemGetImageR2((InventoryItemPort)this));
        }

        public (BoolPort Success, IntPort TotalCount) AddR2(PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            return ChipBuilder.InventoryItemAddR2((InventoryItemPort)this, Player, Quantity, Complete);
        }

        public IntPort GetCountR2(PlayerPort Player, AlternativeExec<IntPort> Complete)
        {
            return ChipBuilder.InventoryItemGetCountR2((InventoryItemPort)this, Player, Complete);
        }

        public (BoolPort Success, IntPort TotalCount) RemoveR2(PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            return ChipBuilder.InventoryItemRemoveR2((InventoryItemPort)this, Player, Quantity, Complete);
        }

        public void UseR2()
        {
            ChipBuilder.InventoryItemUseR2((InventoryItemPort)this);
        }
    }

    public abstract class InvisibleCollisionPortGen : AnyPort
    {
        public BoolPort BlocksPlayers
        {
            get => CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetBlocksPlayers_" + PortKey(), () => ChipBuilder.InvisibleCollisionGetBlocksPlayers((InvisibleCollisionPort)this));
            set => ChipBuilder.InvisibleCollisionSetBlocksPlayers((InvisibleCollisionPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetEnabled_" + PortKey(), () => ChipBuilder.InvisibleCollisionGetEnabled((InvisibleCollisionPort)this));
            set => ChipBuilder.InvisibleCollisionSetEnabled((InvisibleCollisionPort)this, value);
        }
    }

    public abstract class LaserPointerPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetColor_" + PortKey(), () => ChipBuilder.LaserPointerGetColor((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetColor((LaserPointerPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetEnabled_" + PortKey(), () => ChipBuilder.LaserPointerGetEnabled((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetEnabled((LaserPointerPort)this, value);
        }

        public FloatPort Length
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetLength_" + PortKey(), () => ChipBuilder.LaserPointerGetLength((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetLength((LaserPointerPort)this, value);
        }
    }

    public abstract class LeaderboardProjectorPortGen : AnyPort
    {
        public BoolPort LeaderboardGetProjectorEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_LeaderboardProjector_LeaderboardGetProjectorEnabled_" + PortKey(), () => ChipBuilder.LeaderboardGetProjectorEnabled((LeaderboardProjectorPort)this));
        }

        public BoolPort LeaderboardSetProjectorEnabled
        {
            set => ChipBuilder.LeaderboardSetProjectorEnabled((LeaderboardProjectorPort)this, value);
        }
    }

    public abstract class LightPortGen : AnyPort
    {
        public FloatPort Angle
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetAngle_" + PortKey(), () => ChipBuilder.LightGetAngle((LightPort)this));
            set => ChipBuilder.LightSetAngle((LightPort)this, value);
        }

        public IntPort AngleDeprecated
        {
            set => ChipBuilder.LightSetAngleDeprecated((LightPort)this, value);
        }

        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetColor_" + PortKey(), () => ChipBuilder.LightGetColor((LightPort)this));
            set => ChipBuilder.LightSetColor((LightPort)this, value);
        }

        public IntPort ColorIdDeprecated
        {
            set => ChipBuilder.LightSetColorIdDeprecated((LightPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetEnabled_" + PortKey(), () => ChipBuilder.LightGetEnabled((LightPort)this));
        }

        public FloatPort Intensity
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetIntensity_" + PortKey(), () => ChipBuilder.LightGetIntensity((LightPort)this));
            set => ChipBuilder.LightSetIntensity((LightPort)this, value);
        }

        public IntPort IntensityDeprecated
        {
            set => ChipBuilder.LightSetIntensityDeprecated((LightPort)this, value);
        }

        public FloatPort Range
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetRange_" + PortKey(), () => ChipBuilder.LightGetRange((LightPort)this));
            set => ChipBuilder.LightSetRange((LightPort)this, value);
        }

        public IntPort RangeDeprecated
        {
            set => ChipBuilder.LightSetRangeDeprecated((LightPort)this, value);
        }

        public FloatPort Softness
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetSoftness_" + PortKey(), () => ChipBuilder.LightGetSoftness((LightPort)this));
            set => ChipBuilder.LightSetSoftness((LightPort)this, value);
        }

        public FloatPort SpecularContribution
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetSpecularContribution_" + PortKey(), () => ChipBuilder.LightGetSpecularContribution((LightPort)this));
            set => ChipBuilder.LightSetSpecularContribution((LightPort)this, value);
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

    public abstract class MotionTrailPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetColor_" + PortKey(), () => ChipBuilder.TrailGetColor((MotionTrailPort)this));
            set => ChipBuilder.TrailSetColor((MotionTrailPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetEnabled_" + PortKey(), () => ChipBuilder.TrailGetEnabled((MotionTrailPort)this));
            set => ChipBuilder.TrailSetEnabled((MotionTrailPort)this, value);
        }

        public FloatPort Lifetime
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetLifetime_" + PortKey(), () => ChipBuilder.TrailGetLifetime((MotionTrailPort)this));
            set => ChipBuilder.TrailSetLifetime((MotionTrailPort)this, value);
        }

        public FloatPort Opacity
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetOpacity_" + PortKey(), () => ChipBuilder.TrailGetOpacity((MotionTrailPort)this));
            set => ChipBuilder.TrailSetOpacity((MotionTrailPort)this, value);
        }
    }

    public abstract class ObjectiveMarkerPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetColor_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetColor((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetColor((ObjectiveMarkerPort)this, value);
        }

        public FloatPort CurrentDistance
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetCurrentDistance_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetCurrentDistance((ObjectiveMarkerPort)this));
        }

        public BoolPort DistanceEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetDistanceEnabled_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetDistanceEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetDistanceEnabled((ObjectiveMarkerPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetEnabled_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetEnabled((ObjectiveMarkerPort)this, value);
        }

        public FloatPort FadeThreshold
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetFadeThreshold_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetFadeThreshold((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetFadeThreshold((ObjectiveMarkerPort)this, value);
        }

        public StringPort Label
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabel_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabel((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetLabel((ObjectiveMarkerPort)this, value);
        }

        public BoolPort LabelEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabelEnabled_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabelEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetLabelEnabled((ObjectiveMarkerPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetPosition_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetPosition((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetPosition((ObjectiveMarkerPort)this, value);
        }

        public RecRoomObjectPort TargetObject
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetObject_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetObject((ObjectiveMarkerPort)this));
        }

        public PlayerPort TargetPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetPlayer_" + PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetPlayer((ObjectiveMarkerPort)this));
        }

        public void AttachToPlayerOrObject(PlayerPort PlayerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, PlayerOrObject);
        }

        public void AttachToPlayerOrObject(RecRoomObjectPort PlayerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, PlayerOrObject);
        }
    }

    public abstract class PathfinderPortGen : AnyPort
    {
        public BoolPort EnableGroundClampingR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetEnableGroundClampingR2_" + PortKey(), () => ChipBuilder.PathfinderGetEnableGroundClampingR2((PathfinderPort)this));
        }

        public BoolPort GroundClampingR2
        {
            set => ChipBuilder.PathfinderSetGroundClampingR2((PathfinderPort)this, value);
        }

        public FloatPort MaxAccelerationR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetMaxAccelerationR2_" + PortKey(), () => ChipBuilder.PathfinderGetMaxAccelerationR2((PathfinderPort)this));
            set => ChipBuilder.PathfinderSetMaxAccelerationR2((PathfinderPort)this, value);
        }

        public FloatPort MaxAngularSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetMaxAngularSpeedR2_" + PortKey(), () => ChipBuilder.PathfinderGetMaxAngularSpeedR2((PathfinderPort)this));
            set => ChipBuilder.PathfinderSetMaxAngularSpeedR2((PathfinderPort)this, value);
        }

        public FloatPort MaxLinearSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetMaxLinearSpeedR2_" + PortKey(), () => ChipBuilder.PathfinderGetMaxLinearSpeedR2((PathfinderPort)this));
            set => ChipBuilder.PathfinderSetMaxLinearSpeedR2((PathfinderPort)this, value);
        }

        public (BoolPort IsPathing, BoolPort HasArrived, BoolPort WithinSlowdownDistance) PathingStateR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetPathingStateR2_" + PortKey(), () => ChipBuilder.PathfinderGetPathingStateR2((PathfinderPort)this));
        }

        public (Vector3Port TargetPosition, FloatPort SlowdownDistance, FloatPort ArrivalDistance) PathingTargetR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetPathingTargetR2_" + PortKey(), () => ChipBuilder.PathfinderGetPathingTargetR2((PathfinderPort)this));
        }

        public (BoolPort IsRotating, BoolPort HasArrived) RotationStateR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetRotationStateR2_" + PortKey(), () => ChipBuilder.PathfinderGetRotationStateR2((PathfinderPort)this));
        }

        public (Vector3Port TargetDirection, FloatPort SlowdownAngle, FloatPort ArrivalAngle) RotationTargetR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetRotationTargetR2_" + PortKey(), () => ChipBuilder.PathfinderGetRotationTargetR2((PathfinderPort)this));
        }

        public ListPort<StringPort> TagsToIgnoreR2
        {
            get => CircuitBuilder.Singleton("RRCG_Pathfinder_GetTagsToIgnoreR2_" + PortKey(), () => ChipBuilder.PathfinderGetTagsToIgnoreR2((PathfinderPort)this));
            set => ChipBuilder.PathfinderSetTagsToIgnoreR2((PathfinderPort)this, value);
        }

        public void StartPathingToPositionR2(Vector3Port TargetPosition, FloatPort SlowdownDistance, FloatPort ArrivalDistance)
        {
            ChipBuilder.PathfinderStartPathingToPositionR2((PathfinderPort)this, TargetPosition, SlowdownDistance, ArrivalDistance);
        }

        public void StartRotatingToDirectionR2(Vector3Port TargetDirection, FloatPort SlowdownAngle, FloatPort ArrivalAngle)
        {
            ChipBuilder.PathfinderStartRotatingToDirectionR2((PathfinderPort)this, TargetDirection, SlowdownAngle, ArrivalAngle);
        }

        public void StopPathingR2()
        {
            ChipBuilder.PathfinderStopPathingR2((PathfinderPort)this);
        }

        public void StopRotatingR2()
        {
            ChipBuilder.PathfinderStopRotatingR2((PathfinderPort)this);
        }
    }

    public abstract class PatrolPointPortGen : AnyPort
    {
    }

    public abstract class PistonPortGen : AnyPort
    {
        public FloatPort Acceleration
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetAcceleration_" + PortKey(), () => ChipBuilder.PistonGetAcceleration((PistonPort)this));
            set => ChipBuilder.PistonSetAcceleration((PistonPort)this, value);
        }

        public FloatPort Distance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetDistance_" + PortKey(), () => ChipBuilder.PistonGetDistance((PistonPort)this));
            set => ChipBuilder.PistonSetDistance((PistonPort)this, value);
        }

        public FloatPort MaxDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetMaxDistance_" + PortKey(), () => ChipBuilder.PistonGetMaxDistance((PistonPort)this));
            set => ChipBuilder.PistonSetMaxDistance((PistonPort)this, value);
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetSpeed_" + PortKey(), () => ChipBuilder.PistonGetSpeed((PistonPort)this));
            set => ChipBuilder.PistonSetSpeed((PistonPort)this, value);
        }

        public FloatPort TargetDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetTargetDistance_" + PortKey(), () => ChipBuilder.PistonGetTargetDistance((PistonPort)this));
            set => ChipBuilder.PistonSetTargetDistance((PistonPort)this, value);
        }
    }

    public abstract class PlayerPortGen : AnyPort
    {
        public StringPort AccountName
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetAccountName_" + PortKey(), () => ChipBuilder.GetPlayerAccountName((PlayerPort)this));
        }

        public StringPort AddAimAssistTag
        {
            set => ChipBuilder.PlayerAddAimAssistTag((PlayerPort)this, value);
        }

        public ListPort<StringPort> AimAssistTags
        {
            set => ChipBuilder.PlayerSetAimAssistTags((PlayerPort)this, value);
        }

        public FloatPort AirControlPercentageR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetAirControlPercentageR2_" + PortKey(), () => ChipBuilder.PlayerGetAirControlPercentageR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetAirControlPercentageR2((PlayerPort)this, value);
        }

        public QuaternionPort BodyOrientation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_BodyOrientation_" + PortKey(), () => ChipBuilder.PlayerBodyOrientation((PlayerPort)this));
        }

        public Vector3Port BodyPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_BodyPosition_" + PortKey(), () => ChipBuilder.PlayerBodyPosition((PlayerPort)this));
        }

        public BoolPort CanFlyR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCanFlyR2_" + PortKey(), () => ChipBuilder.PlayerGetCanFlyR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetCanFlyR2((PlayerPort)this, value);
        }

        public BoolPort CanTeleportR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCanTeleportR2_" + PortKey(), () => ChipBuilder.PlayerGetCanTeleportR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetCanTeleportR2((PlayerPort)this, value);
        }

        public BoolPort CanWallClimbR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCanWallClimbR2_" + PortKey(), () => ChipBuilder.PlayerGetCanWallClimbR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetCanWallClimbR2((PlayerPort)this, value);
        }

        public Vector3Port CombatantGetGroundPositionR1
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetGroundPositionR1_" + PortKey(), () => ChipBuilder.CombatantGetGroundPositionR1((PlayerPort)this));
        }

        public BoolPort CombatantGetIsAliveR1
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetIsAliveR1_" + PortKey(), () => ChipBuilder.CombatantGetIsAliveR1((PlayerPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocityR1
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetVelocityR1_" + PortKey(), () => ChipBuilder.CombatantGetVelocityR1((PlayerPort)this));
        }

        public IntPort CombatantSetMaxHealthR1
        {
            set => ChipBuilder.CombatantSetMaxHealthR1((PlayerPort)this, value);
        }

        public CostumePort Costume
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCostume_" + PortKey(), () => ChipBuilder.PlayerGetCostume((PlayerPort)this));
        }

        public BoolPort CrouchInputEnabledR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCrouchInputEnabledR2_" + PortKey(), () => ChipBuilder.PlayerGetCrouchInputEnabledR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetCrouchInputEnabledR2((PlayerPort)this, value);
        }

        public FloatPort CrouchSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCrouchSpeedR2_" + PortKey(), () => ChipBuilder.PlayerGetCrouchSpeedR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetCrouchSpeedR2((PlayerPort)this, value);
        }

        public BoolPort DominantHandIsRight
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetDominantHandIsRight_" + PortKey(), () => ChipBuilder.PlayerGetDominantHandIsRight((PlayerPort)this));
        }

        public (RecRoomObjectPort DominantHandObject, RecRoomObjectPort OffHandObject, RecRoomObjectPort LeftHipHolsterObject, RecRoomObjectPort RightHipHolsterObject, RecRoomObjectPort ShoulderHolsterObject) EquippedObjects
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetEquippedObjects_" + PortKey(), () => ChipBuilder.PlayerGetEquippedObjects((PlayerPort)this));
        }

        public StringPort FirstTag
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetFirstTag_" + PortKey(), () => ChipBuilder.GetFirstTag((PlayerPort)this));
        }

        public BoolPort ForceManualSprintR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceManualSprintR2_" + PortKey(), () => ChipBuilder.PlayerGetForceManualSprintR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceManualSprintR2((PlayerPort)this, value);
        }

        public BoolPort ForceVirtualHeightModeR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceVirtualHeightModeR2_" + PortKey(), () => ChipBuilder.PlayerGetForceVirtualHeightModeR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceVirtualHeightModeR2((PlayerPort)this, value);
        }

        public BoolPort ForceVRWalkR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceVRWalkR2_" + PortKey(), () => ChipBuilder.PlayerGetForceVRWalkR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceVRWalkR2((PlayerPort)this, value);
        }

        public Vector3Port ForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForwardVector_" + PortKey(), () => ChipBuilder.GetForwardVector((PlayerPort)this));
        }

        public Vector3Port ForwardVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForwardVectorDeprecated_" + PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((PlayerPort)this));
        }

        public AlternativeExec<(BoolPort Success, IntPort TotalBalance)> GetCurrencyBalanceDeprecatedR1
        {
            set => ChipBuilder.GetCurrencyBalanceDeprecatedR1((PlayerPort)this, value);
        }

        public AnyPort GoToEvent
        {
            set => ChipBuilder.GoToEvent((PlayerPort)this, value);
        }

        public DestinationRoomPort GoToRoom
        {
            set => ChipBuilder.GoToRoom((PlayerPort)this, value);
        }

        public Vector3Port HeadForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadForwardVector_" + PortKey(), () => ChipBuilder.PlayerHeadForwardVector((PlayerPort)this));
        }

        public FloatPort HeadHeight
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadHeight_" + PortKey(), () => ChipBuilder.PlayerHeadHeight((PlayerPort)this));
        }

        public QuaternionPort HeadOrientation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadOrientation_" + PortKey(), () => ChipBuilder.PlayerHeadOrientation((PlayerPort)this));
        }

        public Vector3Port HeadPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadPosition_" + PortKey(), () => ChipBuilder.PlayerHeadPosition((PlayerPort)this));
        }

        public Vector3Port HeadUpVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadUpVector_" + PortKey(), () => ChipBuilder.PlayerHeadUpVector((PlayerPort)this));
        }

        public Vector3Port HeadVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadVelocity_" + PortKey(), () => ChipBuilder.PlayerHeadVelocity((PlayerPort)this));
        }

        public BoolPort IsClambering
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsClambering_" + PortKey(), () => ChipBuilder.PlayerGetIsClambering((PlayerPort)this));
        }

        public BoolPort IsCrouching
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsCrouching_" + PortKey(), () => ChipBuilder.PlayerGetIsCrouching((PlayerPort)this));
        }

        public BoolPort IsCustomFootstepAudioActive
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsCustomFootstepAudioActive_" + PortKey(), () => ChipBuilder.PlayerGetIsCustomFootstepAudioActive((PlayerPort)this));
        }

        public BoolPort IsFlying
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsFlying_" + PortKey(), () => ChipBuilder.PlayerGetIsFlying((PlayerPort)this));
        }

        public (BoolPort IsGrounded, FloatPort TimeSinceLastGrounded, RecRoomObjectPort SurfaceObject, Vector3Port SurfaceNormal) IsGrounded
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsGrounded_" + PortKey(), () => ChipBuilder.PlayerGetIsGrounded((PlayerPort)this));
        }

        public BoolPort IsHoldingMakerPen
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsHoldingMakerPen_" + PortKey(), () => ChipBuilder.PlayerIsHoldingMakerPen((PlayerPort)this));
        }

        public BoolPort IsInParty
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsInParty_" + PortKey(), () => ChipBuilder.PlayerIsInParty((PlayerPort)this));
        }

        public (BoolPort IsJumpingOrFalling, RecRoomObjectPort ContactSurface) IsJumpingOrFalling
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsJumpingOrFalling_" + PortKey(), () => ChipBuilder.PlayerGetIsJumpingOrFalling((PlayerPort)this));
        }

        public BoolPort IsLocal
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsLocal_" + PortKey(), () => ChipBuilder.PlayerGetIsLocal((PlayerPort)this));
        }

        public BoolPort IsProne
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsProne_" + PortKey(), () => ChipBuilder.PlayerGetIsProne((PlayerPort)this));
        }

        public BoolPort IsRoomContributor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsRoomContributor_" + PortKey(), () => ChipBuilder.PlayerGetIsRoomContributor((PlayerPort)this));
        }

        public BoolPort IsRoomHost
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsRoomHost_" + PortKey(), () => ChipBuilder.PlayerGetIsRoomHost((PlayerPort)this));
        }

        public BoolPort IsRoomMod
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsRoomMod_" + PortKey(), () => ChipBuilder.PlayerGetIsRoomMod((PlayerPort)this));
        }

        public BoolPort IsRoomOwner
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsRoomOwner_" + PortKey(), () => ChipBuilder.PlayerGetIsRoomOwner((PlayerPort)this));
        }

        public BoolPort IsSliding
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsSliding_" + PortKey(), () => ChipBuilder.PlayerGetIsSliding((PlayerPort)this));
        }

        public BoolPort IsSprinting
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsSprinting_" + PortKey(), () => ChipBuilder.PlayerGetIsSprinting((PlayerPort)this));
        }

        public BoolPort IsWallClimbing
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsWallClimbing_" + PortKey(), () => ChipBuilder.PlayerGetIsWallClimbing((PlayerPort)this));
        }

        public BoolPort IsWallRunning
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsWallRunning_" + PortKey(), () => ChipBuilder.PlayerGetIsWallRunning((PlayerPort)this));
        }

        public FloatPort JumpHeightR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetJumpHeightR2_" + PortKey(), () => ChipBuilder.PlayerGetJumpHeightR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetJumpHeightR2((PlayerPort)this, value);
        }

        public BoolPort JumpInputEnabledR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetJumpInputEnabledR2_" + PortKey(), () => ChipBuilder.PlayerGetJumpInputEnabledR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetJumpInputEnabledR2((PlayerPort)this, value);
        }

        public Vector3Port LeftHandFingerDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandFingerDirection_" + PortKey(), () => ChipBuilder.PlayerLeftHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandPosition_" + PortKey(), () => ChipBuilder.PlayerLeftHandPosition((PlayerPort)this));
        }

        public QuaternionPort LeftHandRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandRotation_" + PortKey(), () => ChipBuilder.PlayerLeftHandRotation((PlayerPort)this));
        }

        public Vector3Port LeftHandThumbDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandThumbDirection_" + PortKey(), () => ChipBuilder.PlayerLeftHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandVelocity_" + PortKey(), () => ChipBuilder.PlayerLeftHandVelocity((PlayerPort)this));
        }

        public FloatPort LocalPlayerOverridePlayerVoiceRolloffR2
        {
            set => ChipBuilder.LocalPlayerOverridePlayerVoiceRolloffR2((PlayerPort)this, value);
        }

        public ColorPort NameColor
        {
            set => ChipBuilder.PlayerSetNameColor((PlayerPort)this, value);
        }

        public FloatPort NormalizedSteeringSpeedDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetNormalizedSteeringSpeedDeprecated_" + PortKey(), () => ChipBuilder.PlayerGetNormalizedSteeringSpeedDeprecated((PlayerPort)this));
        }

        public ListPort<PlayerPort> PartyOfPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPartyOfPlayer_" + PortKey(), () => ChipBuilder.GetPartyOfPlayer((PlayerPort)this));
        }

        public Vector3Port PhysicsVelocityR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPhysicsVelocityR2_" + PortKey(), () => ChipBuilder.PlayerGetPhysicsVelocityR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetPhysicsVelocityR2((PlayerPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPosition_" + PortKey(), () => ChipBuilder.GetPosition((PlayerPort)this));
            set => ChipBuilder.SetPosition((PlayerPort)this, value);
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPositionDeprecated_" + PortKey(), () => ChipBuilder.GetPositionDeprecated((PlayerPort)this));
        }

        public RecNetImagePort ProfileImage
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetProfileImage_" + PortKey(), () => ChipBuilder.PlayerGetProfileImage((PlayerPort)this));
        }

        public FloatPort ProneSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetProneSpeedR2_" + PortKey(), () => ChipBuilder.PlayerGetProneSpeedR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetProneSpeedR2((PlayerPort)this, value);
        }

        public IntPort RadioChannel
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRadioChannel_" + PortKey(), () => ChipBuilder.PlayerGetRadioChannel((PlayerPort)this));
            set => ChipBuilder.PlayerSetRadioChannel((PlayerPort)this, value);
        }

        public StringPort RemoveAimAssistTag
        {
            set => ChipBuilder.PlayerRemoveAimAssistTag((PlayerPort)this, value);
        }

        public Vector3Port RightHandFingerDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandFingerDirection_" + PortKey(), () => ChipBuilder.PlayerRightHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port RightHandPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandPosition_" + PortKey(), () => ChipBuilder.PlayerRightHandPosition((PlayerPort)this));
        }

        public QuaternionPort RightHandRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandRotation_" + PortKey(), () => ChipBuilder.PlayerRightHandRotation((PlayerPort)this));
        }

        public Vector3Port RightHandThumbDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandThumbDirection_" + PortKey(), () => ChipBuilder.PlayerRightHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port RightHandVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandVelocity_" + PortKey(), () => ChipBuilder.PlayerRightHandVelocity((PlayerPort)this));
        }

        public IntPort RoomIndex
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRoomIndex_" + PortKey(), () => ChipBuilder.PlayerGetRoomIndex((PlayerPort)this));
        }

        public IntPort RoomLevel
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRoomLevel_" + PortKey(), () => ChipBuilder.PlayerGetRoomLevel((PlayerPort)this));
        }

        public QuaternionPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRotation_" + PortKey(), () => ChipBuilder.GetRotation((PlayerPort)this));
        }

        public QuaternionPort RotationDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRotationDeprecated_" + PortKey(), () => ChipBuilder.GetRotationDeprecated((PlayerPort)this));
        }

        public StringPort SeasonLeagueNameDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSeasonLeagueNameDeprecated_" + PortKey(), () => ChipBuilder.GetPlayerSeasonLeagueNameDeprecated((PlayerPort)this));
        }

        public SeatPort Seat
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSeat_" + PortKey(), () => ChipBuilder.PlayerGetSeat((PlayerPort)this));
        }

        public BoolPort ShareCameraGetIsSpawned
        {
            get => CircuitBuilder.Singleton("RRCG_Player_ShareCameraGetIsSpawned_" + PortKey(), () => ChipBuilder.ShareCameraGetIsSpawned((PlayerPort)this));
        }

        public FloatPort SlideSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSlideSpeedR2_" + PortKey(), () => ChipBuilder.PlayerGetSlideSpeedR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetSlideSpeedR2((PlayerPort)this, value);
        }

        public BoolPort SprintInputEnabledR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSprintInputEnabledR2_" + PortKey(), () => ChipBuilder.PlayerGetSprintInputEnabledR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetSprintInputEnabledR2((PlayerPort)this, value);
        }

        public FloatPort SprintSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSprintSpeedR2_" + PortKey(), () => ChipBuilder.PlayerGetSprintSpeedR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetSprintSpeedR2((PlayerPort)this, value);
        }

        public Vector3Port SteeringDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSteeringDirection_" + PortKey(), () => ChipBuilder.PlayerGetSteeringDirection((PlayerPort)this));
        }

        public BoolPort SteeringInputEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSteeringInputEnabled_" + PortKey(), () => ChipBuilder.PlayerGetSteeringInputEnabled((PlayerPort)this));
        }

        public BoolPort SteeringInputEnabledR2
        {
            set => ChipBuilder.PlayerSetSteeringInputEnabledR2((PlayerPort)this, value);
        }

        public FloatPort SteeringSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSteeringSpeed_" + PortKey(), () => ChipBuilder.PlayerGetSteeringSpeed((PlayerPort)this));
        }

        public Vector3Port SteeringVelocityR2
        {
            set => ChipBuilder.PlayerSetSteeringVelocityR2((PlayerPort)this, value);
        }

        public (BoolPort Result, IntPort SecondsUntilEnabled) SubscribesToRoomOwnerDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_SubscribesToRoomOwnerDeprecated_" + PortKey(), () => ChipBuilder.PlayerSubscribesToRoomOwnerDeprecated((PlayerPort)this));
        }

        public ListPort<StringPort> Tags
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTags_" + PortKey(), () => ChipBuilder.GetTags((PlayerPort)this));
        }

        public FloatPort TeleportDelayR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTeleportDelayR2_" + PortKey(), () => ChipBuilder.PlayerGetTeleportDelayR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetTeleportDelayR2((PlayerPort)this, value);
        }

        public FloatPort TeleportDistanceR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTeleportDistanceR2_" + PortKey(), () => ChipBuilder.PlayerGetTeleportDistanceR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetTeleportDistanceR2((PlayerPort)this, value);
        }

        public IntPort TimeZone
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTimeZone_" + PortKey(), () => ChipBuilder.PlayerGetTimeZone((PlayerPort)this));
        }

        public CombatantPort ToCombatantR1
        {
            get => CircuitBuilder.Singleton("RRCG_Player_ToCombatantR1_" + PortKey(), () => ChipBuilder.ToCombatantR1((PlayerPort)this));
        }

        public RecRoomObjectPort UnequipFromPlayer
        {
            set => ChipBuilder.UnequipFromPlayer((PlayerPort)this, value);
        }

        public Vector3Port UpVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetUpVector_" + PortKey(), () => ChipBuilder.GetUpVector((PlayerPort)this));
        }

        public Vector3Port UpVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetUpVectorDeprecated_" + PortKey(), () => ChipBuilder.GetUpVectorDeprecated((PlayerPort)this));
        }

        public Vector3Port Velocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVelocity_" + PortKey(), () => ChipBuilder.GetVelocity((PlayerPort)this));
        }

        public Vector3Port VelocityDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVelocityDeprecated_" + PortKey(), () => ChipBuilder.GetVelocityDeprecated((PlayerPort)this));
        }

        public FloatPort VoiceRolloffDistanceR2
        {
            set => ChipBuilder.PlayerSetVoiceRolloffDistanceR2((PlayerPort)this, value);
        }

        public FloatPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVolume_" + PortKey(), () => ChipBuilder.PlayerGetVolume((PlayerPort)this));
        }

        public FloatPort WalkSpeedR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWalkSpeedR2_" + PortKey(), () => ChipBuilder.PlayerGetWalkSpeedR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetWalkSpeedR2((PlayerPort)this, value);
        }

        public BoolPort WallRunEnabledR2
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWallRunEnabledR2_" + PortKey(), () => ChipBuilder.PlayerGetWallRunEnabledR2((PlayerPort)this));
            set => ChipBuilder.PlayerSetWallRunEnabledR2((PlayerPort)this, value);
        }

        public BoolPort WorldUIEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIEnabled_" + PortKey(), () => ChipBuilder.GetPlayerWorldUIEnabled((PlayerPort)this));
        }

        public ColorPort WorldUIPrimaryBarColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarColor_" + PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarColor((PlayerPort)this, value);
        }

        public BoolPort WorldUIPrimaryBarEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarEnabled_" + PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this, value);
        }

        public IntPort WorldUIPrimaryBarMaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarMaxValue_" + PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this, value);
        }

        public IntPort WorldUIPrimaryBarValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarValue_" + PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarValue((PlayerPort)this, value);
        }

        public ColorPort WorldUISecondaryBarColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarColor_" + PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarColor((PlayerPort)this, value);
        }

        public BoolPort WorldUISecondaryBarEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarEnabled_" + PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarEnabled((PlayerPort)this, value);
        }

        public IntPort WorldUISecondaryBarMaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarMaxValue_" + PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this, value);
        }

        public IntPort WorldUISecondaryBarValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarValue_" + PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarValue((PlayerPort)this, value);
        }

        public ColorPort WorldUITextColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextColor_" + PortKey(), () => ChipBuilder.GetPlayerWorldUITextColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextColor((PlayerPort)this, value);
        }

        public BoolPort WorldUITextEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextEnabled_" + PortKey(), () => ChipBuilder.GetPlayerWorldUITextEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextEnabled((PlayerPort)this, value);
        }

        public StringPort WorldUITextValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextValue_" + PortKey(), () => ChipBuilder.GetPlayerWorldUITextValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextValue((PlayerPort)this, value);
        }

        public IntPort XP
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetXP_" + PortKey(), () => ChipBuilder.PlayerGetXP((PlayerPort)this));
        }

        public void AddTag(StringPort Tag)
        {
            ChipBuilder.AddTag((PlayerPort)this, Tag);
        }

        public void AddTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.AddTags((PlayerPort)this, Tags);
        }

        public (BoolPort Success, IntPort TotalBalance) AwardCurrencyDeprecatedR1(IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrencyDeprecatedR1((PlayerPort)this, Amount, OnAwardCurrencyComplete);
        }

        public void ClearPlayerVignette()
        {
            ChipBuilder.ClearPlayerVignette((PlayerPort)this);
        }

        public void ClearPlayerWorldUI()
        {
            ChipBuilder.ClearPlayerWorldUI((PlayerPort)this);
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealthR1()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetHealthR1_" + PortKey(), () => ChipBuilder.CombatantGetHealthR1((PlayerPort)this));
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, AIPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, CombatantPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantReceiveDamageR1(IntPort Damage, BoolPort IgnoreShield, PlayerPort DamageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, Damage, IgnoreShield, DamageSource);
        }

        public void CombatantSetHealthR1(IntPort Health)
        {
            ChipBuilder.CombatantSetHealthR1((PlayerPort)this, Health);
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

        public BoolPort EquipShareCamera(BoolPort ForceEquip)
        {
            return ChipBuilder.EquipShareCamera((PlayerPort)this, ForceEquip);
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

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((PlayerPort)this, ReferenceObject);
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

        public void IfPlayerHasRoleR1(StringPort Role, AlternativeExec DoesNotHaveRole)
        {
            ChipBuilder.IfPlayerHasRoleR1((PlayerPort)this, Role, DoesNotHaveRole);
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

        public void LocalPlayerClearPlayerVoiceRolloffOverrideR2()
        {
            ChipBuilder.LocalPlayerClearPlayerVoiceRolloffOverrideR2((PlayerPort)this);
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

        public void AddRoleR1(StringPort Value)
        {
            ChipBuilder.PlayerAddRoleR1((PlayerPort)this, Value);
        }

        public BoolPort AwardXP(IntPort Amount, AlternativeExec<BoolPort> OnAwardComplete)
        {
            return ChipBuilder.PlayerAwardXP((PlayerPort)this, Amount, OnAwardComplete);
        }

        public void ClearCurrentSubtitle()
        {
            ChipBuilder.PlayerClearCurrentSubtitle((PlayerPort)this);
        }

        public BoolPort EquipInventoryItemR2(InventoryItemPort InventoryItem, EquipmentSlotPort InventoryEquipmentSlot, AlternativeExec<BoolPort> OnEquipComplete)
        {
            return ChipBuilder.PlayerEquipInventoryItemR2((PlayerPort)this, InventoryItem, InventoryEquipmentSlot, OnEquipComplete);
        }

        public ListPort<StringPort> GetAimAssistTags()
        {
            return ChipBuilder.PlayerGetAimAssistTags((PlayerPort)this);
        }

        public BoolPort GetEquipmentSlotIsEnabledR2(EquipmentSlotPort EquipmentSlot)
        {
            return ChipBuilder.PlayerGetEquipmentSlotIsEnabledR2((PlayerPort)this, EquipmentSlot);
        }

        public BoolPort GetIsAuthorityOf(RecRoomObjectPort Object)
        {
            return ChipBuilder.PlayerGetIsAuthorityOf((PlayerPort)this, Object);
        }

        public (FloatPort VoiceRolloffDistance, BoolPort HasLocalOverride) GetVoiceRolloffDistanceR2()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetVoiceRolloffDistanceR2_" + PortKey(), () => ChipBuilder.PlayerGetVoiceRolloffDistanceR2((PlayerPort)this));
        }

        public BoolPort HasPurchasedRoomOfferR2(RoomOfferPort RoomOffer, AlternativeExec<BoolPort> OnPlayerHasPurchasedRoomOfferComplete)
        {
            return ChipBuilder.PlayerHasPurchasedRoomOfferR2((PlayerPort)this, RoomOffer, OnPlayerHasPurchasedRoomOfferComplete);
        }

        public BoolPort HasRoleR1(StringPort Value)
        {
            return ChipBuilder.PlayerHasRoleR1((PlayerPort)this, Value);
        }

        public BoolPort OwnsInventoryItemR2(InventoryItemPort InventoryItem, AlternativeExec<BoolPort> Complete)
        {
            return ChipBuilder.PlayerOwnsInventoryItemR2((PlayerPort)this, InventoryItem, Complete);
        }

        public BoolPort OwnsRoomKeyR1(RoomKeyPort RoomKey, AlternativeExec<BoolPort> OnPlayerOwnsRoomKeyComplete)
        {
            return ChipBuilder.PlayerOwnsRoomKeyR1((PlayerPort)this, RoomKey, OnPlayerOwnsRoomKeyComplete);
        }

        public (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex) PromptMultipleChoice(StringPort PromptTitle, StringPort PromptBody, ListPort<StringPort> AnswerChoices, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex)> OnPromptComplete)
        {
            return ChipBuilder.PlayerPromptMultipleChoice((PlayerPort)this, PromptTitle, PromptBody, AnswerChoices, OnPromptComplete);
        }

        public (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response) PromptText(StringPort PromptTitle, StringPort PromptBody, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response)> OnPromptComplete)
        {
            return ChipBuilder.PlayerPromptText((PlayerPort)this, PromptTitle, PromptBody, OnPromptComplete);
        }

        public void RemoveRoleR1(StringPort Value)
        {
            ChipBuilder.PlayerRemoveRoleR1((PlayerPort)this, Value);
        }

        public void ResetNameColor()
        {
            ChipBuilder.PlayerResetNameColor((PlayerPort)this);
        }

        public void SetEquipmentSlotIsEnabledR2(EquipmentSlotPort EquipmentSlot, BoolPort IsEnabled)
        {
            ChipBuilder.PlayerSetEquipmentSlotIsEnabledR2((PlayerPort)this, EquipmentSlot, IsEnabled);
        }

        public void ShowSubtitle(StringPort Subtitle, FloatPort Duration, IntPort Priority)
        {
            ChipBuilder.PlayerShowSubtitle((PlayerPort)this, Subtitle, Duration, Priority);
        }

        public BoolPort UnequipFromSlotR2(EquipmentSlotPort EquipmentSlot, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipFromSlotR2((PlayerPort)this, EquipmentSlot, OnUnequipComplete);
        }

        public BoolPort UnequipInventoryItemR2(InventoryItemPort InventoryItem, AlternativeExec<BoolPort> OnUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipInventoryItemR2((PlayerPort)this, InventoryItem, OnUnequipComplete);
        }

        public PlayerPort Variable(VariableData config)
        {
            return ChipBuilder.PlayerVariable((PlayerPort)this, config);
        }

        public PlayerPort VariableDeprecated(VariableData config)
        {
            return ChipBuilder.PlayerVariableDeprecated((PlayerPort)this, config);
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

        public void RoomBackgroundObjectsClearPlayerOverrideR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsClearPlayerOverrideR2((PlayerPort)this, BlendTime, BlendFinished);
        }

        public void RoomFogClearPlayerOverrideR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomFogClearPlayerOverrideR2((PlayerPort)this, BlendTime, BlendFinished);
        }

        public void RoomSkydomeClearPlayerOverrideR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSkydomeClearPlayerOverrideR2((PlayerPort)this, BlendTime, BlendFinished);
        }

        public void RoomSunClearPlayerOverrideR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSunClearPlayerOverrideR2((PlayerPort)this, BlendTime, BlendFinished);
        }

        public void SetCameraShake(FloatPort Intensity, FloatPort Duration)
        {
            ChipBuilder.SetCameraShake((PlayerPort)this, Intensity, Duration);
        }

        public void SetVignette(FloatPort Time, ColorPort Color, FloatPort Intensity)
        {
            ChipBuilder.SetPlayerVignette((PlayerPort)this, Time, Color, Intensity);
        }

        public void SetPositionDeprecated(Vector3Port Position, AlternativeExec Failed)
        {
            ChipBuilder.SetPositionDeprecated((PlayerPort)this, Position, Failed);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port Position, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((PlayerPort)this, Position, ReferenceObject);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port Position, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((PlayerPort)this, Position, ReferenceObject);
        }

        public BoolPort SetRotation(Vector3Port Rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, Rotation);
        }

        public BoolPort SetRotation(QuaternionPort Rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, Rotation);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetTransform(Vector3Port Position, Vector3Port Rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, Position, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, QuaternionPort Rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, Position, Rotation);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, Vector3Port Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, Vector3Port Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, QuaternionPort Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, QuaternionPort Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, Position, Rotation, ReferenceObject);
        }

        public void ShowBannerNotification(StringPort Title, StringPort MainText, FloatPort Duration)
        {
            ChipBuilder.ShowBannerNotification((PlayerPort)this, Title, MainText, Duration);
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

        public ListPort<RecRoomObjectPort> UnequipFromSlotsR1(BoolPort DominantHand, BoolPort OffHand, BoolPort LeftHipHolster, BoolPort RightHipHolster, BoolPort ShoulderHolster)
        {
            return ChipBuilder.UnequipFromSlotsR1((PlayerPort)this, DominantHand, OffHand, LeftHipHolster, RightHipHolster, ShoulderHolster);
        }

        public void VelocityAdd(FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAdd((PlayerPort)this, Multiplier, Velocity, MaximumSpeed);
        }

        public void VelocityAddDeprecated(FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAddDeprecated((PlayerPort)this, Speed, Direction, MaximumSpeed);
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

    public abstract class PlayerOutfitSlotPortGen : AnyPort
    {
    }

    public abstract class PlayerSpawnPointV2PortGen : AnyPort
    {
        public BoolPort Active
        {
            get => CircuitBuilder.Singleton("RRCG_PlayerSpawnPointV2_GetActive_" + PortKey(), () => ChipBuilder.RespawnPointGetActive((PlayerSpawnPointV2Port)this));
            set => ChipBuilder.RespawnPointSetActive((PlayerSpawnPointV2Port)this, value);
        }

        public BoolPort AddAvoidRoleR1(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddAvoidRoleR1((PlayerSpawnPointV2Port)this, Role);
        }

        public void AddAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public BoolPort AddSpawnRoleR1(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddSpawnRoleR1((PlayerSpawnPointV2Port)this, Role);
        }

        public void AddSpawnTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddSpawnTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RemoveAvoidRoleR1(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveAvoidRoleR1((PlayerSpawnPointV2Port)this, Role);
        }

        public void RemoveAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointRemoveAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RemoveSpawnRoleR1(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveSpawnRoleR1((PlayerSpawnPointV2Port)this, Role);
        }

        public void RemoveSpawnTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointRemoveSpawnTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RespawnPlayerAtRespawnPoint(PlayerPort Player, BoolPort ClearVelocity, BoolPort UseRezEffects)
        {
            ChipBuilder.RespawnPointRespawnPlayerAtRespawnPoint((PlayerSpawnPointV2Port)this, Player, ClearVelocity, UseRezEffects);
        }
    }

    public abstract class PlayerWorldUIPortGen : AnyPort
    {
        public void DisplayPlayerWorldUI(PlayerPort Player)
        {
            ChipBuilder.DisplayPlayerWorldUI((PlayerWorldUIPort)this, Player);
        }
    }

    public abstract class ProjectileLauncherPortGen : AnyPort
    {
        public PlayerPort FiringPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetFiringPlayer_" + PortKey(), () => ChipBuilder.ProjectileLauncherGetFiringPlayer((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetFiringPlayer((ProjectileLauncherPort)this, value);
        }

        public IntPort ProjectileCount
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileCount_" + PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileCount((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileCount((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileLifetime
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileLifetime_" + PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileLifetime((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileLifetime((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpeed_" + PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpeed((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileSpeed((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileSpread
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpread_" + PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpread((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileSpread((ProjectileLauncherPort)this, value);
        }

        public void FireProjectile(Vector3Port Direction)
        {
            ChipBuilder.ProjectileLauncherFireProjectile((ProjectileLauncherPort)this, Direction);
        }
    }

    public abstract class QuickChatTablePortGen : AnyPort
    {
        public void SetEnabled(PlayerPort Player, BoolPort Enabled)
        {
            ChipBuilder.QuickChatTableSetEnabled((QuickChatTablePort)this, Player, Enabled);
        }
    }

    public abstract class RangedWeaponPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetColor_" + PortKey(), () => ChipBuilder.RangedWeaponGetColor((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetColor((RangedWeaponPort)this, value);
        }

        public IntPort HeadDamage
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetHeadDamage_" + PortKey(), () => ChipBuilder.RangedWeaponGetHeadDamage((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetHeadDamage((RangedWeaponPort)this, value);
        }

        public IntPort LimbDamage
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetLimbDamage_" + PortKey(), () => ChipBuilder.RangedWeaponGetLimbDamage((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetLimbDamage((RangedWeaponPort)this, value);
        }

        public ColorPort ProjectileColor
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetProjectileColor_" + PortKey(), () => ChipBuilder.RangedWeaponGetProjectileColor((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetProjectileColor((RangedWeaponPort)this, value);
        }

        public IntPort RecRoomObjectDamage
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetRecRoomObjectDamage_" + PortKey(), () => ChipBuilder.RangedWeaponGetRecRoomObjectDamage((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetRecRoomObjectDamage((RangedWeaponPort)this, value);
        }

        public IntPort TorsoDamage
        {
            get => CircuitBuilder.Singleton("RRCG_RangedWeapon_GetTorsoDamage_" + PortKey(), () => ChipBuilder.RangedWeaponGetTorsoDamage((RangedWeaponPort)this));
            set => ChipBuilder.RangedWeaponSetTorsoDamage((RangedWeaponPort)this, value);
        }
    }

    public abstract class RecNetImagePortGen : AnyPort
    {
    }

    public abstract class RecRoomObjectPortGen : AnyPort
    {
        public Vector3Port AngularVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAngularVelocity_" + PortKey(), () => ChipBuilder.GetAngularVelocity((RecRoomObjectPort)this));
        }

        public PlayerPort Authority
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAuthority_" + PortKey(), () => ChipBuilder.RecRoomObjectGetAuthority((RecRoomObjectPort)this));
            set => ChipBuilder.RecRoomObjectSetAuthority((RecRoomObjectPort)this, value);
        }

        public StringPort FirstTag
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetFirstTag_" + PortKey(), () => ChipBuilder.GetFirstTag((RecRoomObjectPort)this));
        }

        public Vector3Port ForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVector_" + PortKey(), () => ChipBuilder.GetForwardVector((RecRoomObjectPort)this));
        }

        public Vector3Port ForwardVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVectorDeprecated_" + PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((RecRoomObjectPort)this));
        }

        public (BoolPort IsHeld, PlayerPort HolderPlayer) HolderPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetHolderPlayer_" + PortKey(), () => ChipBuilder.RecRoomObjectGetHolderPlayer((RecRoomObjectPort)this));
        }

        public BoolPort IsLocalPlayerAuthority
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetIsLocalPlayerAuthority_" + PortKey(), () => ChipBuilder.RecRoomObjectGetIsLocalPlayerAuthority((RecRoomObjectPort)this));
        }

        public (PlayerPort Player, BoolPort CurrentlyHeldOrEquipped) LastHoldingOrEquippingPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetLastHoldingOrEquippingPlayer_" + PortKey(), () => ChipBuilder.RecRoomObjectGetLastHoldingOrEquippingPlayer((RecRoomObjectPort)this));
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPosition_" + PortKey(), () => ChipBuilder.GetPosition((RecRoomObjectPort)this));
            set => ChipBuilder.SetPosition((RecRoomObjectPort)this, value);
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPositionDeprecated_" + PortKey(), () => ChipBuilder.GetPositionDeprecated((RecRoomObjectPort)this));
        }

        public RecRoomObjectPort RootObject
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRootObject_" + PortKey(), () => ChipBuilder.RecRoomObjectGetRootObject((RecRoomObjectPort)this));
        }

        public QuaternionPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotation_" + PortKey(), () => ChipBuilder.GetRotation((RecRoomObjectPort)this));
        }

        public QuaternionPort RotationDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotationDeprecated_" + PortKey(), () => ChipBuilder.GetRotationDeprecated((RecRoomObjectPort)this));
        }

        public ListPort<StringPort> Tags
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetTags_" + PortKey(), () => ChipBuilder.GetTags((RecRoomObjectPort)this));
        }

        public Vector3Port UpVector
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVector_" + PortKey(), () => ChipBuilder.GetUpVector((RecRoomObjectPort)this));
        }

        public Vector3Port UpVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVectorDeprecated_" + PortKey(), () => ChipBuilder.GetUpVectorDeprecated((RecRoomObjectPort)this));
        }

        public Vector3Port Velocity
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocity_" + PortKey(), () => ChipBuilder.GetVelocity((RecRoomObjectPort)this));
        }

        public Vector3Port VelocityDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocityDeprecated_" + PortKey(), () => ChipBuilder.GetVelocityDeprecated((RecRoomObjectPort)this));
        }

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
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_FromRecRoomObject_" + PortKey(), () => ChipBuilder.FromRecRoomObject<T>((RecRoomObjectPort)this));
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

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort ReferenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((RecRoomObjectPort)this, ReferenceObject);
        }

        public BoolPort HasTag(StringPort Tag)
        {
            return ChipBuilder.HasTag((RecRoomObjectPort)this, Tag);
        }

        public void IfHasTag(StringPort Tag, AlternativeExec DoesNotHaveTag)
        {
            ChipBuilder.IfHasTag((RecRoomObjectPort)this, Tag, DoesNotHaveTag);
        }

        public void Reset()
        {
            ChipBuilder.RecRoomObjectReset((RecRoomObjectPort)this);
        }

        public RecRoomObjectPort Variable(VariableData config)
        {
            return ChipBuilder.RecRoomObjectVariable((RecRoomObjectPort)this, config);
        }

        public void RemoveTag(StringPort Tag)
        {
            ChipBuilder.RemoveTag((RecRoomObjectPort)this, Tag);
        }

        public void RemoveTags(ListPort<StringPort> Tags)
        {
            ChipBuilder.RemoveTags((RecRoomObjectPort)this, Tags);
        }

        public void ReplicatorReturnObjectR2()
        {
            ChipBuilder.ReplicatorReturnObjectR2((RecRoomObjectPort)this);
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

        public void SetPositionDeprecated(Vector3Port Position, AlternativeExec Failed)
        {
            ChipBuilder.SetPositionDeprecated((RecRoomObjectPort)this, Position, Failed);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port Position, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((RecRoomObjectPort)this, Position, ReferenceObject);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port Position, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((RecRoomObjectPort)this, Position, ReferenceObject);
        }

        public BoolPort SetRotation(Vector3Port Rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, Rotation);
        }

        public BoolPort SetRotation(QuaternionPort Rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, Rotation);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, Rotation, ReferenceObject);
        }

        public BoolPort SetTransform(Vector3Port Position, Vector3Port Rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, Position, Rotation);
        }

        public BoolPort SetTransform(Vector3Port Position, QuaternionPort Rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, Position, Rotation);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, Vector3Port Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, Vector3Port Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, QuaternionPort Rotation, PlayerPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, Position, Rotation, ReferenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port Position, QuaternionPort Rotation, RecRoomObjectPort ReferenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, Position, Rotation, ReferenceObject);
        }

        public void SpawnerInternalStartSpawningR1(IntPort Amountofobjectstospawn, FloatPort Timebetweenspawns, Vector3Port SpawnPosition)
        {
            ChipBuilder.SpawnerInternalStartSpawningR1((RecRoomObjectPort)this, Amountofobjectstospawn, Timebetweenspawns, SpawnPosition);
        }

        public void SpawnerResetR1()
        {
            ChipBuilder.SpawnerResetR1((RecRoomObjectPort)this);
        }

        public BoolPort UnequipObject()
        {
            return ChipBuilder.UnequipObject((RecRoomObjectPort)this);
        }

        public void VelocityAdd(FloatPort Multiplier, Vector3Port Velocity, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAdd((RecRoomObjectPort)this, Multiplier, Velocity, MaximumSpeed);
        }

        public void VelocityAddDeprecated(FloatPort Speed, Vector3Port Direction, FloatPort MaximumSpeed)
        {
            ChipBuilder.VelocityAddDeprecated((RecRoomObjectPort)this, Speed, Direction, MaximumSpeed);
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

    public abstract class ReplicatorPortGen : AnyPort
    {
        public IntPort ActiveObjectsCountR2
        {
            get => CircuitBuilder.Singleton("RRCG_Replicator_GetActiveObjectsCountR2_" + PortKey(), () => ChipBuilder.ReplicatorGetActiveObjectsCountR2((ReplicatorPort)this));
        }

        public ListPort<RecRoomObjectPort> ActiveObjectsR2
        {
            get => CircuitBuilder.Singleton("RRCG_Replicator_GetActiveObjectsR2_" + PortKey(), () => ChipBuilder.ReplicatorGetActiveObjectsR2((ReplicatorPort)this));
        }

        public (RecRoomObjectPort Object, BoolPort Success) SpawnNextObjectR2(Vector3Port Position, QuaternionPort Orientation, BoolPort AssigntoPlayer, PlayerPort Player, AlternativeExec<(RecRoomObjectPort Object, BoolPort Success)> OnSpawnComplete)
        {
            return ChipBuilder.ReplicatorSpawnNextObjectR2((ReplicatorPort)this, Position, Orientation, AssigntoPlayer, Player, OnSpawnComplete);
        }
    }

    public abstract class RewardPortGen : AnyPort
    {
    }

    public abstract class RoomCurrencyPortGen : AnyPort
    {
        public (BoolPort Success, IntPort TotalBalance) AwardCurrencyR1(PlayerPort Player, IntPort Amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrencyR1((RoomCurrencyPort)this, Player, Amount, OnAwardCurrencyComplete);
        }

        public (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceR1(PlayerPort Player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> OnGetBalanceComplete)
        {
            return ChipBuilder.GetCurrencyBalanceR1((RoomCurrencyPort)this, Player, OnGetBalanceComplete);
        }

        public void ShowPurchasePromptR1(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePromptR1((RoomCurrencyPort)this, Player);
        }
    }

    public abstract class RoomDoorPortGen : AnyPort
    {
        public DestinationRoomPort DestinationR1
        {
            get => CircuitBuilder.Singleton("RRCG_RoomDoor_GetDestinationR1_" + PortKey(), () => ChipBuilder.DoorGetDestinationR1((RoomDoorPort)this));
            set => ChipBuilder.DoorSetDestinationR1((RoomDoorPort)this, value);
        }

        public BoolPort LockedR1
        {
            get => CircuitBuilder.Singleton("RRCG_RoomDoor_GetLockedR1_" + PortKey(), () => ChipBuilder.DoorGetLockedR1((RoomDoorPort)this));
            set => ChipBuilder.DoorSetLockedR1((RoomDoorPort)this, value);
        }
    }

    public abstract class RoomKeyPortGen : AnyPort
    {
        public BoolPort AwardRoomKeyR1(PlayerPort Player, AlternativeExec<BoolPort> OnAwardRoomKeyComplete)
        {
            return ChipBuilder.AwardRoomKeyR1((RoomKeyPort)this, Player, OnAwardRoomKeyComplete);
        }

        public void ShowPurchasePromptR1(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePromptR1((RoomKeyPort)this, Player);
        }
    }

    public abstract class RoomLevelHUDPortGen : AnyPort
    {
    }

    public abstract class RoomOfferPortGen : AnyPort
    {
        public void ShowPurchasePromptR2(PlayerPort Player)
        {
            ChipBuilder.ShowPurchasePromptR2((RoomOfferPort)this, Player);
        }
    }

    public abstract class RotatorPortGen : AnyPort
    {
        public FloatPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotation_" + PortKey(), () => ChipBuilder.RotatorGetRotation((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotation((RotatorPort)this, value);
        }

        public FloatPort RotationAcceleration
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotationAcceleration_" + PortKey(), () => ChipBuilder.RotatorGetRotationAcceleration((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotationAcceleration((RotatorPort)this, value);
        }

        public FloatPort RotationSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotationSpeed_" + PortKey(), () => ChipBuilder.RotatorGetRotationSpeed((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotationSpeed((RotatorPort)this, value);
        }

        public FloatPort TargetRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetTargetRotation_" + PortKey(), () => ChipBuilder.RotatorGetTargetRotation((RotatorPort)this));
            set => ChipBuilder.RotatorSetTargetRotation((RotatorPort)this, value);
        }
    }

    public abstract class SeatPortGen : AnyPort
    {
        public BoolPort LockPlayersIn
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersIn_" + PortKey(), () => ChipBuilder.SeatGetLockPlayersIn((SeatPort)this));
            set => ChipBuilder.SeatSetLockPlayersIn((SeatPort)this, value);
        }

        public BoolPort LockPlayersOut
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersOut_" + PortKey(), () => ChipBuilder.SeatGetLockPlayersOut((SeatPort)this));
            set => ChipBuilder.SeatSetLockPlayersOut((SeatPort)this, value);
        }

        public PlayerPort SeatedPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetSeatedPlayer_" + PortKey(), () => ChipBuilder.SeatGetSeatedPlayer((SeatPort)this));
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

    public abstract class SFXPortGen : AnyPort
    {
        public BoolPort IsPlaying
        {
            get => CircuitBuilder.Singleton("RRCG_SFX_GetIsPlaying_" + PortKey(), () => ChipBuilder.SFXGetIsPlaying((SFXPort)this));
        }

        public IntPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_SFX_GetVolume_" + PortKey(), () => ChipBuilder.SFXGetVolume((SFXPort)this));
            set => ChipBuilder.SFXSetVolume((SFXPort)this, value);
        }

        public void Play()
        {
            ChipBuilder.SFXPlay((SFXPort)this);
        }

        public void Stop()
        {
            ChipBuilder.SFXStop((SFXPort)this);
        }
    }

    public abstract class SkydomePortGen : AnyPort
    {
        public BoolPort RoomSkydomeModifyR1(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSkydomeModifyR1((SkydomePort)this, BlendFinished);
        }

        public void RoomSkydomeModifyR2(FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSkydomeModifyR2((SkydomePort)this, BlendTime, BlendFinished);
        }

        public void RoomSkydomePlayerOverrideR2(PlayerPort Player, FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSkydomePlayerOverrideR2((SkydomePort)this, Player, BlendTime, BlendFinished);
        }
    }

    public abstract class StatePortGen : AnyPort
    {
        public void GoToState()
        {
            ChipBuilder.GoToState((StatePort)this);
        }
    }

    public abstract class StorefrontPortGen : AnyPort
    {
        public BoolPort IsEnabledR2
        {
            get => CircuitBuilder.Singleton("RRCG_Storefront_GetIsEnabledR2_" + PortKey(), () => ChipBuilder.StorefrontGetIsEnabledR2((StorefrontPort)this));
            set => ChipBuilder.StorefrontSetIsEnabledR2((StorefrontPort)this, value);
        }

        public ListPort<RoomOfferPort> OffersListR2
        {
            get => CircuitBuilder.Singleton("RRCG_Storefront_GetOffersListR2_" + PortKey(), () => ChipBuilder.StorefrontGetOffersListR2((StorefrontPort)this));
            set => ChipBuilder.StorefrontSetOffersListR2((StorefrontPort)this, value);
        }
    }

    public abstract class StudioObjectPortGen : AnyPort
    {
        public StudioFunctionData StudioFunction
        {
            set => ChipBuilder.StudioFunction((StudioObjectPort)this, value);
        }

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

        public ColorPort GetPropertyColor(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyColor((StudioObjectPort)this, Property);
        }

        public FloatPort GetPropertyFloat(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyFloat((StudioObjectPort)this, Property);
        }

        public IntPort GetPropertyInt(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyInt((StudioObjectPort)this, Property);
        }

        public QuaternionPort GetPropertyQuaternion(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyQuaternion((StudioObjectPort)this, Property);
        }

        public StringPort GetPropertyString(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyString((StudioObjectPort)this, Property);
        }

        public Vector3Port GetPropertyVector3(StringPort Property)
        {
            return ChipBuilder.StudioObjectGetPropertyVector3((StudioObjectPort)this, Property);
        }
    }

    public abstract class SunPortGen : AnyPort
    {
        public BoolPort RoomSunModifyR1(SunDirectionPort SunDirection, AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSunModifyR1((SunPort)this, SunDirection, BlendFinished);
        }

        public void RoomSunModifyR2(SunDirectionPort SunDirection, FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSunModifyR2((SunPort)this, SunDirection, BlendTime, BlendFinished);
        }

        public void RoomSunPlayerOverrideR2(SunDirectionPort SunDirection, PlayerPort Player, FloatPort BlendTime, AlternativeExec BlendFinished)
        {
            ChipBuilder.RoomSunPlayerOverrideR2((SunPort)this, SunDirection, Player, BlendTime, BlendFinished);
        }
    }

    public abstract class SunDirectionPortGen : AnyPort
    {
    }

    public abstract class SwingHandlePortGen : AnyPort
    {
        public BoolPort IsSwinging
        {
            get => CircuitBuilder.Singleton("RRCG_SwingHandle_GetIsSwinging_" + PortKey(), () => ChipBuilder.SwingHandleGetIsSwinging((SwingHandlePort)this));
        }
    }

    public abstract class TextPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Text_GetColor_" + PortKey(), () => ChipBuilder.TextGetColor((TextPort)this));
            set => ChipBuilder.TextSetColor((TextPort)this, value);
        }

        public IntPort ColorIdDeprecated
        {
            set => ChipBuilder.TextSetColorIdDeprecated((TextPort)this, value);
        }

        public IntPort Material
        {
            set => ChipBuilder.TextSetMaterial((TextPort)this, value);
        }

        public StringPort Text
        {
            get => CircuitBuilder.Singleton("RRCG_Text_GetText_" + PortKey(), () => ChipBuilder.TextGetText((TextPort)this));
            set => ChipBuilder.TextSetText((TextPort)this, value);
        }
    }

    public abstract class TextScreenPortGen : AnyPort
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

    public abstract class ToggleButtonPortGen : AnyPort
    {
        public BoolPort IsPressed
        {
            get => CircuitBuilder.Singleton("RRCG_ToggleButton_GetIsPressed_" + PortKey(), () => ChipBuilder.ToggleButtonGetIsPressed((ToggleButtonPort)this));
            set => ChipBuilder.ToggleButtonSetIsPressed((ToggleButtonPort)this, value);
        }

        public BoolPort IsPressedDeprecated
        {
            set => ChipBuilder.ToggleButtonSetIsPressedDeprecated((ToggleButtonPort)this, value);
        }
    }

    public abstract class TouchpadPortGen : AnyPort
    {
        public (BoolPort IsTouchActive, Vector3Port TouchPosition, Vector3Port WorldPosition) ActiveTouch
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetActiveTouch_" + PortKey(), () => ChipBuilder.TouchpadComponentGetActiveTouch((TouchpadPort)this));
        }

        public StringPort InteractionLabel
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetInteractionLabel_" + PortKey(), () => ChipBuilder.TouchpadComponentGetInteractionLabel((TouchpadPort)this));
            set => ChipBuilder.TouchpadComponentSetInteractionLabel((TouchpadPort)this, value);
        }

        public BoolPort IsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetIsEnabled_" + PortKey(), () => ChipBuilder.TouchpadComponentGetIsEnabled((TouchpadPort)this));
            set => ChipBuilder.TouchpadComponentSetIsEnabled((TouchpadPort)this, value);
        }
    }

    public abstract class TriggerHandlePortGen : AnyPort
    {
        public StringPort ControlPromptDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerHandle_GetControlPromptDeprecated_" + PortKey(), () => ChipBuilder.TriggerHandleGetControlPromptDeprecated((TriggerHandlePort)this));
            set => ChipBuilder.TriggerHandleSetControlPromptDeprecated((TriggerHandlePort)this, value);
        }

        public BoolPort PrimaryActionHeld
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerHandle_GetPrimaryActionHeld_" + PortKey(), () => ChipBuilder.TriggerHandleGetPrimaryActionHeld((TriggerHandlePort)this));
        }
    }

    public abstract class TriggerVolumePortGen : AnyPort
    {
        public StringPort FilterRoleR1
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetFilterRoleR1_" + PortKey(), () => ChipBuilder.TriggerVolumeGetFilterRoleR1((TriggerVolumePort)this));
            set => ChipBuilder.TriggerVolumeSetFilterRoleR1((TriggerVolumePort)this, value);
        }

        public IntPort ObjectCount
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjectCount_" + PortKey(), () => ChipBuilder.TriggerVolumeGetObjectCount((TriggerVolumePort)this));
        }

        public ListPort<StringPort> ObjectFilterTags
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjectFilterTags_" + PortKey(), () => ChipBuilder.TriggerVolumeGetObjectFilterTags((TriggerVolumePort)this));
            set => ChipBuilder.TriggerVolumeSetObjectFilterTags((TriggerVolumePort)this, value);
        }

        public ListPort<RecRoomObjectPort> Objects
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjects_" + PortKey(), () => ChipBuilder.TriggerVolumeGetObjects((TriggerVolumePort)this));
        }

        public IntPort PlayerCount
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayerCount_" + PortKey(), () => ChipBuilder.TriggerVolumeGetPlayerCount((TriggerVolumePort)this));
        }

        public ListPort<StringPort> PlayerFilterTagsR2
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayerFilterTagsR2_" + PortKey(), () => ChipBuilder.TriggerVolumeGetPlayerFilterTagsR2((TriggerVolumePort)this));
            set => ChipBuilder.TriggerVolumeSetPlayerFilterTagsR2((TriggerVolumePort)this, value);
        }

        public ListPort<PlayerPort> Players
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayers_" + PortKey(), () => ChipBuilder.TriggerVolumeGetPlayers((TriggerVolumePort)this));
        }
    }

    public abstract class VectorComponentPortGen : AnyPort
    {
        public Vector3Port GetVector(FloatPort Magnitude)
        {
            return ChipBuilder.VectorComponentGetVector((VectorComponentPort)this, Magnitude);
        }
    }

    public abstract class WelcomeMatPortGen : AnyPort
    {
        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_WelcomeMat_GetEnabled_" + PortKey(), () => ChipBuilder.WelcomeMatGetEnabled((WelcomeMatPort)this));
            set => ChipBuilder.WelcomeMatSetEnabled((WelcomeMatPort)this, value);
        }
    }
}