using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class ClassChipsTest : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            DelayTest();
            ErrorTest();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DelayTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            var delay = __VariableDeclaratorExpression<RRCGBuild.Delay>("delay", () => new Delay(5));
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
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ErrorTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            TestUtils.ExpectToThrow(() =>
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                __BeginAccessibilityScope(false);
                var delay = __VariableDeclaratorExpression<RRCGBuild.Delay>("delay", () => new Delay(1));
                delay.Await();
                delay.Await();
                __EndAccessibilityScope();
                ExecFlow.current.Merge(rrcg_return_flow);
            }

            , "Await can only be called once");
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}