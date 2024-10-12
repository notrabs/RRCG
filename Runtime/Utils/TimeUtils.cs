using System.Diagnostics;

namespace RRCG
{
    // A more convenient stopwatch
    public class ProfilingTimer
    {
        Stopwatch sw;

        public ProfilingTimer()
        {
            sw = new Stopwatch();
            sw.Start();
        }

        public double SecondsElapsed => sw.Elapsed.TotalSeconds;
        public string Formatted { get => $"{SecondsElapsed:f2}s"; }

        /// <summary> Returns the current time and resets afterwards </summary>
        public string StartNew()
        {
            var current = Formatted;
            sw.Restart();
            return current;
        }
    }
}
