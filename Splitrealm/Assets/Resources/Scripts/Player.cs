using UnityEngine;
using Mirror;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using System.Net;

public class Player : NetworkBehaviour
{
    // Build structure
    // Get resources
    // Spent resources
    // Destroy structure
    public string playerName;
    public List<UnitData> ownedUnits;
    public List<Army> ownedArmies;
    public List<HeroData> ownedHeroes;
    public List<Tile> ownedTiles;
    public MapManager mapManager;
    public GameObject armyPrefab;

    void Update()
    {
        
    }

    public void AddUnit(UnitData unit, int amount)
    {
        for(int i = 0; i < ownedUnits.Count; i++)
        {
            if(ownedUnits[i] == unit)
            {
                ownedUnits[i].amount += amount;
            }
        }
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
        {
            if(ownedArmies[i] == army)
            {
                if(ownedArmies[i].leadingHero != hero)
                {
                    ownedArmies[i].leadingHero = hero;
                }
            }
        }
    }

    public void MoveArmy(Army army, int amount)
    {
        for(int i = 0; i < ownedArmies.Count; i++)
        {
            if(ownedArmies[i] == army)
            {
                army.Pathfinding();
                army.Move(amount);
            }
        }
    }

    public void ClaimTile(Tilemap tileMap, Vector3Int gridPosition)
    {
        TileBase claimedTile = tileMap.GetTile(gridPosition);
        // Change something to indicate ownership
    }

    public void CreateArmy(UnitData unit, int amount)
    {

    }
}