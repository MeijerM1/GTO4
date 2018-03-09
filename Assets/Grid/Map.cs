using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int sizeX;
    public int sizeY;

    public float tileOffset;

    public Cell prototype;

    //public List<Cell> cells;

    public void Start()
    {
        spawn();
    }

    public void spawn()
    {
        float offsetX = 0;
        for (int i = 0; i < sizeX; i++)
        {
            float offsetY = 0;
            for (int j = 0; j < sizeY; j++)
            {
                Cell newCell = Instantiate(prototype);
                newCell.transform.SetParent(transform);
                newCell.transform.localPosition = new Vector3(offsetX, 0, offsetY);

                newCell.name = "Cell: " + i + "," + j;

                newCell.xPos = i;
                newCell.yPos = j;

                offsetY += tileOffset;
            }

            offsetX += tileOffset;
        }
    }

    public Cell GetCell(int x,int y)
    {
        return transform.GetChild((x * sizeY) + y).GetComponent<Cell>();
    }
}
