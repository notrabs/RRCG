using System.Collections.Generic;

namespace RRCGSource
{
    public class ChipLib
    {
        /// <summary>
        /// Creates a temporary event to cache the value for further executions
        /// </summary>
        /// <typeparam name="T0">The type of port to cache</typeparam>
        /// <param name="value0">The value to cache</param>
        /// <returns>The cached value</returns>
        public static T0 EventCache<T0>(T0 value0) { return default; }

        /// <summary>
        /// Logs a value to the console with automatic ToString conversion
        /// </summary>
        public static void Log(object obj) { }

        /// <summary>
        /// Contines on the delayed exec port instead of the immediate one
        /// </summary>
        public static void AwaitDelay(float delay = 0) { }

        /// <summary>
        /// A simple execution counter, that is cheaper than a variable. Can't be reset.
        /// </summary>
        public static int RandomStoreCounter() { return default; }

        /// <summary>
        /// A modulated execution counter, that is cheaper than a variable.
        /// </summary>
        public static int RandomStoreCounter(int modulus) { return default; }

        /// <summary>
        /// A Look-Up-Table to generate a shared, switch-based accessor for a large list of data.
        /// </summary>
        public class LUT<T>
        {
            public LUT(IEnumerable<T> list) { }

            /// <summary>
            /// Call immediately before reading a value. The output will change if a different index is read.
            /// </summary>
            public T Read(int index) { return default; }

            /// <summary>
            /// Read from this port if you have already called Read()
            /// </summary>
            public T UnsafeReadPort;
        }
    }
}
