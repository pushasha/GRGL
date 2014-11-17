﻿using UnityEngine;
using System.Collections;

public class InterfaceBehavior: MonoBehaviour {

	private GameObject _guiInventory;
	private GameObject _windowGroup;

	// Use this for initialization
	void Start () {
		// init references
		_guiInventory = GameObject.Find("GuiInventory");


		// disable windows for now
		_windowGroup = GameObject.Find("Windows");
		ToggleGroupActive(_windowGroup);


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Inventory")){
			ToggleElementActive(_guiInventory);
		}
	}


	// helper functions 
	void ToggleElementActive(GameObject element){
		element.SetActive(!element.activeSelf);
	}

	void ToggleGroupActive (GameObject group){
		foreach (Transform child in group.transform){
			ToggleElementActive(child.gameObject);
		}
	}

}
