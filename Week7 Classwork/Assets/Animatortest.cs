using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatortest : MonoBehaviour {
	


		Animator myAnim;

		int current;

		// Use this for initialization
		void Start () {

			myAnim = GetComponent<Animator> ();
			current = 0;






		}

		// Update is called once per frame
		void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			current = 1;
		} else { current = 0; }

		if (Input.GetKeyDown (KeyCode.A)) {
			current = 2; 
		} 

		if (Input.GetKeyDown (KeyCode.S)) {
			current = 3; 
		} 

		if (Input.GetKeyDown (KeyCode.D)) {
			current = 4; 
		} 


			myAnim.SetInteger ("whichState", current);

		}
	}