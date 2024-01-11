using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Switches : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            SwitchTypes("test", 22);
            LogString("Return from SwitchTypes()");
            ConditionalReturn("test", true);
            LogString("Return from ConditionalReturn()");
            SwitchInWhileLoop();
            LogString("Return from SwitchInWhileLoop()");
            SwitchPromotedVariables();
            LogString("Return from SwitchPromotedVariables()");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
            __BeginReturnScope("SwitchTypes", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("switchString", null, () => switchString!, (_RRCG_SETTER_VALUE) => switchString = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<IntPort>("switchInt", null, () => switchInt!, (_RRCG_SETTER_VALUE) => switchInt = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"test\"");
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("block case");
                        __Break();
                        __EndAccessibilityScope();
                    }
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"case3\"");
                    __LabelDecl("rrcg_switch_case_label_\"case2\"");
                    LogString("fallthrough");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"case4\"");
                    ExecFlow.current.Clear();
                }

                ;
                AlternativeExec rrcg_switch_section_4 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"case5\"");
                    __Return();
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(__ConditionalContext(), () => switchString, rrcg_switch_section_5, new()
                {{"test", rrcg_switch_section_0}, {"case2", rrcg_switch_section_1}, {"case3", rrcg_switch_section_1}, {"case4", rrcg_switch_section_3}, {"case5", rrcg_switch_section_4}});
                __EndAccessibilityScope();
            }

            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("block case");
                        __Break();
                        __EndAccessibilityScope();
                    }
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_3");
                    __LabelDecl("rrcg_switch_case_label_2");
                    LogString("fallthrough");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_4");
                    ExecFlow.current.Clear();
                }

                ;
                AlternativeExec rrcg_switch_section_4 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_5");
                    __Return();
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(__ConditionalContext(), () => switchInt, rrcg_switch_section_5, new()
                {{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_1}, {4, rrcg_switch_section_3}, {5, rrcg_switch_section_4}});
                __EndAccessibilityScope();
            }

            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            __BeginReturnScope("ConditionalReturn", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("switchString", null, () => switchString!, (_RRCG_SETTER_VALUE) => switchString = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<BoolPort>("condition", null, () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"0\"");
                    __If(__ConditionalContext(), () => condition, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __Break();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __EndAccessibilityScope();
                    }

                    );
                    __Return();
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"switch\"");
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        AlternativeExec rrcg_switch_section_0 = delegate
                        {
                            __LabelDecl("rrcg_switch_case_label_\"0\"");
                            __If(__ConditionalContext(), () => condition, delegate
                            {
                                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                                __Break();
                                __EndAccessibilityScope();
                            }

                            , delegate
                            {
                                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                                __EndAccessibilityScope();
                            }

                            );
                            __Return();
                        }

                        ;
                        __Switch(__ConditionalContext(), () => switchString, delegate
                        {
                        }

                        , new()
                        {{"0", rrcg_switch_section_0}});
                        __EndAccessibilityScope();
                    }

                    LogString("After Switch 2");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"while\"");
                    __While(__ConditionalContext(), () => condition, false, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            AlternativeExec rrcg_switch_section_0 = delegate
                            {
                                __LabelDecl("rrcg_switch_case_label_\"0\"");
                                LogString("While Switch Case 0");
                                __Break();
                            }

                            ;
                            AlternativeExec rrcg_switch_section_1 = delegate
                            {
                                __LabelDecl("rrcg_switch_case_label_\"return\"");
                                __Return();
                            }

                            ;
                            __Switch(__ConditionalContext(), () => switchString, delegate
                            {
                            }

                            , new()
                            {{"0", rrcg_switch_section_0}, {"return", rrcg_switch_section_1}});
                            __EndAccessibilityScope();
                        }

                        LogString("After Switch While Switch Case 0");
                        __If(__ConditionalContext(), () => condition, delegate
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            LogString("Break out of while");
                            __Break();
                            __EndAccessibilityScope();
                        }

                        , delegate
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            __If(__ConditionalContext(), () => condition, delegate
                            {
                                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                                LogString("Return");
                                __Return();
                                __EndAccessibilityScope();
                            }

                            , delegate
                            {
                                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                                __EndAccessibilityScope();
                            }

                            );
                            __EndAccessibilityScope();
                        }

                        );
                        LogString("Continue in while");
                        __EndAccessibilityScope();
                    }

                    );
                    LogString("After Switch While");
                    __Break();
                }

                ;
                __Switch(__ConditionalContext(), () => switchString, delegate
                {
                }

                , new()
                {{"0", rrcg_switch_section_0}, {"switch", rrcg_switch_section_1}, {"while", rrcg_switch_section_2}});
                __EndAccessibilityScope();
            }

            LogString("After Switch 1");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void SwitchInWhileLoop()
        {
            __BeginReturnScope("SwitchInWhileLoop", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __While(__ConditionalContext(), () => true, false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    AlternativeExec rrcg_switch_section_0 = delegate
                    {
                        __LabelDecl("rrcg_switch_case_label_5");
                        __Continue();
                    }

                    ;
                    __Switch(__ConditionalContext(), () => 5, delegate
                    {
                    }

                    , new()
                    {{5, rrcg_switch_section_0}});
                    __EndAccessibilityScope();
                }

                LogString("After switch");
                __EndAccessibilityScope();
            }

            );
            LogString("After while");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void SwitchPromotedVariables()
        {
            __BeginReturnScope("SwitchPromotedVariables", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort myLocal = default !;
                myLocal = __VariableDeclaratorExpression<IntPort>("myLocal", () => 0, () => myLocal!, (_RRCG_SETTER_VALUE) => myLocal = _RRCG_SETTER_VALUE);
                FloatPort otherLocal = default !;
                otherLocal = __VariableDeclaratorExpression<FloatPort>("otherLocal", () => 0f, () => otherLocal!, (_RRCG_SETTER_VALUE) => otherLocal = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_0");
                    myLocal += 1;
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    __If(__ConditionalContext("myLocal"), () => true, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        myLocal += 2;
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __EndAccessibilityScope();
                    }

                    );
                    myLocal += 3;
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_3");
                    myLocal += 4;
                    otherLocal = 10f;
                    __Goto("rrcg_switch_case_label_0");
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    myLocal = IntPort.MinValue;
                    __Break();
                }

                ;
                __Switch(__ConditionalContext("myLocal", "otherLocal"), () => myLocal, rrcg_switch_section_3, new()
                {{0, rrcg_switch_section_0}, {1, rrcg_switch_section_1}, {3, rrcg_switch_section_2}});
                __EndAccessibilityScope();
            }

            LogString(__StringInterpolation(myLocal, ", ", otherLocal));
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

