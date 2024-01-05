using RRCGSource;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointsTest : CircuitDescriptor
{
    // class initializers should be placed in root
    int a = RandomInt(1, 10);

    public EntryPointsTest()
    {
        // This should be executed after class initializers, and before the circuit graph
        ChipLib.Log("constructor");
    }

    public override void CircuitGraph()
    {
        // This should be the first graph after initialization
        ChipLib.Log("main circuit graph");
    }

    [CircuitGraph]
    void PrivateGraph()
    {
        // This should start a new graph
        ChipLib.Log("private graph");
    }

    [CircuitGraph]
    protected void ProtectedGraph()
    {
        // This should start a new graph
        ChipLib.Log("protected graph");
    }

    [CircuitGraph]
    protected void InternalGraph()
    {
        // This should start a new graph
        ChipLib.Log("internal graph");
    }

    [CircuitGraph]
    public void PublicGraph()
    {
        // This should start a new graph
        ChipLib.Log("public graph");
    }
}