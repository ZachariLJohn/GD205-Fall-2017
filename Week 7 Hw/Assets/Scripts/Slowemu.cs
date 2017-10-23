using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowemu : MonoBehaviour {


    public Transform Player;
    public Transform myTransform;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
        transform.Translate(Vector3.forward * 1 * Time.deltaTime);
    }
}
