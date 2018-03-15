﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public string PlayerName;
	public Color Color;

	// Use this for initialization
	void Awake ()
	{
		Color = Random.ColorHSV();
        PlayerName = gameObject.name;
	}	
}
