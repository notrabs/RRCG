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
    }
}
class TypeTest
{
    public class NestedTypeTest { }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used
