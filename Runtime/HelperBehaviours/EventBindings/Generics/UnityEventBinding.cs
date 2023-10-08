using Flatpack.Architecture.Events.Channels.Generics;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Flatpack.Architecture.HelperBehaviours.EventBindings.Generics
{
    /// <summary>
    /// Binding layer that can connect a UnityEvent to an EventChannel
    /// Be wary using this for high-frequency events, as UnityEvents do incur a performance overhead
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnityEventBinding<T>: MonoBehaviour
    {
        [BoxGroup("Binding Setup")]
        public UnityEvent<T> serializedEvent;
        [BoxGroup("Binding Setup")]
        public AbstractEventChannel<T> targetChannel;

        void OnEnable()
        {
            // Add the UnityEvent binding as a subscribed layer
            targetChannel.Subscribe(serializedEvent.Invoke);
        }

        private void OnDisable()
        {
            // Unsubscribe when this binding becomes disabled!
            targetChannel.Unsubscribe(serializedEvent.Invoke);
        }
    }
}