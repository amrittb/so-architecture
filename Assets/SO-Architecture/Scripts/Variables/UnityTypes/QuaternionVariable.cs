using UnityEngine;

namespace SOArchitecture.Variables
{

    [CreateAssetMenu(fileName = "NewQuaternionVariable", menuName = "SO Architecture/Variables/QuaternionVariable")]
    public class QuaternionVariable : Variable<Quaternion>
    {
        public override void ApplyChange(Quaternion amount)
        {
            CurrentValue *= amount;
        }
    }
}

