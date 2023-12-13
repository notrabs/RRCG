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
            StringPort port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "Hello", (rrcg_setter_value) => port1 = rrcg_setter_value);
            StringPort port2 = __VariableDeclaratorExpression<StringPort>("port2", () => "World", (rrcg_setter_value) => port2 = rrcg_setter_value);
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
            RRCGBuild.Variable<StringPort> variable = __VariableDeclaratorExpression<RRCGBuild.Variable<StringPort>>("variable", () => new Variable<StringPort>(), (rrcg_setter_value) => variable = rrcg_setter_value);
            StringPort port1 = __VariableDeclaratorExpression<StringPort>("port1", () => "data", (rrcg_setter_value) => port1 = rrcg_setter_value);
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
            IntPort intData = __VariableDeclaratorExpression<IntPort>("intData", () => 5, (rrcg_setter_value) => intData = rrcg_setter_value);
            IntPort intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => ParseInt("10").Result, (rrcg_setter_value) => intPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
            FloatPort floatData = __VariableDeclaratorExpression<FloatPort>("floatData", () => 5.25f, (rrcg_setter_value) => floatData = rrcg_setter_value);
            IntPort floatPort = __VariableDeclaratorExpression<IntPort>("floatPort", () => ParseInt("19.87").Result, (rrcg_setter_value) => floatPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
            BoolPort boolData = __VariableDeclaratorExpression<BoolPort>("boolData", () => false, (rrcg_setter_value) => boolData = rrcg_setter_value);
            BoolPort boolPort = __VariableDeclaratorExpression<BoolPort>("boolPort", () => ParseBool("True").Result, (rrcg_setter_value) => boolPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
            ColorPort colorData = __VariableDeclaratorExpression<ColorPort>("colorData", () => new ColorPort(1, 0, 0), (rrcg_setter_value) => colorData = rrcg_setter_value);
            ColorPort colorPort = __VariableDeclaratorExpression<ColorPort>("colorPort", () => ParseColor("#00FF00").Result, (rrcg_setter_value) => colorPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
            Vector3Port vectorData = __VariableDeclaratorExpression<Vector3Port>("vectorData", () => new Vector3Port(1, 2, 3), (rrcg_setter_value) => vectorData = rrcg_setter_value);
            Vector3Port vectorPort = __VariableDeclaratorExpression<Vector3Port>("vectorPort", () => Vector3Create(4, 5, 6), (rrcg_setter_value) => vectorPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
            QuaternionPort quatData = __VariableDeclaratorExpression<QuaternionPort>("quatData", () => new QuaternionPort(1, 2, 3, 4), (rrcg_setter_value) => quatData = rrcg_setter_value);
            QuaternionPort quatPort = __VariableDeclaratorExpression<QuaternionPort>("quatPort", () => QuaternionCreate(5, 6, 7, 8), (rrcg_setter_value) => quatPort = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}