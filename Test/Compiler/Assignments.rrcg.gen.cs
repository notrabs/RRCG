using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
#pragma warning disable CS0219 // Variable is assigned but its value is never used

    public class AssignmentsTest : RRCGBuild.CircuitBuilder
    {
        RRCGBuild.IntPort methodValueAssignment = __NamedAssignment<RRCGBuild.IntPort>("methodValueAssignment", () => 3);
        RRCGBuild.TypeTest mehtodTypeAssignment = __NamedAssignment<RRCGBuild.TypeTest>("mehtodTypeAssignment", () => new RRCGBuild.TypeTest());
        RRCGBuild.TypeTest mehtodTypeAssignmentAnonymous = __NamedAssignment<RRCGBuild.TypeTest>("mehtodTypeAssignmentAnonymous", () => new());
        TypeTest.NestedTypeTest mehtodNestedTypeAssignment = __NamedAssignment<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest());
        TypeTest.NestedTypeTest mehtodNestedTypeAssignmentAnonymous = __NamedAssignment<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignmentAnonymous", () => new());
        RRCGBuild.FloatPort outOfScopeType = __NamedAssignment<RRCGBuild.FloatPort>("outOfScopeType", () => UnityEngine.Mathf.Sqrt(4));
        RRCGBuild.IVariable<RRCGBuild.IntPort> variableAssignment = __NamedAssignment<RRCGBuild.IVariable<RRCGBuild.IntPort>>("variableAssignment", () => new RRCGBuild.Variable<RRCGBuild.IntPort>());
        private NamedVariable<RRCGBuild.StringPort> __RRCG_MEMBER_VARIABLE_FieldString = __CreateNamedVariable<RRCGBuild.StringPort>("FieldString", "Home value", VariableKind.Local);
        public RRCGBuild.StringPort FieldString
        {
            get => __RRCG_MEMBER_VARIABLE_FieldString.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldString.Value = value;
        }

        private NamedVariable<RRCGBuild.ColorPort> __RRCG_MEMBER_VARIABLE_SyncedFieldColour = __CreateNamedVariable<RRCGBuild.ColorPort>("SyncedFieldColour", new RRCGBuild.ColorPort(1, 0, 0), VariableKind.Synced);
        private RRCGBuild.ColorPort SyncedFieldColour
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedFieldColour.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedFieldColour.Value = value;
        }

        private NamedVariable<RRCGBuild.ColorPort> __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField = __CreateNamedVariable<RRCGBuild.ColorPort>("TestMultipleDeclarationsField", new RRCGBuild.ColorPort(0, 1, 0), VariableKind.Synced);
        private RRCGBuild.ColorPort TestMultipleDeclarationsField
        {
            get => __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField.Value;
            set => __RRCG_MEMBER_VARIABLE_TestMultipleDeclarationsField.Value = value;
        }

        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar1 = __CreateNamedVariable<RRCGBuild.IntPort>("FieldCloudVar1", null !, VariableKind.Cloud);
        private RRCGBuild.IntPort FieldCloudVar1
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar1.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar1.Value = value;
        }

        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar2 = __CreateNamedVariable<RRCGBuild.IntPort>("FieldCloudVar2", null !, VariableKind.Cloud);
        private RRCGBuild.IntPort FieldCloudVar2
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar2.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar2.Value = value;
        }

        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_FieldCloudVar3 = __CreateNamedVariable<RRCGBuild.IntPort>("FieldCloudVar3", null !, VariableKind.Cloud);
        private RRCGBuild.IntPort FieldCloudVar3
        {
            get => __RRCG_MEMBER_VARIABLE_FieldCloudVar3.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldCloudVar3.Value = value;
        }

        private NamedVariable<RRCGBuild.StringPort> __RRCG_MEMBER_VARIABLE_PropertyString = __CreateNamedVariable<RRCGBuild.StringPort>("PropertyString", "Home value", VariableKind.Local);
        public RRCGBuild.StringPort PropertyString
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyString.Value;
            set => __RRCG_MEMBER_VARIABLE_PropertyString.Value = value;
        }

        private NamedVariable<RRCGBuild.ColorPort> __RRCG_MEMBER_VARIABLE_SyncedPropertyColour = __CreateNamedVariable<RRCGBuild.ColorPort>("SyncedPropertyColour", new RRCGBuild.ColorPort(1, 0, 0), VariableKind.Synced);
        private RRCGBuild.ColorPort SyncedPropertyColour
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedPropertyColour.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedPropertyColour.Value = value;
        }

        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_PropertyCloudVar1 = __CreateNamedVariable<RRCGBuild.IntPort>("PropertyCloudVar1", null !, VariableKind.Cloud);
        private RRCGBuild.IntPort PropertyCloudVar1
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyCloudVar1.Value;
            set => __RRCG_MEMBER_VARIABLE_PropertyCloudVar1.Value = value;
        }

        RRCGBuild.FloatPort PropertyAccessorBacking = __NamedAssignment<RRCGBuild.FloatPort>("PropertyAccessorBacking", () => 0f);
        // We should see an accessibility scope inserted
        // into both blocks, as well as a return scope for the getter.
        public RRCGBuild.FloatPort PropertyAccessorTestBlocks
        {
            get
            {
                __BeginReturnScope("PropertyAccessorTestBlocks_get", typeof(RRCGBuild.FloatPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.FloatPort>(PropertyAccessorBacking);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            set
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                PropertyAccessorBacking = value;
                __EndAccessibilityScope();
            }
        }

        // This should translate in a similar way,
        // with the same SemanticScope configuration
        public RRCGBuild.FloatPort PropertyAccessorTestExpressions
        {
            get
            {
                __BeginReturnScope("PropertyAccessorTestExpressions_get", typeof(RRCGBuild.FloatPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.FloatPort>(PropertyAccessorBacking);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            set
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                PropertyAccessorBacking = value;
                __EndAccessibilityScope();
            }
        }

        // These should also behave the same.
        public RRCGBuild.FloatPort PropertyAccessorTestMixedOne
        {
            get
            {
                __BeginReturnScope("PropertyAccessorTestMixedOne_get", typeof(RRCGBuild.FloatPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.FloatPort>(PropertyAccessorBacking);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            set
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                PropertyAccessorBacking = value;
                __EndAccessibilityScope();
            }
        }

        public RRCGBuild.FloatPort PropertyAccessorTestMixedTwo
        {
            get
            {
                __BeginReturnScope("PropertyAccessorTestMixedTwo_get", typeof(RRCGBuild.FloatPort), null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __Return<RRCGBuild.FloatPort>(PropertyAccessorBacking);
                __EndAccessibilityScope();
                return __EndReturnScope()!;
            }

            set
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                PropertyAccessorBacking = value;
                __EndAccessibilityScope();
            }
        }

        // And this one shouldn't be affected,
        // since it's marked unsafe.
        public unsafe RRCGBuild.FloatPort PropertyAccessorTestUnsafe
        {
            get
            {
                return PropertyAccessorBacking;
            }

            set
            {
                PropertyAccessorBacking = value;
            }
        }

        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                RRCGBuild.IntPort methodValueAssignment = default !;
                methodValueAssignment = __VariableDeclaratorExpression<RRCGBuild.IntPort>("methodValueAssignment", () => 3, () => methodValueAssignment!, (_RRCG_SETTER_VALUE) => methodValueAssignment = _RRCG_SETTER_VALUE);
                RRCGBuild.TypeTest mehtodTypeAssignment = default !;
                mehtodTypeAssignment = __VariableDeclaratorExpression<RRCGBuild.TypeTest>("mehtodTypeAssignment", () => new RRCGBuild.TypeTest(), () => mehtodTypeAssignment!, (_RRCG_SETTER_VALUE) => mehtodTypeAssignment = _RRCG_SETTER_VALUE);
                TypeTest.NestedTypeTest mehtodNestedTypeAssignment = default !;
                mehtodNestedTypeAssignment = __VariableDeclaratorExpression<TypeTest.NestedTypeTest>("mehtodNestedTypeAssignment", () => new TypeTest.NestedTypeTest(), () => mehtodNestedTypeAssignment!, (_RRCG_SETTER_VALUE) => mehtodNestedTypeAssignment = _RRCG_SETTER_VALUE);
                RRCGBuild.FloatPort outOfScopeType = default !;
                outOfScopeType = __VariableDeclaratorExpression<RRCGBuild.FloatPort>("outOfScopeType", () => UnityEngine.Mathf.Sqrt(4), () => outOfScopeType!, (_RRCG_SETTER_VALUE) => outOfScopeType = _RRCG_SETTER_VALUE);
                RRCGBuild.Vector3Port vec3 = default !;
                vec3 = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("vec3", () => new RRCGBuild.Vector3Port(), () => vec3!, (_RRCG_SETTER_VALUE) => vec3 = _RRCG_SETTER_VALUE);
                RRCGBuild.Vector3Port fullyQualifiedVec3 = default !;
                fullyQualifiedVec3 = __VariableDeclaratorExpression<RRCGBuild.Vector3Port>("fullyQualifiedVec3", () => new RRCGBuild.Vector3Port(), () => fullyQualifiedVec3!, (_RRCG_SETTER_VALUE) => fullyQualifiedVec3 = _RRCG_SETTER_VALUE);
                RRCGBuild.ListPort<RRCGBuild.IntPort> test = default !;
                test = __VariableDeclaratorExpression<RRCGBuild.ListPort<RRCGBuild.IntPort>>("test", () => ListCreate<RRCGBuild.IntPort>(1), () => test!, (_RRCG_SETTER_VALUE) => test = _RRCG_SETTER_VALUE);
                RRCGBuild.StringPort result = default !;
                result = __VariableDeclaratorExpression<RRCGBuild.StringPort>("result", () => Reroute<RRCGBuild.StringPort>("Hello"), () => result!, (_RRCG_SETTER_VALUE) => result = _RRCG_SETTER_VALUE);
            __If(__ConditionalContext("result"), () => ParseBool("true").Result, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                result += ", world!";
                LogString(result);
                __Throw();
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
            SyncedFieldColour = RRCGBuild.ColorPort.red;
            TestMultipleDeclarationsField = RRCGBuild.ColorPort.magenta;
            FieldCloudVar1 = 1;
            FieldCloudVar2 = 2;
            FieldCloudVar3 = 3;
            PropertyString = "world";
            SyncedPropertyColour = RRCGBuild.ColorPort.blue;
            PropertyCloudVar1 = 4;
            RRCGBuild.ChipLib.Log(FieldString);
            RRCGBuild.ChipLib.Log(SyncedFieldColour);
            RRCGBuild.ChipLib.Log(TestMultipleDeclarationsField);
            RRCGBuild.ChipLib.Log(FieldCloudVar1);
            RRCGBuild.ChipLib.Log(FieldCloudVar2);
            RRCGBuild.ChipLib.Log(FieldCloudVar3);
            RRCGBuild.ChipLib.Log(PropertyString);
            RRCGBuild.ChipLib.Log(SyncedPropertyColour);
            RRCGBuild.ChipLib.Log(PropertyCloudVar1);
            RRCGBuild.RoomEvent.TestEvent(param =>
            {
                __BeginReturnScope("SimpleLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
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
                __EndReturnScope();
            }

            );
            RRCGBuild.RoomEvent.TestEvent((param) =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
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
            RRCGBuild.RoomEvent.TestEvent(delegate (RRCGBuild.StringPort param)
            {
                __BeginReturnScope("AnonymousMethod", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<RRCGBuild.StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
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
            RRCGBuild.RoomEvent.TestEvent(ConditionalParamsTest);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void ConditionalParamsTest(RRCGBuild.StringPort param)
        {
            __BeginReturnScope("ConditionalParamsTest", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.StringPort>("param", null, () => param!, (_RRCG_SETTER_VALUE) => param = _RRCG_SETTER_VALUE);
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
    }

    class TypeTest
    {
        public class NestedTypeTest
        {
        }
    }
}
#pragma warning restore CS0219 // Variable is assigned but its value is never used

