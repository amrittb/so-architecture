using UnityEngine;

namespace SOArchitecture.Variables {

    [CreateAssetMenu(fileName = "NewFloatVariable", menuName = "SO Architecture/Variables/FloatVariable")]
    public class FloatVariable : Variable<float> {

        public void ApplyChange(float amount) {
            CurrentValue += amount;
        }

        public void ApplyChange(FloatVariable amount) {
            CurrentValue += amount.CurrentValue;
        }
    }
}
