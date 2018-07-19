using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public class StateChangedEventListener : BaseGameEventListener<bool> {

        public StateChangedGameEvent GameEvent;
        public StateChangedUnityEvent GameResponse;

        protected override BaseGameEvent<bool> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<bool> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
