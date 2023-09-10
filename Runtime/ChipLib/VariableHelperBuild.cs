using System;

namespace RRCGBuild
{
    public enum VariableKind
    {
        Local,
        Synced,
        Cloud
    }

    public class VariableHelper<T> where T : AnyPort, new()
    {
        private string name;
        private VariableKind kind;
        private T homeValue;

        private T VariableGetterPort;

        public VariableHelper(T homeValue, VariableKind kind = VariableKind.Local)
        {
            if (!homeValue.IsDataPort) throw new ArgumentException("homeValue needs to be static, not a port");

            name = "RRCG_var_" + Context.current.GetUniqueId();
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
            Context.lastSpawnedNode.VariableHomeValue = homeValue.Data;

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
}
