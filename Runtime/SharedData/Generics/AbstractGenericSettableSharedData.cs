using Sirenix.OdinInspector;

namespace Flatpack.Architecture.SharedData.Generics
{
    public abstract class AbstractGenericSettableSharedData<T>: AbstractGenericSharedData<T>
    {
        [BoxGroup("Manual Method Calls")]
        [Button(ButtonStyle.Box, Name = "Set Data Call")]
        public abstract void SetData(T value);
    }
}