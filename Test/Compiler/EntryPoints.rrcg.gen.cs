using System;
using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;

namespace RRCGBuild
{
    public class EntryPointsTest : CircuitBuilder
    {
        IntPort a;
        public EntryPointsTest()
        {
            a = __VariableDeclaratorExpression<IntPort>("a", () => RandomInt(1, 10), () => a!, (_RRCG_SETTER_VALUE) => a = _RRCG_SETTER_VALUE);
            __BeginAccessibilityScope(AccessibilityScope.Kind.General);
            // This should be executed after class initializers, and before the circuit graph
            ChipLib.Log("constructor");
            __EndAccessibilityScope();
        }

        public override void CircuitGraph()
        {
            __BeginReturnScope("CircuitGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            // This should be the first graph after initialization
            ChipLib.Log("main circuit graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        void PrivateGraph()
        {
            __BeginReturnScope("PrivateGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            // This should start a new graph
            ChipLib.Log("private graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        protected void ProtectedGraph()
        {
            __BeginReturnScope("ProtectedGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            // This should start a new graph
            ChipLib.Log("protected graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        protected void InternalGraph()
        {
            __BeginReturnScope("InternalGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            // This should start a new graph
            ChipLib.Log("internal graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }

        [CircuitGraph]
        public void PublicGraph()
        {
            __BeginReturnScope("PublicGraph", null, null);
            __BeginAccessibilityScope(AccessibilityScope.Kind.MethodRoot);
            // This should start a new graph
            ChipLib.Log("public graph");
            __EndAccessibilityScope();
            __EndReturnScope();
        }
    }
}