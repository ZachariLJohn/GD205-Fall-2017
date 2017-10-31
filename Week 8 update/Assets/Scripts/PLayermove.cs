using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PLayermove : MonoBehaviour {


    public Text LoseText;
    
    private int count;
 
    public Text countText;
    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float gravity = 50f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    //bool isJumping; // "controller.isGrounded" can be used instead
    public GameObject checkpoint;
    public GameObject Player;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    [SerializeField]
  

    void Start()
    {
      

        count = 0;
        SetCountText();
        LoseText.text = "";
        controller = GetComponent<CharacterController>();
    }
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

        if (other.gameObject.CompareTag("Enimu"))
        {
            other.gameObject.transform.position =  checkpoint.transform.position ;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enimu2"))
        {
            other.gameObject.transform.position = checkpoint2.transform.position;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enimu3"))
        {
            other.gameObject.transform.position = checkpoint3.transform.position;
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >=5)
        {
            Player.gameObject.SetActive(false);
           LoseText.text = "The nightmares have found their way";
        }
    }
}