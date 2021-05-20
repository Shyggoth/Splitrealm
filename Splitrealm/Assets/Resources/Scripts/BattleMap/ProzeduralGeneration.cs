using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
    public class ProzeduralGeneration : MonoBehaviour
    {
        public int _width;
        public int _height;
        public GameObject spawner;
        public MapManager mapManager;
        public TileBase lightSpawn;
        public TileBase darkSpawn;
        public List<Tile> tiles = new List<Tile>();

        void Start()
        {
           // mapManager = GameObject.Find("MapManager").GetComponent<MapManager>();
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
            Vector3Int tmp = new Vector3Int(2, 5, 0);
            mapManager.Decorations.SetTile(tmp, lightSpawn);
            Vector3 cellPosition = mapManager.Decorations.GetCellCenterLocal(tmp);
            GameObject lightSpawner = Instantiate(spawner, cellPosition, Quaternion.identity);
            lightSpawner.name = "Light Spawner";
            tmp = mapManager.fogTileMap.WorldToCell(cellPosition);
            ClearFog(tmp);
            tmp = new Vector3Int(33, 5, 0);
            mapManager.Decorations.SetTile(tmp, darkSpawn);
            cellPosition = mapManager.Decorations.GetCellCenterLocal(tmp);
            lightSpawner = Instantiate(spawner, cellPosition, Quaternion.identity);
            lightSpawner.name = "Dark Spawner";
            tmp = mapManager.fogTileMap.WorldToCell(cellPosition);
            ClearFog(tmp);
        }

        void PlacePOIs()
        {

        }

        public void ClearFog(Vector3Int tmp)
        {
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    mapManager.fogTileMap.SetTile(tmp + new Vector3Int(x, y, 0), null);
                }
            }
        }
    }
}