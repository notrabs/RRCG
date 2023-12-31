using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class StudioFunctions : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                StudioFunctionsObject studioObject = default !;
                studioObject = __VariableDeclaratorExpression<StudioFunctionsObject>("studioObject", () => new StudioFunctionsObject(RecRoomObjectPort.Invalid), () => studioObject!, (_RRCG_SETTER_VALUE) => studioObject = _RRCG_SETTER_VALUE);
            studioObject.VoidFunction();
            studioObject.AllParameterTypes(true, 23f, 7, "test", new ColorPort(1.0f, 0, 0), Vector3Port.up, QuaternionPort.identity);
            ChipLib.Log(studioObject.SingleReturn(Vector3Port.zero));
                (Vector3Port, QuaternionPort) multiReturn = default !;
                multiReturn = __VariableDeclaratorExpression<(Vector3Port, QuaternionPort)>("multiReturn", () => studioObject.MultiReturn(), () => multiReturn!, (_RRCG_SETTER_VALUE) => multiReturn = _RRCG_SETTER_VALUE);
            ChipLib.Log(multiReturn.Item1);
            ChipLib.Log(multiReturn.Item2);
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