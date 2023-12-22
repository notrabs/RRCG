using RRCG;
using RRCGSource;
using System.Collections.Generic;

#pragma warning disable CS0162 // Unreachable code detected
public class Iterators : CircuitDescriptor
{
    public override void CircuitGraph()
    {
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

        // For Each loops
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
    public string StringRepeatEventFunction(string str, int count)
    {
        // Functions are transparent -- this will duplicate the logic
        // and represent it as an event function.
        return StringRepeat(str, count);
    }

    public string StringRepeat(string str, int count)
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
    public string StringRepeatDoWhileEventFunction(string str, int count)
    {
        return StringRepeatDoWhile(str, count);
    }

    public string StringRepeatDoWhile(string str, int count)
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
    public int ForEachReturnEventFunction(List<int> list)
    {
        return ForEachReturnImpl(list);
    }

    public int ForEachReturnImpl(List<int> list)
    {
        foreach (var item in list)
        {
            LogString($"Item: {item}");

            // We have to return the item in a reroute
            // for now because returning Item directly would
            // return the port on the For Each node, which will be removed.
            // The invalid reference would hang out in rrcg_return_data where we
            // can't correct it. Maybe conditional returns would fix this,
            // if we use an event cache to store returned values (and get conditionals for free)?
            if (item == 5) return Reroute(item);
        }

        throw null;
    }

    void ForEachReturnTest(List<int> list)
    {
        var entry = new EventDefinition("ForEachReturnTest");
        entry.Receiver();

        // Test returns from while block within an "inline" graph (functions are transparent)
        ChipLib.Log($"Result (inline graph): {ForEachReturnImpl(list)}");

        // Test returns from while block within a circuit board
        var result = CircuitBoard(ForEachReturnImpl, list);
        ChipLib.Log($"Result (circuit board): {result}");

        // Test returns from while block within event functions
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
    }
}
#pragma warning restore CS0162 // Unreachable code detected