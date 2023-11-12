using RRCG;
using System.Collections.Generic;
using RRCGBuild;

namespace RRCGBuild
{
    public class Tree : CircuitBuilder
    {
        Variable<IntPort> integer = new Variable<IntPort>();
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            integer.Value = 0;
            ChipLib.Log(ListCreate2());
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public dynamic ListCreate2()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __Return(rrcg_return_flow, out rrcg_return_data, ListCreate<ListPort<ListPort<IntPort>>>(//ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            //ListCreate1(),
            ListCreate1()));
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        public dynamic ListCreate1()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __Return(rrcg_return_flow, out rrcg_return_data, ListCreate<ListPort<IntPort>>(ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0(), ListCreate0()));
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }

        public dynamic ListCreate0()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            dynamic rrcg_return_data = default;
            __Return(rrcg_return_flow, out rrcg_return_data, ListCreate<IntPort>(integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value, integer.Value));
            ExecFlow.current.Merge(rrcg_return_flow);
            return rrcg_return_data;
        }
    }
}