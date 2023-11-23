using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG
{
    // A more convenient stopwatch
    public class ProfilingTimer
    {
        DateTime startTime = DateTime.Now;
        public string Formatted { get => $"{(DateTime.Now - startTime).TotalSeconds:f2}s"; }
    }
}
