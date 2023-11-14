using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tile
{
    public int X {get; }
    public int Y { get; }

    //public bool Selected { get; set; } = false;

    public GameObject TileObjectUI;
    //Plant plant;

    public Tile(int x, int y, GameObject tileObjectUI)
    {
        X = x;
        Y = y;
        this.TileObjectUI = tileObjectUI;
        tileObjectUI.GetComponent<Button>().onClick.AddListener(OnClick);
        tileObjectUI.AddComponent<HoverEffect>();
    }

    private void OnClick()  // ko je tile clicked
    {
        Debug.Log(TileObjectUI.name);
    }
}
