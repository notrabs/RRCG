using RRCG;
using System.Collections.Generic;
using UnityEngine;

namespace RRCGSource
{
    public class ChipLib
    {
        /// <summary>
        /// Creates a temporary variable to cache a value for further executions.
        /// If you intend to read it a lot of times, consider using the more heat efficient EventCache instead.
        /// </summary>
        /// <typeparam name="T0">The type of port to cache</typeparam>
        /// <param name="value0">The value to cache</param>
        /// <returns>The cached value</returns>
        public static T0 VariableCache<T0>(T0 value0) => default;

        /// <summary>
        /// Creates a temporary event to cache the value for further executions.
        /// </summary>
        /// <typeparam name="T0">The type of port to cache</typeparam>
        /// <param name="value0">The value to cache</param>
        /// <returns>The cached value</returns>
        public static T0 EventCache<T0>(T0 value0)  => default;
        public static (T0, T1) EventCache<T0, T1>(T0 value0, T1 value1)  => default;
        public static (T0, T1, T2) EventCache<T0, T1, T2>(T0 value0, T1 value1, T2 value2)  => default;
        public static (T0, T1, T2, T3) EventCache<T0, T1, T2, T3>(T0 value0, T1 value1, T2 value2, T3 value3)  => default;

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
        public static int RandomStoreCounter() => default;

        /// <summary>
        /// A modulated execution counter, that is cheaper than a variable.
        /// </summary>
        public static int RandomStoreCounter(int modulus) => default;

        /// <summary>
        /// Constructs a simple switch to return a value by index. Supports 64 values. Consider using a ChipLib.LUT for bigger look up tables.
        /// </summary>
        public static T ValueSwitch<T>(int index, params T[] options) => default;

        /// <summary>
        /// Picks a random value from the options using a value switch.
        /// </summary>
        public static T PickRandom<T>(params T[] options) => default;

        /// <summary>
        /// Picks a random, non repeating value [0,num). It is stored in an efficient random store.
        /// </summary>
        public static int RandomNonRepeating(int num) => default;

        /// <summary>
        /// Picks a random, non repeating value [0,num) and stores it in the given variable
        /// </summary>
        public static int RandomNonRepeating(IVariable<int> variable, int num) => default;

        /// <summary>
        /// Gets the closest RRObject of type T
        /// </summary>
        public static T GetClosest<T>(Player position, string tag) => default;
        public static T GetClosest<T>(Vector3 position, string tag) => default;
        public static T GetClosest<T>(RecRoomObject position, string tag) => default;

        public static void RequireKey(string keyName) { }

        /// <summary>
        /// Creates a list with [count] inputs and the given value assigned to all elements
        /// </summary>
        public static List<T> ListFill<T>(int count, T value) => default;

        /// <summary>
        /// A Look-Up-Table to generate a shared, switch-based accessor for a large list of data.
        /// </summary>
        public class LUT<T>
        {
            public LUT(IEnumerable<T> list) { }

            /// <summary>
            /// Call immediately before reading a value. The output will change if a different index is read.
            /// </summary>
            public T Read(int index) => default;

            /// <summary>
            /// Read from this port if you have already called Read()
            /// </summary>
            public T UnsafeReadPort;
        }

        /// <summary>
        /// Returns a string containing the bit representation of the number.
        /// This operation is quite expensive!
        /// </summary>
        public static string BitString(int bits) => default;

        /// <summary>
        /// A float constant that forces its type. Use e.g. to pass a float constant into the Vector3Scale chip.
        /// Maybe this can be done automatic at some point...
        /// </summary>
        public static float FloatConst(float value) => default;

        /// <summary>
        /// A int constant that forces its type. Use e.g. to pass a int constant into the Vector3Scale chip.
        /// Maybe this can be done automatic at some point...
        /// </summary>
        public static int IntConst(int value) => default;

        /// <summary>
        /// A Raycast chip, but defined by two points instead of direction+distance.
        /// </summary>
        public static (bool Hit, Player Player, RecRoomObject Object, float Distance, Vector3 HitPosition, Vector3 SurfaceNormal) Raycast(Vector3 from, Vector3 to, RaycastData config) => default;
    }
}
