using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelector : MonoBehaviour {

	private Player _player;

	public List<Unit> _units;
	
	void Start ()
	{
		_units  = new List<Unit>();
		_player = GetComponent<Player>();
	}
	
	void Update () {
		if (!Input.GetMouseButtonDown(0)) return;
		
		RaycastHit hit; 
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (!Physics.Raycast(ray, out hit)) return;
		
		Unit unit = hit.transform.GetComponent<Unit>();

		if (unit == null || unit.player != _player) return;
				
		if (!_units.Contains(unit))
		{
			unit.Select();
			_units.Add(unit);									
		}
		else
		{
			unit.Deselect();
			_units.Remove(unit);
		}
	}
}
