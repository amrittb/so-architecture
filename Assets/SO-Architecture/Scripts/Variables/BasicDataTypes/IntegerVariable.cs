﻿using UnityEngine;

namespace SOArchitecture.Variables {

    [CreateAssetMenu(fileName = "NewIntegerVariable", menuName = "SO Architecture/Variables/IntegerVariable")]
    public class IntegerVariable : Variable<int> {

        public override void ApplyChange(int amount) {
            CurrentValue += amount;
        }
    }
}
