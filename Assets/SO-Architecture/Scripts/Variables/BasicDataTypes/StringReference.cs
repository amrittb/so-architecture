using System;

namespace SOArchitecture.Variables {

    [Serializable]
    public class StringReference : VariableReference<StringVariable, string>
    {
        protected override void ApplyChangeToConstant(string amount)
        {
            ConstantValue = amount;
        }
    }
}