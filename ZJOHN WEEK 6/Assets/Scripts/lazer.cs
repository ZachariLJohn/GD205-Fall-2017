using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour {
	//public Rigidbody rb;
// 	public int movmentAmt =1;
	//public GameObject pie;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
	//rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {


		// this line of code with a ray will utilize the mouse position as camera movement (think overwatch, or 3d horror games)
		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);

		Debug.DrawRay (beam.origin, beam.direction * 1000f);


		RaycastHit beamHit = new RaycastHit ();


		//the if statement for your raycast (for the line that hits an object)
		if( Physics.Raycast(beam, out beamHit, 1000f)) {

			Debug.Log ("you hit something" + beamHit.point);

			if (Input.GetMouseButtonDown (0)) {
				//forces any object with aq rigit body up

				beamHit.rigidbody.AddForce (Random.insideUnitSphere  * 5000f);
				//Destoryme.transform.position *= 1.01f;
				//rb.AddForce(0, 0, 39);

				if (Input.GetMouseButtonDown (1)) {
					//forces any object with aq rigit body up
					Instantiate (prefab,beamHit.point, Quaternion.identity);
					//beamHit.rigidbody.AddForce (Random.insideUnitSphere  * 5000f);
					//Destoryme.transform.position *= 1.01f;
					//rb.AddForce(0, 0, 39);
			}
		}
	}
}
}




// HOMEWORK IDEA. Utilize the first person script from your ghost house game and move it to positio. 
//utilize the ray code to make a first person lazer (possibly learn to make actual visual lazer shots) you are trapped in a room and cyclopse is fighting an enemy 
//walking towards him when he shoots the neemy the enemy respawns in a random location in the room if the enemy touches you are you are dead screen pops up 