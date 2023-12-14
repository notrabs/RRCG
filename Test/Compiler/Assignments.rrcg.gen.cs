using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0219 // Variable is assigned but its value is never used

    public class AssignmentsTest : CircuitBuilder
    {
        IntPort methodValueAssignment;
        TypeTest mehtodTypeAssignment;
        TypeTest mehtodTypeAssignmentAnonymous;
        TypeTest.NestedTypeTest mehtodNestedTypeAssignment;
        TypeTest.NestedTypeTest mehtodNestedTypeAssignmentAnonymous;
        FloatPort outOfScopeType;
        // Test interface assignments
        IVariable<IntPort> variableAssignment;
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            IntPort methodValueAssignment = __VariableDeclaratorExpression<IntPort>("methodValueAssignment", () => 3, (_RRCG_SETTER_VALUE) => methodValueAssignment = _RRCG_SETTER_VALUE);
            TypeTest mehtodTypeAssignment = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignment", () => new TypeTest(), (_RRCG_SETTER_VALUE) => mehtodTypeAssignment = _RRCG_SETTER_VALUE);
            TypeTest.NestedTypeTest mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest(), (_RRCG_SETTER_VALUE) => mehtodNestedTypeAssignment = _RRCG_SETTER_VALUE);
            FloatPort outOfScopeType = __VariableDeclaratorExpression<FloatPort>("outOfScopeType", () => Mathf.Sqrt(4), (_RRCG_SETTER_VALUE) => outOfScopeType = _RRCG_SETTER_VALUE);
            Vector3Port vec3 = __VariableDeclaratorExpression<Vector3Port>("vec3", () => new Vector3Port(), (_RRCG_SETTER_VALUE) => vec3 = _RRCG_SETTER_VALUE);
            Vector3Port fullyQualifiedVec3 = __VariableDeclaratorExpression<Vector3Port>("fullyQualifiedVec3", () => new Vector3Port(), (_RRCG_SETTER_VALUE) => fullyQualifiedVec3 = _RRCG_SETTER_VALUE);
            ListPort<IntPort> test = __VariableDeclaratorExpression<ListPort<IntPort>>("test", () => ListCreate<IntPort>(1), (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public AssignmentsTest()
        {
            methodValueAssignment = __VariableDeclaratorExpression<IntPort>("methodValueAssignment", () => 3, (_RRCG_SETTER_VALUE) => methodValueAssignment = _RRCG_SETTER_VALUE);
            mehtodTypeAssignment = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignment", () => new TypeTest(), (_RRCG_SETTER_VALUE) => mehtodTypeAssignment = _RRCG_SETTER_VALUE);
            mehtodTypeAssignmentAnonymous = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignmentAnonymous", () => new(), (_RRCG_SETTER_VALUE) => mehtodTypeAssignmentAnonymous = _RRCG_SETTER_VALUE);
            mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest(), (_RRCG_SETTER_VALUE) => mehtodNestedTypeAssignment = _RRCG_SETTER_VALUE);
            mehtodNestedTypeAssignmentAnonymous = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignmentAnonymous", () => new(), (_RRCG_SETTER_VALUE) => mehtodNestedTypeAssignmentAnonymous = _RRCG_SETTER_VALUE);
            outOfScopeType = __VariableDeclaratorExpression<FloatPort>("outOfScopeType", () => Mathf.Sqrt(4), (_RRCG_SETTER_VALUE) => outOfScopeType = _RRCG_SETTER_VALUE);
            variableAssignment = __VariableDeclaratorExpression<IVariable<IntPort>>("variableAssignment", () => new Variable<IntPort>(), (_RRCG_SETTER_VALUE) => variableAssignment = _RRCG_SETTER_VALUE);
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

