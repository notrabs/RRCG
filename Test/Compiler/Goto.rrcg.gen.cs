using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

    public class Goto : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginLabelAccessibilityScope(false);
            ExecFlow rrcg_return_flow = new ExecFlow();
            var GotoTest = __VariableDeclaratorExpression("GotoTest", () => new EventDefinition());
            GotoTest.Receiver();
                __LabelDecl("label1");
                LogString("Label 1!");
            ChipBuilder.If(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                __Goto("label1");
                __EndLabelAccessibilityScope();
            }

            , delegate
            {
                __BeginLabelAccessibilityScope(true);
                __EndLabelAccessibilityScope();
            }

            );
            LogString("Did not go to label1");
            ChipBuilder.If(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                __Goto("label2");
                __EndLabelAccessibilityScope();
            }

            , delegate
            {
                __BeginLabelAccessibilityScope(true);
                __EndLabelAccessibilityScope();
            }

            );
            LogString("Did not go to label2");
                __LabelDecl("label2");
                LogString("Label 2");
                __LabelDecl("label3");
                    __LabelDecl("label4");
                        __LabelDecl("label5");
                        LogString("Label 3, 4, 5");
            {
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    LogString("Going to label3");
                    __Goto("label3");
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    LogString("Going to label4");
                    __Goto("label4");
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    LogString("Going to label5");
                    __Goto("label5");
                }

                ;
                __Switch(0, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_2}});
            }

            // No scoping weirdness
            CircuitBoard(() =>
            {
                __BeginLabelAccessibilityScope(false);
                ExecFlow rrcg_return_flow = new ExecFlow();
                    __LabelDecl("innerLabel1");
                    LogString("Inner label 1");
                ChipBuilder.If(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __Goto("innerLabel1");
                    __EndLabelAccessibilityScope();
                }

                , delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __EndLabelAccessibilityScope();
                }

                );
                LogString("Did not go to innerLabel1");
                ChipBuilder.If(true, delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __Goto("innerLabel2");
                    __EndLabelAccessibilityScope();
                }

                , delegate
                {
                    __BeginLabelAccessibilityScope(true);
                    __EndLabelAccessibilityScope();
                }

                );
                LogString("Did not go to innerLabel2");
                    __LabelDecl("innerLabel2");
                    LogString("Inner label 2");
                    __LabelDecl("innerLabel3");
                        __LabelDecl("innerLabel4");
                            __LabelDecl("innerLabel5");
                            LogString("Inner label 3, 4, 5");
                {
                    AlternativeExec rrcg_switch_section_0 = delegate
                    {
                        LogString("Going to innerLabel3");
                        __Goto("innerLabel3");
                    }

                    ;
                    AlternativeExec rrcg_switch_section_1 = delegate
                    {
                        LogString("Going to innerLabel4");
                        __Goto("innerLabel4");
                    }

                    ;
                    AlternativeExec rrcg_switch_section_2 = delegate
                    {
                        LogString("Going to innerLabel5");
                        __Goto("innerLabel5");
                    }

                    ;
                    __Switch(0, delegate
                    {
                    }

                    , new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_2}});
                }

                ExecFlow.current.Merge(rrcg_return_flow);
                __EndLabelAccessibilityScope();
            }

            );
            ChipBuilder.If(true, delegate
            {
                __BeginLabelAccessibilityScope(true);
                    __LabelDecl("blockLabel");
                    LogString("Block label");
                __EndLabelAccessibilityScope();
            }

            , delegate
            {
                __BeginLabelAccessibilityScope(true);
                __EndLabelAccessibilityScope();
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
            __EndLabelAccessibilityScope();
        //goto blockLabel;
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

