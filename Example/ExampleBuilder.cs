using System.Collections.Generic;
using RRCG;

namespace RRCGBuild
{
    public class ExampleBuilder : CircuitBuilder
    {

        public override Context BuildCircuitGraph()
        {

            List<Node> nodes = new List<Node>();
            List<Connection> connections = new List<Connection>();

            Context.current = new Context
            {
                Nodes = nodes,
                Connections = connections
            };

            ExecFlow execFlow = new ExecFlow();
            CircuitGraph();

            return Context.current;
        }


        public override void CircuitGraph()
        {
            throw new System.NotImplementedException();
        }

        // This should be translated from "Main"
        public void Main()
        {
            ChipBuilder.EventReceiver(RoomEvents.Hz30);

            StringPort result = FormatMessage(new StringPort { Data = "b" });

            PrintResult(result);
        }

        public StringPort FormatMessage(StringPort message)
        {
            ChipBuilder.EventReceiver(RoomEvents.Hz30);

            return ChipBuilder.Concat(new StringPort { Data = "a message:" }, message);
        }

        public void PrintResult(StringPort result)
        {
            ChipBuilder.EventReceiver(RoomEvents.Hz30);

            ChipBuilder.LogString(result);
        }


        public void SimpleIf()
        {
            ChipBuilder.EventReceiver(RoomEvents.Hz30);

            IntPort result = ChipBuilder.Add(new IntPort { Data = 3 }, new IntPort { Data = 4 });
            BoolPort test = ChipBuilder.GreaterThan(result, ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 }));

            ChipBuilder.If(test,
            delegate ()
            {
                ChipBuilder.LogString(new StringPort { Data = "If" });
            },
            delegate ()
            {
                ChipBuilder.LogString(new StringPort { Data = "Else" });
            });

            ChipBuilder.LogString(new StringPort { Data = "SimpleIf" });

        }

        public void ComplexIf()
        {
            ChipBuilder.EventReceiver(RoomEvents.Hz30);

            IntPort sum = ChipBuilder.Add(new IntPort { Data = 3 }, new IntPort { Data = 4 });

            ChipBuilder.If(ChipBuilder.GreaterThan(sum, ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 })),
                delegate ()
                {
                    ChipBuilder.LogString(new StringPort { Data = "If" });
                },
                delegate ()
                {
                    ChipBuilder.If(ChipBuilder.GreaterThan(sum, ChipBuilder.RandomInt(new IntPort { Data = 0 }, new IntPort { Data = 10 })),
                        delegate ()
                        {
                            ChipBuilder.LogString(new StringPort { Data = "Second Chance" });
                        },
                        delegate ()
                        {
                            ChipBuilder.LogString(new StringPort { Data = "Else" });
                            ExecFlow.current.Clear();
                        }
                    );
                }
            );

            ChipBuilder.LogString(new StringPort { Data = "No Early return" });
        }

    }
}

