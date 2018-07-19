using UnityEngine;

namespace SOArchitecture.Variables {

    [CreateAssetMenu(fileName = "NewIntegerVariable", menuName = "SO Architecture/Variables/IntegerVariable")]
    public class IntegerVariable : Variable<int> {

        public void ApplyChange(int amount) {
            CurrentValue += amount;
        }

        public void ApplyChange(IntegerVariable amount) {
            CurrentValue += amount.CurrentValue;
        }
    }
}
