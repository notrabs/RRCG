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
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            InterpolatePureData();
            InterpolateDataWithPort();
            InterpolateNonStrings();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolatePureData()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("InterpolatePureData").Receiver();
            StringPort port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "Hello", (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
            StringPort port2 = __VariableDeclaratorExpression<StringPort>("port2", () => "World", (_RRCG_SETTER_VALUE) => port2 = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation(port1, ", ", port2, "!"));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateDataWithPort()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("InterpolateDataWithPort").Receiver();
            RRCGBuild.Variable<StringPort> variable = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("variable", () => new Variable<StringPort>(), (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
            StringPort port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "data", (_RRCG_SETTER_VALUE) => port1 = _RRCG_SETTER_VALUE);
            variable.Value = "port";
            ChipLib.Log(__StringInterpolation("String interpolation works with both ", port1, " and ", variable.Value, "s!"));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateNonStrings()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("InterpolateNonStrings").Receiver();
            IntPort intData = __VariableDeclaratorExpression<IntPort>("intData", () => 5, (_RRCG_SETTER_VALUE) => intData = _RRCG_SETTER_VALUE);
            IntPort intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => ParseInt("10").Result, (_RRCG_SETTER_VALUE) => intPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
            FloatPort floatData = __VariableDeclaratorExpression<FloatPort>("floatData", () => 5.25f, (_RRCG_SETTER_VALUE) => floatData = _RRCG_SETTER_VALUE);
            IntPort floatPort = __VariableDeclaratorExpression<IntPort>("floatPort", () => ParseInt("19.87").Result, (_RRCG_SETTER_VALUE) => floatPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
            BoolPort boolData = __VariableDeclaratorExpression<BoolPort>("boolData", () => false, (_RRCG_SETTER_VALUE) => boolData = _RRCG_SETTER_VALUE);
            BoolPort boolPort = __VariableDeclaratorExpression<BoolPort>("boolPort", () => ParseBool("True").Result, (_RRCG_SETTER_VALUE) => boolPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
            ColorPort colorData = __VariableDeclaratorExpression<ColorPort>("colorData", () => new ColorPort(1, 0, 0), (_RRCG_SETTER_VALUE) => colorData = _RRCG_SETTER_VALUE);
            ColorPort colorPort = __VariableDeclaratorExpression<ColorPort>("colorPort", () => ParseColor("#00FF00").Result, (_RRCG_SETTER_VALUE) => colorPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
            Vector3Port vectorData = __VariableDeclaratorExpression<Vector3Port>("vectorData", () => new Vector3Port(1, 2, 3), (_RRCG_SETTER_VALUE) => vectorData = _RRCG_SETTER_VALUE);
            Vector3Port vectorPort = __VariableDeclaratorExpression<Vector3Port>("vectorPort", () => Vector3Create(4, 5, 6), (_RRCG_SETTER_VALUE) => vectorPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
            QuaternionPort quatData = __VariableDeclaratorExpression<QuaternionPort>("quatData", () => new QuaternionPort(1, 2, 3, 4), (_RRCG_SETTER_VALUE) => quatData = _RRCG_SETTER_VALUE);
            QuaternionPort quatPort = __VariableDeclaratorExpression<QuaternionPort>("quatPort", () => QuaternionCreate(5, 6, 7, 8), (_RRCG_SETTER_VALUE) => quatPort = _RRCG_SETTER_VALUE);
            ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}