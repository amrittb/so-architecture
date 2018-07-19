using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public class Vector3EventListener : BaseGameEventListener<Vector3> {

        public Vector3GameEvent GameEvent;
        public Vector3UnityEvent GameResponse;

        protected override BaseGameEvent<Vector3> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<Vector3> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
