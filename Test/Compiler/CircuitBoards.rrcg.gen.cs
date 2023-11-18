using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class CircuitBoards : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var a = __VariableDeclaratorExpression("a", () => RandomInt(1, 10));
            CircuitBoard(ContentsExec);
            var b = __VariableDeclaratorExpression("b", () => CircuitBoard(ContentsMixed, a));
            ChipLib.Log(b);
            var(c, d) = CircuitBoard(ContentsData, b, b);
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
                __BeginLabelAccessibilityScope(false);
                ExecFlow rrcg_return_flow = new ExecFlow();
                ChipLib.Log("Anonymous Parameter");
                ExecFlow.current.Merge(rrcg_return_flow);
                __EndLabelAccessibilityScope();
            }

            , a);
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void ContentsExec()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            RandomInt(1, 10);
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        IntPort ContentsMixed(IntPort a)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __Return(rrcg_return_flow, out rrcg_return_data, RandomInt(a, 10));
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
            return rrcg_return_data;
        }

        (IntPort namedValue, IntPort) ContentsData(IntPort a, IntPort b)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __Return(rrcg_return_flow, out rrcg_return_data, (a, b));
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
            return rrcg_return_data;
        }

        void ExecOut()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            EventReceiver(RoomEvents.Hz30);
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void ExecIn()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            RandomInt(1, 10);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }
    }
}