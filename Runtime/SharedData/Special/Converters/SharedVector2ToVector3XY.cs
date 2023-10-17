using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Converters
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Converters/Vector2 -> Vector3 (X->X, Y->Y)", fileName = "SharedVector2ToVector3XY", order = 0)]
    public class SharedVector2ToVector3XY: AbstractGenericSharedData<Vector3>
    {
        public AbstractGenericSharedData<float> zValue;
        public AbstractGenericSharedData<Vector2> op;
        
        public override Vector3 Value => new(op.Value.x, op.Value.y, zValue.Value);
    }
}