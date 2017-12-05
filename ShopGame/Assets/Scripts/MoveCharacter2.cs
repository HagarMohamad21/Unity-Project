using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter2 : MonoBehaviour {
	Rigidbody2D myRig2;
	public static bool move2;
	// Use this for initialization
	void Start () {
		myRig2 = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		HandleMovement2 ();

	}public void HandleMovement2(){

		if (move2== true) {
			myRig2.velocity = Vector2.right * 30;
		}
	}

}
