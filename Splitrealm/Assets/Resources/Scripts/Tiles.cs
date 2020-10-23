using UnityEngine;

public class Tiles : ScriptableObject
{
	public int id = 0;
	public bool buildable = false;
	public bool isDecorated = false;
	public float movementFactor = 0f;
	public float attackFactor = 0f;
	public float defenceFactor = 0f;
	public string tileName = "New Tile";
	public Sprite sprite = null;
}