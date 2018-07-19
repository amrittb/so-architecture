using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events {

    public class GameObjectEventListener : BaseGameEventListener<GameObject> {

        public GameObjectGameEvent GameEvent;
        public GameObjectUnityEvent GameResponse;

        protected override BaseGameEvent<GameObject> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<GameObject> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
