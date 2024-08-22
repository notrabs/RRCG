using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : RRCGBuild.CircuitBuilder
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
            new RRCGBuild.EventDefinition("NativeIntOperators").Receiver();
                RRCGBuild.IntPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<RRCGBuild.IntPort>("nativeA", () => 1, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("nativeB", () => 2, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(nativeA + nativeB);
            RRCGBuild.ChipLib.Log(nativeA - nativeB);
            RRCGBuild.ChipLib.Log(nativeA * nativeB);
            RRCGBuild.ChipLib.Log(nativeA / nativeB);
            RRCGBuild.ChipLib.Log(nativeA % nativeB);
                RRCGBuild.IntPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("postIncrement", () => 0, () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postIncrement++);
            RRCGBuild.ChipLib.Log(postIncrement);
                RRCGBuild.IntPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("preIncrement", () => 0, () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(++preIncrement);
            RRCGBuild.ChipLib.Log(++preIncrement);
                RRCGBuild.IntPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("postDecrement", () => 0, () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postDecrement--);
            RRCGBuild.ChipLib.Log(postDecrement);
                RRCGBuild.IntPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("preDecrement", () => 0, () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(--preDecrement);
            RRCGBuild.ChipLib.Log(preDecrement);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void NativeFloatOperators()
        {
            __BeginReturnScope("NativeFloatOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("NativeFloatOperators").Receiver();
                RRCGBuild.FloatPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("nativeA", () => 1, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("nativeB", () => 2, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(nativeA + nativeB);
            RRCGBuild.ChipLib.Log(nativeA - nativeB);
            RRCGBuild.ChipLib.Log(nativeA * nativeB);
            RRCGBuild.ChipLib.Log(nativeA / nativeB);
            RRCGBuild.ChipLib.Log(nativeA % nativeB);
                RRCGBuild.FloatPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("postIncrement", () => 0, () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postIncrement++);
            RRCGBuild.ChipLib.Log(postIncrement);
                RRCGBuild.FloatPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("preIncrement", () => 0, () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(++preIncrement);
            RRCGBuild.ChipLib.Log(++preIncrement);
                RRCGBuild.FloatPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("postDecrement", () => 0, () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postDecrement--);
            RRCGBuild.ChipLib.Log(postDecrement);
                RRCGBuild.FloatPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("preDecrement", () => 0, () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(--preDecrement);
            RRCGBuild.ChipLib.Log(preDecrement);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void PortIntOperators()
        {
            __BeginReturnScope("PortIntOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("PortIntOperators").Receiver();
                RRCGBuild.IntPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portA", () => RandomInt(0, 0), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portB = default !;
                portB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portB", () => RandomInt(0, 0), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(portA + portB);
            RRCGBuild.ChipLib.Log(portA - portB);
            RRCGBuild.ChipLib.Log(portA * portB);
            RRCGBuild.ChipLib.Log(portA / portB);
            RRCGBuild.ChipLib.Log(portA % portB);
                RRCGBuild.IntPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("postIncrement", () => RandomInt(0, 0), () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postIncrement++);
            RRCGBuild.ChipLib.Log(postIncrement);
                RRCGBuild.IntPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("preIncrement", () => RandomInt(0, 0), () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(++preIncrement);
            RRCGBuild.ChipLib.Log(preIncrement);
                RRCGBuild.IntPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("postDecrement", () => RandomInt(0, 0), () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postDecrement--);
            RRCGBuild.ChipLib.Log(postDecrement);
                RRCGBuild.IntPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<RRCGBuild.IntPort>("preDecrement", () => RandomInt(0, 0), () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(--preDecrement);
            RRCGBuild.ChipLib.Log(preDecrement);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void PortFloatOperators()
        {
            __BeginReturnScope("PortFloatOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("PortFloatOperators").Receiver();
                RRCGBuild.FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort portB = default !;
                portB = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portB", () => RandomFloat(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(portA + portB);
            RRCGBuild.ChipLib.Log(portA - portB);
            RRCGBuild.ChipLib.Log(portA * portB);
            RRCGBuild.ChipLib.Log(portA / portB);
            RRCGBuild.ChipLib.Log(portA % portB);
                RRCGBuild.FloatPort postIncrement = default !;
                postIncrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("postIncrement", () => RandomFloat(0, 0), () => postIncrement!, (_RRCG_SETTER_VALUE) => postIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postIncrement++);
            RRCGBuild.ChipLib.Log(postIncrement);
                RRCGBuild.FloatPort preIncrement = default !;
                preIncrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("preIncrement", () => RandomFloat(0, 0), () => preIncrement!, (_RRCG_SETTER_VALUE) => preIncrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(++preIncrement);
            RRCGBuild.ChipLib.Log(preIncrement);
                RRCGBuild.FloatPort postDecrement = default !;
                postDecrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("postDecrement", () => RandomFloat(0, 0), () => postDecrement!, (_RRCG_SETTER_VALUE) => postDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(postDecrement--);
            RRCGBuild.ChipLib.Log(postDecrement);
                RRCGBuild.FloatPort preDecrement = default !;
                preDecrement = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("preDecrement", () => RandomFloat(0, 0), () => preDecrement!, (_RRCG_SETTER_VALUE) => preDecrement = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(--preDecrement);
            RRCGBuild.ChipLib.Log(preDecrement);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void StringOperators()
        {
            __BeginReturnScope("StringOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("StringOperators").Receiver();
            RRCGBuild.ChipLib.Log("a" + 1);
            RRCGBuild.ChipLib.Log("a" + 1f);
            RRCGBuild.ChipLib.Log(1 + "b");
            RRCGBuild.ChipLib.Log(1f + "b");
            RRCGBuild.ChipLib.Log("a" + "b");
                RRCGBuild.IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<RRCGBuild.IntPort>("intPort", () => RandomInt(1, 1), () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort floatPort = default !;
                floatPort = __VariableDeclaratorExpression<RRCGBuild.IntPort>("floatPort", () => RandomInt(1, 1), () => floatPort!, (_RRCG_SETTER_VALUE) => floatPort = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort stringPort = default !;
                stringPort = __VariableDeclaratorExpression<RRCGBuild.StringPort>("stringPort", () => GetPlayerAccountName(RRCGBuild.PlayerPort.Local), () => stringPort!, (_RRCG_SETTER_VALUE) => stringPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log("a" + intPort);
            RRCGBuild.ChipLib.Log("a" + floatPort);
            RRCGBuild.ChipLib.Log("a" + stringPort);
            RRCGBuild.ChipLib.Log(intPort + "b");
            RRCGBuild.ChipLib.Log(floatPort + "b");
            RRCGBuild.ChipLib.Log(stringPort + "b");
            RRCGBuild.ChipLib.Log(stringPort + intPort);
            RRCGBuild.ChipLib.Log(stringPort + floatPort);
            RRCGBuild.ChipLib.Log(stringPort + stringPort);
            RRCGBuild.ChipLib.Log(intPort + stringPort);
            RRCGBuild.ChipLib.Log(floatPort + stringPort);
            RRCGBuild.ChipLib.Log(stringPort + stringPort);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void VectorOperators()
        {
            __BeginReturnScope("VectorOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("VectorOperators").Receiver();
                RRCGBuild.Vector3Port vectorA = default !;
                vectorA = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("vectorA", () => Vector3Create(1, 2, 3), () => vectorA!, (_RRCG_SETTER_VALUE) => vectorA = _RRCG_SETTER_VALUE);
                RRCGBuild.Vector3Port vectorB = default !;
                vectorB = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("vectorB", () => Vector3Create(4, 5, 6), () => vectorB!, (_RRCG_SETTER_VALUE) => vectorB = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portB = default !;
                portB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portB", () => RandomInt(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(vectorA + vectorB);
            RRCGBuild.ChipLib.Log(vectorA - vectorB);
            RRCGBuild.ChipLib.Log(vectorA * portA);
            RRCGBuild.ChipLib.Log(vectorB * portB);
            RRCGBuild.ChipLib.Log(portA * vectorA);
            RRCGBuild.ChipLib.Log(portB * vectorB);
            RRCGBuild.ChipLib.Log(vectorA / portA);
            RRCGBuild.ChipLib.Log(vectorB / portB);
            RRCGBuild.ChipLib.Log(vectorA * 5f);
            RRCGBuild.ChipLib.Log(vectorA * 6);
            RRCGBuild.ChipLib.Log(7f * vectorB);
            RRCGBuild.ChipLib.Log(8 * vectorB);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void MixedOperators()
        {
            __BeginReturnScope("MixedOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("MixedOperators").Receiver();
                RRCGBuild.FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portA", () => RandomFloat(1, 1), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portB = default !;
                portB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portB", () => RandomInt(2, 2), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort nativeA = default !;
                nativeA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("nativeA", () => 3, () => nativeA!, (_RRCG_SETTER_VALUE) => nativeA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort nativeB = default !;
                nativeB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("nativeB", () => 4, () => nativeB!, (_RRCG_SETTER_VALUE) => nativeB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(portA + portB * nativeA / nativeB);
            RRCGBuild.ChipLib.Log(portA + portB * 5);
            RRCGBuild.ChipLib.Log(portA * portB + 5);
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void TernaryOperator()
        {
            __BeginReturnScope("TernaryOperator", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("TernaryOperator").Receiver();
                RRCGBuild.BoolPort condition = default !;
                condition = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("condition", () => Reroute<RRCGBuild.BoolPort>(true), () => condition!, (_RRCG_SETTER_VALUE) => condition = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort dataA = default !;
                dataA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("dataA", () => 0, () => dataA!, (_RRCG_SETTER_VALUE) => dataA = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort dataB = default !;
                dataB = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("dataB", () => 1, () => dataB!, (_RRCG_SETTER_VALUE) => dataB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.EventCache<RRCGBuild.FloatPort>(__Ternary<RRCGBuild.FloatPort>(condition, () => dataA, () => dataB));
                RRCGBuild.FloatPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portA", () => RandomFloat(0, 0), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort portB = default !;
                portB = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("portB", () => RandomFloat(1, 1), () => portB!, (_RRCG_SETTER_VALUE) => portB = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.EventCache<RRCGBuild.FloatPort>(__Ternary<RRCGBuild.FloatPort>(condition, () => portA, () => portB));
            RRCGBuild.ChipLib.EventCache<RRCGBuild.FloatPort>(__Ternary<RRCGBuild.FloatPort>(condition, () => portA, () => dataB));
            // Implicit conversions
            // Floats without -f suffix
            RandomFloat(0, __Ternary<RRCGBuild.FloatPort>(condition, () => 123, () => 456));
                RRCGBuild.IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<RRCGBuild.IntPort>("intPort", () => RandomInt(0, 0), () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
            RandomFloat(0, __Ternary<RRCGBuild.FloatPort>(condition, () => 1.5f, () => intPort));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Result: ", (__Ternary<RRCGBuild.FloatPort>(condition, () => intPort, () => portA))));
            RRCGBuild.ChipLib.VariableCache<RRCGBuild.FloatPort>(__Ternary<RRCGBuild.FloatPort>(true, () => RandomInt(0, 0), () => RandomFloat(0, 0)));
            RRCGBuild.ChipLib.VariableCache<RRCGBuild.FloatPort>(__Ternary<RRCGBuild.FloatPort>(false, () => RandomInt(0, 0), () => RandomFloat(0, 0)));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void BitwiseOperators()
        {
            __BeginReturnScope("BitwiseOperators", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("BitwiseOperators").Receiver();
                RRCGBuild.IntPort dataA = default !;
                dataA = __VariableDeclaratorExpression<RRCGBuild.IntPort>("dataA", () => BinaryLiteral(0b00000000000011111111111111111111), () => dataA!, (_RRCG_SETTER_VALUE) => dataA = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort dataB = default !;
                dataB = __VariableDeclaratorExpression<RRCGBuild.IntPort>("dataB", () => BinaryLiteral(0b11111111111111111111000000000000), () => dataB!, (_RRCG_SETTER_VALUE) => dataB = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portA = default !;
                portA = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portA", () => Reroute<RRCGBuild.IntPort>(dataA), () => portA!, (_RRCG_SETTER_VALUE) => portA = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise AND, pure data: ", RRCGBuild.ChipLib.BitString(dataA & dataB)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise AND, with ports: ", RRCGBuild.ChipLib.BitString(portA & dataB)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise OR, pure data: ", RRCGBuild.ChipLib.BitString(dataA | dataB)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise OR, with ports: ", RRCGBuild.ChipLib.BitString(portA | dataB)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise XOR, pure data: ", RRCGBuild.ChipLib.BitString(dataA ^ dataB)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise XOR, with ports: ", RRCGBuild.ChipLib.BitString(portA ^ dataB)));
                RRCGBuild.IntPort dataC = default !;
                dataC = __VariableDeclaratorExpression<RRCGBuild.IntPort>("dataC", () => BinaryLiteral(0b00000000000011111111000000000000), () => dataC!, (_RRCG_SETTER_VALUE) => dataC = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portC = default !;
                portC = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portC", () => Reroute<RRCGBuild.IntPort>(dataC), () => portC!, (_RRCG_SETTER_VALUE) => portC = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bit shift left, pure data: ", RRCGBuild.ChipLib.BitString(ChipBuilder.BitShiftLeft(dataC, 12))));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bit shift left, with ports: ", RRCGBuild.ChipLib.BitString(ChipBuilder.BitShiftLeft(portC, 12))));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bit shift right, pure data: ", RRCGBuild.ChipLib.BitString(ChipBuilder.BitShiftRight(dataC, 12))));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bit shift right, with ports: ", RRCGBuild.ChipLib.BitString(ChipBuilder.BitShiftRight(portC, 12))));
                RRCGBuild.IntPort dataD = default !;
                dataD = __VariableDeclaratorExpression<RRCGBuild.IntPort>("dataD", () => BinaryLiteral(0b_0000_1111_0000_1111_0000_1111_0000_1100), () => dataD!, (_RRCG_SETTER_VALUE) => dataD = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort portD = default !;
                portD = __VariableDeclaratorExpression<RRCGBuild.IntPort>("portD", () => Reroute<RRCGBuild.IntPort>(dataD), () => portD!, (_RRCG_SETTER_VALUE) => portD = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise complement, pure data: ", RRCGBuild.ChipLib.BitString(~dataD)));
            RRCGBuild.ChipLib.Log(__StringInterpolation("Bitwise complement, with ports: ", RRCGBuild.ChipLib.BitString(~portD)));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        unsafe int BinaryLiteral(uint literal)
        {
            return unchecked((int)literal);
        }
    }
}