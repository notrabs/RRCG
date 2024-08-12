using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class StringInterpolation : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            InterpolatePureData();
            InterpolateDataWithPort();
            InterpolateNonStrings();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InterpolatePureData()
        {
            __BeginReturnScope("InterpolatePureData", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("InterpolatePureData").Receiver();
                StringPort port1 = default !;
                port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "Hello", () => port1!, (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
                StringPort port2 = default !;
                port2 = __VariableDeclaratorExpression<StringPort>("port2", () => "World", () => port2!, (_RRCG_SETTER_VALUE) => port2 = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation(port1, ", ", port2, "!"));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InterpolateDataWithPort()
        {
            __BeginReturnScope("InterpolateDataWithPort", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("InterpolateDataWithPort").Receiver();
                RRCGBuild.Variable<StringPort> variable = default !;
                variable = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("variable", () => new Variable<StringPort>(), () => variable!, (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
                StringPort port1 = default !;
                port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "data", () => port1!, (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
            variable.Value = "port";
            ChipLib.Log(__StringInterpolation("String interpolation works with both ", port1, " and ", variable.Value, "s!"));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InterpolateNonStrings()
        {
            __BeginReturnScope("InterpolateNonStrings", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("InterpolateNonStrings").Receiver();
                IntPort intData = default !;
                intData = __VariableDeclaratorExpression<IntPort>("intData", () => 5, () => intData!, (_RRCG_SETTER_VALUE) => intData = _RRCG_SETTER_VALUE);
                IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => ParseInt("10").Result, () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
                FloatPort floatData = default !;
                floatData = __VariableDeclaratorExpression<FloatPort>("floatData", () => 5.25f, () => floatData!, (_RRCG_SETTER_VALUE) => floatData = _RRCG_SETTER_VALUE);
                IntPort floatPort = default !;
                floatPort = __VariableDeclaratorExpression<IntPort>("floatPort", () => ParseInt("19.87").Result, () => floatPort!, (_RRCG_SETTER_VALUE) => floatPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
                BoolPort boolData = default !;
                boolData = __VariableDeclaratorExpression<BoolPort>("boolData", () => false, () => boolData!, (_RRCG_SETTER_VALUE) => boolData = _RRCG_SETTER_VALUE);
                BoolPort boolPort = default !;
                boolPort = __VariableDeclaratorExpression<BoolPort>("boolPort", () => ParseBool("True").Result, () => boolPort!, (_RRCG_SETTER_VALUE) => boolPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
                ColorPort colorData = default !;
                colorData = __VariableDeclaratorExpression<ColorPort>("colorData", () => new ColorPort(1, 0, 0), () => colorData!, (_RRCG_SETTER_VALUE) => colorData = _RRCG_SETTER_VALUE);
                ColorPort colorPort = default !;
                colorPort = __VariableDeclaratorExpression<ColorPort>("colorPort", () => ParseColor("#00FF00").Result, () => colorPort!, (_RRCG_SETTER_VALUE) => colorPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
                Vector3Port vectorData = default !;
                vectorData = __VariableDeclaratorExpression<Vector3Port>("vectorData", () => new Vector3Port(1, 2, 3), () => vectorData!, (_RRCG_SETTER_VALUE) => vectorData = _RRCG_SETTER_VALUE);
                Vector3Port vectorPort = default !;
                vectorPort = __VariableDeclaratorExpression<Vector3Port>("vectorPort", () => Vector3Create(4, 5, 6), () => vectorPort!, (_RRCG_SETTER_VALUE) => vectorPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
                QuaternionPort quatData = default !;
                quatData = __VariableDeclaratorExpression<QuaternionPort>("quatData", () => new QuaternionPort(1, 2, 3, 4), () => quatData!, (_RRCG_SETTER_VALUE) => quatData = _RRCG_SETTER_VALUE);
                QuaternionPort quatPort = default !;
                quatPort = __VariableDeclaratorExpression<QuaternionPort>("quatPort", () => QuaternionCreate(5, 6, 7, 8), () => quatPort!, (_RRCG_SETTER_VALUE) => quatPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}