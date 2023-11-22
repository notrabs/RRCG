using RRCG;
using System;
using System.Text.RegularExpressions;

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


    public class NamedVariable<T> : IVariable<T> where T : AnyPort, new()
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
            T data = value switch
            {
                IntPort typed => ChipBuilder.IntVariable(typed) as T,
                BoolPort typed => ChipBuilder.BoolVariable(typed) as T,
                FloatPort typed => ChipBuilder.FloatVariable(typed) as T,
                StringPort typed => ChipBuilder.StringVariable(typed) as T,
                PlayerPort typed => ChipBuilder.PlayerVariable(typed) as T,
                RecRoomObjectPort typed => ChipBuilder.RecRoomObjectVariable(typed) as T,
                Vector3Port typed => ChipBuilder.Vector3Variable(typed) as T,
                QuaternionPort typed => ChipBuilder.QuaternionVariable(typed) as T,
                ColorPort typed => ChipBuilder.ColorVariable(typed) as T,
                AIPort typed => ChipBuilder.AIVariable(typed) as T,
                CombatantPort typed => ChipBuilder.CombatantVariable(typed) as T,
                DestinationRoomPort typed => ChipBuilder.DestinationRoomVariable(typed) as T,

                ListPort<IntPort> typed => ChipBuilder.ListIntVariable(typed) as T,
                ListPort<BoolPort> typed => ChipBuilder.ListBoolVariable(typed) as T,
                ListPort<FloatPort> typed => ChipBuilder.ListFloatVariable(typed) as T,
                ListPort<StringPort> typed => ChipBuilder.ListStringVariable(typed) as T,
                ListPort<PlayerPort> typed => ChipBuilder.ListPlayerVariable(typed) as T,
                ListPort<RecRoomObjectPort> typed => ChipBuilder.ListRecRoomObjectVariable(typed) as T,
                ListPort<Vector3Port> typed => ChipBuilder.ListVector3Variable(typed) as T,
                ListPort<QuaternionPort> typed => ChipBuilder.ListQuaternionVariable(typed) as T,
                ListPort<ColorPort> typed => ChipBuilder.ListColorVariable(typed) as T,
                ListPort<DestinationRoomPort> typed => ChipBuilder.ListDestinationRoomVariable(typed) as T,
                ListPort<ObjectiveMarkerPort> typed => ChipBuilder.ListObjectiveMarkerVariable(typed) as T,
                ListPort<RewardPort> typed => ChipBuilder.ListRewardVariable(typed) as T,

                _ => throw new Exception("Variable type not supported yet: " + value.GetType().ToString())
            };

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
            var sourceName = SanitizeUtils.SantizeCV2Name(SemanticStackUtils.GetNamedAssignmentName("var"));

            return $"RRCG_{sourceName}_{Context.current.GetUniqueId()}";
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
