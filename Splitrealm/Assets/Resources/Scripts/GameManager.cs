using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
	public List<Player> listOfPlayers = new List<Player>();
	public Tilemap tileMap;
    public Canvas canvas;
    public int timer;

    void Start()
    {
        canvas.GetComponent<Timer>().SetTimer(timer);
    }
}
