using RRCGSource;

internal class ClassChipsTest : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        DelayTest();

        ErrorTest();
    }

    void DelayTest()
    {
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
    }

    void ErrorTest()
    {
        TestUtils.ExpectToThrow(() =>
        {
            var delay = new Delay(1);

            delay.Await();
            delay.Await();
        }, "Await can only be called once");
    }
}

