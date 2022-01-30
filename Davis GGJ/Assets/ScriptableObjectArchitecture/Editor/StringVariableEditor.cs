using UnityEditor;
using UnityEngine;

//Is there any way to get this to work with GenericReference?

[CustomEditor(typeof(StringVariable))]
public class StringVariableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        StringVariable stringVariable = (StringVariable)target;


        GUILayout.BeginHorizontal();
        GUILayout.Label("ValueMultiline", GUILayout.Width(Screen.width * 0.351f));
        stringVariable.Value = GUILayout.TextArea(stringVariable.Value, EditorStyles.textArea);
        GUILayout.EndHorizontal();
        EditorUtility.SetDirty(stringVariable);
        Undo.RecordObject(stringVariable,"valuechange");
    }

}