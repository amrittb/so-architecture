using System;
using UnityEngine;
using UnityEngine.Events;

namespace SOArchitecture.Events
{

    public class ColorEventListener : BaseGameEventListener<Color>
    {

        public ColorGameEvent GameEvent;
        public ColorUnityEvent GameResponse;

        protected override BaseGameEvent<Color> Event
        {
            get
            {
                return GameEvent;
            }
        }

        protected override UnityEvent<Color> Response
        {
            get
            {
                return GameResponse;
            }
        }
    }
}
