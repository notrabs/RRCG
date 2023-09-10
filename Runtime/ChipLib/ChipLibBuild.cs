
namespace RRCGBuild
{
    public class ChipLib
    {

        public static T0 EventCache<T0>(T0 value0) where T0 : AnyPort, new()
        {
            var eventName = "RRCG_EventCache_" + Context.current.GetUniqueId();

            ChipBuilder.EventDefinition<T0>(eventName, "value0");

            ChipBuilder.EventSender<T0>(eventName, value0);

            return ChipBuilder.EventReceiver<T0>(new StringPort() { Data = eventName });
        }

        public static void Log(AnyPort obj)
        {
            StringPort stringPort;
            if (obj is StringPort) stringPort = (StringPort)obj;
            else stringPort = ChipBuilder.ToString(obj);

            ChipBuilder.LogString(stringPort);
        }

        public static void AwaitDelay(FloatPort delay = null)
        {
            if (delay == null) delay = new FloatPort() { Data = 0f };

            ChipBuilder.Delay(delay, delegate () { }, delegate () { });
            ExecFlow.current.Ports[0].Index = 1;
        }
    }
}
