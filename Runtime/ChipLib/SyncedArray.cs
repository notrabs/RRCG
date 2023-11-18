namespace RRCGSource
{
    /// <summary>
    /// A helper that creates a synced variable for each entry of the array.
    /// </summary>
    /// <typeparam name="T">A RR data type that supports synced variables</typeparam>
    public class SyncedArray<T>
    {
        public SyncedArray(int count) { }

        // Reads a value and stores it in a temporary cache to make it safe for subsequent reads.
        public T GetSafe(int index) { return default; }

        public T this[int i]
        {
            // Reads a value. WARDNING: Only the last read value is safe to use. Use GetSafe to access a cached copy.
            get { return default; }
            set { }
        }
    }

    /// <summary>
    /// A SyncedArray<int> with optimized functions for int operations
    /// </summary>
    public class SyncedArrayInt : SyncedArray<int>
    {
        public SyncedArrayInt(int count) : base(count) { }

        public void Add(int index, int value) { }
    }
}