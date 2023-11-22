using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class SyncedArray<T> where T : AnyPort, new()
    {
        protected SyncedVariable<T>[] variables;
        protected EventDefinition<IntPort> readEvent;
        protected EventDefinition<IntPort, T> writeEvent;

        protected T readPort;

        public SyncedArray() { }
        public SyncedArray(IntPort count)
        {
            Init(count, () => { }, () => { });
        }

        public void Init(IntPort count, Action initGlobal, Action initCB)
        {
            variables = new SyncedVariable<T>[count.AsData<int>()];
            readEvent = new EventDefinition<IntPort>("SyncedArray_Read", "index");
            writeEvent = new EventDefinition<IntPort, T>("SyncedArray_Write", "index", "data");

            initGlobal();

            CircuitBuilder.InlineGraph(() =>
            {
                readPort = CircuitBuilder.CircuitBoard("SyncedArray", () =>
                {
                    for (int i = 0; i < count.AsData<int>(); i++)
                    {
                        variables[i] = new SyncedVariable<T>();
                    }

                    var (writeIndex, writeData) = writeEvent.Receiver();

                    Dictionary<IntPort, AlternativeExec> cases = variables.ToDictionary(
                        v => (IntPort)Array.IndexOf(variables, v),
                        v => (AlternativeExec)delegate () { v.Value = writeData; }
                        );

                    ChipBuilder.ExecutionIntegerSwitch(writeIndex, () => { }, cases);

                    initCB();

                    var readIndex = readEvent.Receiver();

                    // prevents an exit pin on the board
                    CircuitBuilder.ClearExec();

                    return ChipLib.ValueSwitch(readIndex, variables.Select(v => v.Value).ToArray());
                });
            });
        }

        public T GetSafe(IntPort index) => ChipLib.EventCache(this[index]);
        public T this[IntPort i]
        {
            get
            {
                readEvent.SendLocal(i);
                return readPort;
            }
            set
            {
                writeEvent.SendLocal(i, value);
            }
        }
    }

    public class SyncedArrayInt : SyncedArray<IntPort>
    {
        EventDefinition<IntPort, IntPort> addEvent;

        public SyncedArrayInt(IntPort count) : base()
        {
            Init(count, () =>
            {
                addEvent = new EventDefinition<IntPort, IntPort>("SyncedArray_Add", "index", "count");
            }, () =>
            {
                var (addIndex, addAmount) = addEvent.Receiver();
                var addCurrent = ChipLib.ValueSwitch(addIndex, variables.Select(v => v.Value).ToArray());
                writeEvent.SendLocal(addIndex, addCurrent + addAmount);
            });
        }

        public void Add(IntPort index, IntPort value)
        {
            addEvent.SendLocal(index, value);
        }
    }
}
