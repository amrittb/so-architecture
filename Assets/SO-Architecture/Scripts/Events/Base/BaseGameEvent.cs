using System;
using System.Collections.Generic;
using UnityEngine;

namespace SOArchitecture.Events {

    public abstract class BaseGameEvent<T> : BaseEvent {

#if UNITY_EDITOR
        [Tooltip("Dummy Value to test event raised.")]
        public T dummyValue;

        public override void Raise() {
            Raise(dummyValue);
        }
#else
        public override void Raise() {
            throw new Exception("Cannot Raise event without argument. Use another variant of Raise()");
        }
#endif

        private List<BaseGameEventListener<T>> listeners = new List<BaseGameEventListener<T>>();

        public void Raise(T arg) {
            for(int i = listeners.Count - 1; i >= 0; i--) {
                listeners[i].OnEventRaised(arg);
            }
        }

        public void RegisterListener(BaseGameEventListener<T> listener) {
            if(! listeners.Contains(listener)) {
                listeners.Add(listener);
            }
        }

        public void UnregisterListener(BaseGameEventListener<T> listener) {
            if (listeners.Contains(listener)) {
                listeners.Remove(listener);
            }
        }
    }
}

