using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour, IEnumerable
{
	public List<PlayerContainer> listOfPlayers = new List<PlayerContainer>();
	public Tilemap tileMap;

	public IEnumerator GetEnumerator()
	{
		throw new System.NotImplementedException();
	}
}
