using System;
using UnityEngine;

namespace SOArchitecture.Variables
{

    [Serializable]
    public class ColorReference : VariableReference<ColorVariable, Color>
    {
        protected override void ApplyChangeToConstant(Color amount)
        {
            ConstantValue = amount;
        }
    }
}
