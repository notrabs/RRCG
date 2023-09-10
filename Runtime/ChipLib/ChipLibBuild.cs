
using System;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class ChipLib : ChipBuilder
    {

        public static T0 EventCache<T0>(T0 value0) where T0 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            EventDefinition<T0>(eventName, "value0");

            EventSender<T0>(eventName, value0);

            return EventReceiver<T0>(eventName);
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
    }
}
