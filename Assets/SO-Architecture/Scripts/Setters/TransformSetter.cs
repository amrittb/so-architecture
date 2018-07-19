using UnityEngine;
using SOArchitecture.Variables;

namespace SOArchitecture.Setters { 

    public class TransformSetter : MonoBehaviour {

        [Tooltip("Position variable.")]
        public Vector3Variable position;

        [Tooltip("Rotation variable.")]
        public QuaternionVariable rotation;

        [Tooltip("Scale variable.")]
        public Vector3Variable scale;

        [Tooltip("Forward variable.")]
        public Vector3Variable forward;

        [Tooltip("Up variable.")]
        public Vector3Variable up;

        private void Update() {
            if(position != null) {
                position.CurrentValue = transform.position;
            }

            if(rotation != null) {
                rotation.CurrentValue = transform.rotation;
            }

            if(scale != null) {
                scale.CurrentValue = transform.localScale;
            }

            if(forward != null) {
                forward.CurrentValue = transform.forward.normalized;
            }

            if(up != null) {
                up.CurrentValue = transform.up.normalized;
            }
        }
    }
}
