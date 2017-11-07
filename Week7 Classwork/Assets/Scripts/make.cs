using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make : MonoBehaviour {
	
	Animator myAnim;
	int current;

	// Use this for initialization
	void Start () {
		//assign the animator that's already attached to the same game object as the script
		myAnim = GetComponent<Animator>();
		current = 0;
	}

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W)) {
			current = 1;
		} else {
			current = 0;
		}

		if ( Input.GetKey (KeyCode.S)) {
			current = 2;
		}
		//use the SetInteger function to update the animation parameter
		//"WhichState" is the name of the parameter and current is the value it's being updated to
		myAnim.SetInteger("WhichState", current);
	}
}