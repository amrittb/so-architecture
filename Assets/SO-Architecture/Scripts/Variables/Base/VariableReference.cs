using System;

namespace SOArchitecture.Variables {

    [Serializable]
    public class VariableReference<T, U> : BaseVariableReference where T : Variable<U> {

        public bool UseConstant = true;
        public U ConstantValue;
        public T Variable;

        public VariableReference()
        { }

        public VariableReference(U value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public U Value
        {
            get { return UseConstant ? ConstantValue : Variable.CurrentValue; }
            set
            {
                if(UseConstant) {
                    ConstantValue = value;
                } else {
                    Variable.CurrentValue = value;
                }
            }
        }

        public static implicit operator U(VariableReference<T, U> reference)
        {
            return reference.Value;
        }
    }
}