using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Switches : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            SwitchTypes("test", 22);
            LogString("Return from SwitchTypes()");
            ConditionalReturn("test", true);
            LogString("Return from ConditionalReturn()");
            SwitchInWhileLoop();
            LogString("Return from SwitchInWhileLoop()");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
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
                    __Return(null);
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(switchString, rrcg_switch_section_5, new Dictionary<AnyPort, AlternativeExec>{{"test", rrcg_switch_section_0}, {"case2", rrcg_switch_section_1}, {"case3", rrcg_switch_section_1}, {"case4", rrcg_switch_section_3}, {"case5", rrcg_switch_section_4}});
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
                    __Return(null);
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_default");
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(switchInt, rrcg_switch_section_5, new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_1}, {4, rrcg_switch_section_3}, {5, rrcg_switch_section_4}});
                __EndAccessibilityScope();
            }

            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            __BeginReturnScope(null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
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
                    __Return(null);
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
                            __Return(null);
                        }

                        ;
                        __Switch(switchString, delegate
                        {
                        }

                        , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}});
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
                                __Return(null);
                            }

                            ;
                            __Switch(switchString, delegate
                            {
                            }

                            , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}, {"return", rrcg_switch_section_1}});
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
                                __Return(null);
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
                __Switch(switchString, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}, {"switch", rrcg_switch_section_1}, {"while", rrcg_switch_section_2}});
                __EndAccessibilityScope();
            }

            LogString("After Switch 1");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void SwitchInWhileLoop()
        {
            __BeginReturnScope(null);
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
                    __Switch(5, delegate
                    {
                    }

                    , new Dictionary<AnyPort, AlternativeExec>{{5, rrcg_switch_section_0}});
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
    }
}
#pragma warning restore CS0162 // Unreachable code detected

