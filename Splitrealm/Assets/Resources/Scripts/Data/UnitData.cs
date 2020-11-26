using UnityEngine;

namespace Splitrealm
{
	[CreateAssetMenu]
	public class UnitData : ScriptableObject
	{
		public int health = 100;
		public int movementBase = 1;
		public int attackBase = 1;
		public int defenceBase = 1;
		public int armor = 1;
		public int amount = 10;
		public string unitName = "New Unit";
		public string faction = "Faction";
		public string type = "Type";
		public Sprite unitSprite;
		int _currentHealth;
	}
}