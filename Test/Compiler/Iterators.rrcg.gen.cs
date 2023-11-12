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
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void WhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = new EventHelper("WhileTest").Definition();
            entry.Receiver();
            var list = ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10");
            var listCache = ChipLib.EventCache(list);
            {
                __BeginWhileLoop(ChipBuilder.GreaterThan(listCache.Count, 0));
                {
                    ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
                    ListRemoveAt(listCache, 0);
                    ChipLib.Log(Concat("List now has ", ToString(listCache.Count), " items."));
                    ChipLib.AwaitDelay();
                }

                __EndWhileLoop();
            }

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
            {
                __BeginWhileLoop(true);
                {
                    strStaging.Value = Concat(strStaging.Value, str);
                    ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, ChipBuilder.Multiply(str.Length, count)), delegate
                    {
                        __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
                    }

                    , delegate
                    {
                    }

                    );
                }

                __EndWhileLoop();
            }

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
            {
                __BeginWhileLoop(ChipBuilder.LessThan(index.Value, 100));
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
                        ChipBuilder.If(ChipBuilder.Equals(ChipBuilder.Modulo(index.Value, 5), 0), delegate
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

                __EndWhileLoop();
            }

            ChipLib.Log("Unreachable nodes test done!");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void NestedWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            LogString("Start");
            {
                __BeginWhileLoop(true);
                {
                    {
                        __BeginWhileLoop(true);
                        {
                            LogString("0");
                            __Break();
                        }

                        __EndWhileLoop();
                    }

                    LogString("1");
                }

                __EndWhileLoop();
            }

            LogString("2");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}