using RRCG;
using RRCGSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCGBuild
{
    public abstract class StudioObjectBuilder
    {
        public StudioObjectPort __Target;

        public StudioObjectBuilder(StudioObjectPort target)
        {
            __Target = target;
        }

        public GameObject gameObject { get; }

        public abstract void __UpdateStudioEvents();

        public void __AddStudioEvent(string name, StudioEventType type, Action creator)
        {

        }

        public void __AddStudioEvent<T>(string name, StudioEventType type, Action<T> creator)
        {

        }
        public void __AddStudioEvent<T1, T2>(string name, StudioEventType type, Action<T1, T2> creator)
        {

        }

        protected void AddListener<T>(T property, T data) { }
        protected void AddListener<T>(Action<T> method, T data) { }
        protected void AddListener<T>(Action<string, T> method, string data0, T data1) { }
    }

    public class StudioEvent : Attribute { }
    public class StudioEventRange : Attribute
    {
        public StudioEventRange(int start, int count, int increment = 1) { }
        public StudioEventRange(params object[] values) { }
    }
}
