using UnityEngine;

[CreateAssetMenu]
public class HeroData : ScriptableObject
{
	public int id = 0;
	public int attack = 1;
	public int defence = 1;
	public int movement = 1;
	public int army = 0;
	public string heroName = "New hero";
	public string factiuon = "Dark";
	public Sprite heroSprite;
}