using RRCG;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Iterators : RRCGBuild.CircuitBuilder
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
            UnreachableNodesTest();
            // Test nested while loops
            NestedWhileTest();
            // Test do while loops
            DoWhileTest();
            // Test returning from within a do while loop
            DoWhileReturnTest();
            // Test nested do while loops
            NestedDoWhileTest();
                RRCGBuild.ListPort<RRCGBuild.IntPort> list = default !;
                list = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", () => InlineGraph<RRCGBuild.ListPort<RRCGBuild.IntPort>>(() =>
                {
                    __BeginReturnScope("ParenthesizedLambda", typeof(RRCGBuild.ListPort<RRCGBuild.IntPort>), null);
                    __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    __Return<RRCGBuild.ListPort<RRCGBuild.IntPort>>(RRCGBuild.ChipLib.EventCache<RRCGBuild.ListPort<RRCGBuild.IntPort>>(ListCreate<RRCGBuild.IntPort>(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)));
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
            new RRCGBuild.EventDefinition("WhileTest").Receiver();
                RRCGBuild.ListPort<RRCGBuild.StringPort> list = default !;
                list = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("list", () => ListCreate<RRCGBuild.StringPort>("Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"), () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                RRCGBuild.ListPort<RRCGBuild.StringPort> listCache = default !;
                listCache = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.StringPort>>("listCache", () => RRCGBuild.ChipLib.EventCache<RRCGBuild.ListPort<RRCGBuild.StringPort>>(list), () => listCache!, (_RRCG_SETTER_VALUE) => listCache = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => ChipBuilder.GreaterThan(listCache.Count, 0), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
                ListRemoveAt<RRCGBuild.StringPort>(listCache, 0);
                RRCGBuild.ChipLib.Log(Concat("List now has ", ToString<RRCGBuild.IntPort>(listCache.Count), " items."));
                RRCGBuild.ChipLib.AwaitDelay();
                __EndAccessibilityScope();
            }

            );
            RRCGBuild.ChipLib.Log("While loop done!");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void WhileReturnTest()
        {
            __BeginReturnScope("WhileReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.EventDefinition entry = default !;
                entry = __VariableDeclaratorExpression<RRCGBuild.EventDefinition>("entry", () => new RRCGBuild.EventDefinition("WhileReturnTest"), () => entry!, (_RRCG_SETTER_VALUE) => entry = _RRCG_SETTER_VALUE);
            entry.Receiver();
            RRCGBuild.ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));
            RRCGBuild.ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<RRCGBuild.StringPort, RRCGBuild.IntPort, RRCGBuild.StringPort>(StringRepeat, "Hey", 7)));
            RRCGBuild.ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        RRCGBuild.StringPort StringRepeatEventFunction(RRCGBuild.StringPort str, RRCGBuild.IntPort count)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.StringPort, RRCGBuild.IntPort>(this, "StringRepeatEventFunction", delegate (RRCGBuild.StringPort str, RRCGBuild.IntPort count)
            {
                __BeginReturnScope("StringRepeatEventFunction", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.StringPort>(StringRepeat(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        RRCGBuild.StringPort StringRepeat(RRCGBuild.StringPort str, RRCGBuild.IntPort count)
        {
            __BeginReturnScope("StringRepeat", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.StringPort>>("strStaging", () => new RRCGBuild.Variable<RRCGBuild.StringPort>(), () => strStaging!, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => true, false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(__ConditionalContext(), () => ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<RRCGBuild.StringPort>(strStaging.Value);
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
            new RRCGBuild.EventDefinition("UnreachableNodesTest").Receiver();
                RRCGBuild.Variable<RRCGBuild.IntPort> index = default !;
                index = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.IntPort>>("index", () => new RRCGBuild.Variable<RRCGBuild.IntPort>(), () => index!, (_RRCG_SETTER_VALUE) => index = _RRCG_SETTER_VALUE);
            index.Value = 0;
            __While(__ConditionalContext(), () => ChipBuilder.LessThan(index.Value, 100), false, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                index.Value += 1;
                __If(__ConditionalContext(), () => ChipBuilder.Equals(index.Value, 50), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    RRCGBuild.ChipLib.Log("index.Value == 50, break!");
                    __Break();
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(index.Value % 5, 0), delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        RRCGBuild.ChipLib.Log("index.Value % 5 == 0, continue!");
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
                __EndAccessibilityScope();
            }

            );
            RRCGBuild.ChipLib.Log("Unreachable nodes test done!");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void NestedWhileTest()
        {
            __BeginReturnScope("NestedWhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("NestedWhileTest").Receiver();
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void DoWhileTest()
        {
            __BeginReturnScope("DoWhileTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("DoWhileTest").Receiver();
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
            new RRCGBuild.EventDefinition("DoWhileReturnTest").Receiver();
            RRCGBuild.ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));
            RRCGBuild.ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<RRCGBuild.StringPort, RRCGBuild.IntPort, RRCGBuild.StringPort>(StringRepeatDoWhile, "Hey", 7)));
            RRCGBuild.ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        RRCGBuild.StringPort StringRepeatDoWhileEventFunction(RRCGBuild.StringPort str, RRCGBuild.IntPort count)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.StringPort, RRCGBuild.StringPort, RRCGBuild.IntPort>(this, "StringRepeatDoWhileEventFunction", delegate (RRCGBuild.StringPort str, RRCGBuild.IntPort count)
            {
                __BeginReturnScope("StringRepeatDoWhileEventFunction", typeof(RRCGBuild.StringPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
                __VariableDeclaratorExpression<RRCGBuild.IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.StringPort>(StringRepeatDoWhile(str, count));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , str, count);
        }

        RRCGBuild.StringPort StringRepeatDoWhile(RRCGBuild.StringPort str, RRCGBuild.IntPort count)
        {
            __BeginReturnScope("StringRepeatDoWhile", typeof(RRCGBuild.StringPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.StringPort>("str", null, () => str!, (_RRCG_SETTER_VALUE) => str = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<RRCGBuild.IntPort>("count", null, () => count!, (_RRCG_SETTER_VALUE) => count = _RRCG_SETTER_VALUE);
                RRCGBuild.Variable<RRCGBuild.StringPort> strStaging = default !;
                strStaging = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.StringPort>>("strStaging", () => new RRCGBuild.Variable<RRCGBuild.StringPort>(), () => strStaging!, (_RRCG_SETTER_VALUE) => strStaging = _RRCG_SETTER_VALUE);
            __While(__ConditionalContext(), () => true, true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                strStaging.Value = Concat(strStaging.Value, str);
                __If(__ConditionalContext(), () => ChipBuilder.GreaterOrEqual(strStaging.Value.Length, str.Length * count), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<RRCGBuild.StringPort>(strStaging.Value);
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
            new RRCGBuild.EventDefinition("NestedDoWhileTest").Receiver();
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

        void ForEachTest(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ForEachTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("ForEachTest").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item));
                __EndAccessibilityScope();
            }

            );
            LogString("For each done");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualForEachTest(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ManualForEachTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("ManualForEachTest").Receiver();
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void NestedForEach(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("NestedForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("NestedForEach").Receiver();
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualWithinStandardForEach(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ManualWithinStandardForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("ManualWithinStandardForEach").Receiver();
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void StandardWithinManualForEach(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("StandardWithinManualForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("StandardWithinManualForEach").Receiver();
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestDelaysForEach(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("TestDelaysForEach", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("TestDelaysForEach").Receiver();
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item outer: ", item));
                __ForEach(__ConditionalContext(), list, (item2) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("Item inner: ", item2));
                    RRCGBuild.ChipLib.AwaitDelay();
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
                    RRCGBuild.ChipLib.AwaitDelay();
                    LogString("After delay, final exec flow contains this node's output port");
                    __EndAccessibilityScope();
                }

                );
                LogString("Inner done");
                __EndAccessibilityScope();
            }

            );
            LogString("All done");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        RRCGBuild.IntPort ForEachReturnEventFunction(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort, RRCGBuild.ListPort<RRCGBuild.IntPort>>(this, "ForEachReturnEventFunction", delegate (RRCGBuild.ListPort<RRCGBuild.IntPort> list)
            {
                __BeginReturnScope("ForEachReturnEventFunction", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
                __Return<RRCGBuild.IntPort>(ForEachReturnImpl(list));
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            , list);
        }

        RRCGBuild.IntPort ForEachReturnImpl(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ForEachReturnImpl", typeof(RRCGBuild.IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            __ForEach(__ConditionalContext(), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item));
                __If(__ConditionalContext(), () => ChipBuilder.Equals(item, 5), delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Return<RRCGBuild.IntPort>(item);
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
            __Throw();
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void ForEachReturnTest(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ForEachReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("ForEachReturnTest").Receiver();
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (inline graph): ", ForEachReturnImpl(list)));
                RRCGBuild.IntPort result = default !;
                result = __VariableDeclaratorExpression<RRCGBuild.IntPort>("result", () => CircuitBoard<RRCGBuild.ListPort<RRCGBuild.IntPort>, RRCGBuild.IntPort>(ForEachReturnImpl, list), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (circuit board): ", result));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (event function): ", ForEachReturnEventFunction(list)));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ForEachPromotedTest(RRCGBuild.ListPort<RRCGBuild.IntPort> list)
        {
            __BeginReturnScope("ForEachPromotedTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("list", null, () => list!, (_RRCG_SETTER_VALUE) => list = _RRCG_SETTER_VALUE);
            new RRCGBuild.EventDefinition("ForEachPromotedTest").Receiver();
                RRCGBuild.IntPort i = default !;
                i = __VariableDeclaratorExpression<RRCGBuild.IntPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
            __ForEach(__ConditionalContext("i"), list, (item) =>
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                LogString(__StringInterpolation("Item: ", item, ", index: ", i));
                i += 1;
                __EndAccessibilityScope();
            }

            );
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ForLoopTest()
        {
            __BeginReturnScope("ForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("ForLoopTest").Receiver();
            LogString("Testing standard form:");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, 10, (i) =>
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

            LogString("Testing standard form (with 'var' index declaration):");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, 10, (i) =>
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

            LogString("All done!");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualForLoopTest()
        {
            __BeginReturnScope("ManualForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("ManualForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, 10, (i) =>
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void OptimizedToManualForLoopConversionsTest()
        {
            __BeginReturnScope("OptimizedToManualForLoopConversionsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("OptimizedToManualForLoopConversions").Receiver();
            // At rewriting time, we make a best-effort guess about whether or not
            // a particular For statement can be optimized into using the For node.
            //
            // However, at build time, this guess may be proven wrong through a
            // number of ways (iterators using Delays in their chain, breaks, etc).
            //
            // If this occurs, we need to go back and splice-in a manual iterator
            // which can be a bit of a convoluted process, especially with the
            // flexibility of For loops.
            //
            // So we need to make sure we get it right!
            LogString("Testing iteration w/ delay (data ports):");
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    RRCGBuild.ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("Testing iteration w/ delay (real ports):");
                RRCGBuild.IntPort min = default !;
                min = __VariableDeclaratorExpression<RRCGBuild.IntPort>("min", () => Reroute<RRCGBuild.IntPort>(0), () => min!, (_RRCG_SETTER_VALUE) => min = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort max = default !;
                max = __VariableDeclaratorExpression<RRCGBuild.IntPort>("max", () => Reroute<RRCGBuild.IntPort>(10), () => max!, (_RRCG_SETTER_VALUE) => max = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), min, max, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    RRCGBuild.ChipLib.AwaitDelay();
                    __EndAccessibilityScope();
                }

                , () =>
                {
                }

                );
                __EndAccessibilityScope();
            }

            LogString("All done!");
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void NestedForLoopTest()
        {
            __BeginReturnScope("NestedForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("NestedForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), 0, 10, (outer) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("outer: ", outer));
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __OptimizedFor(__ConditionalContext("inner"), 0, 10, (inner) =>
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ManualWithinStandardForLoopTest()
        {
            __BeginReturnScope("ManualWithinStandardForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("ManualWithinStandardForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), 0, 10, (outer) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("outer: ", outer));
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __OptimizedFor(__ConditionalContext("inner"), 0, 10, (inner) =>
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void StandardWithinManualForLoopTest()
        {
            __BeginReturnScope("StandardWithinManualForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("StandardWithinManualForLoopTest").Receiver();
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("outer"), 0, 10, (outer) =>
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
                        __OptimizedFor(__ConditionalContext("inner"), 0, 10, (inner) =>
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void PromotedVariablesForLoopTest()
        {
            __BeginReturnScope("PromotedVariablesForLoopTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("PromotedVariablesForLoopTest").Receiver();
            LogString("Testing variable promotions with actual locals");
                RRCGBuild.FloatPort promotedFloat = default !;
                promotedFloat = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("promotedFloat", () => 1f, () => promotedFloat!, (_RRCG_SETTER_VALUE) => promotedFloat = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort promotedString = default !;
                promotedString = __VariableDeclaratorExpression<RRCGBuild.StringPort>("promotedString", () => "", () => promotedString!, (_RRCG_SETTER_VALUE) => promotedString = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i", "promotedFloat", "promotedString"), 0, 10, (i) =>
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
                RRCGBuild.IntPort otherOne = default !;
                otherOne = __VariableDeclaratorExpression<RRCGBuild.IntPort>("otherOne", () => 0, () => otherOne!, (_RRCG_SETTER_VALUE) => otherOne = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort otherTwo = default !;
                otherTwo = __VariableDeclaratorExpression<RRCGBuild.IntPort>("otherTwo", () => 0, () => otherTwo!, (_RRCG_SETTER_VALUE) => otherTwo = _RRCG_SETTER_VALUE);
                __OptimizedFor(__ConditionalContext("i", "otherOne", "otherTwo"), 0, 10, (i) =>
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [EventFunction]
        RRCGBuild.IntPort ForLoopReturnEventFunction()
        {
            return SpecialMethodsDispatcher.current.DispatchEventFunction<RRCGBuild.IntPort>(this, "ForLoopReturnEventFunction", delegate ()
            {
                __BeginReturnScope("ForLoopReturnEventFunction", typeof(RRCGBuild.IntPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.IntPort>(ForLoopReturnImpl());
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            );
        }

        RRCGBuild.IntPort ForLoopReturnImpl()
        {
            __BeginReturnScope("ForLoopReturnImpl", typeof(RRCGBuild.IntPort), null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __OptimizedFor(__ConditionalContext("i"), 0, 10, (i) =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    LogString(__StringInterpolation("i: ", i));
                    __If(__ConditionalContext(), () => ChipBuilder.Equals(i, 5), delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __Return<RRCGBuild.IntPort>(i);
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

            __Throw();
            __EndAccessibilityScope();
            return __EndReturnScope()!;
        }

        void ForLoopReturnTest()
        {
            __BeginReturnScope("ForLoopReturnTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("ForLoopReturnTest").Receiver();
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (inline graph): ", ForLoopReturnImpl()));
                RRCGBuild.IntPort result = default !;
                result = __VariableDeclaratorExpression<RRCGBuild.IntPort>("result", () => CircuitBoard<RRCGBuild.IntPort>(ForLoopReturnImpl), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (circuit board): ", result));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result (event function): ", ForLoopReturnEventFunction()));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void UnconventionalForLoopsTest()
        {
            __BeginReturnScope("UnconventionalForLoopsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("UnconventionalForLoopsTest").Receiver();
            // The most common use-case of For loops is to get an incrementing index.
            // But they aren't just limited to that task, so it's important that we
            // support all the possible use-cases, even if it means manual iteration.
            //
            // So, let's throw some unconventional For loops at it,
            // and ensure the resulting circuits match semantically..
            LogString("Testing string for loop");
                RRCGBuild.StringPort nextChar = default !;
                nextChar = __VariableDeclaratorExpression<RRCGBuild.StringPort>("nextChar", () => "", () => nextChar!, (_RRCG_SETTER_VALUE) => nextChar = _RRCG_SETTER_VALUE);
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                RRCGBuild.StringPort result = default !;
                result = __VariableDeclaratorExpression<RRCGBuild.StringPort>("result", () => "", () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
                __ManualFor(__ConditionalContext("result", "nextChar"), () =>
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    nextChar = __SwitchExpression<RRCGBuild.StringPort>(result.Length, () => " ", new()
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
                RRCGBuild.FloatPort i = default !;
                i = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("i", () => 0, () => i!, (_RRCG_SETTER_VALUE) => i = _RRCG_SETTER_VALUE);
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
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

