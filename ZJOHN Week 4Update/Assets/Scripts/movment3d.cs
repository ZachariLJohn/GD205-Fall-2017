using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment3d : MonoBehaviour {
	public GameObject mover;

	public GameObject[] enemies;

	public Vector3 startingPosition;
	public float enemyspeed = 0.1;
	public GameObject bg;
	public GameObject winspot;
	public int movmentAmt =1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (mover.transform.position.z > 19 ||
		    mover.transform.position.x > 19 ||
		    mover.transform.position.x < 0) {

			mover.transform.position = startingPosition;
		}

		if (mover.transform.position ==
		    new Vector3 (winspot.transform.position.x,
			    mover.transform.position.y, 
			    winspot.transform.position.z)) {

			Debug.Log ("pie");
			mover.GetComponent<MeshRenderer> ().material.color = Color.red;
			mover.transform.localScale *= 1.01f; //increases player size contantly on the spot

			Newlevel
		} 
		//enemy interaction
		for (int i = 0; i < enemies.Length; i++) {
			
			if (mover.transform.position == enemies [i].transform.position) {
				mover.transform.position = startingPosition; //run into enemy and get reset (enemy was also turned into an int to whenever we put on more numbers 
			}

			if (enemies [i].transform.position.x > -2) {
				enemies [i].transform.position += new Vector3 (-0.25f, 0, 0);
			} else {
				enemies [i].transform.position = new Vector3 (18, 4, 12);
			}


			//player movement
			if (Input.GetKeyDown (KeyCode.W)) {

				Debug.Log ("true");
				mover.transform.position += new Vector3 (0, 0, movmentAmt);

			} 

			if (Input.GetKeyDown (KeyCode.S)) {

				Debug.Log ("Sea");
				mover.transform.position += new Vector3 (0, 0, -movmentAmt);
				;

			} 

			if (Input.GetKeyDown (KeyCode.A)) {

				Debug.Log ("Apple");
				mover.transform.position += new Vector3 (-movmentAmt, 0, 0);

			} 

			if (Input.GetKeyDown (KeyCode.D)) {

				Debug.Log ("Dog");
				mover.transform.position += new Vector3 (movmentAmt, 0, 0);

			} 


		}
	}
	void Newlevel() {  //new level start for random gen levels

		bg.GetComponent<MeshRenderer> ().material.color = new Color ( Random.Range(0f,1f), Random.Range(0f,1f),  Random.Range(0f,1f));
		mover.transform.position = startingPosition;
		mover.GetComponent<MeshRenderer> ().material.color = new Color ( Random.Range(0f,1f), Random.Range(0f,1f),  Random.Range(0f,1f));
		for (int1 = 0; if <enemies.Length; i++) {
			enemies[i]
		}

}
