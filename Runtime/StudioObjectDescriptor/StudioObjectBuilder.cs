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
    public interface StudioObjectBuilderImpl
    {
        public void __ClearEvents(StudioObjectBuilder target);
        public void __FinalizeEvents(StudioObjectBuilder target);

        public void __AddStudioEvent(StudioObjectBuilder target, string name, StudioEventType type, Action creator);
        public void __AddStudioEvent<T>(StudioObjectBuilder target, string name, StudioEventType type, Action<T> creator);
        public void __AddStudioEvent<T1, T2>(StudioObjectBuilder target, string name, StudioEventType type, Action<T1, T2> creator);
        public void AddListener(StudioObjectBuilder target, object obj, string propertyOrMethod);
        public void AddListener<T>(StudioObjectBuilder target, object obj, string propertyOrMethod, T data);
        public void AddDynamicListener(StudioObjectBuilder target, object obj, string propertyOrMethod);
    }

    public abstract class StudioObjectBuilder
    {

        public static StudioObjectBuilderImpl impl;

        public StudioObjectPort __Target;

        public StudioObjectBuilder(StudioObjectPort target)
        {
            __Target = target;
        }

        public GameObject gameObject { get => __Target.AsData<GameObject>(); }

        public abstract void __UpdateStudioEvents();

        public StudioObjectBuilderImpl __GetImplementation()
        {
            if (impl == null) throw new Exception("StudioObjectBuilder is not supported yet");
            return impl;
        }

        public void __AddStudioEvent(string name, StudioEventType type, Action creator)
        {
            __GetImplementation().__AddStudioEvent(this, name, type, creator);
        }

        public void __AddStudioEvent<T>(string name, StudioEventType type, Action<T> creator)
        {
            __GetImplementation().__AddStudioEvent(this, name, type, creator);
        }
        public void __AddStudioEvent<T1, T2>(string name, StudioEventType type, Action<T1, T2> creator)
        {
            __GetImplementation().__AddStudioEvent(this, name, type, creator);
        }

        protected void AddListener<T>(object obj, string propertyOrMethod)
        {
            __GetImplementation().AddListener(this, obj, propertyOrMethod);
        }

        protected void AddListener<T>(object obj, string propertyOrMethod, T data)
        {
            __GetImplementation().AddListener<T>(this, obj, propertyOrMethod, data);
        }

        protected void AddDynamicListener<T>(object obj, string propertyOrMethod)
        {
            __GetImplementation().AddDynamicListener(this, obj, propertyOrMethod);
        }
    }

    public class StudioEvent : Attribute { }
    public class StudioEventRange : Attribute
    {
        public StudioEventRange(int start, int count, int increment = 1) { }
        public StudioEventRange(params object[] values) { }
    }
}
