using RRCGSource;

#pragma warning disable CS0162 // Unreachable code detected
public class Switches : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        SwitchTypes("test", 22);

        LogString("Return from SwitchTypes()");

        ConditionalReturn("test", true);

        LogString("Return from ConditionalReturn()");

        SwitchInWhileLoop();

        LogString("Return from SwitchInWhileLoop()");
    }
    public void SwitchTypes(string switchString, int switchInt)
    {

        switch (switchString)
        {
            case "test":
                {
                    LogString("block case");
                    break;
                }
            case "case2":
            case "case3":
                LogString("fallthrough");
                break;
            case "case4":
                throw null;
            case "case5":
                return;
            default:
                LogString("default");
                break;
        }

        switch (switchInt)
        {
            case 1:
                {
                    LogString("block case");
                    break;
                }
            case 2:
            case 3:
                LogString("fallthrough");
                break;
            case 4:
                throw null;
            case 5:
                return;
            default:
                LogString("default");
                break;
        }
    }

    public void ConditionalReturn(string switchString, bool condition)
    {
        switch (switchString)
        {
            case "0":
                if (condition) break;
                return;
            case "switch":
                switch (switchString)
                {
                    case "0":
                        if (condition) break;
                        return;
                }
                LogString("After Switch 2");
                break;
            case "while":
                while (condition)
                {
                    switch (switchString)
                    {
                        case "0":
                            LogString("While Switch Case 0");
                            break;
                        case "return":
                            return;
                    }
                    LogString("After Switch While Switch Case 0");

                    if (condition)
                    {
                        LogString("Break out of while");
                        break;
                    }
                    else if (condition)
                    {
                        LogString("Return");
                        return;
                    }
                    LogString("Continue in while");
                }
                LogString("After Switch While");
                break;
        }
        LogString("After Switch 1");
    }

    void SwitchInWhileLoop()
    {
        while (true)
        {
            switch (5)
            {
                case 5:
                    continue;
            }
            LogString("After switch");
        }
        LogString("After while");
    }
}
#pragma warning restore CS0162 // Unreachable code detected
