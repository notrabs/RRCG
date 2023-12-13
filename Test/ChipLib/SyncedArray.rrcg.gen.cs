using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class SyncedArray : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            ReadWrite();
            SyncedArrayInt();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void ReadWrite()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            ChipLib.Log("Start before inline definitions.");
            RRCGBuild.SyncedArray<IntPort> arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<IntPort>>("arrayInt", () => new SyncedArray<IntPort>(2), (rrcg_setter_value) => arrayInt = rrcg_setter_value);
            RRCGBuild.SyncedArray<FloatPort> arrayFloat = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<FloatPort>>("arrayFloat", () => new SyncedArray<FloatPort>(4), (rrcg_setter_value) => arrayFloat = rrcg_setter_value);
            RRCGBuild.SyncedArray<StringPort> arrayString = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<StringPort>>("arrayString", () => new SyncedArray<StringPort>(6), (rrcg_setter_value) => arrayString = rrcg_setter_value);
            RRCGBuild.SyncedArray<BoolPort> arrayBool = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<BoolPort>>("arrayBool", () => new SyncedArray<BoolPort>(8), (rrcg_setter_value) => arrayBool = rrcg_setter_value);
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
            arrayFloat[3] = RandomInt(0, 3);
            ChipLib.Log(arrayFloat[2]);
            arrayString[3] = "test";
            ChipLib.Log(arrayString[5]);
            arrayBool[3] = true;
            ChipLib.Log(arrayBool[0]);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void SyncedArrayInt()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            RRCGBuild.SyncedArrayInt arrayInt = __VariableDeclaratorExpression<RRCGBuild.SyncedArrayInt>("arrayInt", () => new SyncedArrayInt(5), (rrcg_setter_value) => arrayInt = rrcg_setter_value);
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
            SyncedArray<IntPort> casted = __VariableDeclaratorExpression<RRCGBuild.SyncedArray<IntPort>>("casted", () => arrayInt, (rrcg_setter_value) => casted = rrcg_setter_value);
            casted[0] = 0;
            ChipLib.Log(casted[1]);
            arrayInt.Add(4, 5);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}