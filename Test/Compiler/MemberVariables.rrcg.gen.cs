using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class MemberVariables : CircuitBuilder
    {
        // Some invalid member variables..
        // Number of cloud variable arguments must match the number of declared variables
        //[CloudVariable("Too", "Many")]
        //int CloudVariable1;
        //[CloudVariable("Too", "Many")] // Multiple member decls. in a single property decl. do not work, unlike fields!
        //int CloudVariable2 { get; set; }
        //[CloudVariable("Too", "Little")]
        //int CloudVariable3, CloudVariable4, CloudVariable5;
        // Cloud variable arguments must be unique
        //[CloudVariable("SameName", "SameName")]
        //int CloudVariable6, CloudVariable7;
        // Properties must be auto-implemented to be member variables
        //[Variable]
        //string PropertyVariable2 => "Constant";
        //[SyncedVariable]
        //string PropertyVariable3
        //{
        //    get => UnderlyingField3;
        //    set
        //    {
        //        UnderlyingField3 = value;
        //    }
        //}
        //string UnderlyingField3 = "Manual";
        // Properties must define a getter and setter to be member variables
        //[Variable]
        //string PropertyVariable4 { get; }
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RoomEvent.TestEvent();
            // Test assignments..
            FieldVariable = FieldVariable + 1;
            SyncedFieldVariable = SyncedFieldVariable + ", assigned suffix (field)";
            CloudFieldVariable = false;
            PropertyVariable += 1;
            SyncedPropertyVariable += ", assigned suffix (property)";
            CloudPropertyVariable = true;
            // Test reads...
            ChipLib.Log(FieldVariable);
            ChipLib.Log(SyncedFieldVariable);
            ChipLib.Log(CloudFieldVariable);
            ChipLib.Log(PropertyVariable);
            ChipLib.Log(SyncedPropertyVariable);
            ChipLib.Log(CloudPropertyVariable);
            // Test change events...
            TestChangeEvent("FieldVariable", FieldVariable);
            TestChangeEvent("SyncedFieldVariable", SyncedFieldVariable);
            TestChangeEvent("CloudFieldVariable", CloudFieldVariable);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestChangeEvent(StringPort name, object member)
        {
            __BeginReturnScope("TestChangeEvent", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<StringPort>("name", null, () => name!, (_RRCG_SETTER_VALUE) => name = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<object>("member", null, () => member!, (_RRCG_SETTER_VALUE) => member = _RRCG_SETTER_VALUE);
            MemberVariableChanged(member, () =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                LogString(__StringInterpolation("Change event fired for member: ", name));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_FieldVariable = __CreateNamedVariable<IntPort>("FieldVariable", 1000, VariableKind.Local);
        public IntPort FieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_FieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldVariable.Value = value;
        }

        private NamedVariable<StringPort> __RRCG_MEMBER_VARIABLE_SyncedFieldVariable = __CreateNamedVariable<StringPort>("SyncedFieldVariable", "Home value", VariableKind.Synced);
        public StringPort SyncedFieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedFieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedFieldVariable.Value = value;
        }

        private NamedVariable<BoolPort> __RRCG_MEMBER_VARIABLE_CloudFieldVariable = __CreateNamedVariable<BoolPort>("FieldCloudVariable", null !, VariableKind.Cloud);
        public BoolPort CloudFieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_CloudFieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_CloudFieldVariable.Value = value;
        }

        private NamedVariable<IntPort> __RRCG_MEMBER_VARIABLE_PropertyVariable = __CreateNamedVariable<IntPort>("PropertyVariable", 2000, VariableKind.Local);
        public IntPort PropertyVariable
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyVariable.Value;
            private set => __RRCG_MEMBER_VARIABLE_PropertyVariable.Value = value;
        }

        private NamedVariable<StringPort> __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable = __CreateNamedVariable<StringPort>("SyncedPropertyVariable", "Home value", VariableKind.Synced);
        public StringPort SyncedPropertyVariable
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable.Value = value;
        }

        private NamedVariable<BoolPort> __RRCG_MEMBER_VARIABLE_CloudPropertyVariable = __CreateNamedVariable<BoolPort>("PropertyCloudVariable", null !, VariableKind.Cloud);
        public BoolPort CloudPropertyVariable
        {
            private get => __RRCG_MEMBER_VARIABLE_CloudPropertyVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_CloudPropertyVariable.Value = value;
        }
    }
}