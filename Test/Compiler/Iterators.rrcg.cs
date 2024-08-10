using RRCG;
using RRCGSource;
using System.Collections.Generic;

#pragma warning disable CS0162 // Unreachable code detected
public class Iterators : CircuitDescriptor
{
    public override void CircuitGraph()
    {
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

        // FOR EACH TEST:
        var list = InlineGraph(() => ChipLib.EventCache(ListCreate(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)));

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
    }

    void WhileTest()
    {
        new EventDefinition("WhileTest").Receiver();

        var list = ListCreate<string>(
            "Item 1", "Item 2", "Item 3", "Item 4", "Item 5",
            "Item 6", "Item 7", "Item 8", "Item 9", "Item 10"
        );

        var listCache = ChipLib.EventCache(list);

        while (listCache.Count > 0)
        {
            ChipLib.Log(Concat("Removing \"", listCache[0], "\" from list"));
            ListRemoveAt(listCache, 0);
            ChipLib.Log(Concat("List now has ", ToString(listCache.Count), " items."));

            ChipLib.AwaitDelay();
        }

        ChipLib.Log("While loop done!");
        throw null;
    }

    void WhileReturnTest()
    {
        var entry = new EventDefinition("WhileReturnTest");
        entry.Receiver();

        // Test returns from while block within an "inline" graph (functions are transparent)
        ChipLib.Log(Concat("Repeated string (inline graph): ", StringRepeat("Hello", 5)));

        // Test returns from while block within a circuit board
        ChipLib.Log(Concat("Repeated string (circuit board): ", CircuitBoard<string, int, string>(StringRepeat, "Hey", 7)));

        // Test returns from while block within event functions
        ChipLib.Log(Concat("Repeated string (event function): ", StringRepeatEventFunction("Hi", 10)));

        throw null;
    }

    [EventFunction]
    string StringRepeatEventFunction(string str, int count)
    {
        // Functions are transparent -- this will duplicate the logic
        // and represent it as an event function.
        return StringRepeat(str, count);
    }

    string StringRepeat(string str, int count)
    {
        var strStaging = new Variable<string>();

        while (true)
        {
            strStaging.Value = Concat(strStaging.Value, str);

            if (strStaging.Value.Length >= str.Length * count)
                return strStaging.Value;
        }
    }

    void UnreachableNodesTest()
    {
        new EventDefinition("UnreachableNodesTest").Receiver();

        var index = new Variable<int>();
        index.Value = 0;

        while (index.Value < 100)
        {
            index.Value += 1;

            if (index.Value == 50)
            {
                ChipLib.Log("index.Value == 50, break!");
                break;

                PlayerShowSubtitle(Player.Local, "This node is unreachable and should not be placed.", 0, 0);
            }
            else if (index.Value % 5 == 0)
            {
                ChipLib.Log("index.Value % 5 == 0, continue!");
                continue;

                PlayerShowSubtitle(Player.Local, "This node is unreachable and should not be placed.", 0, 0);
            }
        }

        ChipLib.Log("Unreachable nodes test done!");
        throw null;
    }

    void NestedWhileTest()
    {
        new EventDefinition("NestedWhileTest").Receiver();

        LogString("Start");
        while (true)
        {
            while (true)
            {
                LogString("0");
                break;
            }

            LogString("1");
        }

        LogString("2");
        throw null;
    }

    void DoWhileTest()
    {
        new EventDefinition("DoWhileTest").Receiver();

        do
        {
            LogString("Do while loop");

            if (true)
            {
                LogString("Break");
                break;
            }
            else if (true)
            {
                LogString("Continue");
                continue;
            }

            LogString("Check condition");
        } while (true);

        LogString("Do while loop done");
    }

    void DoWhileReturnTest()
    {
        new EventDefinition("DoWhileReturnTest").Receiver();

        // Test returns from do while block within an "inline" graph (functions are transparent)
        ChipLib.Log(Concat("Repeated string (do while, inline graph): ", StringRepeatDoWhile("Hello", 5)));

        // Test returns from do while block within a circuit board
        ChipLib.Log(Concat("Repeated string (do while, circuit board): ", CircuitBoard<string, int, string>(StringRepeatDoWhile, "Hey", 7)));

        // Test returns from do while block within event functions
        ChipLib.Log(Concat("Repeated string (do while, event function): ", StringRepeatDoWhileEventFunction("Hi", 10)));

        throw null;
    }

    [EventFunction]
    string StringRepeatDoWhileEventFunction(string str, int count)
    {
        return StringRepeatDoWhile(str, count);
    }

    string StringRepeatDoWhile(string str, int count)
    {
        var strStaging = new Variable<string>();

        do
        {
            strStaging.Value = Concat(strStaging.Value, str);

            if (strStaging.Value.Length >= str.Length * count)
                return strStaging.Value;
        } while (true);
    }

    void NestedDoWhileTest()
    {
        new EventDefinition("NestedDoWhileTest").Receiver();

        do
        {
            LogString("Do while loop 1");

            if (true)
            {
                LogString("Loop 1 break");
                break;
            }
            else if (true)
            {
                LogString("Loop 1 continue");
                continue;
            }

            do
            {
                LogString("Do while loop 2");

                if (true)
                {
                    LogString("Loop 2 break");
                    break;
                }
                else if (true)
                {
                    LogString("Loop 2 continue");
                    continue;
                }

                LogString("Loop 2 check condition");
            } while (true);

            LogString("Loop 2 done");

            LogString("Loop 1 check condition");
        } while (true);

        LogString("Loop 1 done");
    }

    void ForEachTest(List<int> list)
    {
        new EventDefinition("ForEachTest").Receiver();

        foreach (var item in list)
            LogString($"Item: {item}");

        LogString("For each done");
        throw null;
    }

    void ManualForEachTest(List<int> list)
    {
        new EventDefinition("ManualForEachTest").Receiver();

        foreach (var item in list)
        {
            LogString($"Item: {item}");
            if (item == 5) break; // Manual iterator is required for break
        }

        LogString("Manual for each done");
        throw null;
    }

    void NestedForEach(List<int> list)
    {
        new EventDefinition("NestedForEach").Receiver();

        foreach (var item in list)
        {
            LogString($"Item outer: {item}");
            foreach (var item2 in list)
            {
                LogString($"Item inner: {item2}");
            }
            LogString("Inner done");
        }

        LogString("Nested for each done");
        throw null;
    }

    void ManualWithinStandardForEach(List<int> list)
    {
        new EventDefinition("ManualWithinStandardForEach").Receiver();

        foreach (var item in list)
        {
            LogString($"Item outer: {item}");
            foreach (var item2 in list)
            {
                LogString($"Item inner: {item2}");
                if (item2 == 5) break;
            }
            LogString("Inner done");
        }

        LogString("Nested for each (manual within standard) done");
        throw null;
    }

    void StandardWithinManualForEach(List<int> list)
    {
        new EventDefinition("StandardWithinManualForEach").Receiver();

        foreach (var item in list)
        {
            LogString($"Item outer: {item}");
            if (item == 5) break;

            foreach (var item2 in list)
            {
                LogString($"Item inner: {item2}");
            }
            LogString("Inner done");
        }

        LogString("Nested for each (standard within manual) done");
        throw null;
    }

    void TestDelaysForEach(List<int> list)
    {
        new EventDefinition("TestDelaysForEach").Receiver();

        // After Delay port on the final exec flow
        foreach (var item in list)
        {
            LogString($"Item outer: {item}");

            foreach (var item2 in list)
            {
                LogString($"Item inner: {item2}");
                ChipLib.AwaitDelay();
            }
            LogString("Inner done");
        }

        LogString("Between loops");

        // After Delay port further back in the exec flow
        foreach (var item in list)
        {
            LogString($"Item outer: {item}");

            foreach (var item2 in list)
            {
                LogString($"Item inner: {item2}");
                ChipLib.AwaitDelay();
                LogString("After delay, final exec flow contains this node's output port");
            }
            LogString("Inner done");
        }

        LogString("All done");
        throw null;
    }

    [EventFunction]
    int ForEachReturnEventFunction(List<int> list)
    {
        return ForEachReturnImpl(list);
    }

    int ForEachReturnImpl(List<int> list)
    {
        foreach (var item in list)
        {
            LogString($"Item: {item}");
            if (item == 5) return item;
        }

        throw null;
    }

    void ForEachReturnTest(List<int> list)
    {
        new EventDefinition("ForEachReturnTest").Receiver();

        // Test returns from For Each within an "inline" graph (functions are transparent)
        ChipLib.Log($"Result (inline graph): {ForEachReturnImpl(list)}");

        // Test returns from For Each within a circuit board
        var result = CircuitBoard(ForEachReturnImpl, list);
        ChipLib.Log($"Result (circuit board): {result}");

        // Test returns from For Each within event functions
        ChipLib.Log($"Result (event function): {ForEachReturnEventFunction(list)}");

        throw null;
    }

    void ForEachPromotedTest(List<int> list)
    {
        new EventDefinition("ForEachPromotedTest").Receiver();

        int i = 0;
        foreach (var item in list)
        {
            LogString($"Item: {item}, index: {i}");
            i += 1;
        }

        throw null;
    }

    void ForLoopTest()
    {
        new EventDefinition("ForLoopTest").Receiver();

        LogString("Testing standard form:");
        for (int i = 0; i < 10; i++)
            LogString($"i: {i}");

        LogString("Testing standard form (with 'var' index declaration):");

        // This should work too, because C# infers the type to be int.
        // We check with the semantic model to determine the type when
        // checking if a For statement can use the For node,
        // not just the syntax alone.

        for (var i = 0; i < 10; i++)
            LogString($"i: {i}");

        LogString("All done!");
        throw null;
    }

    void ManualForLoopTest()
    {
        new EventDefinition("ManualForLoopTest").Receiver();

        for (int i = 0; i < 10; i++)
        {
            LogString($"i: {i}");
            if (i == 5) break; // Breaking forces a manual implementation
        }

        LogString("For loop done");
        throw null;
    }

    void OptimizedToManualForLoopConversionsTest()
    {
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
        //
        // So we need to make sure we get it right!

        LogString("Testing iteration w/ delay (data ports):");

        // For iterators using data ports,
        // all we need to do is splice out the For node itself.
        for (int i = 0; i < 10; i++)
        {
            LogString($"i: {i}");
            ChipLib.AwaitDelay();
        }

        LogString("Testing iteration w/ delay (real ports):");

        // For iterators using real ports, we have a problem.
        //
        // We want to preserve the semantics of the For node here.
        // The start/end values are immutable while running the loop,
        // so to preserve the semantics (& ensure efficiency), we need to
        // cache the end value in a Random store before entering the loop.
        var min = Reroute(0);
        var max = Reroute(10);

        for (int i = min; i < max; i++)
        {
            LogString($"i: {i}");
            ChipLib.AwaitDelay();
        }

        LogString("All done!");
        throw null;
    }

    void NestedForLoopTest()
    {
        new EventDefinition("NestedForLoopTest").Receiver();

        for (int outer = 0; outer < 10; outer++)
        {
            LogString($"outer: {outer}");
            for (int inner = 0; inner < 10; inner++)
            {
                LogString($"inner: {inner}");
            }
            LogString("Inner done");
        }

        LogString("Outer done");
        throw null;
    }

    void ManualWithinStandardForLoopTest()
    {
        new EventDefinition("ManualWithinStandardForLoopTest").Receiver();

        for (int outer = 0; outer < 10; outer++)
        {
            LogString($"outer: {outer}");

            for (int inner = 0; inner < 10; inner++)
            {
                LogString($"inner: {inner}");
                if (inner == 5) break;
            }

            LogString("Inner done");
        }

        LogString("Outer done");
        throw null;
    }

    void StandardWithinManualForLoopTest()
    {
        new EventDefinition("StandardWithinManualForLoopTest").Receiver();

        for (int outer = 0; outer < 10; outer++)
        {
            LogString($"outer: {outer}");
            if (outer == 5) break;

            for (int inner = 0; inner < 10; inner++)
            {
                LogString($"inner: {inner}");
            }

            LogString("Inner done");
        }

        LogString("Outer done");
        throw null;
    }

    void PromotedVariablesForLoopTest()
    {
        new EventDefinition("PromotedVariablesForLoopTest").Receiver();

        LogString("Testing variable promotions with actual locals");

        float promotedFloat = 1f;
        string promotedString = "";

        for (int i = 0; i < 10; i++)
        {
            promotedFloat *= 2;
            promotedString += "a";
        }

        LogString($"promotedFloat: {promotedFloat}, promotedString: {promotedString}");
        LogString($"Testing variable promotions with For-declared variables");

        // This For statement should still be optimizable.
        for (int i = 0, otherOne = 0, otherTwo = 0; i < 10; i++, otherOne += 10)
        {
            otherTwo += 1;
            LogString($"otherOne: {otherOne}, otherTwo: {otherTwo}");
        }

        LogString("All done!");
        throw null;
    }

    [EventFunction]
    int ForLoopReturnEventFunction()
    {
        return ForLoopReturnImpl();
    }

    int ForLoopReturnImpl()
    {
        for (int i = 0; i < 10; i++)
        {
            LogString($"i: {i}");
            if (i == 5) return i;
        }

        throw null;
    }

    void ForLoopReturnTest()
    {
        new EventDefinition("ForLoopReturnTest").Receiver();

        // Test returns from a For loop within an "inline" graph (functions are transparent)
        ChipLib.Log($"Result (inline graph): {ForLoopReturnImpl()}");

        // Test returns from a For loop within a circuit board
        var result = CircuitBoard(ForLoopReturnImpl);
        ChipLib.Log($"Result (circuit board): {result}");

        // Test returns from a For loop within event functions
        ChipLib.Log($"Result (event function): {ForLoopReturnEventFunction()}");

        throw null;
    }

    void UnconventionalForLoopsTest()
    {
        new EventDefinition("UnconventionalForLoopsTest").Receiver();

        // The most common use-case of For loops is to get an incrementing index.
        // But they aren't just limited to that task, so it's important that we
        // support all the possible use-cases, even if it means manual iteration.
        //
        // So, let's throw some unconventional For loops at it,
        // and ensure the resulting circuits match semantically..

        LogString("Testing string for loop");

        string nextChar = "";
        for (string result = ""; result.Length < 14; result += nextChar)
        {
            nextChar = result.Length switch
            {
                0 => "H",
                1 => "e",
                2 => "l",
                3 => "l",
                4 => "o",
                5 => ",",
                6 => " ",
                7 => "W",
                8 => "o",
                9 => "r",
                10 => "l",
                11 => "d",
                12 => "!",
                _ => " "
            };
            LogString($"result: {result}");
        }

        LogString("Testing float for loop");

        for (float i = 0; i < 10; i += 0.5f)
        {
            LogString($"i: {i}");
        }

        LogString("All done!");
        throw null;
    }
}
#pragma warning restore CS0162 // Unreachable code detected