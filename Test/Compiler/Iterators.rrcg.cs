using RRCG;
using RRCGSource;

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
}
#pragma warning restore CS0162 // Unreachable code detected