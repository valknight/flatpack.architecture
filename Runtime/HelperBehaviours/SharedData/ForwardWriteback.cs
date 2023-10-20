using Flatpack.Architecture.SharedData.Generics;
using Sirenix.OdinInspector;
using UnityEngine;

namespace HelperBehaviours.SharedData
{
    public class ForwardWriteback: WritebackBehaviour<Vector3>
    {
        public override void SetData()
        {
            forwardOutput.SetData(transform.forward);
        }
    }
}