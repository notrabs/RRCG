using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
    public class EventFunctionsTest : RRCGBuild.CircuitBuilder
    {
        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_ContextDependency = __CreateNamedVariable<RRCGBuild.IntPort>("ContextDependency", 0, VariableKind.Local);
        RRCGBuild.IntPort ContextDependency
        {
            get => __RRCG_MEMBER_VARIABLE_ContextDependency.Value;
            set => __RRCG_MEMBER_VARIABLE_ContextDependency.Value = value;
        }

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
            RRCGBuild.ChipLib.Log(SingleReturn());
            RRCGBuild.ChipLib.Log(DataReturn());
                (RRCGBuild.IntPort Item1, RRCGBuild.StringPort Item2) tuple = default !;
                tuple = __VariableDeclaratorExpression<(RRCGBuild.IntPort Item1, RRCGBuild.StringPort Item2)>("tuple", () => TupleReturn(5), () => tuple!, (_RRCG_SETTER_VALUE) => tuple = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(tuple.Item1);
            RRCGBuild.ChipLib.Log(tuple.Item2);
            tuple = MultiInOut(6, "test");
            RRCGBuild.ChipLib.Log(tuple.Item1);
            RRCGBuild.ChipLib.Log(tuple.Item2);
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
            RRCGBuild.ChipLib.Log(StaticTest());
            // EventFunctions that have a "dependency" on a node
            // from a particular context should be placed in the
            // same context as that node. (TODO: Cross-context returns..)
            CircuitBoard(() =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                VoidCrossContext();
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            // Checks that event functions can access shared properties
            AccessingSharedProperty();
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
                RRCGBuild.ChipLib.Log("void0");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        void Void1(RRCGBuild.StringPort p0)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort>(this, "Void1", delegate (RRCGBuild.StringPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void1(RRCGBuild.IntPort p0)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort>(this, "Void1", delegate (RRCGBuild.IntPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void2(RRCGBuild.StringPort p0, RRCGBuild.IntPort p1)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.IntPort>(this, "Void2", delegate (RRCGBuild.StringPort p0, RRCGBuild.IntPort p1)
            {
                __BeginReturnScope("Void2", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log(__StringInterpolation("void2 ", p0, " ", p1));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1);
        }

        [EventFunction]
        void Void3(RRCGBuild.StringPort p0, RRCGBuild.IntPort p1, RRCGBuild.FloatPort p2)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.IntPort, RRCGBuild.FloatPort>(this, "Void3", delegate (RRCGBuild.StringPort p0, RRCGBuild.IntPort p1, RRCGBuild.FloatPort p2)
            {
                __BeginReturnScope("Void3", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.FloatPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log(__StringInterpolation("void3 ", p0, " ", p1, " ", p2));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2);
        }

        [EventFunction]
        RRCGBuild.IntPort SingleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort>(this, "SingleReturn", delegate ()
            {
                __BeginReturnScope("SingleReturn", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 10));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        RRCGBuild.IntPort DataReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort>(this, "DataReturn", delegate ()
            {
                __BeginReturnScope("DataReturn", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.IntPort>(3);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (RRCGBuild.IntPort, RRCGBuild.StringPort) TupleReturn(RRCGBuild.IntPort number)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(RRCGBuild.IntPort, RRCGBuild.StringPort), RRCGBuild.IntPort>(this, "TupleReturn", delegate (RRCGBuild.IntPort number)
            {
                __BeginReturnScope("TupleReturn", typeof((RRCGBuild.IntPort, RRCGBuild.StringPort)), new[]{"value0", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("number", null, () => number!, (_RRCG_SETTER_VALUE) => number = _RRCG_SETTER_VALUE);
                __Return<(RRCGBuild.IntPort, RRCGBuild.StringPort)>((number, number.ToString()));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , number);
        }

        [EventFunction]
        (RRCGBuild.IntPort, RRCGBuild.StringPort) MultiInOut(RRCGBuild.IntPort number, RRCGBuild.StringPort text)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(RRCGBuild.IntPort, RRCGBuild.StringPort), RRCGBuild.IntPort, RRCGBuild.StringPort>(this, "MultiInOut", delegate (RRCGBuild.IntPort number, RRCGBuild.StringPort text)
            {
                __BeginReturnScope("MultiInOut", typeof((RRCGBuild.IntPort, RRCGBuild.StringPort)), new[]{"value0", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("number", null, () => number!, (_RRCG_SETTER_VALUE) => number = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("text", null, () => text!, (_RRCG_SETTER_VALUE) => text = _RRCG_SETTER_VALUE);
                __Return<(RRCGBuild.IntPort, RRCGBuild.StringPort)>((number, text));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , number, text);
        }

        // Interface test
        [EventFunction]
        void Void4(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "Void4", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3)
            {
                __BeginReturnScope("Void4", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        void Void5(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "Void5", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4)
            {
                __BeginReturnScope("Void5", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        void Void6(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "Void6", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5)
            {
                __BeginReturnScope("Void6", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        void Void7(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "Void7", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6)
            {
                __BeginReturnScope("Void7", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        void Void8(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6, RRCGBuild.IntPort p7)
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "Void8", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6, RRCGBuild.IntPort p7)
            {
                __BeginReturnScope("Void8", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p7", null, () => p7!, (_RRCG_SETTER_VALUE) => p7 = _RRCG_SETTER_VALUE);
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6, p7);
        }

        [EventFunction]
        RRCGBuild.IntPort NonVoid4(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "NonVoid4", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3)
            {
                __BeginReturnScope("NonVoid4", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        RRCGBuild.IntPort NonVoid5(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "NonVoid5", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4)
            {
                __BeginReturnScope("NonVoid5", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        RRCGBuild.IntPort NonVoid6(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "NonVoid6", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5)
            {
                __BeginReturnScope("NonVoid6", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        RRCGBuild.IntPort NonVoid7(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "NonVoid7", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6)
            {
                __BeginReturnScope("NonVoid7", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 2));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        RRCGBuild.IntPort NonVoid8(RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6, RRCGBuild.IntPort p7)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort, RRCGBuild.IntPort>(this, "NonVoid8", delegate (RRCGBuild.IntPort p0, RRCGBuild.IntPort p1, RRCGBuild.IntPort p2, RRCGBuild.IntPort p3, RRCGBuild.IntPort p4, RRCGBuild.IntPort p5, RRCGBuild.IntPort p6, RRCGBuild.IntPort p7)
            {
                __BeginReturnScope("NonVoid8", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p0", null, () => p0!, (_RRCG_SETTER_VALUE) => p0 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p1", null, () => p1!, (_RRCG_SETTER_VALUE) => p1 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p2", null, () => p2!, (_RRCG_SETTER_VALUE) => p2 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p3", null, () => p3!, (_RRCG_SETTER_VALUE) => p3 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p4", null, () => p4!, (_RRCG_SETTER_VALUE) => p4 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p5", null, () => p5!, (_RRCG_SETTER_VALUE) => p5 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p6", null, () => p6!, (_RRCG_SETTER_VALUE) => p6 = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("p7", null, () => p7!, (_RRCG_SETTER_VALUE) => p7 = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(RandomInt(1, 2));
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
                RRCGBuild.ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        static RRCGBuild.StringPort StaticTest()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort>(typeof(EventFunctionsTest), "StaticTest", delegate ()
            {
                __BeginReturnScope("StaticTest", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    RRCGBuild.StringPort result = default !;
                    result = __VariableDeclaratorExpression<RRCGBuild.StringPort>("result", () => "static works", () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
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

                __Return<RRCGBuild.StringPort>(result);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        void VoidCrossContext()
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction(this, "VoidCrossContext", delegate ()
            {
                __BeginReturnScope("VoidCrossContext", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                // Because the content of this EventFunction
                // uses the ContextDependency variable (in the root context),
                // the receiver should also be placed in the root context,
                // despite its first invocation occuring in a subcontext.
                LogString(__StringInterpolation(ContextDependency));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        void AccessingSharedProperty()
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction(this, "AccessingSharedProperty", delegate ()
            {
                __BeginReturnScope("AccessingSharedProperty", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                SharedData();
                // There is a tricky situation, when EventFunctions are nested, and both use the same SharedData()
                AccessingSharedPropertyNested();
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        RRCGBuild.RecRoomObjectPort rootContextData = __NamedAssignment<RRCGBuild.RecRoomObjectPort>("rootContextData", () => RecRoomObjectGetFirstWithTag("rootcontext"));
        [EventFunction]
        void AccessingSharedPropertyNested()
        {
            SpecialMethodsDispatcher.current.DispatchEventFunction(this, "AccessingSharedPropertyNested", delegate ()
            {
                __BeginReturnScope("AccessingSharedPropertyNested", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.ChipLib.Log(rootContextData);
                RRCGBuild.ChipLib.Log(SharedData());
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }

        [SharedProperty]
        RRCGBuild.RecRoomObjectPort SharedData()
        {
            return SpecialMethodsDispatcher.current.DispatchSharedPropertyFunction<RRCGBuild.RecRoomObjectPort>(this, delegate ()
            {
                __BeginReturnScope("SharedData", typeof(RRCGBuild.RecRoomObjectPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.RecRoomObjectPort>(RecRoomObjectGetFirstWithTag("shared"));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }
    }
}