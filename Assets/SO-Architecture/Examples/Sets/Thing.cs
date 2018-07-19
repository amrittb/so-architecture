using UnityEngine;

public class Thing : MonoBehaviour {

    public ThingSet set;

    private void OnEnable() {
        set.Add(this);
    }

    private void OnDisable() {
        set.Remove(this);
    }
}
