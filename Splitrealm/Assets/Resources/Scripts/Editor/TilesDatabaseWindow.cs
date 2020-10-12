using UnityEditor;
using UnityEngine;

public class TilesDatabaseWindow : EditorWindow
{
    [MenuItem("Window/Databases/TilesDatabase")]
    public static void ShowWindow()
    {
        GetWindow<TilesDatabaseWindow>("TilesDatabase");
    }

    void OnGUI()
    {
        // GUI, GUILayout and EditorGUI, EditorGUILayout
        GUILayout.Label("This is a label", EditorStyles.boldLabel);
        EditorGUILayout.TextField("");

    }
}
