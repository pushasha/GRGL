using UnityEngine;
using System.Collections;

using Grgl.Concrete.Character;
using Grgl.Concrete.Dialog;
using Grgl.Interfaces.Dialog;

public class PlayerBehavior : MonoBehaviour {

	private const int RMB = 1;
	private const int LMB = 0;
	static Character pc;

	public static DialogTree CurrentTree {get; set;}

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
				// Debug.Log(rayHit.collider.gameObject.name );

				// interact if it hits a human
				if (rayHit.collider.gameObject.GetComponent<NpcBehavior>() != null && !pc.CharacterStates.Contains(Grgl.Other.CharacterStateType.Dialog))
				{
					NpcBehavior npc = rayHit.collider.gameObject.GetComponent<NpcBehavior>();
					this.StartDialog(npc.NpcObject);
				}
			}// end if
		}

	}

	void StartDialog(Npc npc){

		// add "in dialog" flag
		pc.CharacterStates.Add(Grgl.Other.CharacterStateType.Dialog);
		ToggleControls();
		// open dialog window

		InterfaceBehavior.DialogActive = true;

		Debug.Log("Having a convo with " + npc.Name);
		InterfaceBehavior.DialogMainText = "Conversation with " + npc.Name;
		CurrentTree = npc.DialogTree as DialogTree;
		InterfaceBehavior.CurrentNode = CurrentTree.Root as DialogNode;



	}

	public static void EndDialog(){
		pc.CharacterStates.Remove(Grgl.Other.CharacterStateType.Dialog);

	}

	public void ToggleControls(){
		Debug.Log("Toggling controls..."); 
		GetComponent<MouseLook>().enabled = !GetComponent<MouseLook>().enabled;
		(GetComponent("SEP_3rdPersonController") as MonoBehaviour).enabled = !(GetComponent("SEP_3rdPersonController") as MonoBehaviour).enabled;
	}

}
