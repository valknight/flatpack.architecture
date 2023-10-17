using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Converters
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Converters/Vector2 -> Vector3 (X->X, Y->Z)", fileName = "SharedVector2ToVector3XZ", order = 0)]
    public class SharedVector2ToVector3XZ: AbstractGenericSharedData<Vector3>
    {
        public AbstractGenericSharedData<float> yValue;
        public AbstractGenericSharedData<Vector2> op;
        
        public override Vector3 Value => new(op.Value.x, yValue.Value, op.Value.y);
    }
}