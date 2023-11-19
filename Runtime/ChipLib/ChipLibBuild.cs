using RRCG;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRCGBuild
{
    public class ChipLib : ChipBuilder
    {
        public static T0 VariableCache<T0>(T0 value0)
            where T0 : AnyPort, new()
        {
            var variableCache = new Variable<T0>();
            variableCache.Value = value0;
            return variableCache.Value;
        }

        public static T0 EventCache<T0>(T0 value0)
            where T0 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            var cacheEvent = new EventHelper<T0>(eventName, "value0").Definition();

            T0 port = null;

            CircuitBuilder.InlineGraph(() =>
            {
                port = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0);

            return port;
        }

        public static (T0, T1) EventCache<T0, T1>(T0 value0, T1 value1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            var cacheEvent = new EventHelper<T0, T1>(eventName, "value0", "value1").Definition();

            (T0, T1) ports = default;

            CircuitBuilder.InlineGraph(() =>
            {
                ports = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0, value1);

            return ports;
        }

        public static (T0, T1, T2) EventCache<T0, T1, T2>(T0 value0, T1 value1, T2 value2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            var cacheEvent = new EventHelper<T0, T1, T2>(eventName, "value0", "value1", "value2").Definition();

            (T0, T1, T2) ports = default;

            CircuitBuilder.InlineGraph(() =>
            {
                ports = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0, value1, value2);

            return ports;
        }

        public static (T0, T1, T2, T3) EventCache<T0, T1, T2, T3>(T0 value0, T1 value1, T2 value2, T3 value3)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            var cacheEvent = new EventHelper<T0, T1, T2, T3>(eventName, "value0", "value1", "value2", "value3").Definition();

            (T0, T1, T2, T3) ports = default;

            CircuitBuilder.InlineGraph(() =>
            {
                ports = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0, value1, value2, value3);

            return ports;
        }


        public static void Log(AnyPort obj)
        {
            StringPort stringPort;
            if (obj is StringPort sp) stringPort = sp;
            else stringPort = obj.ToString();

            LogString(stringPort);
        }

        public static void AwaitDelay(FloatPort delay = null)
        {
            if (delay == null) delay = new FloatPort() { Data = 0f };

            Delay(delay, delegate () { }, delegate () { });
            ExecFlow.current.Ports[0].Index = 1;
        }

        public static void Throttle(FloatPort interval)
        {
            CircuitBuilder.CircuitBoard("Throttle", (FloatPort interval) =>
            {
                var lastExec = new Variable<FloatPort>();

                var currentTime = TimeGetPreciseSeconds();

                var test = GreaterThan(
                    Subtract(currentTime, lastExec.Value),
                    interval
                );

                If(
                    test,
                    () => lastExec.Value = currentTime,
                    () => CircuitBuilder.ClearExec()
                );
            }, interval);
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

            if (options.Length > 64) throw new Exception("ValueSwitch only supports 64 values. Consider using a ChipLib.LUT for big look up tables.");

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

        public static IntPort RandomNonRepeating(IntPort num)
        {
            var sum = Add(0, RandomInt(0, (int)num - 1));
            var addNode = Context.lastSpawnedNode;

            var newValue = Modulo(sum, num);
            var nonRepeating = RandomInt(newValue, newValue);

            addNode.ConnectInputPort(nonRepeating, 0);

            return nonRepeating;
        }
        public static IntPort RandomNonRepeating(IVariable<IntPort> variable, IntPort num)
        {
            var newValue = Modulo(Add(variable.Value, RandomInt(0, (int)num - 1)), num);
            variable.Value = newValue;
            return variable.Value;
        }

        public static T GetClosest<T>(Vector3Port postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)GetClosest(postion, RecRoomObjectGetAllWithTag(tag)).Closest;
        }
        public static T GetClosest<T>(PlayerPort postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)GetClosest(postion, RecRoomObjectGetAllWithTag(tag)).Closest;
        }
        public static T GetClosest<T>(RecRoomObjectPort postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)GetClosest(postion, RecRoomObjectGetAllWithTag(tag)).Closest;
        }

        public static void RequireKey(StringPort keyName)
        {
            var key = CircuitBuilder.Singleton("RequireKey_" + keyName.AsData<string>(), () => ChipBuilder.RoomKeyConstant(new RoomKeyData(keyName.AsData<string>())));

            var ownsKey = PlayerOwnsRoomKey(PlayerPort.Local, key, (_) => { });
            ExecFlow.current.Ports[0].Index = 1;

            If(ownsKey, delegate () { }, delegate ()
            {
                ShowPurchasePrompt(key, PlayerPort.Local);
                CircuitBuilder.ClearExec();
            });
        }

        public static ListPort<T> ListFill<T>(IntPort count, T value) where T : AnyPort, new()
        {
            int intCount = count.AsData<int>();

            if (intCount < 0 || intCount > 64) throw new Exception("ListFill count must be within [0, 64]");

            var intialValues = new T[intCount];
            Array.Fill(intialValues, value);
            return ListCreate<T>(intialValues);
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

        public static StringPort BitString(IntPort bits)
        {
            // If bits is a data port, let's precalculate it
            if (bits.IsDataPort)
                return new StringPort { Data = Convert.ToString(bits.Data, 2).PadLeft(32, '0') };

            // Otherwise we have to implement this in circuits
            // Climb up to the root context
            Context prevContext = Context.current;
            while (Context.current.ParentContext != null)
                Context.current = Context.current.ParentContext;

            // Now build the implementation
            var callEvent = new EventHelper<IntPort>("ChipLib_BitString");
            var returnEvent = new EventHelper<StringPort>("ChipLib_BitString_Read");

            CircuitBuilder.InlineGraph(() => CircuitBuilder.Singleton("_ChipLib_BitString", () =>
            {
                // Place definitions in root context
                callEvent.Definition();
                returnEvent.Definition();

                // Place method implementation in a circuit board
                CircuitBuilder.Singleton("_ChipLib_BitString_CircuitBoard",
                    () => CircuitBuilder.CircuitBoard("ChipLibBitString", () =>
                {
                    IntPort bits = callEvent.Receiver();
                    returnEvent.SendLocal(BitStringImpl(bits));

                    // Prevent exec output
                    CircuitBuilder.ClearExec();
                }));
            }));

            // Now we go back to the original context
            // and place the necessary chips.
            Context.current = prevContext;

            // Send the event
            callEvent.SendLocal(bits);

            // And read from a singleton receiver, one per context
            StringPort readPort = null;
            CircuitBuilder.InlineGraph(() =>
                readPort = CircuitBuilder.Singleton("_ChipLib_BitString_Read", () => returnEvent.Receiver()));
            return readPort;
        }

        private static StringPort BitStringImpl(IntPort bits)
        {
            // Collect outputs of value switches for concatenation later
            var digits = new List<StringPort>();

            for (int i=31; i >= 0; i--)
            {
                // Test for bit i to be set
                int mask = 1 << i;
                IntPort maskedValue = ChipBuilder.BitAnd(bits, mask);

                // If the bit is set, output 1, otherwise 0
                StringPort digit = ChipBuilder.ValueIntegerSwitch<StringPort>(maskedValue, "0", new()
                {
                    { mask, "1" }
                });

                digits.Add(digit);
            }

            // Now concatenate the digits
            return ChipBuilder.Concat(digits.ToArray());
        }

        public static FloatPort FloatConst(FloatPort value)
        {
            var reroute = Reroute(value);
            // This forces the type to float. There might be a better way to do this.
            Round(reroute);
            return reroute;
        }

        public static IntPort IntConst(IntPort value)
        {
            var reroute = Reroute(value);
            // This forces the type to float. There might be a better way to do this.
            IntToFloat(reroute);
            return reroute;
        }
    }
}
