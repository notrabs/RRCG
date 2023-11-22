using RRCG;
using RRCGSource;

#pragma warning disable CS0162 // Unreachable code detected
public class Optimizer : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        TestNotIfOptimizer();

        TestKnownSingletonChipsOptimizer();

        TestVariableCollapseOptimizer();

        TestAssociativeOperationCollapseOptimizer();
    }

    void TestNotIfOptimizer()
    {
        new EventDefinition("TestNotIfOptimizer").Receiver();

        var optimizableBool = ParseBool("true").Result;

        if (true) LogString("true");
        else LogString("false");

        if (!true) LogString("true");
        else LogString("false");

        if (Not(true)) LogString("true");
        else LogString("false");

        var optimizableButNotDeletable = !ParseBool("true").Result;

        if (optimizableButNotDeletable) LogString("true");
        else LogString("false");

        ChipLib.Log(optimizableButNotDeletable);

        if (optimizableBool) LogString("true");
        else LogString("false");

        if (!optimizableBool) LogString("true");
        else LogString("false");

        if (ParseInt("1").Result == 1) LogString("true");
        else LogString("false");

        if (ParseInt("1").Result != 1) LogString("true");
        else LogString("false");

        throw null;
    }

    void TestKnownSingletonChipsOptimizer()
    {
        new EventDefinition("TestKnownSingletonChipsOptimizer").Receiver();

        var floatVar = new Variable<float>();

        // All these Time Get Precise Seconds nodes
        // will be collapsed into a single node.
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();

        throw null;
    }

    void TestVariableCollapseOptimizer()
    {
        new EventDefinition("TestVariableCollapseOptimiser").Receiver();

        var var0 = new Variable<float>();
        var var1 = new Variable<float>();
        var var2 = new Variable<float>();
        var var3 = new Variable<float>();

        // All read-only instances of each
        // variable will be collapsed into
        // the "writing" instance.
        var0.Value = RandomFloat(0, 100);
        ChipLib.Log(var0.Value);

        var1.Value = RandomFloat(0, 100);
        ChipLib.Log(var1.Value);

        var2.Value = RandomFloat(0, 100);
        ChipLib.Log(var2.Value);

        var3.Value = RandomFloat(0, 100);
        ChipLib.Log(var3.Value);

        throw null;
    }

    void TestAssociativeOperationCollapseOptimizer()
    {
        new EventDefinition("TestAssociativeOperationCollapseOptimizer").Receiver();

        var variable = new Variable<float>();
        variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;

        float undeletableAdd = variable.Value + 5f;
        float collapsible = undeletableAdd + 1f + 2f + 3f + 4f;
        ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
        ChipLib.Log(collapsible);

        var spacePort = Reroute<string>(" ");
        ChipLib.Log("Hello" + spacePort + "World");

        var undeletableConcat = "Undeletable" + spacePort + "concat";
        ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
        ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);
        throw null;
    }
}
#pragma warning restore CS0162 // Unreachable code detected
