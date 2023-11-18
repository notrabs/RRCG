using RRCG;
using RRCGSource;

#pragma warning disable CS0162 // Unreachable code detected
public class Goto : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        var GotoTest = new EventDefinition();
        GotoTest.Receiver();

        // Go to label that's already defined
    label1:
        LogString("Label 1!");

        if (true)
            goto label1;

        LogString("Did not go to label1");

        // Goto label that is yet to be defined
        if (true)
            goto label2;

        LogString("Did not go to label2");

    label2:
        LogString("Label 2");

        // Label fallthrough
    label3:
    label4:
    label5:
        LogString("Label 3, 4, 5");

        switch (0)
        {
            case 1:
                LogString("Going to label3");
                goto label3;
            case 2:
                LogString("Going to label4");
                goto label4;
            case 3:
                LogString("Going to label5");
                goto label5;
        }

        // No scoping weirdness
        CircuitBoard(() =>
        {
        // Go to label that's already defined
        innerLabel1:
            LogString("Inner label 1");

            if (true)
                goto innerLabel1;

            LogString("Did not go to innerLabel1");

            // Goto label that is yet to be defined
            if (true)
                goto innerLabel2;

            LogString("Did not go to innerLabel2");

        innerLabel2:
            LogString("Inner label 2");

        // Label fallthrough
        innerLabel3:
        innerLabel4:
        innerLabel5:
            LogString("Inner label 3, 4, 5");

            switch (0)
            {
                case 1:
                    LogString("Going to innerLabel3");
                    goto innerLabel3;
                case 2:
                    LogString("Going to innerLabel4");
                    goto innerLabel4;
                case 3:
                    LogString("Going to innerLabel5");
                    goto innerLabel5;
            }

            // Cannot goto label outside function scope (we're in a nested function)
            //goto label1;
        });

        // Cannot goto label inside function scope
        //goto innerLabel1;

        // Cannot goto label inside block
        if (true)
        {
        blockLabel:
            LogString("Block label");
        }

        //goto blockLabel;
    }
}
#pragma warning restore CS0162 // Unreachable code detected