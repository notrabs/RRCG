using RRCG;
using RRCGSource;

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

        CircuitBoard(ExecOut);
        CircuitBoard(ExecIn);
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

    void ExecOut()
    {
        EventReceiver(RoomEvents.Hz30);
    }

    void ExecIn()
    {
        RandomInt(1, 10);
        throw null;
    }
}
