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
            // Assign to our member variables
            FieldString = "Hello";
            SyncedFieldColour = ColorPort.red;
            TestMultipleDeclarationsField = ColorPort.magenta;
            FieldCloudVar1 = 1;
            FieldCloudVar2 = 2;
            FieldCloudVar3 = 3;
            PropertyString = "world";
            SyncedPropertyColour = ColorPort.blue;
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

        private NamedVariable<StringPort> __RRCG_MEMBER_VARIABLE_FieldString = __CreateNamedVariable<StringPort>("FieldString", "Home value", VariableKind.Local);
        public StringPort FieldString
        {
            get => __RRCG_MEMBER_VARIABLE_FieldString.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldString.Value = value;
        }

        private NamedVariable<ColorPort> __RRCG_MEMBER_VARIABLE_SyncedFieldColour = __CreateNamedVariable<ColorPort>("SyncedFieldColour", new ColorPort(1, 0, 0), VariableKind.Synced);
        private ColorPort SyncedFieldColour
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedFieldColour.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedFieldColour.Value = value;
        }

        private NamedVariable<ColorPort> __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField = __CreateNamedVariable<ColorPort>("TestMultipleDeclarationsField", new ColorPort(0, 1, 0), VariableKind.Synced);
        private ColorPort TestMultipleDeclarationsField
        {
            get => __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField.Value;
            set => __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar1 = __CreateNamedVariable<IntPort>("FieldCloudVar1", null !, VariableKind.Cloud);
        private IntPort FieldCloudVar1
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar1.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar1.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar2 = __CreateNamedVariable<IntPort>("FieldCloudVar2", null !, VariableKind.Cloud);
        private IntPort FieldCloudVar2
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar2.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar2.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar3 = __CreateNamedVariable<IntPort>("FieldCloudVar3", null !, VariableKind.Cloud);
        private IntPort FieldCloudVar3
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar3.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar3.Value = value;
        }

        private NamedVariable<StringPort> __RRCG_MEMBER_VARIABLE_PropertyString = __CreateNamedVariable<StringPort>("PropertyString", "Home value", VariableKind.Local);
        public StringPort PropertyString
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyString.Value;
            set => __RRCG_MEMBER_VARIABLE_PropertyString.Value = value;
        }

        private NamedVariable<ColorPort> __RRCG_MEMBER_VARIABLE_SyncedPropertyColour = __CreateNamedVariable<ColorPort>("SyncedPropertyColour", new ColorPort(1, 0, 0), VariableKind.Synced);
        private ColorPort SyncedPropertyColour
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedPropertyColour.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedPropertyColour.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_PropertyCloudVar1 = __CreateNamedVariable<IntPort>("PropertyCloudVar1", null !, VariableKind.Cloud);
        private IntPort PropertyCloudVar1
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyCloudVar1.Value;
            set => __RRCG_MEMBER_VARIABLE_PropertyCloudVar1.Value = value;
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

