using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Switches : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            SwitchTypes("test", 22);
            LogString("Return from SwitchTypes()");
            ConditionalReturn("test", true);
            LogString("Return from ConditionalReturn()");
            SwitchInWhileLoop();
            LogString("Return from SwitchInWhileLoop()");
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            {
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    {
                        LogString("block case");
                        __Break();
                    }
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    LogString("fallthrough");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    ExecFlow.current.Clear();
                }

                ;
                AlternativeExec rrcg_switch_section_4 = delegate
                {
                    __Return(rrcg_return_flow);
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(switchString, rrcg_switch_section_5, new Dictionary<AnyPort, AlternativeExec>{{"test", rrcg_switch_section_0}, {"case2", rrcg_switch_section_1}, {"case3", rrcg_switch_section_1}, {"case4", rrcg_switch_section_3}, {"case5", rrcg_switch_section_4}});
            }

            {
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    {
                        LogString("block case");
                        __Break();
                    }
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    LogString("fallthrough");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_3 = delegate
                {
                    ExecFlow.current.Clear();
                }

                ;
                AlternativeExec rrcg_switch_section_4 = delegate
                {
                    __Return(rrcg_return_flow);
                }

                ;
                AlternativeExec rrcg_switch_section_5 = delegate
                {
                    LogString("default");
                    __Break();
                }

                ;
                __Switch(switchInt, rrcg_switch_section_5, new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_1}, {4, rrcg_switch_section_3}, {5, rrcg_switch_section_4}});
            }

            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            {
                AlternativeExec rrcg_switch_section_0 = delegate
                {
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
                    {
                        AlternativeExec rrcg_switch_section_0 = delegate
                        {
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
                    }

                    LogString("After Switch 2");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __While(condition, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        {
                            AlternativeExec rrcg_switch_section_0 = delegate
                            {
                                LogString("While Switch Case 0");
                                __Break();
                            }

                            ;
                            AlternativeExec rrcg_switch_section_1 = delegate
                            {
                                __Return(rrcg_return_flow);
                            }

                            ;
                            __Switch(switchString, delegate
                            {
                            }

                            , new Dictionary<AnyPort, AlternativeExec>{{"0", rrcg_switch_section_0}, {"return", rrcg_switch_section_1}});
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
            }

            LogString("After Switch 1");
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void SwitchInWhileLoop()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            __While(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                {
                    AlternativeExec rrcg_switch_section_0 = delegate
                    {
                        __Continue();
                    }

                    ;
                    __Switch(5, delegate
                    {
                    }

                    , new Dictionary<AnyPort, AlternativeExec>{{5, rrcg_switch_section_0}});
                }

                LogString("After switch");
                __EndLabelAccessibilityScope();
            }

            );
            LogString("After while");
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

