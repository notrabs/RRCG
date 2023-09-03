using RRCG;
using RRCGBuild;
using System.Collections.Generic;

public class ExampleRoomGen : CircuitBuilder
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
        var rand1 = RandomInt(new IntPort{Data = 0}, new IntPort{Data = 10});
        var rand2 = RandomInt(new IntPort{Data = 0}, new IntPort{Data = 10});
        ChipBuilder.If(ChipBuilder.GreaterThan(ChipBuilder.Add(rand1, rand2), new IntPort{Data = 10}), delegate
        {
            LogString(new StringPort{Data = "Today's your lucky day"});
        }

        , delegate
        {
            LogString(new StringPort{Data = "Try again next time"});
        }

        );
    }

    public void EventCacheExample()
    {
        EventReceiver(RoomEvents.Hz30);
        var rand1 = RandomInt(new IntPort{Data = 0}, new IntPort{Data = 10});
        var sum = ChipBuilder.Add((ChipBuilder.Add(rand1, new IntPort{Data = 3})), (ChipBuilder.Add(new IntPort{Data = 4}, new IntPort{Data = 5})));
        var cached = ChipLib.EventCache<IntPort>(sum);
        PlayerShowSubtitle(GetLocalPlayer(), ToString(cached), new FloatPort{Data = 3.0f}, new IntPort{Data = 0});
    }

    public void AdderCircuitBoard()
    {
        IntPort input1 = ExistingDataInput<IntPort>(new StringPort{Data = "value0"});
        IntPort input2 = ExistingDataInput<IntPort>(new StringPort{Data = "value1"});
        var result = ChipBuilder.Add(input1, input2);
        ExistingDataOutput<IntPort>(new StringPort{Data = "result"}, result);
    }

    public void RandomCircuitBoard()
    {
        ExistingExecInput(new StringPort{Data = "Exec"});
        var result = GenerateRandomNumber();
        ExistingDataOutput<IntPort>(new StringPort{Data = "result"}, result);
        ExistingExecOutput(new StringPort{Data = "Exec"});
    }

    public IntPort GenerateRandomNumber()
    {
        return ChipBuilder.Add(RandomInt(new IntPort{Data = 0}, new IntPort{Data = 100}), RandomInt(new IntPort{Data = 0}, new IntPort{Data = 100}));
    }

    public override Context BuildCircuitGraph()
    {
        List<Node> nodes = new List<Node>();
        List<Connection> connections = new List<Connection>();
        Context context = new Context{Nodes = nodes, Connections = connections};
        Context.current = context;
        ExecFlow.current = new ExecFlow();
        CircuitGraph();
        return context;
    }
}