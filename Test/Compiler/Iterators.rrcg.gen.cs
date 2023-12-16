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
                ListPort<StringPort> list = default !;
                list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"), () => list, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                ListPort<StringPort> listCache = default !;
                listCache = __VariableDeclaratorExpression<ListPort<StringPort>>("listCache", () => ChipLib.EventCache<ListPort<StringPort>>(list), () => listCache, (_RRCG_SETTER_VALUE) => listCache = _RRCG_SETTER_VALUE);
            __While(() => ChipBuilder.GreaterThan(listCache.Count, 0), delegate
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
                RRCGBuild.EventDefinition entry = default !;
                entry = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("entry", () => new EventDefinition("WhileReturnTest"), () => entry, (_RRCG_SETTER_VALUE) => entry = _RRCG_SETTER_VALUE);
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
                RRCGBuild.Variable<StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), () => strStaging, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __While(() => true, delegate
            {
                __BeginAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
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
                RRCGBuild.Variable<IntPort> index = default !;
                index = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("index", () => new Variable<IntPort>(), () => index, (_RRCG_SETTER_VALUE) => index = _RRCG_SETTER_VALUE);
            index.Value = 0;
            __While(() => ChipBuilder.LessThan(index.Value, 100), delegate
            {
                __BeginAccessibilityScope(true);
                index.Value += 1;
                __If(ChipBuilder.Equals(index.Value, 50), delegate
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
                    __If(ChipBuilder.Equals(index.Value % 5, 0), delegate
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
            __While(() => true, delegate
            {
                __BeginAccessibilityScope(true);
                __While(() => true, delegate
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
                __If(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("Break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    __If(true, delegate
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
                RRCGBuild.Variable<StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), () => strStaging, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __DoWhile(true, delegate
            {
                __BeginAccessibilityScope(true);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
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
                __If(true, delegate
                {
                    __BeginAccessibilityScope(true);
                    LogString("Loop 1 break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(true);
                    __If(true, delegate
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
                    __If(true, delegate
                    {
                        __BeginAccessibilityScope(true);
                        LogString("Loop 2 break");
                        __Break();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(true);
                        __If(true, delegate
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

