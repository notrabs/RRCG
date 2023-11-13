using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Switches : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            SwitchTypes("test", 22);
            LogString("Return from SwitchTypes()");
            ConditionalReturn("test", true);
            LogString("Return from ConditionalReturn()");
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
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
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            {
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    ChipBuilder.If(condition, delegate
                    {
                        __Break();
                    }

                    , delegate
                    {
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
                                __Break();
                            }

                            , delegate
                            {
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
                    {
                        __BeginWhileLoop(condition);
                        {
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
                                LogString("Break out of while");
                                __Break();
                            }

                            , delegate
                            {
                                ChipBuilder.If(condition, delegate
                                {
                                    LogString("Return");
                                    __Return(rrcg_return_flow);
                                }

                                , delegate
                                {
                                }

                                );
                            }

                            );
                            LogString("Continue in while");
                        }

                        __EndWhileLoop();
                    }

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
        }
    }
}