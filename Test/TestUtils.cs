using RRCGBuild;
using System;
using UnityEngine;

public class TestUtils
{
    /// <summary>
    /// Builds the circuit function in an isolated environment and checks if an exception was thrown.
    /// Fails the test if no exception occurred or if it didn't match the expected message.
    /// </summary>
    public static void ExpectToThrow(AlternativeExec circuitFn, string expectedMessage = null)
    {
        var prevContext = Context.current;
        var prevExecFlow = ExecFlow.current;
        var prevSemanticStack = SemanticStack.current;
        var prevDispatcher = SpecialMethodsDispatcher.current;

        bool didThrow = true;

        try
        {
            // Test in a new environment to avoid the error leaving behind a corrupted state for future tests.
            Context.current = new Context();
            ExecFlow.current = new ExecFlow();
            SemanticStack.current = new SemanticStack();
            SpecialMethodsDispatcher.current = new SpecialMethodsDispatcher();

            circuitFn();

            didThrow = false;
        }
        catch (Exception e)
        {
            if (expectedMessage != null && e.Message != expectedMessage)
            {
                Debug.LogException(e);
                throw new Exception("Test failed: Thrown error does not match expected message!");
            }
        }

        if (!didThrow) throw new Exception("Test failed: Expected circuit function to throw an error!");

        Context.current = prevContext;
        ExecFlow.current = prevExecFlow;
        SemanticStack.current = prevSemanticStack;
        SpecialMethodsDispatcher.current = prevDispatcher;
    }
}

