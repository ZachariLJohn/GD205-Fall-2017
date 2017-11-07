using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInput : MonoBehaviour {


	Animator myAnim;

	int current;

	// Use this for initialization
	void Start () {

		myAnim = GetComponent<Animator> ();
		current = 0;






	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			current = 1;
		} else {
			current = 0;
		}


		myAnim.SetInteger ("whichState", current);

	}
	}

