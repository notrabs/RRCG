using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class EventDefintionTest : CircuitBuilder
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
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => new EventDefinition(), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
                RRCGBuild.EventDefinition<IntPort> params1 = default !;
                params1 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<IntPort>>("params1", () => new EventDefinition<IntPort>("param0"), () => params1!, (_RRCG_SETTER_VALUE) => params1 = _RRCG_SETTER_VALUE);
                IntPort params1Value = default !;
                params1Value = __VariableDeclaratorExpression<IntPort>("params1Value", () => params1.Receiver(), () => params1Value!, (_RRCG_SETTER_VALUE) => params1Value = _RRCG_SETTER_VALUE);
            params1.SendLocal(params1Value);
                RRCGBuild.EventDefinition<StringPort, BoolPort> params2 = default !;
                params2 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<StringPort, BoolPort>>("params2", () => new EventDefinition<StringPort, BoolPort>("param0", "param1"), () => params2!, (_RRCG_SETTER_VALUE) => params2 = _RRCG_SETTER_VALUE);
                (StringPort, BoolPort) params2Value = default !;
                params2Value = __VariableDeclaratorExpression<(StringPort, BoolPort)>("params2Value", () => params2.Receiver(), () => params2Value!, (_RRCG_SETTER_VALUE) => params2Value = _RRCG_SETTER_VALUE);
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void SendTypes()
        {
            __BeginReturnScope("SendTypes", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition params0 = default !;
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => new EventDefinition(), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
            params0.SendOthers();
            params0.SendAll();
            params0.SendAuthority();
            params0.SendRoomAuthority();
            params0.SendPlayer(PlayerPort.Local);
            params0.SendPlayer(GetLocalPlayer());
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void Existing()
        {
            __BeginReturnScope("Existing", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition params0 = default !;
                params0 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("params0", () => ExistingEvent("Existing0"), () => params0!, (_RRCG_SETTER_VALUE) => params0 = _RRCG_SETTER_VALUE);
            params0.Receiver();
            params0.SendLocal();
                RRCGBuild.EventDefinition<IntPort> params1 = default !;
                params1 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<IntPort>>("params1", () => ExistingEvent<IntPort>("Existing1"), () => params1!, (_RRCG_SETTER_VALUE) => params1 = _RRCG_SETTER_VALUE);
                IntPort params1Value = default !;
                params1Value = __VariableDeclaratorExpression<IntPort>("params1Value", () => params1.Receiver(), () => params1Value!, (_RRCG_SETTER_VALUE) => params1Value = _RRCG_SETTER_VALUE);
            params1.SendLocal(params1Value);
                RRCGBuild.EventDefinition<IntPort, StringPort> params2 = default !;
                params2 = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<IntPort, StringPort>>("params2", () => ExistingEvent<IntPort, StringPort>("Existing2"), () => params2!, (_RRCG_SETTER_VALUE) => params2 = _RRCG_SETTER_VALUE);
                (IntPort, StringPort) params2Value = default !;
                params2Value = __VariableDeclaratorExpression<(IntPort, StringPort)>("params2Value", () => params2.Receiver(), () => params2Value!, (_RRCG_SETTER_VALUE) => params2Value = _RRCG_SETTER_VALUE);
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}