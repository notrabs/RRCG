using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            NativeIntOperators();
            NativeFloatOperators();
            PortIntOperators();
            PortFloatOperators();
            StringOperators();
            VectorOperators();
            MixedOperators();
            TernaryOperator();
            BitwiseOperators();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void NativeIntOperators()
        {
            __BeginReturnScope("NativeIntOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NativeIntOperators").Receiver();
                IntPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<IntPort>("nativeA", () => 1, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                IntPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<IntPort>("nativeB", () => 2, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
                IntPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<IntPort>("postIncrement", () => 0, () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
                IntPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<IntPort>("preIncrement", () => 0, () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
                IntPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<IntPort>("postDecrement", () => 0, () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
                IntPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<IntPort>("preDecrement", () => 0, () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void NativeFloatOperators()
        {
            __BeginReturnScope("NativeFloatOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("NativeFloatOperators").Receiver();
                FloatPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<FloatPort>("nativeA", () => 1, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                FloatPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<FloatPort>("nativeB", () => 2, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
                FloatPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<FloatPort>("postIncrement", () => 0, () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
                FloatPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<FloatPort>("preIncrement", () => 0, () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
                FloatPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<FloatPort>("postDecrement", () => 0, () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
                FloatPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<FloatPort>("preDecrement", () => 0, () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void PortIntOperators()
        {
            __BeginReturnScope("PortIntOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("PortIntOperators").Receiver();
                IntPort portA = default !;
                portA = __VariableDeclaratorExpression<IntPort>("portA", () => RandomInt(0, 0), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                IntPort portB = default !;
                portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(0, 0), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
                IntPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<IntPort>("postIncrement", () => RandomInt(0, 0), () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
                IntPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<IntPort>("preIncrement", () => RandomInt(0, 0), () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
                IntPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<IntPort>("postDecrement", () => RandomInt(0, 0), () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
                IntPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<IntPort>("preDecrement", () => RandomInt(0, 0), () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void PortFloatOperators()
        {
            __BeginReturnScope("PortFloatOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("PortFloatOperators").Receiver();
                FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                FloatPort portB = default !;
                portB = __VariableDeclaratorExpression<FloatPort>("portB", () => RandomFloat(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
                FloatPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<FloatPort>("postIncrement", () => RandomFloat(0, 0), () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
                FloatPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<FloatPort>("preIncrement", () => RandomFloat(0, 0), () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
                FloatPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<FloatPort>("postDecrement", () => RandomFloat(0, 0), () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
                FloatPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<FloatPort>("preDecrement", () => RandomFloat(0, 0), () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void StringOperators()
        {
            __BeginReturnScope("StringOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("StringOperators").Receiver();
            ChipLib.Log("a" + 1);
            ChipLib.Log("a" + 1f);
            ChipLib.Log(1 + "b");
            ChipLib.Log(1f + "b");
            ChipLib.Log("a" + "b");
                IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => RandomInt(1, 1), () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
                IntPort floatPort = default !;
                floatPort = __VariableDeclaratorExpression<IntPort>("floatPort", () => RandomInt(1, 1), () => floatPort!, (_RRCG_SETTER_VALUE) => floatPort = _RRCG_SETTER_VALUE);
                StringPort stringPort = default !;
                stringPort = __VariableDeclaratorExpression<StringPort>("stringPort", () => GetPlayerAccountName(PlayerPort.Local), () => stringPort!, (_RRCG_SETTER_VALUE) => stringPort = _RRCG_SETTER_VALUE);
            ChipLib.Log("a" + intPort);
            ChipLib.Log("a" + floatPort);
            ChipLib.Log("a" + stringPort);
            ChipLib.Log(intPort + "b");
            ChipLib.Log(floatPort + "b");
            ChipLib.Log(stringPort + "b");
            ChipLib.Log(stringPort + intPort);
            ChipLib.Log(stringPort + floatPort);
            ChipLib.Log(stringPort + stringPort);
            ChipLib.Log(intPort + stringPort);
            ChipLib.Log(floatPort + stringPort);
            ChipLib.Log(stringPort + stringPort);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void VectorOperators()
        {
            __BeginReturnScope("VectorOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("VectorOperators").Receiver();
                Vector3Port vectorA = default !;
                vectorA = __VariableDeclaratorExpression<Vector3Port>("vectorA", () => Vector3Create(1, 2, 3), () => vectorA!, (_RRCG_SETTER_VALUE) => vectorA = _RRCG_SETTER_VALUE);
                Vector3Port vectorB = default !;
                vectorB = __VariableDeclaratorExpression<Vector3Port>("vectorB", () => Vector3Create(4, 5, 6), () => vectorB!, (_RRCG_SETTER_VALUE) => vectorB = _RRCG_SETTER_VALUE);
                FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                IntPort portB = default !;
                portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
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
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void MixedOperators()
        {
            __BeginReturnScope("MixedOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("MixedOperators").Receiver();
                FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                IntPort portB = default !;
                portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
                FloatPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<FloatPort>("nativeA", () => 3, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                IntPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<IntPort>("nativeB", () => 4, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            ChipLib.Log(portA + portB * nativeA / nativeB);
            ChipLib.Log(portA + portB * 5);
            ChipLib.Log(portA * portB + 5);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void TernaryOperator()
        {
            __BeginReturnScope("TernaryOperator", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("TernaryOperator").Receiver();
                BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<BoolPort>("condition", () => Reroute<BoolPort>(true), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
                FloatPort dataA = default !;
                dataA = __VariableDeclaratorExpression<FloatPort>("dataA", () => 0, () => dataA!, (_RRCG_SETTER_VALUE) => dataA = _RRCG_SETTER_VALUE);
                FloatPort dataB = default !;
                dataB = __VariableDeclaratorExpression<FloatPort>("dataB", () => 1, () => dataB!, (_RRCG_SETTER_VALUE) => dataB = _RRCG_SETTER_VALUE);
            ChipLib.EventCache<FloatPort>(__Ternary<FloatPort>(condition, () => dataA, () => dataB));
                FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(0, 0), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                FloatPort portB = default !;
                portB = __VariableDeclaratorExpression<FloatPort>("portB", () => RandomFloat(1, 1), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            ChipLib.EventCache<FloatPort>(__Ternary<FloatPort>(condition, () => portA, () => portB));
            // Port / data
            ChipLib.EventCache<FloatPort>(__Ternary<FloatPort>(condition, () => portA, () => dataB));
            // Implicit conversions
            // Floats without -f suffix
            RandomFloat(0, __Ternary<FloatPort>(condition, () => 123, () => 456));
                IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => RandomInt(0, 0), () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
            RandomFloat(0, __Ternary<FloatPort>(condition, () => 1.5f, () => intPort));
            // Implicit conversion for result
            ChipLib.Log(__StringInterpolation("Result: ", (__Ternary<FloatPort>(condition, () => intPort, () => portA))));
            // Data condition
            // Will only evaluate the necessary branch
            ChipLib.VariableCache<FloatPort>(__Ternary<FloatPort>(true, () => RandomInt(0, 0), () => RandomFloat(0, 0)));
            ChipLib.VariableCache<FloatPort>(__Ternary<FloatPort>(false, () => RandomInt(0, 0), () => RandomFloat(0, 0)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void BitwiseOperators()
        {
            __BeginReturnScope("BitwiseOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("BitwiseOperators").Receiver();
                IntPort dataA = default !;
                dataA = __VariableDeclaratorExpression<IntPort>("dataA", () => BinaryLiteral(0b00000000000011111111111111111111), () => dataA!, (_RRCG_SETTER_VALUE) => dataA = _RRCG_SETTER_VALUE);
                IntPort dataB = default !;
                dataB = __VariableDeclaratorExpression<IntPort>("dataB", () => BinaryLiteral(0b11111111111111111111000000000000), () => dataB!, (_RRCG_SETTER_VALUE) => dataB = _RRCG_SETTER_VALUE);
                IntPort portA = default !;
                portA = __VariableDeclaratorExpression<IntPort>("portA", () => Reroute<IntPort>(dataA), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Bitwise AND, pure data: ", ChipLib.BitString(dataA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise AND, with ports: ", ChipLib.BitString(portA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, pure data: ", ChipLib.BitString(dataA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, with ports: ", ChipLib.BitString(portA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, pure data: ", ChipLib.BitString(dataA ^ dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, with ports: ", ChipLib.BitString(portA ^ dataB)));
                IntPort dataC = default !;
                dataC = __VariableDeclaratorExpression<IntPort>("dataC", () => BinaryLiteral(0b00000000000011111111000000000000), () => dataC!, (_RRCG_SETTER_VALUE) => dataC = _RRCG_SETTER_VALUE);
                IntPort portC = default !;
                portC = __VariableDeclaratorExpression<IntPort>("portC", () => Reroute<IntPort>(dataC), () => portC!, (_RRCG_SETTER_VALUE) => portC = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Bit shift left, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift left, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(portC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftRight(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftRight(portC, 12))));
                IntPort dataD = default !;
                dataD = __VariableDeclaratorExpression<IntPort>("dataD", () => BinaryLiteral(0b_0000_1111_0000_1111_0000_1111_0000_1100), () => dataD!, (_RRCG_SETTER_VALUE) => dataD = _RRCG_SETTER_VALUE);
                IntPort portD = default !;
                portD = __VariableDeclaratorExpression<IntPort>("portD", () => Reroute<IntPort>(dataD), () => portD!, (_RRCG_SETTER_VALUE) => portD = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Bitwise complement, pure data: ", ChipLib.BitString(~dataD)));
            ChipLib.Log(__StringInterpolation("Bitwise complement, with ports: ", ChipLib.BitString(~portD)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        unsafe int BinaryLiteral(uint literal)
        {
            return unchecked((int)literal);
        }
    }
}