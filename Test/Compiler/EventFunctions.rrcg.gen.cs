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
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        void Void0()
        {
            __DispatchEventFunction("Void0", delegate ()
            {
                __BeginReturnScope("Void0", null, null);
                ChipLib.Log("void0");
                __EndReturnScope();
            }

            );
        }

        [EventFunction]
        void Void1(StringPort p0)
        {
            __DispatchEventFunction<StringPort>("Void1", delegate (StringPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void1(IntPort p0)
        {
            __DispatchEventFunction<IntPort>("Void1", delegate (IntPort p0)
            {
                __BeginReturnScope("Void1", null, null);
                ChipLib.Log(__StringInterpolation("void1 ", p0));
                __EndReturnScope();
            }

            , p0);
        }

        [EventFunction]
        void Void2(StringPort p0, IntPort p1)
        {
            __DispatchEventFunction<StringPort, IntPort>("Void2", delegate (StringPort p0, IntPort p1)
            {
                __BeginReturnScope("Void2", null, null);
                ChipLib.Log(__StringInterpolation("void2 ", p0, " ", p1));
                __EndReturnScope();
            }

            , p0, p1);
        }

        [EventFunction]
        void Void3(StringPort p0, IntPort p1, FloatPort p2)
        {
            __DispatchEventFunction<StringPort, IntPort, FloatPort>("Void3", delegate (StringPort p0, IntPort p1, FloatPort p2)
            {
                __BeginReturnScope("Void3", null, null);
                ChipLib.Log(__StringInterpolation("void3 ", p0, " ", p1, " ", p2));
                __EndReturnScope();
            }

            , p0, p1, p2);
        }

        [EventFunction]
        IntPort SingleReturn()
        {
            return __DispatchEventFunction<IntPort>("SingleReturn", delegate ()
            {
                __BeginReturnScope("SingleReturn", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 10));
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        IntPort DataReturn()
        {
            return __DispatchEventFunction<IntPort>("DataReturn", delegate ()
            {
                __BeginReturnScope("DataReturn", typeof(IntPort), null);
                __Return<IntPort>(3);
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (IntPort, StringPort) TupleReturn(IntPort number)
        {
            return __DispatchEventFunction<(IntPort, StringPort), IntPort>("TupleReturn", delegate (IntPort number)
            {
                __BeginReturnScope("TupleReturn", typeof((IntPort, StringPort)), new[]{"value0", "value1"});
                __Return<(IntPort, StringPort)>((number, number.ToString()));
                return __EndReturnScope()!;
            }

            , number);
        }

        [EventFunction]
        (IntPort, StringPort) MultiInOut(IntPort number, StringPort text)
        {
            return __DispatchEventFunction<(IntPort, StringPort), IntPort, StringPort>("MultiInOut", delegate (IntPort number, StringPort text)
            {
                __BeginReturnScope("MultiInOut", typeof((IntPort, StringPort)), new[]{"value0", "value1"});
                __Return<(IntPort, StringPort)>((number, text));
                return __EndReturnScope()!;
            }

            , number, text);
        }

        // Interface test
        [EventFunction]
        void Void4(IntPort p0, IntPort p1, IntPort p2, IntPort p3)
        {
            __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort>("Void4", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3)
            {
                __BeginReturnScope("Void4", null, null);
                ChipLib.Log("compiled!");
                __EndReturnScope();
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        void Void5(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
        {
            __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort>("Void5", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
            {
                __BeginReturnScope("Void5", null, null);
                ChipLib.Log("compiled!");
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        void Void6(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
        {
            __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("Void6", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
            {
                __BeginReturnScope("Void6", null, null);
                ChipLib.Log("compiled!");
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        void Void7(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
        {
            __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("Void7", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
            {
                __BeginReturnScope("Void7", null, null);
                ChipLib.Log("compiled!");
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        void Void8(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
        {
            __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("Void8", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
            {
                __BeginReturnScope("Void8", null, null);
                ChipLib.Log("compiled!");
                __EndReturnScope();
            }

            , p0, p1, p2, p3, p4, p5, p6, p7);
        }

        [EventFunction]
        IntPort NonVoid4(IntPort p0, IntPort p1, IntPort p2, IntPort p3)
        {
            return __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort>("NonVoid4", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3)
            {
                __BeginReturnScope("NonVoid4", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 2));
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3);
        }

        [EventFunction]
        IntPort NonVoid5(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
        {
            return __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("NonVoid5", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4)
            {
                __BeginReturnScope("NonVoid5", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 2));
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4);
        }

        [EventFunction]
        IntPort NonVoid6(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
        {
            return __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("NonVoid6", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5)
            {
                __BeginReturnScope("NonVoid6", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 2));
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5);
        }

        [EventFunction]
        IntPort NonVoid7(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
        {
            return __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("NonVoid7", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6)
            {
                __BeginReturnScope("NonVoid7", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 2));
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5, p6);
        }

        [EventFunction]
        IntPort NonVoid8(IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
        {
            return __DispatchEventFunction<IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort, IntPort>("NonVoid8", delegate (IntPort p0, IntPort p1, IntPort p2, IntPort p3, IntPort p4, IntPort p5, IntPort p6, IntPort p7)
            {
                __BeginReturnScope("NonVoid8", typeof(IntPort), null);
                __Return<IntPort>(RandomInt(1, 2));
                return __EndReturnScope()!;
            }

            , p0, p1, p2, p3, p4, p5, p6, p7);
        }

        [EventFunction]
        public void PublicProperFunction()
        {
            __DispatchEventFunction("PublicProperFunction", delegate ()
            {
                __BeginReturnScope("PublicProperFunction", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                ChipLib.Log("compiled!");
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
        }
    }
}