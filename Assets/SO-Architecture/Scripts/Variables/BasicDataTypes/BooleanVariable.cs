using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewBooleanVariable", menuName = "SO Architecture/Variables/BooleanVariable")]
    public class BooleanVariable : Variable<bool>
    {

        public override void ApplyChange(bool amount)
        {
            CurrentValue = amount;
        }
    }
}
