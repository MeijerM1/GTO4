using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	public int xPos;
    public int yPos;

	private Color _color;

	public void Start()
	{
		_color = GetComponent<Renderer>().material.color;
	}
	
	public void Highlight(bool enable)
	{
		if (enable)
		{
			GetComponent<Renderer>().material.color = Color.blue;			
		}
		else
		{
			GetComponent<Renderer>().material.color = _color;					
		}		
	}
}
