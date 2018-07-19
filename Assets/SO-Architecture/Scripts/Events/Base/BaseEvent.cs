using UnityEngine;

namespace SOArchitecture.Events {

    public abstract class BaseEvent : ScriptableObject {

        public abstract void Raise();
    }
}