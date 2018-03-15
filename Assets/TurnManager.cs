using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    List<Player> players = new List<Player>();
    int activePlayer = 0;

    private void Start()
    {
        foreach(Transform child in transform)
        {
            players.Add(child.GetComponent<Player>());
        }

        SetActivePlayer();
    }


    public void EndTurn()
    {
        if (activePlayer == players.Count - 1)
        {
            activePlayer = 0;
        }
        else
        {
            activePlayer++;            
        }
        SetActivePlayer();
    }

    private void SetActivePlayer()
    {        
        for (int i = 0; i < players.Count; i++)
        {
            if (i == activePlayer)
            {
                players[i].gameObject.SetActive(true);
            }
            else
            {
                players[i].gameObject.SetActive(false);                
            }
        }  
    }
}
