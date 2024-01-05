using RRCG;
using System;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
    public class Returns : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            InlineTests();
            CircuitBoardTests();
            EventFunctionTests();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InlineTests()
        {
            __BeginReturnScope("InlineTests", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            Test("InlineTests", () =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                // Test single non-tuple return
                LogString(SingleNonTupleReturn());
                // Test multiple non-tuple returns
                LogString(MultipleNonTupleReturns());
                    (StringPort Named, IntPort) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result0", () => SingleTupleReturn(), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (StringPort Named, IntPort) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result1", () => MultipleTupleReturns(), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(TestIfReturnWithPromoted());
                    ListPort<StringPort> list = default !;
                    list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ChipLib.EventCache<ListPort<StringPort>>(ListCreate<StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                LogString(TestWhileReturnWithPromoted(list));
                list[list.Count - 1] = "Not END";
                LogString(TestForEachReturnWithPromoted(list));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void CircuitBoardTests()
        {
            __BeginReturnScope("CircuitBoardTests", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            Test("CircuitBoardTests", () =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                // Test single non-tuple return
                LogString(CircuitBoard<StringPort>(SingleNonTupleReturn));
                // Test multiple non-tuple returns
                LogString(CircuitBoard<StringPort>(MultipleNonTupleReturns));
                    (StringPort Named, IntPort) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result0", () => CircuitBoard<(StringPort Named, IntPort)>(SingleTupleReturn), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (StringPort Named, IntPort) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result1", () => CircuitBoard<(StringPort Named, IntPort)>(MultipleTupleReturns), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(CircuitBoard<StringPort>(TestIfReturnWithPromoted));
                    ListPort<StringPort> list = default !;
                    list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ChipLib.EventCache<ListPort<StringPort>>(ListCreate<StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                LogString(CircuitBoard<ListPort<StringPort>, StringPort>(TestWhileReturnWithPromoted, list));
                list[list.Count - 1] = "Not END";
                LogString(CircuitBoard<ListPort<StringPort>, StringPort>(TestForEachReturnWithPromoted, list));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void EventFunctionTests()
        {
            __BeginReturnScope("EventFunctionTests", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            Test("EventFunctionTests", () =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                // Test single non-tuple return
                LogString(EFSingleNonTupleReturn());
                // Test multiple non-tuple returns
                LogString(EFMultipleNonTupleReturns());
                    (StringPort Named, IntPort) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result0", () => EFSingleTupleReturn(), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (StringPort Named, IntPort) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(StringPort Named, IntPort)>("result1", () => EFMultipleTupleReturns(), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(EFTestIfReturnWithPromoted());
                    ListPort<StringPort> list = default !;
                    list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ChipLib.EventCache<ListPort<StringPort>>(ListCreate<StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                LogString(EFTestWhileReturnWithPromoted(list));
                list[list.Count - 1] = "Not END";
                LogString(EFTestForEachReturnWithPromoted(list));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        StringPort SingleNonTupleReturn()
        {
            __BeginReturnScope("SingleNonTupleReturn", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return<StringPort>("Single Return");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        StringPort MultipleNonTupleReturns()
        {
            __BeginReturnScope("MultipleNonTupleReturns", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<StringPort>("Return Value 1");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<StringPort>("Return Value 2");
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        (StringPort Named, IntPort) SingleTupleReturn()
        {
            __BeginReturnScope("SingleTupleReturn", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return<(StringPort Named, IntPort)>(("Named Element", IntPort.MaxValue));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        (StringPort Named, IntPort) MultipleTupleReturns()
        {
            __BeginReturnScope("MultipleTupleReturns", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<(StringPort Named, IntPort)>(("Named 1", 1));
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<(StringPort Named, IntPort)>(("Named 2", 2));
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        StringPort TestIfReturnWithPromoted()
        {
            __BeginReturnScope("TestIfReturnWithPromoted", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                StringPort promoted = default !;
                promoted = __VariableDeclaratorExpression<StringPort>("promoted", () => Reroute<StringPort>("Hello"), () => promoted!, (_RRCG_SETTER_VALUE) => promoted = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext("promoted"), () => ParseBool("true").Result, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Assign("promoted", out promoted, () => promoted + ", world!");
                __Return<StringPort>(promoted);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __Return<StringPort>(__StringInterpolation("Default return: ", promoted));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        StringPort TestWhileReturnWithPromoted(ListPort<StringPort> list)
        {
            __BeginReturnScope("TestWhileReturnWithPromoted", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                StringPort output = default !;
                output = __VariableDeclaratorExpression<StringPort>("output", () => "", () => output!, (_RRCG_SETTER_VALUE) => output = _RRCG_SETTER_VALUE);
                IntPort i = default !;
                i = __VariableDeclaratorExpression<IntPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext("output", "i"), () => ChipBuilder.LessThan(i, list.Count), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    StringPort character = default !;
                    character = __VariableDeclaratorExpression<StringPort>("character", () => list[i], () => character!, (_RRCG_SETTER_VALUE) => character = _RRCG_SETTER_VALUE);
                __If(__ConditionalContext(), () => ChipBuilder.Equals(character, "END"), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<StringPort>(output);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __Assign("output", out output, () => output + character);
                i++;
                __EndAccessibilityScope();
            }

            );
            __Return<StringPort>("Failed to find END");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        StringPort TestForEachReturnWithPromoted(ListPort<StringPort> list)
        {
            __BeginReturnScope("TestForEachReturnWithPromoted", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                StringPort output = default !;
                output = __VariableDeclaratorExpression<StringPort>("output", () => "", () => output!, (_RRCG_SETTER_VALUE) => output = _RRCG_SETTER_VALUE);
            __ForEach(__ConditionalContext("output"), list, (character) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __If(__ConditionalContext(), () => ChipBuilder.Equals(character, "END"), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<StringPort>(output);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __Assign("output", out output, () => output + character);
                __EndAccessibilityScope();
            }

            );
            __Return<StringPort>("Failed to find END");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        [EventFunction]
        StringPort EFSingleNonTupleReturn()
        {
            return __DispatchEventFunction<StringPort>("EFSingleNonTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleNonTupleReturn", typeof(StringPort), null);
                __Return<StringPort>(SingleNonTupleReturn());
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFMultipleNonTupleReturns()
        {
            return __DispatchEventFunction<StringPort>("EFMultipleNonTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleNonTupleReturns", typeof(StringPort), null);
                __Return<StringPort>(MultipleNonTupleReturns());
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (StringPort Named, IntPort) EFSingleTupleReturn()
        {
            return __DispatchEventFunction<(StringPort Named, IntPort)>("EFSingleTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleTupleReturn", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
                __Return<(StringPort Named, IntPort)>(SingleTupleReturn());
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (StringPort Named, IntPort) EFMultipleTupleReturns()
        {
            return __DispatchEventFunction<(StringPort Named, IntPort)>("EFMultipleTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleTupleReturns", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
                __Return<(StringPort Named, IntPort)>(MultipleTupleReturns());
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFTestIfReturnWithPromoted()
        {
            return __DispatchEventFunction<StringPort>("EFTestIfReturnWithPromoted", delegate ()
            {
                __BeginReturnScope("EFTestIfReturnWithPromoted", typeof(StringPort), null);
                __Return<StringPort>(TestIfReturnWithPromoted());
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFTestWhileReturnWithPromoted(ListPort<StringPort> list)
        {
            return __DispatchEventFunction<StringPort, ListPort<StringPort>>("EFTestWhileReturnWithPromoted", delegate (ListPort<StringPort> list)
            {
                __BeginReturnScope("EFTestWhileReturnWithPromoted", typeof(StringPort), null);
                __Return<StringPort>(TestWhileReturnWithPromoted(list));
                return __EndReturnScope()!;
            }

            , list);
        }

        [EventFunction]
        StringPort EFTestForEachReturnWithPromoted(ListPort<StringPort> list)
        {
            return __DispatchEventFunction<StringPort, ListPort<StringPort>>("EFTestForEachReturnWithPromoted", delegate (ListPort<StringPort> list)
            {
                __BeginReturnScope("EFTestForEachReturnWithPromoted", typeof(StringPort), null);
                __Return<StringPort>(TestForEachReturnWithPromoted(list));
                return __EndReturnScope()!;
            }

            , list);
        }

        private void Test(StringPort name, Action test)
        {
            __BeginReturnScope("Test", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition(name).Receiver();
            LogString(__StringInterpolation("Starting test ", name));
            test();
            LogString(__StringInterpolation("Finished test ", name));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

