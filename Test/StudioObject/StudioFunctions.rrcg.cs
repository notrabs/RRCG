using RRCGSource;
using UnityEngine;

public class StudioFunctions : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        var studioObject = new StudioFunctionsObject(RecRoomObject.Invalid);

        studioObject.VoidFunction();

        studioObject.AllParameterTypes(true, 23f, 7, "test", new Color(1.0f, 0, 0), Vector3.up, Quaternion.identity);

        ChipLib.Log(studioObject.SingleReturn(Vector3.zero));

        var multiReturn = studioObject.MultiReturn();
        ChipLib.Log(multiReturn.Item1);
        ChipLib.Log(multiReturn.Item2);
    }
}

public class StudioFunctionsObject : StudioObjectDescriptor
{
    public StudioFunctionsObject(StudioObject target) : base(target, "TestPrefab") { }

    [ExistingStudioFunction]
    public void VoidFunction() { }

    [ExistingStudioFunction]
    public void AllParameterTypes(bool p0, float p1, int p2, string p3, Color p4, Vector3 p5, Quaternion p6) { }

    [ExistingStudioFunction]
    public Vector3 SingleReturn(Vector3 input) { return default; }

    [ExistingStudioFunction]
    public (Vector3, Quaternion) MultiReturn() { return default; }
}

