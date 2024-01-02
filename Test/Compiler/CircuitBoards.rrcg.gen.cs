using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class CircuitBoards : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort a = default !;
                a = __VariableDeclaratorExpression<IntPort>("a", () => RandomInt(1, 10), () => a!, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            CircuitBoard(ContentsExec);
                IntPort b = default !;
                b = __VariableDeclaratorExpression<IntPort>("b", () => CircuitBoard<IntPort, IntPort>(ContentsMixed, a), () => b!, (_RRCG_SETTER_VALUE) => b = _RRCG_SETTER_VALUE);
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
                __BeginReturnScope(null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                ChipLib.Log("Anonymous Parameter");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , a);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ContentsExec()
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        IntPort ContentsMixed(IntPort a)
        {
            __BeginReturnScope(typeof(IntPort));
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return(RandomInt(a, 10));
            __EndAccessibilityScope();
            return __EndReturnScope();
        }

        (IntPort namedValue, IntPort) ContentsData(IntPort a, IntPort b)
        {
            __BeginReturnScope(typeof((IntPort namedValue, IntPort)));
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return((a, b));
            __EndAccessibilityScope();
            return __EndReturnScope();
        }

        void ExecOut()
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            EventReceiver(RoomEvents.Hz30);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ExecIn()
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}