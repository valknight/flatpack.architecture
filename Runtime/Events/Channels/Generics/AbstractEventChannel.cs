using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Flatpack.Architecture.Events.Channels.Generics
{
    public abstract class AbstractEventChannel<T>: ScriptableObject
    {
        [Button(ButtonStyle.Box, Name = "Manual dispatch")]
        public abstract void Dispatch(T data);
        
        public abstract void Subscribe(Action<T> callback);
        public abstract void Unsubscribe(Action<T> callback);
    }
}