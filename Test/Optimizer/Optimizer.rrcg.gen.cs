using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Optimizer : RRCGBuild.CircuitBuilder
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
            new RRCGBuild.EventDefinition("TestNotIfOptimizer").Receiver();
                RRCGBuild.BoolPort optimizableBool = default !;
                optimizableBool = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("optimizableBool", () => ParseBool("true").Result, () => optimizableBool!, (_RRCG_SETTER_VALUE) => optimizableBool = _RRCG_SETTER_VALUE);
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
                RRCGBuild.BoolPort optimizableButNotDeletable = default !;
                optimizableButNotDeletable = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("optimizableButNotDeletable", () => !ParseBool("true").Result, () => optimizableButNotDeletable!, (_RRCG_SETTER_VALUE) => optimizableButNotDeletable = _RRCG_SETTER_VALUE);
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
            RRCGBuild.ChipLib.Log(optimizableButNotDeletable);
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
            new RRCGBuild.EventDefinition("TestIfLocalPlayerIsAuthorityOptimizer").Receiver();
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetAuthority(), RRCGBuild.PlayerPort.Local), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetAuthority()), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetAuthority(), RRCGBuild.PlayerPort.Local)), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetAuthority())), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetAuthority(), RRCGBuild.PlayerPort.Local), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetAuthority(), RRCGBuild.PlayerPort.Local)), delegate
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
                RRCGBuild.BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("condition", () => ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetAuthority()), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(condition);
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
            new RRCGBuild.EventDefinition("TestIfLocalPlayerIsRoomAuthorityOptimizer").Receiver();
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetRoomAuthority(), RRCGBuild.PlayerPort.Local), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetRoomAuthority()), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetRoomAuthority(), RRCGBuild.PlayerPort.Local)), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetRoomAuthority())), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Equals(GetRoomAuthority(), RRCGBuild.PlayerPort.Local), delegate
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
            __If(__ConditionalContext(), () => ChipBuilder.Not(ChipBuilder.Equals(GetRoomAuthority(), RRCGBuild.PlayerPort.Local)), delegate
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
                RRCGBuild.BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("condition", () => ChipBuilder.Equals(RRCGBuild.PlayerPort.Local, GetRoomAuthority()), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(condition);
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
            new RRCGBuild.EventDefinition("TestIfLocalPlayerShouldRunOptimizer").Receiver();
                RRCGBuild.PlayerPort player = default !;
                player = __VariableDeclaratorExpression<RRCGBuild.PlayerPort>("player", () => GetLocalPlayer(), () => player!, (_RRCG_SETTER_VALUE) => player = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(player.IsValid, () => player.IsLocal, () => ChipBuilder.Equals(GetAuthority(), player)), delegate
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
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
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
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
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
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(GetLocalPlayer().IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
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
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(nonLocalPlayer.IsValid, () => GetLocalPlayer().IsLocal, () => ChipBuilder.Equals(GetAuthority(), nonLocalPlayer)), delegate
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
            __If(__ConditionalContext(), () => __Ternary<RRCGBuild.BoolPort>(nonLocalPlayer.IsValid, () => nonLocalPlayer.IsLocal, () => ChipBuilder.Equals(GetAuthority(), GetLocalPlayer())), delegate
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
            new RRCGBuild.EventDefinition("TestIfPlayerHasRoleOptimizer").Receiver();
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.HasRoleR1("testrole"), delegate
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
            __If(__ConditionalContext(), () => !RRCGBuild.PlayerPort.Local.HasRoleR1("testrole"), delegate
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
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.HasRoleR1("testrole"), delegate
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
                RRCGBuild.BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("condition", () => PlayerGetFirstWithTag("tag").HasRoleR1("testrole"), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(condition);
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
            new RRCGBuild.EventDefinition("TestIfPlayerIsLocalOptimizer").Receiver();
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.IsLocal, delegate
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
            __If(__ConditionalContext(), () => !RRCGBuild.PlayerPort.Local.IsLocal, delegate
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
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.IsLocal, delegate
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
                RRCGBuild.BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("condition", () => PlayerGetFirstWithTag("tag").IsLocal, () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => condition, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(condition);
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
            new RRCGBuild.EventDefinition("TestIfPlayerIsValidOptimizer").Receiver();
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.IsValid, delegate
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
            __If(__ConditionalContext(), () => RRCGBuild.PlayerPort.Local.IsLocal, delegate
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
            new RRCGBuild.EventDefinition("TestKnownSingletonChipsOptimizer").Receiver();
                RRCGBuild.Variable<RRCGBuild.FloatPort> floatVar = default !;
                floatVar = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("floatVar", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => floatVar!, (_RRCG_SETTER_VALUE) => floatVar = _RRCG_SETTER_VALUE);
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
            new RRCGBuild.EventDefinition("TestVariableCollapseOptimiser").Receiver();
                RRCGBuild.Variable<RRCGBuild.FloatPort> var0 = default !;
                var0 = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("var0", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => var0!, (_RRCG_SETTER_VALUE) => var0 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.FloatPort> var1 = default !;
                var1 = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("var1", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => var1!, (_RRCG_SETTER_VALUE) => var1 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.FloatPort> var2 = default !;
                var2 = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("var2", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => var2!, (_RRCG_SETTER_VALUE) => var2 = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.FloatPort> var3 = default !;
                var3 = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("var3", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => var3!, (_RRCG_SETTER_VALUE) => var3 = _RRCG_SETTER_VALUE);
            // All read-only instances of each
            // variable will be collapsed into
            // the "writing" instance.
            var0.Value = RandomFloat(0, 100);
            RRCGBuild.ChipLib.Log(var0.Value);
            var1.Value = RandomFloat(0, 100);
            RRCGBuild.ChipLib.Log(var1.Value);
            var2.Value = RandomFloat(0, 100);
            RRCGBuild.ChipLib.Log(var2.Value);
            var3.Value = RandomFloat(0, 100);
            RRCGBuild.ChipLib.Log(var3.Value);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestAssociativeOperationCollapseOptimizer()
        {
            __BeginReturnScope("TestAssociativeOperationCollapseOptimizer", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("TestAssociativeOperationCollapseOptimizer").Receiver();
                RRCGBuild.Variable<RRCGBuild.FloatPort> variable = default !;
                variable = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.FloatPort>>("variable", () => new RRCGBuild.Variable<RRCGBuild.FloatPort>(), () => variable!, (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
            variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;
                RRCGBuild.FloatPort undeletableAdd = default !;
                undeletableAdd = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("undeletableAdd", () => variable.Value + 5f, () => undeletableAdd!, (_RRCG_SETTER_VALUE) => undeletableAdd = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort collapsible = default !;
                collapsible = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("collapsible", () => undeletableAdd + 1f + 2f + 3f + 4f, () => collapsible!, (_RRCG_SETTER_VALUE) => collapsible = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
            RRCGBuild.ChipLib.Log(collapsible);
                RRCGBuild.StringPort spacePort = default !;
                spacePort = __VariableDeclaratorExpression<RRCGBuild.StringPort>("spacePort", () => Reroute<RRCGBuild.StringPort>(" "), () => spacePort!, (_RRCG_SETTER_VALUE) => spacePort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log("Hello" + spacePort + "World");
                RRCGBuild.StringPort undeletableConcat = default !;
                undeletableConcat = __VariableDeclaratorExpression<RRCGBuild.StringPort>("undeletableConcat", () => "Undeletable" + spacePort + "concat", () => undeletableConcat!, (_RRCG_SETTER_VALUE) => undeletableConcat = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
            RRCGBuild.ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);
                RRCGBuild.FloatPort undeletableSubtract = default !;
                undeletableSubtract = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("undeletableSubtract", () => RRCGBuild.ChipLib.FloatConst(50f) - RRCGBuild.ChipLib.FloatConst(10f) - (RRCGBuild.ChipLib.FloatConst(5f) - RRCGBuild.ChipLib.FloatConst(3f)), () => undeletableSubtract!, (_RRCG_SETTER_VALUE) => undeletableSubtract = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(undeletableSubtract); // Log to make it undeletable
            RRCGBuild.ChipLib.Log(undeletableSubtract - 5f);
                RRCGBuild.FloatPort undeletableDivide = default !;
                undeletableDivide = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("undeletableDivide", () => RRCGBuild.ChipLib.FloatConst(50f) / RRCGBuild.ChipLib.FloatConst(0.2f) / (RRCGBuild.ChipLib.FloatConst(0.4f) / RRCGBuild.ChipLib.FloatConst(0.8f)), () => undeletableDivide!, (_RRCG_SETTER_VALUE) => undeletableDivide = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(undeletableDivide); // Log to make it undeletable
            RRCGBuild.ChipLib.Log(undeletableDivide / 5f);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

