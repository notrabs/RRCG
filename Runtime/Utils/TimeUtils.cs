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
        public double SecondsElapsed => (DateTime.Now - startTime).TotalSeconds;
        public string Formatted { get => $"{SecondsElapsed:f2}s"; }

        /// <summary> Returns the current time and resets afterwards </summary>
        public string StartNew()
        {
            var current = Formatted;
            startTime = DateTime.Now;
            return current;
        }
    }
}
