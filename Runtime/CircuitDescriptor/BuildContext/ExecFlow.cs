using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public delegate void AlternativeExec();

    public class ExecFlow
    {
        public static ExecFlow current;

        public List<Port> Ports = new List<Port>();

        public bool hasAdvanced = false;

        public void Advance(Context context, Port inPort, Port outPort)
        {
            if (inPort != null)
            {
                foreach (Port port in Ports)
                {
                    context.Connections.Add(new Connection
                    {
                        From = port,
                        To = inPort,
                        isExec = true,
                    });
                }

            }

            Ports.Clear();

            if (outPort != null)
            {
                Ports.Add(outPort);
            }

            hasAdvanced = true;
        }


        public void Clear()
        {
            Ports.Clear();

            hasAdvanced = true;
        }

        public void Merge(ExecFlow flow)
        {
            Ports.AddRange(flow.Ports);

            hasAdvanced = true;
        }
    }
}