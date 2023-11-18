using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
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
            __EndLabelAccessibilityScope();
        }

        public void NativeIntOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("NativeIntOperators").Definition());
            e.Receiver();
            IntPort nativeA = __VariableDeclaratorExpression("nativeA", () => 1);
            IntPort nativeB = __VariableDeclaratorExpression("nativeB", () => 2);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            IntPort postIncrement = __VariableDeclaratorExpression("postIncrement", () => 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = __VariableDeclaratorExpression("preIncrement", () => 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            IntPort postDecrement = __VariableDeclaratorExpression("postDecrement", () => 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = __VariableDeclaratorExpression("preDecrement", () => 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void NativeFloatOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("NativeFloatOperators").Definition());
            e.Receiver();
            FloatPort nativeA = __VariableDeclaratorExpression("nativeA", () => 1);
            FloatPort nativeB = __VariableDeclaratorExpression("nativeB", () => 2);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            FloatPort postIncrement = __VariableDeclaratorExpression("postIncrement", () => 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = __VariableDeclaratorExpression("preIncrement", () => 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            FloatPort postDecrement = __VariableDeclaratorExpression("postDecrement", () => 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = __VariableDeclaratorExpression("preDecrement", () => 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void PortIntOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("PortIntOperators").Definition());
            e.Receiver();
            IntPort portA = __VariableDeclaratorExpression("portA", () => RandomInt(0, 0));
            IntPort portB = __VariableDeclaratorExpression("portB", () => RandomInt(0, 0));
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            IntPort postIncrement = __VariableDeclaratorExpression("postIncrement", () => RandomInt(0, 0));
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = __VariableDeclaratorExpression("preIncrement", () => RandomInt(0, 0));
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            IntPort postDecrement = __VariableDeclaratorExpression("postDecrement", () => RandomInt(0, 0));
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = __VariableDeclaratorExpression("preDecrement", () => RandomInt(0, 0));
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void PortFloatOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("PortFloatOperators").Definition());
            e.Receiver();
            FloatPort portA = __VariableDeclaratorExpression("portA", () => RandomFloat(1, 1));
            FloatPort portB = __VariableDeclaratorExpression("portB", () => RandomFloat(2, 2));
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            FloatPort postIncrement = __VariableDeclaratorExpression("postIncrement", () => RandomFloat(0, 0));
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = __VariableDeclaratorExpression("preIncrement", () => RandomFloat(0, 0));
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            FloatPort postDecrement = __VariableDeclaratorExpression("postDecrement", () => RandomFloat(0, 0));
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = __VariableDeclaratorExpression("preDecrement", () => RandomFloat(0, 0));
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void VectorOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("VectorOperators").Definition());
            e.Receiver();
            Vector3Port vectorA = __VariableDeclaratorExpression("vectorA", () => Vector3Create(1, 2, 3));
            Vector3Port vectorB = __VariableDeclaratorExpression("vectorB", () => Vector3Create(4, 5, 6));
            FloatPort portA = __VariableDeclaratorExpression("portA", () => RandomFloat(1, 1));
            IntPort portB = __VariableDeclaratorExpression("portB", () => RandomInt(2, 2));
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
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void MixedOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("MixedOperators").Definition());
            e.Receiver();
            FloatPort portA = __VariableDeclaratorExpression("portA", () => RandomFloat(1, 1));
            IntPort portB = __VariableDeclaratorExpression("portB", () => RandomInt(2, 2));
            FloatPort nativeA = __VariableDeclaratorExpression("nativeA", () => 3);
            IntPort nativeB = __VariableDeclaratorExpression("nativeB", () => 4);
            ChipLib.Log(portA + portB * nativeA / nativeB);
            ChipLib.Log(portA + portB * 5);
            ChipLib.Log(portA * portB + 5);
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void TernaryOperator()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("TernaryOperator").Definition());
            e.Receiver();
            FloatPort dataA = __VariableDeclaratorExpression("dataA", () => 0);
            FloatPort dataB = __VariableDeclaratorExpression("dataB", () => 1);
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, dataA, dataB));
            FloatPort portA = __VariableDeclaratorExpression("portA", () => RandomFloat(0, 0));
            FloatPort portB = __VariableDeclaratorExpression("portB", () => RandomFloat(1, 1));
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, portA, portB));
            // Port / data
            ChipLib.EventCache(ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, portA, dataB));
            // Implicit conversions
            // Floats without -f suffix
            RandomFloat(0, ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, 123, 456));
            IntPort intPort = __VariableDeclaratorExpression("intPort", () => RandomInt(0, 0));
            RandomFloat(0, ChipBuilder.IfValue<RRCGBuild.FloatPort>(true, 1.5f, intPort));
            // Implicit conversion for result
            ChipLib.Log(__StringInterpolation("Result: ", (ChipBuilder.IfValue<RRCGBuild.FloatPort>(false, intPort, portA))));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void BitwiseOperators()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = __VariableDeclaratorExpression("e", () => new EventHelper("BitwiseOperators").Definition());
            e.Receiver();
            IntPort dataA = __VariableDeclaratorExpression("dataA", () => BinaryLiteral(0b00000000000011111111111111111111));
            IntPort dataB = __VariableDeclaratorExpression("dataB", () => BinaryLiteral(0b11111111111111111111000000000000));
            IntPort portA = __VariableDeclaratorExpression("portA", () => Reroute(dataA));
            ChipLib.Log(__StringInterpolation("Bitwise AND, pure data: ", ChipLib.BitString(dataA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise AND, with ports: ", ChipLib.BitString(portA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, pure data: ", ChipLib.BitString(dataA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, with ports: ", ChipLib.BitString(portA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, pure data: ", ChipLib.BitString(dataA ^ dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, with ports: ", ChipLib.BitString(portA ^ dataB)));
            IntPort dataC = __VariableDeclaratorExpression("dataC", () => BinaryLiteral(0b00000000000011111111000000000000));
            IntPort portC = __VariableDeclaratorExpression("portC", () => Reroute(dataC));
            ChipLib.Log(__StringInterpolation("Bit shift left, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift left, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(portC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftRight(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftRight(portC, 12))));
            IntPort dataD = __VariableDeclaratorExpression("dataD", () => BinaryLiteral(0b_0000_1111_0000_1111_0000_1111_0000_1100));
            IntPort portD = __VariableDeclaratorExpression("portD", () => Reroute(dataD));
            ChipLib.Log(__StringInterpolation("Bitwise complement, pure data: ", ChipLib.BitString(~dataD)));
            ChipLib.Log(__StringInterpolation("Bitwise complement, with ports: ", ChipLib.BitString(~portD)));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        int BinaryLiteral(uint literal)
        {
            return unchecked((int)literal);
        }
    }
}