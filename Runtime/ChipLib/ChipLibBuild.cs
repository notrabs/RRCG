using System;

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

    }
}
