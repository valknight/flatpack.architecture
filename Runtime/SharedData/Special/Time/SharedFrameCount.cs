using Flatpack.Architecture.SharedData.Generics;

namespace Flatpack.Architecture.SharedData.Special.Time
{
    /// <summary>
    /// </summary>
    [UnityEngine.CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Time/Frame Count", fileName = "SharedFrameCount", order = 0)]
    internal class SharedFrameCount: AbstractGenericSharedData<int>
    {
        public override int Value => UnityEngine.Time.frameCount;
    }
}