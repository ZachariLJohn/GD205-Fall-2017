using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {


    public Transform[] patrol;
    private int Currentpoint;
    public float moveSpeed;

    void Start()
    {
        transform.position = patrol[1].position;
        Currentpoint = 0;
    }
    void Update()
    {
        if (transform.position == patrol[Currentpoint].position)
        {
            Currentpoint++;
        }

        if (Currentpoint >= patrol.Length)
        {
            Currentpoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrol[Currentpoint].position, moveSpeed * Time.deltaTime);
    }
}

