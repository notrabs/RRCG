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
                // We're about to advance into an execution port,
                // let's try to process pending labels
                var accessScopeOrNull = SemanticStack.current.GetNextScopeWithType<SemanticStack.AccessibilityScope>();

                while (accessScopeOrNull is SemanticStack.AccessibilityScope accessScope &&
                       accessScope.PendingLabels.Count > 0)
                {
                    var labelName = accessScope.PendingLabels[0];
                    accessScope.PendingLabels.RemoveAt(0);

                    // Merge pending goto exec flows in with us
                    if (accessScope.PendingGotos.TryGetValue(labelName, out var flow))
                    {
                        Merge(flow);
                        accessScope.PendingGotos.Remove(labelName);
                    }

                    // Declare the label in the access scope
                    accessScope.PendingLabels.Remove(labelName);
                    accessScope.DeclaredLabels[labelName] = inPort;
                }

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