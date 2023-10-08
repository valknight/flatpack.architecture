using Flatpack.Architecture.SharedData.Generics;

namespace Flatpack.Architecture.SharedData.Special.Time
{
    /// <summary>
    /// This allows us to modify the timescale, simply by writing to a shared value
    /// This could allow us to do some funky maths, especially when it comes to like, on-hit effects, or the like
    /// </summary>
    [UnityEngine.CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Time/Smooth Delta Time", fileName = "SharedTimeScale", order = 0)]
    internal class SharedTimeScale: AbstractGenericSettableSharedData<float>
    {
        public override float Value => UnityEngine.Time.timeScale;
        
        public override void SetData(float value)
        {
            UnityEngine.Time.timeScale = value;
        }
    }
}