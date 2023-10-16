using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Multiply
{
    public class SharedVector2Multiplication: AbstractGenericSharedData<Vector2>
    {
        private AbstractGenericSharedData<Vector2> op1;
        private AbstractGenericSharedData<Vector2> op2;

        public override Vector2 Value 
        {
            get
            {
                var x = op1.Value.x * op2.Value.x;
                var y = op1.Value.x * op2.Value.y;
                return new Vector2(x, y);
            }
        }
    }
}