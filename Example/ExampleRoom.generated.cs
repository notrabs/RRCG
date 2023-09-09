using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

public class ExampleRoomGen : CircuitBuilder
{
    public override void CircuitGraph()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        RandomExample();
        EventCacheExample();
        ExecFlow.current.Merge(rrcg_return_flow);
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
        ExecFlow rrcg_return_flow = new ExecFlow();
        EventReceiver(RoomEvents.Hz30);
        var rand1 = RandomInt(0, 10);
        var rand2 = RandomInt(0, 10);
        ChipBuilder.If(ChipBuilder.GreaterThan(ChipBuilder.Add(rand1, rand2), 10), delegate
        {
            LogString("Today's your lucky day");
        }

        , delegate
        {
            LogString("Try again next time");
        }

        );
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    public void EventCacheExample()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        EventReceiver(RoomEvents.Hz30);
        var rand1 = RandomInt(0, 10);
        var sum = ChipBuilder.Add((ChipBuilder.Add(rand1, 3)), (ChipBuilder.Add(4, 5)));
        var cached = ChipLib.EventCache<IntPort>(sum);
        PlayerShowSubtitle(GetLocalPlayer(), ToString(cached), 3.0f, 0);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    public void AdderCircuitBoard()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        IntPort input1 = ExistingDataInput<IntPort>("value0");
        IntPort input2 = ExistingDataInput<IntPort>("value1");
        var result = ChipBuilder.Add(input1, input2);
        ExistingDataOutput<IntPort>("result", result);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    public void RandomCircuitBoard()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        ExistingExecInput("Exec");
        var result = GenerateRandomNumber();
        ExistingDataOutput<IntPort>("result", result);
        ExistingExecOutput("Exec");
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    public IntPort GenerateRandomNumber()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        IntPort rrcg_return_data = default;
        Return(rrcg_return_flow, out rrcg_return_data, ChipBuilder.Add(RandomInt(0, 100), RandomInt(0, 100)));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }

    public void ReturnTest1()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
        {
            {
                Return(rrcg_return_flow);
            }
        }

        , delegate
        {
            ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
            {
                {
                    Return(rrcg_return_flow);
                }
            }

            , delegate
            {
            }

            );
        }

        );
        Return(rrcg_return_flow);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    public (IntPort, IntPort) ReturnTest2()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        (IntPort, IntPort) rrcg_return_data = default;
        IntPort b = 0;
        ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
        {
            {
                Return(rrcg_return_flow, out rrcg_return_data, (1, 1));
            }
        }

        , delegate
        {
            ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
            {
                {
                    var c = 3;
                    ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
                    {
                        c = 4;
                    }

                    , delegate
                    {
                    }

                    );
                    b = 4;
                    Return(rrcg_return_flow, out rrcg_return_data, (b, c));
                }
            }

            , delegate
            {
                ChipBuilder.If(ChipBuilder.Equals(RandomInt(0, 10), 5), delegate
                {
                    {
                        b = 4;
                    }
                }

                , delegate
                {
                }

                );
            }

            );
        }

        );
        Return(rrcg_return_flow, out rrcg_return_data, (1, b));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }
}