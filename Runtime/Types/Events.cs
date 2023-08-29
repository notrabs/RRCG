namespace RRCGSource
{
    public static class RoomEvents
    {
        public static string Hz30;
    }
}

namespace RRCGBuild
{
    public static class RoomEvents
    {
        public static StringPort Hz30 = new StringPort() { Data = "Update 30Hz" };
    }
}

