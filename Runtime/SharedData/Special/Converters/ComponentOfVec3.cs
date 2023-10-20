using System;
using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Converters
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Converters/Vector3 Component as Float", fileName = "ComponentOfVec3", order = 0)]
    public class ComponentOfVec3: AbstractGenericSharedData<float>
    {
        [SerializeField] private AbstractGenericSharedData<Vector3> op;
        [SerializeField] private Vec3Component componentToGet;

        public override float Value
        {
            get
            {
                return componentToGet switch
                {
                    Vec3Component.X => op.Value.x,
                    Vec3Component.Y => op.Value.y,
                    Vec3Component.Z => op.Value.z,
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }

        private enum Vec3Component
        {
            X = 0,
            Y = 1,
            Z = 2
        }
    }
}