using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class CircuitBoards : RRCGBuild.CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.IntPort a = default !;
                a = __VariableDeclaratorExpression<RRCGBuild.IntPort>("a", () => RandomInt(1, 10), () => a!, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            CircuitBoard(ContentsExec);
                RRCGBuild.IntPort b = default !;
                b = __VariableDeclaratorExpression<RRCGBuild.IntPort>("b", () => CircuitBoard<RRCGBuild.IntPort, RRCGBuild.IntPort>(ContentsMixed, a), () => b!, (_RRCG_SETTER_VALUE) => b = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(b);
            var(c, d) = CircuitBoard<RRCGBuild.IntPort, RRCGBuild.IntPort, (RRCGBuild.IntPort namedValue, RRCGBuild.IntPort Item2)>(ContentsData, b, b);
            RRCGBuild.ChipLib.Log(c);
            RRCGBuild.ChipLib.Log(d);
            CircuitBoard(ExecOut);
            CircuitBoard(ExecIn);
            // Returns are not translated yet
            //CircuitBoard(() =>
            //{
            //    ChipLib.Log("Anonymous Function");
            //    return "test";
            //});
            CircuitBoard<RRCGBuild.IntPort>((RRCGBuild.IntPort test) =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("test", null, () => test!, (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("Anonymous Parameter");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , a);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ContentsExec()
        {
            __BeginReturnScope("ContentsExec", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        RRCGBuild.IntPort ContentsMixed(RRCGBuild.IntPort a)
        {
            __BeginReturnScope("ContentsMixed", typeof(RRCGBuild.IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("a", null, () => a!, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            __Return<RRCGBuild.IntPort>(RandomInt(a, 10));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        (RRCGBuild.IntPort namedValue, RRCGBuild.IntPort) ContentsData(RRCGBuild.IntPort a, RRCGBuild.IntPort b)
        {
            __BeginReturnScope("ContentsData", typeof((RRCGBuild.IntPort namedValue, RRCGBuild.IntPort)), new[]{"namedValue", "value1"});
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("a", null, () => a!, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("b", null, () => b!, (_RRCG_SETTER_VALUE) => b = _RRCG_SETTER_VALUE);
            __Return<(RRCGBuild.IntPort namedValue, RRCGBuild.IntPort Item2)>((a, b));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void ExecOut()
        {
            __BeginReturnScope("ExecOut", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.RoomEvent.Hz30();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ExecIn()
        {
            __BeginReturnScope("ExecIn", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RandomInt(1, 10);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}