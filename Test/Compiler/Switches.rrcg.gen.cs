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
            __Switch(switchString, delegate
            {
                LogString("default");
                __Break();
            }

            , new Dictionary<AnyPort, AlternativeExec>{{"test", delegate
            {
                {
                    LogString("block case");
                    __Break();
                }
            }
            }, {"case2", delegate
            {
                LogString("fallthrough");
                __Break();
            }
            }, {"case3", delegate
            {
                LogString("fallthrough");
                __Break();
            }
            }, {"case4", delegate
            {
                ExecFlow.current.Clear();
            }
            }, {"case5", delegate
            {
                __Return(rrcg_return_flow);
            }
            }});
            __Switch(switchInt, delegate
            {
                LogString("default");
                __Break();
            }

            , new Dictionary<AnyPort, AlternativeExec>{{1, delegate
            {
                {
                    LogString("block case");
                    __Break();
                }
            }
            }, {2, delegate
            {
                LogString("fallthrough");
                __Break();
            }
            }, {3, delegate
            {
                LogString("fallthrough");
                __Break();
            }
            }, {4, delegate
            {
                ExecFlow.current.Clear();
            }
            }, {5, delegate
            {
                __Return(rrcg_return_flow);
            }
            }});
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void ConditionalReturn(StringPort switchString, BoolPort condition)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __Switch(switchString, delegate
            {
            }

            , new Dictionary<AnyPort, AlternativeExec>{{"0", delegate
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
            }, {"switch", delegate
            {
                __Switch(switchString, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{"0", delegate
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
                }});
                LogString("After Switch 2");
                __Break();
            }
            }, {"while", delegate
            {
                {
                    __BeginWhileLoop(condition);
                    {
                        __Switch(switchString, delegate
                        {
                        }

                        , new Dictionary<AnyPort, AlternativeExec>{{"0", delegate
                        {
                            LogString("While Switch Case 0");
                            __Break();
                        }
                        }, {"return", delegate
                        {
                            __Return(rrcg_return_flow);
                        }
                        }});
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
            }});
            LogString("After Switch 1");
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}