using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    //CameraController Script from Zachari John's Group Ghost House Game
    //takes the object (in this case the camera's Vector3 (x,y,and z) and locked it to the player)
    void Start () {
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
    }
}
