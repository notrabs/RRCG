using RRCGSource;

public class Switches : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        SwitchTypes("test", 22);

        LogString("Return from SwitchTypes");
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
}