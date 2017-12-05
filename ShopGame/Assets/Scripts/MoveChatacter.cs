using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveChatacter : MonoBehaviour {
	Rigidbody2D myRig;

	private Animator Myanimation;
	public   string MoveCowBoy="Wine";
	public static bool move=false;


	//DetectObjects db ;
	// Use this for initialization
	void Start () {
		myRig = GetComponent<Rigidbody2D> ();
		//GameObject MoveCow = GameObject.Find ("MoveCowBoy");
		Myanimation = GetComponent<Animator> ();
	
//	  db = MoveCow.GetComponent<DetectObjects> ();

	}
	
	// Update is called once per frame
	void Update () {
		HandleMovement ();
		
	}
	public void HandleMovement(){

		if (move== true) {
			myRig.velocity = Vector2.right * 30;
		}
	}



//	 Update is called once per frame

//	public 	void GetImageName(Image im){
//		if (im.name == "WineGlass") {
//			move = true;
//
//			Debug.Log("Wine Glass is clicked");
//		}
//
//
//			
//	}

}
