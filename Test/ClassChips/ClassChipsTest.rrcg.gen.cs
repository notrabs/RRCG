using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class ClassChipsTest : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            DelayTest();
            ErrorTest();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void DelayTest()
        {
            __BeginReturnScope("DelayTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.Delay delay = default !;
                delay = __VariableDeclaratorExpression<RRCGBuild.Delay>("delay", () => new Delay(5), () => delay!, (_RRCG_SETTER_VALUE) => delay = _RRCG_SETTER_VALUE);
            ChipLib.Log("Delay Test 1");
            delay.Cancel().Run();
            ChipLib.Log("Delay is scheduled");
            delay.Await();
            ChipLib.Log("After delay");
            StartNewGraph();
            ChipLib.Log("Delay Test 2");
            // Should only connect the cancel pin because run was called
            delay.Cancel().Run();
            StartNewGraph();
            ChipLib.Log("Delay Test 3");
            delay.Run();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ErrorTest()
        {
            __BeginReturnScope("ErrorTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            TestUtils.ExpectToThrow(() =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    RRCGBuild.Delay delay = default !;
                    delay = __VariableDeclaratorExpression<RRCGBuild.Delay>("delay", () => new Delay(1), () => delay!, (_RRCG_SETTER_VALUE) => delay = _RRCG_SETTER_VALUE);
                delay.Await();
                delay.Await();
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , "Await can only be called once");
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}