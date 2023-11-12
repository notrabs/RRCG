using RRCG;
using RRCGSource;
using System.Collections.Generic;

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
    }

    void WhileTest()
    {
        var entry = new EventHelper("WhileTest").Definition();
        entry.Receiver();

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
        var entry = new EventHelper("WhileReturnTest").Definition();
        entry.Receiver();

        // Test returns from while block within an "inline" graph (functions are transparent)
        ChipLib.Log(Concat("Repeated string (circuit board): ", StringRepeat("Hello", 5)));

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
        var entry = new EventHelper("UnreachableNodesTest").Definition();
        entry.Receiver();

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
}