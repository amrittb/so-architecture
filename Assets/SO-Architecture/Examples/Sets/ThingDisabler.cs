using UnityEngine;

public class ThingDisabler : MonoBehaviour {

    public ThingSet set;

    public void Toggle() {
        foreach(Thing t in set.Items) {
            Renderer r = t.gameObject.GetComponent<Renderer>();
            r.enabled = !r.enabled;
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.T)) {
            Toggle();
        }
    }
}
