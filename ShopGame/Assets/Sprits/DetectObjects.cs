using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
public class DetectObjects : MonoBehaviour {
	
	//public   string MoveCowBoy="Wine";
	public Image wine;
	public Image wineInhead;
	public Image money;
	public Image BlueBerry;
	public Image BlueBerryInhead;
	public Image money2;
	//public SpriteRenderer rnd;
	//DetectObjects db ;
	// Use this for initialization
void Start () {
		money.enabled = false;
		money2.enabled = false;
//		rnd = GetComponent<SpriteRenderer> ();
//		GameObject MoveCow = GameObject.Find ("MoveCowBoy");
//
//		//	  db = MoveCow.GetComponent<DetectObjects> ();
//
}

	// Update is called once per frame

//	public void HandleMovement(){
//
//		if(move==true)
//			myRig.velocity = Vector2.right*30;
//	}



	// Update is called once per frame

	public 	void GetImageName(Image im){
		if (im.name == "WineGlass") {
			wine.gameObject.GetComponent<Image> ().enabled = false;
			wineInhead.enabled = false;
			money.enabled = true;
			MoveChatacter.move = true;
			Debug.Log ("Wine Glass is clicked");
		} else if (im.name == "GirlBread2") {
			MoveCharacter2.move2 = true;
			BlueBerry.enabled = false;
			BlueBerryInhead.enabled = false;
			money2.enabled = true;
			Debug.Log ("BlueBerry jam is clicked");
		}


		//	
	}

}
