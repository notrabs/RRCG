using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class SyncedArray : CircuitBuilder
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
            ChipLib.Log("Start before inline definitions.");
                RRCGBuild.SyncedArray<IntPort> arrayInt = default !;
                arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<IntPort>>("arrayInt", () => new SyncedArray<IntPort>(2), () => arrayInt!, (_RRCG_SETTER_VALUE) => arrayInt = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<FloatPort> arrayFloat = default !;
                arrayFloat = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<FloatPort>>("arrayFloat", () => new SyncedArray<FloatPort>(4), () => arrayFloat!, (_RRCG_SETTER_VALUE) => arrayFloat = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<StringPort> arrayString = default !;
                arrayString = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<StringPort>>("arrayString", () => new SyncedArray<StringPort>(6), () => arrayString!, (_RRCG_SETTER_VALUE) => arrayString = _RRCG_SETTER_VALUE);
                RRCGBuild.SyncedArray<BoolPort> arrayBool = default !;
                arrayBool = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<BoolPort>>("arrayBool", () => new SyncedArray<BoolPort>(8), () => arrayBool!, (_RRCG_SETTER_VALUE) => arrayBool = _RRCG_SETTER_VALUE);
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
            arrayFloat[3] = RandomInt(0, 3);
            ChipLib.Log(arrayFloat[2]);
            arrayString[3] = "test";
            ChipLib.Log(arrayString[5]);
            arrayBool[3] = true;
            ChipLib.Log(arrayBool[0]);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        public void SyncedArrayInt()
        {
            __BeginReturnScope("SyncedArrayInt", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.SyncedArrayInt arrayInt = default !;
                arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArrayInt>("arrayInt", () => new SyncedArrayInt(5), () => arrayInt!, (_RRCG_SETTER_VALUE) => arrayInt = _RRCG_SETTER_VALUE);
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
                SyncedArray<IntPort> casted = default !;
                casted = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<IntPort>>("casted", () => arrayInt, () => casted!, (_RRCG_SETTER_VALUE) => casted = _RRCG_SETTER_VALUE);
            casted[0] = 0;
            ChipLib.Log(casted[1]);
            arrayInt.Add(4, 5);
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}