using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string PlayerName;
	public Color color;

	// Use this for initialization
	void Awake ()
	{
		color = Random.ColorHSV();
        PlayerName = gameObject.name;
	}	
}
