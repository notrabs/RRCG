using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class SyncedArray : RRCGBuild.CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            ReadWrite();
            SyncedArrayInt();
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void ReadWrite()
        {
            __BeginReturnScope("ReadWrite", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("Start before inline definitions.");
                RRCGBuild.SyncedArray<RRCGBuild.IntPort> arrayInt = default !;
                arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<RRCGBuild.IntPort>>("arrayInt", () => new RRCGBuild.SyncedArray<RRCGBuild.IntPort>(2), () => arrayInt!, (_RRCG_SETTER_VALUE) => arrayInt = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<RRCGBuild.FloatPort> arrayFloat = default !;
                arrayFloat = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<RRCGBuild.FloatPort>>("arrayFloat", () => new RRCGBuild.SyncedArray<RRCGBuild.FloatPort>(4), () => arrayFloat!, (_RRCG_SETTER_VALUE) => arrayFloat = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<RRCGBuild.StringPort> arrayString = default !;
                arrayString = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<RRCGBuild.StringPort>>("arrayString", () => new RRCGBuild.SyncedArray<RRCGBuild.StringPort>(6), () => arrayString!, (_RRCG_SETTER_VALUE) => arrayString = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<RRCGBuild.BoolPort> arrayBool = default !;
                arrayBool = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<RRCGBuild.BoolPort>>("arrayBool", () => new RRCGBuild.SyncedArray<RRCGBuild.BoolPort>(8), () => arrayBool!, (_RRCG_SETTER_VALUE) => arrayBool = _RRCG_SETTER_VALUE);
            arrayInt[0] = 0;
            RRCGBuild.ChipLib.Log(arrayInt[1]);
            arrayFloat[3] = RandomInt(0, 3);
            RRCGBuild.ChipLib.Log(arrayFloat[2]);
            arrayString[3] = "test";
            RRCGBuild.ChipLib.Log(arrayString[5]);
            arrayBool[3] = true;
            RRCGBuild.ChipLib.Log(arrayBool[0]);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void SyncedArrayInt()
        {
            __BeginReturnScope("SyncedArrayInt", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.SyncedArrayInt arrayInt = default !;
                arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArrayInt>("arrayInt", () => new RRCGBuild.SyncedArrayInt(5), () => arrayInt!, (_RRCG_SETTER_VALUE) => arrayInt = _RRCG_SETTER_VALUE);
            arrayInt[0] = 0;
            RRCGBuild.ChipLib.Log(arrayInt[1]);
                RRCGBuild.SyncedArray<RRCGBuild.IntPort> casted = default !;
                casted = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<RRCGBuild.IntPort>>("casted", () => arrayInt, () => casted!, (_RRCG_SETTER_VALUE) => casted = _RRCG_SETTER_VALUE);
            casted[0] = 0;
            RRCGBuild.ChipLib.Log(casted[1]);
            arrayInt.Add(4, 5);
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}