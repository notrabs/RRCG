using RRCG;
using RRCGSource;

public class Optimizer : CircuitDescriptor
{
    public override void CircuitGraph()
    {
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
    }
}
