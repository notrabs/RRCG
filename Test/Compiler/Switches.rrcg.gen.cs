using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Switches : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            SwitchTypes("test", 22);
            LogString("Return from SwitchTypes()");
            ConditionalReturn("test", true);
            LogString("Return from ConditionalReturn()");
            SwitchInWhileLoop();
            LogString("Return from SwitchInWhileLoop()");
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            {
                __BeginLabelAccessibilityScope(true);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"test\"");
                    {
                        __BeginLabelAccessibilityScope(true);
                        LogString("block case");
                        __Break();
                        __EndLabelAccessibilityScope();
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
                    __Return(rrcg_return_flow);
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
                __EndLabelAccessibilityScope();
            }

            {
                __BeginLabelAccessibilityScope(true);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    {
                        __BeginLabelAccessibilityScope(true);
                        LogString("block case");
                        __Break();
                        __EndLabelAccessibilityScope();
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
                    __Return(rrcg_return_flow);
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
                __EndLabelAccessibilityScope();
            }

            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            {
                __BeginLabelAccessibilityScope(true);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"0\"");
                    ChipBuilder.If(condition, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        __Break();
                        __EndLabelAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        __EndLabelAccessibilityScope();
                    }

                    );
                    __Return(rrcg_return_flow);
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"switch\"");
                    {
                        __BeginLabelAccessibilityScope(true);
                        AlternativeExec rrcg_switch_section_0 = delegate
                        {
                            __LabelDecl("rrcg_switch_case_label_\"0\"");
                            ChipBuilder.If(condition, delegate
                            {
                                __BeginLabelAccessibilityScope(true);
                                __Break();
                                __EndLabelAccessibilityScope();
                            }

                            , delegate
                            {
                                __BeginLabelAccessibilityScope(true);
                                __EndLabelAccessibilityScope();
                            }

                            );
                            __Return(rrcg_return_flow);
                        }

                        ;
                        __Switch(switchString, delegate
                        {
                        }

                        , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}});
                        __EndLabelAccessibilityScope();
                    }

                    LogString("After Switch 2");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"while\"");
                    __While(condition, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        {
                            __BeginLabelAccessibilityScope(true);
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
                                __Return(rrcg_return_flow);
                            }

                            ;
                            __Switch(switchString, delegate
                            {
                            }

                            , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}, {"return", rrcg_switch_section_1}});
                            __EndLabelAccessibilityScope();
                        }

                        LogString("After Switch While Switch Case 0");
                        ChipBuilder.If(condition, delegate
                        {
                            __BeginLabelAccessibilityScope(true);
                            LogString("Break out of while");
                            __Break();
                            __EndLabelAccessibilityScope();
                        }

                        , delegate
                        {
                            __BeginLabelAccessibilityScope(true);
                            ChipBuilder.If(condition, delegate
                            {
                                __BeginLabelAccessibilityScope(true);
                                LogString("Return");
                                __Return(rrcg_return_flow);
                                __EndLabelAccessibilityScope();
                            }

                            , delegate
                            {
                                __BeginLabelAccessibilityScope(true);
                                __EndLabelAccessibilityScope();
                            }

                            );
                            __EndLabelAccessibilityScope();
                        }

                        );
                        LogString("Continue in while");
                        __EndLabelAccessibilityScope();
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
                __EndLabelAccessibilityScope();
            }

            LogString("After Switch 1");
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void SwitchInWhileLoop()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            __While(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                {
                    __BeginLabelAccessibilityScope(true);
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
                    __EndLabelAccessibilityScope();
                }

                LogString("After switch");
                __EndLabelAccessibilityScope();
            }

            );
            LogString("After while");
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

