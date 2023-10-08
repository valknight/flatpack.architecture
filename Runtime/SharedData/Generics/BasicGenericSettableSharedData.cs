using Sirenix.OdinInspector;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Generics
{
    internal class BasicGenericSettableSharedData<T>: AbstractGenericSettableSharedData<T>
    {
        [BoxGroup("Data")]
        [LabelText("Serialized Value")]
        [SerializeField] private T data;
        
        // We don't add a setter, as this conflicts with the definition for a non-settable type
        public override T Value => data;

        public override void SetData(T value)
        {
            data = value;
        }
    }
}