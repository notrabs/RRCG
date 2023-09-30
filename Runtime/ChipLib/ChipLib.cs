using System.Collections.Generic;
using UnityEngine;

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
        public static (T0, T1) EventCache<T0, T1>(T0 value0, T1 value1) { return default; }
        public static (T0, T1, T2) EventCache<T0, T1, T2>(T0 value0, T1 value1, T2 value2) { return default; }
        public static (T0, T1, T2, T3) EventCache<T0, T1, T2, T3>(T0 value0, T1 value1, T2 value2, T3 value3) { return default; }

        /// <summary>
        /// Logs a value to the console with automatic ToString conversion
        /// </summary>
        public static void Log(object obj) { }

        /// <summary>
        /// Contines on the delayed exec port instead of the immediate one
        /// </summary>
        public static void AwaitDelay(float delay = 0) { }

        /// <summary>
        /// Throttles an exec signal to only occur once per interval. Further executions are blocked until the interval expires.
        /// </summary>
        public static void Throttle(float interval) { }

        /// <summary>
        /// A simple execution counter, that is cheaper than a variable. Can't be reset.
        /// </summary>
        public static int RandomStoreCounter() { return default; }

        /// <summary>
        /// A modulated execution counter, that is cheaper than a variable.
        /// </summary>
        public static int RandomStoreCounter(int modulus) { return default; }

        /// <summary>
        /// Constructs a simple switch to return a value by index. Supports 64 values. Consider using a ChipLib.LUT for bigger look up tables.
        /// </summary>
        public static T ValueSwitch<T>(int index, params T[] options) { return default; }

        /// <summary>
        /// Picks a random value from the options using a value switch.
        /// </summary>
        public static T PickRandom<T>(params T[] options) { return default; }

        /// <summary>
        /// Picks a random, non repeating value [0,num). It is stored in an efficient random store.
        /// </summary>
        public static int RandomNonRepeating(int num) { return default; }

        /// <summary>
        /// Picks a random, non repeating value [0,num) and stores it in the given variable
        /// </summary>
        public static int RandomNonRepeating(IVariable<int> variable, int num) { return default; }

        /// <summary>
        /// Gets the closest RRObject of type T
        /// </summary>
        public static T GetClosest<T>(Player position, string tag) { return default; }
        public static T GetClosest<T>(Vector3 position, string tag) { return default; }
        public static T GetClosest<T>(RecRoomObject position, string tag) { return default; }

        public static void RequireKey(string keyName) { }

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
