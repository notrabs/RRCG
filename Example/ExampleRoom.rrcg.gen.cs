using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : CircuitBuilder
    {
        EventDefinition<IntPort> testEvent = __VariableDeclaratorExpression("testEvent", () => new EventDefinition<IntPort>("intValue"));
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            RandomExample();
            EventCacheExample();
            VariableLoopExample();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void RandomExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            EventReceiver(RoomEvents.Hz30);
            var rand1 = __VariableDeclaratorExpression("rand1", () => RandomInt(0, 10));
            var rand2 = __VariableDeclaratorExpression("rand2", () => RandomInt(0, 10));
            ChipBuilder.If(ChipBuilder.GreaterThan(rand1 + rand2, 10), delegate
            {
                LogString("Today's your lucky day");
            }

            , delegate
            {
                LogString("Try again next time");
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void EventCacheExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            EventReceiver(RoomEvents.Hz30);
            var rand1 = __VariableDeclaratorExpression("rand1", () => RandomInt(0, 10));
            var sum = __VariableDeclaratorExpression("sum", () => (rand1 + 3) + (4 + 5));
            var cached = __VariableDeclaratorExpression("cached", () => ChipLib.EventCache<IntPort>(sum));
            PlayerShowSubtitle(GetLocalPlayer(), ToString(cached), 3.0f, 0);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VariableLoopExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var intValue = __VariableDeclaratorExpression("intValue", () => testEvent.Receiver());
            var counter = __VariableDeclaratorExpression("counter", () => new Variable<IntPort>());
            __While(ChipBuilder.LessThan(counter.Value, intValue), delegate
            {
                ChipLib.Log(counter.Value);
                counter.Value++;
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}