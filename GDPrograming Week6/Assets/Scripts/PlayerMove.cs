using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float gravity = 50f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    public Text countText;
    private int count;
    public Text winText;
    public Text loseText;
    public GameObject Enimu1;
    public GameObject Enimu2;
    public GameObject Enimu3;
    public GameObject Enimu4;
    public GameObject Player;
    public GameObject EnimuD;
    // Use this for initialization
    void Start () {

        count = 0;
        SetCountText();
        winText.text = "";
        loseText.text = "";
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
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

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("DicePower"))
        {
            other.gameObject.SetActive(false);
            winText.text = "VICTORY";
            Enimu4.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("EnimuD"))
        {
            Player.gameObject.SetActive(false);
            loseText.text = "YouLose";
            
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 1)
        {
            Enimu1.gameObject.SetActive(false);
        }
        if (count >= 2)
        {
            Enimu2.gameObject.SetActive(false);
        }
        if (count >= 3)
        {
            Enimu3.gameObject.SetActive(false);
        }
    }



}
