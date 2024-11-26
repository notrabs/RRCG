using RRCGBuild;
using System;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class EventDefintionTest : RRCGBuild.CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            ParamCounts();
            SendTypes();
            Existing();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ParamCounts()
        {
            __BeginReturnScope("ParamCounts", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition params0 = default !;
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => new RRCGBuild.EventDefinition(), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
                RRCGBuild.EventDefinition<RRCGBuild.IntPort> params1 = default !;
                params1 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<RRCGBuild.IntPort>>("params1", () => new RRCGBuild.EventDefinition<RRCGBuild.IntPort>("param0"), () => params1!, (_RRCG_SETTER_VALUE) => params1 = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort params1Value = default !;
                params1Value = __VariableDeclaratorExpression<RRCGBuild.IntPort>("params1Value", () => params1.Receiver(), () => params1Value!, (_RRCG_SETTER_VALUE) => params1Value = _RRCG_SETTER_VALUE);
            params1.SendLocal(params1Value);
                RRCGBuild.EventDefinition<RRCGBuild.StringPort, RRCGBuild.BoolPort> params2 = default !;
                params2 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<RRCGBuild.StringPort, RRCGBuild.BoolPort>>("params2", () => new RRCGBuild.EventDefinition<RRCGBuild.StringPort, RRCGBuild.BoolPort>("param0", "param1"), () => params2!, (_RRCG_SETTER_VALUE) => params2 = _RRCG_SETTER_VALUE);
                (RRCGBuild.StringPort Item1, RRCGBuild.BoolPort Item2) params2Value = default !;
                params2Value = __VariableDeclaratorExpression<(RRCGBuild.StringPort Item1, RRCGBuild.BoolPort Item2)>("params2Value", () => params2.Receiver(), () => params2Value!, (_RRCG_SETTER_VALUE) => params2Value = _RRCG_SETTER_VALUE);
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void SendTypes()
        {
            __BeginReturnScope("SendTypes", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition params0 = default !;
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => new RRCGBuild.EventDefinition(), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
            params0.SendOthers();
            params0.SendAll();
            params0.SendAuthority();
            params0.SendRoomAuthority();
            params0.SendPlayer(RRCGBuild.PlayerPort.Local);
            params0.SendPlayer(GetLocalPlayer());
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void Existing()
        {
            __BeginReturnScope("Existing", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition params0 = default !;
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => ExistingEvent("Existing0", Guid.Empty), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
                RRCGBuild.EventDefinition<RRCGBuild.IntPort> params1 = default !;
                params1 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<RRCGBuild.IntPort>>("params1", () => ExistingEvent<RRCGBuild.IntPort>("Existing1", Guid.Empty), () => params1!, (_RRCG_SETTER_VALUE) => params1 = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort params1Value = default !;
                params1Value = __VariableDeclaratorExpression<RRCGBuild.IntPort>("params1Value", () => params1.Receiver(), () => params1Value!, (_RRCG_SETTER_VALUE) => params1Value = _RRCG_SETTER_VALUE);
            params1.SendLocal(params1Value);
                RRCGBuild.EventDefinition<RRCGBuild.IntPort, RRCGBuild.StringPort> params2 = default !;
                params2 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<RRCGBuild.IntPort, RRCGBuild.StringPort>>("params2", () => ExistingEvent<RRCGBuild.IntPort, RRCGBuild.StringPort>("Existing2", Guid.Empty), () => params2!, (_RRCG_SETTER_VALUE) => params2 = _RRCG_SETTER_VALUE);
                (RRCGBuild.IntPort Item1, RRCGBuild.StringPort Item2) params2Value = default !;
                params2Value = __VariableDeclaratorExpression<(RRCGBuild.IntPort Item1, RRCGBuild.StringPort Item2)>("params2Value", () => params2.Receiver(), () => params2Value!, (_RRCG_SETTER_VALUE) => params2Value = _RRCG_SETTER_VALUE);
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}