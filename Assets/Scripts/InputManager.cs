using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	private bool select; 
	private bool selectDown;
	private bool selectUp;
	private bool direct;
	private bool directDown;
	private bool directUp;
	// Use this for initialization
	void Start () {
		select = false;
		selectUp = false;
		selectDown = false;
		direct = false;
		directDown = false;
		directUp = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			if (!select) {
				selectDown = true;
			}
			else {
				selectDown = false;
			}
			select = true;
			selectUp = false;
		}
		else {
			if (select) {
				selectUp = true;
			}
			else {
				selectUp = false;
			}
			select = false;
			selectDown = false;
		}
		if (Input.GetMouseButton(1)) {
			if (!direct) {
				directDown = true;
			}
			else {
				directDown = false;
			}
			direct = true;
			directUp = false;
		}
		else {
			if (direct) {
				directUp = true;
			}
			else {
				directUp = false;
			}
			direct = false;
			directDown = false;
		}
	}
	
	public bool getSelect() {
		return select;
	}
	public bool getSelectDown() {
		return selectDown;
	}
	public bool getSelectUp() {
		return selectUp;
	}
	public bool getDirect() {
		return direct;
	}
	public bool getDirectDown() {
		return directDown;
	}
	public bool getDirectUp() {
		return directUp;
	}
}
