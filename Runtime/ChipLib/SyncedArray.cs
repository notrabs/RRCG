using System.Collections.Generic;

namespace RRCGSource
{
    /// <summary>
    /// A helper that creates a synced variable for each entry of the array.
    /// </summary>
    /// <typeparam name="T">A Rec Room data type that supports synced variables</typeparam>
    public class SyncedArray<T>
    {
        /// <summary>Construct a synced array. The count supplied must be pure-data.</summary>
        public SyncedArray(int count) { }

        /// <summary>
        /// Reads a value and stores it in a temporary cache to make it safe for subsequent reads.
        /// </summary>
        public T GetSafe(int index) { return default; }

        public T this[int i]
        {
            /// <summary>Reads a value. WARDNING: Only the last read value is safe to use. Use GetSafe to access a cached copy.</summary>
            get { return default; }
            set { }
        }

        /// <summary>
        /// Returns the current state of the SyncedArray wrapped in a list
        /// WARNING: Every access of the returned value will create a new list.
        /// You should consider caching the result (e.g. with <see cref="ChipLib.EventCache"/>)
        /// </summary>
        /// <returns></returns>
        public List<T> AsList() => default;
    }

    /// <summary>
    /// A SyncedArray&lt;int&gt; with optimized functions for int operations
    /// </summary>
    public class SyncedArrayInt : SyncedArray<int>
    {
        /// <inheritdoc cref="SyncedArray{T}.SyncedArray(int)"/>
        public SyncedArrayInt(int count) : base(count) { }

        /// <summary>
        /// Increments the array element at the <paramref name="index"/> by the provided <paramref name="value"/>.
        /// This is more efficient than reading the value, incrementing, and writing it back.
        /// The <paramref name="value"/> can also be negative if you need to decrement.
        /// </summary>
        public void Add(int index, int value) { }
    }
}