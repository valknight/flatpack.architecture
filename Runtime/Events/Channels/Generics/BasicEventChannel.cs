using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace Flatpack.Architecture.Events.Channels.Generics
{
    internal class BasicEventChannel<T>: AbstractEventChannel<T>
    {
        private List<Action<T>> _callbacks;
        
        public override void Dispatch(T data)
        {
            if (_callbacks == null) return;
            // go backwards through the loop
            // this way, if something is null, we can remove it without the indexing getting weird
            for (var i = _callbacks.Count - 1; i >= 0; i--)
            {
                if (_callbacks[i] == null)
                {
                    _callbacks.RemoveAt(i);
                    continue;
                }
                // Call the callback!
                _callbacks[i](data);
            }
        }

        public override void Subscribe(Action<T> callback)
        {
            // Never add a null callback, as that's pretty useless?
            // unless you're doing some buck wild changing around the reference at runtime
            // but in which case; don't do that. fixed.
            if (callback == null) return;
            // create the list if not defined
            _callbacks ??= new List<Action<T>>();
            // check if the list contains callback already
            if (_callbacks.Contains(callback)) return;
            // add the callback to the list as it's not present
            _callbacks.Add(callback);
        }

        public override void Unsubscribe(Action<T> callback)
        {
            // no bother creating it here, that's not a useful allocation
            if (_callbacks == null) return;
            while (_callbacks.Contains(callback))
            {
                _callbacks.Remove(callback);
            }
        }
    }
}