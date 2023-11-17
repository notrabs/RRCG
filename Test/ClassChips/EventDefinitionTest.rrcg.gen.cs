using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class EventDefintionTest : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            ParamCounts();
            SendTypes();
            Existing();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ParamCounts()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var params0 = __VariableDeclaratorExpression("params0", () => new EventDefinition());
            params0.Receiver();
            params0.SendLocal();
            var params1 = __VariableDeclaratorExpression("params1", () => new EventDefinition<IntPort>("param0"));
            var params1Value = __VariableDeclaratorExpression("params1Value", () => params1.Receiver());
            params1.SendLocal(params1Value);
            var params2 = __VariableDeclaratorExpression("params2", () => new EventDefinition<StringPort, BoolPort>("param0", "param1"));
            var params2Value = __VariableDeclaratorExpression("params2Value", () => params2.Receiver());
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void SendTypes()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var params0 = __VariableDeclaratorExpression("params0", () => new EventDefinition());
            params0.Receiver();
            params0.SendLocal();
            params0.SendOthers();
            params0.SendAll();
            params0.SendAuthority();
            params0.SendRoomAuthority();
            params0.SendPlayer(PlayerPort.Local);
            params0.SendPlayer(GetLocalPlayer());
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void Existing()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var params0 = __VariableDeclaratorExpression("params0", () => ExistingEvent("Existing0"));
            params0.Receiver();
            params0.SendLocal();
            var params1 = __VariableDeclaratorExpression("params1", () => ExistingEvent<IntPort>("Existing1"));
            var params1Value = __VariableDeclaratorExpression("params1Value", () => params1.Receiver());
            params1.SendLocal(params1Value);
            var params2 = __VariableDeclaratorExpression("params2", () => ExistingEvent<IntPort, StringPort>("Existing2"));
            var params2Value = __VariableDeclaratorExpression("params2Value", () => params2.Receiver());
            params2.SendLocal(params2Value.Item1, params2Value.Item2);
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}