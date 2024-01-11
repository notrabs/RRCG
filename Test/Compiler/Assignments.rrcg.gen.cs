using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0219 // Variable is assigned but its value is never used

    public class AssignmentsTest : CircuitBuilder
    {
        IntPort methodValueAssignment = 3;
        TypeTest mehtodTypeAssignment = new TypeTest();
        TypeTest mehtodTypeAssignmentAnonymous = new();
        TypeTest.NestedTypeTest mehtodNestedTypeAssignment = new TypeTest.NestedTypeTest();
        TypeTest.NestedTypeTest mehtodNestedTypeAssignmentAnonymous = new();
        FloatPort outOfScopeType = Mathf.Sqrt(4);
        // Test interface assignments
        IVariable<IntPort> variableAssignment = new Variable<IntPort>();
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                IntPort methodValueAssignment = default !;
                methodValueAssignment = __VariableDeclaratorExpression<IntPort>("methodValueAssignment", () => 3, () => methodValueAssignment!, (_RRCG_SETTER_VALUE) => methodValueAssignment = _RRCG_SETTER_VALUE);
                TypeTest mehtodTypeAssignment = default !;
                mehtodTypeAssignment = __VariableDeclaratorExpression<TypeTest>("mehtodTypeAssignment", () => new TypeTest(), () => mehtodTypeAssignment!, (_RRCG_SETTER_VALUE) => mehtodTypeAssignment = _RRCG_SETTER_VALUE);
                TypeTest.NestedTypeTest mehtodNestedTypeAssignment = default !;
                mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest(), () => mehtodNestedTypeAssignment!, (_RRCG_SETTER_VALUE) => mehtodNestedTypeAssignment = _RRCG_SETTER_VALUE);
                FloatPort outOfScopeType = default !;
                outOfScopeType = __VariableDeclaratorExpression<FloatPort>("outOfScopeType", () => Mathf.Sqrt(4), () => outOfScopeType!, (_RRCG_SETTER_VALUE) => outOfScopeType = _RRCG_SETTER_VALUE);
                Vector3Port vec3 = default !;
                vec3 = __VariableDeclaratorExpression<Vector3Port>("vec3", () => new Vector3Port(), () => vec3!, (_RRCG_SETTER_VALUE) => vec3 = _RRCG_SETTER_VALUE);
                Vector3Port fullyQualifiedVec3 = default !;
                fullyQualifiedVec3 = __VariableDeclaratorExpression<Vector3Port>("fullyQualifiedVec3", () => new Vector3Port(), () => fullyQualifiedVec3!, (_RRCG_SETTER_VALUE) => fullyQualifiedVec3 = _RRCG_SETTER_VALUE);
                ListPort<IntPort> test = default !;
                test = __VariableDeclaratorExpression<ListPort<IntPort>>("test", () => ListCreate<IntPort>(1), () => test!, (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
                StringPort result = default !;
                result = __VariableDeclaratorExpression<StringPort>("result", () => Reroute<StringPort>("Hello"), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext("result"), () => ParseBool("true").Result, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                result += ", world!";
                LogString(result);
                ExecFlow.current.Clear();
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            LogString(result);
            // Assign to our variable fields
            MemberString = "Hello";
            SyncedMemberColour = ColorPort.red;
            TestMultipleDeclarations = ColorPort.magenta;
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
            // Test conditional assignments to method parameters
            // Simple lambdas
            RoomEvent.TestEvent(param =>
            {
                __BeginReturnScope("SimpleLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __If(__ConditionalContext("param"), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    param += ", conditional suffix (simple lambda)";
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                LogString(param);
                __EndAccessibilityScope();
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            // Parenthesized lambdas
            RoomEvent.TestEvent((param) =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
                __If(__ConditionalContext("param"), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    param += ", conditional suffix (parenthesized lambda)";
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                LogString(param);
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            // Anonymous methods
            RoomEvent.TestEvent(delegate (StringPort param)
            {
                __BeginReturnScope("AnonymousMethod", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
                __If(__ConditionalContext("param"), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    param += ", conditional suffix (anonymous method)";
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                LogString(param);
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            // Methods
            RoomEvent.TestEvent(ConditionalParamsTest);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ConditionalParamsTest(StringPort param)
        {
            __BeginReturnScope("ConditionalParamsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext("param"), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                param += ", conditional suffix (member method)";
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            LogString(param);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        private NamedVariable<StringPort> __RRCG_FIELD_VARIABLE_MemberString = __CreateNamedVariable<StringPort>("MemberString", "Home value", VariableKind.Local);
        public StringPort MemberString
        {
            get => __RRCG_FIELD_VARIABLE_MemberString.Value;
            set => __RRCG_FIELD_VARIABLE_MemberString.Value = value;
        }

        private NamedVariable<ColorPort> __RRCG_FIELD_VARIABLE_SyncedMemberColour = __CreateNamedVariable<ColorPort>("SyncedMemberColour", new ColorPort(1, 0, 0), VariableKind.Synced);
        private ColorPort SyncedMemberColour
        {
            get => __RRCG_FIELD_VARIABLE_SyncedMemberColour.Value;
            set => __RRCG_FIELD_VARIABLE_SyncedMemberColour.Value = value;
        }

        private NamedVariable<ColorPort> __RRCG_FIELD_VARIABLE_TestMultipleDeclarations = __CreateNamedVariable<ColorPort>("TestMultipleDeclarations", new ColorPort(0, 1, 0), VariableKind.Synced);
        private ColorPort TestMultipleDeclarations
        {
            get => __RRCG_FIELD_VARIABLE_TestMultipleDeclarations.Value;
            set => __RRCG_FIELD_VARIABLE_TestMultipleDeclarations.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_FIELD_VARIABLE_MemberCloudVar1 = __CreateNamedVariable<IntPort>("CloudVar1", null !, VariableKind.Cloud);
        private IntPort MemberCloudVar1
        {
            get => __RRCG_FIELD_VARIABLE_MemberCloudVar1.Value;
            set => __RRCG_FIELD_VARIABLE_MemberCloudVar1.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_FIELD_VARIABLE_MemberCloudVar2 = __CreateNamedVariable<IntPort>("CloudVar2", null !, VariableKind.Cloud);
        private IntPort MemberCloudVar2
        {
            get => __RRCG_FIELD_VARIABLE_MemberCloudVar2.Value;
            set => __RRCG_FIELD_VARIABLE_MemberCloudVar2.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_FIELD_VARIABLE_MemberCloudVar3 = __CreateNamedVariable<IntPort>("CloudVar3", null !, VariableKind.Cloud);
        private IntPort MemberCloudVar3
        {
            get => __RRCG_FIELD_VARIABLE_MemberCloudVar3.Value;
            set => __RRCG_FIELD_VARIABLE_MemberCloudVar3.Value = value;
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

