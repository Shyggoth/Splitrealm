using UnityEngine;

namespace Splitrealm
{
	[CreateAssetMenu]
	public class HeroData : ScriptableObject
	{
		public int attackModifier = 1;
		public int defenceModifier = 1;
		public int movementModifier = 1;
		public string heroName = "New hero";
		public string factiuon = "Faction";
		public Sprite heroSprite;
	}
}