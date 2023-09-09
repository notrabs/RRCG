namespace RRCGSource
{
    public enum VariableKind
    {
        Local,
        Synced,
        Cloud
    }

    public class VariableHelper<T>
    {
        private VariableKind kind;

        public VariableHelper(T homeValue = default, VariableKind kind = VariableKind.Local) { }

        public T Value { get; set; }

        public void ChangedEvent() { }
    }
}
