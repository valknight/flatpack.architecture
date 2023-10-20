using Flatpack.Architecture.SharedData.Generics;
using Sirenix.OdinInspector;
using UnityEngine;

namespace HelperBehaviours.SharedData
{
    public abstract class WritebackBehaviour<T>: MonoBehaviour
    {
        [TabGroup("Timings")] [SerializeField] private bool updateOnEveryUpdate = true;
        [TabGroup("Timings")] [SerializeField] private bool updateOnEveryFixedUpdate = false;
        [TabGroup("Timings")] [SerializeField] private bool updateOnStart = false;
        [TabGroup("Storage")] [SerializeField] private protected AbstractGenericSettableSharedData<T> forwardOutput;
        
        private void Start()
        {
            if (updateOnStart) SetData();
        }
        
        private void Update()
        {
            if (updateOnEveryUpdate) SetData();
        }

        private void FixedUpdate()
        {
            if (updateOnEveryFixedUpdate) SetData();
        }

        public abstract void SetData();
    }
}