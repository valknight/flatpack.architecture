using Flatpack.Architecture.Events.Channels.Generics;
using Flatpack.Architecture.SharedData.Generics;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Flatpack.Architecture.Events.InvokingData.Generics
{
    [InlineEditor]
    public class EventInvokingSharedData<T>: AbstractGenericSettableSharedData<T>
    {
        [BoxGroup("Data")]
        [LabelText("Serialized Value")]
        [SerializeField] private T data;    
        [BoxGroup("Event Channels")]
        [SerializeField] private AbstractEventChannel<AbstractGenericSharedData<T>> referenceEventChannel;
        [BoxGroup("Event Channels")]
        [SerializeField] private AbstractEventChannel<T> eventChannel;
        
        public override T Value => data;
        public override void SetData(T value)
        {
            data = value;
            Invoke();
        }

        /// <summary>
        /// Cause an invocation of this shared data object
        /// This also allows objects to manually reinvoke the same data
        /// </summary>
        [BoxGroup("Manual Method Calls")]
        [Button(ButtonSizes.Medium, Name = "Manual Invocation")]
        public void Invoke()
        {
            // First, dispatch the reference to this object
            // This is useful specifically for shared data which contain a value type
            // ReSharper disable once Unity.NoNullPropagation
            referenceEventChannel?.Dispatch(this);
            // ReSharper disable once Unity.NoNullPropagation
            eventChannel?.Dispatch(data);
        }
    }
}