using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Multiply
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Multiply Float", fileName = "SharedFloatMultiplication", order = 0)]
    public class SharedFloatMultiplication: AbstractGenericSharedData<float>
    {
        [SerializeField] private AbstractGenericSharedData<float> op1;
        [SerializeField] private AbstractGenericSharedData<float> op2;

        public override float Value
        {
            get
            {
                return op1.Value * op2.Value;
            }
        }
    }
}