using RRCGSource;
using RRCG;
using UnityEngine;

namespace RRCGSource
{
    public class RoomEvent3
    {
        /// <summary>
        /// AI Died
        /// </summary>
        public static void AIDied(AlternativeExec<(AI aI, Combatant attacker)> onAIDied)
        {
        }

        /// <summary>
        /// AI Spawned
        /// </summary>
        public static void AISpawned(AlternativeExec<AI> onAISpawned)
        {
        }

        /// <summary>
        /// Consumable Purchased
        /// </summary>
        public static void ConsumablePurchased(AlternativeExec<(Consumable consumable, int quantity)> onConsumablePurchased)
        {
        }

        /// <summary>
        /// Consumable Used
        /// </summary>
        public static void ConsumableUsed(AlternativeExec<Consumable> onConsumableUsed)
        {
        }

        /// <summary>
        /// DEPRECATED Local Player Spawned
        /// </summary>
        public static void DEPRECATEDLocalPlayerSpawned(AlternativeExec onDEPRECATEDLocalPlayerSpawned)
        {
        }

        /// <summary>
        /// DEPRECATED Player Left
        /// </summary>
        public static void DEPRECATEDPlayerLeft(AlternativeExec<Player> onDEPRECATEDPlayerLeft)
        {
        }

        /// <summary>
        /// Interaction Volume Hold Cancel
        /// </summary>
        public static void InteractionVolumeHoldCancel(AlternativeExec<InteractionVolume> onInteractionVolumeHoldCancel)
        {
        }

        /// <summary>
        /// Interaction Volume Hold End
        /// </summary>
        public static void InteractionVolumeHoldEnd(AlternativeExec<InteractionVolume> onInteractionVolumeHoldEnd)
        {
        }

        /// <summary>
        /// Interaction Volume Hold Start
        /// </summary>
        public static void InteractionVolumeHoldStart(AlternativeExec<InteractionVolume> onInteractionVolumeHoldStart)
        {
        }

        /// <summary>
        /// Interaction Volume Hold Update
        /// </summary>
        public static void InteractionVolumeHoldUpdate(AlternativeExec<InteractionVolume> onInteractionVolumeHoldUpdate)
        {
        }

        /// <summary>
        /// Interaction Volume Hover End
        /// </summary>
        public static void InteractionVolumeHoverEnd(AlternativeExec<InteractionVolume> onInteractionVolumeHoverEnd)
        {
        }

        /// <summary>
        /// Interaction Volume Hover Start
        /// </summary>
        public static void InteractionVolumeHoverStart(AlternativeExec<InteractionVolume> onInteractionVolumeHoverStart)
        {
        }

        /// <summary>
        /// Interaction Volume On Use
        /// </summary>
        public static void InteractionVolumeOnUse(AlternativeExec<(InteractionVolume interactionVolume, Player player)> onInteractionVolumeOnUse)
        {
        }

        /// <summary>
        /// Inventory Item Count Changed
        /// </summary>
        public static void InventoryItemCountChanged(AlternativeExec<(InventoryItem inventoryItem, int oldCount, int newCount)> onInventoryItemCountChanged)
        {
        }

        /// <summary>
        /// Inventory Item Equipped
        /// </summary>
        public static void InventoryItemEquipped(AlternativeExec<InventoryItem> onInventoryItemEquipped)
        {
        }

        /// <summary>
        /// Inventory Item Unequipped
        /// </summary>
        public static void InventoryItemUnequipped(AlternativeExec<InventoryItem> onInventoryItemUnequipped)
        {
        }

        /// <summary>
        /// Inventory Item Used
        /// </summary>
        public static void InventoryItemUsed(AlternativeExec<InventoryItem> onInventoryItemUsed)
        {
        }

        /// <summary>
        /// Level Reached
        /// </summary>
        public static void LevelReached(AlternativeExec<int> onLevelReached)
        {
        }

        /// <summary>
        /// Local Player Third Person Active Changed
        /// </summary>
        public static void LocalPlayerThirdPersonActiveChanged(AlternativeExec<(bool active, bool toggledByPlayer)> onLocalPlayerThirdPersonActiveChanged)
        {
        }

        /// <summary>
        /// On Player Clamber Started
        /// </summary>
        public static void OnPlayerClamberStarted(AlternativeExec<Player> onPlayerClamberStarted)
        {
        }

        /// <summary>
        /// On Player Crouch Started
        /// </summary>
        public static void OnPlayerCrouchStarted(AlternativeExec<Player> onPlayerCrouchStarted)
        {
        }

        /// <summary>
        /// On Player Fly Started
        /// </summary>
        public static void OnPlayerFlyStarted(AlternativeExec<Player> onPlayerFlyStarted)
        {
        }

        /// <summary>
        /// On Player Fly Stopped
        /// </summary>
        public static void OnPlayerFlyStopped(AlternativeExec<Player> onPlayerFlyStopped)
        {
        }

        /// <summary>
        /// On Player Footstep
        /// </summary>
        public static void OnPlayerFootstep(AlternativeExec<(Player player, RecRoomObject surface, Vector3 position)> onPlayerFootstep)
        {
        }

        /// <summary>
        /// On Player Grabbed Object
        /// </summary>
        public static void OnPlayerGrabbedObject(AlternativeExec<(Player player, RecRoomObject @object)> onPlayerGrabbedObject)
        {
        }

        /// <summary>
        /// On Player Grounded
        /// </summary>
        public static void OnPlayerGrounded(AlternativeExec<(Player player, RecRoomObject surface, Vector3 position)> onPlayerGrounded)
        {
        }

        /// <summary>
        /// On Player Jumped
        /// </summary>
        public static void OnPlayerJumped(AlternativeExec<(Player player, RecRoomObject surface, Vector3 position)> onPlayerJumped)
        {
        }

        /// <summary>
        /// On Player Landed
        /// </summary>
        public static void OnPlayerLanded(AlternativeExec<(Player player, RecRoomObject surface, Vector3 position)> onPlayerLanded)
        {
        }

        /// <summary>
        /// On Player Prone Started
        /// </summary>
        public static void OnPlayerProneStarted(AlternativeExec<Player> onPlayerProneStarted)
        {
        }

        /// <summary>
        /// On Player Released Object
        /// </summary>
        public static void OnPlayerReleasedObject(AlternativeExec<(Player player, RecRoomObject @object)> onPlayerReleasedObject)
        {
        }

        /// <summary>
        /// On Player Slide Started
        /// </summary>
        public static void OnPlayerSlideStarted(AlternativeExec<Player> onPlayerSlideStarted)
        {
        }

        /// <summary>
        /// On Player Sprint Started
        /// </summary>
        public static void OnPlayerSprintStarted(AlternativeExec<Player> onPlayerSprintStarted)
        {
        }

        /// <summary>
        /// On Player Sprint Stopped
        /// </summary>
        public static void OnPlayerSprintStopped(AlternativeExec<Player> onPlayerSprintStopped)
        {
        }

        /// <summary>
        /// On Player Stand Started
        /// </summary>
        public static void OnPlayerStandStarted(AlternativeExec<Player> onPlayerStandStarted)
        {
        }

        /// <summary>
        /// On Player Velocity Modified
        /// </summary>
        public static void OnPlayerVelocityModified(AlternativeExec<(Player player, bool ungroundedPlayer, Vector3 velocityDelta)> onPlayerVelocityModified)
        {
        }

        /// <summary>
        /// On Player Wall Climb Started
        /// </summary>
        public static void OnPlayerWallClimbStarted(AlternativeExec<Player> onPlayerWallClimbStarted)
        {
        }

        /// <summary>
        /// On Player Wall Run Started
        /// </summary>
        public static void OnPlayerWallRunStarted(AlternativeExec<(Player player, Vector3 wallNormal, RecRoomObject wallObject)> onPlayerWallRunStarted)
        {
        }

        /// <summary>
        /// On Player Wall Run Stopped
        /// </summary>
        public static void OnPlayerWallRunStopped(AlternativeExec<Player> onPlayerWallRunStopped)
        {
        }

        /// <summary>
        /// OnGameEnd
        /// </summary>
        public static void OnGameEnd(AlternativeExec onGameEnd)
        {
        }

        /// <summary>
        /// OnGameStart
        /// </summary>
        public static void OnGameStart(AlternativeExec onGameStart)
        {
        }

        /// <summary>
        /// Player Joined
        /// </summary>
        public static void PlayerJoined(AlternativeExec<Player> onPlayerJoined)
        {
        }

        /// <summary>
        /// Player Leaving
        /// </summary>
        public static void PlayerLeaving(AlternativeExec<Player> onPlayerLeaving)
        {
        }

        /// <summary>
        /// Player Left
        /// </summary>
        public static void PlayerLeft(AlternativeExec<Player> onPlayerLeft)
        {
        }

        /// <summary>
        /// PlayerCollision
        /// </summary>
        public static void PlayerCollision(AlternativeExec<(Player playerA, Player playerB)> onPlayerCollision)
        {
        }

        /// <summary>
        /// Room Authority Changed
        /// </summary>
        public static void RoomAuthorityChanged(AlternativeExec<Player> onRoomAuthorityChanged)
        {
        }

        /// <summary>
        /// Room Key Purchased
        /// </summary>
        public static void RoomKeyPurchased(AlternativeExec<RoomKey> onRoomKeyPurchased)
        {
        }

        /// <summary>
        /// Room Loaded
        /// </summary>
        public static void RoomLoaded(AlternativeExec onRoomLoaded)
        {
        }

        /// <summary>
        /// Room Offer Purchased
        /// </summary>
        public static void RoomOfferPurchased(AlternativeExec<(RoomOffer roomOffer, int quantity)> onRoomOfferPurchased)
        {
        }

        /// <summary>
        /// Room Reset
        /// </summary>
        public static void RoomReset(AlternativeExec onRoomReset)
        {
        }

        /// <summary>
        /// Test Event
        /// </summary>
        public static void TestEvent(AlternativeExec<string> onTestEvent)
        {
        }

        /// <summary>
        /// Update
        /// </summary>
        public static void Update(AlternativeExec<float> onUpdate)
        {
        }

        /// <summary>
        /// Update 30Hz
        /// </summary>
        public static void Update30Hz(AlternativeExec<float> onUpdate30Hz)
        {
        }
    }
}