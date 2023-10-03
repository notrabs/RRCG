using RRCG;
using RRCGSource;
using UnityEngine;

public class ExampleRoom : CircuitDescriptor
{

    public override void CircuitGraph()
    {
        RandomExample();

        EventCacheExample();

        // These are WIP
        //ExistingCircuitBoard("Adder Board", AdderCircuitBoard);
        //ExistingCircuitBoard("Random Board", RandomCircuitBoard);

        //ReturnTest1();
        //RandomInt(0, 10);
        //var (a, b) = ReturnTest2();

        //ChipLib.Log(a);
        //ChipLib.Log(b);

        
    }

    public void RandomExample()
    {
        EventReceiver(RoomEvents.Hz30);

        var rand1 = RandomInt(0, 10);
        var rand2 = RandomInt(0, 10);

        if (rand1 + rand2 > 10) LogString("Today's your lucky day");
        else LogString("Try again next time");
    }

    public void EventCacheExample()
    {
        EventReceiver(RoomEvents.Hz30);

        var rand1 = RandomInt(0, 10);
        var sum = (rand1 + 3) + (4 + 5);
        var cached = ChipLib.EventCache<int>(sum);

        PlayerShowSubtitle(
            GetLocalPlayer(),
            ToString(cached),
            3.0f, 0
        );
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
        return RandomInt(0, 100) + RandomInt(0, 100);
    }

    public void ReturnTest1()
    {
        if (RandomInt(0, 10) == 5)
        {
            return;
        }
        else if (RandomInt(0, 10) == 5)
        {
            return;
        }

        return;
    }

    public (int, int) ReturnTest2()
    {
        int b = 0;

        if (RandomInt(0, 10) == 5)
        {
            return (1, 1);
        }
        else if (RandomInt(0, 10) == 5)
        {
            var c = 3;

            if (RandomInt(0, 10) == 5) c = 4;

            b = 4;
            return (b, c);
        }
        else if (RandomInt(0, 10) == 5)
        {
            b = 4;
        }

        return (1, b);
    }
}


