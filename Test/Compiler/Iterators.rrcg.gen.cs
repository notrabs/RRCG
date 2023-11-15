using RRCG;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
    public class Iterators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            // Test using while loops
            WhileTest();
            // Test returning from within a while loop
            WhileReturnTest();
            // Test unreachable nodes aren't spawned
            // (this doesn't happen currently. Some day..)
            UnreachableNodesTest();
            // Test nested while loops
            NestedWhileTest();
            // Test do while loops
            DoWhileTest();
            // Test returning from within a do while loop
            DoWhileReturnTest();
            // Test nested do while loops
            NestedDoWhileTest();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void WhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("WhileTest").Definition();
            entry.Receiver();
            var list = ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10");
            var listCache = ChipLib.EventCache(list);
            __While(ChipBuilder.GreaterThan(listCache.Count, 0), delegate
            {
                ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
                ListRemoveAt(listCache, 0);
                ChipLib.Log(Concat("List now has ", ToString(listCache.Count), " items."));
                ChipLib.AwaitDelay();
            }

            );
            ChipLib.Log("While loop done!");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void WhileReturnTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("WhileReturnTest").Definition();
            entry.Receiver();
            // Test returns from while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));
            // Test returns from while block within a circuit board
            ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeat, "Hey", 7)));
            // Test returns from while block within event functions
            ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        [EventFunction]
        public StringPort StringRepeatEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatEventFunction", delegate (StringPort str, IntPort count)
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeat(str, count));
                ExecFlow.current.Merge(rrcg_return_flow);
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeat(StringPort str, IntPort count)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            var strStaging = new Variable<StringPort>();
            __While(true, delegate
            {
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
                }

                , delegate
                {
                }

                );
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void UnreachableNodesTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("UnreachableNodesTest").Definition();
            entry.Receiver();
            var index = new Variable<IntPort>();
            index.Value = 0;
            __While(ChipBuilder.LessThan(index.Value, 100), delegate
            {
                index.Value += 1;
                ChipBuilder.If(ChipBuilder.Equals(index.Value, 50), delegate
                {
                    ChipLib.Log("index.Value == 50, break!");
                    __Break();
                    PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                }

                , delegate
                {
                    ChipBuilder.If(ChipBuilder.Equals(index.Value % 5, 0), delegate
                    {
                        ChipLib.Log("index.Value % 5 == 0, continue!");
                        __Continue();
                        PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                    }

                    , delegate
                    {
                    }

                    );
                }

                );
            }

            );
            ChipLib.Log("Unreachable nodes test done!");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void NestedWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = new EventHelper("NestedWhileTest").Definition();
            ev.Receiver();
            LogString("Start");
            __While(true, delegate
            {
                __While(true, delegate
                {
                    LogString("0");
                    __Break();
                }

                );
                LogString("1");
            }

            );
            LogString("2");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DoWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = new EventHelper("DoWhileTest").Definition();
            ev.Receiver();
            __DoWhile(true, delegate
            {
                LogString("Do while loop");
                ChipBuilder.If(true, delegate
                {
                    LogString("Break");
                    __Break();
                }

                , delegate
                {
                    ChipBuilder.If(true, delegate
                    {
                        LogString("Continue");
                        __Continue();
                    }

                    , delegate
                    {
                    }

                    );
                }

                );
                LogString("Check condition");
            }

            );
            LogString("Do while loop done");
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DoWhileReturnTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("DoWhileReturnTest").Definition();
            entry.Receiver();
            // Test returns from do while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));
            // Test returns from do while block within a circuit board
            ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeatDoWhile, "Hey", 7)));
            // Test returns from do while block within event functions
            ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        [EventFunction]
        public StringPort StringRepeatDoWhileEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatDoWhileEventFunction", delegate (StringPort str, IntPort count)
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeatDoWhile(str, count));
                ExecFlow.current.Merge(rrcg_return_flow);
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeatDoWhile(StringPort str, IntPort count)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            var strStaging = new Variable<StringPort>();
            __DoWhile(true, delegate
            {
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
                }

                , delegate
                {
                }

                );
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void NestedDoWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = new EventHelper("NestedDoWhileTest").Definition();
            ev.Receiver();
            __DoWhile(true, delegate
            {
                LogString("Do while loop 1");
                ChipBuilder.If(true, delegate
                {
                    LogString("Loop 1 break");
                    __Break();
                }

                , delegate
                {
                    ChipBuilder.If(true, delegate
                    {
                        LogString("Loop 1 continue");
                        __Continue();
                    }

                    , delegate
                    {
                    }

                    );
                }

                );
                __DoWhile(true, delegate
                {
                    LogString("Do while loop 2");
                    ChipBuilder.If(true, delegate
                    {
                        LogString("Loop 2 break");
                        __Break();
                    }

                    , delegate
                    {
                        ChipBuilder.If(true, delegate
                        {
                            LogString("Loop 2 continue");
                            __Continue();
                        }

                        , delegate
                        {
                        }

                        );
                    }

                    );
                    LogString("Loop 2 check condition");
                }

                );
                LogString("Loop 2 done");
                LogString("Loop 1 check condition");
            }

            );
            LogString("Loop 1 done");
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}