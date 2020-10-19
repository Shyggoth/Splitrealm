using UnityEngine;

[CreateAssetMenu(fileName = "Tile", menuName = "Tools/Tiles")]
public class Tiles : ScriptableObject
{
	public int id;
	public bool buildable;
	public bool isDecoratied;
	public float movementFactor;
	public float attackFactor;
	public float defenceFactor;
	public string tileName;
	public Sprite sprite;

	public void ToggleBuildable()
    {
		buildable = !buildable;
    }

	public void ToggleDecorated()
	{
		isDecoratied = !isDecoratied;
	}
}