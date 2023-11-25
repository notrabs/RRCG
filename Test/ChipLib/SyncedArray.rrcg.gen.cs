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
            var arrayInt = __VariableDeclaratorExpression("arrayInt", () => new SyncedArray<IntPort>(2));
            var arrayFloat = __VariableDeclaratorExpression("arrayFloat", () => new SyncedArray<FloatPort>(4));
            var arrayString = __VariableDeclaratorExpression("arrayString", () => new SyncedArray<StringPort>(6));
            var arrayBool = __VariableDeclaratorExpression("arrayBool", () => new SyncedArray<BoolPort>(8));
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
            var arrayInt = __VariableDeclaratorExpression("arrayInt", () => new SyncedArrayInt(5));
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
            SyncedArray<IntPort> casted = __VariableDeclaratorExpression("casted", () => arrayInt);
            casted[0] = 0;
            ChipLib.Log(casted[1]);
            arrayInt.Add(4, 5);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}