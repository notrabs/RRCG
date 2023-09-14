using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRCGBuild;

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
        Return(rrcg_return_flow, out rrcg_return_data, RandomInt(a, 10));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }

    (IntPort, IntPort) ContentsData(IntPort a, IntPort b)
    {
        ExecFlow rrcg_return_flow = new ExecFlow();
        (IntPort, IntPort) rrcg_return_data = default;
        Return(rrcg_return_flow, out rrcg_return_data, (a, b));
        ExecFlow.current.Merge(rrcg_return_flow);
        return rrcg_return_data;
    }
}