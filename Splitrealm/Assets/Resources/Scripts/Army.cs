using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Army : MonoBehaviour
{
	public Dictionary<UnitData, int> armyComposition = new Dictionary<UnitData, int>();
	public HeroData leadingHero;
	public GameObject armyPrefab;
	public List<UnitData> units = new List<UnitData>();
	public List<int> amounts = new List<int>();
	public PlayerContainer player;
	public int finalMovement;
	public Tilemap tileMap;

	void Start()
	{
		foreach(var unit in units)
		{
			armyComposition.Add(unit, 0);
		}

		for(int i = 0; i < armyComposition.Count; i++)
		{
			armyComposition[units[i]] = amounts[i];
		}
	}

	public int CalculateMovement(float terrainFactor, int unitBaseValue, int heroModifier)
	{
		finalMovement = unitBaseValue * (int)terrainFactor * heroModifier;

		return finalMovement;
	}

	public void Pathfinding()
	{

	}

	public void Move(int amountOfTiles)
	{

	}

	public void Attack()
	{

	}

	public void Defend()
	{

	}
}