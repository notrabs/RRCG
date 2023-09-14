using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CircuitBoards : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        var a = RandomInt(1, 10);

        CircuitBoard(ContentsExec);

        var b = CircuitBoard(ContentsMixed, a);

        ChipLib.Log(b);

        var (c, d) = CircuitBoard(ContentsData, b, b);

        ChipLib.Log(c);
        ChipLib.Log(d);
    }

    void ContentsExec()
    {
        RandomInt(1, 10);
    }

    int ContentsMixed(int a)
    {
        return RandomInt(a, 10);
    }

    (int, int) ContentsData(int a, int b)
    {
        return (a, b);
    }
}
