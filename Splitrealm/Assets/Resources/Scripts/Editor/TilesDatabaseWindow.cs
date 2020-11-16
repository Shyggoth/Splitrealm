//using UnityEngine;
//using UnityEditor;
//using System.Collections.Generic;

//public class TilesDatabaseWindow : EditorWindow
//{
//    public MapManager tileDatabase;
//    private int viewIndex = 1;

//    [MenuItem("Window/Tile Database Editor %#e")]
//    static void Init()
//    {
//        GetWindow(typeof(TilesDatabaseWindow));
//    }

//    void OnEnable()
//    {
//        if(EditorPrefs.HasKey("ObjectPath"))
//        {
//            string objectPath = EditorPrefs.GetString("ObjectPath");
//            tileDatabase = AssetDatabase.LoadAssetAtPath(objectPath, typeof(MapManager)) as MapManager;
//        }
//    }

//    void OnGUI()
//    {
//        GUILayout.BeginHorizontal();
//        GUILayout.Label("Tile DB Editor", EditorStyles.boldLabel);

//        if(tileDatabase != null)
//            if(GUILayout.Button("Show Tile List"))
//            {
//                EditorUtility.FocusProjectWindow();
//                Selection.activeObject = tileDatabase;
//            }

//        if(GUILayout.Button("Open Tile List"))
//            OpenTileList();

//        if(GUILayout.Button("New Tile List"))
//        {
//            EditorUtility.FocusProjectWindow();
//            Selection.activeObject = tileDatabase;
//        }

//        GUILayout.EndHorizontal();

//        if(tileDatabase == null)
//        {
//            GUILayout.BeginHorizontal();
//            GUILayout.Space(10);

//            if(GUILayout.Button("Create New Tile List", GUILayout.ExpandWidth(false)))
//                CreateNewTileList();

//            if(GUILayout.Button("Open Existing Tile List", GUILayout.ExpandWidth(false)))
//                OpenTileList();

//            GUILayout.EndHorizontal();
//        }

//        GUILayout.Space(10);

//        if(tileDatabase != null)
//        {
//            GUILayout.BeginHorizontal();
//            GUILayout.Space(10);

//            if(GUILayout.Button("Previous", GUILayout.ExpandWidth(false)))
//                if(viewIndex > 1)
//                    viewIndex--;

//            GUILayout.Space(5);

//            if(GUILayout.Button("Next", GUILayout.ExpandWidth(false)))
//                if(viewIndex < tileDatabase.tileDatas.Count)
//                    viewIndex++;

//            GUILayout.Space(10);

//            if(GUILayout.Button("Add Tile", GUILayout.ExpandWidth(false)))
//                AddTile();

//            if(GUILayout.Button("Delete Tile", GUILayout.ExpandWidth(false)))
//                DeleteTile(viewIndex - 1);

//            GUILayout.EndHorizontal();

//            if(tileDatabase.tileDatas == null)
//                Debug.Log("Tile DB is empty");

//            if(tileDatabase.tileDatas.Count > 0)
//            {
//                GUILayout.BeginHorizontal();
//                viewIndex = Mathf.Clamp(EditorGUILayout.IntField("Current Tile", viewIndex, GUILayout.ExpandWidth(false)), 1, tileDatabase.tileDatas.Count);
//                EditorGUILayout.LabelField(" of " + tileDatabase.tileDatas.Count.ToString() + " tiles", "", GUILayout.ExpandWidth(false));
//                GUILayout.EndHorizontal();
//                tileDatabase.tileDatas[viewIndex - 1].id = EditorGUILayout.IntField("ID", tileDatabase.tileDatas[viewIndex - 1].id, GUILayout.ExpandWidth(false));
//                tileDatabase.tileDatas[viewIndex - 1].movementFactor = EditorGUILayout.FloatField("Movement factor", tileDatabase.tileDatas[viewIndex - 1].movementFactor, GUILayout.ExpandWidth(false));
//                tileDatabase.tileDatas[viewIndex - 1].attackFactor = EditorGUILayout.FloatField("Attack factor", tileDatabase.tileDatas[viewIndex - 1].attackFactor, GUILayout.ExpandWidth(false));
//                tileDatabase.tileDatas[viewIndex - 1].defenceFactor = EditorGUILayout.FloatField("Defense factor", tileDatabase.tileDatas[viewIndex - 1].defenceFactor, GUILayout.ExpandWidth(false));
//                tileDatabase.tileDatas[viewIndex - 1].buildable = EditorGUILayout.Toggle("Buildable", tileDatabase.tileDatas[viewIndex - 1].buildable, GUILayout.ExpandWidth(false));
//                tileDatabase.tileDatas[viewIndex - 1].isDecorated = EditorGUILayout.Toggle("Decorated", tileDatabase.tileDatas[viewIndex - 1].isDecorated, GUILayout.ExpandWidth(false));
//            }
//            else
//                GUILayout.Label("This Tile DB is Empty.");
//        }

//        if(GUI.changed)
//            EditorUtility.SetDirty(tileDatabase);
//    }

//    void CreateNewTileList()
//    {
//        viewIndex = 1;
//        tileDatabase = CreateTileDB.Create();

//        if(tileDatabase)
//        {
//            tileDatabase.tileDatas = new List<TileData>();
//            string relPath = AssetDatabase.GetAssetPath(tileDatabase);
//            EditorPrefs.SetString("ObjectPath", relPath);
//        }
//    }

//    void OpenTileList()
//    {
//        string absPath = EditorUtility.OpenFilePanel("Select Tile List", "", "");

//        if(absPath.StartsWith(Application.dataPath))
//        {
//            string relPath = absPath.Substring(Application.dataPath.Length - "Assets".Length);
//            tileDatabase = AssetDatabase.LoadAssetAtPath(relPath, typeof(MapManager)) as MapManager;

//            if(tileDatabase.tileDatas == null)
//                tileDatabase.tileDatas = new List<TileData>();
            
//            if(tileDatabase)
//                EditorPrefs.SetString("ObjectPath", relPath);
//        }
//    }

//    void AddTile()
//    {
//        TileData newTile = new TileData();
//        tileDatabase.tileDatas.Add(newTile);
//        viewIndex = tileDatabase.tileDatas.Count;
//    }

//    void DeleteTile(int index)
//    {
//        tileDatabase.tileDatas.RemoveAt(index);
//    }
//}