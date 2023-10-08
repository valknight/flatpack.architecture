using Flatpack.Architecture.SharedData.Generics;

namespace Flatpack.Architecture.SharedData.Special.Time
{
    [UnityEngine.CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Time/Unscaled Time", fileName = "SharedUnscaledTime", order = 0)]
    internal class SharedUnscaledTime: AbstractGenericSharedData<float>
    {
        public override float Value => UnityEngine.Time.unscaledTime;
    }
}