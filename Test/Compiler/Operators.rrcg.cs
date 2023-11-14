using RRCGSource;

public class Operators : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        NativeIntOperators();

        NativeFloatOperators();

        PortIntOperators();

        PortFloatOperators();

        MixedOperators();
    }

    public void NativeIntOperators()
    {
        int nativeA = 1;
        int nativeB = 2;

        ChipLib.Log(nativeA + nativeB);
        ChipLib.Log(nativeA - nativeB);
        ChipLib.Log(nativeA * nativeB);
        ChipLib.Log(nativeA / nativeB);
        ChipLib.Log(nativeA % nativeB);

        int postIncrement = 0;
        ChipLib.Log(postIncrement++);
        ChipLib.Log(postIncrement);

        int preIncrement = 0;
        ChipLib.Log(++preIncrement);
        ChipLib.Log(++preIncrement);

        int postDecrement = 0;
        ChipLib.Log(postDecrement--);
        ChipLib.Log(postDecrement);

        int preDecrement = 0;
        ChipLib.Log(--preDecrement);
        ChipLib.Log(preDecrement);
    }

    public void NativeFloatOperators()
    {
        float nativeA = 1;
        float nativeB = 2;

        ChipLib.Log(nativeA + nativeB);
        ChipLib.Log(nativeA - nativeB);
        ChipLib.Log(nativeA * nativeB);
        ChipLib.Log(nativeA / nativeB);
        ChipLib.Log(nativeA % nativeB);

        float postIncrement = 0;
        ChipLib.Log(postIncrement++);
        ChipLib.Log(postIncrement);

        float preIncrement = 0;
        ChipLib.Log(++preIncrement);
        ChipLib.Log(++preIncrement);

        float postDecrement = 0;
        ChipLib.Log(postDecrement--);
        ChipLib.Log(postDecrement);

        float preDecrement = 0;
        ChipLib.Log(--preDecrement);
        ChipLib.Log(preDecrement);
    }

    public void PortIntOperators()
    {
        int portA = RandomInt(0, 0);
        int portB = RandomInt(0, 0);

        ChipLib.Log(portA + portB);
        ChipLib.Log(portA - portB);
        ChipLib.Log(portA * portB);
        ChipLib.Log(portA / portB);
        ChipLib.Log(portA % portB);

        int postIncrement = RandomInt(0, 0);
        ChipLib.Log(postIncrement++);
        ChipLib.Log(postIncrement);

        int preIncrement = RandomInt(0, 0);
        ChipLib.Log(++preIncrement);
        ChipLib.Log(++preIncrement);

        int postDecrement = RandomInt(0, 0);
        ChipLib.Log(postDecrement--);
        ChipLib.Log(postDecrement);

        int preDecrement = RandomInt(0, 0);
        ChipLib.Log(--preDecrement);
        ChipLib.Log(preDecrement);
    }

    public void PortFloatOperators()
    {
        float portA = RandomFloat(1, 1);
        float portB = RandomFloat(2, 2);

        ChipLib.Log(portA + portB);
        ChipLib.Log(portA - portB);
        ChipLib.Log(portA * portB);
        ChipLib.Log(portA / portB);
        ChipLib.Log(portA % portB);

        float postIncrement = RandomFloat(0, 0);
        ChipLib.Log(postIncrement++);
        ChipLib.Log(postIncrement);

        float preIncrement = RandomFloat(0, 0);
        ChipLib.Log(++preIncrement);
        ChipLib.Log(++preIncrement);

        float postDecrement = RandomFloat(0, 0);
        ChipLib.Log(postDecrement--);
        ChipLib.Log(postDecrement);

        float preDecrement = RandomFloat(0, 0);
        ChipLib.Log(--preDecrement);
        ChipLib.Log(preDecrement);
    }

    public void MixedOperators()
    {
        float portA = RandomFloat(1, 1);
        int portB = RandomInt(2, 2);
        float nativeA = 3;
        int nativeB = 4;

        // TODO: These are not working!
        //ChipLib.Log(portA + portB * nativeA / nativeB);
        //ChipLib.Log(portA + portB * 5);
        //ChipLib.Log(portA * portB + 5);
    }
}