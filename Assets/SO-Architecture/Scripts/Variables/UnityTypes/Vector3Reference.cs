using System;
using UnityEngine;

namespace SOArchitecture.Variables
{

    [Serializable]
    public class Vector3Reference : VariableReference<Vector3Variable, Vector3>
    {
        protected override void ApplyChangeToConstant(Vector3 amount)
        {
            ConstantValue += amount;
        }
    }
}