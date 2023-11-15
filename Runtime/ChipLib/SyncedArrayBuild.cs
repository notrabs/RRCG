using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class SyncedArray<T> where T : AnyPort, new()
    {
        protected SyncedVariable<T>[] variables;
        protected EventHelper<IntPort> readEvent;
        protected EventHelper<IntPort, T> writeEvent;

        protected T readPort;

        public SyncedArray() { }
        public SyncedArray(IntPort count)
        {
            Init(count, () => { }, () => { });
        }

        public void Init(IntPort count, Action initGlobal, Action initCB)
        {
            variables = new SyncedVariable<T>[count.AsData<int>()];
            readEvent = new EventHelper<IntPort>("SyncedArray_Read");
            writeEvent = new EventHelper<IntPort, T>("SyncedArray_Write");

            initGlobal();

            CircuitBuilder.InlineGraph(() =>
            {
                readEvent.Definition();
                writeEvent.Definition();

                readPort = CircuitBuilder.CircuitBoard(() =>
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
                    return ChipLib.ValueSwitch(readIndex, variables.Select(v => v.Value).ToArray());
                });
            });
        }

        public T this[IntPort i]
        {
            get
            {
                readEvent.Sender(i);
                return readPort;
            }
            set
            {
                writeEvent.Sender(i, value);
            }
        }
    }

    public class SyncedArrayInt : SyncedArray<IntPort>
    {
        EventHelper<IntPort, IntPort> addEvent;

        public SyncedArrayInt(IntPort count) : base()
        {
            Init(count, () =>
            {
                addEvent = new EventHelper<IntPort, IntPort>("SyncedArray_Add").Definition();
            }, () =>
            {
                var (addIndex, addAmount) = addEvent.Receiver();
                var addCurrent = ChipLib.ValueSwitch(addIndex, variables.Select(v => v.Value).ToArray());
                writeEvent.Sender(addIndex, addCurrent + addAmount);
            });
        }

        public void Add(IntPort index, IntPort value)
        {
            addEvent.Sender(index, value);
        }
    }
}
