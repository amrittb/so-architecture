using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public class FloatEventListener : BaseGameEventListener<float> {

        public FloatGameEvent GameEvent;
        public FloatUnityEvent GameResponse;

        protected override BaseGameEvent<float> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<float> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
