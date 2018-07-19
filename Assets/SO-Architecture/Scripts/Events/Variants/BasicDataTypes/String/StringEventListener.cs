using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public class StringEventListener : BaseGameEventListener<string> {

        public StringGameEvent GameEvent;
        public StringUnityEvent GameResponse;

        protected override BaseGameEvent<string> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<string> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
