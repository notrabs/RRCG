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

        // Returns are not translated yet
        //CircuitBoard(() =>
        //{
        //    ChipLib.Log("Anonymous Function");
        //    return "test";
        //});

        CircuitBoard((int test) =>
        {
            ChipLib.Log("Anonymous Parameter");
        }, a);
    }

    void ContentsExec()
    {
        RandomInt(1, 10);
    }

    int ContentsMixed(int a)
    {
        return RandomInt(a, 10);
    }

    (int namedValue, int) ContentsData(int a, int b)
    {
        return (a, b);
    }

    void ExecOut()
    {
        RoomEvent.Hz30();
    }

    void ExecIn()
    {
        RandomInt(1, 10);
        throw null;
    }
}
