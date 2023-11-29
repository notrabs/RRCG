using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0219 // Variable is assigned but its value is never used

    public class AssignmentsTest : CircuitBuilder
    {
        IntPort methodValueAssignment = __VariableDeclaratorExpression<IntPort>("methodValueAssignment", () => 3);
        TypeTest mehtodTypeAssignment = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignment", () => new TypeTest());
        TypeTest mehtodTypeAssignmentAnonymous = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignmentAnonymous", () => new());
        TypeTest.NestedTypeTest mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest());
        TypeTest.NestedTypeTest mehtodNestedTypeAssignmentAnonymous = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignmentAnonymous", () => new());
        FloatPort outOfScopeType = __VariableDeclaratorExpression<FloatPort>("outOfScopeType", () => Mathf.Sqrt(4));
        // Test interface assignments
        IVariable<IntPort> variableAssignment = __VariableDeclaratorExpression<RRCGBuild.IVariable<IntPort>>("variableAssignment", () => new Variable<IntPort>());
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            // Test var assignments
            var methodValueAssignment = __VariableDeclaratorExpression<IntPort>("methodValueAssignment", () => 3);
            var mehtodTypeAssignment = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignment", () => new TypeTest());
            var mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest());
            var outOfScopeType = __VariableDeclaratorExpression<FloatPort>("outOfScopeType", () => Mathf.Sqrt(4));
            Vector3Port vec3 = __VariableDeclaratorExpression<Vector3Port>("vec3", () => new Vector3Port());
            Vector3Port fullyQualifiedVec3 = __VariableDeclaratorExpression<Vector3Port>("fullyQualifiedVec3", () => new Vector3Port());
            ListPort<IntPort> test = __VariableDeclaratorExpression<ListPort<IntPort>>("test", () => ListCreate<IntPort>(1));
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }

    class TypeTest
    {
        public class NestedTypeTest
        {
        }
    }
}
#pragma warning restore CS0219 // Variable is assigned but its value is never used

