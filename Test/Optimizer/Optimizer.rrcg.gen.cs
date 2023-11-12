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
            var optimizableBool = ParseBool("true").Result;
            ChipBuilder.If(true, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(!true, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(Not(true), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            var optimizableButNotDeletable = !ParseBool("true").Result;
            ChipBuilder.If(optimizableButNotDeletable, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipLib.Log(optimizableButNotDeletable);
            ChipBuilder.If(optimizableBool, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(!optimizableBool, delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(ChipBuilder.Equals(ParseInt("1").Result, 1), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ChipBuilder.If(ChipBuilder.Not(ChipBuilder.Equals(ParseInt("1").Result, 1)), delegate
            {
                LogString("true");
            }

            , delegate
            {
                LogString("false");
            }

            );
            ExecFlow.current.Merge(rrcg_return_flow);
        }
    }
}
#pragma warning restore CS0162 // Unreachable code detected

