using RRCGSource;

#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).

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

        SwitchPromotedVariables();

        LogString("Return from SwitchPromotedVariables()");

        SwitchExpressions();

        LogString("Return from SwitchExpressions()");
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

    public void SwitchPromotedVariables()
    {
        int myLocal = 0;
        float otherLocal = 0f;
        switch (myLocal)
        {
            case 0:
                myLocal += 1;
                break;
            case 1:
                if (true)
                    myLocal += 2;

                myLocal += 3;
                break;
            case 3:
                myLocal += 4;
                otherLocal = 10f;
                goto case 0;
            default:
                myLocal = int.MinValue;
                break;
        }

        LogString($"{myLocal}, {otherLocal}");
    }

    public void SwitchExpressions()
    {
        int matchIntData = 5;
        int matchIntPort = Reroute(5);

        string matchStrData = "Match";
        string matchStrPort = Reroute("Match");

        // Test with data match
        // The compiler will only evaluate the matching branch
        string dataIntResult = ChipLib.VariableCache(matchIntData switch
        {
            0 => "Zero",
            1 => "One",
            _ => "Default"
        });

        string dataStrResult = ChipLib.VariableCache(matchStrData switch
        {
            "Hello" => "World",
            "Match" => "Matched",
            _ => "Default"
        });

        // Test with port match
        // The compiler has to evaluate all possibilities and spawn a value switch chip
        string portIntResult = ChipLib.VariableCache(matchIntPort switch
        {
            0 => "Zero",
            1 => "One",
            _ => "Default"
        });

        string portStrResult = ChipLib.VariableCache(matchStrPort switch
        {
            "Hello" => "World",
            "Match" => "Matched",
            _ => "Default"
        });

        // Test match failure with no default
        // This should produce a circuits error due to the unwired port:
        var rrObjResultPort = ChipLib.VariableCache(matchIntPort switch
        {
            -1 => RecRoomObject.Invalid
        });

        // And this should produce a build-time exception.
        // (Maybe there's a difference in semantics
        //  when the result type supports default values. FIXME?)
        TestUtils.ExpectToThrow(() =>
        {
            var rrObjResultData = ChipLib.VariableCache(matchIntData switch
            {
                -1 => RecRoomObject.Invalid
            });
        }, "Failed to match against pure-data value, but no default value was provided!");
    }
}

#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
#pragma warning restore CS0162 // Unreachable code detected
