using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events
{

    public class QuaternionEventListener : BaseGameEventListener<Quaternion>
    {

        public QuaternionGameEvent GameEvent;
        public QuaternionUnityEvent GameResponse;

        protected override BaseGameEvent<Quaternion> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<Quaternion> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
