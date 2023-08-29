using RRCG;
using RRCGBuild;
using System.Collections.Generic;

[RRCGRoom]
public class ExampleRoomGen : CircuitBuilder
{
    public override void CircuitGraph()
    {
        MyRoom();
        TestEventHandler();
        StartNewGraph();
        Main();
        //ExistingCircuitBoard("Adder Board", AdderCircuitBoard);
        //ExistingCircuitBoard("Random Board", RandomCircuitBoard);
    }

    public void MyRoom()
    {
        ChipBuilder.EventReceiver(RoomEvents.Hz30);
        IntPort rand1 = ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 });
        IntPort rand2 = ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 });
        IntPort rand3 = ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 });
        ChipBuilder.If(ChipBuilder.GreaterThan(ChipBuilder.Add(ChipBuilder.Add(rand1, rand2), rand3), new IntPort { Data = 10 }), delegate ()
        {
            {
                ChipBuilder.LogString(new StringPort { Data = "Today's your lucky day" });
                return;
            }
        }

        , delegate ()
        {
        }

        );
        ChipBuilder.LogString(new StringPort { Data = "Try again next time" });
    }

    public void TestEventHandler()
    {
        StringPort message = ChipBuilder.EventReceiver<StringPort>(new StringPort { Data = "MyEvent" });
        var sum = ChipLib.EventCache<IntPort>(ChipBuilder.Add(ChipBuilder.Add(ChipBuilder.Add(new IntPort { Data = 2 }, new IntPort { Data = 3 }), new IntPort { Data = 4 }), new IntPort { Data = 5 }));
        var formatted = ChipBuilder.Concat(message, ChipBuilder.ToString(sum));
        ChipBuilder.PlayerShowSubtitle(ChipBuilder.GetLocalPlayer(), formatted, new FloatPort { Data = 3 }, new IntPort { Data = 0 });
    }

    public void AdderCircuitBoard()
    {
        IntPort input1 = ExistingDataInput<IntPort>(new StringPort { Data = "value0" });
        IntPort input2 = ExistingDataInput<IntPort>(new StringPort { Data = "value1" });
        var result = ChipBuilder.Add(input1, input2);
        ExistingDataOutput<IntPort>(new StringPort { Data = "result" }, result);
    }

    public void RandomCircuitBoard()
    {
        ExistingExecInput(new StringPort { Data = "Exec" });
        var result = GenerateRandomNumber();
        ExistingDataOutput<IntPort>(new StringPort { Data = "result" }, result);
        ExistingExecOutput(new StringPort { Data = "Exec" });
    }

    public IntPort GenerateRandomNumber()
    {
        return ChipBuilder.Add(ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 100 }), ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 100 }));
    }

    // OLD stuff
    void Main()
    {
        StringPort result = FormatMessage(new StringPort { Data = "b" });
        PrintResult(result);
    }

    StringPort FormatMessage(StringPort message)
    {
        return ChipBuilder.Concat(new StringPort { Data = "a message:" }, message);
    }

    void PrintResult(StringPort result)
    {
        ChipBuilder.LogString(result);
    }

    public override Context BuildCircuitGraph()
    {
        List<Node> nodes = new List<Node>();
        List<Connection> connections = new List<Connection>();
        Context context = new Context { Nodes = nodes, Connections = connections };
        ExecFlow execFlow = new ExecFlow();
        CircuitGraph();
        return context;
    }
    //void SimpleIf()
    //{
    //    int result = Chips.Add(3, 4);
    //    bool test = Chips.GreaterThan(result, Chips.RandomInt(0, 10));
    //    Chips.If(test,
    //     delegate ()
    //     {
    //         Chips.LogString("If");
    //     },
    //     delegate ()
    //     {
    //         Chips.LogString("Else");
    //     });
    //    Chips.LogString("SimpleIf");
    //}
    //void ComplexIf()
    //{
    //    int sum = 3 + 4;
    //    if (sum > Chips.RandomInt(0, 10))
    //    {
    //        Chips.LogString("If");
    //    }
    //    else if (sum > Chips.RandomInt(0, 10))
    //    {
    //        Chips.LogString("Second Chance");
    //    }
    //    else
    //    {
    //        Chips.LogString("Else");
    //        return;
    //    }
    //    Chips.LogString("No Early return");
    //}
}