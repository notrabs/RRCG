using RRCGSource;
using System;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable CS0219 // Variable is assigned but its value is never used
public class AssignmentsTest : CircuitDescriptor
{
    // Test fixed type assignements
    int methodValueAssignment = 3;
    TypeTest mehtodTypeAssignment = new TypeTest();
    TypeTest mehtodTypeAssignmentAnonymous = new();
    TypeTest.NestedTypeTest mehtodNestedTypeAssignment = new TypeTest.NestedTypeTest();
    TypeTest.NestedTypeTest mehtodNestedTypeAssignmentAnonymous = new();
    float outOfScopeType = Mathf.Sqrt(4);

    // Test interface assignments
    IVariable<int> variableAssignment = new Variable<int>();

    // Field -> variable assignments
    [Variable]
    public string MemberString = "Home value";

    [SyncedVariable]
    private Color SyncedMemberColour = new Color(1, 0, 0), TestMultipleDeclarations = new Color(0, 1, 0);

    [CloudVariable("CloudVar1", "CloudVar2", "CloudVar3")]
    private int MemberCloudVar1, MemberCloudVar2, MemberCloudVar3; // home values unsupported

    public override void CircuitGraph()
    {
        // Test var assignments
        var methodValueAssignment = 3;
        var mehtodTypeAssignment = new TypeTest();
        var mehtodNestedTypeAssignment = new TypeTest.NestedTypeTest();
        var outOfScopeType = Mathf.Sqrt(4);

        // Test that the builtin Unity types get rewritten correctly into port types
        Vector3 vec3 = new Vector3();
        UnityEngine.Vector3 fullyQualifiedVec3 = new UnityEngine.Vector3();
        List<int> test = ListCreate(1);

        // Test conditional/promoted assignments with a terminated execution flow
        string result = Reroute("Hello");
        if (ParseBool("true").Result)
        {
            result += ", world!";
            LogString(result);
            throw null;
        }

        LogString(result);

        // Assign to our variable fields
        MemberString = "Hello";
        SyncedMemberColour = Color.red;
        TestMultipleDeclarations = Color.magenta;
        MemberCloudVar1 = 1;
        MemberCloudVar2 = 2;
        MemberCloudVar3 = 3;

        // Log all our variable fields
        ChipLib.Log(MemberString);
        ChipLib.Log(SyncedMemberColour);
        ChipLib.Log(TestMultipleDeclarations);
        ChipLib.Log(MemberCloudVar1);
        ChipLib.Log(MemberCloudVar2);
        ChipLib.Log(MemberCloudVar3);

        // TODO: Collapse sequential variable writes.
        MemberString += ", world!";
        MemberString += " How";
        MemberString += " are";
        MemberString += "you?";
    }
}
class TypeTest
{
    public class NestedTypeTest { }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
