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
            // WHILE TEST:
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
                    __BeginReturnScope("ParenthesizedLambda", typeof(ListPort<IntPort>), null);
                    __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    __Return<ListPort<IntPort>>(ChipLib.EventCache<ListPort<IntPort>>(ListCreate<IntPort>(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)));
                    __EndAccessibilityScope();
                    return __EndReturnScope()!;
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
            // FOR LOOPS TEST:
            // - Standard forms
            ForLoopTest();
            // - Manual form
            ManualForLoopTest();
            // - Optimized -> manual conversions
            //   (ensure we do this correctly in all cases)
            OptimizedToManualForLoopConversionsTest();
            // - Nested standard
            NestedForLoopTest();
            // - Nested variations
            ManualWithinStandardForLoopTest();
            StandardWithinManualForLoopTest();
            // - Test promoted (& multiple variables in the For declaration)
            PromotedVariablesForLoopTest();
            // - Test returns
            ForLoopReturnTest();
            // - Test unconventional for loops
            UnconventionalForLoopsTest();
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
        StringPort StringRepeatEventFunction(StringPort str, IntPort count)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, StringPort, IntPort>(this, "StringRepeatEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginReturnScope("StringRepeatEventFunction", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                __Return<StringPort>(StringRepeat(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        StringPort StringRepeat(StringPort str, IntPort count)
        {
            __BeginReturnScope("StringRepeat", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
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
        StringPort StringRepeatDoWhileEventFunction(StringPort str, IntPort count)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<StringPort, StringPort, IntPort>(this, "StringRepeatDoWhileEventFunction", delegate (StringPort str, IntPort count)
            {
                __BeginReturnScope("StringRepeatDoWhileEventFunction", typeof(StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                __Return<StringPort>(StringRepeatDoWhile(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        StringPort StringRepeatDoWhile(StringPort str, IntPort count)
        {
            __BeginReturnScope("StringRepeatDoWhile", typeof(StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
        IntPort ForEachReturnEventFunction(ListPort<IntPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort, ListPort<IntPort>>(this, "ForEachReturnEventFunction", delegate (ListPort<IntPort> list)
            {
                __BeginReturnScope("ForEachReturnEventFunction", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<IntPort>(ForEachReturnImpl(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        IntPort ForEachReturnImpl(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachReturnImpl", typeof(IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new EventDefinition("ForEachReturnTest").Receiver();
            // Test returns from For Each within an "inline" graph (functions are transparent)
            ChipLib.Log(__StringInterpolation("Result (inline graph): ", ForEachReturnImpl(list)));
                IntPort result = default !;
                result = __VariableDeclaratorExpression<IntPort>("result", () => CircuitBoard<ListPort<IntPort>, IntPort>(ForEachReturnImpl, list), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Result (circuit board): ", result));
            // Test returns from For Each within event functions
            ChipLib.Log(__StringInterpolation("Result (event function): ", ForEachReturnEventFunction(list)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ForEachPromotedTest(ListPort<IntPort> list)
        {
            __BeginReturnScope("ForEachPromotedTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<ListPort<IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
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
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ForLoopTest()
        {
            __BeginReturnScope("ForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ForLoopTest").Receiver();
            LogString("Testing standard form, positive iteration:");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Testing standard form, positive iteration (with 'var' index declaration):");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            // TODO: The negative iteration worked fine for positive numbers,
            //       but breaks on negative numbers. Whoops.. is it possible to
            //       come up with a solution that works for both?
            /*LogString("Testing standard form, negative iteration (data ports):");

        // The For node does not support negative iteration.
        // But, we can augment this functionality onto it.

        // At rewriting time, depending on the condition of the loop,
        // we determine the iteration direction, and what values are
        // the minimum and maximum. So this should iterate upward,
        // but use a Subtract chip to correct the index.
        for (int i = 10; i > 0; i--)
            LogString($"i: {i}");

        LogString("Testing standard form, negative iteration (real ports):");

        // When we apply the correction for the negative iteration,
        // we want it to be as efficient as possible. With a pure-data
        // max value, we can insert it directly into the Subtract chip.
        // But if it's a real port, we cache it in an efficient Random store
        // first, to ensure each access of the index is nice and cheap.

        var minPort = Reroute(0);
        var maxPort = Reroute(10);
        for (int i = maxPort; i > minPort; i--)
            LogString($"i: {i}");*/
            LogString("All done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualForLoopTest()
        {
            __BeginReturnScope("ManualForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ManualForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(i, 5), delegate
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

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("For loop done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void OptimizedToManualForLoopConversionsTest()
        {
            __BeginReturnScope("OptimizedToManualForLoopConversionsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("OptimizedToManualForLoopConversions").Receiver();
            // At rewriting time, we make a best-effort guess about whether or not
            // a particular For statement can be optimized into using the For node.
            //
            // However, at build time, this guess may be proven wrong through a
            // number of ways (iterators using Delays in their chain, breaks, etc).
            //
            // If this occurs, we need to go back and splice-in a manual iterator
            // which can be a bit of a convoluted process, especially with the
            // flexibility of For loops.
            // So we need to make sure we get it right!
            LogString("Testing positive iteration (data ports):");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Testing positive iteration (real ports):");
                IntPort min = default !;
                min = __VariableDeclaratorExpression<IntPort>("min", () => Reroute<IntPort>(0), () => min!, (_RRCG_SETTER_VALUE) => min = _RRCG_SETTER_VALUE);
                IntPort max = default !;
                max = __VariableDeclaratorExpression<IntPort>("max", () => Reroute<IntPort>(10), () => max!, (_RRCG_SETTER_VALUE) => max = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, min, max, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            /*LogString("Testing negative iteration (data ports):");

        // For negative iterators using data ports, all we need to do
        // is splice out the For node & the subtract node, and rather than
        // checking if the index is less than a value, we check if it's greater.
        for (int i = 10; i > 0; i--)
        {
            LogString($"i: {i}");
            ChipLib.AwaitDelay();
        }

        LogString("Testing negative iteration (real ports):");

        // For negative iterators using real ports, we again have a problem.
        // We again have to cache the end value to preserve semantics & efficiency.
        // This should look exactly like the positive iterator/real port case, except
        // the value being cached should be the minimum value.
        for (int i = max; i > min; i--)
        {
            LogString($"i: {i}");
            ChipLib.AwaitDelay();
        }*/
            LogString("All done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void NestedForLoopTest()
        {
            __BeginReturnScope("NestedForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NestedForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), true, 0, 10, (outer) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("outer: ", outer));
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __OptimizedFor(__ConditionalContext("inner"), true, 0, 10, (inner) =>
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            LogString(__StringInterpolation("inner: ", inner));
                            __EndAccessibilityScope();
                        }

                        , () =>
                        {
                        }

                        );
                        __EndAccessibilityScope();
                    }

                    LogString("Inner done");
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Outer done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualWithinStandardForLoopTest()
        {
            __BeginReturnScope("ManualWithinStandardForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ManualWithinStandardForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), true, 0, 10, (outer) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("outer: ", outer));
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __OptimizedFor(__ConditionalContext("inner"), true, 0, 10, (inner) =>
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            LogString(__StringInterpolation("inner: ", inner));
                            __If(__ConditionalContext(), () => ChipBuilder.Equals(inner, 5), delegate
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

                        , () =>
                        {
                        }

                        );
                        __EndAccessibilityScope();
                    }

                    LogString("Inner done");
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Outer done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void StandardWithinManualForLoopTest()
        {
            __BeginReturnScope("StandardWithinManualForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("StandardWithinManualForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), true, 0, 10, (outer) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("outer: ", outer));
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(outer, 5), delegate
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
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __OptimizedFor(__ConditionalContext("inner"), true, 0, 10, (inner) =>
                        {
                            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                            LogString(__StringInterpolation("inner: ", inner));
                            __EndAccessibilityScope();
                        }

                        , () =>
                        {
                        }

                        );
                        __EndAccessibilityScope();
                    }

                    LogString("Inner done");
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Outer done");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void PromotedVariablesForLoopTest()
        {
            __BeginReturnScope("PromotedVariablesForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("PromotedVariablesForLoopTest").Receiver();
            LogString("Testing variable promotions with actual locals");
                FloatPort promotedFloat = default !;
                promotedFloat = __VariableDeclaratorExpression<FloatPort>("promotedFloat", () => 1f, () => promotedFloat!, (_RRCG_SETTER_VALUE) => promotedFloat = _RRCG_SETTER_VALUE);
                StringPort promotedString = default !;
                promotedString = __VariableDeclaratorExpression<StringPort>("promotedString", () => "", () => promotedString!, (_RRCG_SETTER_VALUE) => promotedString = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i", "promotedFloat", "promotedString"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    promotedFloat *= 2;
                    promotedString += "a";
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString(__StringInterpolation("promotedFloat: ", promotedFloat, ", promotedString: ", promotedString));
            LogString(__StringInterpolation("Testing variable promotions with For-declared variables"));
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                IntPort otherOne = default !;
                otherOne = __VariableDeclaratorExpression<IntPort>("otherOne", () => 0, () => otherOne!, (_RRCG_SETTER_VALUE) => otherOne = _RRCG_SETTER_VALUE);
                IntPort otherTwo = default !;
                otherTwo = __VariableDeclaratorExpression<IntPort>("otherTwo", () => 0, () => otherTwo!, (_RRCG_SETTER_VALUE) => otherTwo = _RRCG_SETTER_VALUE);
                __OptimizedFor(__ConditionalContext("i", "otherOne", "otherTwo"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    otherTwo += 1;
                    LogString(__StringInterpolation("otherOne: ", otherOne, ", otherTwo: ", otherTwo));
                    __EndAccessibilityScope();
                }

                , () =>
                {
                    otherOne += 10;
                }

                );
                __EndAccessibilityScope();
            }

            LogString("All done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        IntPort ForLoopReturnEventFunction()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<IntPort>(this, "ForLoopReturnEventFunction", delegate ()
            {
                __BeginReturnScope("ForLoopReturnEventFunction", typeof(IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<IntPort>(ForLoopReturnImpl());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        IntPort ForLoopReturnImpl()
        {
            __BeginReturnScope("ForLoopReturnImpl", typeof(IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), true, 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(i, 5), delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __Return<IntPort>(i);
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

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void ForLoopReturnTest()
        {
            __BeginReturnScope("ForLoopReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("ForLoopReturnTest").Receiver();
            // Test returns from a For loop within an "inline" graph (functions are transparent)
            ChipLib.Log(__StringInterpolation("Result (inline graph): ", ForLoopReturnImpl()));
                IntPort result = default !;
                result = __VariableDeclaratorExpression<IntPort>("result", () => CircuitBoard<IntPort>(ForLoopReturnImpl), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Result (circuit board): ", result));
            // Test returns from a For loop within event functions
            ChipLib.Log(__StringInterpolation("Result (event function): ", ForLoopReturnEventFunction()));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void UnconventionalForLoopsTest()
        {
            __BeginReturnScope("UnconventionalForLoopsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("UnconventionalForLoopsTest").Receiver();
            // The most common use-case of For loops is to get an incrementing index.
            // But they aren't just limited to that task, so it's important that we
            // support all the possible use-cases, even if it means manual iteration.
            //
            // So, let's throw some unconventional For loops at it,
            // and ensure the resulting circuits match semantically..
            LogString("Testing string for loop");
                StringPort nextChar = default !;
                nextChar = __VariableDeclaratorExpression<StringPort>("nextChar", () => "", () => nextChar!, (_RRCG_SETTER_VALUE) => nextChar = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                StringPort result = default !;
                result = __VariableDeclaratorExpression<StringPort>("result", () => "", () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
                __ManualFor(__ConditionalContext("result", "nextChar"), () =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    nextChar = __SwitchExpression<StringPort>(result.Length, () => " ", new()
                    {{0, () => "H"}, {1, () => "e"}, {2, () => "l"}, {3, () => "l"}, {4, () => "o"}, {5, () => ","}, {6, () => " "}, {7, () => "W"}, {8, () => "o"}, {9, () => "r"}, {10, () => "l"}, {11, () => "d"}, {12, () => "!"}});
                    LogString(__StringInterpolation("result: ", result));
                    __EndAccessibilityScope();
                }

                , () => ChipBuilder.LessThan(result.Length, 14), () =>
                {
                    result += nextChar;
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Testing float for loop");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                FloatPort i = default !;
                i = __VariableDeclaratorExpression<FloatPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
                __ManualFor(__ConditionalContext("i"), () =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __EndAccessibilityScope();
                }

                , () => ChipBuilder.LessThan(i, 10), () =>
                {
                    i += 0.5f;
                }

                );
                __EndAccessibilityScope();
            }

            LogString("All done!");
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

