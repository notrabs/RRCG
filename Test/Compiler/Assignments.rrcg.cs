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
    public string FieldString = "Home value";

    [SyncedVariable]
    private Color SyncedFieldColour = new Color(1, 0, 0), TestMultipleDeclarationsField = new Color(0, 1, 0);

    [CloudVariable("FieldCloudVar1", "FieldCloudVar2", "FieldCloudVar3")]
    private int FieldCloudVar1, FieldCloudVar2, FieldCloudVar3; // home values unsupported

    // Property -> variable assignments
    [Variable]
    public string PropertyString { get; set; } = "Home value";

    [SyncedVariable]
    private Color SyncedPropertyColour { get; set; } = new Color(1, 0, 0);

    [CloudVariable("PropertyCloudVar1")]
    private int PropertyCloudVar1 { get; set; }

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

        // Assign to our member variables
        FieldString = "Hello";
        SyncedFieldColour = Color.red;
        TestMultipleDeclarationsField = Color.magenta;
        FieldCloudVar1 = 1;
        FieldCloudVar2 = 2;
        FieldCloudVar3 = 3;

        PropertyString = "world";
        SyncedPropertyColour = Color.blue;
        PropertyCloudVar1 = 4;

        // Log all our variable fields
        ChipLib.Log(FieldString);
        ChipLib.Log(SyncedFieldColour);
        ChipLib.Log(TestMultipleDeclarationsField);
        ChipLib.Log(FieldCloudVar1);
        ChipLib.Log(FieldCloudVar2);
        ChipLib.Log(FieldCloudVar3);

        ChipLib.Log(PropertyString);
        ChipLib.Log(SyncedPropertyColour);
        ChipLib.Log(PropertyCloudVar1);

        // Test conditional assignments to method parameters
        // Simple lambdas
        RoomEvent.TestEvent(param =>
        {
            if (true) param += ", conditional suffix (simple lambda)";
            LogString(param);
        });

        // Parenthesized lambdas
        RoomEvent.TestEvent((param) =>
        {
            if (true) param += ", conditional suffix (parenthesized lambda)";
            LogString(param);
        });

        // Anonymous methods
        RoomEvent.TestEvent(delegate (string param)
        {
            if (true) param += ", conditional suffix (anonymous method)";
            LogString(param);
        });

        // Methods
        RoomEvent.TestEvent(ConditionalParamsTest);
    }

    void ConditionalParamsTest(string param)
    {
        if (true)
            param += ", conditional suffix (member method)";

        LogString(param);
    }
}
class TypeTest
{
    public class NestedTypeTest { }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
