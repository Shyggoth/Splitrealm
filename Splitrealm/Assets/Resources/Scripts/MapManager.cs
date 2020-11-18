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
        public Camera cam;

        void Awake()
        {
            dataFromTiles = new Dictionary<TileBase, TileData>();

            foreach(var tileData in tileDatas)
                foreach(var tile in tileData.tiles)
                    dataFromTiles.Add(tile, tileData);
        }

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
                Vector3Int gridPosition = terrainTileMap.WorldToCell(mousePosition);
                TileBase clickedTile = terrainTileMap.GetTile(gridPosition);
                float movement = dataFromTiles[clickedTile].movementFactor;
                float attack = dataFromTiles[clickedTile].attackFactor;
                float defence = dataFromTiles[clickedTile].defenceFactor;
                bool build = dataFromTiles[clickedTile].buildable;
                bool deco = dataFromTiles[clickedTile].isDecorated;
                print("The clicked Tile is at position " + gridPosition + " and it is a " + clickedTile + " Tile.");
                print("It has the following values : Movement " + movement + ", Attack " + attack + ", Defense " + defence + ", Buildable " + build + ", Decorated " + deco);
            }
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