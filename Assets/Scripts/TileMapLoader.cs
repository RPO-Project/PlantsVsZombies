using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapLoader : MonoBehaviour
{
    GameObject parentCanvas;
    [SerializeField] Vector2 tileMapGridSize;

    TileMap tileMap;
    
    void Start()
    {
        parentCanvas = gameObject;
        tileMap = new TileMap(parentCanvas, tileMapGridSize);
    }

    void Update()
    {
        
    }
}
