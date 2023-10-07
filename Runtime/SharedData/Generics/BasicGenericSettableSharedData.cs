using UnityEngine;

namespace Flatpack.Architecture.SharedData.Generics
{
    public class BasicGenericSettableSharedData<T>: AbstractGenericSettableSharedData<T>
    {
        [SerializeField] private T data;
        
        public T Value
        {
            get => data;
            set => SetData(value);
        }
        
        public override void SetData(T value)
        {
            data = value;
        }
    }
}