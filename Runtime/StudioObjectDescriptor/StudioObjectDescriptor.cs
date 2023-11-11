using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RRCGSource
{
    public abstract class StudioObjectDescriptor
    {

        public StudioObjectDescriptor(StudioObject target) { }

        protected void AddListener(Action method) { }
        protected void AddListener<T>(T property, T data) { }
        protected void AddListener<T>(Action<T> method, T data) { }

        protected void AddDynamicListener<T>(T property) { }
        protected void AddDynamicListener<T>(Action<T> method) { }
        protected void AddDynamicListener<T>(Action<string, T> method) { }

        /// <summary>
        /// The root gameObject of the Rec Room Object prefab
        /// </summary>
        protected GameObject gameObject { get; }
    }

    public class StudioEvent : Attribute { }
    public class StudioEventRange: Attribute {
        public StudioEventRange(int start, int count, int increment = 1) { }
        public StudioEventRange(params object[] values) { }
    }

    public class StudioFunction : Attribute { }
    public class ExistingStudioFunction : Attribute { }
}
