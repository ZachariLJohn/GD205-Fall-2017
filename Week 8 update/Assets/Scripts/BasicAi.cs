using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAi : MonoBehaviour {


    public Transform Player;
    public Transform myTransform;




    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
        transform.Translate(Vector3.forward * 2 * Time.deltaTime);
    }
}

