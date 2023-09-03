using RRCG;
using RRCGSource;

public class ExampleRoom : CircuitDescriptor
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
        EventReceiver(RoomEvents.Hz30);

        int rand1 = RandomInt(0, 10);
        int rand2 = RandomInt(0, 10);
        int rand3 = RandomInt(0, 10);

        if (rand1 + rand2 + rand3 > 10)
        {
            LogString("Today's your lucky day");
            return;
        }

        LogString("Try again next time");
    }

    public void TestEventHandler()
    {
        string message = EventReceiver<string>("MyEvent");

        var sum = ChipLib.EventCache<int>(2+3+4+5);

        var formatted = Concat(message, ToString(sum));

        PlayerShowSubtitle(GetLocalPlayer(), formatted, 3.0f, 0);
    }

    public void AdderCircuitBoard()
    {
        int input1 = ExistingDataInput<int>("value0");
        int input2 = ExistingDataInput<int>("value1");

        var result = input1 + input2;

        ExistingDataOutput<int>("result", result);
    }


    public void RandomCircuitBoard()
    {
        ExistingExecInput("Exec");

        var result = GenerateRandomNumber();

        ExistingDataOutput<int>("result", result);
        ExistingExecOutput("Exec");
    }

    public int GenerateRandomNumber()
    {
        return RandomInt(0, 100) + RandomInt(0,100);
    }



    // OLD stuff

    void Main()
    {
        string result = FormatMessage("b");

        PrintResult(result);
    }

    string FormatMessage(string message)
    {
        return Concat("a message:", message);
    }

    void PrintResult(string result)
    {
        LogString(result);
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


