using RRCG;
using RRCGBuild;
using System.Collections.Generic;

public class CircuitBoardsGen : CircuitBuilder
{
    public override void CircuitGraph()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        var a = RandomInt(1, 10);
        CircuitBoard(ContentsExec);
        var b = CircuitBoard(ContentsMixed, a);
        ChipLib.Log(b);
        var(c, d) = CircuitBoard(ContentsData, b, b);
        ChipLib.Log(c);
        ChipLib.Log(d);
        CircuitBoard(ExecOut);
        CircuitBoard(ExecIn);
        //CircuitBoard(() =>
        //{
        //    ChipLib.Log("Anonymous Function");
        //    __Return(rrcg_return_flow, out rrcg_return_data, "test");
        //}

        //);
        CircuitBoard((IntPort test) =>
        {
            ChipLib.Log("Anonymous Parameter");
        }

        , a);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    void ContentsExec()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        RandomInt(1, 10);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    IntPort ContentsMixed(IntPort a)
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        IntPort rrcg_return_data = default;
        __Return(rrcg_return_flow, out rrcg_return_data, RandomInt(a, 10));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }

    (IntPort namedValue, IntPort) ContentsData(IntPort a, IntPort b)
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        (IntPort namedValue, IntPort) rrcg_return_data = default;
        __Return(rrcg_return_flow, out rrcg_return_data, (a, b));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }

    void ExecOut()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        EventReceiver(RoomEvents.Hz30);
        ExecFlow.current.Merge(rrcg_return_flow);
    }

    void ExecIn()
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        RandomInt(1, 10);
        ExecFlow.current.Clear();
        ExecFlow.current.Merge(rrcg_return_flow);
    }
}