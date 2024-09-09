using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class StudioFunctions : RRCGBuild.CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                StudioFunctionsObject studioObject = default !;
                studioObject = __VariableDeclaratorExpression<StudioFunctionsObject>("studioObject", () => new StudioFunctionsObject(RRCGBuild.RecRoomObjectPort.Invalid), () => studioObject!, (_RRCG_SETTER_VALUE) => studioObject = _RRCG_SETTER_VALUE);
            studioObject.VoidFunction();
            studioObject.AllParameterTypes(true, 23f, 7, "test", new RRCGBuild.ColorPort(1.0f, 0, 0), RRCGBuild.Vector3Port.up, RRCGBuild.QuaternionPort.identity);
            RRCGBuild.ChipLib.Log(studioObject.SingleReturn(RRCGBuild.Vector3Port.zero));
                (RRCGBuild.Vector3Port Item1, RRCGBuild.QuaternionPort Item2) multiReturn = default !;
                multiReturn = __VariableDeclaratorExpression<(RRCGBuild.Vector3Port Item1, RRCGBuild.QuaternionPort Item2)>("multiReturn", () => studioObject.MultiReturn(), () => multiReturn!, (_RRCG_SETTER_VALUE) => multiReturn = _RRCG_SETTER_VALUE);
            RRCGBuild.ChipLib.Log(multiReturn.Item1);
            RRCGBuild.ChipLib.Log(multiReturn.Item2);
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }

    public class StudioFunctionsObject : StudioObjectBuilder
    {
        public StudioFunctionsObject(StudioObjectPort target): base(target, "TestPrefab")
        {
        }

        [ExistingStudioFunction]
        public void VoidFunction()
        {
            __SpawnStudioFunctionChip("VoidFunction");
        }

        [ExistingStudioFunction]
        public void AllParameterTypes(BoolPort p0, FloatPort p1, IntPort p2, StringPort p3, ColorPort p4, Vector3Port p5, QuaternionPort p6)
        {
            __SpawnStudioFunctionChip("AllParameterTypes", p0, p1, p2, p3, p4, p5, p6);
        }

        [ExistingStudioFunction]
        public Vector3Port SingleReturn(Vector3Port input)
        {
            __SpawnStudioFunctionChip("SingleReturn", input);
            var node = Context.lastSpawnedNode;
            return new Vector3Port()
            {Port = node.Port(0, 1)};
        }

        [ExistingStudioFunction]
        public (Vector3Port, QuaternionPort) MultiReturn()
        {
            __SpawnStudioFunctionChip("MultiReturn");
            var node = Context.lastSpawnedNode;
            return (new Vector3Port()
            {Port = node.Port(0, 1)}, new QuaternionPort()
            {Port = node.Port(0, 2)});
        }

        public override void __UpdateStudioEvents()
        {
            __GetImplementation().__ClearEvents(this);
            __GetImplementation().__FinalizeEvents(this);
        }
    }
}