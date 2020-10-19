using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour
{
    public static TileDatabase Instance { get; set; }
    [SerializeField]
    public List<Tiles> Tiles = new List<Tiles>();

    private void Start()
    {
        if(Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;

    }

    public List<Tiles> GetTileList()
    {
        return Tiles;
    }

    public Tiles GetRandomTile(int amount)
    {

        return null;
    }
}