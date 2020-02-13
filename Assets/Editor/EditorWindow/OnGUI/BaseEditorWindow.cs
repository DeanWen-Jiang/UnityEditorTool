using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 自定义EditorWindow的GUI显示方法，调用时机：EditorWindow界面重绘时系统自动调用
/// </summary>
public class BaseEditorWindow : EditorWindow
{
    private Vector2 _scroll;

    [MenuItem("EditorWindow/BaseEditorWindow")]
    static void Open()
    {
        BaseEditorWindow baseEditorWindow = GetWindow<BaseEditorWindow>();
        baseEditorWindow.Show();
    }

    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();

        //【GUI】系统可以在发布后使用，也可以在编辑器中使用。
        //GUI.Button(new Rect(0,0,100,30),"Button");
        //GUI.Label(new Rect(100,0,100,30),"Label");
        //GUI.PasswordField(new Rect(0, 30, 100, 30), "Password", '*');
        //GUI.Toggle(new Rect(100,30,100,30),true,"Toggle");

        //【GUILayout】系统可以在发布后使用，也可以在编辑器中使用(带布局)
        //1.水平布局
        GUILayout.BeginHorizontal("Box");//水平布局
        GUILayout.Button("Button");
        GUILayout.Label("Label");
        GUILayout.PasswordField("Password", '*');
        GUILayout.Toggle(true, "");
        GUILayout.FlexibleSpace();        //创建一个自适应的空白区域，也即是填满本次布局中的这部分空间
        GUILayout.EndHorizontal();

        //2.垂直布局
        GUILayout.BeginVertical("Box"); //开始一个垂直布局
        GUILayout.Button("Button");
        GUILayout.Label("Label");
        GUILayout.PasswordField("Password", '$');
        GUILayout.Toggle(true, "");
        GUILayout.EndVertical();        //结束一个垂直布局

        //3.Scroll
        _scroll = GUILayout.BeginScrollView(_scroll);//开始一个滚动视野
        GUILayout.BeginVertical("Box");
        for (int i = 0; i < 5; i++) {
            GUILayout.Button("Button"+i);
        }
        GUILayout.EndVertical();
        GUILayout.EndScrollView();


        //【EditorGUI】系统不可以在发布后使用，只能在编辑器中使用，其拥有部分编辑器专用控件
        EditorGUI.ColorField(new Rect(0,0,100,20),Color.white);
        EditorGUI.DoubleField(new Rect(0,30,30,30),10);
        EditorGUI.ProgressBar(new Rect(0,60,100,30),0.5f,"ProgressBar");

        //【EditorGUILayout】系统不可以在发布后使用，只能在编辑器中使用
        EditorGUILayout.BeginHorizontal("Box");    //开始一个水平布局
        EditorGUILayout.LabelField("LabelField");
        EditorGUILayout.PasswordField("PasswordField");
        EditorGUILayout.RectField(Rect.zero);
        EditorGUILayout.EndHorizontal();           //结束一个水平布局



        EditorGUILayout.EndHorizontal();
    }
}
