using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Multiply
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Multiply (Vector2)", fileName = "SharedVector2Multiplication", order = 0)]
    public class SharedVector2Multiplication: AbstractGenericSharedData<Vector2>
    {
        [SerializeField] private AbstractGenericSharedData<Vector2> op1;
        [SerializeField] private AbstractGenericSharedData<Vector2> op2;

        public override Vector2 Value 
        {
            get
            {
                var x = op1.Value.x * op2.Value.x;
                var y = op1.Value.y * op2.Value.y;
                var toReturn = new Vector2(x, y);
                return toReturn;
            }
        }
    }
}