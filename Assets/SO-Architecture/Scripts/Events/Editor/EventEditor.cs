using UnityEditor;
using UnityEngine;

namespace SOArchitecture.Events {

    [CustomEditor(typeof(BaseEvent), true)]
    public class EventEditor : Editor {

        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            BaseEvent eventVar = target as BaseEvent;

            if (GUILayout.Button("Raise"))
                eventVar.Raise();
        }
    }
}

