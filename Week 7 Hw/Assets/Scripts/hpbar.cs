using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hpbar : MonoBehaviour {

    public float max_Health = 100f;
    public float cur_Health = 0f;
    public GameObject healthBar;
    public bool alive = true;
    private string sceneIndex;

    // Use this for initialization
    void Start()
    {
        cur_Health = 100f;

        InvokeRepeating("decreasehealth", 1f, 1f);
        alive = true;
    }

    public void TakeDamage(float amount)
    {

        if (cur_Health <= 0)
        {
            cur_Health = 0;
            gameObject.SetActive(false);
            transform.position = new Vector3(0, 1.1f, 0);
        }



        cur_Health -= amount;
        SetHealthBar();
    }

    private void SetHealthBar()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        if (cur_Health <= 0)
        {
            cur_Health = 0;
            gameObject.SetActive(false);
            transform.position = new Vector3(0, 1.1f, 0);
           
        }
    }
    void decreasehealth()
    {

        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }
    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShoppingBag1"))
        {
            cur_Health -= 9;
        }
    }

}
