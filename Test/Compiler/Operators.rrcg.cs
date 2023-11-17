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

        BitwiseOperators();
    }

    public void NativeIntOperators()
    {
        var e = new EventHelper("NativeIntOperators").Definition();
        e.Receiver();

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

        throw null;
    }

    public void NativeFloatOperators()
    {
        var e = new EventHelper("NativeFloatOperators").Definition();
        e.Receiver();

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

        throw null;
    }

    public void PortIntOperators()
    {
        var e = new EventHelper("PortIntOperators").Definition();
        e.Receiver();

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

        throw null;
    }

    public void PortFloatOperators()
    {
        var e = new EventHelper("PortFloatOperators").Definition();
        e.Receiver();

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

        throw null;
    }

    public void VectorOperators()
    {
        var e = new EventHelper("VectorOperators").Definition();
        e.Receiver();

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

        throw null;
    }

    public void MixedOperators()
    {
        var e = new EventHelper("MixedOperators").Definition();
        e.Receiver();

        float portA = RandomFloat(1, 1);
        int portB = RandomInt(2, 2);
        float nativeA = 3;
        int nativeB = 4;

        ChipLib.Log(portA + portB * nativeA / nativeB);
        ChipLib.Log(portA + portB * 5);
        ChipLib.Log(portA * portB + 5);

        throw null;
    }

    public void TernaryOperator()
    {
        var e = new EventHelper("TernaryOperator").Definition();
        e.Receiver();

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

        // Implicit conversions
        // Floats without -f suffix
        RandomFloat(0, true ? 123 : 456);

        // Implicit conversions w/ real ports
        int intPort = RandomInt(0, 0);
        RandomFloat(0, true ? 1.5f : intPort);

        // Implicit conversion for result
        ChipLib.Log($"Result: {(false ? intPort : portA)}");

        throw null;
    }

    public void BitwiseOperators()
    {
        var e = new EventHelper("BitwiseOperators").Definition();
        e.Receiver();

        int dataA = BinaryLiteral(0b00000000000011111111111111111111);
        int dataB = BinaryLiteral(0b11111111111111111111000000000000);
        int portA = Reroute(dataA);

        ChipLib.Log($"Bitwise AND, pure data: {ChipLib.BitString(dataA & dataB)}");
        ChipLib.Log($"Bitwise AND, with ports: {ChipLib.BitString(portA & dataB)}");

        ChipLib.Log($"Bitwise OR, pure data: {ChipLib.BitString(dataA | dataB)}");
        ChipLib.Log($"Bitwise OR, with ports: {ChipLib.BitString(portA | dataB)}");

        ChipLib.Log($"Bitwise XOR, pure data: {ChipLib.BitString(dataA ^ dataB)}");
        ChipLib.Log($"Bitwise XOR, with ports: {ChipLib.BitString(portA ^ dataB)}");

        int dataC = BinaryLiteral(0b00000000000011111111000000000000);
        int portC = Reroute(dataC);

        ChipLib.Log($"Bit shift left, pure data: {ChipLib.BitString(dataC << 12)}");
        ChipLib.Log($"Bit shift left, with ports: {ChipLib.BitString(portC << 12)}");

        ChipLib.Log($"Bit shift right, pure data: {ChipLib.BitString(dataC >> 12)}");
        ChipLib.Log($"Bit shift right, with ports: {ChipLib.BitString(portC >> 12)}");

        int dataD = BinaryLiteral(0b_0000_1111_0000_1111_0000_1111_0000_1100);
        int portD = Reroute(dataD);

        ChipLib.Log($"Bitwise complement, pure data: {ChipLib.BitString(~dataD)}");
        ChipLib.Log($"Bitwise complement, with ports: {ChipLib.BitString(~portD)}");

        throw null;
    }

    unsafe int BinaryLiteral(uint literal)
    {
        return unchecked((int)literal);
    }
}