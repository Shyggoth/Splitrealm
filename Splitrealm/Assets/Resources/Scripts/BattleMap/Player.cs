using Mirror;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
    public class Player : NetworkBehaviour
    {
        // Build structure
        // Get resources
        // Spent resources
        // Destroy structure
        public Color tileColor;
        public string playerName;
        public List<UnitData> ownedUnits;
        public List<Army> ownedArmies;
        public List<HeroData> ownedHeroes;
        public List<Tile> ownedTiles;
        public MapManager mapManager;
        public GameObject armyPrefabLight;
        public GameObject armyPrefabDark;
        public GameObject spawner;
        public GameObject army;
        public GameObject selectedGO;
        public Camera cam;
        public int vision = 1;

        void Start()
        {
            cam = GameObject.Find("Main Camera").GetComponent<Camera>();
            mapManager = GameObject.Find("MapManager").GetComponent<MapManager>();

            if (GameObject.Find("NetworkManager").GetComponent<NetworkManagerSplit>().playerAmount == 1)
            {
                spawner = GameObject.Find("Light Spawner");
                army = Instantiate(armyPrefabLight, transform.position, Quaternion.identity);
            }
            else
            {
                spawner = GameObject.Find("Dark Spawner");
                army = Instantiate(armyPrefabDark, transform.position, Quaternion.identity);
            }

            transform.position = spawner.transform.position;
            army.GetComponent<Army>().player = this;
            selectedGO = army;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && isLocalPlayer)
            {
                Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
                Vector3Int gridPosition = mapManager.terrainTileMap.WorldToCell(mousePosition);
                Vector3 cellPosition = mapManager.terrainTileMap.GetCellCenterLocal(gridPosition);
                //float mov = player.GetComponent<Army>().CalculateMovement(GetMovementFactor(cellPosition));

                SetPosition(cellPosition);
                gridPosition = mapManager.fogTileMap.WorldToCell(cellPosition);
                ClearFog(gridPosition);
            }
        }

        public void SetPosition(Vector3 position)
        {
            selectedGO.transform.position = position;
        }

        public void ClearFog(Vector3Int start)
        {
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    mapManager.fogTileMap.SetTile(start + new Vector3Int(x, y, 0), null);
                }
            }
        }

        public void AddUnit(UnitData unit, int amount)
        {
            for(int i = 0; i < ownedUnits.Count; i++)
                if(ownedUnits[i] == unit)
                    ownedUnits[i].amount += amount;
        }

        public void AddHero(HeroData hero)
        {
            ownedHeroes.Add(hero);
        }

        public void RemoveHero(HeroData hero)
        {
            ownedHeroes.Remove(hero);
        }

        public void AddArmy(Army army)
        {
            ownedArmies.Add(army);
        }

        public void RemoveArmy(Army army)
        {
            ownedArmies.Add(army);
        }

        public void ChangeLeader(Army army, HeroData hero)
        {
            for(int i = 0; i < ownedArmies.Count; i++)
                if(ownedArmies[i] == army)
                    if(ownedArmies[i].leadingHero != hero)
                        ownedArmies[i].leadingHero = hero;
        }

        public void MoveArmy(Army army, int amount)
        {
            for(int i = 0; i < ownedArmies.Count; i++)
                if(ownedArmies[i] == army)
                {
                    army.Pathfinding();
                    army.Move(amount);
                }
        }

        public void ClaimTile(Tilemap tileMap, Vector3Int gridPosition)
        {
            TileBase claimedTile = tileMap.GetTile(gridPosition);
            // Change something to indicate ownership
            // Changing the color of the tile based on your faction
            // mapManager.terrainTileMap.GetTile(gridPosition).
        }

        public void CreateArmy(UnitData unit, int amount)
        {

        }
    }
}