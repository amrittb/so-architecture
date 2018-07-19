using UnityEngine;

namespace SOArchitecture.Variables {

    public abstract class  Variable<T> : ScriptableObject {

        public T DefaultValue;

        public T CurrentValue;

        public bool ResetChange;

        public void SetValue(T value) {
            CurrentValue = value;
        }

        public void SetValue(Variable<T> value) {
            CurrentValue = value.CurrentValue;
        }

        protected virtual void OnEnable() {
            ResetValue();
        }

        protected virtual void OnDisable() {
            ResetValue();
        }

        public void ResetValue() {
            if (ResetChange) {
                CurrentValue = DefaultValue;
            }
        }

        public void ForceResetValue() {
            CurrentValue = DefaultValue;
        }

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription;
#endif
    }
}


