using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Multiply
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Multiply (Vector3)", fileName = "SharedVector3Multiplication", order = 0)]
    public class SharedVector3Multiplication: AbstractGenericSharedData<Vector3>
    {
        [SerializeField] private AbstractGenericSharedData<Vector3> op1;
        [SerializeField] private AbstractGenericSharedData<Vector3> op2;

        public override Vector3 Value 
        {
            get
            {
                var x = op1.Value.x * op2.Value.x;
                var y = op1.Value.y * op2.Value.y;
                var z = op1.Value.z * op2.Value.z;
                return new Vector3(x, y, z);
            }
        }
    }
}