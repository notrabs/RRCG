using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class SyncedArray : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            ReadWrite();
            SyncedArrayInt();
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void ReadWrite()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
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
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }

        public void SyncedArrayInt()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var arrayInt = __VariableDeclaratorExpression("arrayInt", () => new SyncedArrayInt(5));
            arrayInt[0] = 0;
            ChipLib.Log(arrayInt[1]);
            SyncedArray<IntPort> casted = __VariableDeclaratorExpression("casted", () => arrayInt);
            casted[0] = 0;
            ChipLib.Log(casted[1]);
            arrayInt.Add(4, 5);
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        }
    }
}