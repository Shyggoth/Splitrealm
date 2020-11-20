using UnityEngine;
using UnityEngine.Tilemaps;

namespace Splitrealm
{
	[CreateAssetMenu]
	public class TileData : ScriptableObject
	{
		public TileBase[] tiles;
		public int id = 0;
		public bool buildable = true;
		public bool isDecorated = false;
		public float movementFactor = 1f;
		public float attackFactor = 1f;
		public float defenceFactor = 1f;
	}
}