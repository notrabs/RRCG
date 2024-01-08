using RRCG;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Iterators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
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
                ListPort<IntPort> list = default !;
                list = __VariableDeclaratorExpression<ListPort<IntPort>>("list", () => InlineGraph<ListPort<IntPort>>(() =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    __BeginReturnScope("ParenthesizedLambda", typeof(ListPort<IntPort>), null);
                    __Return<ListPort<IntPort>>(ChipLib.EventCache<ListPort<IntPort>>(ListCreate<IntPort>(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)));
                    dynamic __RRCG_RETURN_DATA = __EndReturnScope()!;
                    __EndAccessibilityScope();
                    return __RRCG_RETURN_DATA;
                }

                ), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            // Standard For Each form
            ForEachTest(list);
            // Manual For Each form
            ManualForEachTest(list);
            // Nested standard For Each
            NestedForEach(list);
            // Nested For Each variations
            ManualWithinStandardForEach(list);
            StandardWithinManualForEach(list);
            // Test delays mark all open iterators
            // as needing manual implementation
            TestDelaysForEach(list);
            // Test returns from for each
            ForEachReturnTest(list);
            // Test promoted variables
            ForEachPromotedTest(list);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void WhileTest()
        {
            __BeginReturnScope("WhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("WhileTest").Receiver();
                ListPort<StringPort> list = default !;
                list = __VariableDeclaratorExpression<ListPort<StringPort>>("list", () => ListCreate<StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                ListPort<StringPort> listCache = default !;
                listCache = __VariableDeclaratorExpression<ListPort<StringPort>>("listCache", () => ChipLib.EventCache<ListPort<StringPort>>(list), () => listCache!, (_RRCG_SETTER_VALUE) => listCache = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => ChipBuilder.GreaterThan(listCache.Count, 0), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
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
            __EndReturnScope();
        }

        void WhileReturnTest()
        {
            __BeginReturnScope("WhileReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition entry = default !;
                entry = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("entry", () => new EventDefinition("WhileReturnTest"), () => entry!, (_RRCG_SETTER_VALUE) => entry = _RRCG_SETTER_VALUE);
            entry.Receiver();
            // Test returns from while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));
            // Test returns from while block within a circuit board
            ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeat, "Hey", 7)));
            // Test returns from while block within event functions
            ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        public StringPort StringRepeatEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginReturnScope("StringRepeatEventFunction", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<StringPort>(StringRepeat(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        public StringPort StringRepeat(StringPort str, IntPort count)
        {
            __BeginReturnScope("StringRepeat", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.Variable<StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), () => strStaging!, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => true, false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(__ConditionalContext(), () => ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<StringPort>(strStaging.Value);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void UnreachableNodesTest()
        {
            __BeginReturnScope("UnreachableNodesTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("UnreachableNodesTest").Receiver();
                RRCGBuild.Variable<IntPort> index = default !;
                index = __VariableDeclaratorExpression<RRCGBuild.Variable<IntPort>>("index", () => new Variable<IntPort>(), () => index!, (_RRCG_SETTER_VALUE) => index = _RRCG_SETTER_VALUE);
            index.Value = 0;
            __While(__ConditionalContext(), () => ChipBuilder.LessThan(index.Value, 100), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                index.Value += 1;
                __If(__ConditionalContext(), () => ChipBuilder.Equals(index.Value, 50), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    ChipLib.Log("index.Value == 50, break!");
                    __Break();
                    PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(index.Value % 5, 0), delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        ChipLib.Log("index.Value % 5 == 0, continue!");
                        __Continue();
                        PlayerShowSubtitle(PlayerPort.Local, "This node is unreachable and should not be placed.", 0, 0);
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
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
            __EndReturnScope();
        }

        void NestedWhileTest()
        {
            __BeginReturnScope("NestedWhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NestedWhileTest").Receiver();
            LogString("Start");
            __While(__ConditionalContext(), () => true, false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __While(__ConditionalContext(), () => true, false, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
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
            __EndReturnScope();
        }

        void DoWhileTest()
        {
            __BeginReturnScope("DoWhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("DoWhileTest").Receiver();
            __While(__ConditionalContext(), () => true, true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Do while loop");
                __If(__ConditionalContext(), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString("Break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __If(__ConditionalContext(), () => true, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("Continue");
                        __Continue();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
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
            __EndReturnScope();
        }

        void DoWhileReturnTest()
        {
            __BeginReturnScope("DoWhileReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("DoWhileReturnTest").Receiver();
            // Test returns from do while block within an "inline" graph (functions are transparent)
            ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));
            // Test returns from do while block within a circuit board
            ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<StringPort, IntPort, StringPort>(StringRepeatDoWhile, "Hey", 7)));
            // Test returns from do while block within event functions
            ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        public StringPort StringRepeatDoWhileEventFunction(StringPort str, IntPort count)
        {
            return __DispatchEventFunction<StringPort, StringPort, IntPort>("StringRepeatDoWhileEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginReturnScope("StringRepeatDoWhileEventFunction", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<StringPort>(StringRepeatDoWhile(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        public StringPort StringRepeatDoWhile(StringPort str, IntPort count)
        {
            __BeginReturnScope("StringRepeatDoWhile", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.Variable<StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("strStaging", () => new Variable<StringPort>(), () => strStaging!, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => true, true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(__ConditionalContext(), () => ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<StringPort>(strStaging.Value);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void NestedDoWhileTest()
        {
            __BeginReturnScope("NestedDoWhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NestedDoWhileTest").Receiver();
            __While(__ConditionalContext(), () => true, true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString("Do while loop 1");
                __If(__ConditionalContext(), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString("Loop 1 break");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __If(__ConditionalContext(), () => true, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("Loop 1 continue");
                        __Continue();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __EndAccessibilityScope();
                    }

                    );
                    __EndAccessibilityScope();
                }

                );
                __While(__ConditionalContext(), () => true, true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString("Do while loop 2");
                    __If(__ConditionalContext(), () => true, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("Loop 2 break");
                        __Break();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __If(__ConditionalContext(), () => true, delegate
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            LogString("Loop 2 continue");
                            __Continue();
                            __EndAccessibilityScope();
                        }

                        , delegate
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
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
            __EndReturnScope();
        }

        void ForEachTest(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ForEachTest").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item));
                __EndAccessibilityScope();
            }

            );
            LogString("For each done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualForEachTest(ListPort<IntPort> list)
        {
            __BeginReturnScope("ManualForEachTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ManualForEachTest").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item));
                __If(__ConditionalContext(), () => ChipBuilder.Equals(item, 5), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            LogString("Manual for each done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void NestedForEach(ListPort<IntPort> list)
        {
            __BeginReturnScope("NestedForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NestedForEach").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("Nested for each done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualWithinStandardForEach(ListPort<IntPort> list)
        {
            __BeginReturnScope("ManualWithinStandardForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ManualWithinStandardForEach").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(item2, 5), delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __Break();
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __EndAccessibilityScope();
                    }

                    );
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("Nested for each (manual within standard) done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void StandardWithinManualForEach(ListPort<IntPort> list)
        {
            __BeginReturnScope("StandardWithinManualForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("StandardWithinManualForEach").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __If(__ConditionalContext(), () => ChipBuilder.Equals(item, 5), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("Nested for each (standard within manual) done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestDelaysForEach(ListPort<IntPort> list)
        {
            __BeginReturnScope("TestDelaysForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TestDelaysForEach").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("Between loops");
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    ChipLib.AwaitDelay();
                    LogString("After delay, final exec flow contains this node's output port");
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("All done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        public IntPort ForEachReturnEventFunction(ListPort<IntPort> list)
        {
            return __DispatchEventFunction<IntPort, ListPort<IntPort>>("ForEachReturnEventFunction", delegate (ListPort<IntPort> list)
            {
                __BeginReturnScope("ForEachReturnEventFunction", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<IntPort>(ForEachReturnImpl(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        public IntPort ForEachReturnImpl(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachReturnImpl", typeof(IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item));
                __If(__ConditionalContext(), () => ChipBuilder.Equals(item, 5), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<IntPort>(item);
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                __EndAccessibilityScope();
            }

            );
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void ForEachReturnTest(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition entry = default !;
                entry = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("entry", () => new EventDefinition("ForEachReturnTest"), () => entry!, (_RRCG_SETTER_VALUE) => entry = _RRCG_SETTER_VALUE);
            entry.Receiver();
            // Test returns from while block within an "inline" graph (functions are transparent)
            ChipLib.Log(__StringInterpolation("Result (inline graph): ", ForEachReturnImpl(list)));
                IntPort result = default !;
                result = __VariableDeclaratorExpression<IntPort>("result", () => CircuitBoard<ListPort<IntPort>, IntPort>(ForEachReturnImpl, list), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Result (circuit board): ", result));
            // Test returns from while block within event functions
            ChipLib.Log(__StringInterpolation("Result (event function): ", ForEachReturnEventFunction(list)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ForEachPromotedTest(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachPromotedTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ForEachPromotedTest").Receiver();
                IntPort i = default !;
                i = __VariableDeclaratorExpression<IntPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
            __ForEach(__ConditionalContext("i"), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item, ", index: ", i));
                i += 1;
                __EndAccessibilityScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

