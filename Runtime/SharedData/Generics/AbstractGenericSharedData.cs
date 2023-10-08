using Sirenix.OdinInspector;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Generics
{
    [InlineEditor]
    public abstract class AbstractGenericSharedData<T>: ScriptableObject
    {
        public abstract T Value
        {
            get;
        }
    }
}