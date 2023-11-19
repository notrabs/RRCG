namespace RRCG
{
    public static class RoomEvents
    {
        public static string Hz30 = "Update 30Hz";
        public static string TestEvent = "Test Event";
    }


    public enum StudioEventType
    {
        VOID,
        INT,
        BOOL,
        FLOAT,
        STRING,
        STRING_INT,
        STRING_BOOL,
        STRING_FLOAT,
        STRING_STRING,
    }

    public enum EventTarget
    {
        LOCAL = 0,
        OTHERS = 1,
        ROOM_AUTHORITY = 2,
        AUTHORITY = 3,
        ALL = 4,
        PLAYER = 5,
    }
}

