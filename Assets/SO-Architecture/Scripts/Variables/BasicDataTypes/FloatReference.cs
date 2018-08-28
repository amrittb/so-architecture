using System;

namespace SOArchitecture.Variables {

    [Serializable]
    public class FloatReference : VariableReference<FloatVariable, float>
    {
        protected override void ApplyChangeToConstant(float amount)
        {
            ConstantValue += amount;
        }
    }
}