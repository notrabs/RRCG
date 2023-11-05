
using RRCG;
using System.Collections.Generic;
using UnityEngine;

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

        public static T Self<T>() { return default; }

        public static void PlayAudioAtPosition(Audio Audio, Vector3 Position, float Volume, float PlaybackSpeed, bool Is2D, PlayAudioAtPositionData config) { return; }
    }
}


