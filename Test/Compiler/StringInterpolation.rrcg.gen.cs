using RRCG;
using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class StringInterpolation : RRCGBuild.CircuitBuilder
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
            new RRCGBuild.EventDefinition("InterpolatePureData").Receiver();
                RRCGBuild.StringPort port1 = default !;
                port1 = __VariableDeclaratorExpression<RRCGBuild.StringPort>("port1", () => "Hello", () => port1!, (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort port2 = default !;
                port2 = __VariableDeclaratorExpression<RRCGBuild.StringPort>("port2", () => "World", () => port2!, (_RRCG_SETTER_VALUE) => port2 = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation(port1, ", ", port2, "!"));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InterpolateDataWithPort()
        {
            __BeginReturnScope("InterpolateDataWithPort", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("InterpolateDataWithPort").Receiver();
                RRCGBuild.Variable<RRCGBuild.StringPort> variable = default !;
                variable = __VariableDeclaratorExpression<RRCGBuild.Variable<RRCGBuild.StringPort>>("variable", () => new RRCGBuild.Variable<RRCGBuild.StringPort>(), () => variable!, (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort port1 = default !;
                port1 = __VariableDeclaratorExpression<RRCGBuild.StringPort>("port1", () => "data", () => port1!, (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
            variable.Value = "port";
            RRCGBuild.ChipLib.Log(__StringInterpolation("String interpolation works with both ", port1, " and ", variable.Value, "s!"));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void InterpolateNonStrings()
        {
            __BeginReturnScope("InterpolateNonStrings", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new RRCGBuild.EventDefinition("InterpolateNonStrings").Receiver();
                RRCGBuild.IntPort intData = default !;
                intData = __VariableDeclaratorExpression<RRCGBuild.IntPort>("intData", () => 5, () => intData!, (_RRCG_SETTER_VALUE) => intData = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort intPort = default !;
                intPort = __VariableDeclaratorExpression<RRCGBuild.IntPort>("intPort", () => ParseInt("10").Result, () => intPort!, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
                RRCGBuild.FloatPort floatData = default !;
                floatData = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("floatData", () => 5.25f, () => floatData!, (_RRCG_SETTER_VALUE) => floatData = _RRCG_SETTER_VALUE);
                RRCGBuild.IntPort floatPort = default !;
                floatPort = __VariableDeclaratorExpression<RRCGBuild.IntPort>("floatPort", () => ParseInt("19.87").Result, () => floatPort!, (_RRCG_SETTER_VALUE) => floatPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
                RRCGBuild.BoolPort boolData = default !;
                boolData = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("boolData", () => false, () => boolData!, (_RRCG_SETTER_VALUE) => boolData = _RRCG_SETTER_VALUE);
                RRCGBuild.BoolPort boolPort = default !;
                boolPort = __VariableDeclaratorExpression<RRCGBuild.BoolPort>("boolPort", () => ParseBool("True").Result, () => boolPort!, (_RRCG_SETTER_VALUE) => boolPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
                RRCGBuild.ColorPort colorData = default !;
                colorData = __VariableDeclaratorExpression<RRCGBuild.ColorPort>("colorData", () => new RRCGBuild.ColorPort(1, 0, 0), () => colorData!, (_RRCG_SETTER_VALUE) => colorData = _RRCG_SETTER_VALUE);
                RRCGBuild.ColorPort colorPort = default !;
                colorPort = __VariableDeclaratorExpression<RRCGBuild.ColorPort>("colorPort", () => ParseColor("#00FF00").Result, () => colorPort!, (_RRCG_SETTER_VALUE) => colorPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
                RRCGBuild.Vector3Port vectorData = default !;
                vectorData = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("vectorData", () => new RRCGBuild.Vector3Port(1, 2, 3), () => vectorData!, (_RRCG_SETTER_VALUE) => vectorData = _RRCG_SETTER_VALUE);
                RRCGBuild.Vector3Port vectorPort = default !;
                vectorPort = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("vectorPort", () => Vector3Create(4, 5, 6), () => vectorPort!, (_RRCG_SETTER_VALUE) => vectorPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
                RRCGBuild.QuaternionPort quatData = default !;
                quatData = __VariableDeclaratorExpression<RRCGBuild.QuaternionPort>("quatData", () => new RRCGBuild.QuaternionPort(1, 2, 3, 4), () => quatData!, (_RRCG_SETTER_VALUE) => quatData = _RRCG_SETTER_VALUE);
                RRCGBuild.QuaternionPort quatPort = default !;
                quatPort = __VariableDeclaratorExpression<RRCGBuild.QuaternionPort>("quatPort", () => QuaternionCreate(5, 6, 7, 8), () => quatPort!, (_RRCG_SETTER_VALUE) => quatPort = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            __Throw();
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}