using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            NativeIntOperators();
            NativeFloatOperators();
            PortIntOperators();
            PortFloatOperators();
            VectorOperators();
            MixedOperators();
            TernaryOperator();
            BitwiseOperators();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            IntPort nativeA = 1;
            IntPort nativeB = 2;
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            IntPort postIncrement = 0;
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = 0;
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            IntPort postDecrement = 0;
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = 0;
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort nativeA = 1;
            FloatPort nativeB = 2;
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            FloatPort postIncrement = 0;
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = 0;
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            FloatPort postDecrement = 0;
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = 0;
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            IntPort portA = RandomInt(0, 0);
            IntPort portB = RandomInt(0, 0);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            IntPort postIncrement = RandomInt(0, 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = RandomInt(0, 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            IntPort postDecrement = RandomInt(0, 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = RandomInt(0, 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort portA = RandomFloat(1, 1);
            FloatPort portB = RandomFloat(2, 2);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            FloatPort postIncrement = RandomFloat(0, 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = RandomFloat(0, 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            FloatPort postDecrement = RandomFloat(0, 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = RandomFloat(0, 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VectorOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            Vector3Port vectorA = Vector3Create(1, 2, 3);
            Vector3Port vectorB = Vector3Create(4, 5, 6);
            FloatPort portA = RandomFloat(1, 1);
            IntPort portB = RandomInt(2, 2);
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
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void MixedOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort portA = RandomFloat(1, 1);
            IntPort portB = RandomInt(2, 2);
            FloatPort nativeA = 3;
            IntPort nativeB = 4;
            ChipLib.Log(portA + portB * nativeA / nativeB);
            ChipLib.Log(portA + portB * 5);
            ChipLib.Log(portA * portB + 5);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void TernaryOperator()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort dataA = 0;
            FloatPort dataB = 1;
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, dataA, dataB));
            FloatPort portA = RandomFloat(0, 0);
            FloatPort portB = RandomFloat(1, 1);
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, portA, portB));
            // Port / data
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, portA, dataB));
            // Implicit conversions
            // Floats without -f suffix
            RandomFloat(0, ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, 123, 456));
            IntPort intPort = RandomInt(0, 0);
            RandomFloat(0, ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, 1.5f, intPort));
            // Implicit conversion for result
            ChipLib.Log(__StringInterpolation("Result: ", (ChipBuilder.IfValue<RRCGBuild.FloatPort>(false, intPort, portA))));
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void BitwiseOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            IntPort dataA = BinaryLiteral(0b00000000000011111111111111111111);
            IntPort dataB = BinaryLiteral(0b11111111111111111111000000000000);
            IntPort portA = Reroute(dataA);
            ChipLib.Log(__StringInterpolation("Bitwise AND, pure data: ", ChipLib.BitString(dataA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise AND, with ports: ", ChipLib.BitString(portA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, pure data: ", ChipLib.BitString(dataA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, with ports: ", ChipLib.BitString(portA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, pure data: ", ChipLib.BitString(dataA ^ dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, with ports: ", ChipLib.BitString(portA ^ dataB)));
            IntPort dataC = BinaryLiteral(0b00000000000011111111000000000000);
            IntPort portC = Reroute(dataC);
            ChipLib.Log(__StringInterpolation("Bit shift left, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift left, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(portC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftRight(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftRight(portC, 12))));
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        int BinaryLiteral(uint literal)
        {
            return unchecked((int)literal);
        }
    }
}