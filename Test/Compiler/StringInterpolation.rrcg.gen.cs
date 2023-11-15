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
            InterpolatePureData();
            InterpolateDataWithPort();
            InterpolateNonStrings();
            ExecFlow.current.Merge(rrcg_return_flow);
        // maybe "value switch" pattern matching
        }

        void InterpolatePureData()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = new EventHelper("InterpolatePureData").Definition();
            e.Receiver();
            StringPort port1 = "Hello";
            StringPort port2 = "World";
            ChipLib.Log(__StringInterpolation(port1, ", ", port2, "!"));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateDataWithPort()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = new EventHelper("InterpolateDataWithPort").Definition();
            e.Receiver();
            var variable = new Variable<StringPort>();
            StringPort port1 = "data";
            variable.Value = "port";
            ChipLib.Log(__StringInterpolation("String interpolation works with both ", port1, " and ", variable.Value, "s!"));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void InterpolateNonStrings()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var e = new EventHelper("InterpolateNonStrings").Definition();
            e.Receiver();
            var intData = 5;
            var intPort = ParseInt("10").Result;
            ChipLib.Log(__StringInterpolation("Interpolating with ints. Data: ", intData, ", Port: ", intPort));
            var floatData = 5.25f;
            var floatPort = ParseInt("19.87").Result;
            ChipLib.Log(__StringInterpolation("Interpolating with floats. Data: ", floatData, ", Port: ", floatPort));
            var boolData = false;
            var boolPort = ParseBool("True").Result;
            ChipLib.Log(__StringInterpolation("Interpolating with bools. Data: ", boolData, ", Port: ", boolPort));
            var colorData = new ColorPort(1, 0, 0);
            var colorPort = ParseColor("#00FF00").Result;
            ChipLib.Log(__StringInterpolation("Interpolating with colors. Data: ", colorData, ", Port: ", colorPort));
            var vectorData = new Vector3Port(1, 2, 3);
            var vectorPort = Vector3Create(4, 5, 6);
            ChipLib.Log(__StringInterpolation("Interpolating with Vector3s. Data: ", vectorData, ", Port: ", vectorPort));
            var quatData = new QuaternionPort(1, 2, 3, 4);
            var quatPort = QuaternionCreate(5, 6, 7, 8);
            ChipLib.Log(__StringInterpolation("Interpolating with Quaternions. Data: ", quatData, ", Port: ", quatPort));
            ExecFlow.current.Clear();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}