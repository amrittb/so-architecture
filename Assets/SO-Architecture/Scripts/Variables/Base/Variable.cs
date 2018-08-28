using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SOArchitecture.Variables
{

    public abstract class Variable<T> : BaseVariable
    {

        [SerializeField]
        private T DefaultValue;

        public T CurrentValue;

        [SerializeField]
        private bool ResetChange;

        public void SetValue(T value)
        {
            CurrentValue = value;
        }

        public void SetValue(Variable<T> value)
        {
            CurrentValue = value.CurrentValue;
        }

        protected virtual void OnEnable()
        {
#if UNITY_EDITOR
            if (ResetChange && EditorApplication.isPlayingOrWillChangePlaymode)
            {
                ResetValue();
            }
#endif

            if (ResetChange && Application.isPlaying)
            {
                ResetValue();
            }
        }

        protected void ResetValue()
        {
            CurrentValue = DefaultValue;
        }

        public static implicit operator T(Variable<T> variable)
        {
            return variable.CurrentValue;
        }

        public abstract void ApplyChange(T amount);

        public void ApplyChange(Variable<T> amount)
        {
            this.ApplyChange(amount.CurrentValue);
        }

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription;
#endif
    }
}


