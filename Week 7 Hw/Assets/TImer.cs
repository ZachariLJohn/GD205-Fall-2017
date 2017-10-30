using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TImer : MonoBehaviour {
    public int timeLeft = 500;
    public Text countdownText;




    // Use this for initialization
    void Start () {
        StartCoroutine("LoseTime");
    }
	
	// Update is called once per frame
	void Update () {
        countdownText.text = ("Time Left = " + timeLeft);
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            Application.LoadLevel("Day cycle");
        }
    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
