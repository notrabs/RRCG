using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ExampleRoom : RRCGBuild.CircuitBuilder
    {
        RRCGBuild.EventDefinition<RRCGBuild.IntPort> testEvent = __NamedAssignment<RRCGBuild.EventDefinition<RRCGBuild.IntPort>>("testEvent", () => new RRCGBuild.EventDefinition<RRCGBuild.IntPort>("intValue"));
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
            RRCGBuild.RoomEvent.Hz30();
                RRCGBuild.IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<RRCGBuild.IntPort>("rand1", () => RandomInt(0, 10), () => rand1!, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort rand2 = default !;
                rand2 = __VariableDeclaratorExpression<RRCGBuild.IntPort>("rand2", () => RandomInt(0, 10), () => rand2!, (_RRCG_SETTER_VALUE) => rand2 = _RRCG_SETTER_VALUE);
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
            RRCGBuild.RoomEvent.Hz30();
                RRCGBuild.IntPort rand1 = default !;
                rand1 = __VariableDeclaratorExpression<RRCGBuild.IntPort>("rand1", () => RandomInt(0, 10), () => rand1!, (_RRCG_SETTER_VALUE) => rand1 = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort sum = default !;
                sum = __VariableDeclaratorExpression<RRCGBuild.IntPort>("sum", () => (rand1 + 3) + (4 + 5), () => sum!, (_RRCG_SETTER_VALUE) => sum = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort cached = default !;
                cached = __VariableDeclaratorExpression<RRCGBuild.IntPort>("cached", () => RRCGBuild.ChipLib.EventCache<RRCGBuild.IntPort>(sum), () => cached!, (_RRCG_SETTER_VALUE) => cached = _RRCG_SETTER_VALUE);
            PlayerShowSubtitle(GetLocalPlayer(), ToString<RRCGBuild.IntPort>(cached), 3.0f, 0);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void VariableLoopExample()
        {
            __BeginReturnScope("VariableLoopExample", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.IntPort intValue = default !;
                intValue = __VariableDeclaratorExpression<RRCGBuild.IntPort>("intValue", () => testEvent.Receiver(), () => intValue!, (_RRCG_SETTER_VALUE) => intValue = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.IntPort> counter = default !;
                counter = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.IntPort>>("counter", () => new RRCGBuild.Variable<RRCGBuild.IntPort>(), () => counter!, (_RRCG_SETTER_VALUE) => counter = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => ChipBuilder.LessThan(counter.Value, intValue), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(counter.Value);
                counter.Value++;
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}