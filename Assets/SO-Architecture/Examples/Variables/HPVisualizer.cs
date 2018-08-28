using System.Collections;
using System.Collections.Generic;
using SOArchitecture.Variables;
using UnityEngine;

public class HPVisualizer : MonoBehaviour {

	public FloatReference HP;

	public Color HealthyColor = Color.green;
	public Color DamagedColor = Color.red;

    private MeshRenderer meshRenderer;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
	{
		meshRenderer = GetComponent<MeshRenderer>();
	}

	void Update() {
		meshRenderer.sharedMaterial.color = Color.Lerp(DamagedColor, HealthyColor, HP / 100f);
	}
}
