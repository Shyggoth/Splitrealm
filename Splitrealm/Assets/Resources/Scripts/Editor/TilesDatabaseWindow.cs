using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TilesDatabaseWindow : EditorWindow
{
    public List<Tiles> tileList;

    bool _groupEnabled;
    bool _testBool;
    float _sliderFloat;
    string _textField;
    Vector2 _position = new Vector2(0f, 0f);
    TileDatabase tDb;

    [MenuItem("Window/Databases/TilesDatabase")]
    public static void ShowWindow()
    {
        GetWindow<TilesDatabaseWindow>("TilesDatabase");
    }

    void OnGUI()
    {
        // GUI, GUILayout and EditorGUI, EditorGUILayout
        GUILayout.Label("This is a label", EditorStyles.boldLabel);
        _textField = EditorGUILayout.TextField("Name", _textField);
        _groupEnabled = EditorGUILayout.BeginToggleGroup("Toggle group", _groupEnabled);
        _testBool = EditorGUILayout.Toggle("Toggle", _testBool);
        _sliderFloat = EditorGUILayout.Slider("Slider", _sliderFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
        EditorGUILayout.BeginScrollView(_position);
        EditorGUILayout.EndScrollView();




        tileList = tDb.GetTileList();
    }
}