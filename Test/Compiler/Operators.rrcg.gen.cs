using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            NativeIntOperators();
            NativeFloatOperators();
            PortIntOperators();
            PortFloatOperators();
            MixedOperators();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            IntPort nativeA = 1;
            IntPort nativeB = 2;
            ChipLib.Log(ChipBuilder.Add(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Subtract(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Multiply(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Divide(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Modulo(nativeA, nativeB));
            IntPort postIncrement = 0;
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = 0;
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            IntPort postDecrement = 0;
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = 0;
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort nativeA = 1;
            FloatPort nativeB = 2;
            ChipLib.Log(ChipBuilder.Add(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Subtract(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Multiply(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Divide(nativeA, nativeB));
            ChipLib.Log(ChipBuilder.Modulo(nativeA, nativeB));
            FloatPort postIncrement = 0;
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = 0;
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            FloatPort postDecrement = 0;
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = 0;
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            IntPort portA = RandomInt(0, 0);
            IntPort portB = RandomInt(0, 0);
            ChipLib.Log(ChipBuilder.Add(portA, portB));
            ChipLib.Log(ChipBuilder.Subtract(portA, portB));
            ChipLib.Log(ChipBuilder.Multiply(portA, portB));
            ChipLib.Log(ChipBuilder.Divide(portA, portB));
            ChipLib.Log(ChipBuilder.Modulo(portA, portB));
            IntPort postIncrement = RandomInt(0, 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = RandomInt(0, 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            IntPort postDecrement = RandomInt(0, 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = RandomInt(0, 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort portA = RandomFloat(1, 1);
            FloatPort portB = RandomFloat(2, 2);
            ChipLib.Log(ChipBuilder.Add(portA, portB));
            ChipLib.Log(ChipBuilder.Subtract(portA, portB));
            ChipLib.Log(ChipBuilder.Multiply(portA, portB));
            ChipLib.Log(ChipBuilder.Divide(portA, portB));
            ChipLib.Log(ChipBuilder.Modulo(portA, portB));
            FloatPort postIncrement = RandomFloat(0, 0);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = RandomFloat(0, 0);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            FloatPort postDecrement = RandomFloat(0, 0);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = RandomFloat(0, 0);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void MixedOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            FloatPort portA = RandomFloat(1, 1);
            IntPort portB = RandomInt(2, 2);
            FloatPort nativeA = 3;
            IntPort nativeB = 4;
            ExecFlow.current.Merge(rrcg_return_flow);
        // TODO: These are not working!
        //ChipLib.Log(portA + portB * nativeA / nativeB);
        //ChipLib.Log(portA + portB * 5);
        //ChipLib.Log(portA * portB + 5);
        }
    }
}