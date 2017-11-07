using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evilseek : MonoBehaviour {
   
    
    public Transform Player;
    public Transform myTransform;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player);
        transform.Translate(Vector3.forward * 7 * Time.deltaTime);
    }
}
