namespace RRCGSource
{
    /// <summary>
    /// A helper that creates a synced variable for each entry of the array.
    /// </summary>
    /// <typeparam name="T">A RR data type that supports synced variables</typeparam>
    public class SyncedArray<T>
    {
        public SyncedArray(int count) { }

        public T this[int i]
        {
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