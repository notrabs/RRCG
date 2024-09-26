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

        public BoolPort HasLineOfSightToTargetR1(AIPort target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public BoolPort HasLineOfSightToTargetR1(CombatantPort target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public BoolPort HasLineOfSightToTargetR1(RecRoomObjectPort target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public BoolPort HasLineOfSightToTargetR1(PatrolPointPort target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public BoolPort HasLineOfSightToTargetR1(PlayerPort target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public BoolPort HasLineOfSightToTargetR1(Vector3Port target)
        {
            return ChipBuilder.AIHasLineOfSightToTargetR1((AIPort)this, target);
        }

        public void LookAtR1(AIPort lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void LookAtR1(CombatantPort lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void LookAtR1(RecRoomObjectPort lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void LookAtR1(PatrolPointPort lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void LookAtR1(PlayerPort lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void LookAtR1(Vector3Port lookTarget, BoolPort lookTargetIsDirection)
        {
            ChipBuilder.AILookAtR1((AIPort)this, lookTarget, lookTargetIsDirection);
        }

        public void PathToR1(AIPort target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void PathToR1(CombatantPort target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void PathToR1(RecRoomObjectPort target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void PathToR1(PatrolPointPort target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void PathToR1(PlayerPort target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void PathToR1(Vector3Port target)
        {
            ChipBuilder.AIPathToR1((AIPort)this, target);
        }

        public void RotateR1(FloatPort rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, rotation);
        }

        public void RotateR1(IntPort rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, rotation);
        }

        public void RotateR1(Vector3Port rotation)
        {
            ChipBuilder.AIRotateR1((AIPort)this, rotation);
        }

        public void SetLineOfSightParametersR1(StringPort visionType, FloatPort visionRange, FloatPort visionConeAngle, FloatPort hearingRange, BoolPort requireLoSForTargeting)
        {
            ChipBuilder.AISetLineOfSightParametersR1((AIPort)this, visionType, visionRange, visionConeAngle, hearingRange, requireLoSForTargeting);
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

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((AIPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantSetHealthR1(IntPort health)
        {
            ChipBuilder.CombatantSetHealthR1((AIPort)this, health);
        }

        public FloatPort Distance(AIPort b)
        {
            return ChipBuilder.Distance((AIPort)this, b);
        }

        public FloatPort Distance(CombatantPort b)
        {
            return ChipBuilder.Distance((AIPort)this, b);
        }

        public FloatPort Distance(RecRoomObjectPort b)
        {
            return ChipBuilder.Distance((AIPort)this, b);
        }

        public FloatPort Distance(PlayerPort b)
        {
            return ChipBuilder.Distance((AIPort)this, b);
        }

        public FloatPort Distance(Vector3Port b)
        {
            return ChipBuilder.Distance((AIPort)this, b);
        }

        public FloatPort DistanceDeprecated(AIPort b)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, b);
        }

        public FloatPort DistanceDeprecated(CombatantPort b)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, b);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort b)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, b);
        }

        public FloatPort DistanceDeprecated(PlayerPort b)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, b);
        }

        public FloatPort DistanceDeprecated(Vector3Port b)
        {
            return ChipBuilder.DistanceDeprecated((AIPort)this, b);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((AIPort)this, referenceObject);
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

        public void PlayAudioAtPosition(Vector3Port position, FloatPort volume, FloatPort playbackSpeed, BoolPort is2D, PlayAudioAtPositionData config)
        {
            ChipBuilder.PlayAudioAtPosition((AudioPort)this, position, volume, playbackSpeed, is2D, config);
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

        public void Play(AudioPort audio)
        {
            ChipBuilder.AudioPlayerPlay((AudioPlayerPort)this, audio);
        }

        public void Stop()
        {
            ChipBuilder.AudioPlayerStop((AudioPlayerPort)this);
        }
    }

    public abstract class BackgroundObjectsPortGen : AnyPort
    {
        public BoolPort RoomBackgroundObjectsModifyR1(AlternativeExec<BoolPort> blendFinished)
        {
            return ChipBuilder.RoomBackgroundObjectsModifyR1((BackgroundObjectsPort)this, blendFinished);
        }

        public void RoomBackgroundObjectsModifyR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsModifyR2((BackgroundObjectsPort)this, blendTime, blendFinished);
        }

        public void RoomBackgroundObjectsPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsPlayerOverrideR2((BackgroundObjectsPort)this, player, blendTime, blendFinished);
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

        public void ReceiveDamageR1(IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, damage, ignoreShield, damageSource);
        }

        public void ReceiveDamageR1(IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, damage, ignoreShield, damageSource);
        }

        public void ReceiveDamageR1(IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((CombatantPort)this, damage, ignoreShield, damageSource);
        }

        public void SetHealthR1(IntPort health)
        {
            ChipBuilder.CombatantSetHealthR1((CombatantPort)this, health);
        }

        public CombatantPort VariableR1(VariableData config)
        {
            return ChipBuilder.CombatantVariableR1((CombatantPort)this, config);
        }

        public FloatPort Distance(AIPort b)
        {
            return ChipBuilder.Distance((CombatantPort)this, b);
        }

        public FloatPort Distance(CombatantPort b)
        {
            return ChipBuilder.Distance((CombatantPort)this, b);
        }

        public FloatPort Distance(RecRoomObjectPort b)
        {
            return ChipBuilder.Distance((CombatantPort)this, b);
        }

        public FloatPort Distance(PlayerPort b)
        {
            return ChipBuilder.Distance((CombatantPort)this, b);
        }

        public FloatPort Distance(Vector3Port b)
        {
            return ChipBuilder.Distance((CombatantPort)this, b);
        }

        public FloatPort DistanceDeprecated(AIPort b)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, b);
        }

        public FloatPort DistanceDeprecated(CombatantPort b)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, b);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort b)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, b);
        }

        public FloatPort DistanceDeprecated(PlayerPort b)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, b);
        }

        public FloatPort DistanceDeprecated(Vector3Port b)
        {
            return ChipBuilder.DistanceDeprecated((CombatantPort)this, b);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((CombatantPort)this, referenceObject);
        }
    }

    public abstract class ConsumablePortGen : AnyPort
    {
        public BoolPort AwardConsumableR1(PlayerPort player, IntPort quantity, AlternativeExec<BoolPort> onAwardConsumableComplete)
        {
            return ChipBuilder.AwardConsumableR1((ConsumablePort)this, player, quantity, onAwardConsumableComplete);
        }

        public void ActivateR1()
        {
            ChipBuilder.ConsumableActivateR1((ConsumablePort)this);
        }

        public void DeactivateR1()
        {
            ChipBuilder.ConsumableDeactivateR1((ConsumablePort)this);
        }

        public void ShowPurchasePromptR1(PlayerPort player)
        {
            ChipBuilder.ShowPurchasePromptR1((ConsumablePort)this, player);
        }
    }

    public abstract class CostumePortGen : AnyPort
    {
        public PlayerPort Wearer
        {
            get => CircuitBuilder.Singleton("RRCG_Costume_GetWearer_" + PortKey(), () => ChipBuilder.CostumeGetWearer((CostumePort)this));
        }

        public void Equip(PlayerPort player)
        {
            ChipBuilder.CostumeEquip((CostumePort)this, player);
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

        public void SetButtonState(BoolPort button1Enabled, StringPort button1Text, BoolPort button2Enabled, StringPort button2Text, BoolPort button3Enabled, StringPort button3Text, BoolPort button4Enabled, StringPort button4Text)
        {
            ChipBuilder.DialogueUISetButtonState((DialogueUIPort)this, button1Enabled, button1Text, button2Enabled, button2Text, button3Enabled, button3Text, button4Enabled, button4Text);
        }

        public void SetDialogueText(StringPort bodyText, BoolPort isInteractive)
        {
            ChipBuilder.DialogueUISetDialogueText((DialogueUIPort)this, bodyText, isInteractive);
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
        public BoolPort RoomFogModifyR1(AlternativeExec<BoolPort> blendFinished)
        {
            return ChipBuilder.RoomFogModifyR1((FogPort)this, blendFinished);
        }

        public void RoomFogModifyR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomFogModifyR2((FogPort)this, blendTime, blendFinished);
        }

        public void RoomFogPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomFogPlayerOverrideR2((FogPort)this, player, blendTime, blendFinished);
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

        public BoolPort GrabObjectR2(RecRoomObjectPort @object, BoolPort stealFromPlayer, BoolPort snapToGrabber)
        {
            return ChipBuilder.GrabberGrabObjectR2((GrabberPort)this, @object, stealFromPlayer, snapToGrabber);
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

        public void AddBoostFuel(IntPort boostAmount)
        {
            ChipBuilder.GroundVehicleAddBoostFuel((GroundVehiclePort)this, boostAmount);
        }

        public void ApplyBoost(AlternativeExec failure)
        {
            ChipBuilder.GroundVehicleApplyBoost((GroundVehiclePort)this, failure);
        }

        public PlayerPort GetSeatedPlayer(IntPort seatIndex)
        {
            return ChipBuilder.GroundVehicleGetSeatedPlayer((GroundVehiclePort)this, seatIndex);
        }

        public void SetSeatedPlayer(IntPort seatIndex, PlayerPort player, AlternativeExec failure)
        {
            ChipBuilder.GroundVehicleSetSeatedPlayer((GroundVehiclePort)this, seatIndex, player, failure);
        }

        public void UnseatPlayer(PlayerPort player, AlternativeExec failure)
        {
            ChipBuilder.GroundVehicleUnseatPlayer((GroundVehiclePort)this, player, failure);
        }

        public void UnseatPlayerFromSeat(IntPort seatIndex, AlternativeExec failure)
        {
            ChipBuilder.GroundVehicleUnseatPlayerFromSeat((GroundVehiclePort)this, seatIndex, failure);
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

        public void AddAutoAimRoleDeprecatedR1(StringPort role)
        {
            ChipBuilder.GunHandleAddAutoAimRoleDeprecatedR1((GunHandlePort)this, role);
        }

        public void ApplyRecoil(FloatPort angleX, FloatPort angleY, FloatPort duration, FloatPort returnDuration)
        {
            ChipBuilder.GunHandleApplyRecoil((GunHandlePort)this, angleX, angleY, duration, returnDuration);
        }

        public Vector3Port GetFiringDirection(RecRoomObjectPort source)
        {
            return ChipBuilder.GunHandleGetFiringDirection((GunHandlePort)this, source);
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

        public void PlayHandleHaptics(IntPort duration, FloatPort intensity)
        {
            ChipBuilder.PlayHandleHaptics((HandlePort)this, duration, intensity);
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

        public void Play(HolotarRecordingPort holotar)
        {
            ChipBuilder.HolotarProjectorPlay((HolotarProjectorPort)this, holotar);
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

        public (BoolPort Success, IntPort TotalCount) AddR2(PlayerPort player, IntPort quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> complete)
        {
            return ChipBuilder.InventoryItemAddR2((InventoryItemPort)this, player, quantity, complete);
        }

        public IntPort GetCountR2(PlayerPort player, AlternativeExec<IntPort> complete)
        {
            return ChipBuilder.InventoryItemGetCountR2((InventoryItemPort)this, player, complete);
        }

        public (BoolPort Success, IntPort TotalCount) RemoveR2(PlayerPort player, IntPort quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> complete)
        {
            return ChipBuilder.InventoryItemRemoveR2((InventoryItemPort)this, player, quantity, complete);
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
            set => ChipBuilder.LightSetEnabled((LightPort)this, value);
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

        public void AttachToPlayerOrObject(PlayerPort playerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, playerOrObject);
        }

        public void AttachToPlayerOrObject(RecRoomObjectPort playerOrObject)
        {
            ChipBuilder.ObjectiveMarkerAttachToPlayerOrObject((ObjectiveMarkerPort)this, playerOrObject);
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

        public void StartPathingToPositionR2(Vector3Port targetPosition, FloatPort slowdownDistance, FloatPort arrivalDistance)
        {
            ChipBuilder.PathfinderStartPathingToPositionR2((PathfinderPort)this, targetPosition, slowdownDistance, arrivalDistance);
        }

        public void StartRotatingToDirectionR2(Vector3Port targetDirection, FloatPort slowdownAngle, FloatPort arrivalAngle)
        {
            ChipBuilder.PathfinderStartRotatingToDirectionR2((PathfinderPort)this, targetDirection, slowdownAngle, arrivalAngle);
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

        public void AddTag(StringPort tag)
        {
            ChipBuilder.AddTag((PlayerPort)this, tag);
        }

        public void AddTags(ListPort<StringPort> tags)
        {
            ChipBuilder.AddTags((PlayerPort)this, tags);
        }

        public (BoolPort Success, IntPort TotalBalance) AwardCurrencyDeprecatedR1(IntPort amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrencyDeprecatedR1((PlayerPort)this, amount, onAwardCurrencyComplete);
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

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantReceiveDamageR1(IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            ChipBuilder.CombatantReceiveDamageR1((PlayerPort)this, damage, ignoreShield, damageSource);
        }

        public void CombatantSetHealthR1(IntPort health)
        {
            ChipBuilder.CombatantSetHealthR1((PlayerPort)this, health);
        }

        public FloatPort Distance(AIPort b)
        {
            return ChipBuilder.Distance((PlayerPort)this, b);
        }

        public FloatPort Distance(CombatantPort b)
        {
            return ChipBuilder.Distance((PlayerPort)this, b);
        }

        public FloatPort Distance(RecRoomObjectPort b)
        {
            return ChipBuilder.Distance((PlayerPort)this, b);
        }

        public FloatPort Distance(PlayerPort b)
        {
            return ChipBuilder.Distance((PlayerPort)this, b);
        }

        public FloatPort Distance(Vector3Port b)
        {
            return ChipBuilder.Distance((PlayerPort)this, b);
        }

        public FloatPort DistanceDeprecated(AIPort b)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, b);
        }

        public FloatPort DistanceDeprecated(CombatantPort b)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, b);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort b)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, b);
        }

        public FloatPort DistanceDeprecated(PlayerPort b)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, b);
        }

        public FloatPort DistanceDeprecated(Vector3Port b)
        {
            return ChipBuilder.DistanceDeprecated((PlayerPort)this, b);
        }

        public BoolPort EquipObjectToDominantHand(RecRoomObjectPort objectToEquip, BoolPort forceEquip, BoolPort steal)
        {
            return ChipBuilder.EquipObjectToDominantHand((PlayerPort)this, objectToEquip, forceEquip, steal);
        }

        public BoolPort EquipObjectToOffHand(RecRoomObjectPort objectToEquip, BoolPort forceEquip, BoolPort steal)
        {
            return ChipBuilder.EquipObjectToOffHand((PlayerPort)this, objectToEquip, forceEquip, steal);
        }

        public BoolPort EquipShareCamera(BoolPort forceEquip)
        {
            return ChipBuilder.EquipShareCamera((PlayerPort)this, forceEquip);
        }

        public (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<RecRoomObjectPort> targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, targets);
        }

        public (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<PlayerPort> targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, targets);
        }

        public (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<Vector3Port> targets)
        {
            return ChipBuilder.GetClosest((PlayerPort)this, targets);
        }

        public (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<RecRoomObjectPort> targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, targets);
        }

        public (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<PlayerPort> targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, targets);
        }

        public (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<Vector3Port> targets)
        {
            return ChipBuilder.GetFarthest((PlayerPort)this, targets);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((PlayerPort)this, referenceObject);
        }

        public BoolPort GrantReward(RewardPort reward, AlternativeExec<BoolPort> onAwardComplete)
        {
            return ChipBuilder.GrantReward((PlayerPort)this, reward, onAwardComplete);
        }

        public BoolPort HasTag(StringPort tag)
        {
            return ChipBuilder.HasTag((PlayerPort)this, tag);
        }

        public BoolPort HolsterObject(RecRoomObjectPort objectToHolster, BoolPort forceHolster, BoolPort steal)
        {
            return ChipBuilder.HolsterObject((PlayerPort)this, objectToHolster, forceHolster, steal);
        }

        public void IfHasTag(StringPort tag, AlternativeExec doesNotHaveTag)
        {
            ChipBuilder.IfHasTag((PlayerPort)this, tag, doesNotHaveTag);
        }

        public void IfLocalPlayerShouldRun(AlternativeExec shouldNotRun)
        {
            ChipBuilder.IfLocalPlayerShouldRun((PlayerPort)this, shouldNotRun);
        }

        public void IfPlayerHasRoleR1(StringPort role, AlternativeExec doesNotHaveRole)
        {
            ChipBuilder.IfPlayerHasRoleR1((PlayerPort)this, role, doesNotHaveRole);
        }

        public void IfPlayerIsLocal(AlternativeExec isNotLocal)
        {
            ChipBuilder.IfPlayerIsLocal((PlayerPort)this, isNotLocal);
        }

        public void IfPlayerIsValid(AlternativeExec isNotValid)
        {
            ChipBuilder.IfPlayerIsValid((PlayerPort)this, isNotValid);
        }

        public void IfPlayerIsValidAndLocal(AlternativeExec isNotValid, AlternativeExec isValidAndNotLocal)
        {
            ChipBuilder.IfPlayerIsValidAndLocal((PlayerPort)this, isNotValid, isValidAndNotLocal);
        }

        public IntPort LeaderboardGetPlayerStat(IntPort channel, AlternativeExec<IntPort> onGetStatComplete)
        {
            return ChipBuilder.LeaderboardGetPlayerStat((PlayerPort)this, channel, onGetStatComplete);
        }

        public void LocalPlayerClearPlayerVoiceRolloffOverrideR2()
        {
            ChipBuilder.LocalPlayerClearPlayerVoiceRolloffOverrideR2((PlayerPort)this);
        }

        public void LocalPlayerDisableInteractionWithTargetPlayer()
        {
            ChipBuilder.LocalPlayerDisableInteractionWithTargetPlayer((PlayerPort)this);
        }

        public void LocalPlayerEnableInteractionWithTargetPlayer(FloatPort requiredHoldDuration, StringPort prompt)
        {
            ChipBuilder.LocalPlayerEnableInteractionWithTargetPlayer((PlayerPort)this, requiredHoldDuration, prompt);
        }

        public void LocalPlayerSetPlayerNametagVisibility(BoolPort enabled)
        {
            ChipBuilder.LocalPlayerSetPlayerNametagVisibility((PlayerPort)this, enabled);
        }

        public void AddRoleR1(StringPort value)
        {
            ChipBuilder.PlayerAddRoleR1((PlayerPort)this, value);
        }

        public BoolPort AwardXP(IntPort amount, AlternativeExec<BoolPort> onAwardComplete)
        {
            return ChipBuilder.PlayerAwardXP((PlayerPort)this, amount, onAwardComplete);
        }

        public void ClearCurrentSubtitle()
        {
            ChipBuilder.PlayerClearCurrentSubtitle((PlayerPort)this);
        }

        public BoolPort EquipInventoryItemR2(InventoryItemPort inventoryItem, EquipmentSlotPort inventoryEquipmentSlot, AlternativeExec<BoolPort> onEquipComplete)
        {
            return ChipBuilder.PlayerEquipInventoryItemR2((PlayerPort)this, inventoryItem, inventoryEquipmentSlot, onEquipComplete);
        }

        public ListPort<StringPort> GetAimAssistTags()
        {
            return ChipBuilder.PlayerGetAimAssistTags((PlayerPort)this);
        }

        public BoolPort GetEquipmentSlotIsEnabledR2(EquipmentSlotPort equipmentSlot)
        {
            return ChipBuilder.PlayerGetEquipmentSlotIsEnabledR2((PlayerPort)this, equipmentSlot);
        }

        public BoolPort GetIsAuthorityOf(RecRoomObjectPort @object)
        {
            return ChipBuilder.PlayerGetIsAuthorityOf((PlayerPort)this, @object);
        }

        public (FloatPort VoiceRolloffDistance, BoolPort HasLocalOverride) GetVoiceRolloffDistanceR2()
        {
            return CircuitBuilder.Singleton("RRCG_Player_GetVoiceRolloffDistanceR2_" + PortKey(), () => ChipBuilder.PlayerGetVoiceRolloffDistanceR2((PlayerPort)this));
        }

        public BoolPort HasPurchasedRoomOfferR2(RoomOfferPort roomOffer, AlternativeExec<BoolPort> onPlayerHasPurchasedRoomOfferComplete)
        {
            return ChipBuilder.PlayerHasPurchasedRoomOfferR2((PlayerPort)this, roomOffer, onPlayerHasPurchasedRoomOfferComplete);
        }

        public BoolPort HasRoleR1(StringPort value)
        {
            return ChipBuilder.PlayerHasRoleR1((PlayerPort)this, value);
        }

        public BoolPort OwnsInventoryItemR2(InventoryItemPort inventoryItem, AlternativeExec<BoolPort> complete)
        {
            return ChipBuilder.PlayerOwnsInventoryItemR2((PlayerPort)this, inventoryItem, complete);
        }

        public BoolPort OwnsRoomKeyR1(RoomKeyPort roomKey, AlternativeExec<BoolPort> onPlayerOwnsRoomKeyComplete)
        {
            return ChipBuilder.PlayerOwnsRoomKeyR1((PlayerPort)this, roomKey, onPlayerOwnsRoomKeyComplete);
        }

        public (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex) PromptMultipleChoice(StringPort promptTitle, StringPort promptBody, ListPort<StringPort> answerChoices, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex)> onPromptComplete)
        {
            return ChipBuilder.PlayerPromptMultipleChoice((PlayerPort)this, promptTitle, promptBody, answerChoices, onPromptComplete);
        }

        public (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response) PromptText(StringPort promptTitle, StringPort promptBody, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response)> onPromptComplete)
        {
            return ChipBuilder.PlayerPromptText((PlayerPort)this, promptTitle, promptBody, onPromptComplete);
        }

        public void RemoveRoleR1(StringPort value)
        {
            ChipBuilder.PlayerRemoveRoleR1((PlayerPort)this, value);
        }

        public void ResetNameColor()
        {
            ChipBuilder.PlayerResetNameColor((PlayerPort)this);
        }

        public void SetEquipmentSlotIsEnabledR2(EquipmentSlotPort equipmentSlot, BoolPort isEnabled)
        {
            ChipBuilder.PlayerSetEquipmentSlotIsEnabledR2((PlayerPort)this, equipmentSlot, isEnabled);
        }

        public void ShowSubtitle(StringPort subtitle, FloatPort duration, IntPort priority)
        {
            ChipBuilder.PlayerShowSubtitle((PlayerPort)this, subtitle, duration, priority);
        }

        public BoolPort UnequipFromSlotR2(EquipmentSlotPort equipmentSlot, AlternativeExec<BoolPort> onUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipFromSlotR2((PlayerPort)this, equipmentSlot, onUnequipComplete);
        }

        public BoolPort UnequipInventoryItemR2(InventoryItemPort inventoryItem, AlternativeExec<BoolPort> onUnequipComplete)
        {
            return ChipBuilder.PlayerUnequipInventoryItemR2((PlayerPort)this, inventoryItem, onUnequipComplete);
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

        public void RemoveTag(StringPort tag)
        {
            ChipBuilder.RemoveTag((PlayerPort)this, tag);
        }

        public void RemoveTags(ListPort<StringPort> tags)
        {
            ChipBuilder.RemoveTags((PlayerPort)this, tags);
        }

        public void RequestVelocitySetOverDuration(FloatPort multiplier, Vector3Port velocity, FloatPort duration)
        {
            ChipBuilder.RequestVelocitySetOverDuration((PlayerPort)this, multiplier, velocity, duration);
        }

        public void ResetPlayerWorldUI()
        {
            ChipBuilder.ResetPlayerWorldUI((PlayerPort)this);
        }

        public BoolPort Respawn(Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            return ChipBuilder.Respawn((PlayerPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects);
        }

        public BoolPort Respawn(Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            return ChipBuilder.Respawn((PlayerPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects);
        }

        public void RespawnDeprecated(Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            ChipBuilder.RespawnDeprecated((PlayerPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects, failed);
        }

        public void RespawnDeprecated(Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            ChipBuilder.RespawnDeprecated((PlayerPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects, failed);
        }

        public void RespawnPointRespawnPlayer(BoolPort clearVelocity, BoolPort useRezEffects)
        {
            ChipBuilder.RespawnPointRespawnPlayer((PlayerPort)this, clearVelocity, useRezEffects);
        }

        public void RoomBackgroundObjectsClearPlayerOverrideR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomBackgroundObjectsClearPlayerOverrideR2((PlayerPort)this, blendTime, blendFinished);
        }

        public void RoomFogClearPlayerOverrideR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomFogClearPlayerOverrideR2((PlayerPort)this, blendTime, blendFinished);
        }

        public void RoomSkydomeClearPlayerOverrideR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSkydomeClearPlayerOverrideR2((PlayerPort)this, blendTime, blendFinished);
        }

        public void RoomSunClearPlayerOverrideR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSunClearPlayerOverrideR2((PlayerPort)this, blendTime, blendFinished);
        }

        public void SetCameraShake(FloatPort intensity, FloatPort duration)
        {
            ChipBuilder.SetCameraShake((PlayerPort)this, intensity, duration);
        }

        public void SetVignette(FloatPort time, ColorPort color, FloatPort intensity)
        {
            ChipBuilder.SetPlayerVignette((PlayerPort)this, time, color, intensity);
        }

        public void SetPositionDeprecated(Vector3Port position, AlternativeExec failed)
        {
            ChipBuilder.SetPositionDeprecated((PlayerPort)this, position, failed);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port position, PlayerPort referenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((PlayerPort)this, position, referenceObject);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port position, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((PlayerPort)this, position, referenceObject);
        }

        public BoolPort SetRotation(Vector3Port rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, rotation);
        }

        public BoolPort SetRotation(QuaternionPort rotation)
        {
            return ChipBuilder.SetRotation((PlayerPort)this, rotation);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((PlayerPort)this, rotation, referenceObject);
        }

        public BoolPort SetTransform(Vector3Port position, Vector3Port rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, position, rotation);
        }

        public BoolPort SetTransform(Vector3Port position, QuaternionPort rotation)
        {
            return ChipBuilder.SetTransform((PlayerPort)this, position, rotation);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, Vector3Port rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, QuaternionPort rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((PlayerPort)this, position, rotation, referenceObject);
        }

        public void ShowBannerNotification(StringPort title, StringPort mainText, FloatPort duration)
        {
            ChipBuilder.ShowBannerNotification((PlayerPort)this, title, mainText, duration);
        }

        public void ShowNotification<T>(StringPort value)
            where T : AnyPort, new()
        {
            ChipBuilder.ShowNotification<T>((PlayerPort)this, value);
        }

        public void ShowRewardNotification(RewardPort reward, FloatPort duration)
        {
            ChipBuilder.ShowRewardNotification((PlayerPort)this, reward, duration);
        }

        public void ShowRewardNotification(ListPort<RewardPort> reward, FloatPort duration)
        {
            ChipBuilder.ShowRewardNotification((PlayerPort)this, reward, duration);
        }

        public void StopCameraShake()
        {
            ChipBuilder.StopCameraShake((PlayerPort)this);
        }

        public ListPort<RecRoomObjectPort> UnequipFromSlotsR1(BoolPort dominantHand, BoolPort offHand, BoolPort leftHipHolster, BoolPort rightHipHolster, BoolPort shoulderHolster)
        {
            return ChipBuilder.UnequipFromSlotsR1((PlayerPort)this, dominantHand, offHand, leftHipHolster, rightHipHolster, shoulderHolster);
        }

        public void VelocityAdd(FloatPort multiplier, Vector3Port velocity, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityAdd((PlayerPort)this, multiplier, velocity, maximumSpeed);
        }

        public void VelocityAddDeprecated(FloatPort speed, Vector3Port direction, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityAddDeprecated((PlayerPort)this, speed, direction, maximumSpeed);
        }

        public void VelocityReflect(FloatPort additionalSpeed, FloatPort speedMultiplier, Vector3Port direction, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityReflect((PlayerPort)this, additionalSpeed, speedMultiplier, direction, maximumSpeed);
        }

        public void VelocitySet(FloatPort multiplier, Vector3Port velocity)
        {
            ChipBuilder.VelocitySet((PlayerPort)this, multiplier, velocity);
        }

        public void VelocitySetDeprecated(FloatPort speed, Vector3Port direction)
        {
            ChipBuilder.VelocitySetDeprecated((PlayerPort)this, speed, direction);
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

        public BoolPort AddAvoidRoleR1(StringPort role)
        {
            return ChipBuilder.RespawnPointAddAvoidRoleR1((PlayerSpawnPointV2Port)this, role);
        }

        public void AddAvoidTag(StringPort tag)
        {
            ChipBuilder.RespawnPointAddAvoidTag((PlayerSpawnPointV2Port)this, tag);
        }

        public BoolPort AddSpawnRoleR1(StringPort role)
        {
            return ChipBuilder.RespawnPointAddSpawnRoleR1((PlayerSpawnPointV2Port)this, role);
        }

        public void AddSpawnTag(StringPort tag)
        {
            ChipBuilder.RespawnPointAddSpawnTag((PlayerSpawnPointV2Port)this, tag);
        }

        public void RemoveAvoidRoleR1(StringPort role)
        {
            ChipBuilder.RespawnPointRemoveAvoidRoleR1((PlayerSpawnPointV2Port)this, role);
        }

        public void RemoveAvoidTag(StringPort tag)
        {
            ChipBuilder.RespawnPointRemoveAvoidTag((PlayerSpawnPointV2Port)this, tag);
        }

        public void RemoveSpawnRoleR1(StringPort role)
        {
            ChipBuilder.RespawnPointRemoveSpawnRoleR1((PlayerSpawnPointV2Port)this, role);
        }

        public void RemoveSpawnTag(StringPort tag)
        {
            ChipBuilder.RespawnPointRemoveSpawnTag((PlayerSpawnPointV2Port)this, tag);
        }

        public void RespawnPlayerAtRespawnPoint(PlayerPort player, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            ChipBuilder.RespawnPointRespawnPlayerAtRespawnPoint((PlayerSpawnPointV2Port)this, player, clearVelocity, useRezEffects);
        }
    }

    public abstract class PlayerWorldUIPortGen : AnyPort
    {
        public void DisplayPlayerWorldUI(PlayerPort player)
        {
            ChipBuilder.DisplayPlayerWorldUI((PlayerWorldUIPort)this, player);
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

        public void FireProjectile(Vector3Port direction)
        {
            ChipBuilder.ProjectileLauncherFireProjectile((ProjectileLauncherPort)this, direction);
        }
    }

    public abstract class QuickChatTablePortGen : AnyPort
    {
        public void SetEnabled(PlayerPort player, BoolPort enabled)
        {
            ChipBuilder.QuickChatTableSetEnabled((QuickChatTablePort)this, player, enabled);
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

        public void AddTag(StringPort tag)
        {
            ChipBuilder.AddTag((RecRoomObjectPort)this, tag);
        }

        public void AddTags(ListPort<StringPort> tags)
        {
            ChipBuilder.AddTags((RecRoomObjectPort)this, tags);
        }

        public BoolPort AngularVelocityAdd(Vector3Port angularVelocity, FloatPort speedMultiplier, FloatPort maxAngularSpeed)
        {
            return ChipBuilder.AngularVelocityAdd((RecRoomObjectPort)this, angularVelocity, speedMultiplier, maxAngularSpeed);
        }

        public void AngularVelocityAddDeprecated(Vector3Port rotation, FloatPort velocityMultiplier, FloatPort maxAngularVelocityApplied)
        {
            ChipBuilder.AngularVelocityAddDeprecated((RecRoomObjectPort)this, rotation, velocityMultiplier, maxAngularVelocityApplied);
        }

        public void AngularVelocityAddDeprecated(QuaternionPort rotation, FloatPort velocityMultiplier, FloatPort maxAngularVelocityApplied)
        {
            ChipBuilder.AngularVelocityAddDeprecated((RecRoomObjectPort)this, rotation, velocityMultiplier, maxAngularVelocityApplied);
        }

        public BoolPort AngularVelocitySet(Vector3Port angularVelocity, FloatPort speedMultiplier)
        {
            return ChipBuilder.AngularVelocitySet((RecRoomObjectPort)this, angularVelocity, speedMultiplier);
        }

        public void AngularVelocitySetDeprecated(Vector3Port rotation, FloatPort velocityMultiplier)
        {
            ChipBuilder.AngularVelocitySetDeprecated((RecRoomObjectPort)this, rotation, velocityMultiplier);
        }

        public void AngularVelocitySetDeprecated(QuaternionPort rotation, FloatPort velocityMultiplier)
        {
            ChipBuilder.AngularVelocitySetDeprecated((RecRoomObjectPort)this, rotation, velocityMultiplier);
        }

        public FloatPort Distance(AIPort b)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, b);
        }

        public FloatPort Distance(CombatantPort b)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, b);
        }

        public FloatPort Distance(RecRoomObjectPort b)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, b);
        }

        public FloatPort Distance(PlayerPort b)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, b);
        }

        public FloatPort Distance(Vector3Port b)
        {
            return ChipBuilder.Distance((RecRoomObjectPort)this, b);
        }

        public FloatPort DistanceDeprecated(AIPort b)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, b);
        }

        public FloatPort DistanceDeprecated(CombatantPort b)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, b);
        }

        public FloatPort DistanceDeprecated(RecRoomObjectPort b)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, b);
        }

        public FloatPort DistanceDeprecated(PlayerPort b)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, b);
        }

        public FloatPort DistanceDeprecated(Vector3Port b)
        {
            return ChipBuilder.DistanceDeprecated((RecRoomObjectPort)this, b);
        }

        public T FromRecRoomObject<T>()
            where T : AnyPort, new()
        {
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_FromRecRoomObject_" + PortKey(), () => ChipBuilder.FromRecRoomObject<T>((RecRoomObjectPort)this));
        }

        public (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<RecRoomObjectPort> targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, targets);
        }

        public (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<PlayerPort> targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, targets);
        }

        public (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(ListPort<Vector3Port> targets)
        {
            return ChipBuilder.GetClosest((RecRoomObjectPort)this, targets);
        }

        public (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<RecRoomObjectPort> targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, targets);
        }

        public (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<PlayerPort> targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, targets);
        }

        public (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(ListPort<Vector3Port> targets)
        {
            return ChipBuilder.GetFarthest((RecRoomObjectPort)this, targets);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(AIPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(CombatantPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public Vector3Port GetPositionInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetPositionInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort referenceObject)
        {
            return ChipBuilder.GetRotationInReferenceObjectSpace((RecRoomObjectPort)this, referenceObject);
        }

        public BoolPort HasTag(StringPort tag)
        {
            return ChipBuilder.HasTag((RecRoomObjectPort)this, tag);
        }

        public void IfHasTag(StringPort tag, AlternativeExec doesNotHaveTag)
        {
            ChipBuilder.IfHasTag((RecRoomObjectPort)this, tag, doesNotHaveTag);
        }

        public void Reset()
        {
            ChipBuilder.RecRoomObjectReset((RecRoomObjectPort)this);
        }

        public RecRoomObjectPort Variable(VariableData config)
        {
            return ChipBuilder.RecRoomObjectVariable((RecRoomObjectPort)this, config);
        }

        public void RemoveTag(StringPort tag)
        {
            ChipBuilder.RemoveTag((RecRoomObjectPort)this, tag);
        }

        public void RemoveTags(ListPort<StringPort> tags)
        {
            ChipBuilder.RemoveTags((RecRoomObjectPort)this, tags);
        }

        public void ReplicatorReturnObjectR2()
        {
            ChipBuilder.ReplicatorReturnObjectR2((RecRoomObjectPort)this);
        }

        public void RequestVelocitySetOverDuration(FloatPort multiplier, Vector3Port velocity, FloatPort duration)
        {
            ChipBuilder.RequestVelocitySetOverDuration((RecRoomObjectPort)this, multiplier, velocity, duration);
        }

        public BoolPort Respawn(Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            return ChipBuilder.Respawn((RecRoomObjectPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects);
        }

        public BoolPort Respawn(Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            return ChipBuilder.Respawn((RecRoomObjectPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects);
        }

        public void RespawnDeprecated(Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            ChipBuilder.RespawnDeprecated((RecRoomObjectPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects, failed);
        }

        public void RespawnDeprecated(Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            ChipBuilder.RespawnDeprecated((RecRoomObjectPort)this, position, rotation, spawnRadius, clearVelocity, useRezEffects, failed);
        }

        public void SetPositionDeprecated(Vector3Port position, AlternativeExec failed)
        {
            ChipBuilder.SetPositionDeprecated((RecRoomObjectPort)this, position, failed);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port position, PlayerPort referenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((RecRoomObjectPort)this, position, referenceObject);
        }

        public BoolPort SetPositionInReferenceObjectSpace(Vector3Port position, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetPositionInReferenceObjectSpace((RecRoomObjectPort)this, position, referenceObject);
        }

        public BoolPort SetRotation(Vector3Port rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, rotation);
        }

        public BoolPort SetRotation(QuaternionPort rotation)
        {
            return ChipBuilder.SetRotation((RecRoomObjectPort)this, rotation);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, rotation, referenceObject);
        }

        public BoolPort SetRotationInReferenceObjectSpace(QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetRotationInReferenceObjectSpace((RecRoomObjectPort)this, rotation, referenceObject);
        }

        public BoolPort SetTransform(Vector3Port position, Vector3Port rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, position, rotation);
        }

        public BoolPort SetTransform(Vector3Port position, QuaternionPort rotation)
        {
            return ChipBuilder.SetTransform((RecRoomObjectPort)this, position, rotation);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, Vector3Port rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, QuaternionPort rotation, PlayerPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, position, rotation, referenceObject);
        }

        public BoolPort SetTransformInReferenceObjectSpace(Vector3Port position, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            return ChipBuilder.SetTransformInReferenceObjectSpace((RecRoomObjectPort)this, position, rotation, referenceObject);
        }

        public void SpawnerInternalStartSpawningR1(IntPort amountOfObjectsToSpawn, FloatPort timeBetweenSpawns, Vector3Port spawnPosition)
        {
            ChipBuilder.SpawnerInternalStartSpawningR1((RecRoomObjectPort)this, amountOfObjectsToSpawn, timeBetweenSpawns, spawnPosition);
        }

        public void SpawnerResetR1()
        {
            ChipBuilder.SpawnerResetR1((RecRoomObjectPort)this);
        }

        public BoolPort UnequipObject()
        {
            return ChipBuilder.UnequipObject((RecRoomObjectPort)this);
        }

        public void VelocityAdd(FloatPort multiplier, Vector3Port velocity, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityAdd((RecRoomObjectPort)this, multiplier, velocity, maximumSpeed);
        }

        public void VelocityAddDeprecated(FloatPort speed, Vector3Port direction, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityAddDeprecated((RecRoomObjectPort)this, speed, direction, maximumSpeed);
        }

        public void VelocityReflect(FloatPort additionalSpeed, FloatPort speedMultiplier, Vector3Port direction, FloatPort maximumSpeed)
        {
            ChipBuilder.VelocityReflect((RecRoomObjectPort)this, additionalSpeed, speedMultiplier, direction, maximumSpeed);
        }

        public void VelocitySet(FloatPort multiplier, Vector3Port velocity)
        {
            ChipBuilder.VelocitySet((RecRoomObjectPort)this, multiplier, velocity);
        }

        public void VelocitySetDeprecated(FloatPort speed, Vector3Port direction)
        {
            ChipBuilder.VelocitySetDeprecated((RecRoomObjectPort)this, speed, direction);
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

        public (RecRoomObjectPort Object, BoolPort Success) SpawnNextObjectR2(Vector3Port position, QuaternionPort orientation, BoolPort assignToPlayer, PlayerPort player, AlternativeExec<(RecRoomObjectPort Object, BoolPort Success)> onSpawnComplete)
        {
            return ChipBuilder.ReplicatorSpawnNextObjectR2((ReplicatorPort)this, position, orientation, assignToPlayer, player, onSpawnComplete);
        }
    }

    public abstract class RewardPortGen : AnyPort
    {
    }

    public abstract class RoomCurrencyPortGen : AnyPort
    {
        public (BoolPort Success, IntPort TotalBalance) AwardCurrencyR1(PlayerPort player, IntPort amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onAwardCurrencyComplete)
        {
            return ChipBuilder.AwardCurrencyR1((RoomCurrencyPort)this, player, amount, onAwardCurrencyComplete);
        }

        public (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceR1(PlayerPort player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onGetBalanceComplete)
        {
            return ChipBuilder.GetCurrencyBalanceR1((RoomCurrencyPort)this, player, onGetBalanceComplete);
        }

        public void ShowPurchasePromptR1(PlayerPort player)
        {
            ChipBuilder.ShowPurchasePromptR1((RoomCurrencyPort)this, player);
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
        public BoolPort AwardRoomKeyR1(PlayerPort player, AlternativeExec<BoolPort> onAwardRoomKeyComplete)
        {
            return ChipBuilder.AwardRoomKeyR1((RoomKeyPort)this, player, onAwardRoomKeyComplete);
        }

        public void ShowPurchasePromptR1(PlayerPort player)
        {
            ChipBuilder.ShowPurchasePromptR1((RoomKeyPort)this, player);
        }
    }

    public abstract class RoomLevelHUDPortGen : AnyPort
    {
    }

    public abstract class RoomOfferPortGen : AnyPort
    {
        public void ShowPurchasePromptR2(PlayerPort player)
        {
            ChipBuilder.ShowPurchasePromptR2((RoomOfferPort)this, player);
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

        public void SetSeatedPlayer(PlayerPort player, AlternativeExec fail)
        {
            ChipBuilder.SeatSetSeatedPlayer((SeatPort)this, player, fail);
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
        public BoolPort RoomSkydomeModifyR1(AlternativeExec<BoolPort> blendFinished)
        {
            return ChipBuilder.RoomSkydomeModifyR1((SkydomePort)this, blendFinished);
        }

        public void RoomSkydomeModifyR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSkydomeModifyR2((SkydomePort)this, blendTime, blendFinished);
        }

        public void RoomSkydomePlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSkydomePlayerOverrideR2((SkydomePort)this, player, blendTime, blendFinished);
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

        public void StudioEventSender(StringPort @event)
        {
            ChipBuilder.StudioEventSender((StudioObjectPort)this, @event);
        }

        public void StudioEventSenderBool(StringPort @event, BoolPort value)
        {
            ChipBuilder.StudioEventSenderBool((StudioObjectPort)this, @event, value);
        }

        public void StudioEventSenderFloat(StringPort @event, FloatPort value)
        {
            ChipBuilder.StudioEventSenderFloat((StudioObjectPort)this, @event, value);
        }

        public void StudioEventSenderInt(StringPort @event, IntPort value)
        {
            ChipBuilder.StudioEventSenderInt((StudioObjectPort)this, @event, value);
        }

        public void StudioEventSenderString(StringPort @event, StringPort value)
        {
            ChipBuilder.StudioEventSenderString((StudioObjectPort)this, @event, value);
        }

        public void StudioEventSenderStringBool(StringPort @event, StringPort value0, BoolPort value1)
        {
            ChipBuilder.StudioEventSenderStringBool((StudioObjectPort)this, @event, value0, value1);
        }

        public void StudioEventSenderStringFloat(StringPort @event, StringPort value0, FloatPort value1)
        {
            ChipBuilder.StudioEventSenderStringFloat((StudioObjectPort)this, @event, value0, value1);
        }

        public void StudioEventSenderStringInt(StringPort @event, StringPort value0, IntPort value1)
        {
            ChipBuilder.StudioEventSenderStringInt((StudioObjectPort)this, @event, value0, value1);
        }

        public void StudioEventSenderStringString(StringPort @event, StringPort value0, StringPort value1)
        {
            ChipBuilder.StudioEventSenderStringString((StudioObjectPort)this, @event, value0, value1);
        }

        public BoolPort GetPropertyBool(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyBool((StudioObjectPort)this, property);
        }

        public ColorPort GetPropertyColor(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyColor((StudioObjectPort)this, property);
        }

        public FloatPort GetPropertyFloat(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyFloat((StudioObjectPort)this, property);
        }

        public IntPort GetPropertyInt(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyInt((StudioObjectPort)this, property);
        }

        public QuaternionPort GetPropertyQuaternion(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyQuaternion((StudioObjectPort)this, property);
        }

        public StringPort GetPropertyString(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyString((StudioObjectPort)this, property);
        }

        public Vector3Port GetPropertyVector3(StringPort property)
        {
            return ChipBuilder.StudioObjectGetPropertyVector3((StudioObjectPort)this, property);
        }
    }

    public abstract class SunPortGen : AnyPort
    {
        public BoolPort RoomSunModifyR1(SunDirectionPort sunDirection, AlternativeExec<BoolPort> blendFinished)
        {
            return ChipBuilder.RoomSunModifyR1((SunPort)this, sunDirection, blendFinished);
        }

        public void RoomSunModifyR2(SunDirectionPort sunDirection, FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSunModifyR2((SunPort)this, sunDirection, blendTime, blendFinished);
        }

        public void RoomSunPlayerOverrideR2(SunDirectionPort sunDirection, PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            ChipBuilder.RoomSunPlayerOverrideR2((SunPort)this, sunDirection, player, blendTime, blendFinished);
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

        public void PrintTextToScreen(StringPort text, ColorPort color)
        {
            ChipBuilder.PrintTextToScreen((TextScreenPort)this, text, color);
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
        public Vector3Port GetVector(FloatPort magnitude)
        {
            return ChipBuilder.VectorComponentGetVector((VectorComponentPort)this, magnitude);
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