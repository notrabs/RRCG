using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    internal class ClassChipsTest : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            DelayTest();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void DelayTest()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            var delay = new Delay(5);
            ChipLib.Log("Delay Test 1");
            delay.Cancel().Run();
            ChipLib.Log("Delay is scheduled");
            delay.Await();
            ChipLib.Log("After delay");
            StartNewGraph();
            ChipLib.Log("Delay Test 2");
            // Should only connect the cancel pin because run was called
            delay.Cancel().Run();
            StartNewGraph();
            ChipLib.Log("Delay Test 3");
            delay.Run();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}