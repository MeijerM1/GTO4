using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Unit prototype;
    public Map map;

    public Resource resource;
    public int costs;

    public int x;
    public int y;

    public void SpawnUnit()
    {

        if (!resource.CanAfford(costs))
        {
            Debug.Log("You be broke boy");
            return;
        }

        Unit newUnit = Instantiate(prototype);

        Cell cell = map.GetCell(x, y);

        newUnit.transform.SetParent(cell.transform, false);

        resource.RemoveAmount(costs);
    }
}
