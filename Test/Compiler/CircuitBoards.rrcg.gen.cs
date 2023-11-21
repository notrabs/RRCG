using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class CircuitBoards : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            var a = __VariableDeclaratorExpression("a", () => RandomInt(1, 10));
            CircuitBoard(ContentsExec);
            var b = __VariableDeclaratorExpression("b", () => CircuitBoard<IntPort, IntPort>(ContentsMixed, a));
            ChipLib.Log(b);
            var(c, d) = CircuitBoard<IntPort, IntPort, (IntPort namedValue, IntPort)>(ContentsData, b, b);
            ChipLib.Log(c);
            ChipLib.Log(d);
            CircuitBoard(ExecOut);
            CircuitBoard(ExecIn);
            // Returns are not translated yet
            //CircuitBoard(() =>
            //{
            //    ChipLib.Log("Anonymous Function");
            //    return "test";
            //});
            CircuitBoard((IntPort test) =>
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                __BeginLabelAccessibilityScope(false);
                ChipLib.Log("Anonymous Parameter");
                __EndLabelAccessibilityScope();
                ExecFlow.current.Merge(rrcg_return_flow);
            }

            , a);
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ContentsExec()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            RandomInt(1, 10);
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        IntPort ContentsMixed(IntPort a)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginLabelAccessibilityScope(false);
            __Return(rrcg_return_flow, out rrcg_return_data, RandomInt(a, 10));
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        (IntPort namedValue, IntPort) ContentsData(IntPort a, IntPort b)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginLabelAccessibilityScope(false);
            __Return(rrcg_return_flow, out rrcg_return_data, (a, b));
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void ExecOut()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            EventReceiver(RoomEvents.Hz30);
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ExecIn()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            RandomInt(1, 10);
            ExecFlow.current.Clear();
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}