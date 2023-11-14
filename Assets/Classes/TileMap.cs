using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class TileMap
{
    public GameObject ParentPanel;
    private Vector2 GridSize; // npr pri sahu: Vector2(8, 8)
    private List<Tile> Tiles = new List<Tile>();

    public TileMap(GameObject parentCanvas, Vector2 gridSize)
    {
        ParentPanel = parentCanvas;
        GridSize = gridSize;

        Vector2 buttonSize = new Vector2(ParentPanel.GetComponent<RectTransform>().rect.width / GridSize.x, ParentPanel.GetComponent<RectTransform>().rect.height / gridSize.y);
        for (int y = 0; y < GridSize.y; y++)
        {
            for (int x = 0; x < GridSize.x; x++)
            {
                Tiles.Add(new Tile(x, y, createTileUI(buttonSize, x, y)));
            }
        }
    }
    
    public List<Tile> GetTiles()
    {
        return Tiles;
    }

    private GameObject createTileUI(Vector2 buttonSize, int x, int y)
    {
        GameObject tile = new GameObject("Tile " + x.ToString() + ", " + y.ToString());
        RectTransform buttonRectTransform = tile.AddComponent<RectTransform>();
        buttonRectTransform.SetParent(ParentPanel.transform);

        Vector2 buttonPosition = new Vector2(x * buttonSize.x, -y * buttonSize.y);
        buttonRectTransform.pivot = Vector2.up;
        buttonRectTransform.anchorMin = Vector2.up;
        buttonRectTransform.anchorMax = Vector2.up;
        buttonRectTransform.localScale = Vector2.one;
        buttonRectTransform.anchoredPosition = buttonPosition;
        buttonRectTransform.sizeDelta = buttonSize;

        tile.AddComponent<Button>();

        Image decal = tile.AddComponent<Image>();
        decal.color = new Color(0, 0, 0, 0.8f);
  
        return tile;
    }
}




