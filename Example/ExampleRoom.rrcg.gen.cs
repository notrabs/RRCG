using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomExample();
            EventCacheExample();
            VariableLoopExample();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void RandomExample()
        {
            __BeginReturnScope("RandomExample", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RoomEvent.Hz30();
                IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), () => rand1!, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                IntPort rand2 = default !;
                rand2 = __VariableDeclaratorExpression<IntPort>("rand2", () => RandomInt(0, 10), () => rand2!, (_RRCG_SETTER_VALUE) => rand2 = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext(), () => ChipBuilder.GreaterThan(rand1 + rand2, 10), delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Today's your lucky day");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Try again next time");
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void EventCacheExample()
        {
            __BeginReturnScope("EventCacheExample", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RoomEvent.Hz30();
                IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<IntPort>("rand1", () => RandomInt(0, 10), () => rand1!, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                IntPort sum = default !;
                sum = __VariableDeclaratorExpression<IntPort>("sum", () => (rand1 + 3) + (4 + 5), () => sum!, (_RRCG_SETTER_VALUE) => sum = _RRCG_SETTER_VALUE);
                IntPort cached = default !;
                cached = __VariableDeclaratorExpression<IntPort>("cached", () => ChipLib.EventCache<IntPort>(sum), () => cached!, (_RRCG_SETTER_VALUE) => cached = _RRCG_SETTER_VALUE);
            PlayerShowSubtitle(GetLocalPlayer(), ToString<IntPort>(cached), 3.0f, 0);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void VariableLoopExample()
        {
            __BeginReturnScope("VariableLoopExample", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort intValue = default !;
                intValue = __VariableDeclaratorExpression<IntPort>("intValue", () => testEvent.Receiver(), () => intValue!, (_RRCG_SETTER_VALUE) => intValue = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<IntPort> counter = default !;
                counter = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("counter", () => new Variable<IntPort>(), () => counter!, (_RRCG_SETTER_VALUE) => counter = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => ChipBuilder.LessThan(counter.Value, intValue), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                ChipLib.Log(counter.Value);
                counter.Value++;
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        EventDefinition<IntPort> testEvent = __NamedAssignment<EventDefinition<IntPort>>("testEvent", () => new EventDefinition<IntPort>("intValue"));
    }
}