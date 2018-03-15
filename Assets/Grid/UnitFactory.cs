using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Unit prototype;
    public Map map;
    public Player player;

    public List<ResourceCosts> costs = new List<ResourceCosts>();

    public int x;
    public int y;

    public void SpawnUnit()
    {

        foreach (var cost in costs)
        {
            if (!cost.CanAfford())
            {
                Debug.Log("You be broke boy");
                return;
            }
        }

        Unit newUnit = Instantiate(prototype);

        Cell cell = map.GetRandomEmptyCell();

        newUnit.transform.SetParent(cell.transform, false);
        newUnit.player = player;
        newUnit.GetComponent<Renderer>().material.color = player.Color;

        foreach (var cost in costs)
        {
            cost.Pay();
        }
    }
}

[System.Serializable]
public class ResourceCosts
{
    public Resource Resource;
    public int Costs;

    public bool CanAfford()
    {
        return Resource.CanAfford(Costs);
    }

    public void Pay()
    {
        Resource.RemoveAmount(Costs);
    }
}
