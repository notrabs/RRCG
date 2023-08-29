

using RRCG;
using System;

public abstract class CircuitDescriptor
{
    public abstract void CircuitGraph();

    public void StartNewGraph() { }
    public void ClearExec() { }
    public void ExistingCircuitBoard(string boardName, Action circuitBoardFn)
    {
        circuitBoardFn();
    }

    public PinType ExistingDataInput<PinType>(string portName)
    {
        return default;
    }
    public void ExistingDataOutput<PinType>(string portName, PinType value)
    {
    }

    public void ExistingExecInput(string portName)
    {
    }

    public void ExistingExecOutput(string portName)
    {
    }

}

