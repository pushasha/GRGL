using UnityEngine;
using System.Collections;

using Grgl.Concrete.Character;

public class PlayerBehavior : MonoBehaviour {

	private const int RMB = 1;
	Character pc;

	// Use this for initialization
	void Start () {

		pc = new Character("Player", "pc001");
	}
	
	// Update is called once per frame
	void Update () {
	
		// -- Check if the E key has been pressed down on this frame --
		if (Input.GetMouseButtonDown(RMB))
		{
			// -- Key has been pressed, now Raycast --
			
			// variables used in raycast
			Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit rayHit;
			
			// raycast command
			if ( Physics.Raycast( mouseRay, out rayHit, 1000 ) && rayHit.collider.gameObject != this.gameObject)
			{
				Debug.Log(rayHit.collider.gameObject.name );
			}
		}

	}
}
