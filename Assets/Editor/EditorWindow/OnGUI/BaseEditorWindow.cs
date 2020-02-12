using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 自定义EditorWindow的GUI显示方法，调用时机：EditorWindow界面重绘时系统自动调用
/// </summary>
public class BaseEditorWindow : EditorWindow
{
    [MenuItem("EditorWindow/BaseEditorWindow")]
    static void Open()
    {
        BaseEditorWindow baseEditorWindow = GetWindow<BaseEditorWindow>();
        baseEditorWindow.Show();
    }

    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("This is a editorwindow test");
        EditorGUILayout.EndHorizontal();
    }
}
