using System;

namespace SOArchitecture.Variables
{

    [Serializable]
    public abstract class VariableReference<T, U> : BaseVariableReference where T : Variable<U>
    {

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
                if (UseConstant)
                {
                    ConstantValue = value;
                }
                else
                {
                    Variable.CurrentValue = value;
                }
            }
        }

        public static implicit operator U(VariableReference<T, U> reference)
        {
            return reference.Value;
        }

        public virtual void ApplyChange(VariableReference<T, U> reference)
        {
            ApplyChange(reference.Value);
        }

        public virtual void ApplyChange(T amount)
        {
            ApplyChange(amount.CurrentValue);
        }

        public virtual void ApplyChange(U amount)
        {
            if (UseConstant)
            {
                ApplyChangeToConstant(amount);
            }
            else
            {
                Variable.ApplyChange(amount);
            }
        }



        protected abstract void ApplyChangeToConstant(U amount);
    }
}