using System.Collections.Generic;

using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;
[CustomEditor(typeof(InputActionCallbackGameEvent), editorForChildClasses: true)]
public class InputEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();


        InputActionCallbackGameEvent e = target as InputActionCallbackGameEvent;
        GUI.enabled = Application.isPlaying;
        if (GUILayout.Button("Raise"))
            e.Invoke(new InputAction.CallbackContext());
    }
}
