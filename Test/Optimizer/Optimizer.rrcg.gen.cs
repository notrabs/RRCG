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
            var optimizableBool = __VariableDeclaratorExpression("optimizableBool", () => ParseBool("true").Result);
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
            var optimizableButNotDeletable = __VariableDeclaratorExpression("optimizableButNotDeletable", () => !ParseBool("true").Result);
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
            var floatVar = __VariableDeclaratorExpression("floatVar", () => new Variable<FloatPort>());
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
            var var0 = __VariableDeclaratorExpression("var0", () => new Variable<FloatPort>());
            var var1 = __VariableDeclaratorExpression("var1", () => new Variable<FloatPort>());
            var var2 = __VariableDeclaratorExpression("var2", () => new Variable<FloatPort>());
            var var3 = __VariableDeclaratorExpression("var3", () => new Variable<FloatPort>());
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
            // Addition
            var variable = __VariableDeclaratorExpression("variable", () => new Variable<FloatPort>());
            variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;
            FloatPort undeletableAdd = __VariableDeclaratorExpression("undeletableAdd", () => variable.Value + 5f);
            FloatPort collapsible = __VariableDeclaratorExpression("collapsible", () => undeletableAdd + 1f + 2f + 3f + 4f);
            ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
            ChipLib.Log(collapsible);
            // String concatenation
            var spacePort = __VariableDeclaratorExpression("spacePort", () => Reroute<StringPort>(" "));
            ChipLib.Log("Hello" + spacePort + "World");
            var undeletableConcat = __VariableDeclaratorExpression("undeletableConcat", () => "Undeletable" + spacePort + "concat");
            ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
            ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);
            // Subtraction
            var undeletableSubtract = __VariableDeclaratorExpression("undeletableSubtract", () => ChipLib.FloatConst(50f) - ChipLib.FloatConst(10f) - (ChipLib.FloatConst(5f) - ChipLib.FloatConst(3f)));
            ChipLib.Log(undeletableSubtract); // Log to make it undeletable
            ChipLib.Log(undeletableSubtract - 5f);
            // Division
            var undeletableDivide = __VariableDeclaratorExpression("undeletableDivide", () => ChipLib.FloatConst(50f) / ChipLib.FloatConst(0.2f) / (ChipLib.FloatConst(0.4f) / ChipLib.FloatConst(0.8f)));
            ChipLib.Log(undeletableDivide); // Log to make it undeletable
            ChipLib.Log(undeletableDivide / 5f);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

