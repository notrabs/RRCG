﻿using RRCG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace RRCGBuild
{
    public static class ChipLib
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
            var cacheEvent = new EventDefinition<T0>("EventCache", "value0");

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
            var cacheEvent = new EventDefinition<T0, T1>("EventCache", "value0", "value1");

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
            var cacheEvent = new EventDefinition<T0, T1, T2>("EventCache", "value0", "value1", "value2");

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
            var cacheEvent = new EventDefinition<T0, T1, T2, T3>("EventCache", "value0", "value1", "value2", "value3");

            (T0, T1, T2, T3) ports = default;

            CircuitBuilder.InlineGraph(() =>
            {
                ports = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0, value1, value2, value3);

            return ports;
        }

        public static (T0, T1, T2, T3, T4) EventCache<T0, T1, T2, T3, T4>(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        {
            var cacheEvent = new EventDefinition<T0, T1, T2, T3, T4>("EventCache", "value0", "value1", "value2", "value3", "value4");

            (T0, T1, T2, T3, T4) ports = default;

            CircuitBuilder.InlineGraph(() =>
            {
                ports = cacheEvent.Receiver();
            });

            cacheEvent.SendLocal(value0, value1, value2, value3, value4);

            return ports;
        }


        public static void Log(AnyPort obj)
        {
            StringPort stringPort;
            if (obj is StringPort sp) stringPort = sp;
            else stringPort = obj.ToString();

            ChipBuilder.LogString(stringPort);
        }

        public static void AwaitDelay(FloatPort delay = null)
        {
            if (delay == null) delay = new FloatPort() { Data = 0f };

            ChipBuilder.Delay(delay, delegate () { }, delegate () { });
            ExecFlow.current.Ports[0].Index = 1;
        }

        public static void Throttle(FloatPort interval)
        {
            CircuitBuilder.CircuitBoard("Throttle", (FloatPort interval) =>
            {
                var lastExec = new Variable<FloatPort>();

                var currentTime = ChipBuilder.TimeGetPreciseSeconds();

                var test = ChipBuilder.GreaterThan(
                    ChipBuilder.Subtract(currentTime, lastExec.Value),
                    interval
                );

                ChipBuilder.If(
                    test,
                    () => lastExec.Value = currentTime,
                    () => CircuitBuilder.ClearExec()
                );
            }, interval);
        }

        public static IntPort RandomStoreCounter()
        {
            var randomPort = ChipBuilder.RandomInt(0, 10);
            var randomNode = Context.lastSpawnedNode;

            var sum = ChipBuilder.Add(randomPort, 1);

            randomNode.ConnectInputPort(Context.current, sum, new Port { Node = randomNode, Index = 1 });
            randomNode.ConnectInputPort(Context.current, sum, new Port { Node = randomNode, Index = 2 });

            return randomPort;
        }

        public static IntPort RandomStoreCounter(IntPort modulusPort)
        {
            var randomPort = ChipBuilder.RandomInt(0, 10);
            var randomNode = Context.lastSpawnedNode;

            IntPort inputValue;
            if (modulusPort.IsDataPort && modulusPort.Data <= 64)
            {
                var cases = new Dictionary<IntPort, IntPort>();

                for (var i = 0; i < modulusPort.Data - 1; i++)
                {
                    cases.Add(i, i + 1);
                }

                inputValue = ChipBuilder.ValueIntegerSwitch(randomPort, 0, cases);
            }
            else
            {
                inputValue = (randomPort + 1) % modulusPort;
            }

            randomNode.ConnectInputPort(Context.current, inputValue, new Port { Node = randomNode, Index = 1 });
            randomNode.ConnectInputPort(Context.current, inputValue, new Port { Node = randomNode, Index = 2 });

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

            return ChipBuilder.ValueIntegerSwitch(index, options[0], cases);
        }

        public static T PickRandom<T>(params T[] options) where T : AnyPort, new()
        {
            var index = ChipBuilder.RandomInt(0, options.Length - 1);
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
            var sum = ChipBuilder.Add(0, ChipBuilder.RandomInt(0, (int)num - 1));
            var addNode = Context.lastSpawnedNode;

            var newValue = ChipBuilder.Modulo(sum, num);
            var nonRepeating = ChipBuilder.RandomInt(newValue, newValue);

            addNode.ConnectInputPort(nonRepeating, 0);

            return nonRepeating;
        }
        public static IntPort RandomNonRepeating(IVariable<IntPort> variable, IntPort num)
        {
            var newValue = ChipBuilder.Modulo(ChipBuilder.Add(variable.Value, ChipBuilder.RandomInt(0, (int)num - 1)), num);
            variable.Value = newValue;
            return variable.Value;
        }

        public static T GetClosest<T>(Vector3Port postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)ChipBuilder.GetClosest(postion, ChipBuilder.RecRoomObjectGetAllWithTag(tag)).Closest;
        }
        public static T GetClosest<T>(PlayerPort postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)ChipBuilder.GetClosest(postion, ChipBuilder.RecRoomObjectGetAllWithTag(tag)).Closest;
        }
        public static T GetClosest<T>(RecRoomObjectPort postion, string tag) where T : AnyPort, new()
        {
            return (T)(dynamic)ChipBuilder.GetClosest(postion, ChipBuilder.RecRoomObjectGetAllWithTag(tag)).Closest;
        }

        public static void RequireKeyR1(Guid keyGuid)
        {
            var key = CircuitBuilder.Singleton("RequireKey_" + keyGuid, () => ChipBuilder.RoomKeyConstantR1(new RoomKeyData(keyGuid)));

            var ownsKey = ChipBuilder.PlayerOwnsRoomKeyR1(PlayerPort.Local, key, (_) => { });
            ExecFlow.current.Ports[0].Index = 1;

            ChipBuilder.If(ownsKey, delegate () { }, delegate ()
            {
                ChipBuilder.ShowPurchasePromptR1(key, PlayerPort.Local);
                CircuitBuilder.ClearExec();
            });
        }

        public static ListPort<T> ListFill<T>(IntPort count, T value) where T : AnyPort, new()
        {
            int intCount = count.AsData<int>();

            if (intCount < 0 || intCount > 64) throw new Exception("ListFill count must be within [0, 64]");

            var intialValues = new T[intCount];
            Array.Fill(intialValues, value);
            return ChipBuilder.ListCreate<T>(intialValues);
        }

        public class LUT<T> where T : AnyPort, new()
        {
            public T UnsafeReadPort;
            private EventDefinition<IntPort> readEvent;

            private IEnumerable<T> list;

            // Typing is a bit awkward for native types
            public LUT(IEnumerable<int> list) => InitLUT(list.Select(el => (T)el));
            public LUT(IEnumerable<float> list) => InitLUT(list.Select(el => (T)el));
            public LUT(IEnumerable<string> list) => InitLUT(list.Select(el => (T)el));
            public LUT(IEnumerable<Vector3> list) => InitLUT(list.Select(el => (T)el));
            public LUT(IEnumerable<Quaternion> list) => InitLUT(list.Select(el => (T)el));
            public LUT(IEnumerable<object> list) => InitLUT(list.Select(el => (T)el));

            public void InitLUT(IEnumerable<T> list)
            {
                readEvent = new EventDefinition<IntPort>("LUT", "index");

                this.list = list;

                UnsafeReadPort = CircuitBuilder.CircuitBoard(LUT_Data);
            }

            private T LUT_Data()
            {
                var index = readEvent.Receiver();

                if (typeof(T) == typeof(Vector3Port)) return LUT_Data_Vector3(index, list as IEnumerable<Vector3Port>) as T;
                if (typeof(T) == typeof(QuaternionPort)) return LUT_Data_Quaternion(index, list as IEnumerable<QuaternionPort>) as T;

                return LUT_Data_Single<T>(index, list);
            }

            private Vector3Port LUT_Data_Vector3(IntPort index, IEnumerable<Vector3Port> list)
            {
                var x = LUT_Data_Single<FloatPort>(index, list.Select(v => v.x));
                var y = LUT_Data_Single<FloatPort>(index, list.Select(v => v.y));
                var z = LUT_Data_Single<FloatPort>(index, list.Select(v => v.z));

                return ChipBuilder.Vector3Create(x, y, z);
            }

            private QuaternionPort LUT_Data_Quaternion(IntPort index, IEnumerable<QuaternionPort> list)
            {
                var x = LUT_Data_Single<FloatPort>(index, list.Select(v => v.x));
                var y = LUT_Data_Single<FloatPort>(index, list.Select(v => v.y));
                var z = LUT_Data_Single<FloatPort>(index, list.Select(v => v.z));
                var w = LUT_Data_Single<FloatPort>(index, list.Select(v => v.w));

                return ChipBuilder.QuaternionCreate(x, y, z, w);
            }

            private PrimitiveT LUT_Data_Single<PrimitiveT>(IntPort index, IEnumerable<PrimitiveT> primitiveList) where PrimitiveT : AnyPort, new()
            {
                if (primitiveList.Count() <= 64)
                {
                    var cases = new Dictionary<IntPort, PrimitiveT>();

                    for (var i = 0; i < primitiveList.Count(); i++)
                    {
                        cases.Add(i, (PrimitiveT)primitiveList.ElementAt(i));
                    }

                    return ChipBuilder.ValueIntegerSwitch<PrimitiveT>(index, null, cases);
                }
                else if (primitiveList.Count() <= 64 * 64)
                {
                    var partitions = Partition<object>(primitiveList, 64);

                    var rootCases = new Dictionary<IntPort, PrimitiveT>();

                    int paritionIndex = 0;
                    foreach (var partition in partitions)
                    {
                        var cases = new Dictionary<IntPort, PrimitiveT>();

                        int itemIndex = 0;
                        foreach (var item in partition)
                        {
                            cases.Add(paritionIndex * 64 + itemIndex, item as dynamic);
                            itemIndex++;
                        }

                        var partitionSwitch = ChipBuilder.ValueIntegerSwitch<PrimitiveT>(index, null, cases);

                        rootCases.Add(paritionIndex, partitionSwitch);
                        paritionIndex++;
                    }

                    return ChipBuilder.ValueIntegerSwitch<PrimitiveT>(ChipBuilder.Divide(index, 64), null, rootCases);
                }
                else
                {
                    throw new Exception("not implemented");
                }
            }

            public T Read(IntPort index)
            {
                readEvent.SendLocal(index);
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
            EventDefinition<IntPort> callEvent = null;
            EventDefinition<StringPort> returnEvent = null;

            CircuitBuilder.InlineGraph(() =>
            {
                (callEvent, returnEvent) = CircuitBuilder.Singleton("_ChipLib_BitString", () =>
                {
                    // Place definitions in root context
                    var callEvent = new EventDefinition<IntPort>("ChipLib_BitString", "int");
                    var returnEvent = new EventDefinition<StringPort>("ChipLib_BitString_Read", "string");

                    // Place method implementation in a circuit board
                    CircuitBuilder.Singleton("_ChipLib_BitString_CircuitBoard",
                        () => CircuitBuilder.CircuitBoard("ChipLibBitString", () =>
                    {
                        IntPort bits = callEvent.Receiver();
                        returnEvent.SendLocal(BitStringImpl(bits));

                        // Prevent exec output
                        CircuitBuilder.ClearExec();
                    }));

                    return (callEvent, returnEvent);
                });
            });

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

            for (int i = 31; i >= 0; i--)
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
            // This forces the type to float. There might be a better way to do this.
            return CircuitBuilder.Singleton($"ChipLib_FloatConst_{value.PortKey()}", () => ChipBuilder.Root(value, 1));
        }

        public static IntPort IntConst(IntPort value)
        {
            // This forces the type to int. There might be a better way to do this.
            return CircuitBuilder.Singleton($"ChipLib_IntConst_{value.PortKey()}", () => ChipBuilder.BitOr(value, 0));
        }


        public static (BoolPort Hit, PlayerPort Player, RecRoomObjectPort Object, FloatPort Distance, Vector3Port HitPosition, Vector3Port SurfaceNormal) Raycast(Vector3Port from, Vector3Port to, RaycastData config)
        {
            return ChipBuilder.Raycast(from, to - from, ChipBuilder.Distance(from, to), config);
        }

        public static (BoolPort Success, RecRoomObjectPort Object) AwaitSpawn(this ReplicatorPort replicator, Vector3Port position, QuaternionPort rotation, BoolPort assignToPlayer, PlayerPort assignPlayer)
        {
            var result = ChipBuilder.ReplicatorSpawnNextObjectR2(replicator, position, rotation, assignToPlayer, assignPlayer, (_) => { });
            ExecFlow.current.Ports[0].Index = 1;
            return (result.Success, result.Object);
        }

    }
}
