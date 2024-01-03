using RRCG;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
#pragma warning disable CS0162 // Unreachable code detected

#pragma warning disable CS0164 // This label has not been referenced

    public class Goto : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            new EventDefinition("GotoTest").Receiver();
                __LabelDecl("label1");
                LogString("Label 1!");
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Goto("label1");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            LogString("Did not go to label1");
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __Goto("label2");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
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
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    LogString("Going to label3");
                    __Goto("label3");
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_2");
                    LogString("Going to label4");
                    __Goto("label4");
                }

                ;
                AlternativeExec rrcg_switch_section_2 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_3");
                    LogString("Going to label5");
                    __Goto("label5");
                }

                ;
                __Switch(0, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_2}});
                __EndAccessibilityScope();
            }

            // No scoping weirdness
            CircuitBoard(() =>
            {
                __BeginReturnScope("ParenthesizedLambda", null, null);
                __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
                    __LabelDecl("innerLabel1");
                    LogString("Inner label 1");
                __If(__ConditionalContext(), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Goto("innerLabel1");
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
                }

                );
                LogString("Did not go to innerLabel1");
                __If(__ConditionalContext(), () => true, delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __Goto("innerLabel2");
                    __EndAccessibilityScope();
                }

                , delegate
                {
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __EndAccessibilityScope();
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
                    __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    AlternativeExec rrcg_switch_section_0 = delegate
                    {
                        __LabelDecl("rrcg_switch_case_label_1");
                        LogString("Going to innerLabel3");
                        __Goto("innerLabel3");
                    }

                    ;
                    AlternativeExec rrcg_switch_section_1 = delegate
                    {
                        __LabelDecl("rrcg_switch_case_label_2");
                        LogString("Going to innerLabel4");
                        __Goto("innerLabel4");
                    }

                    ;
                    AlternativeExec rrcg_switch_section_2 = delegate
                    {
                        __LabelDecl("rrcg_switch_case_label_3");
                        LogString("Going to innerLabel5");
                        __Goto("innerLabel5");
                    }

                    ;
                    __Switch(0, delegate
                    {
                    }

                    , new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}, {3, rrcg_switch_section_2}});
                    __EndAccessibilityScope();
                }

                __EndAccessibilityScope();
                __EndReturnScope();
            }

            );
            __If(__ConditionalContext(), () => true, delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                    __LabelDecl("blockLabel");
                    LogString("Block label");
                __EndAccessibilityScope();
            }

            , delegate
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                __EndAccessibilityScope();
            }

            );
            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    LogString("Case 1");
                    __If(__ConditionalContext(), () => true, delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        LogString("Going to case 2");
                        __Goto("rrcg_switch_case_label_2");
                        __EndAccessibilityScope();
                    }

                    , delegate
                    {
                        __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                        __EndAccessibilityScope();
                    }

                    );
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_2");
                    LogString("Case 2");
                    __Break();
                }

                ;
                __Switch(1, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{1, rrcg_switch_section_0}, {2, rrcg_switch_section_1}});
                __EndAccessibilityScope();
            }

            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"World\"");
                    LogString("Hello World");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_\"World2\"");
                    LogString("Goto case world");
                    __Goto("rrcg_switch_case_label_\"World\"");
                }

                ;
                __Switch("Hello", delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{"World", rrcg_switch_section_0}, {"World2", rrcg_switch_section_1}});
                __EndAccessibilityScope();
            }

            {
                __BeginAccessibilityScope(AccessibilityScope.Kind.General);
                AlternativeExec rrcg_switch_section_0 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_0");
                        __LabelDecl("testLabel");
                        LogString("TestLabel");
                    __Break();
                }

                ;
                AlternativeExec rrcg_switch_section_1 = delegate
                {
                    __LabelDecl("rrcg_switch_case_label_1");
                    __Goto("testLabel");
                }

                ;
                __Switch(2, delegate
                {
                }

                , new Dictionary<AnyPort, AlternativeExec>{{0, rrcg_switch_section_0}, {1, rrcg_switch_section_1}});
                __EndAccessibilityScope();
            }

            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}
#pragma warning restore CS0164 // This label has not been referenced

#pragma warning restore CS0162 // Unreachable code detected

