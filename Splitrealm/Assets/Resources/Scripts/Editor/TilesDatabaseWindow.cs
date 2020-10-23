using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class TilesDatabaseWindow : EditorWindow
{
    public TileDatabase tileDatabase;
    private int viewIndex = 1;

    [MenuItem("Window/Tile Database Editor %#e")]
    static void Init()
    {
        GetWindow(typeof(TilesDatabaseWindow));
    }

    void OnEnable()
    {
        if (EditorPrefs.HasKey("ObjectPath"))
        {
            string objectPath = EditorPrefs.GetString("ObjectPath");
            tileDatabase = AssetDatabase.LoadAssetAtPath(objectPath, typeof(TileDatabase)) as TileDatabase;
        }

    }

    void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("Tile DB Editor", EditorStyles.boldLabel);

        if (tileDatabase != null)
            if (GUILayout.Button("Show Tile List"))
            {
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = tileDatabase;
            }

        if (GUILayout.Button("Open Tile List"))
            OpenTileList();

        if (GUILayout.Button("New Tile List"))
        {
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = tileDatabase;
        }

        GUILayout.EndHorizontal();

        if (tileDatabase == null)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Space(10);

            if (GUILayout.Button("Create New Tile List", GUILayout.ExpandWidth(false)))
                CreateNewTileList();

            if (GUILayout.Button("Open Existing Tile List", GUILayout.ExpandWidth(false)))
                OpenTileList();

            GUILayout.EndHorizontal();
        }

        GUILayout.Space(20);

        if (tileDatabase != null)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Space(10);

            if (GUILayout.Button("Prev", GUILayout.ExpandWidth(false)))
                if (viewIndex > 1)
                    viewIndex--;

            GUILayout.Space(5);

            if (GUILayout.Button("Next", GUILayout.ExpandWidth(false)))
                if (viewIndex < tileDatabase.tileDB.Count)
                    viewIndex++;

            GUILayout.Space(60);

            if (GUILayout.Button("Add Tile", GUILayout.ExpandWidth(false)))
                AddTile();

            if (GUILayout.Button("Delete Tile", GUILayout.ExpandWidth(false)))
                DeleteTile(viewIndex - 1);

            GUILayout.EndHorizontal();

            if (tileDatabase.tileDB == null)
                Debug.Log("Tile DB is empty");

            if (tileDatabase.tileDB.Count > 0)
            {
                GUILayout.BeginHorizontal();
                viewIndex = Mathf.Clamp(EditorGUILayout.IntField("Current Tile", viewIndex, GUILayout.ExpandWidth(false)), 1, tileDatabase.tileDB.Count);
                //Mathf.Clamp (viewIndex, 1, inventoryItemList.itemList.Count);
                EditorGUILayout.LabelField("of   " + tileDatabase.tileDB.Count.ToString() + "  tiles", "", GUILayout.ExpandWidth(false));
                GUILayout.EndHorizontal();
                tileDatabase.tileDB[viewIndex - 1].tileName = EditorGUILayout.TextField("Tile Name", tileDatabase.tileDB[viewIndex - 1].tileName as string);
                tileDatabase.tileDB[viewIndex - 1].sprite = EditorGUILayout.ObjectField("Tile Sprite", tileDatabase.tileDB[viewIndex - 1].sprite, typeof(Sprite), false) as Sprite;
            //  tileDatabase.tileDB[viewIndex - 1].itemObject = EditorGUILayout.ObjectField("Item Object", tileDatabase.tileDB[viewIndex - 1].itemObject, typeof(Rigidbody), false) as Rigidbody;
                GUILayout.Space(10);
                GUILayout.BeginHorizontal();
                tileDatabase.tileDB[viewIndex - 1].buildable = (bool)EditorGUILayout.Toggle("Buildable", tileDatabase.tileDB[viewIndex - 1].buildable, GUILayout.ExpandWidth(false));
                tileDatabase.tileDB[viewIndex - 1].isDecorated = (bool)EditorGUILayout.Toggle("Decorated", tileDatabase.tileDB[viewIndex - 1].isDecorated, GUILayout.ExpandWidth(false));
            // tileDatabase.tileDB[viewIndex - 1].isQuestItem = (bool)EditorGUILayout.Toggle("QuestItem", tileDatabase.tileDB[viewIndex - 1].isQuestItem, GUILayout.ExpandWidth(false));
                GUILayout.EndHorizontal();
                GUILayout.Space(10);
            //    GUILayout.BeginHorizontal();
            //   tileDatabase.tileDB[viewIndex - 1].isStackable = (bool)EditorGUILayout.Toggle("Stackable ", tileDatabase.tileDB[viewIndex - 1].isStackable, GUILayout.ExpandWidth(false));
            //   tileDatabase.tileDB[viewIndex - 1].destroyOnUse = (bool)EditorGUILayout.Toggle("Destroy On Use", tileDatabase.tileDB[viewIndex - 1].destroyOnUse, GUILayout.ExpandWidth(false));
            //    tileDatabase.tileDB[viewIndex - 1].encumbranceValue = EditorGUILayout.FloatField("Encumberance", tileDatabase.tileDB[viewIndex - 1].encumbranceValue, GUILayout.ExpandWidth(false));
            //    GUILayout.EndHorizontal();
                GUILayout.Space(10);
            }
            else
                GUILayout.Label("This Tile DB is Empty.");
        }

        if (GUI.changed)
            EditorUtility.SetDirty(tileDatabase);
    }

    void CreateNewTileList()
    {
        viewIndex = 1;
        tileDatabase = CreateTileDB.Create();

        if (tileDatabase)
        {
            tileDatabase.tileDB = new List<Tiles>();
            string relPath = AssetDatabase.GetAssetPath(tileDatabase);
            EditorPrefs.SetString("ObjectPath", relPath);
        }
    }

    void OpenTileList()
    {
        string absPath = EditorUtility.OpenFilePanel("Select Tile List", "", "");

        if (absPath.StartsWith(Application.dataPath))
        {
            string relPath = absPath.Substring(Application.dataPath.Length - "Assets".Length);
            tileDatabase = AssetDatabase.LoadAssetAtPath(relPath, typeof(TileDatabase)) as TileDatabase;

            if (tileDatabase.tileDB == null)
                tileDatabase.tileDB = new List<Tiles>();
            
            if (tileDatabase)
                EditorPrefs.SetString("ObjectPath", relPath);
        }
    }

    void AddTile()
    {
        Tiles newTile = new Tiles();
        newTile.tileName = "New Tile";
        tileDatabase.tileDB.Add(newTile);
        viewIndex = tileDatabase.tileDB.Count;
    }

    void DeleteTile(int index)
    {
        tileDatabase.tileDB.RemoveAt(index);
    }
}