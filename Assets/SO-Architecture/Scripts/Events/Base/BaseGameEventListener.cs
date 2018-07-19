using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public abstract class BaseGameEventListener<T> : MonoBehaviour {

        protected abstract BaseGameEvent<T> Event { get; }
        protected abstract UnityEvent<T> Response { get; }

        private void OnEnable() {
            Event.RegisterListener(this);
        }

        private void OnDisable() {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T arg) {
            Response.Invoke(arg);
        }
    }
}