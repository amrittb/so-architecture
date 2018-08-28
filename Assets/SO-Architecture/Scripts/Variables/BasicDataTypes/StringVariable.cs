using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewStringVariable", menuName = "SO Architecture/Variables/StringVariable")]
    public class StringVariable : Variable<string>
    {
        public override void ApplyChange(string amount)
        {
            CurrentValue = amount;
        }
    }
}

