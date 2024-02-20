using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDestroyer : MonoBehaviour
{
    private Tilemap tilemap;
    private Vector3 mousePos;
    private Vector3Int tilePos;

    [SerializeField] GridLayout grid;

    void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tilePos = grid.WorldToCell(mousePos);
        if(Input.GetMouseButtonDown(0))
        {
            tilemap.SetTile(tilePos, null);
        }
    }

}
