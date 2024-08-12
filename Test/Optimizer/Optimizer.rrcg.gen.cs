using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Optimizer : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            TestNotIfOptimizer();
            TestIfLocalPlayerIsAuthorityOptimizer();
            TestIfLocalPlayerIsRoomAuthorityOptimizer();
            TestIfLocalPlayerShouldRunOptimizer();
            TestIfPlayerHasRoleOptimizer();
            TestIfPlayerIsLocalOptimizer();
            TestIfPlayerIsValidOptimizer();
            TestKnownSingletonChipsOptimizer();
            TestVariableCollapseOptimizer();
            TestAssociativeOperationCollapseOptimizer();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestNotIfOptimizer()
        {
            __BeginReturnScope("TestNotIfOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestNotIfOptimizer").Receiver();
                BoolPort optimizableBool = default !;
                optimizableBool = __VariableDeclaratorExpression<BoolPort>("optimizableBool", () => ParseBool("true").Result, () => optimizableBool!, (_RRCG_SETTER_VALUE) => optimizableBool = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => Not(true), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
                BoolPort optimizableButNotDeletable = default !;
                optimizableButNotDeletable = __VariableDeclaratorExpression<BoolPort>("optimizableButNotDeletable", () => !ParseBool("true").Result, () => optimizableButNotDeletable!, (_RRCG_SETTER_VALUE) => optimizableButNotDeletable = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => optimizableButNotDeletable, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipLib.Log(optimizableButNotDeletable);
            __If(__ConditionalContext(), () => optimizableBool, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !optimizableBool, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(ParseInt("1").Result, 1), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(ParseInt("1").Result, 1)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !!true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !!!true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !!!!true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => Not(Not(true)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => Not(Not(Not(true))), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => Not(Not(Not(Not(true)))), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfLocalPlayerIsAuthorityOptimizer()
        {
            __BeginReturnScope("TestIfLocalPlayerIsAuthorityOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfLocalPlayerIsAuthorityOptimizer").Receiver();
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetAuthority(), PlayerPort.Local), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(PlayerPort.Local, GetAuthority()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetAuthority(), GetLocalPlayer()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetLocalPlayer(), GetAuthority()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetAuthority(), PlayerPort.Local)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(PlayerPort.Local, GetAuthority())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetAuthority(), GetLocalPlayer())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetLocalPlayer(), GetAuthority())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetAuthority(), PlayerPort.Local), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetAuthority(), PlayerPort.Local)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
                BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<BoolPort>("condition", () => ChipBuilder.Equals(PlayerPort.Local, GetAuthority()), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(condition);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => LocalPlayerIsAuthority, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfLocalPlayerIsRoomAuthorityOptimizer()
        {
            __BeginReturnScope("TestIfLocalPlayerIsRoomAuthorityOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfLocalPlayerIsRoomAuthorityOptimizer").Receiver();
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetRoomAuthority(), PlayerPort.Local), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(PlayerPort.Local, GetRoomAuthority()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetRoomAuthority(), GetLocalPlayer()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetLocalPlayer(), GetRoomAuthority()), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetRoomAuthority(), PlayerPort.Local)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(PlayerPort.Local, GetRoomAuthority())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetRoomAuthority(), GetLocalPlayer())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetLocalPlayer(), GetRoomAuthority())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetRoomAuthority(), PlayerPort.Local), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetRoomAuthority(), PlayerPort.Local)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
                BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<BoolPort>("condition", () => ChipBuilder.Equals(PlayerPort.Local, GetRoomAuthority()), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(condition);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => LocalPlayerIsRoomAuthority, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfLocalPlayerShouldRunOptimizer()
        {
            __BeginReturnScope("TestIfLocalPlayerShouldRunOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfLocalPlayerShouldRunOptimizer").Receiver();
                RRCGBuild.PlayerPort player = default !;
                player = __VariableDeclaratorExpression<RRCGBuild.PlayerPort>("player", () => GetLocalPlayer(), () => player!, (_RRCG_SETTER_VALUE) => player = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(player.IsValid, () => player.IsLocal, () => ChipBuilder.Equals(GetAuthority(), player)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
                RRCGBuild.PlayerPort nonLocalPlayer = default !;
                nonLocalPlayer = __VariableDeclaratorExpression<RRCGBuild.PlayerPort>("nonLocalPlayer", () => PlayerGetFirstWithTag("tag"), () => nonLocalPlayer!, (_RRCG_SETTER_VALUE) => nonLocalPlayer = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(GetLocalPlayer().IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(nonLocalPlayer.IsValid, () => GetLocalPlayer().IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => __Ternary<BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), GetLocalPlayer())), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfPlayerHasRoleOptimizer()
        {
            __BeginReturnScope("TestIfPlayerHasRoleOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfPlayerHasRoleOptimizer").Receiver();
            __If(__ConditionalContext(), () => PlayerPort.Local.HasRoleR1("testrole"), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => GetLocalPlayer().HasRoleR1("testrole"), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerGetFirstWithTag("tag").HasRoleR1("testrole"), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !PlayerPort.Local.HasRoleR1("testrole"), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerPort.Local.HasRoleR1("testrole"), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
                BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<BoolPort>("condition", () => PlayerGetFirstWithTag("tag").HasRoleR1("testrole"), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(condition);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfPlayerIsLocalOptimizer()
        {
            __BeginReturnScope("TestIfPlayerIsLocalOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfPlayerIsLocalOptimizer").Receiver();
            __If(__ConditionalContext(), () => PlayerPort.Local.IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => GetLocalPlayer().IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerGetFirstWithTag("tag").IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => !PlayerPort.Local.IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerPort.Local.IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
                BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<BoolPort>("condition", () => PlayerGetFirstWithTag("tag").IsLocal, () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(condition);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestIfPlayerIsValidOptimizer()
        {
            __BeginReturnScope("TestIfPlayerIsValidOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestIfPlayerIsValidOptimizer").Receiver();
            __If(__ConditionalContext(), () => PlayerPort.Local.IsValid, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => GetLocalPlayer().IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerGetFirstWithTag("tag").IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            __If(__ConditionalContext(), () => PlayerPort.Local.IsLocal, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestKnownSingletonChipsOptimizer()
        {
            __BeginReturnScope("TestKnownSingletonChipsOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestKnownSingletonChipsOptimizer").Receiver();
                RRCGBuild.Variable<FloatPort> floatVar = default !;
                floatVar = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("floatVar", () => new Variable<FloatPort>(), () => floatVar!, (_RRCG_SETTER_VALUE) => floatVar = _RRCG_SETTER_VALUE);
            // All these Time Get Precise Seconds nodes
            // will be collapsed into a single node.
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestVariableCollapseOptimizer()
        {
            __BeginReturnScope("TestVariableCollapseOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestVariableCollapseOptimiser").Receiver();
                RRCGBuild.Variable<FloatPort> var0 = default !;
                var0 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var0", () => new Variable<FloatPort>(), () => var0!, (_RRCG_SETTER_VALUE) => var0 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<FloatPort> var1 = default !;
                var1 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var1", () => new Variable<FloatPort>(), () => var1!, (_RRCG_SETTER_VALUE) => var1 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<FloatPort> var2 = default !;
                var2 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var2", () => new Variable<FloatPort>(), () => var2!, (_RRCG_SETTER_VALUE) => var2 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<FloatPort> var3 = default !;
                var3 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var3", () => new Variable<FloatPort>(), () => var3!, (_RRCG_SETTER_VALUE) => var3 = _RRCG_SETTER_VALUE);
            // All read-only instances of each
            // variable will be collapsed into
            // the "writing" instance.
            var0.Value = RandomFloat(0, 100);
            ChipLib.Log(var0.Value);
            var1.Value = RandomFloat(0, 100);
            ChipLib.Log(var1.Value);
            var2.Value = RandomFloat(0, 100);
            ChipLib.Log(var2.Value);
            var3.Value = RandomFloat(0, 100);
            ChipLib.Log(var3.Value);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestAssociativeOperationCollapseOptimizer()
        {
            __BeginReturnScope("TestAssociativeOperationCollapseOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestAssociativeOperationCollapseOptimizer").Receiver();
                RRCGBuild.Variable<FloatPort> variable = default !;
                variable = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("variable", () => new Variable<FloatPort>(), () => variable!, (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
            variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;
                FloatPort undeletableAdd = default !;
                undeletableAdd = __VariableDeclaratorExpression<FloatPort>("undeletableAdd", () => variable.Value + 5f, () => undeletableAdd!, (_RRCG_SETTER_VALUE) => undeletableAdd = _RRCG_SETTER_VALUE);
                FloatPort collapsible = default !;
                collapsible = __VariableDeclaratorExpression<FloatPort>("collapsible", () => undeletableAdd + 1f + 2f + 3f + 4f, () => collapsible!, (_RRCG_SETTER_VALUE) => collapsible = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
            ChipLib.Log(collapsible);
                StringPort spacePort = default !;
                spacePort = __VariableDeclaratorExpression<StringPort>("spacePort", () => Reroute<StringPort>(" "), () => spacePort!, (_RRCG_SETTER_VALUE) => spacePort = _RRCG_SETTER_VALUE);
            ChipLib.Log("Hello" + spacePort + "World");
                StringPort undeletableConcat = default !;
                undeletableConcat = __VariableDeclaratorExpression<StringPort>("undeletableConcat", () => "Undeletable" + spacePort + "concat", () => undeletableConcat!, (_RRCG_SETTER_VALUE) => undeletableConcat = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
            ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);
                FloatPort undeletableSubtract = default !;
                undeletableSubtract = __VariableDeclaratorExpression<FloatPort>("undeletableSubtract", () => ChipLib.FloatConst(50f) - ChipLib.FloatConst(10f) - (ChipLib.FloatConst(5f) - ChipLib.FloatConst(3f)), () => undeletableSubtract!, (_RRCG_SETTER_VALUE) => undeletableSubtract = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableSubtract); // Log to make it undeletable
            ChipLib.Log(undeletableSubtract - 5f);
                FloatPort undeletableDivide = default !;
                undeletableDivide = __VariableDeclaratorExpression<FloatPort>("undeletableDivide", () => ChipLib.FloatConst(50f) / ChipLib.FloatConst(0.2f) / (ChipLib.FloatConst(0.4f) / ChipLib.FloatConst(0.8f)), () => undeletableDivide!, (_RRCG_SETTER_VALUE) => undeletableDivide = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableDivide); // Log to make it undeletable
            ChipLib.Log(undeletableDivide / 5f);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

