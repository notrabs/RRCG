using RRCG;
using RRCGSource;

public class ExampleRoom : CircuitDescriptor
{

    public override void CircuitGraph()
    {
        RandomExample();

        EventCacheExample();

        // These are WIP
        //ExistingCircuitBoard("Adder Board", AdderCircuitBoard);
        //ExistingCircuitBoard("Random Board", RandomCircuitBoard);
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
}


