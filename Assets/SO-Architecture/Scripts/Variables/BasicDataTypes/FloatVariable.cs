using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewFloatVariable", menuName = "SO Architecture/Variables/FloatVariable")]
    public class FloatVariable : Variable<float>
    {

        public override void ApplyChange(float amount)
        {
            CurrentValue += amount;
        }
    }
}
