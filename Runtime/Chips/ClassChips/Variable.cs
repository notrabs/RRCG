using System;

namespace RRCGSource
{
    public enum VariableKind
    {
        Local,
        Synced,
        Cloud
    }

    public interface IVariable<T>
    {
        public T Value { get; set; }

        public void ChangedEvent();
    }

    public class NamedVariable<T> : IVariable<T>
    {
        private VariableKind kind;

        public NamedVariable(string name, T homeValue, VariableKind kind) { }

        public T Value { get; set; }

        public void ChangedEvent() { }
    }

    public class Variable<T> : NamedVariable<T>
    {
        public Variable(T homeValue = default) : base("", homeValue, VariableKind.Local) { }
    }

    public class SyncedVariable<T> : NamedVariable<T>
    {
        public SyncedVariable(T homeValue = default) : base("", homeValue, VariableKind.Synced) { }
    }

    public class CloudVariable<T> : NamedVariable<T>
    {
        public CloudVariable(string name) : base(name, default, VariableKind.Cloud) { }
    }

    [Obsolete("Please use Variable/SyncedVariable/CloudVariable instead.")]
    public class VariableHelper<T> : Variable<T> {
        public VariableHelper(T homeValue = default, VariableKind kind = VariableKind.Local) { }
    }
}
