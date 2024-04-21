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
                // Test returns from switch statements
                LogString(TestSwitchReturn(0));
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
                // Test returns from switch statements
                LogString(CircuitBoard<IntPort, StringPort>(TestSwitchReturn, 0));
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
                // Test returns from switch statements
                LogString(EFTestSwitchReturn(0));
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
                promoted += ", world!";
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
            __VariableDeclaratorExpression<ListPort<StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
                output += character;
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
            __VariableDeclaratorExpression<ListPort<StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
                output += character;
                __EndAccessibilityScope();
            }

            );
            __Return<StringPort>("Failed to find END");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        StringPort TestSwitchReturn(IntPort match)
        {
            __BeginReturnScope("TestSwitchReturn", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<IntPort>("match", null, () => match!, (_RRCG_SETTER_VALUE) => match = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_0");
                    LogString("Case 0 matched");
                    __Return<StringPort>("0");
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    LogString("Case 1 matched");
                    __Return<StringPort>("1");
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_2");
                    LogString("Case 2 matched");
                    match += 2;
                    __Return<StringPort>(match.ToString());
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("Default case");
                    __Return<StringPort>("Error: default case matched!");
                }

                ;
                __Switch(__ConditionalContext("match"), () => match, rrcg_switch_section_3, new()
                {{0, rrcg_switch_section_0}, {1, rrcg_switch_section_1}, {2, rrcg_switch_section_2}});
                __EndAccessibilityScope();
            }

            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        [EventFunction]
        StringPort EFSingleNonTupleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort>(this, "EFSingleNonTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleNonTupleReturn", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<StringPort>(SingleNonTupleReturn());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFMultipleNonTupleReturns()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort>(this, "EFMultipleNonTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleNonTupleReturns", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<StringPort>(MultipleNonTupleReturns());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (StringPort Named, IntPort) EFSingleTupleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(StringPort Named, IntPort)>(this, "EFSingleTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleTupleReturn", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<(StringPort Named, IntPort)>(SingleTupleReturn());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (StringPort Named, IntPort) EFMultipleTupleReturns()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(StringPort Named, IntPort)>(this, "EFMultipleTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleTupleReturns", typeof((StringPort Named, IntPort)), new[]{"Named", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<(StringPort Named, IntPort)>(MultipleTupleReturns());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFTestIfReturnWithPromoted()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort>(this, "EFTestIfReturnWithPromoted", delegate ()
            {
                __BeginReturnScope("EFTestIfReturnWithPromoted", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<StringPort>(TestIfReturnWithPromoted());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        StringPort EFTestWhileReturnWithPromoted(ListPort<StringPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, ListPort<StringPort>>(this, "EFTestWhileReturnWithPromoted", delegate (ListPort<StringPort> list)
            {
                __BeginReturnScope("EFTestWhileReturnWithPromoted", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<ListPort<StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<StringPort>(TestWhileReturnWithPromoted(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        [EventFunction]
        StringPort EFTestForEachReturnWithPromoted(ListPort<StringPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, ListPort<StringPort>>(this, "EFTestForEachReturnWithPromoted", delegate (ListPort<StringPort> list)
            {
                __BeginReturnScope("EFTestForEachReturnWithPromoted", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<ListPort<StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<StringPort>(TestForEachReturnWithPromoted(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        [EventFunction]
        StringPort EFTestSwitchReturn(IntPort match)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, IntPort>(this, "EFTestSwitchReturn", delegate (IntPort match)
            {
                __BeginReturnScope("EFTestSwitchReturn", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<IntPort>("match", null, () => match!, (_RRCG_SETTER_VALUE) => match = _RRCG_SETTER_VALUE);
                __Return<StringPort>(TestSwitchReturn(match));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , match);
        }

        private void Test(StringPort name, Action test)
        {
            __BeginReturnScope("Test", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("name", null, () => name!, (_RRCG_SETTER_VALUE) => name = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<Action>("test", null, () => test!, (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
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

