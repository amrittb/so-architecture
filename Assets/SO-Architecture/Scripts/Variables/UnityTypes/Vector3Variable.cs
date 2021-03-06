﻿using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewVector3Variable", menuName = "SO Architecture/Variables/Vector3Variable")]
    public class Vector3Variable : Variable<Vector3>
    {
        public override void ApplyChange(Vector3 amount)
        {
            CurrentValue += amount;
        }
    }
}

