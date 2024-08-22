using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
    public class EntryPointsTest : RRCGBuild.CircuitBuilder
    {
        RRCGBuild.IntPort a = __NamedAssignment<RRCGBuild.IntPort>("a", () => RandomInt(1, 10));
        public EntryPointsTest()
        {
            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
            RRCGBuild.ChipLib.Log("constructor");
            __EndAccessibilityScope();
        }

        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("main circuit graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        void PrivateGraph()
        {
            __BeginReturnScope("PrivateGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("private graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        protected void ProtectedGraph()
        {
            __BeginReturnScope("ProtectedGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("protected graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        protected void InternalGraph()
        {
            __BeginReturnScope("InternalGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("internal graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        public void PublicGraph()
        {
            __BeginReturnScope("PublicGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            RRCGBuild.ChipLib.Log("public graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}