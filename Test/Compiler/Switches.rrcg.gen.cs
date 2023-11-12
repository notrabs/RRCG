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
            LogString("Return from SwitchTypes");
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void SwitchTypes(StringPort switchString, IntPort switchInt)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __Switch(switchString, delegate
            {
                LogString("default");
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
            }

            , new Dictionary<AnyPort, AlternativeExec>{{"test", delegate
            {
                {
                    LogString("block case");
                    {
                        __Break();
                        return; // Avoid spawning unreachable nodes
                    }
                }
            }
            }, {"case2", delegate
            {
                LogString("fallthrough");
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
            }
            }, {"case3", delegate
            {
                LogString("fallthrough");
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
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
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
            }

            , new Dictionary<AnyPort, AlternativeExec>{{1, delegate
            {
                {
                    LogString("block case");
                    {
                        __Break();
                        return; // Avoid spawning unreachable nodes
                    }
                }
            }
            }, {2, delegate
            {
                LogString("fallthrough");
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
            }
            }, {3, delegate
            {
                LogString("fallthrough");
                {
                    __Break();
                    return; // Avoid spawning unreachable nodes
                }
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
    }
}