using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RRCGBuild
{
    public class ChipLib : ChipBuilder
    {

        public static T0 EventCache<T0>(T0 value0) where T0 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            EventDefinition<T0>(eventName, "value0");

            T0 port = null;

            CircuitBuilder.InlineGraph(() =>
            {
                port = EventReceiver<T0>(eventName);
            });

            EventSender<T0>(eventName, value0);

            return port;
        }

        public static void Log(AnyPort obj)
        {
            StringPort stringPort;
            if (obj is StringPort) stringPort = (StringPort)obj;
            else stringPort = ToString(obj);

            LogString(stringPort);
        }

        public static void AwaitDelay(FloatPort delay = null)
        {
            if (delay == null) delay = new FloatPort() { Data = 0f };

            Delay(delay, delegate () { }, delegate () { });
            ExecFlow.current.Ports[0].Index = 1;
        }

        private static void ThrottleBoard(FloatPort interval)
        {
            var lastExec = new Variable<FloatPort>();

            var currentTime = TimeGetPreciseSeconds();

            var test = ChipBuilder.GreaterThan(
                ChipBuilder.Subtract(currentTime, lastExec.Value),
                interval
            );

            ChipBuilder.If(
                test,
                () => lastExec.Value = currentTime,
                () => throw null
            );

        }

        public static void Throttle(FloatPort interval)
        {
            CircuitBuilder.CircuitBoard(ThrottleBoard, interval);
        }

        public static IntPort RandomStoreCounter()
        {
            var randomPort = RandomInt(0, 10);
            var randomNode = Context.lastSpawnedNode;

            var sum = Add(randomPort, 1);

            randomNode.ConnectInputPort(Context.current, sum, new Port { Node = randomNode, Index = 1 });
            randomNode.ConnectInputPort(Context.current, sum, new Port { Node = randomNode, Index = 2 });

            return randomPort;
        }

        public static IntPort RandomStoreCounter(IntPort modulusPort)
        {
            var randomPort = RandomInt(0, 10);
            var randomNode = Context.lastSpawnedNode;

            if (modulusPort.IsActualPort) throw new Exception("RandomStoreCounter requires actual data in the modulusPort");
            var modulus = modulusPort.Data;

            if (modulus > 64) throw new Exception("RandomStoreCounter only supports modulus below 64");

            var cases = new Dictionary<IntPort, IntPort>();

            for (var i = 0; i < modulus - 1; i++)
            {
                cases.Add(i, i + 1);
            }

            var switchValue = ValueIntegerSwitch(randomPort, 0, cases);

            randomNode.ConnectInputPort(Context.current, switchValue, new Port { Node = randomNode, Index = 1 });
            randomNode.ConnectInputPort(Context.current, switchValue, new Port { Node = randomNode, Index = 2 });

            return randomPort;
        }

        public static T ValueSwitch<T>(IntPort index, params T[] options) where T : AnyPort, new()
        {
            var cases = new Dictionary<IntPort, T>();

            for (var i = 1; i < options.Length; i++)
            {
                cases.Add(i, options[i]);
            }

            return ValueIntegerSwitch(index, options[0], cases);
        }

        public static T PickRandom<T>(params T[] options) where T : AnyPort, new()
        {
            var index = RandomInt(0, options.Length - 1);
            return ValueSwitch(index, options);
        }

        public static StringPort PickRandom(params StringPort[] options)
        {
            return PickRandom<StringPort>(options);
        }
        public static IntPort PickRandom(params IntPort[] options)
        {
            return PickRandom<IntPort>(options);
        }
        public static FloatPort PickRandom(params FloatPort[] options)
        {
            return PickRandom<FloatPort>(options);
        }

        public class LUT<T> where T : AnyPort, new()
        {
            public T UnsafeReadPort;
            private EventHelper<IntPort> readEvent;

            private IEnumerable<object> list;

            public LUT(IEnumerable<object> list)
            {
                readEvent = new EventHelper<IntPort>("LUT_" + Context.current.GetUniqueId(), "index");

                readEvent.Definition();

                this.list = list;

                UnsafeReadPort = CircuitBuilder.CircuitBoard(LUT_Data);
            }

            private T LUT_Data()
            {

                var index = readEvent.Receiver();

                if (list.Count() <= 64)
                {
                    var cases = new Dictionary<IntPort, T>();

                    for (var i = 0; i < list.Count(); i++)
                    {
                        cases.Add(i, (T)list.ElementAt(i));
                    }

                    return ChipBuilder.ValueIntegerSwitch<T>(index, null, cases);
                }
                else if (list.Count() <= 64 * 64)
                {
                    var partitions = Partition<object>(list, 64);

                    var rootCases = new Dictionary<IntPort, T>();

                    int paritionIndex = 0;
                    foreach (var partition in partitions)
                    {
                        var cases = new Dictionary<IntPort, T>();

                        int itemIndex = 0;
                        foreach (var item in partition)
                        {
                            cases.Add(paritionIndex * 64 + itemIndex, item as dynamic);
                            itemIndex++;
                        }

                        var partitionSwitch = ChipBuilder.ValueIntegerSwitch<T>(index, null, cases);

                        rootCases.Add(paritionIndex, partitionSwitch);
                        paritionIndex++;
                    }

                    return ChipBuilder.ValueIntegerSwitch<T>(ChipBuilder.Divide(index, 64), null, rootCases);
                }
                else
                {
                    throw new Exception("not implemented");
                }
            }

            public T Read(IntPort index)
            {
                readEvent.Sender(index);
                return UnsafeReadPort;
            }

            static IEnumerable<List<Type>> Partition<Type>(IEnumerable<Type> source, Int32 size)
            {
                for (int i = 0; i < (source.Count() / size) + (source.Count() % size > 0 ? 1 : 0); i++)
                    yield return new List<Type>(source.Skip(size * i).Take(size));
            }
        }
    }
}
