using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Optimizer : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            TestNotIfOptimizer();
            TestKnownSingletonChipsOptimizer();
            TestVariableCollapseOptimizer();
            TestAssociativeOperationCollapseOptimizer();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestNotIfOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("TestNotIfOptimizer").Receiver();
            BoolPort optimizableBool = __VariableDeclaratorExpression<BoolPort>("optimizableBool", () => ParseBool("true").Result, (_RRCG_SETTER_VALUE) => optimizableBool = _RRCG_SETTER_VALUE);
            ChipBuilder.If(true, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipBuilder.If(!true, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipBuilder.If(Not(true), delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            BoolPort optimizableButNotDeletable = __VariableDeclaratorExpression<BoolPort>("optimizableButNotDeletable", () => !ParseBool("true").Result, (_RRCG_SETTER_VALUE) => optimizableButNotDeletable = _RRCG_SETTER_VALUE);
            ChipBuilder.If(optimizableButNotDeletable, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipLib.Log(optimizableButNotDeletable);
            ChipBuilder.If(optimizableBool, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipBuilder.If(!optimizableBool, delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipBuilder.If(ChipBuilder.Equals(ParseInt("1").Result, 1), delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ChipBuilder.If(ChipBuilder.Not(ChipBuilder.Equals(ParseInt("1").Result, 1)), delegate
            {
                __BeginAccessibilityScope(true);
                LogString("true");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(true);
                LogString("false");
                __EndAccessibilityScope();
            }

            );
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestKnownSingletonChipsOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("TestKnownSingletonChipsOptimizer").Receiver();
            RRCGBuild.Variable<FloatPort> floatVar = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("floatVar", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => floatVar = _RRCG_SETTER_VALUE);
            // All these Time Get Precise Seconds nodes
            // will be collapsed into a single node.
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            floatVar.Value = TimeGetPreciseSeconds();
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestVariableCollapseOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("TestVariableCollapseOptimiser").Receiver();
            RRCGBuild.Variable<FloatPort> var0 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var0", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => var0 = _RRCG_SETTER_VALUE);
            RRCGBuild.Variable<FloatPort> var1 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var1", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => var1 = _RRCG_SETTER_VALUE);
            RRCGBuild.Variable<FloatPort> var2 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var2", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => var2 = _RRCG_SETTER_VALUE);
            RRCGBuild.Variable<FloatPort> var3 = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("var3", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => var3 = _RRCG_SETTER_VALUE);
            // All read-only instances of each
            // variable will be collapsed into
            // the "writing" instance.
            var0.Value = RandomFloat(0, 100);
            ChipLib.Log(var0.Value);
            var1.Value = RandomFloat(0, 100);
            ChipLib.Log(var1.Value);
            var2.Value = RandomFloat(0, 100);
            ChipLib.Log(var2.Value);
            var3.Value = RandomFloat(0, 100);
            ChipLib.Log(var3.Value);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        void TestAssociativeOperationCollapseOptimizer()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("TestAssociativeOperationCollapseOptimizer").Receiver();
            RRCGBuild.Variable<FloatPort> variable = __VariableDeclaratorExpression<RRCGBuild.Variable<FloatPort>>("variable", () => new Variable<FloatPort>(), (_RRCG_SETTER_VALUE) => variable = _RRCG_SETTER_VALUE);
            variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;
            FloatPort undeletableAdd = __VariableDeclaratorExpression<FloatPort>("undeletableAdd", () => variable.Value + 5f, (_RRCG_SETTER_VALUE) => undeletableAdd = _RRCG_SETTER_VALUE);
            FloatPort collapsible = __VariableDeclaratorExpression<FloatPort>("collapsible", () => undeletableAdd + 1f + 2f + 3f + 4f, (_RRCG_SETTER_VALUE) => collapsible = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
            ChipLib.Log(collapsible);
            StringPort spacePort = __VariableDeclaratorExpression<StringPort>("spacePort", () => Reroute<StringPort>(" "), (_RRCG_SETTER_VALUE) => spacePort = _RRCG_SETTER_VALUE);
            ChipLib.Log("Hello" + spacePort + "World");
            StringPort undeletableConcat = __VariableDeclaratorExpression<StringPort>("undeletableConcat", () => "Undeletable" + spacePort + "concat", (_RRCG_SETTER_VALUE) => undeletableConcat = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
            ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);
            FloatPort undeletableSubtract = __VariableDeclaratorExpression<FloatPort>("undeletableSubtract", () => ChipLib.FloatConst(50f) - ChipLib.FloatConst(10f) - (ChipLib.FloatConst(5f) - ChipLib.FloatConst(3f)), (_RRCG_SETTER_VALUE) => undeletableSubtract = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableSubtract); // Log to make it undeletable
            ChipLib.Log(undeletableSubtract - 5f);
            FloatPort undeletableDivide = __VariableDeclaratorExpression<FloatPort>("undeletableDivide", () => ChipLib.FloatConst(50f) / ChipLib.FloatConst(0.2f) / (ChipLib.FloatConst(0.4f) / ChipLib.FloatConst(0.8f)), (_RRCG_SETTER_VALUE) => undeletableDivide = _RRCG_SETTER_VALUE);
            ChipLib.Log(undeletableDivide); // Log to make it undeletable
            ChipLib.Log(undeletableDivide / 5f);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

