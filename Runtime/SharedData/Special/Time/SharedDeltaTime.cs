using Flatpack.Architecture.SharedData.Generics;

namespace Flatpack.Architecture.SharedData.Special.Time
{
    /// <summary>
    /// This is intended to allow multiplication by delta time to occur on the ScriptableObject layer
    /// By doing this, we can fix issues caused by not multiplying values without changing code
    /// This can help resolve bugs when it comes closer to deadlines, and, keeps code more generic
    /// </summary>
    [UnityEngine.CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Time/Delta Time", fileName = "SharedDeltaTime", order = 0)]
    internal class SharedDeltaTime: AbstractGenericSharedData<float>
    {
        public override float Value => UnityEngine.Time.deltaTime;
    }
}