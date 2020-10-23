using UnityEngine;
using UnityEditor;

public class CreateTileDB
{
    [MenuItem("Assets/Create/Tile DB")]
    public static TileDatabase Create()
    {
        TileDatabase asset = ScriptableObject.CreateInstance<TileDatabase>();
        AssetDatabase.CreateAsset(asset, "Assets/TileDatabase.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
}
