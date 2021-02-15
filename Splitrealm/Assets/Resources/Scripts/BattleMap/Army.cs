using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
	public class Army : MonoBehaviour
	{
		public Dictionary<UnitData, int> armyComposition = new Dictionary<UnitData, int>();
		public HeroData leadingHero;
		public List<UnitData> units = new List<UnitData>();
		public List<int> amounts = new List<int>();
		public Player player;
		public float finalMovement;
		public Tilemap tileMap;

		void Start()
		{
			foreach(var unit in units)
				armyComposition.Add(unit, 0);

			for(int i = 0; i < armyComposition.Count; i++)
				armyComposition[units[i]] = amounts[i];
		}

		public float CalculateMovement(float terrainFactor)
		{
			finalMovement = units[0].movementBase * leadingHero.movementModifier * terrainFactor;
			return finalMovement;
		}

		public void Pathfinding()
		{

		}

		public void Move(int amountOfTiles)
		{

		}
	}
}