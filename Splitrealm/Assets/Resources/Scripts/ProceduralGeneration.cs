using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public int[,] tiles;

    public ProceduralGeneration(int width, int height)
    {
        mapWidth = width;
        mapHeight = height;

        for(int i = 0; i < width; i++)
        {
            for(int o = 0; o < height; o++)
            {

            }
        }
    }

    public int FetchRandomTile()
    {
        // Do fetch stuff
        
        return mapWidth;
    }
}
