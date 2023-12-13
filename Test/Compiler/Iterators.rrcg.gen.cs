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
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
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
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void WhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("WhileTest").Receiver();
            ListPort<StringPort> list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"), (rrcg_setter_value) => list = rrcg_setter_value);
            ListPort<StringPort> listCache = __VariableDeclaratorExpression<ListPort<StringPort>>("listCache", () => ChipLib.EventCache<ListPort<StringPort>>(list), (rrcg_setter_value) => listCache = rrcg_setter_value);
            __While(ChipBuilder.GreaterThan(listCache.Count, 0), delegate
            {
                __BeginAccessibilityScope(true);
                ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
                ListRemoveAt<StringPort>(listCache, 0);
                ChipLib.Log(Concat("List now has ", ToString<IntPort>(listCache.Count), " items."));
                ChipLib.AwaitDelay();
                __EndAccessibilityScope();
            }

            );
            ChipLib.Log("While loop done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void WhileReturnTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            RRCGBuild.EventDefinition entry = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("entry", () => new EventDefinition("WhileReturnTest"), (rrcg_setter_value) => entry = rrcg_setter_value);
            entry.Receiver();
            // Test returns from while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));
            // Test returns from while block within a circuit board
            ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeat, "Hey", 7)));
            // Test returns from while block within event functions
            ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        [EventFunction]
        public StringPort StringRepeatEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatEventFunction", delegate (StringPort str, IntPort count)
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __BeginAccessibilityScope(false);
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeat(str, count));
                __EndAccessibilityScope();
                ExecFlow.current.Merge(rrcg_return_flow);
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeat(StringPort str, IntPort count)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginAccessibilityScope(false);
            RRCGBuild.Variable<StringPort> strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), (rrcg_setter_value) => strStaging = rrcg_setter_value);
            __While(true, delegate
            {
                __BeginAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(true);
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void UnreachableNodesTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("UnreachableNodesTest").Receiver();
            RRCGBuild.Variable<IntPort> index = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("index", () => new Variable<IntPort>(), (rrcg_setter_value) => index = rrcg_setter_value);
            index.Value = 0;
            __While(ChipBuilder.LessThan(index.Value, 100), delegate
            {
                __BeginAccessibilityScope(true);
                index.Value += 1;
                ChipBuilder.If(ChipBuilder.Equals(index.Value, 50), delegate
                {
                    __BeginAccessibilityScope(true);
                    ChipLib.Log("index.Value == 50, break!");
                    __Break();
                    PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    ChipBuilder.If(ChipBuilder.Equals(index.Value % 5, 0), delegate
                    {
                        __BeginAccessibilityScope(true);
                        ChipLib.Log("index.Value % 5 == 0, continue!");
                        __Continue();
                        PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(true);
                        __EndAccessibilityScope();
                    }

                    );
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            ChipLib.Log("Unreachable nodes test done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void NestedWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("NestedWhileTest").Receiver();
            LogString("Start");
            __While(true, delegate
            {
                __BeginAccessibilityScope(true);
                __While(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("0");
                    __Break();
                    __EndAccessibilityScope();
                }

                );
                LogString("1");
                __EndAccessibilityScope();
            }

            );
            LogString("2");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DoWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("DoWhileTest").Receiver();
            __DoWhile(true, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("Do while loop");
                ChipBuilder.If(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("Break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    ChipBuilder.If(true, delegate
                    {
                        __BeginAccessibilityScope(true);
                        LogString("Continue");
                        __Continue();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(true);
                        __EndAccessibilityScope();
                    }

                    );
                    __EndAccessibilityScope();
                }

                );
                LogString("Check condition");
                __EndAccessibilityScope();
            }

            );
            LogString("Do while loop done");
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DoWhileReturnTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("DoWhileReturnTest").Receiver();
            // Test returns from do while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));
            // Test returns from do while block within a circuit board
            ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeatDoWhile, "Hey", 7)));
            // Test returns from do while block within event functions
            ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        [EventFunction]
        public StringPort StringRepeatDoWhileEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatDoWhileEventFunction", delegate (StringPort str, IntPort count)
            {
                ExecFlow rrcg_return_flow = new ExecFlow();
                dynamic rrcg_return_data = default;
                __BeginAccessibilityScope(false);
                __Return(rrcg_return_flow, out rrcg_return_data, StringRepeatDoWhile(str, count));
                __EndAccessibilityScope();
                ExecFlow.current.Merge(rrcg_return_flow);
                return rrcg_return_data;
            }

            , str, count);
        }

        public StringPort StringRepeatDoWhile(StringPort str, IntPort count)
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __BeginAccessibilityScope(false);
            RRCGBuild.Variable<StringPort> strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), (rrcg_setter_value) => strStaging = rrcg_setter_value);
            __DoWhile(true, delegate
            {
                __BeginAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                ChipBuilder.If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(true);
                    __Return(rrcg_return_flow, out rrcg_return_data, strStaging.Value);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        void NestedDoWhileTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("NestedDoWhileTest").Receiver();
            __DoWhile(true, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("Do while loop 1");
                ChipBuilder.If(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("Loop 1 break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    ChipBuilder.If(true, delegate
                    {
                        __BeginAccessibilityScope(true);
                        LogString("Loop 1 continue");
                        __Continue();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(true);
                        __EndAccessibilityScope();
                    }

                    );
                    __EndAccessibilityScope();
                }

                );
                __DoWhile(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("Do while loop 2");
                    ChipBuilder.If(true, delegate
                    {
                        __BeginAccessibilityScope(true);
                        LogString("Loop 2 break");
                        __Break();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(true);
                        ChipBuilder.If(true, delegate
                        {
                            __BeginAccessibilityScope(true);
                            LogString("Loop 2 continue");
                            __Continue();
                            __EndAccessibilityScope();
                        }

                        , delegate
                        {
                            __BeginAccessibilityScope(true);
                            __EndAccessibilityScope();
                        }

                        );
                        __EndAccessibilityScope();
                    }

                    );
                    LogString("Loop 2 check condition");
                    __EndAccessibilityScope();
                }

                );
                LogString("Loop 2 done");
                LogString("Loop 1 check condition");
                __EndAccessibilityScope();
            }

            );
            LogString("Loop 1 done");
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

