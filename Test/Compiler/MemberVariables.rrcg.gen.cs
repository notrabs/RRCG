using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class MemberVariables : RRCGBuild.CircuitBuilder
    {
        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_FieldVariable = __CreateNamedVariable<RRCGBuild.IntPort>("FieldVariable", 1000, VariableKind.Local);
        public RRCGBuild.IntPort FieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_FieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_FieldVariable.Value = value;
        }

        private NamedVariable<RRCGBuild.StringPort> __RRCG_MEMBER_VARIABLE_SyncedFieldVariable = __CreateNamedVariable<RRCGBuild.StringPort>("SyncedFieldVariable", "Home value", VariableKind.Synced);
        public RRCGBuild.StringPort SyncedFieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedFieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedFieldVariable.Value = value;
        }

        private NamedVariable<RRCGBuild.BoolPort> __RRCG_MEMBER_VARIABLE_CloudFieldVariable = __CreateNamedVariable<RRCGBuild.BoolPort>("FieldCloudVariable", null !, VariableKind.Cloud);
        public RRCGBuild.BoolPort CloudFieldVariable
        {
            get => __RRCG_MEMBER_VARIABLE_CloudFieldVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_CloudFieldVariable.Value = value;
        }

        private NamedVariable<RRCGBuild.IntPort> __RRCG_MEMBER_VARIABLE_PropertyVariable = __CreateNamedVariable<RRCGBuild.IntPort>("PropertyVariable", 2000, VariableKind.Local);
        public RRCGBuild.IntPort PropertyVariable
        {
            get => __RRCG_MEMBER_VARIABLE_PropertyVariable.Value;
            private set => __RRCG_MEMBER_VARIABLE_PropertyVariable.Value = value;
        }

        private NamedVariable<RRCGBuild.StringPort> __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable = __CreateNamedVariable<RRCGBuild.StringPort>("SyncedPropertyVariable", "Home value", VariableKind.Synced);
        public RRCGBuild.StringPort SyncedPropertyVariable
        {
            get => __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_SyncedPropertyVariable.Value = value;
        }

        private NamedVariable<RRCGBuild.BoolPort> __RRCG_MEMBER_VARIABLE_CloudPropertyVariable = __CreateNamedVariable<RRCGBuild.BoolPort>("PropertyCloudVariable", null !, VariableKind.Cloud);
        public RRCGBuild.BoolPort CloudPropertyVariable
        {
            private get => __RRCG_MEMBER_VARIABLE_CloudPropertyVariable.Value;
            set => __RRCG_MEMBER_VARIABLE_CloudPropertyVariable.Value = value;
        }

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
            RRCGBuild.RoomEvent.TestEvent();
            // Test assignments..
            FieldVariable = FieldVariable + 1;
            SyncedFieldVariable = SyncedFieldVariable + ", assigned suffix (field)";
            CloudFieldVariable = false;
            PropertyVariable += 1;
            SyncedPropertyVariable += ", assigned suffix (property)";
            CloudPropertyVariable = true;
            RRCGBuild.ChipLib.Log(FieldVariable);
            RRCGBuild.ChipLib.Log(SyncedFieldVariable);
            RRCGBuild.ChipLib.Log(CloudFieldVariable);
            RRCGBuild.ChipLib.Log(PropertyVariable);
            RRCGBuild.ChipLib.Log(SyncedPropertyVariable);
            RRCGBuild.ChipLib.Log(CloudPropertyVariable);
            // Test change events...
            TestChangeEvent<RRCGBuild.IntPort>("FieldVariable", FieldVariable);
            TestChangeEvent<RRCGBuild.StringPort>("SyncedFieldVariable", SyncedFieldVariable);
            TestChangeEvent<RRCGBuild.BoolPort>("CloudFieldVariable", CloudFieldVariable);
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        void TestChangeEvent<T>(RRCGBuild.StringPort name, T member)
            where T : AnyPort, new()
        {
            __BeginReturnScope("TestChangeEvent", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            __VariableDeclaratorExpression<RRCGBuild.StringPort>("name", null, () => name!, (_RRCG_SETTER_VALUE) => name = _RRCG_SETTER_VALUE);
            __VariableDeclaratorExpression<T>("member", null, () => member!, (_RRCG_SETTER_VALUE) => member = _RRCG_SETTER_VALUE);
            MemberVariableChanged<T>(member, (value) =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                __VariableDeclaratorExpression<T>("value", null, () => value!, (_RRCG_SETTER_VALUE) => value = _RRCG_SETTER_VALUE);
                LogString(__StringInterpolation("Change event fired for member: ", name));
                LogString(__StringInterpolation("Got value: ", value));
                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}