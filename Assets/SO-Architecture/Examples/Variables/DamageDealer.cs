using System.Collections;
using System.Collections.Generic;
using SOArchitecture.Variables;
using UnityEngine;

public class DamageDealer : MonoBehaviour {

	public FloatReference HP;

	public FloatReference DamageAmount;
    public FloatReference HealAmount;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
	{
		if(Input.GetKeyDown(KeyCode.D)) {
			HP.ApplyChange(-DamageAmount);
			HP.Value = Mathf.Clamp(HP.Value, 0, 100);
		}

		if(Input.GetKeyDown(KeyCode.H)) {
			HP.ApplyChange(HealAmount);
			HP.Value = Mathf.Clamp(HP.Value, 0, 100);
		}
	}
}
