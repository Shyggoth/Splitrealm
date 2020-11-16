using UnityEngine;

[CreateAssetMenu]
public class UnitData : ScriptableObject
{
	public int id = 0;
	public int health = 100;
	public int movementBase = 1;
	public int attackBase = 1;
	public int defenceBase = 1;
	public int armor = 1;
	public string unitName = "New Unit";
	public string faction = "Dark";
	public Sprite unitSprite;
	int _currentHealth;
}