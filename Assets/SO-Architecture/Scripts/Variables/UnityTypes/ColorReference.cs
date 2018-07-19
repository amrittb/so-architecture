using System;
using UnityEngine;

namespace SOArchitecture.Variables {

    [Serializable]
    public class ColorReference : VariableReference<ColorVariable, Color> {

        public static implicit operator Color(ColorReference reference) {
            return reference.Value;
        }
    }
}
