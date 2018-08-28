using System;

namespace SOArchitecture.Variables {

    [Serializable]
    public class BooleanReference : VariableReference<BooleanVariable, bool>
    {
        protected override void ApplyChangeToConstant(bool amount)
        {
            ConstantValue = amount;
        }
    }
}