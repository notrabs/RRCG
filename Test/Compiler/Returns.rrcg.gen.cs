using RRCG;
using System;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
    public class Returns : RRCGBuild.CircuitBuilder
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
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result0", () => SingleTupleReturn(), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result1", () => MultipleTupleReturns(), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(TestIfReturnWithPromoted());
                    RRCGBuild.ListPort<RRCGBuild.StringPort> list = default !;
                    list = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", () => RRCGBuild.ChipLib.EventCache<RRCGBuild.ListPort<RRCGBuild.StringPort>>(ListCreate<RRCGBuild.StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
                LogString(CircuitBoard<RRCGBuild.StringPort>(SingleNonTupleReturn));
                // Test multiple non-tuple returns
                LogString(CircuitBoard<RRCGBuild.StringPort>(MultipleNonTupleReturns));
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result0", () => CircuitBoard<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>(SingleTupleReturn), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result1", () => CircuitBoard<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>(MultipleTupleReturns), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(CircuitBoard<RRCGBuild.StringPort>(TestIfReturnWithPromoted));
                    RRCGBuild.ListPort<RRCGBuild.StringPort> list = default !;
                    list = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", () => RRCGBuild.ChipLib.EventCache<RRCGBuild.ListPort<RRCGBuild.StringPort>>(ListCreate<RRCGBuild.StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                LogString(CircuitBoard<RRCGBuild.ListPort<RRCGBuild.StringPort>, RRCGBuild.StringPort>(TestWhileReturnWithPromoted, list));
                list[list.Count - 1] = "Not END";
                LogString(CircuitBoard<RRCGBuild.ListPort<RRCGBuild.StringPort>, RRCGBuild.StringPort>(TestForEachReturnWithPromoted, list));
                // Test returns from switch statements
                LogString(CircuitBoard<RRCGBuild.IntPort, RRCGBuild.StringPort>(TestSwitchReturn, 0));
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
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result0 = default !;
                    result0 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result0", () => EFSingleTupleReturn(), () => result0!, (_RRCG_SETTER_VALUE) => result0 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result0.Named, ", Item2: ", result0.Item2));
                    (RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2) result1 = default !;
                    result1 = __VariableDeclaratorExpression<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>("result1", () => EFMultipleTupleReturns(), () => result1!, (_RRCG_SETTER_VALUE) => result1 = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Named: ", result1.Named, ", Item2: ", result1.Item2));
                // Test returns with variable promotions
                LogString(EFTestIfReturnWithPromoted());
                    RRCGBuild.ListPort<RRCGBuild.StringPort> list = default !;
                    list = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", () => RRCGBuild.ChipLib.EventCache<RRCGBuild.ListPort<RRCGBuild.StringPort>>(ListCreate<RRCGBuild.StringPort>("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END")), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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

        RRCGBuild.StringPort SingleNonTupleReturn()
        {
            __BeginReturnScope("SingleNonTupleReturn", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return<RRCGBuild.StringPort>("Single Return");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        RRCGBuild.StringPort MultipleNonTupleReturns()
        {
            __BeginReturnScope("MultipleNonTupleReturns", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<RRCGBuild.StringPort>("Return Value 1");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<RRCGBuild.StringPort>("Return Value 2");
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        (RRCGBuild.StringPort Named, RRCGBuild.IntPort) SingleTupleReturn()
        {
            __BeginReturnScope("SingleTupleReturn", typeof((RRCGBuild.StringPort Named, RRCGBuild.IntPort)), new[]{"Named", "value1"});
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __Return<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>(("Named Element", RRCGBuild.IntPort.MaxValue));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        (RRCGBuild.StringPort Named, RRCGBuild.IntPort) MultipleTupleReturns()
        {
            __BeginReturnScope("MultipleTupleReturns", typeof((RRCGBuild.StringPort Named, RRCGBuild.IntPort)), new[]{"Named", "value1"});
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>(("Named 1", 1));
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Return<(RRCGBuild.StringPort Named, RRCGBuild.IntPort Item2)>(("Named 2", 2));
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        RRCGBuild.StringPort TestIfReturnWithPromoted()
        {
            __BeginReturnScope("TestIfReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.StringPort promoted = default !;
                promoted = __VariableDeclaratorExpression<RRCGBuild.StringPort>("promoted", () => Reroute<RRCGBuild.StringPort>("Hello"), () => promoted!, (_RRCG_SETTER_VALUE) => promoted = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext("promoted"), () => ParseBool("true").Result, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                promoted += ", world!";
                __Return<RRCGBuild.StringPort>(promoted);
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            __Return<RRCGBuild.StringPort>(__StringInterpolation("Default return: ", promoted));
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        RRCGBuild.StringPort TestWhileReturnWithPromoted(RRCGBuild.ListPort<RRCGBuild.StringPort> list)
        {
            __BeginReturnScope("TestWhileReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort output = default !;
                output = __VariableDeclaratorExpression<RRCGBuild.StringPort>("output", () => "", () => output!, (_RRCG_SETTER_VALUE) => output = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort i = default !;
                i = __VariableDeclaratorExpression<RRCGBuild.IntPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext("output", "i"), () => ChipBuilder.LessThan(i, list.Count), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    RRCGBuild.StringPort character = default !;
                    character = __VariableDeclaratorExpression<RRCGBuild.StringPort>("character", () => list[i], () => character!, (_RRCG_SETTER_VALUE) => character = _RRCG_SETTER_VALUE);
                __If(__ConditionalContext(), () => ChipBuilder.Equals(character, "END"), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<RRCGBuild.StringPort>(output);
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
            __Return<RRCGBuild.StringPort>("Failed to find END");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        RRCGBuild.StringPort TestForEachReturnWithPromoted(RRCGBuild.ListPort<RRCGBuild.StringPort> list)
        {
            __BeginReturnScope("TestForEachReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort output = default !;
                output = __VariableDeclaratorExpression<RRCGBuild.StringPort>("output", () => "", () => output!, (_RRCG_SETTER_VALUE) => output = _RRCG_SETTER_VALUE);
            __ForEach(__ConditionalContext("output"), list, (character) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __If(__ConditionalContext(), () => ChipBuilder.Equals(character, "END"), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<RRCGBuild.StringPort>(output);
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
            __Return<RRCGBuild.StringPort>("Failed to find END");
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        RRCGBuild.StringPort TestSwitchReturn(RRCGBuild.IntPort match)
        {
            __BeginReturnScope("TestSwitchReturn", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("match", null, () => match!, (_RRCG_SETTER_VALUE) => match = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_0");
                    LogString("Case 0 matched");
                    __Return<RRCGBuild.StringPort>("0");
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    LogString("Case 1 matched");
                    __Return<RRCGBuild.StringPort>("1");
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_2");
                    LogString("Case 2 matched");
                    match += 2;
                    __Return<RRCGBuild.StringPort>(match.ToString());
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("Default case");
                    __Return<RRCGBuild.StringPort>("Error: default case matched!");
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
        RRCGBuild.StringPort EFSingleNonTupleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort>(this, "EFSingleNonTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleNonTupleReturn", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.StringPort>(SingleNonTupleReturn());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        RRCGBuild.StringPort EFMultipleNonTupleReturns()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort>(this, "EFMultipleNonTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleNonTupleReturns", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.StringPort>(MultipleNonTupleReturns());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (RRCGBuild.StringPort Named, RRCGBuild.IntPort) EFSingleTupleReturn()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(RRCGBuild.StringPort Named, RRCGBuild.IntPort)>(this, "EFSingleTupleReturn", delegate ()
            {
                __BeginReturnScope("EFSingleTupleReturn", typeof((RRCGBuild.StringPort Named, RRCGBuild.IntPort)), new[]{"Named", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<(RRCGBuild.StringPort Named, RRCGBuild.IntPort)>(SingleTupleReturn());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        (RRCGBuild.StringPort Named, RRCGBuild.IntPort) EFMultipleTupleReturns()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<(RRCGBuild.StringPort Named, RRCGBuild.IntPort)>(this, "EFMultipleTupleReturns", delegate ()
            {
                __BeginReturnScope("EFMultipleTupleReturns", typeof((RRCGBuild.StringPort Named, RRCGBuild.IntPort)), new[]{"Named", "value1"});
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<(RRCGBuild.StringPort Named, RRCGBuild.IntPort)>(MultipleTupleReturns());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        RRCGBuild.StringPort EFTestIfReturnWithPromoted()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort>(this, "EFTestIfReturnWithPromoted", delegate ()
            {
                __BeginReturnScope("EFTestIfReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.StringPort>(TestIfReturnWithPromoted());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        [EventFunction]
        RRCGBuild.StringPort EFTestWhileReturnWithPromoted(RRCGBuild.ListPort<RRCGBuild.StringPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.ListPort<RRCGBuild.StringPort>>(this, "EFTestWhileReturnWithPromoted", delegate (RRCGBuild.ListPort<RRCGBuild.StringPort> list)
            {
                __BeginReturnScope("EFTestWhileReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.StringPort>(TestWhileReturnWithPromoted(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        [EventFunction]
        RRCGBuild.StringPort EFTestForEachReturnWithPromoted(RRCGBuild.ListPort<RRCGBuild.StringPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.ListPort<RRCGBuild.StringPort>>(this, "EFTestForEachReturnWithPromoted", delegate (RRCGBuild.ListPort<RRCGBuild.StringPort> list)
            {
                __BeginReturnScope("EFTestForEachReturnWithPromoted", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.StringPort>(TestForEachReturnWithPromoted(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        [EventFunction]
        RRCGBuild.StringPort EFTestSwitchReturn(RRCGBuild.IntPort match)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.IntPort>(this, "EFTestSwitchReturn", delegate (RRCGBuild.IntPort match)
            {
                __BeginReturnScope("EFTestSwitchReturn", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("match", null, () => match!, (_RRCG_SETTER_VALUE) => match = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.StringPort>(TestSwitchReturn(match));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , match);
        }

        private void Test(RRCGBuild.StringPort name, System.Action test)
        {
            __BeginReturnScope("Test", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.StringPort>("name", null, () => name!, (_RRCG_SETTER_VALUE) => name = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<System.Action>("test", null, () => test!, (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition(name).Receiver();
            LogString(__StringInterpolation("Starting test ", name));
            test();
            LogString(__StringInterpolation("Finished test ", name));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

