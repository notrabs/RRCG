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
        public string __PrefabName;

        public StudioObjectBuilder(StudioObjectPort target, string prefabName = null)
        {
            __Target = target;
            __PrefabName = prefabName;
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

        public void __AddStudioEventRange<RT>(string name, StudioEventType type, Action<RT> creator, params RT[] rangeParams)
        {
            foreach (var i in EnumerateRange(rangeParams))
            {
                __GetImplementation().__AddStudioEvent(this, name + i.ToString(), type, () => creator(i));
            }
        }
        public void __AddStudioEventRange<RT, T>(string name, StudioEventType type, Action<RT, T> creator, params RT[] rangeParams)
        {
            foreach (var i in EnumerateRange(rangeParams))
            {
                __GetImplementation().__AddStudioEvent<T>(this, name + i.ToString(), type, (p1) => creator(i, p1));
            }
        }
        public void __AddStudioEventRange<RT, T1, T2>(string name, StudioEventType type, Action<RT, T1, T2> creator, params RT[] rangeParams)
        {
            foreach (var i in EnumerateRange(rangeParams))
            {
                __GetImplementation().__AddStudioEvent<T1, T2>(this, name + i.ToString(), type, (p1, p2) => creator(i, p1, p2));
            }
        }

        public string __GetPrefabName()
        {
            if (__PrefabName == null) throw new Exception("A StudioObjectDescriptor must specifcy a prefabName in the base constructor to use Studio functions");
            return __PrefabName;
        }

        public void __SpawnStudioFunctionChip(string fnName)
        {
            ChipBuilder.StudioFunction(new StudioFunctionData(__GetPrefabName(), fnName));
        }

        public IEnumerable<T> EnumerateRange<T>(params T[] rangeParams)
        {
            if (rangeParams.GetType() == typeof(int[]) && rangeParams.Length == 2)
            {
                int start = rangeParams[0] as dynamic;
                int end = rangeParams[1] as dynamic;

                if (start <= end)
                {
                    for (int i = start; i < end; i++) yield return i as dynamic;
                }
                else
                {
                    for (int i = start; i > end; i--) yield return i as dynamic;
                }
            }
            else if (rangeParams.GetType() == typeof(int[]) && rangeParams.Length == 2)
            {
                int start = rangeParams[0] as dynamic;
                int end = rangeParams[1] as dynamic;

                if (start <= end)
                {
                    for (int i = start; i < end; i++) yield return i as dynamic;
                }
                else
                {
                    for (int i = start; i > end; i--) yield return i as dynamic;
                }
            }
            else if (rangeParams.GetType() == typeof(int[]) && rangeParams.Length == 3)
            {
                int start = rangeParams[0] as dynamic;
                int end = rangeParams[1] as dynamic;
                int increment = rangeParams[2] as dynamic;

                if (start <= end)
                {
                    for (int i = start; i < end; i += increment) yield return i as dynamic;
                }
                else
                {
                    for (int i = start; i > end; i += increment) yield return i as dynamic;
                }
            }
            else
            {
                foreach (var item in rangeParams) yield return item;
            }
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

    public class StudioFunction : Attribute { }
    public class ExistingStudioFunction : Attribute { }
}
