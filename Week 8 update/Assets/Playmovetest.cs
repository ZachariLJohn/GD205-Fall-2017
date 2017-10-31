using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playmovetest : MonoBehaviour
{

    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float gravity = 50f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    //bool isJumping; // "controller.isGrounded" can be used instead
    // Use this for initialization

    public GameObject Player;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {

        moveDirection.x = Input.GetAxis("Horizontal") * speed;
        moveDirection.z = Input.GetAxis("Vertical") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            if (controller.isGrounded)
            {
                moveDirection.y = jumpSpeed;

            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("ShoppingBag1"))
        {
            /*add count to shopping bag and make it rotate. 
           // think of elsword when it comes to enemy interactions 
                 the enemy is patrolling back and forth through the 
                 enviroment as you are side scrolling have a possible enemy chasing you 
                 after a certain level. be able to have powerups to help the 
                 main character run and or evolve to help him fight agaisnt 
                 enemies and or be more vunerable against them.
       */



            GetComponent<Renderer>().material.color = new Color(0, 255, 0);

            speed = 2f;
        }
        if (other.gameObject.CompareTag("ShoppingBag3")) {
            GetComponent<Renderer>().material.color = new Color(50, 255, 89);

            speed = 34f;
        }

            if (other.gameObject.CompareTag("ShoppingBag2"))
        {
            GetComponent<Renderer>().material.color = new Color(0, 255, 200);

            speed = 10f;

            // make possible if hit by enemy slow by 3 seconds// 

        }
    }

}
