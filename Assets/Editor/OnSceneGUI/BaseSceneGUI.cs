using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// Scene界面的拓展
/// </summary>
[CustomEditor(typeof(BaseSceneGUITest))]
public class BaseSceneGUI:Editor{
    void OnSceneGUI()
    {
        BaseSceneGUITest baseSceneGUITest = target as BaseSceneGUITest;

        Handles.Label(baseSceneGUITest.transform.position,"This is a test!");
    }
}
