using RRCG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RRCGBuild
{
    /// <summary>
    /// Dispatches and manages "special methods" (event functions/shared properties).
    /// </summary>
    public class SpecialMethodsDispatcher
    {
        public static SpecialMethodsDispatcher current;
        private Dictionary<object, SpecialMethodsContainer> Containers = new();

        dynamic DispatchEventFunctionInternal(object owner, string name, object target, MethodInfo method, params AnyPort[] args)
        {
            var container = GetContainerForOwner(owner);
            var signature = DispatchFunctionSignature(method);

            // Has this particular event function been created for the owner already?
            if (!container.EventFunctions.ContainsKey(signature))
            {
                // Build the method contents on a new event.
                // Climb to the root context..
                var prevContext = Context.current;
                while (Context.current.ParentContext != null)
                    Context.current = Context.current.ParentContext;

                // Place the event definition in the root context..
                (StringPort, Type)[] eventPorts = args.Select((arg, index) => ((StringPort)"value" + index, arg.GetType())).ToArray();
                var eventDefinition = new DynamicEventDefinition("EventFunction_" + name, eventPorts);

                // Then return to the previous context.
                Context.current = prevContext;

                // Now build the method body from the event receiver.
                // Build with analysis, so we can place it into a sensible Context.
                var analysis = GraphUtils.BuildWithAnalysis(() =>
                {
                    var ports = eventDefinition.Receiver();
                    return method.Invoke(target, ports);
                });

                // Now look for any connections to/from nodes
                // outside the context ("dependencies" if you will),
                // to help us figure out in which context to place the receiver.
                //
                // NOTE: It's probably impossible as of now to create an outgoing dependency,
                //       but it's technically correct to check for them anyway.
                var context = analysis.AnalyzedContext;
                var incomingDependencies = context.Connections.Where(c => c.From.Node.Context != context).Select(c => c.From.Node);
                var outgoingDependencies = context.Connections.Where(c => c.To.Node.Context != context).Select(c => c.To.Node);

                // Now look at their contexts. If the dependencies live in different
                // contexts to eachother, the situation cannot be reconciled.
                var dependencyContexts = incomingDependencies.Select(n => n.Context)
                                        .Concat(outgoingDependencies.Select(n => n.Context))
                                        .Distinct()
                                        .ToArray();

                if (dependencyContexts.Length > 1)
                    throw new Exception($"EventFunction references nodes from more than one external context!");

                // Otherwise, we either choose to place the receiver in
                // the first dependency context, or just the current context.
                var targetContext = dependencyContexts.FirstOrDefault() ?? Context.current;
                targetContext.Merge(context);

                // Finally, store the event with the return data.
                container.EventFunctions[signature] = (eventDefinition, analysis.ReturnValue);
            }

            // Finally, we send the event & return the result.
            container.EventFunctions[signature].Event.SendLocal(args);
            return container.EventFunctions[signature].Return;
        }

        public T DispatchSharedPropertyFunction<T>(object owner, Func<T> fn)
        {
            var container = GetContainerForOwner(owner);
            var signature = DispatchFunctionSignature(fn.GetMethodInfo());

            // Has this shared function been built for the owner already?
            if (!container.SharedProperties.ContainsKey(signature))
                container.SharedProperties[signature] = CircuitBuilder.InlineGraph(fn);

            return (T)container.SharedProperties[signature];
        }

        #region DispatchEventFunction overloads
        public void DispatchEventFunction(object owner, string name, Action fn) => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo());

        public T DispatchEventFunction<T>(object owner, string name, Func<T> fn) => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo());

        public void DispatchEventFunction<T0>(object owner, string name, Action<T0> fn, T0 param0)
            where T0 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0);

        public T DispatchEventFunction<T, T0>(object owner, string name, Func<T0, T> fn, T0 param0)
            where T0 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0);

        public void DispatchEventFunction<T0, T1>(object owner, string name, Action<T0, T1> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1);

        public T DispatchEventFunction<T, T0, T1>(object owner, string name, Func<T0, T1, T> fn, T0 param0, T1 param1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1);

        public void DispatchEventFunction<T0, T1, T2>(object owner, string name, Action<T0, T1, T2> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2);

        public T DispatchEventFunction<T, T0, T1, T2>(object owner, string name, Func<T0, T1, T2, T> fn, T0 param0, T1 param1, T2 param2)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2);

        public void DispatchEventFunction<T0, T1, T2, T3>(object owner, string name, Action<T0, T1, T2, T3> fn, T0 param0, T1 param1, T2 param2, T3 param3)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3);

        public T DispatchEventFunction<T, T0, T1, T2, T3>(object owner, string name, Func<T0, T1, T2, T3, T> fn, T0 param0, T1 param1, T2 param2, T3 param3)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3);

        public void DispatchEventFunction<T0, T1, T2, T3, T4>(object owner, string name, Action<T0, T1, T2, T3, T4> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4);

        public T DispatchEventFunction<T, T0, T1, T2, T3, T4>(object owner, string name, Func<T0, T1, T2, T3, T4, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4);

        public void DispatchEventFunction<T0, T1, T2, T3, T4, T5>(object owner, string name, Action<T0, T1, T2, T3, T4, T5> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5);

        public T DispatchEventFunction<T, T0, T1, T2, T3, T4, T5>(object owner, string name, Func<T0, T1, T2, T3, T4, T5, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5);

        public void DispatchEventFunction<T0, T1, T2, T3, T4, T5, T6>(object owner, string name, Action<T0, T1, T2, T3, T4, T5, T6> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5, param6);

        public T DispatchEventFunction<T, T0, T1, T2, T3, T4, T5, T6>(object owner, string name, Func<T0, T1, T2, T3, T4, T5, T6, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5, param6);

        public void DispatchEventFunction<T0, T1, T2, T3, T4, T5, T6, T7>(object owner, string name, Action<T0, T1, T2, T3, T4, T5, T6, T7> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
        => DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5, param6, param7);

        public T DispatchEventFunction<T, T0, T1, T2, T3, T4, T5, T6, T7>(object owner, string name, Func<T0, T1, T2, T3, T4, T5, T6, T7, T> fn, T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
            where T2 : AnyPort, new()
            where T3 : AnyPort, new()
            where T4 : AnyPort, new()
            where T5 : AnyPort, new()
            where T6 : AnyPort, new()
            where T7 : AnyPort, new()
        => (T)DispatchEventFunctionInternal(owner, name, fn.Target, fn.GetMethodInfo(), param0, param1, param2, param3, param4, param5, param6, param7);
        #endregion

        private string DispatchFunctionSignature(MethodInfo method) => method.ToString();

        private SpecialMethodsContainer GetContainerForOwner(object owner)
        {
            if (Containers.TryGetValue(owner, out var result))
                return result;

            var newContainer = new SpecialMethodsContainer();
            Containers[owner] = newContainer;
            return newContainer;
        }

        /// <summary>
        /// A class to contain the special method information for a particular "owner".
        /// An owner can be an instance of a class, or a Type itself,
        /// for instance/static methods respectively.
        /// </summary>
        private class SpecialMethodsContainer
        {
            public Dictionary<string, (DynamicEventDefinition Event, object Return)> EventFunctions = new();
            public Dictionary<string, dynamic> SharedProperties = new();
        }
    }
}