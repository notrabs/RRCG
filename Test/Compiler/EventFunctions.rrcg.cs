using RRCGSource;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionsTest : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        Void0();
        Void1("test");
        Void1(2);
        Void2("test", 42);
        Void3("test", 42, 3f);

        // Call again with different parameters
        Void0();
        Void1("test2");
        Void1(5);
        Void2("test2", 43);
        Void3("test2", 43, 4f);

        // Test returns
        ChipLib.Log(SingleReturn());
        ChipLib.Log(DataReturn());

        var tuple = TupleReturn(5);
        ChipLib.Log(tuple.Item1);
        ChipLib.Log(tuple.Item2);

        tuple = MultiInOut(6, "test");
        ChipLib.Log(tuple.Item1);
        ChipLib.Log(tuple.Item2);

        // Check that all remaining interfaces compile
        Void4(1, 2, 3, 4);
        Void5(1, 2, 3, 4, 5);
        Void6(1, 2, 3, 4, 5, 6);
        Void7(1, 2, 3, 4, 5, 6, 7);
        Void8(1, 2, 3, 4, 5, 6, 7, 8);
        NonVoid4(1, 2, 3, 4);
        NonVoid5(1, 2, 3, 4, 5);
        NonVoid6(1, 2, 3, 4, 5, 6);
        NonVoid7(1, 2, 3, 4, 5, 6, 7);
        NonVoid8(1, 2, 3, 4, 5, 6, 7, 8);
        PublicProperFunction();
    }

    [EventFunction]
    void Void0() => ChipLib.Log("void0");

    [EventFunction]
    void Void1(string p0) => ChipLib.Log($"void1 {p0}");

    [EventFunction]
    void Void1(int p0) => ChipLib.Log($"void1 {p0}");

    [EventFunction]
    void Void2(string p0, int p1) => ChipLib.Log($"void2 {p0} {p1}");

    [EventFunction]
    void Void3(string p0, int p1, float p2) => ChipLib.Log($"void3 {p0} {p1} {p2}");

    [EventFunction]
    int SingleReturn() => RandomInt(1, 10);

    [EventFunction]
    int DataReturn() => 3;

    [EventFunction]
    (int, string) TupleReturn(int number) => (number, number.ToString());

    [EventFunction]
    (int, string) MultiInOut(int number, string text) => (number, text);

    // Interface test

    [EventFunction]
    void Void4(int p0, int p1, int p2, int p3) => ChipLib.Log("compiled!");

    [EventFunction]
    void Void5(int p0, int p1, int p2, int p3, int p4) => ChipLib.Log("compiled!");

    [EventFunction]
    void Void6(int p0, int p1, int p2, int p3, int p4, int p5) => ChipLib.Log("compiled!");

    [EventFunction]
    void Void7(int p0, int p1, int p2, int p3, int p4, int p5, int p6) => ChipLib.Log("compiled!");

    [EventFunction]
    void Void8(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7) => ChipLib.Log("compiled!");

    [EventFunction]
    int NonVoid4(int p0, int p1, int p2, int p3) => RandomInt(1, 2);

    [EventFunction]
    int NonVoid5(int p0, int p1, int p2, int p3, int p4) => RandomInt(1, 2);

    [EventFunction]
    int NonVoid6(int p0, int p1, int p2, int p3, int p4, int p5) => RandomInt(1, 2);

    [EventFunction]
    int NonVoid7(int p0, int p1, int p2, int p3, int p4, int p5, int p6) => RandomInt(1, 2);

    [EventFunction]
    int NonVoid8(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7) => RandomInt(1, 2);

    [EventFunction]
    public void PublicProperFunction()
    {
        ChipLib.Log("compiled!");
    }
}