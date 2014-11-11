using UnityEngine;
using System.Collections;

public class InterfaceBehaviorScript : MonoBehaviour {

	private GameObject _guiInventory, _guiDialog;
	private GameObject _windowGroup;

	// Use this for initialization
	void Start () {
		// init references
		_guiInventory = GameObject.Find("GuiInventory");
		_guiDialog = GameObject.Find("GuiDialog");


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
