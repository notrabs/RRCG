using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : CircuitBuilder
    {
        EventDefinition<IntPort> testEvent = __VariableDeclaratorExpression<RRCGBuild.EventDefinition<IntPort>>("testEvent", () => new EventDefinition<IntPort>("intValue"));
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
            IntPort rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), (rrcg_setter_value) => rand1 = rrcg_setter_value);
            IntPort rand2 = __VariableDeclaratorExpression<IntPort>("rand2", () => RandomInt(0, 10), (rrcg_setter_value) => rand2 = rrcg_setter_value);
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
            IntPort rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), (rrcg_setter_value) => rand1 = rrcg_setter_value);
            IntPort sum = __VariableDeclaratorExpression<IntPort>("sum", () => (rand1 + 3) + (4 + 5), (rrcg_setter_value) => sum = rrcg_setter_value);
            IntPort cached = __VariableDeclaratorExpression<IntPort>("cached", () => ChipLib.EventCache<IntPort>(sum), (rrcg_setter_value) => cached = rrcg_setter_value);
            PlayerShowSubtitle(GetLocalPlayer(), ToString<IntPort>(cached), 3.0f, 0);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VariableLoopExample()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            IntPort intValue = __VariableDeclaratorExpression<IntPort>("intValue", () => testEvent.Receiver(), (rrcg_setter_value) => intValue = rrcg_setter_value);
            RRCGBuild.Variable<IntPort> counter = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("counter", () => new Variable<IntPort>(), (rrcg_setter_value) => counter = rrcg_setter_value);
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
    }
}