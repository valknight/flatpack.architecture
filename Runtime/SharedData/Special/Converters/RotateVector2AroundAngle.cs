using System;
using Flatpack.Architecture.SharedData.Generics;
using UnityEngine;

namespace Flatpack.Architecture.SharedData.Special.Converters
{
    [CreateAssetMenu(menuName = "Flatpack/Architecture/Shared Data/Special/Converters/Rotate Vector2", fileName = "RotateVector2AroundAngle", order = 0)]
    public class RotateVector2AroundAngle: AbstractGenericSharedData<Vector2>
    {
        [SerializeField] private AbstractGenericSharedData<Vector2> baseValue;
        [SerializeField] private AbstractGenericSharedData<float> angle;
        [SerializeField] private AngleMode angleMode;

        private static Vector2 Rotate(Vector2 vec, float radians)
        {
            return new Vector2(
                vec.x * Mathf.Cos(radians) - vec.y * Mathf.Sin(radians),
                vec.x * Mathf.Sin(radians) + vec.y * Mathf.Cos(radians)
            );
        }
        public override Vector2 Value {
            get
            {
                var radianAngle = angle.Value;
                if (angleMode == AngleMode.Degrees)
                {
                    radianAngle *= Mathf.Deg2Rad;
                }
                return Rotate(baseValue.Value, radianAngle);
            }
        }

        private enum AngleMode
        {
            Radians = 0,
            Degrees = 1
        }
    }
}