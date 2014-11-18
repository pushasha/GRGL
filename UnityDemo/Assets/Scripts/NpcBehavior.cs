using UnityEngine;
using System.Collections;
using Grgl.Concrete.Character;

public class NpcBehavior : MonoBehaviour {



	// Use this for initialization
	void Start () {
		this.NpcObject = new Npc("Olaf", "NpcOlaf001");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Npc NpcObject {get; private set;}
}
