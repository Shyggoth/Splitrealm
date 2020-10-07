using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDBSplitrealm;

public class DBHanler : MonoBehaviour
{
    void Start()
    {
        GameDB gameDb = new GameDB("MyGameDB");
        List<GameObject> tilesGo = new List<GameObject>();

        gameDb.OnDBLoaded = delegate ()
        {
            var tiles = gameDb.TilesTable.GetByKey("");

            foreach(var tile in gameDb.TilesTable.GetRows())
            {
                tilesGo.Add(tile);
            }
        };

        gameDb.Load("GameDBs/gameDB");
    }

    void LoadAllDBs()
    {

    }

    void LoadDBByName(string dbName)
    {

    }
    
    // FetchTileByID(tileID)

    // FetchRandomTile(amount)

    // FetchDecorationByID(decorationID)

    // FetchRandomDecoration(amount)

    // FetchUnitByID(unitID)

    // FetchUnitByName(unitName)

    // FetchStructureByID(structureID)

    // FetchStructureByName(strucctureName)

    // FetchHeroByName(heroName)

    // FetchHeroByID(heroID)
}
