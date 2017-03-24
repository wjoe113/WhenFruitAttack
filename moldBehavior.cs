/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moldBehavior : MonoBehaviour {

    public Material mold;
    private Material original;
    float timeLeft = 3f;
    bool timerStarted;

    void Start()
    {
        Renderer objRenderer = GetComponent<Renderer>();
        original = objRenderer.material;
        timerStarted = false;
	}

    public void getMoldy()
    {
        timerStarted = true;
        GetComponent<Renderer>().material = mold;
        //Debug.Log("MOLDY");
       
    }
	
	void Update ()
    {
        if(timerStarted)
        {
            timeLeft -= Time.deltaTime;
        }

        if( timeLeft < 0f)
        {
            timeLeft = 3f;
            timerStarted = false;
            GetComponent<Renderer>().material = original;
            //Debug.Log("UNMOLDY");
        }
    }
}
