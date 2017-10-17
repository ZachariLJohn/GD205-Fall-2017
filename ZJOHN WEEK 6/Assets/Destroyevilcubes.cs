using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyevilcubes : MonoBehaviour {
    public GameObject destroyMe1;
    public GameObject destroyMe2;
    public GameObject destroyMe3;
    public GameObject destroyMe4;
    public GameObject destroyMe5;
    public GameObject destroyMe6;
    public GameObject destroyMe7;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
           

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bye1"))
        {
            Destroy(destroyMe1);
        }

        if (other.gameObject.CompareTag("Bye2"))
        {
            Destroy(destroyMe2);
        }

        if (other.gameObject.CompareTag("Bye3"))
        {
            Destroy(destroyMe3);
        }

        if (other.gameObject.CompareTag("Bye4"))
        {
            Destroy(destroyMe4);
        }

        if (other.gameObject.CompareTag("Bye5"))
        {
            Destroy(destroyMe5);
        }

        if (other.gameObject.CompareTag("Bye6"))
        {
            Destroy(destroyMe6);
        }

        if (other.gameObject.CompareTag("Bye7"))
        {
            Destroy(destroyMe7);
        }


    }
}
