/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starBehavior : MonoBehaviour {

    private float add = 5.0f;
    GameObject FPC;
    GameObject parent;

    private void Start()
    {
        FPC = GameObject.Find("CustomFPC");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == FPC)
        {
            Destroy(gameObject);
            FPC.GetComponent<VoiceManager>().addStars(5.0f);
            FPC.GetComponent<NinjaManager>().keepScore(5.0f);
            Debug.Log("GOT MORE STARS");
        }
    }

    void Update()
    {
        //transform.Rotate(100.0f * Time.deltaTime, 0, 150.0f * Time.deltaTime);
    }
}
