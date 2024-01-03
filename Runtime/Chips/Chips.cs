using RRCG;
using System;
using System.Collections.Generic;


namespace RRCGSource
{
    public partial class Chips : RRCGGenerated.ChipsGen
    {
        public static void EventDefinition(string eventName) { }
        public static void EventDefinition<T0>(string eventName, string param0) { }
        public static void EventDefinition<T0, T1>(string eventName, string param0, string param1) { }
        public static void EventReceiver(string eventName) { }
        public static T0 EventReceiver<T0>(string eventName) { return default; }
        public static (T0, T1) EventReceiver<T0, T1>(string eventName) { return default; }
        public static void EventSender(string eventName) { }
        public static void EventSender<T0>(string eventName, T0 value0) { }
        public static void EventSender<T0, T1>(string eventName, T1 value1) { }

        public static string Concat(params string[] strings) { return ""; }

        public static void If(bool test, AlternativeExec ifBranch, AlternativeExec elseBranch) { }

        /// <summary>  For loop executing forEach [from, to) and continuing on the Done pin  </summary>
        public static void For(AlternativeExec<int> forEach, int from, int to) { }
        public static void ExecutionIntegerSwitch(int match, AlternativeExec failed, Dictionary<int, AlternativeExec> cases) { }
        public static void ExecutionStringSwitch(int match, AlternativeExec failed, Dictionary<string, AlternativeExec> cases) { }
        public static T ValueIntegerSwitch<T>(int match, T failed, Dictionary<int, T> cases) { return default; }
        public static T ValueStringSwitch<T>(int match, T failed, Dictionary<string, T> cases) { return default; }

        //
        // Data Table
        //

        public static T DataTableReadCell<T>(int Row, DataTableColumnData config) => default;

        //
        // Misc
        //

        public static T Self<T>() { return default; }

        public static float Power(float Value, float Power) { return default; }
        public static int Power(int Value, int Power) { return default; }

        // 
        // Shorthands
        //

        /// <summary>
        /// If used in an if statement, this will optimize to an IfIsLocalPlayerAuthority chip. Otherwise the equivalent chips are spawned.
        /// </summary>
        public static bool LocalPlayerIsAuthority => default;

        /// <summary>
        /// If used in an if statement, this will optimize to an IsLocalPlayerRoomAuthority chip. Otherwise the equivalent chips are spawned.
        /// </summary>
        public static bool LocalPlayerIsRoomAuthority => default;

        //
        // Deprecations
        //
        [Obsolete("Use the PascalCase variant instead")]
        public static List<RecRoomObject> RecRoomObjectGetAllwithTag(string tag) { return default; }

        [Obsolete("Use the PascalCase variant instead")]
        public static RecRoomObject RecRoomObjectGetFirstwithTag(string tag) { return default; }
    }
}


