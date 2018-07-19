using UnityEngine;

namespace SOArchitecture.Variables {

    [CreateAssetMenu(fileName = "NewBooleanVariable", menuName = "SO Architecture/Variables/BooleanVariable")]
    public class BooleanVariable : Variable<bool> {

        public void ApplyChange(bool amount) {
            CurrentValue = amount;
        }

        public void ApplyChange(BooleanVariable amount) {
            CurrentValue = amount.CurrentValue;
        }
    }
}
