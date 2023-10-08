using Flatpack.Architecture.SharedData.Generics;

namespace Flatpack.Architecture.SharedData.Special.Time
{
    [UnityEngine.CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Time/Unscaled Delta Time", fileName = "SharedUnscaledDeltaTime", order = 0)]
    internal class SharedUnscaledDeltaTime: AbstractGenericSharedData<float>
    {
        public override float Value => UnityEngine.Time.unscaledDeltaTime;
    }
}