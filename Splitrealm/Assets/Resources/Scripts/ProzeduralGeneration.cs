using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
    public class ProzeduralGeneration : MonoBehaviour
    {
        public int _width;
        public int _height;
        public MapManager mapManager;
        public List<Tile> tiles = new List<Tile>();

        void Start()
        {
            GenerateBaseMap(_width, _height);
            Decorate();
            PlacePOIs();
            SetSpawnpoints();
        }

        void GenerateBaseMap(int width, int height)
        {
            for(int i = 0; i < width; i++)
                for(int e = 0; e < height; e++)
                {
                    Vector3Int tmp = new Vector3Int(i, e, 0);
                    mapManager.terrainTileMap.SetTile(tmp, tiles[Random.Range(0, tiles.Count)]);
                }
        }

        void Decorate()
        {

        }

        void SetSpawnpoints()
        {

        }

        void PlacePOIs()
        {

        }
    }
}