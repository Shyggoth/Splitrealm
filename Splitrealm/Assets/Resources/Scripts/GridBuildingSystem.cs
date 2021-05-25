using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBuildingSystem : MonoBehaviour
{
    GridXZ<GridObject> grid;

	void Awake()
	{
		int gridWitdth = 20;
		int gridHeight = 20;
		float cellSize = 10F;
		grid = new GridXZ<GridObject>(gridWitdth, gridHeight, cellSize, Vector3.zero, (GridXZ<GridObject> g, int x, int t) => new GridObject(g, x, z));
	}

	public class GridObject
	{
		GridXZ<GridObject> grid;
		int x;
		int z;

		public GridObject(GridXZ<GridObject> grid, int x, int z)
		{
			this.grid = grid;
			this.x = x;
			this.z = z;
		}
	}
}
