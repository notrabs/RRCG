using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCGSource
{
    public abstract class AnyObject
    {
        public bool IsValid { get; }
    }
    public class RRTuple<T0, T1> : AnyObject { }

    public class AI : AIGen { }
    public class AnalyticsPayload : AnalyticsPayloadGen { }
    public class Player : PlayerGen
    {
        public static Player Local = new Player();
        public static Player Invalid = null;
    }

    public class Combatant : CombatantGen { }
    public class PatrolPoint : PatrolPointGen { }
    public class Consumable : ConsumableGen { }
    public class RoomKey : RoomKeyGen { }
    public class BackgroundObjects : BackgroundObjectsGen { }
    public class CollisionData : CollisionDataGen { }
    public class DestinationRoom : DestinationRoomGen { }
    public class PlayerWorldUI : PlayerWorldUIGen { }
    public class Fog : FogGen { }
    public class HUDElement : HUDElementGen { }
    public class Reward : RewardGen { }
    public class PlayerOutfitSlot : PlayerOutfitSlotGen { }
    public class Skydome : SkydomeGen { }
    public class Sun : SunGen { }
    public class SunDirection : SunDirectionGen { }
    public class RoomCurrency : RoomCurrencyGen { }
    public class InventoryItem : InventoryItemGen { }
    public class State : StateGen { }
    public class EquipmentSlot : EquipmentSlotGen { }
    public class DialogueUI : DialogueUIGen { }
    public class CollisionDetectionVolume : CollisionDetectionVolumeGen { }
    public class RoomOffer : RoomOfferGen { }
    public class RecNetImage : RecNetImageGen { }
    public class RangedWeapon : RangedWeaponGen { }
    public class Storefront : StorefrontGen { }

    // remember to add types to RRTypesUtils.ImplemetedRRTypes
}
