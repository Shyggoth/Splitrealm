using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
    public string tileName;
    public string tooltipName;
    public string tooltipDescription;
    public float movementCost;
    public int id;

    public TileBehaviour(int ID, string tpName, string tpDesc, string name, float mvmtCost)
    {
        id                  = ID;
        tooltipName         = tpName;
        tooltipDescription  = tpDesc;
        movementCost        = mvmtCost;
        tileName            = name;
    }

    public float MovementPenalty(float baseMovement)
    {
        float actualMovement =movementCost * baseMovement;
        return actualMovement;
    }

    public bool DetectIfOccupied()
    {
        // Check if an army is on this tile
        bool stuff = false;
        return stuff;
    }

    public bool IsBuiltUpon()
    {
        // Check if a building is built on this tile

        bool stuff = false;
        return stuff;
    }
}
