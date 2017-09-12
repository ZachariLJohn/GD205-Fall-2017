using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playermove : MonoBehaviour {
    // Player Move script is from Zachari John's Level 2 Ghost house Game // 
    public Vector3 Backup;
    public GameObject currentCheckpoint;
    public GameObject Startpoint;
    public GameObject Player;
    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float gravity = 50f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    //bool isJumping; // "controller.isGrounded" can be used instead
    [SerializeField]
    int nrOfAlowedDJumps = 1; // New vairable
    int dJumpCounter = 0;     // New variable
    public Text winText;
   

    // Use this for initialization
    void Start()
        {
      
        controller = GetComponent<CharacterController>();
        winText.text = "";
       
        Backup = new Vector3(-20, 0, 0);
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
                dJumpCounter = 0;
            }
            if (!controller.isGrounded && dJumpCounter < nrOfAlowedDJumps)
            {
                gravity = 10;


            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
    //Enemy Tag from Zachari John's Level 2 Ghost House Game//
    //Player Checkpoint inspired by gamesplusjames//
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy2"))
        {
            Debug.Log("NOT LIKE THIS");
            Player.transform.position = currentCheckpoint.transform.position;
        }
        if (other.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("HOME SWEET HOME");
            Player.transform.position = Startpoint.transform.position;
        }
        if (other.gameObject.CompareTag("Cappy"))
        {
            Debug.Log("MY BABY");
            other.gameObject.SetActive(false);
            winText.text = "YAY you got your... Golden thing back! you win!";
        }
    }

    }