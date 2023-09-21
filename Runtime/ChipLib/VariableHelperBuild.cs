using System;

namespace RRCGBuild
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


    public class NamedVariable<T>: IVariable<T> where T : AnyPort, new()
    {
        private string name;
        private VariableKind kind;
        private T homeValue;

        private T VariableGetterPort;

        public NamedVariable(string name, T homeValue = null, VariableKind kind = VariableKind.Local)
        {
            if (homeValue != null && !homeValue.IsDataPort) throw new ArgumentException("homeValue needs to be static, not a port");

            this.name = name;
            this.kind = kind;
            this.homeValue = homeValue;

            var prevFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();

            this.VariableGetterPort = CreateVariableNode(new T());

            ExecFlow.current = prevFlow;
        }

        private T CreateVariableNode(T value)
        {
            T data;

            if (value is StringPort) data = ChipBuilder.stringVariable(value as StringPort) as T;
            else if (value is IntPort) data = ChipBuilder.intVariable(value as IntPort) as T;
            else if (value is BoolPort) data = ChipBuilder.boolVariable(value as BoolPort) as T;
            else if (value is FloatPort) data = ChipBuilder.floatVariable(value as FloatPort) as T;
            else throw new Exception("Variable type not supported yet");

            Context.lastSpawnedNode.VariableName = name;
            Context.lastSpawnedNode.VariableKind = kind;
            Context.lastSpawnedNode.VariableType = typeof(T);
            Context.lastSpawnedNode.VariableHomeValue = homeValue?.Data;

            return data;
        }

        public T Value
        {
            get => VariableGetterPort;
            set { CreateVariableNode(value); }
        }
        public void ChangedEvent()
        {
            ChipBuilder.EventReceiver(name + " Changed");
        }
    }

    public class AutoNamedVariable<T> : NamedVariable<T> where T : AnyPort, new()
    {
        public AutoNamedVariable(T homeValue, VariableKind kind) : base(GenerateName(), homeValue, kind) { }
        public static string GenerateName()
        {
            return "RRCG_var_" + Context.current.GetUniqueId();
        }
    }

    public class Variable<T> : AutoNamedVariable<T> where T : AnyPort, new()
    {
        public Variable(T homeValue = default) : base(homeValue, VariableKind.Local) { }
    }
    public class SyncedVariable<T> : AutoNamedVariable<T> where T : AnyPort, new()
    {
        public SyncedVariable(T homeValue = default) : base(homeValue, VariableKind.Synced) { }
    }
    public class CloudVariable<T> : NamedVariable<T> where T : AnyPort, new()
    {
        public CloudVariable(string name) : base(name, default, VariableKind.Cloud) { }
    }
}
