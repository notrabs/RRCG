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
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort a = default !;
                a = __VariableDeclaratorExpression<IntPort>("a", () => RandomInt(1, 10), () => a, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            CircuitBoard(ContentsExec);
                IntPort b = default !;
                b = __VariableDeclaratorExpression<IntPort>("b", () => CircuitBoard<IntPort, IntPort>(ContentsMixed, a), () => b, (_RRCG_SETTER_VALUE) => b = _RRCG_SETTER_VALUE);
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
            CircuitBoard<IntPort>((IntPort test) =>
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                ChipLib.Log("Anonymous Parameter");
                __EndAccessibilityScope();
                ExecFlow.current.Merge(rrcg_return_flow);
            }

            , a);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ContentsExec()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        IntPort ContentsMixed(IntPort a)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return(rrcg_return_flow, out rrcg_return_data, RandomInt(a, 10));
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        (IntPort namedValue, IntPort) ContentsData(IntPort a, IntPort b)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return(rrcg_return_flow, out rrcg_return_data, (a, b));
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void ExecOut()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            EventReceiver(RoomEvents.Hz30);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void ExecIn()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}