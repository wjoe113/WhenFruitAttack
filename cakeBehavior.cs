/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakeBehavior : MonoBehaviour {

    //private float rotSpeed = 10f;
    private float healthPoints = 10.0f;
    private NinjaManager ninjaManager;

    void Start()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject == GameObject.Find("CustomFPC"))
        {
            Destroy(gameObject);
            ninjaManager.addHealth(healthPoints); // health + 10;
            ninjaManager.keepScore(10.0f);
            //Debug.Log("EATING THE CAKE");
        }
    }
}
