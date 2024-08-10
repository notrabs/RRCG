using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
    public class EventFunctionsTest : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            Void0();
            Void1("test");
            Void1(2);
            Void2("test", 42);
            Void3("test", 42, 3f);
            // Call again with different parameters
            Void0();
            Void1("test2");
            Void1(5);
            Void2("test2", 43);
            Void3("test2", 43, 4f);
            // Test returns
            ChipLib.Log(SingleReturn());
            ChipLib.Log(DataReturn());
                (IntPort, StringPort) tuple = default !;
                tuple = __VariableDeclaratorExpression<(IntPort, StringPort)>("tuple", () => TupleReturn(5), () => tuple!, (_RRCG_SETTER_VALUE) => tuple = _RRCG_SETTER_VALUE);
            ChipLib.Log(tuple.Item1);
            ChipLib.Log(tuple.Item2);
            tuple = MultiInOut(6, "test");
            ChipLib.Log(tuple.Item1);
            ChipLib.Log(tuple.Item2);
            // Check that all remaining interfaces compile
            Void4(1, 2, 3, 4);
            Void5(1, 2, 3, 4, 5);
            Void6(1, 2, 3, 4, 5, 6);
            Void7(1, 2, 3, 4, 5, 6, 7);
            Void8(1, 2, 3, 4, 5, 6, 7, 8);
            NonVoid4(1, 2, 3, 4);
            NonVoid5(1, 2, 3, 4, 5);
            NonVoid6(1, 2, 3, 4, 5, 6);
            NonVoid7(1, 2, 3, 4, 5, 6, 7);
            NonVoid8(1, 2, 3, 4, 5, 6, 7, 8);
            PublicProperFunction();
            // Test static event functions
            ChipLib.Log(StaticTest());
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        void Void0()
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction(this, "Void0", delegate ()
            {
                __BeginReturnScope("Void0", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                ChipLib.Log("void0");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        void Void1(StringPort p0)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort>(this, "Void1", delegate (StringPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void1(IntPort p0)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort>(this, "Void1", delegate (IntPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void2(StringPort p0, IntPort p1)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, IntPort>(this, "Void2", delegate (StringPort p0, IntPort p1)
            {
                __BeginReturnScope("Void2", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                ChipLib.Log(__StringInterpolation("void2 ", p0, " ", p1));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1);
        }

        [EventFunction]
        void Void3(StringPort p0, IntPort p1, FloatPort p2)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, IntPort, FloatPort>(this, "Void3", delegate (StringPort p0, IntPort p1, FloatPort p2)
            {
                __BeginReturnScope("Void3", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<FloatPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                ChipLib.Log(__StringInterpolation("void3 ", p0, " ", p1, " ", p2));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2);
        }

        [EventFunction]
        IntPort SingleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort>(this, "SingleReturn", delegate ()
            {
                __BeginReturnScope("SingleReturn", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<IntPort>(RandomInt(1, 10));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        IntPort DataReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort>(this, "DataReturn", delegate ()
            {
                __BeginReturnScope("DataReturn", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<IntPort>(3);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (IntPort, StringPort) TupleReturn(IntPort number)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(IntPort, StringPort), IntPort>(this, "TupleReturn", delegate (IntPort number)
            {
                __BeginReturnScope("TupleReturn", typeof((IntPort, StringPort)), new[]{"value0", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("number", null, () => number!, (_RRCG_SETTER_VALUE) => number = _RRCG_SETTER_VALUE);
                __Return<(IntPort, StringPort)>((number, number.ToString()));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , number);
        }

        [EventFunction]
        (IntPort, StringPort) MultiInOut(IntPort number, StringPort text)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(IntPort, StringPort), IntPort, StringPort>(this, "MultiInOut", delegate (IntPort number, StringPort text)
            {
                __BeginReturnScope("MultiInOut", typeof((IntPort, StringPort)), new[]{"value0", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("number", null, () => number!, (_RRCG_SETTER_VALUE) => number = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<StringPort>("text", null, () => text!, (_RRCG_SETTER_VALUE) => text = _RRCG_SETTER_VALUE);
                __Return<(IntPort, StringPort)>((number, text));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , number, text);
        }

        // Interface test
        [EventFunction]
        void Void4(IntPort p0, IntPort p1, IntPort p2, IntPort p3)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort>(this, "Void4", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3)
            {
                __BeginReturnScope("Void4", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        void Void5(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort>(this, "Void5", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
            {
                __BeginReturnScope("Void5", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        void Void6(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "Void6", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
            {
                __BeginReturnScope("Void6", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        void Void7(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "Void7", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
            {
                __BeginReturnScope("Void7", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        void Void8(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "Void8", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
            {
                __BeginReturnScope("Void8", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p7", null, () => p7!, (_RRCG_SETTER_VALUE) => p7 = _RRCG_SETTER_VALUE);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6, p7);
        }

        [EventFunction]
        IntPort NonVoid4(IntPort p0, IntPort p1, IntPort p2, IntPort p3)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort>(this, "NonVoid4", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3)
            {
                __BeginReturnScope("NonVoid4", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __Return<IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        IntPort NonVoid5(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "NonVoid5", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
            {
                __BeginReturnScope("NonVoid5", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __Return<IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        IntPort NonVoid6(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "NonVoid6", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
            {
                __BeginReturnScope("NonVoid6", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __Return<IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        IntPort NonVoid7(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "NonVoid7", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
            {
                __BeginReturnScope("NonVoid7", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __Return<IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        IntPort NonVoid8(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>(this, "NonVoid8", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
            {
                __BeginReturnScope("NonVoid8", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("p7", null, () => p7!, (_RRCG_SETTER_VALUE) => p7 = _RRCG_SETTER_VALUE);
                __Return<IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5, p6, p7);
        }

        [EventFunction]
        public void PublicProperFunction()
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction(this, "PublicProperFunction", delegate ()
            {
                __BeginReturnScope("PublicProperFunction", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        static StringPort StaticTest()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort>(typeof(EventFunctionsTest), "StaticTest", delegate ()
            {
                __BeginReturnScope("StaticTest", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    StringPort result = default !;
                    result = __VariableDeclaratorExpression<StringPort>("result", () => "static works", () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __OptimizedFor(__ConditionalContext("i", "result"), 0, 10, (i) =>
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        result += "!";
                        __EndAccessibilityScope();
                    }

                    , () =>
                    {
                    }

                    );
                    __EndAccessibilityScope();
                }

                __Return<StringPort>(result);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }
    }
}