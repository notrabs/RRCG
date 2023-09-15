using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class ExecFlow
    {
        public static ExecFlow current;

        public List<Port> Ports = new List<Port>();

        public bool hasAdvanced = false;
        public bool hasCleared = false;

        public bool hasAdvancedOrCleared { get => hasAdvanced || hasCleared; }

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

            hasCleared = true;
        }

        public void Merge(ExecFlow flow)
        {
            Ports.AddRange(flow.Ports);

            hasAdvanced = this.hasAdvanced || flow.hasAdvanced;
            hasCleared = this.hasCleared || flow.hasCleared;
        }
    }
}