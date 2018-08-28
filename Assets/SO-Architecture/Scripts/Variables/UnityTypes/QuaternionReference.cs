using System;
using UnityEngine;

namespace SOArchitecture.Variables
{

    [Serializable]
    public class QuaternionReference : VariableReference<QuaternionVariable, Quaternion>
    {
        protected override void ApplyChangeToConstant(Quaternion amount)
        {
            ConstantValue *= amount;
        }
    }
}