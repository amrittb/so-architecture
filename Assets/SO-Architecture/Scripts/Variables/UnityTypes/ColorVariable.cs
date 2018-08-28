using System;
using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewColorVariable", menuName = "SO Architecture/Variables/ColorVariable")]
    public class ColorVariable : Variable<Color>
    {
        public override void ApplyChange(Color amount)
        {
            CurrentValue = amount;
        }
    }
}