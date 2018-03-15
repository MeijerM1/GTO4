using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUIScript : MonoBehaviour
{

	public Text text;

	// Use this for initialization
	void Start ()
	{
		Player p = GetComponentInParent<Player>();
		text.text = p.PlayerName;

	}
	
}
