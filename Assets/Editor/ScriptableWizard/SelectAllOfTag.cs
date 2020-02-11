using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 脚本向导
/// </summary>
public class SelectAllOfTag : ScriptableWizard
{
    public string searchTag = "Your tag here";

    [MenuItem("ScriptalbeWizard/Select All Of Tag")]
    static void SelectAllOfTagWizard() {
        ScriptableWizard.DisplayWizard<SelectAllOfTag>("Select All Of Tag", "Make Selection"); 
    }

    void OnWizardCreate() {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(searchTag);
        Selection.objects = gameObjects;
    }
}
