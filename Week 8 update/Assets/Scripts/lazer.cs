using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class lazer : MonoBehaviour {

    public GameObject prefab;
    public GameObject Enimu1;
    public GameObject Enimu2;
    public GameObject Enimu3;
    public GameObject Enimu4;
    public GameObject Enimu5;
    public GameObject Enimu6;
    public GameObject Enimu7;
    public GameObject Enimu8;
    public GameObject Enimu9;
    public GameObject Enimu10;
    public GameObject Enimu11;
    public GameObject Enimu12;
    public GameObject Enimu13;
    public GameObject Enimu14;
    public GameObject Enimu15;
    public GameObject Enimu16;
    public GameObject Enimu17;
    public GameObject Enimu18;
    
    public Text WinText;

    private int count;

    public Text countText;
    // Use this for initialization
    void Start () {

        count = 0;
        SetCountText();
        WinText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(beam.origin, beam.direction * 1000f);


        RaycastHit beamHit = new RaycastHit();

        if (Physics.Raycast(beam, out beamHit, 1000f))
        {
            Debug.Log("you hit something at" + beamHit.point);
            if (Input.GetMouseButtonDown(0))
            {
                //destroy the gameobject whose collider you hit if you middle click
                Destroy(beamHit.collider.gameObject);
                count = count + 1;
                SetCountText();
            }
        }


        }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 30)
        {
            Enimu1.gameObject.SetActive(false);
            Enimu2.gameObject.SetActive(false);
            Enimu3.gameObject.SetActive(false);
            Enimu4.gameObject.SetActive(false);
            Enimu5.gameObject.SetActive(false);
            Enimu6.gameObject.SetActive(false);
            Enimu7.gameObject.SetActive(false);
            Enimu8.gameObject.SetActive(false);
            Enimu9.gameObject.SetActive(false);
            Enimu10.gameObject.SetActive(false);
            Enimu12.gameObject.SetActive(false);
            Enimu13.gameObject.SetActive(false);
            Enimu14.gameObject.SetActive(false);
            Enimu15.gameObject.SetActive(false);
            Enimu16.gameObject.SetActive(false);
            Enimu17.gameObject.SetActive(false);
            Enimu18.gameObject.SetActive(false);
            

            WinText.text = "You defeated the nightmares cyclops!";
        }
    }
}
