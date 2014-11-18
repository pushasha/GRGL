using UnityEngine;
using System.Collections.Generic;
using Grgl.Concrete.Dialog;
using Grgl.Interfaces.Dialog;

public class InterfaceBehavior: MonoBehaviour {


	public GUISkin customSkin;

	// Use this for initialization
	void Start () {

		DialogActive = false;



	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUI.skin = customSkin; 

		if (DialogActive){
			DrawDialogWindow();
		}

	}

	public static bool DialogActive { get; set;}

	public static string DialogMainText {get; set;}

	public static DialogNode CurrentNode {get; set;}

	public static void DrawDialogWindow(){
		GUILayout.BeginArea(new Rect(Screen.width/3, Screen.height/3, Screen.width / 2, Screen.height / 2), GUI.skin.GetStyle("Area"));
		GUILayout.Label(CurrentNode != null ? CurrentNode.Text : "");

		GUILayout.BeginVertical();


		if (!(CurrentNode is IDialogChoiceNode)){

			if (GUILayout.Button ("Click to continue...")){

				if (CurrentNode.Next == null){
					DialogActive = false;
					(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>() as PlayerBehavior).ToggleControls();
					PlayerBehavior.EndDialog();
				}
				else {
					CurrentNode = CurrentNode.Next as DialogNode;
				}


			}
			
		}

		else {
			DialogChoiceNode node = CurrentNode as DialogChoiceNode;

			foreach (KeyValuePair<string, IDialogNode> pair in node.Choices){
				if (GUILayout.Button(pair.Value.Text)){
					CurrentNode = (CurrentNode as DialogChoiceNode).Choices[pair.Key] as DialogNode; 
					CurrentNode = CurrentNode.Next as DialogNode;

				}
			}
			//

		}


		GUILayout.EndVertical();



		GUILayout.EndArea();
	}

}
