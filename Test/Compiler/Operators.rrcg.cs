using RRCGSource;
using UnityEngine;

public class Operators : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        NativeIntOperators();

        NativeFloatOperators();

        PortIntOperators();

        PortFloatOperators();

        VectorOperators();

        MixedOperators();

        TernaryOperator();
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
        ChipLib.Log(preIncrement);

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
        ChipLib.Log(preIncrement);

        float postDecrement = RandomFloat(0, 0);
        ChipLib.Log(postDecrement--);
        ChipLib.Log(postDecrement);

        float preDecrement = RandomFloat(0, 0);
        ChipLib.Log(--preDecrement);
        ChipLib.Log(preDecrement);
    }

    public void VectorOperators()
    {
        Vector3 vectorA = Vector3Create(1, 2, 3);
        Vector3 vectorB = Vector3Create(4, 5, 6);
        float portA = RandomFloat(1, 1);
        int portB = RandomInt(2, 2);

        ChipLib.Log(vectorA + vectorB);
        ChipLib.Log(vectorA - vectorB);

        // Should be converted to VectorScale
        ChipLib.Log(vectorA * portA);
        ChipLib.Log(vectorB * portB);
        ChipLib.Log(portA * vectorA);
        ChipLib.Log(portB * vectorB);
        ChipLib.Log(vectorA / portA);
        ChipLib.Log(vectorB / portB);

        // TODO: These will loose their default value in game. Can we detect this?
        ChipLib.Log(vectorA * 5f);
        ChipLib.Log(vectorA * 6);
        ChipLib.Log(7f * vectorB);
        ChipLib.Log(8 * vectorB);
    }

    public void MixedOperators()
    {
        float portA = RandomFloat(1, 1);
        int portB = RandomInt(2, 2);
        float nativeA = 3;
        int nativeB = 4;

        ChipLib.Log(portA + portB * nativeA / nativeB);
        ChipLib.Log(portA + portB * 5);
        ChipLib.Log(portA * portB + 5);
    }

    public void TernaryOperator()
    {
        // Data / data
        float dataA = 0;
        float dataB = 1;
        ChipLib.EventCache(true ? dataA : dataB);

        // Port / port
        float portA = RandomFloat(0, 0);
        float portB = RandomFloat(1, 1);
        ChipLib.EventCache(true ? portA : portB);

        // Port / data
        ChipLib.EventCache(true ? portA : dataB);
    }
}