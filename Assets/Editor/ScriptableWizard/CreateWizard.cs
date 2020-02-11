using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateWizard : ScriptableWizard
{
    public Texture2D portraitTexture;
    public Color color = Color.white;
    public string nickname = "Default Name";

    [MenuItem("ScriptalbeWizard/CreateCharacter")]
    static void CreatekCharacterWizard() {
        ScriptableWizard.DisplayWizard<CreateWizard>("Create Character", "Create new", "Update Selected");
    }

    void OnWizardCreate() {
        GameObject characterGO = new GameObject();
        Character characterComponent = characterGO.AddComponent<Character>();
        characterComponent.portrait = portraitTexture;
        characterComponent.nickname = nickname;
        characterComponent.color = color;
    }

    void OnWizardOtherButton() {
        if (Selection.activeTransform != null) {
            Character characterComponent = Selection.activeTransform.GetComponent<Character>();
            if (characterComponent != null) {
                characterComponent.portrait = portraitTexture;
                characterComponent.nickname = nickname;
                characterComponent.color = color;
            }
        }
    }

    void OnWizardUpdate() {
        helpString = "Enter character details";
    }

}
