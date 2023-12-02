using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;
using RRCG;

namespace RRCGGenerated
{
    public abstract class AIPortGen : AnyPort
    {
        public Vector3Port CombatantGetGroundPosition
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((AIPort)this));
        }

        public BoolPort CombatantGetIsAlive
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((AIPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_AI_CombatantGetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((AIPort)this));
        }

        public IntPort CombatantSetMaxHealth
        {
            set => ChipBuilder.CombatantSetMaxHealth((AIPort)this, value);
        }

        public (StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange) LineOfSightParameters
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetLineOfSightParameters_" + Port.PortKey(), () => ChipBuilder.AIGetLineOfSightParameters((AIPort)this));
        }

        public FloatPort PathingSpeed
        {
            set => ChipBuilder.AISetPathingSpeed((AIPort)this, value);
        }

        public PatrolPointPort PatrolPoint
        {
            set => ChipBuilder.AISetPatrolPoint((AIPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((AIPort)this));
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((AIPort)this));
        }

        public CombatantPort Target
        {
            get => CircuitBuilder.Singleton("RRCG_AI_GetTarget_" + Port.PortKey(), () => ChipBuilder.AIGetTarget((AIPort)this));
            set => ChipBuilder.AISetTarget((AIPort)this, value);
        }

        public CombatantPort ToCombatant
        {
            get => CircuitBuilder.Singleton("RRCG_AI_ToCombatant_" + Port.PortKey(), () => ChipBuilder.ToCombatant((AIPort)this));
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

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_AI_CombatantGetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((AIPort)this));
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
    }

    public abstract class AnalyticsPayloadPortGen : AnyPort
    {
    }

    public abstract class AnimationControllerPortGen : AnyPort
    {
        public IntPort Frame
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetFrame_" + Port.PortKey(), () => ChipBuilder.AnimationGetFrame((AnimationControllerPort)this));
            set => ChipBuilder.AnimationSetFrame((AnimationControllerPort)this, value);
        }

        public BoolPort IsPlaying
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetIsPlaying_" + Port.PortKey(), () => ChipBuilder.AnimationGetIsPlaying((AnimationControllerPort)this));
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetSpeed_" + Port.PortKey(), () => ChipBuilder.AnimationGetSpeed((AnimationControllerPort)this));
            set => ChipBuilder.AnimationSetSpeed((AnimationControllerPort)this, value);
        }

        public FloatPort TimeStamp
        {
            get => CircuitBuilder.Singleton("RRCG_AnimationController_GetTimeStamp_" + Port.PortKey(), () => ChipBuilder.AnimationGetTimeStamp((AnimationControllerPort)this));
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
            get => CircuitBuilder.Singleton("RRCG_Audio_GetLength_" + Port.PortKey(), () => ChipBuilder.AudioGetLength((AudioPort)this));
        }

        public void PlayAudioAtPosition(Vector3Port Position, FloatPort Volume, FloatPort PlaybackSpeed, BoolPort Is2D, PlayAudioAtPositionData config)
        {
            ChipBuilder.PlayAudioAtPosition((AudioPort)this, Position, Volume, PlaybackSpeed, Is2D, config);
        }
    }

    public abstract class AudioPlayerPortGen : AnyPort
    {
        public AudioPort Audio
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetAudio_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetAudio((AudioPlayerPort)this));
        }

        public FloatPort MaxRolloffDistance
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetMaxRolloffDistance_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetMaxRolloffDistance((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetMaxRolloffDistance((AudioPlayerPort)this, value);
        }

        public BoolPort Playing
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetPlaying_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetPlaying((AudioPlayerPort)this));
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetSpeed_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetSpeed((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetSpeed((AudioPlayerPort)this, value);
        }

        public FloatPort TimeStamp
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetTimeStamp_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetTimeStamp((AudioPlayerPort)this));
            set => ChipBuilder.AudioPlayerSetTimeStamp((AudioPlayerPort)this, value);
        }

        public FloatPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_AudioPlayer_GetVolume_" + Port.PortKey(), () => ChipBuilder.AudioPlayerGetVolume((AudioPlayerPort)this));
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
        public BoolPort RoomBackgroundObjectsModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomBackgroundObjectsModify((BackgroundObjectsPort)this, BlendFinished);
        }
    }

    public abstract class BeaconPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetColor_" + Port.PortKey(), () => ChipBuilder.BeaconGetColor((BeaconPort)this));
            set => ChipBuilder.BeaconSetColor((BeaconPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetEnabled_" + Port.PortKey(), () => ChipBuilder.BeaconGetEnabled((BeaconPort)this));
            set => ChipBuilder.BeaconSetEnabled((BeaconPort)this, value);
        }

        public FloatPort Height
        {
            get => CircuitBuilder.Singleton("RRCG_Beacon_GetHeight_" + Port.PortKey(), () => ChipBuilder.BeaconGetHeight((BeaconPort)this));
            set => ChipBuilder.BeaconSetHeight((BeaconPort)this, value);
        }
    }

    public abstract class ButtonPortGen : AnyPort
    {
        public BoolPort IsPressed
        {
            get => CircuitBuilder.Singleton("RRCG_Button_GetIsPressed_" + Port.PortKey(), () => ChipBuilder.ButtonGetIsPressed((ButtonPort)this));
        }

        public StringPort Text
        {
            get => CircuitBuilder.Singleton("RRCG_Button_GetText_" + Port.PortKey(), () => ChipBuilder.ButtonGetText((ButtonPort)this));
            set => ChipBuilder.ButtonSetText((ButtonPort)this, value);
        }
    }

    public abstract class CollisionDataPortGen : AnyPort
    {
        public FloatPort Distance
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetDistance_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetDistance((CollisionDataPort)this));
        }

        public Vector3Port Normal
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetNormal_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetNormal((CollisionDataPort)this));
        }

        public RecRoomObjectPort Object
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetObject_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetObject((CollisionDataPort)this));
        }

        public PlayerPort Player
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetPlayer_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPlayer((CollisionDataPort)this));
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionData_GetPosition_" + Port.PortKey(), () => ChipBuilder.CollisionDataGetPosition((CollisionDataPort)this));
        }
    }

    public abstract class CollisionDetectionVolumePortGen : AnyPort
    {
        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_CollisionDetectionVolume_GetEnabled_" + Port.PortKey(), () => ChipBuilder.CollisionDetectionVolumeGetEnabled((CollisionDetectionVolumePort)this));
            set => ChipBuilder.CollisionDetectionVolumeSetEnabled((CollisionDetectionVolumePort)this, value);
        }
    }

    public abstract class CombatantPortGen : AnyPort
    {
        public Vector3Port GroundPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((CombatantPort)this));
        }

        public BoolPort IsAlive
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((CombatantPort)this));
        }

        public IntPort MaxHealth
        {
            set => ChipBuilder.CombatantSetMaxHealth((CombatantPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((CombatantPort)this));
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((CombatantPort)this));
        }

        public (BoolPort IsPlayer, PlayerPort Player, AIPort AI) Split
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_Split_" + Port.PortKey(), () => ChipBuilder.CombatantSplit((CombatantPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) Velocity
        {
            get => CircuitBuilder.Singleton("RRCG_Combatant_GetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((CombatantPort)this));
        }

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) GetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_Combatant_GetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((CombatantPort)this));
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
    }

    public abstract class ConsumablePortGen : AnyPort
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

    public abstract class CostumePortGen : AnyPort
    {
        public PlayerPort Wearer
        {
            get => CircuitBuilder.Singleton("RRCG_Costume_GetWearer_" + Port.PortKey(), () => ChipBuilder.CostumeGetWearer((CostumePort)this));
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
        public DestinationRoomPort Variable()
        {
            return ChipBuilder.DestinationRoomVariable((DestinationRoomPort)this);
        }
    }

    public abstract class DialogueUIPortGen : AnyPort
    {
        public (StringPort BodyText, BoolPort IsInteractive) DialogueText
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetDialogueText_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetDialogueText((DialogueUIPort)this));
        }

        public BoolPort IsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetIsEnabled_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetIsEnabled((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetIsEnabled((DialogueUIPort)this, value);
        }

        public BoolPort TitleIsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleIsEnabled_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetTitleIsEnabled((DialogueUIPort)this));
            set => ChipBuilder.DialogueUISetTitleIsEnabled((DialogueUIPort)this, value);
        }

        public StringPort TitleText
        {
            get => CircuitBuilder.Singleton("RRCG_DialogueUI_GetTitleText_" + Port.PortKey(), () => ChipBuilder.DialogueUIGetTitleText((DialogueUIPort)this));
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
            get => CircuitBuilder.Singleton("RRCG_Die_GetPlayerRolled_" + Port.PortKey(), () => ChipBuilder.DiceGetPlayerRolled((DiePort)this));
        }

        public IntPort Result
        {
            get => CircuitBuilder.Singleton("RRCG_Die_GetResult_" + Port.PortKey(), () => ChipBuilder.DiceGetResult((DiePort)this));
        }

        public BoolPort RollFinished
        {
            get => CircuitBuilder.Singleton("RRCG_Die_GetRollFinished_" + Port.PortKey(), () => ChipBuilder.DiceGetRollFinished((DiePort)this));
        }
    }

    public abstract class EmitterPortGen : AnyPort
    {
        public ColorPort Color
        {
            set => ChipBuilder.EmitterSetColor((EmitterPort)this, value);
        }

        public IntPort ColorId
        {
            set => ChipBuilder.EmitterSetColorId((EmitterPort)this, value);
        }

        public BoolPort Looping
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetLooping_" + Port.PortKey(), () => ChipBuilder.EmitterGetLooping((EmitterPort)this));
            set => ChipBuilder.EmitterSetLooping((EmitterPort)this, value);
        }

        public BoolPort Playing
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetPlaying_" + Port.PortKey(), () => ChipBuilder.EmitterGetPlaying((EmitterPort)this));
        }

        public FloatPort Size
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetSize_" + Port.PortKey(), () => ChipBuilder.EmitterGetSize((EmitterPort)this));
            set => ChipBuilder.EmitterSetSize((EmitterPort)this, value);
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_Emitter_GetSpeed_" + Port.PortKey(), () => ChipBuilder.EmitterGetSpeed((EmitterPort)this));
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
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetDamage_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetDamage((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetDamage((ExplosionEmitterPort)this, value);
        }

        public ColorPort ExplosionColor
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionColor_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionColor((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetExplosionColor((ExplosionEmitterPort)this, value);
        }

        public FloatPort ExplosionRadius
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetExplosionRadius_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetExplosionRadius((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetExplosionRadius((ExplosionEmitterPort)this, value);
        }

        public PlayerPort FiringPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_ExplosionEmitter_GetFiringPlayer_" + Port.PortKey(), () => ChipBuilder.ExplosionEmitterGetFiringPlayer((ExplosionEmitterPort)this));
            set => ChipBuilder.ExplosionEmitterSetFiringPlayer((ExplosionEmitterPort)this, value);
        }

        public void Explode()
        {
            ChipBuilder.ExplosionEmitterExplode((ExplosionEmitterPort)this);
        }
    }

    public abstract class FogPortGen : AnyPort
    {
        public BoolPort RoomFogModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomFogModify((FogPort)this, BlendFinished);
        }
    }

    public abstract class GiftDropShopItemPortGen : AnyPort
    {
    }

    public abstract class GrabberPortGen : AnyPort
    {
        public (BoolPort HasHeldObject, RecRoomObjectPort HeldObject) HeldObject
        {
            get => CircuitBuilder.Singleton("RRCG_Grabber_GetHeldObject_" + Port.PortKey(), () => ChipBuilder.GrabberGetHeldObject((GrabberPort)this));
        }

        public BoolPort PlayerCanStealFromGrabber
        {
            set => ChipBuilder.GrabberSetPlayerCanStealFromGrabber((GrabberPort)this, value);
        }

        public BoolPort GrabObject(RecRoomObjectPort Object, BoolPort StealfromPlayer, BoolPort SnaptoGrabber)
        {
            return ChipBuilder.GrabberGrabObject((GrabberPort)this, Object, StealfromPlayer, SnaptoGrabber);
        }

        public RecRoomObjectPort Release()
        {
            return ChipBuilder.GrabberRelease((GrabberPort)this);
        }
    }

    public abstract class GroundVehiclePortGen : AnyPort
    {
        public IntPort BoostFuel
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetBoostFuel_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetBoostFuel((GroundVehiclePort)this));
        }

        public BoolPort DrivingEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetDrivingEnabled_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetDrivingEnabled((GroundVehiclePort)this));
            set => ChipBuilder.GroundVehicleSetDrivingEnabled((GroundVehiclePort)this, value);
        }

        public FloatPort EngineTorqueMultiplier
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetEngineTorqueMultiplier_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetEngineTorqueMultiplier((GroundVehiclePort)this));
            set => ChipBuilder.GroundVehicleSetEngineTorqueMultiplier((GroundVehiclePort)this, value);
        }

        public FloatPort WheelFrictionMultiplier
        {
            get => CircuitBuilder.Singleton("RRCG_GroundVehicle_GetWheelFrictionMultiplier_" + Port.PortKey(), () => ChipBuilder.GroundVehicleGetWheelFrictionMultiplier((GroundVehiclePort)this));
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

        public ListPort<StringPort> AutoAimRoles
        {
            set => ChipBuilder.GunHandleSetAutoAimRoles((GunHandlePort)this, value);
        }

        public IntPort CurrentAmmo
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetCurrentAmmo_" + Port.PortKey(), () => ChipBuilder.GunHandleGetCurrentAmmo((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetCurrentAmmo((GunHandlePort)this, value);
        }

        public BoolPort IsReloading
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetIsReloading_" + Port.PortKey(), () => ChipBuilder.GunHandleGetIsReloading((GunHandlePort)this));
        }

        public IntPort MaxAmmo
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetMaxAmmo_" + Port.PortKey(), () => ChipBuilder.GunHandleGetMaxAmmo((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetMaxAmmo((GunHandlePort)this, value);
        }

        public FloatPort RateOfFire
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetRateOfFire_" + Port.PortKey(), () => ChipBuilder.GunHandleGetRateOfFire((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetRateOfFire((GunHandlePort)this, value);
        }

        public FloatPort ReloadDuration
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetReloadDuration_" + Port.PortKey(), () => ChipBuilder.GunHandleGetReloadDuration((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetReloadDuration((GunHandlePort)this, value);
        }

        public StringPort RemoveAutoAimRole
        {
            set => ChipBuilder.GunHandleRemoveAutoAimRole((GunHandlePort)this, value);
        }

        public BoolPort SupportsReload
        {
            get => CircuitBuilder.Singleton("RRCG_GunHandle_GetSupportsReload_" + Port.PortKey(), () => ChipBuilder.GunHandleGetSupportsReload((GunHandlePort)this));
            set => ChipBuilder.GunHandleSetSupportsReload((GunHandlePort)this, value);
        }

        public void AddAutoAimRole(StringPort Role)
        {
            ChipBuilder.GunHandleAddAutoAimRole((GunHandlePort)this, Role);
        }

        public void ApplyRecoil(FloatPort AngleX, FloatPort AngleY, FloatPort Duration, FloatPort ReturnDuration)
        {
            ChipBuilder.GunHandleApplyRecoil((GunHandlePort)this, AngleX, AngleY, Duration, ReturnDuration);
        }

        public Vector3Port GetFiringDirection(RecRoomObjectPort Source)
        {
            return ChipBuilder.GunHandleGetFiringDirection((GunHandlePort)this, Source);
        }

        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((GunHandlePort)this, Duration, Intensity);
        }
    }

    public abstract class HolotarProjectorPortGen : AnyPort
    {
    }

    public abstract class HUDConstantPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetColor_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementColor((HUDConstantPort)this));
            set => ChipBuilder.SetGameHUDElementColor((HUDConstantPort)this, value);
        }

        public BoolPort Enabled
        {
            set => ChipBuilder.SetHUDElementEnabled((HUDConstantPort)this, value);
        }

        public StringPort Label
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetLabel_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementLabel((HUDConstantPort)this));
            set => ChipBuilder.SetGameHUDElementLabel((HUDConstantPort)this, value);
        }

        public BoolPort LabelEnabled
        {
            set => ChipBuilder.SetGameHUDElementLabelEnabled((HUDConstantPort)this, value);
        }

        public IntPort MaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetMaxValue_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementMaxValue((HUDConstantPort)this));
            set => ChipBuilder.SetGameHUDElementMaxValue((HUDConstantPort)this, value);
        }

        public IntPort Value
        {
            get => CircuitBuilder.Singleton("RRCG_HUDConstant_GetValue_" + Port.PortKey(), () => ChipBuilder.GetGameHUDElementValue((HUDConstantPort)this));
            set => ChipBuilder.SetGameHUDElementValue((HUDConstantPort)this, value);
        }

        public BoolPort ValueTextEnabled
        {
            set => ChipBuilder.SetGameHUDElementValueTextEnabled((HUDConstantPort)this, value);
        }
    }

    public abstract class HUDElementPortGen : AnyPort
    {
        public void GameHUDElementSetAllValues()
        {
            ChipBuilder.GameHUDElementSetAllValues((HUDElementPort)this);
        }
    }

    public abstract class InteractionVolumePortGen : AnyPort
    {
        public FloatPort HoldTime
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetHoldTime_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetHoldTime((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetHoldTime((InteractionVolumePort)this, value);
        }

        public StringPort InteractionPrompt
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetInteractionPrompt_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetInteractionPrompt((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetInteractionPrompt((InteractionVolumePort)this, value);
        }

        public BoolPort IsLocked
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetIsLocked_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetIsLocked((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetLocked((InteractionVolumePort)this, value);
        }

        public FloatPort NormalizedHoldProgress
        {
            get => CircuitBuilder.Singleton("RRCG_InteractionVolume_GetNormalizedHoldProgress_" + Port.PortKey(), () => ChipBuilder.InteractionVolumeGetNormalizedHoldProgress((InteractionVolumePort)this));
            set => ChipBuilder.InteractionVolumeSetNormalizedHoldProgress((InteractionVolumePort)this, value);
        }
    }

    public abstract class InventoryItemPortGen : AnyPort
    {
        public (StringPort Name, StringPort Description, BoolPort SupportsUseAction) Definition
        {
            get => CircuitBuilder.Singleton("RRCG_InventoryItem_GetDefinition_" + Port.PortKey(), () => ChipBuilder.InventoryItemGetDefinition((InventoryItemPort)this));
        }

        public (BoolPort Success, IntPort TotalCount) Add(PlayerPort Player, IntPort Quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> Complete)
        {
            return ChipBuilder.InventoryItemAdd((InventoryItemPort)this, Player, Quantity, Complete);
        }

        public IntPort GetCount(PlayerPort Player, AlternativeExec<IntPort> Complete)
        {
            return ChipBuilder.InventoryItemGetCount((InventoryItemPort)this, Player, Complete);
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

    public abstract class InvisibleCollisionPortGen : AnyPort
    {
        public BoolPort BlocksPlayers
        {
            get => CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetBlocksPlayers_" + Port.PortKey(), () => ChipBuilder.InvisibleCollisionGetBlocksPlayers((InvisibleCollisionPort)this));
            set => ChipBuilder.InvisibleCollisionSetBlocksPlayers((InvisibleCollisionPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_InvisibleCollision_GetEnabled_" + Port.PortKey(), () => ChipBuilder.InvisibleCollisionGetEnabled((InvisibleCollisionPort)this));
            set => ChipBuilder.InvisibleCollisionSetEnabled((InvisibleCollisionPort)this, value);
        }
    }

    public abstract class LaserPointerPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetColor_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetColor((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetColor((LaserPointerPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetEnabled_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetEnabled((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetEnabled((LaserPointerPort)this, value);
        }

        public FloatPort Length
        {
            get => CircuitBuilder.Singleton("RRCG_LaserPointer_GetLength_" + Port.PortKey(), () => ChipBuilder.LaserPointerGetLength((LaserPointerPort)this));
            set => ChipBuilder.LaserPointerSetLength((LaserPointerPort)this, value);
        }
    }

    public abstract class LightPortGen : AnyPort
    {
        public FloatPort Angle
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetAngle_" + Port.PortKey(), () => ChipBuilder.LightGetAngle((LightPort)this));
            set => ChipBuilder.LightSetAngle((LightPort)this, value);
        }

        public IntPort AngleInt
        {
            set => ChipBuilder.LightSetAngleInt((LightPort)this, value);
        }

        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetColor_" + Port.PortKey(), () => ChipBuilder.LightGetColor((LightPort)this));
            set => ChipBuilder.LightSetColor((LightPort)this, value);
        }

        public IntPort ColorId
        {
            set => ChipBuilder.LightSetColorId((LightPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetEnabled_" + Port.PortKey(), () => ChipBuilder.LightGetEnabled((LightPort)this));
        }

        public FloatPort Intensity
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetIntensity_" + Port.PortKey(), () => ChipBuilder.LightGetIntensity((LightPort)this));
            set => ChipBuilder.LightSetIntensity((LightPort)this, value);
        }

        public IntPort IntensityInt
        {
            set => ChipBuilder.LightSetIntensityInt((LightPort)this, value);
        }

        public FloatPort Range
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetRange_" + Port.PortKey(), () => ChipBuilder.LightGetRange((LightPort)this));
            set => ChipBuilder.LightSetRange((LightPort)this, value);
        }

        public IntPort RangeInt
        {
            set => ChipBuilder.LightSetRangeInt((LightPort)this, value);
        }

        public FloatPort Softness
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetSoftness_" + Port.PortKey(), () => ChipBuilder.LightGetSoftness((LightPort)this));
            set => ChipBuilder.LightSetSoftness((LightPort)this, value);
        }

        public FloatPort SpecularContribution
        {
            get => CircuitBuilder.Singleton("RRCG_Light_GetSpecularContribution_" + Port.PortKey(), () => ChipBuilder.LightGetSpecularContribution((LightPort)this));
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

    public abstract class MeleeZonePortGen : AnyPort
    {
    }

    public abstract class MotionTrailPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetColor_" + Port.PortKey(), () => ChipBuilder.TrailGetColor((MotionTrailPort)this));
            set => ChipBuilder.TrailSetColor((MotionTrailPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetEnabled_" + Port.PortKey(), () => ChipBuilder.TrailGetEnabled((MotionTrailPort)this));
            set => ChipBuilder.TrailSetEnabled((MotionTrailPort)this, value);
        }

        public FloatPort Lifetime
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetLifetime_" + Port.PortKey(), () => ChipBuilder.TrailGetLifetime((MotionTrailPort)this));
            set => ChipBuilder.TrailSetLifetime((MotionTrailPort)this, value);
        }

        public FloatPort Opacity
        {
            get => CircuitBuilder.Singleton("RRCG_MotionTrail_GetOpacity_" + Port.PortKey(), () => ChipBuilder.TrailGetOpacity((MotionTrailPort)this));
            set => ChipBuilder.TrailSetOpacity((MotionTrailPort)this, value);
        }
    }

    public abstract class ObjectiveMarkerPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetColor_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetColor((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetColor((ObjectiveMarkerPort)this, value);
        }

        public FloatPort CurrentDistance
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetCurrentDistance_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetCurrentDistance((ObjectiveMarkerPort)this));
        }

        public BoolPort DistanceEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetDistanceEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetDistanceEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetDistanceEnabled((ObjectiveMarkerPort)this, value);
        }

        public BoolPort Enabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetEnabled((ObjectiveMarkerPort)this, value);
        }

        public FloatPort FadeThreshold
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetFadeThreshold_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetFadeThreshold((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetFadeThreshold((ObjectiveMarkerPort)this, value);
        }

        public StringPort Label
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabel_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabel((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetLabel((ObjectiveMarkerPort)this, value);
        }

        public BoolPort LabelEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetLabelEnabled_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetLabelEnabled((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetLabelEnabled((ObjectiveMarkerPort)this, value);
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetPosition_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetPosition((ObjectiveMarkerPort)this));
            set => ChipBuilder.ObjectiveMarkerSetPosition((ObjectiveMarkerPort)this, value);
        }

        public RecRoomObjectPort TargetObject
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetObject_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetObject((ObjectiveMarkerPort)this));
        }

        public PlayerPort TargetPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_ObjectiveMarker_GetTargetPlayer_" + Port.PortKey(), () => ChipBuilder.ObjectiveMarkerGetTargetPlayer((ObjectiveMarkerPort)this));
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

    public abstract class PatrolPointPortGen : AnyPort
    {
    }

    public abstract class PistonPortGen : AnyPort
    {
        public FloatPort Acceleration
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetAcceleration_" + Port.PortKey(), () => ChipBuilder.PistonGetAcceleration((PistonPort)this));
            set => ChipBuilder.PistonSetAcceleration((PistonPort)this, value);
        }

        public FloatPort Distance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetDistance((PistonPort)this));
            set => ChipBuilder.PistonSetDistance((PistonPort)this, value);
        }

        public FloatPort MaxDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetMaxDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetMaxDistance((PistonPort)this));
            set => ChipBuilder.PistonSetMaxDistance((PistonPort)this, value);
        }

        public FloatPort Speed
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetSpeed_" + Port.PortKey(), () => ChipBuilder.PistonGetSpeed((PistonPort)this));
            set => ChipBuilder.PistonSetSpeed((PistonPort)this, value);
        }

        public FloatPort TargetDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Piston_GetTargetDistance_" + Port.PortKey(), () => ChipBuilder.PistonGetTargetDistance((PistonPort)this));
            set => ChipBuilder.PistonSetTargetDistance((PistonPort)this, value);
        }
    }

    public abstract class PlayerPortGen : AnyPort
    {
        public StringPort AccountName
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetAccountName_" + Port.PortKey(), () => ChipBuilder.GetPlayerAccountName((PlayerPort)this));
        }

        public QuaternionPort BodyOrientation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_BodyOrientation_" + Port.PortKey(), () => ChipBuilder.PlayerBodyOrientation((PlayerPort)this));
        }

        public Vector3Port BodyPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_BodyPosition_" + Port.PortKey(), () => ChipBuilder.PlayerBodyPosition((PlayerPort)this));
        }

        public BoolPort CanTeleport
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCanTeleport_" + Port.PortKey(), () => ChipBuilder.PlayerGetCanTeleport((PlayerPort)this));
            set => ChipBuilder.PlayerSetCanTeleport((PlayerPort)this, value);
        }

        public Vector3Port CombatantGetGroundPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetGroundPosition_" + Port.PortKey(), () => ChipBuilder.CombatantGetGroundPosition((PlayerPort)this));
        }

        public BoolPort CombatantGetIsAlive
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetIsAlive_" + Port.PortKey(), () => ChipBuilder.CombatantGetIsAlive((PlayerPort)this));
        }

        public (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_CombatantGetVelocity_" + Port.PortKey(), () => ChipBuilder.CombatantGetVelocity((PlayerPort)this));
        }

        public IntPort CombatantSetMaxHealth
        {
            set => ChipBuilder.CombatantSetMaxHealth((PlayerPort)this, value);
        }

        public CostumePort Costume
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCostume_" + Port.PortKey(), () => ChipBuilder.PlayerGetCostume((PlayerPort)this));
        }

        public BoolPort CrouchInputEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetCrouchInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetCrouchInputEnabled((PlayerPort)this));
            set => ChipBuilder.PlayerSetCrouchInputEnabled((PlayerPort)this, value);
        }

        public BoolPort DominantHandIsRight
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetDominantHandIsRight_" + Port.PortKey(), () => ChipBuilder.PlayerGetDominantHandIsRight((PlayerPort)this));
        }

        public (RecRoomObjectPort DominantHandObject, RecRoomObjectPort OffHandObject, RecRoomObjectPort LeftHipHolsterObject, RecRoomObjectPort RightHipHolsterObject, RecRoomObjectPort ShoulderHolsterObject) EquippedObjects
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetEquippedObjects_" + Port.PortKey(), () => ChipBuilder.PlayerGetEquippedObjects((PlayerPort)this));
        }

        public StringPort FirstTag
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetFirstTag_" + Port.PortKey(), () => ChipBuilder.GetFirstTag((PlayerPort)this));
        }

        public BoolPort ForceManualSprint
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceManualSprint_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceManualSprint((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceManualSprint((PlayerPort)this, value);
        }

        public BoolPort ForceVirtualHeightMode
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceVirtualHeightMode_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceVirtualHeightMode((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceVirtualHeightMode((PlayerPort)this, value);
        }

        public BoolPort ForceVRWalk
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForceVRWalk_" + Port.PortKey(), () => ChipBuilder.PlayerGetForceVRWalk((PlayerPort)this));
            set => ChipBuilder.PlayerSetForceVRWalk((PlayerPort)this, value);
        }

        public Vector3Port ForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForwardVector_" + Port.PortKey(), () => ChipBuilder.GetForwardVector((PlayerPort)this));
        }

        public Vector3Port ForwardVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetForwardVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((PlayerPort)this));
        }

        public AlternativeExec<(BoolPort Success, IntPort TotalBalance)> GetCurrencyBalance
        {
            set => ChipBuilder.GetCurrencyBalance((PlayerPort)this, value);
        }

        public DestinationRoomPort GoToRoom
        {
            set => ChipBuilder.GoToRoom((PlayerPort)this, value);
        }

        public Vector3Port HeadForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadForwardVector_" + Port.PortKey(), () => ChipBuilder.PlayerHeadForwardVector((PlayerPort)this));
        }

        public FloatPort HeadHeight
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadHeight_" + Port.PortKey(), () => ChipBuilder.PlayerHeadHeight((PlayerPort)this));
        }

        public QuaternionPort HeadOrientation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadOrientation_" + Port.PortKey(), () => ChipBuilder.PlayerHeadOrientation((PlayerPort)this));
        }

        public Vector3Port HeadPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadPosition_" + Port.PortKey(), () => ChipBuilder.PlayerHeadPosition((PlayerPort)this));
        }

        public Vector3Port HeadUpVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadUpVector_" + Port.PortKey(), () => ChipBuilder.PlayerHeadUpVector((PlayerPort)this));
        }

        public Vector3Port HeadVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_HeadVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerHeadVelocity((PlayerPort)this));
        }

        public BoolPort IsClambering
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsClambering_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsClambering((PlayerPort)this));
        }

        public BoolPort IsCrouching
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsCrouching_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsCrouching((PlayerPort)this));
        }

        public (BoolPort IsGrounded, FloatPort TimeSinceLastGrounded, RecRoomObjectPort SurfaceObject, Vector3Port SurfaceNormal) IsGrounded
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsGrounded_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsGrounded((PlayerPort)this));
        }

        public BoolPort IsHoldingMakerPen
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsHoldingMakerPen_" + Port.PortKey(), () => ChipBuilder.PlayerIsHoldingMakerPen((PlayerPort)this));
        }

        public BoolPort IsInParty
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsInParty_" + Port.PortKey(), () => ChipBuilder.PlayerIsInParty((PlayerPort)this));
        }

        public (BoolPort IsJumpingOrFalling, RecRoomObjectPort ContactSurface) IsJumpingOrFalling
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsJumpingOrFalling_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsJumpingOrFalling((PlayerPort)this));
        }

        public BoolPort IsLocal
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsLocal_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsLocal((PlayerPort)this));
        }

        public BoolPort IsProne
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsProne_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsProne((PlayerPort)this));
        }

        public BoolPort IsRoomHost
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsRoomHost_" + Port.PortKey(), () => ChipBuilder.PlayerIsRoomHost((PlayerPort)this));
        }

        public BoolPort IsRoomMod
        {
            get => CircuitBuilder.Singleton("RRCG_Player_IsRoomMod_" + Port.PortKey(), () => ChipBuilder.PlayerIsRoomMod((PlayerPort)this));
        }

        public BoolPort IsRoomOwner
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsRoomOwner_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsRoomOwner((PlayerPort)this));
        }

        public BoolPort IsSliding
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsSliding_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsSliding((PlayerPort)this));
        }

        public BoolPort IsSprinting
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetIsSprinting_" + Port.PortKey(), () => ChipBuilder.PlayerGetIsSprinting((PlayerPort)this));
        }

        public FloatPort JumpHeight
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetJumpHeight_" + Port.PortKey(), () => ChipBuilder.PlayerGetJumpHeight((PlayerPort)this));
            set => ChipBuilder.PlayerSetJumpHeight((PlayerPort)this, value);
        }

        public BoolPort JumpInputEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetJumpInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetJumpInputEnabled((PlayerPort)this));
            set => ChipBuilder.PlayerSetJumpInputEnabled((PlayerPort)this, value);
        }

        public Vector3Port LeftHandFingerDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandFingerDirection_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandPosition_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandPosition((PlayerPort)this));
        }

        public QuaternionPort LeftHandRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandRotation_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandRotation((PlayerPort)this));
        }

        public Vector3Port LeftHandThumbDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandThumbDirection_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port LeftHandVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_LeftHandVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerLeftHandVelocity((PlayerPort)this));
        }

        public ColorPort NameColor
        {
            set => ChipBuilder.PlayerSetNameColor((PlayerPort)this, value);
        }

        public FloatPort NormalizedSteeringSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetNormalizedSteeringSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetNormalizedSteeringSpeed((PlayerPort)this));
        }

        public ListPort<PlayerPort> PartyOfPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPartyOfPlayer_" + Port.PortKey(), () => ChipBuilder.GetPartyOfPlayer((PlayerPort)this));
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((PlayerPort)this));
            set => ChipBuilder.SetPosition((PlayerPort)this, value);
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((PlayerPort)this));
        }

        public IntPort RadioChannel
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRadioChannel_" + Port.PortKey(), () => ChipBuilder.PlayerGetRadioChannel((PlayerPort)this));
            set => ChipBuilder.PlayerSetRadioChannel((PlayerPort)this, value);
        }

        public StringPort RemoveRole
        {
            set => ChipBuilder.PlayerRemoveRole((PlayerPort)this, value);
        }

        public Vector3Port RightHandFingerDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandFingerDirection_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandFingerDirection((PlayerPort)this));
        }

        public Vector3Port RightHandPosition
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandPosition_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandPosition((PlayerPort)this));
        }

        public QuaternionPort RightHandRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandRotation_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandRotation((PlayerPort)this));
        }

        public Vector3Port RightHandThumbDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandThumbDirection_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandThumbDirection((PlayerPort)this));
        }

        public Vector3Port RightHandVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_RightHandVelocity_" + Port.PortKey(), () => ChipBuilder.PlayerRightHandVelocity((PlayerPort)this));
        }

        public IntPort RoomIndex
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRoomIndex_" + Port.PortKey(), () => ChipBuilder.PlayerGetRoomIndex((PlayerPort)this));
        }

        public IntPort RoomLevel
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRoomLevel_" + Port.PortKey(), () => ChipBuilder.PlayerGetRoomLevel((PlayerPort)this));
        }

        public QuaternionPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRotation_" + Port.PortKey(), () => ChipBuilder.GetRotation((PlayerPort)this));
        }

        public QuaternionPort RotationDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetRotationDeprecated_" + Port.PortKey(), () => ChipBuilder.GetRotationDeprecated((PlayerPort)this));
        }

        public StringPort SeasonLeagueName
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSeasonLeagueName_" + Port.PortKey(), () => ChipBuilder.GetPlayerSeasonLeagueName((PlayerPort)this));
        }

        public SeatPort Seat
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSeat_" + Port.PortKey(), () => ChipBuilder.PlayerGetSeat((PlayerPort)this));
        }

        public BoolPort SprintInputEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSprintInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetSprintInputEnabled((PlayerPort)this));
            set => ChipBuilder.PlayerSetSprintInputEnabled((PlayerPort)this, value);
        }

        public FloatPort SprintSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSprintSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetSprintSpeed((PlayerPort)this));
            set => ChipBuilder.PlayerSetSprintSpeed((PlayerPort)this, value);
        }

        public Vector3Port SteeringDirection
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetSteeringDirection_" + Port.PortKey(), () => ChipBuilder.PlayerGetSteeringDirection((PlayerPort)this));
        }

        public (BoolPort Result, IntPort SecondsUntilEnabled) SubscribesToRoomOwner
        {
            get => CircuitBuilder.Singleton("RRCG_Player_SubscribesToRoomOwner_" + Port.PortKey(), () => ChipBuilder.PlayerSubscribesToRoomOwner((PlayerPort)this));
        }

        public ListPort<StringPort> Tags
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTags_" + Port.PortKey(), () => ChipBuilder.GetTags((PlayerPort)this));
        }

        public FloatPort TeleportDelay
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTeleportDelay_" + Port.PortKey(), () => ChipBuilder.PlayerGetTeleportDelay((PlayerPort)this));
            set => ChipBuilder.PlayerSetTeleportDelay((PlayerPort)this, value);
        }

        public FloatPort TeleportDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTeleportDistance_" + Port.PortKey(), () => ChipBuilder.PlayerGetTeleportDistance((PlayerPort)this));
            set => ChipBuilder.PlayerSetTeleportDistance((PlayerPort)this, value);
        }

        public IntPort TimeZone
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetTimeZone_" + Port.PortKey(), () => ChipBuilder.PlayerGetTimeZone((PlayerPort)this));
        }

        public CombatantPort ToCombatant
        {
            get => CircuitBuilder.Singleton("RRCG_Player_ToCombatant_" + Port.PortKey(), () => ChipBuilder.ToCombatant((PlayerPort)this));
        }

        public RecRoomObjectPort UnequipFromPlayer
        {
            set => ChipBuilder.UnequipFromPlayer((PlayerPort)this, value);
        }

        public Vector3Port UpVector
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetUpVector_" + Port.PortKey(), () => ChipBuilder.GetUpVector((PlayerPort)this));
        }

        public Vector3Port UpVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetUpVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetUpVectorDeprecated((PlayerPort)this));
        }

        public Vector3Port Velocity
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVelocity_" + Port.PortKey(), () => ChipBuilder.GetVelocity((PlayerPort)this));
        }

        public Vector3Port VelocityDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVelocityDeprecated_" + Port.PortKey(), () => ChipBuilder.GetVelocityDeprecated((PlayerPort)this));
        }

        public FloatPort VoiceRolloffDistance
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetVoiceRolloffDistance_" + Port.PortKey(), () => ChipBuilder.PlayerGetVoiceRolloffDistance((PlayerPort)this));
            set => ChipBuilder.PlayerSetVoiceRolloffDistance((PlayerPort)this, value);
        }

        public BoolPort WalkInputEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWalkInputEnabled_" + Port.PortKey(), () => ChipBuilder.PlayerGetWalkInputEnabled((PlayerPort)this));
            set => ChipBuilder.PlayerSetWalkInputEnabled((PlayerPort)this, value);
        }

        public FloatPort WalkSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWalkSpeed_" + Port.PortKey(), () => ChipBuilder.PlayerGetWalkSpeed((PlayerPort)this));
            set => ChipBuilder.PlayerSetWalkSpeed((PlayerPort)this, value);
        }

        public BoolPort WorldUIEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIEnabled((PlayerPort)this));
        }

        public ColorPort WorldUIPrimaryBarColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarColor((PlayerPort)this, value);
        }

        public BoolPort WorldUIPrimaryBarEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarEnabled((PlayerPort)this, value);
        }

        public IntPort WorldUIPrimaryBarMaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarMaxValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarMaxValue((PlayerPort)this, value);
        }

        public IntPort WorldUIPrimaryBarValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUIPrimaryBarValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUIPrimaryBarValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUIPrimaryBarValue((PlayerPort)this, value);
        }

        public ColorPort WorldUISecondaryBarColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarColor((PlayerPort)this, value);
        }

        public BoolPort WorldUISecondaryBarEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarEnabled((PlayerPort)this, value);
        }

        public IntPort WorldUISecondaryBarMaxValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarMaxValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarMaxValue((PlayerPort)this, value);
        }

        public IntPort WorldUISecondaryBarValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUISecondaryBarValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUISecondaryBarValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUISecondaryBarValue((PlayerPort)this, value);
        }

        public ColorPort WorldUITextColor
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextColor_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextColor((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextColor((PlayerPort)this, value);
        }

        public BoolPort WorldUITextEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextEnabled_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextEnabled((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextEnabled((PlayerPort)this, value);
        }

        public StringPort WorldUITextValue
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetWorldUITextValue_" + Port.PortKey(), () => ChipBuilder.GetPlayerWorldUITextValue((PlayerPort)this));
            set => ChipBuilder.SetPlayerWorldUITextValue((PlayerPort)this, value);
        }

        public IntPort XP
        {
            get => CircuitBuilder.Singleton("RRCG_Player_GetXP_" + Port.PortKey(), () => ChipBuilder.PlayerGetXP((PlayerPort)this));
        }

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

        public (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealth()
        {
            return CircuitBuilder.Singleton("RRCG_Player_CombatantGetHealth_" + Port.PortKey(), () => ChipBuilder.CombatantGetHealth((PlayerPort)this));
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

        public void ClearCurrentSubtitle()
        {
            ChipBuilder.PlayerClearCurrentSubtitle((PlayerPort)this);
        }

        public BoolPort EquipInventoryItem(InventoryItemPort InventoryItem, EquipmentSlotPort InventoryEquipmentSlot, AlternativeExec<BoolPort> OnEquipComplete)
        {
            return ChipBuilder.PlayerEquipInventoryItem((PlayerPort)this, InventoryItem, InventoryEquipmentSlot, OnEquipComplete);
        }

        public BoolPort GetEquipmentSlotIsEnabled(EquipmentSlotPort EquipmentSlot)
        {
            return ChipBuilder.PlayerGetEquipmentSlotIsEnabled((PlayerPort)this, EquipmentSlot);
        }

        public BoolPort GetIsAuthorityOf(RecRoomObjectPort Object)
        {
            return ChipBuilder.PlayerGetIsAuthorityOf((PlayerPort)this, Object);
        }

        public BoolPort HasRole(StringPort Value)
        {
            return ChipBuilder.PlayerHasRole((PlayerPort)this, Value);
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

        public void ResetNameColor()
        {
            ChipBuilder.PlayerResetNameColor((PlayerPort)this);
        }

        public void SetEquipmentSlotIsEnabled(EquipmentSlotPort EquipmentSlot, BoolPort IsEnabled)
        {
            ChipBuilder.PlayerSetEquipmentSlotIsEnabled((PlayerPort)this, EquipmentSlot, IsEnabled);
        }

        public void ShowSubtitle(StringPort Subtitle, FloatPort Duration, IntPort Priority)
        {
            ChipBuilder.PlayerShowSubtitle((PlayerPort)this, Subtitle, Duration, Priority);
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

    public abstract class PlayerOutfitSlotPortGen : AnyPort
    {
    }

    public abstract class PlayerSpawnPointV2PortGen : AnyPort
    {
        public BoolPort Active
        {
            get => CircuitBuilder.Singleton("RRCG_PlayerSpawnPointV2_GetActive_" + Port.PortKey(), () => ChipBuilder.RespawnPointGetActive((PlayerSpawnPointV2Port)this));
            set => ChipBuilder.RespawnPointSetActive((PlayerSpawnPointV2Port)this, value);
        }

        public BoolPort AddAvoidRole(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddAvoidRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void AddAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public BoolPort AddSpawnRole(StringPort Role)
        {
            return ChipBuilder.RespawnPointAddSpawnRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void AddSpawnTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointAddSpawnTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RemoveAvoidRole(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveAvoidRole((PlayerSpawnPointV2Port)this, Role);
        }

        public void RemoveAvoidTag(StringPort Tag)
        {
            ChipBuilder.RespawnPointRemoveAvoidTag((PlayerSpawnPointV2Port)this, Tag);
        }

        public void RemoveSpawnRole(StringPort Role)
        {
            ChipBuilder.RespawnPointRemoveSpawnRole((PlayerSpawnPointV2Port)this, Role);
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
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetFiringPlayer_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetFiringPlayer((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetFiringPlayer((ProjectileLauncherPort)this, value);
        }

        public IntPort HandDamage
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetHandDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetHandDamage((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetHandDamage((ProjectileLauncherPort)this, value);
        }

        public IntPort HeadDamage
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetHeadDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetHeadDamage((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetHeadDamage((ProjectileLauncherPort)this, value);
        }

        public ColorPort ProjectileColor
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileColor_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileColor((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileColor((ProjectileLauncherPort)this, value);
        }

        public IntPort ProjectileCount
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileCount_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileCount((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileCount((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileLifetime
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileLifetime_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileLifetime((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileLifetime((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpeed_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpeed((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileSpeed((ProjectileLauncherPort)this, value);
        }

        public FloatPort ProjectileSpread
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetProjectileSpread_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetProjectileSpread((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetProjectileSpread((ProjectileLauncherPort)this, value);
        }

        public IntPort RecRoomObjectDamage
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetRecRoomObjectDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetRecRoomObjectDamage((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetRecRoomObjectDamage((ProjectileLauncherPort)this, value);
        }

        public IntPort TorsoDamage
        {
            get => CircuitBuilder.Singleton("RRCG_ProjectileLauncher_GetTorsoDamage_" + Port.PortKey(), () => ChipBuilder.ProjectileLauncherGetTorsoDamage((ProjectileLauncherPort)this));
            set => ChipBuilder.ProjectileLauncherSetTorsoDamage((ProjectileLauncherPort)this, value);
        }

        public void FireProjectile(Vector3Port Direction)
        {
            ChipBuilder.ProjectileLauncherFireProjectile((ProjectileLauncherPort)this, Direction);
        }
    }

    public abstract class RecRoomObjectPortGen : AnyPort
    {
        public Vector3Port AngularVelocity
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAngularVelocity_" + Port.PortKey(), () => ChipBuilder.GetAngularVelocity((RecRoomObjectPort)this));
        }

        public PlayerPort Authority
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetAuthority_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetAuthority((RecRoomObjectPort)this));
            set => ChipBuilder.RecRoomObjectSetAuthority((RecRoomObjectPort)this, value);
        }

        public StringPort FirstTag
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetFirstTag_" + Port.PortKey(), () => ChipBuilder.GetFirstTag((RecRoomObjectPort)this));
        }

        public Vector3Port ForwardVector
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVector_" + Port.PortKey(), () => ChipBuilder.GetForwardVector((RecRoomObjectPort)this));
        }

        public Vector3Port ForwardVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetForwardVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetForwardVectorDeprecated((RecRoomObjectPort)this));
        }

        public (BoolPort IsHeld, PlayerPort HolderPlayer) HolderPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetHolderPlayer_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetHolderPlayer((RecRoomObjectPort)this));
        }

        public BoolPort IsLocalPlayerAuthority
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetIsLocalPlayerAuthority_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetIsLocalPlayerAuthority((RecRoomObjectPort)this));
        }

        public (PlayerPort Player, BoolPort CurrentlyHeldOrEquipped) LastHoldingOrEquippingPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetLastHoldingOrEquippingPlayer_" + Port.PortKey(), () => ChipBuilder.RecRoomObjectGetLastHoldingOrEquippingPlayer((RecRoomObjectPort)this));
        }

        public Vector3Port Position
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPosition_" + Port.PortKey(), () => ChipBuilder.GetPosition((RecRoomObjectPort)this));
            set => ChipBuilder.SetPosition((RecRoomObjectPort)this, value);
        }

        public Vector3Port PositionDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetPositionDeprecated_" + Port.PortKey(), () => ChipBuilder.GetPositionDeprecated((RecRoomObjectPort)this));
        }

        public QuaternionPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotation_" + Port.PortKey(), () => ChipBuilder.GetRotation((RecRoomObjectPort)this));
        }

        public QuaternionPort RotationDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetRotationDeprecated_" + Port.PortKey(), () => ChipBuilder.GetRotationDeprecated((RecRoomObjectPort)this));
        }

        public ListPort<StringPort> Tags
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetTags_" + Port.PortKey(), () => ChipBuilder.GetTags((RecRoomObjectPort)this));
        }

        public Vector3Port UpVector
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVector_" + Port.PortKey(), () => ChipBuilder.GetUpVector((RecRoomObjectPort)this));
        }

        public Vector3Port UpVectorDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetUpVectorDeprecated_" + Port.PortKey(), () => ChipBuilder.GetUpVectorDeprecated((RecRoomObjectPort)this));
        }

        public Vector3Port Velocity
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocity_" + Port.PortKey(), () => ChipBuilder.GetVelocity((RecRoomObjectPort)this));
        }

        public Vector3Port VelocityDeprecated
        {
            get => CircuitBuilder.Singleton("RRCG_RecRoomObject_GetVelocityDeprecated_" + Port.PortKey(), () => ChipBuilder.GetVelocityDeprecated((RecRoomObjectPort)this));
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
            return CircuitBuilder.Singleton("RRCG_RecRoomObject_FromRecRoomObject_" + Port.PortKey(), () => ChipBuilder.FromRecRoomObject<T>((RecRoomObjectPort)this));
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

    public abstract class RemoteVideoPlayerPortGen : AnyPort
    {
    }

    public abstract class RewardPortGen : AnyPort
    {
    }

    public abstract class RoomCurrencyPortGen : AnyPort
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

    public abstract class RoomDoorPortGen : AnyPort
    {
        public DestinationRoomPort Destination
        {
            get => CircuitBuilder.Singleton("RRCG_RoomDoor_GetDestination_" + Port.PortKey(), () => ChipBuilder.DoorGetDestination((RoomDoorPort)this));
            set => ChipBuilder.DoorSetDestination((RoomDoorPort)this, value);
        }

        public BoolPort Locked
        {
            get => CircuitBuilder.Singleton("RRCG_RoomDoor_GetLocked_" + Port.PortKey(), () => ChipBuilder.DoorGetLocked((RoomDoorPort)this));
            set => ChipBuilder.DoorSetLocked((RoomDoorPort)this, value);
        }
    }

    public abstract class RoomKeyPortGen : AnyPort
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

    public abstract class RoomLevelHUDPortGen : AnyPort
    {
    }

    public abstract class RoomOfferPortGen : AnyPort
    {
    }

    public abstract class RotatorPortGen : AnyPort
    {
        public FloatPort Rotation
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotation_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotation((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotation((RotatorPort)this, value);
        }

        public FloatPort RotationAcceleration
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotationAcceleration_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotationAcceleration((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotationAcceleration((RotatorPort)this, value);
        }

        public FloatPort RotationSpeed
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetRotationSpeed_" + Port.PortKey(), () => ChipBuilder.RotatorGetRotationSpeed((RotatorPort)this));
            set => ChipBuilder.RotatorSetRotationSpeed((RotatorPort)this, value);
        }

        public FloatPort TargetRotation
        {
            get => CircuitBuilder.Singleton("RRCG_Rotator_GetTargetRotation_" + Port.PortKey(), () => ChipBuilder.RotatorGetTargetRotation((RotatorPort)this));
            set => ChipBuilder.RotatorSetTargetRotation((RotatorPort)this, value);
        }
    }

    public abstract class SeatPortGen : AnyPort
    {
        public BoolPort LockPlayersIn
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersIn_" + Port.PortKey(), () => ChipBuilder.SeatGetLockPlayersIn((SeatPort)this));
            set => ChipBuilder.SeatSetLockPlayersIn((SeatPort)this, value);
        }

        public BoolPort LockPlayersOut
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetLockPlayersOut_" + Port.PortKey(), () => ChipBuilder.SeatGetLockPlayersOut((SeatPort)this));
            set => ChipBuilder.SeatSetLockPlayersOut((SeatPort)this, value);
        }

        public PlayerPort SeatedPlayer
        {
            get => CircuitBuilder.Singleton("RRCG_Seat_GetSeatedPlayer_" + Port.PortKey(), () => ChipBuilder.SeatGetSeatedPlayer((SeatPort)this));
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
            get => CircuitBuilder.Singleton("RRCG_SFX_GetIsPlaying_" + Port.PortKey(), () => ChipBuilder.SFXGetIsPlaying((SFXPort)this));
        }

        public IntPort Volume
        {
            get => CircuitBuilder.Singleton("RRCG_SFX_GetVolume_" + Port.PortKey(), () => ChipBuilder.SFXGetVolume((SFXPort)this));
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
        public BoolPort RoomSkydomeModify(AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSkydomeModify((SkydomePort)this, BlendFinished);
        }
    }

    public abstract class StatePortGen : AnyPort
    {
        public void GoToState()
        {
            ChipBuilder.GoToState((StatePort)this);
        }
    }

    public abstract class SteeringEnginePortGen : AnyPort
    {
    }

    public abstract class StudioObjectPortGen : AnyPort
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

    public abstract class SunPortGen : AnyPort
    {
        public BoolPort RoomSunModify(SunDirectionPort SunDirection, AlternativeExec<BoolPort> BlendFinished)
        {
            return ChipBuilder.RoomSunModify((SunPort)this, SunDirection, BlendFinished);
        }
    }

    public abstract class SunDirectionPortGen : AnyPort
    {
    }

    public abstract class SwingHandlePortGen : AnyPort
    {
        public BoolPort IsSwinging
        {
            get => CircuitBuilder.Singleton("RRCG_SwingHandle_GetIsSwinging_" + Port.PortKey(), () => ChipBuilder.SwingHandleGetIsSwinging((SwingHandlePort)this));
        }

        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((SwingHandlePort)this, Duration, Intensity);
        }
    }

    public abstract class TextPortGen : AnyPort
    {
        public ColorPort Color
        {
            get => CircuitBuilder.Singleton("RRCG_Text_GetColor_" + Port.PortKey(), () => ChipBuilder.TextGetColor((TextPort)this));
            set => ChipBuilder.TextSetColor((TextPort)this, value);
        }

        public IntPort ColorId
        {
            set => ChipBuilder.TextSetColorId((TextPort)this, value);
        }

        public IntPort Material
        {
            set => ChipBuilder.TextSetMaterial((TextPort)this, value);
        }

        public StringPort Text
        {
            get => CircuitBuilder.Singleton("RRCG_Text_GetText_" + Port.PortKey(), () => ChipBuilder.TextGetText((TextPort)this));
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
            get => CircuitBuilder.Singleton("RRCG_ToggleButton_GetIsPressed_" + Port.PortKey(), () => ChipBuilder.ToggleButtonGetIsPressed((ToggleButtonPort)this));
            set => ChipBuilder.ToggleButtonSetIsPressed((ToggleButtonPort)this, value);
        }
    }

    public abstract class TouchpadPortGen : AnyPort
    {
        public (BoolPort IsTouchActive, Vector3Port TouchPosition, Vector3Port WorldPosition) ActiveTouch
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetActiveTouch_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetActiveTouch((TouchpadPort)this));
        }

        public StringPort InteractionLabel
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetInteractionLabel_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetInteractionLabel((TouchpadPort)this));
            set => ChipBuilder.TouchpadComponentSetInteractionLabel((TouchpadPort)this, value);
        }

        public BoolPort IsEnabled
        {
            get => CircuitBuilder.Singleton("RRCG_Touchpad_GetIsEnabled_" + Port.PortKey(), () => ChipBuilder.TouchpadComponentGetIsEnabled((TouchpadPort)this));
            set => ChipBuilder.TouchpadComponentSetIsEnabled((TouchpadPort)this, value);
        }
    }

    public abstract class TriggerHandlePortGen : AnyPort
    {
        public StringPort ControlPrompt
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerHandle_GetControlPrompt_" + Port.PortKey(), () => ChipBuilder.TriggerHandleGetControlPrompt((TriggerHandlePort)this));
            set => ChipBuilder.TriggerHandleSetControlPrompt((TriggerHandlePort)this, value);
        }

        public BoolPort PrimaryActionHeld
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerHandle_GetPrimaryActionHeld_" + Port.PortKey(), () => ChipBuilder.TriggerHandleGetPrimaryActionHeld((TriggerHandlePort)this));
        }

        public void PlayHandleHaptics(IntPort Duration, FloatPort Intensity)
        {
            ChipBuilder.PlayHandleHaptics((TriggerHandlePort)this, Duration, Intensity);
        }
    }

    public abstract class TriggerVolumePortGen : AnyPort
    {
        public StringPort FilterRole
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetFilterRole_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetFilterRole((TriggerVolumePort)this));
            set => ChipBuilder.TriggerVolumeSetFilterRole((TriggerVolumePort)this, value);
        }

        public ListPort<StringPort> FilterTags
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetFilterTags_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetFilterTags((TriggerVolumePort)this));
            set => ChipBuilder.TriggerVolumeSetFilterTags((TriggerVolumePort)this, value);
        }

        public IntPort ObjectCount
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjectCount_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetObjectCount((TriggerVolumePort)this));
        }

        public ListPort<RecRoomObjectPort> Objects
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetObjects_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetObjects((TriggerVolumePort)this));
        }

        public IntPort PlayerCount
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayerCount_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetPlayerCount((TriggerVolumePort)this));
        }

        public ListPort<PlayerPort> Players
        {
            get => CircuitBuilder.Singleton("RRCG_TriggerVolume_GetPlayers_" + Port.PortKey(), () => ChipBuilder.TriggerVolumeGetPlayers((TriggerVolumePort)this));
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
            get => CircuitBuilder.Singleton("RRCG_WelcomeMat_GetEnabled_" + Port.PortKey(), () => ChipBuilder.WelcomeMatGetEnabled((WelcomeMatPort)this));
            set => ChipBuilder.WelcomeMatSetEnabled((WelcomeMatPort)this, value);
        }
    }
}