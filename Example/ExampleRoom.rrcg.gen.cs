using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : CircuitBuilder
    {
        EventDefinition<IntPort> testEvent;
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            RandomExample();
            EventCacheExample();
            VariableLoopExample();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void RandomExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            EventReceiver(RoomEvents.Hz30);
            IntPort rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
            IntPort rand2 = __VariableDeclaratorExpression<IntPort>("rand2", () => RandomInt(0, 10), (_RRCG_SETTER_VALUE) => rand2 = _RRCG_SETTER_VALUE);
            ChipBuilder.If(ChipBuilder.GreaterThan(rand1 + rand2, 10), delegate
            {
                __BeginAccessibilityScope(true);
                LogString("Today's your lucky day");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("Try again next time");
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void EventCacheExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            EventReceiver(RoomEvents.Hz30);
            IntPort rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
            IntPort sum = __VariableDeclaratorExpression<IntPort>("sum", () => (rand1 + 3) + (4 + 5), (_RRCG_SETTER_VALUE) => sum = _RRCG_SETTER_VALUE);
            IntPort cached = __VariableDeclaratorExpression<IntPort>("cached", () => ChipLib.EventCache<IntPort>(sum), (_RRCG_SETTER_VALUE) => cached = _RRCG_SETTER_VALUE);
            PlayerShowSubtitle(GetLocalPlayer(), ToString<IntPort>(cached), 3.0f, 0);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VariableLoopExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            IntPort intValue = __VariableDeclaratorExpression<IntPort>("intValue", () => testEvent.Receiver(), (_RRCG_SETTER_VALUE) => intValue = _RRCG_SETTER_VALUE);
            RRCGBuild.Variable<IntPort> counter = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("counter", () => new Variable<IntPort>(), (_RRCG_SETTER_VALUE) => counter = _RRCG_SETTER_VALUE);
            __While(ChipBuilder.LessThan(counter.Value, intValue), delegate
            {
                __BeginAccessibilityScope(true);
                ChipLib.Log(counter.Value);
                counter.Value++;
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public ExampleRoom()
        {
            testEvent = __VariableDeclaratorExpression<EventDefinition<IntPort>>("testEvent", () => new EventDefinition<IntPort>("intValue"), (_RRCG_SETTER_VALUE) => testEvent = _RRCG_SETTER_VALUE);
        }
    }
}