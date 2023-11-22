using RRCG;
using RRCGSource;
using UnityEngine;

public class StringInterpolation : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        InterpolatePureData();

        InterpolateDataWithPort();

        InterpolateNonStrings();

        // maybe "value switch" pattern matching
    }

    void InterpolatePureData()
    {
        new EventDefinition("InterpolatePureData").Receiver();

        string port1 = "Hello";
        string port2 = "World";

        ChipLib.Log($"{port1}, {port2}!");
        throw null;
    }

    void InterpolateDataWithPort()
    {
        new EventDefinition("InterpolateDataWithPort").Receiver();

        var variable = new Variable<string>();
        string port1 = "data";
        variable.Value = "port";

        ChipLib.Log($"String interpolation works with both {port1} and {variable.Value}s!");
        throw null;
    }

    void InterpolateNonStrings()
    {
        new EventDefinition("InterpolateNonStrings").Receiver();

        var intData = 5;
        var intPort = ParseInt("10").Result;
        ChipLib.Log($"Interpolating with ints. Data: {intData}, Port: {intPort}");

        var floatData = 5.25f;
        var floatPort = ParseInt("19.87").Result;
        ChipLib.Log($"Interpolating with floats. Data: {floatData}, Port: {floatPort}");

        var boolData = false;
        var boolPort = ParseBool("True").Result;
        ChipLib.Log($"Interpolating with bools. Data: {boolData}, Port: {boolPort}");

        var colorData = new Color(1, 0, 0);
        var colorPort = ParseColor("#00FF00").Result;
        ChipLib.Log($"Interpolating with colors. Data: {colorData}, Port: {colorPort}");

        var vectorData = new Vector3(1, 2, 3);
        var vectorPort = Vector3Create(4, 5, 6);
        ChipLib.Log($"Interpolating with Vector3s. Data: {vectorData}, Port: {vectorPort}");

        var quatData = new Quaternion(1, 2, 3, 4);
        var quatPort = QuaternionCreate(5, 6, 7, 8);
        ChipLib.Log($"Interpolating with Quaternions. Data: {quatData}, Port: {quatPort}");

        throw null;
    }
}