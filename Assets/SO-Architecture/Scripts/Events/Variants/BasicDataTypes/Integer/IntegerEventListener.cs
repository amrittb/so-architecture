using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events
{

    public class IntegerEventListener : BaseGameEventListener<int>
    {

        public IntegerGameEvent GameEvent;
        public IntegerUnityEvent GameResponse;

        protected override BaseGameEvent<int> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<int> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
