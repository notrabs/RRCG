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
            __BeginLabelAccessibilityScope(false);
            InterpolatePureData();
            InterpolateDataWithPort();
            InterpolateNonStrings();
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolatePureData()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            new EventDefinition("InterpolatePureData").Receiver();
            StringPort port1 = __VariableDeclaratorExpression("port1", () => "Hello");
            StringPort port2 = __VariableDeclaratorExpression("port2", () => "World");
            ChipLib.Log(__StringInterpolation(port1, ", ", port2, "!"));
            ExecFlow.current.Clear();
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateDataWithPort()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            new EventDefinition("InterpolateDataWithPort").Receiver();
            var variable = __VariableDeclaratorExpression("variable", () => new Variable<StringPort>());
            StringPort port1 = __VariableDeclaratorExpression("port1", () => "data");
            variable.Value = "port";
            ChipLib.Log(__StringInterpolation("String interpolation works with both ", port1, " and ", variable.Value, "s!"));
            ExecFlow.current.Clear();
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateNonStrings()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginLabelAccessibilityScope(false);
            new EventDefinition("InterpolateNonStrings").Receiver();
            var intData = __VariableDeclaratorExpression("intData", () => 5);
            var intPort = __VariableDeclaratorExpression("intPort", () => ParseInt("10").Result);
            ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
            var floatData = __VariableDeclaratorExpression("floatData", () => 5.25f);
            var floatPort = __VariableDeclaratorExpression("floatPort", () => ParseInt("19.87").Result);
            ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
            var boolData = __VariableDeclaratorExpression("boolData", () => false);
            var boolPort = __VariableDeclaratorExpression("boolPort", () => ParseBool("True").Result);
            ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
            var colorData = __VariableDeclaratorExpression("colorData", () => new ColorPort(1, 0, 0));
            var colorPort = __VariableDeclaratorExpression("colorPort", () => ParseColor("#00FF00").Result);
            ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
            var vectorData = __VariableDeclaratorExpression("vectorData", () => new Vector3Port(1, 2, 3));
            var vectorPort = __VariableDeclaratorExpression("vectorPort", () => Vector3Create(4, 5, 6));
            ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
            var quatData = __VariableDeclaratorExpression("quatData", () => new QuaternionPort(1, 2, 3, 4));
            var quatPort = __VariableDeclaratorExpression("quatPort", () => QuaternionCreate(5, 6, 7, 8));
            ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            ExecFlow.current.Clear();
            __EndLabelAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}