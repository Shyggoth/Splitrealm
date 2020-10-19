using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProzeduralGeneration : MonoBehaviour
{
    [SerializeField]
    int _width;
    [SerializeField]
    int _height;
    [SerializeField]
    TileDatabase tDB;

    public List<Tiles> tiles = new List<Tiles>();

    void Start()
    {
        GenerateBaseMap(_width, _height);
        Decorate();
        PlacePOIs();
        SetSpawnpoints();
    }

    void GenerateBaseMap(int width, int height)
    {

    }

    void Decorate()
    {

    }

    void SetSpawnpoints()
    {

    }

    void PlacePOIs()
    {

    }


}
