using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Iterators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
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
            __EndLabelAccessibilityScope();
        }

        void WhileTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = __VariableDeclaratorExpression("entry", () => new EventHelper("WhileTest").Definition());
            entry.Receiver();
            var list = __VariableDeclaratorExpression("list", () => ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"));
            var listCache = __VariableDeclaratorExpression("listCache", () => ChipLib.EventCache(list));
            __While(ChipBuilder.GreaterThan(listCache.Count, 0), delegate
            {
                __BeginLabelAccessibilityScope(true);
                ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
                ListRemoveAt(listCache, 0);
                ChipLib.Log(Concat("List now has ", ToString(listCache.Count), " items."));
                ChipLib.AwaitDelay();
                __EndLabelAccessibilityScope();
            }

            );
            ChipLib.Log("While loop done!");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void WhileReturnTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = __VariableDeclaratorExpression("entry", () => new EventHelper("WhileReturnTest").Definition());
            entry.Receiver();
            // Test returns from while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));
            // Test returns from while block within a circuit board
            ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeat, "Hey", 7)));
            // Test returns from while block within event functions
            ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        [EventFunction]
        public StringPort StringRepeatEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginLabelAccessibilityScope(false);
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeat(str, count));
                ExecFlow.current.Merge(rrcg_return_flow);
                __EndLabelAccessibilityScope();
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeat(StringPort str, IntPort count)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            var strStaging = __VariableDeclaratorExpression("strStaging", () => new Variable<StringPort>());
            __While(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
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
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
            return rrcg_return_data;
        }

        void UnreachableNodesTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = __VariableDeclaratorExpression("entry", () => new EventHelper("UnreachableNodesTest").Definition());
            entry.Receiver();
            var index = __VariableDeclaratorExpression("index", () => new Variable<IntPort>());
            index.Value = 0;
            __While(ChipBuilder.LessThan(index.Value, 100), delegate
            {
                __BeginLabelAccessibilityScope(true);
                index.Value += 1;
                ChipBuilder.If(ChipBuilder.Equals(index.Value, 50), delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    ChipLib.Log("index.Value == 50, break!");
                    __Break();
                    PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                    __EndLabelAccessibilityScope();
                }

                , delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    ChipBuilder.If(ChipBuilder.Equals(index.Value % 5, 0), delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        ChipLib.Log("index.Value % 5 == 0, continue!");
                        __Continue();
                        PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
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
                __EndLabelAccessibilityScope();
            }

            );
            ChipLib.Log("Unreachable nodes test done!");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void NestedWhileTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = __VariableDeclaratorExpression("ev", () => new EventHelper("NestedWhileTest").Definition());
            ev.Receiver();
            LogString("Start");
            __While(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                __While(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    LogString("0");
                    __Break();
                    __EndLabelAccessibilityScope();
                }

                );
                LogString("1");
                __EndLabelAccessibilityScope();
            }

            );
            LogString("2");
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void DoWhileTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = __VariableDeclaratorExpression("ev", () => new EventHelper("DoWhileTest").Definition());
            ev.Receiver();
            __DoWhile(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                LogString("Do while loop");
                ChipBuilder.If(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    LogString("Break");
                    __Break();
                    __EndLabelAccessibilityScope();
                }

                , delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    ChipBuilder.If(true, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        LogString("Continue");
                        __Continue();
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
                LogString("Check condition");
                __EndLabelAccessibilityScope();
            }

            );
            LogString("Do while loop done");
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        void DoWhileReturnTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var entry = __VariableDeclaratorExpression("entry", () => new EventHelper("DoWhileReturnTest").Definition());
            entry.Receiver();
            // Test returns from do while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));
            // Test returns from do while block within a circuit board
            ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeatDoWhile, "Hey", 7)));
            // Test returns from do while block within event functions
            ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        [EventFunction]
        public StringPort StringRepeatDoWhileEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatDoWhileEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginLabelAccessibilityScope(false);
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeatDoWhile(str, count));
                ExecFlow.current.Merge(rrcg_return_flow);
                __EndLabelAccessibilityScope();
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeatDoWhile(StringPort str, IntPort count)
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            var strStaging = __VariableDeclaratorExpression("strStaging", () => new Variable<StringPort>());
            __DoWhile(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
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
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
            return rrcg_return_data;
        }

        void NestedDoWhileTest()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var ev = __VariableDeclaratorExpression("ev", () => new EventHelper("NestedDoWhileTest").Definition());
            ev.Receiver();
            __DoWhile(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                LogString("Do while loop 1");
                ChipBuilder.If(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    LogString("Loop 1 break");
                    __Break();
                    __EndLabelAccessibilityScope();
                }

                , delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    ChipBuilder.If(true, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        LogString("Loop 1 continue");
                        __Continue();
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
                __DoWhile(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    LogString("Do while loop 2");
                    ChipBuilder.If(true, delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        LogString("Loop 2 break");
                        __Break();
                        __EndLabelAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginLabelAccessibilityScope(true);
                        ChipBuilder.If(true, delegate
                        {
                            __BeginLabelAccessibilityScope(true);
                            LogString("Loop 2 continue");
                            __Continue();
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
                    LogString("Loop 2 check condition");
                    __EndLabelAccessibilityScope();
                }

                );
                LogString("Loop 2 done");
                LogString("Loop 1 check condition");
                __EndLabelAccessibilityScope();
            }

            );
            LogString("Loop 1 done");
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

