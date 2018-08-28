using UnityEngine;
using System.Collections.Generic;

namespace SOArchitecture.Events
{

    [CreateAssetMenu(fileName = "New Simple Game Event", menuName = "SO Architecture/Events/SimpleGameEvent")]
    public class SimpleGameEvent : BaseEvent
    {

        private List<SimpleGameEventListener> listeners = new List<SimpleGameEventListener>();

        public override void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(SimpleGameEventListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
            }
        }

        public void UnregisterListener(SimpleGameEventListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }
    }
}

