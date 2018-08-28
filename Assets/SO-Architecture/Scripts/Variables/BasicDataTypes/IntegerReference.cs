using System;

namespace SOArchitecture.Variables {

    [Serializable]
    public class IntegerReference : VariableReference<IntegerVariable, int>
    {
        protected override void ApplyChangeToConstant(int amount)
        {
            ConstantValue += amount;
        }
    }
}