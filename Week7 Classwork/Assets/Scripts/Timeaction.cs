using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeaction : MonoBehaviour {
	
	public float startTime = 5f;
	public float interval = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//this creates a timer that creates a debug every 3 seconds after the first 5 seconds

		if (Time.time >= startTime) {

			startTime += interval;
			Debug.Log ("dosomething");

			StartCoroutine (ScreenShake.Shake (30, 0.5f)); 

		}
	}
}
