using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Ownable {

    public void Select()
    {
        Cell cell = gameObject.GetComponentInParent<Cell>();
        
        cell.Highlight(true);
    }

    public void Deselect()
    {
        Cell cell = gameObject.GetComponentInParent<Cell>();
        
        cell.Highlight(false);
        
    }
}
