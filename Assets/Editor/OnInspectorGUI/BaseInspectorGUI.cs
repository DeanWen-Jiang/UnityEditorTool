using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// Inspector编辑器扩展
/// </summary>
[CustomEditor(typeof(BaseInspectorGUITest))]
public class BaseInspectorGUI : Editor
{
    private BaseInspectorGUITest baseTest;

    private void OnEnable()
    {
        baseTest = target as BaseInspectorGUITest;
    }

    public override void OnInspectorGUI() {
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label(baseTest.Value);
        EditorGUILayout.EndHorizontal();
    }
}
