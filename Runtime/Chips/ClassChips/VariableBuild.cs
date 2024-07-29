using RRCG;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RRCGBuild
{
    public enum VariableKind
    {
        Local,
        Synced,
        Cloud
    }

    public interface IVariable
    {
        public Type Type { get; }
        public AnyPort Value { get; set; }
        public void ChangedEvent();
        public IVariable ChangedEvent(AlternativeExec OnChanged);
    }

    public interface IVariable<T> where T : AnyPort
    {
        public T Value { get; set; }

        public void ChangedEvent();
        public IVariable<T> ChangedEvent(AlternativeExec OnChanged);
    }


    public class NamedVariable<T> : IVariable<T>, IVariable where T : AnyPort, new()
    {
        private string name;
        private VariableKind kind;
        private T homeValue;

        private T VariableGetterPort;

        private static readonly Type[] SupportsHomeValue = new[] { typeof(IntPort), typeof(BoolPort), typeof(FloatPort), typeof(StringPort), typeof(ColorPort) };

        public NamedVariable(string name, T homeValue = null, VariableKind kind = VariableKind.Local)
        {
            if (homeValue != null)
                if (kind == VariableKind.Cloud)
                    throw new ArgumentException("Cloud variables don't support home values!");
                else if (!SupportsHomeValue.Contains(typeof(T)))
                    throw new ArgumentException($"Home values not supported for variable type {typeof(T).Name}");
                else if (!homeValue.IsDataPort)
                    throw new ArgumentException("homeValue needs to be static, not a port");

            this.name = name;
            this.kind = kind;
            this.homeValue = homeValue;

            this.VariableGetterPort = CircuitBuilder.InlineGraph(() => CreateVariableNode(new T()));
        }

        private T CreateVariableNode(T value)
        {
            var variableConfig = new VariableData(name, kind, typeof(T), homeValue?.Data);

            T data = value switch
            {
                IntPort typed => ChipBuilder.IntVariable(typed, variableConfig) as T,
                BoolPort typed => ChipBuilder.BoolVariable(typed, variableConfig) as T,
                FloatPort typed => ChipBuilder.FloatVariable(typed, variableConfig) as T,
                StringPort typed => ChipBuilder.StringVariable(typed, variableConfig) as T,
                PlayerPort typed => ChipBuilder.PlayerVariable(typed, variableConfig) as T,
                RecRoomObjectPort typed => ChipBuilder.RecRoomObjectVariable(typed, variableConfig) as T,
                Vector3Port typed => ChipBuilder.Vector3Variable(typed, variableConfig) as T,
                QuaternionPort typed => ChipBuilder.QuaternionVariable(typed, variableConfig) as T,
                ColorPort typed => ChipBuilder.ColorVariable(typed, variableConfig) as T,
                AIPort typed => ChipBuilder.AIVariableR1(typed, variableConfig) as T,
                CombatantPort typed => ChipBuilder.CombatantVariableR1(typed, variableConfig) as T,
                DestinationRoomPort typed => ChipBuilder.DestinationRoomVariable(typed, variableConfig) as T,

                ListPort<IntPort> typed => ChipBuilder.ListIntVariable(typed, variableConfig) as T,
                ListPort<BoolPort> typed => ChipBuilder.ListBoolVariable(typed, variableConfig) as T,
                ListPort<FloatPort> typed => ChipBuilder.ListFloatVariable(typed, variableConfig) as T,
                ListPort<StringPort> typed => ChipBuilder.ListStringVariable(typed, variableConfig) as T,
                ListPort<PlayerPort> typed => ChipBuilder.ListPlayerVariable(typed, variableConfig) as T,
                ListPort<RecRoomObjectPort> typed => ChipBuilder.ListRecRoomObjectVariable(typed, variableConfig) as T,
                ListPort<Vector3Port> typed => ChipBuilder.ListVector3Variable(typed, variableConfig) as T,
                ListPort<QuaternionPort> typed => ChipBuilder.ListQuaternionVariable(typed, variableConfig) as T,
                ListPort<ColorPort> typed => ChipBuilder.ListColorVariable(typed, variableConfig) as T,
                ListPort<DestinationRoomPort> typed => ChipBuilder.ListDestinationRoomVariable(typed, variableConfig) as T,
                ListPort<ObjectiveMarkerPort> typed => ChipBuilder.ListObjectiveMarkerVariable(typed, variableConfig) as T,
                ListPort<RewardPort> typed => ChipBuilder.ListRewardVariable(typed, variableConfig) as T,

                _ => throw new Exception("Variable type not supported yet: " + value.GetType().ToString())
            };

            return data;
        }

        Type IVariable.Type => typeof(T);

        AnyPort IVariable.Value
        {
            get => Value;
            set => Value = (T)value;
        }

        public T Value
        {
            get => VariableGetterPort;
            set { CreateVariableNode(value); }
        }

        void IVariable.ChangedEvent() => ChangedEvent();
        public void ChangedEvent() => ChipBuilder.EventReceiver(name + " Changed");

        IVariable IVariable.ChangedEvent(AlternativeExec OnChanged) => (IVariable)ChangedEvent(OnChanged);
        public IVariable<T> ChangedEvent(AlternativeExec OnChanged)
        {
            CircuitBuilder.InlineGraph(() =>
            {
                ChangedEvent();
                OnChanged();
            });
            return this;
        }
    }

    public class AutoNamedVariable<T> : NamedVariable<T> where T : AnyPort, new()
    {
        public AutoNamedVariable(T homeValue, VariableKind kind) : base(GenerateName(), homeValue, kind) { }
        public static string GenerateName()
        {
            var sourceName = SanitizeUtils.SantizeCV2Name(SemanticStackUtils.GetNamedAssignmentName("var"));

            return Context.current.GetUniqueId($"RRCG_{sourceName}");
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
