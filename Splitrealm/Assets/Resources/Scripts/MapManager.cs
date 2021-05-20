using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
    public class MapManager : MonoBehaviour
    {
        public List<TileData> tileDatas;
        public Tilemap terrainTileMap, fogTileMap, Decorations;
        public Dictionary<TileBase, TileData> dataFromTiles;

        void Awake()
        {
            dataFromTiles = new Dictionary<TileBase, TileData>();

            foreach(var tileData in tileDatas)
                foreach(var tile in tileData.tiles)
                    dataFromTiles.Add(tile, tileData);
        }

        void Start()
        {
            terrainTileMap = GameObject.Find("Terrain/Terrain Map").GetComponent<Tilemap>();
            fogTileMap = GameObject.Find("Terrain/Fog").GetComponent<Tilemap>();
            Decorations = GameObject.Find("Terrain/Decorations").GetComponent<Tilemap>();
        }

        public float GetMovementFactor(Vector2 worldPosition)
        {
            Vector3Int gridPosition = terrainTileMap.WorldToCell(worldPosition);
            TileBase tile = terrainTileMap.GetTile(gridPosition);

            if(tile == null)
                return 0f;

            float movementFactor = dataFromTiles[tile].movementFactor;
            return movementFactor;
        }

        public float GetAttackFactor(Vector2 worldPosition)
        {
            Vector3Int gridPosition = terrainTileMap.WorldToCell(worldPosition);
            TileBase tile = terrainTileMap.GetTile(gridPosition);

            if(tile == null)
                return 0f;

            float attackFactor = dataFromTiles[tile].attackFactor;
            return attackFactor;
        }

        public float GetDefenceFactor(Vector2 worldPosition)
        {
            Vector3Int gridPosition = terrainTileMap.WorldToCell(worldPosition);
            TileBase tile = terrainTileMap.GetTile(gridPosition);

            if(tile == null)
                return 0f;

            float defenceFactor = dataFromTiles[tile].defenceFactor;
            return defenceFactor;
        }

        public bool GetBuildability(Vector2 worldPosition)
        {
            Vector3Int gridPosition = terrainTileMap.WorldToCell(worldPosition);
            TileBase tile = terrainTileMap.GetTile(gridPosition);

            if(tile == null)
                return false;

            bool buildable = dataFromTiles[tile].buildable;
            return buildable;
        }

        public bool GetDecorated(Vector2 worldPosition)
        {
            Vector3Int gridPosition = terrainTileMap.WorldToCell(worldPosition);
            TileBase tile = terrainTileMap.GetTile(gridPosition);

            if(tile == null)
                return false;

            bool isDecorated = dataFromTiles[tile].isDecorated;
            return isDecorated;
        }
    }
}