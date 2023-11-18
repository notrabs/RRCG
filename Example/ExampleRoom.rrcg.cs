using RRCG;
using RRCGSource;
using UnityEngine;

public class ExampleRoom : CircuitDescriptor
{
    EventDefinition<int> testEvent = new EventDefinition<int>("intValue");

    public override void CircuitGraph()
    {
        RandomExample();

        EventCacheExample();

        VariableLoopExample();
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

    public void VariableLoopExample()
    {
        var intValue = testEvent.Receiver();

        var counter = new Variable<int>();

        while (counter.Value < intValue)
        {
            ChipLib.Log(counter.Value);
            counter.Value++;
        }
    }
}


