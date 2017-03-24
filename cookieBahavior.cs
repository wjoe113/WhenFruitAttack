/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieBahavior : MonoBehaviour {

    private float rotSpeed = 50f;
    private float healthPoints = 5.0f;
    private NinjaManager ninjaManager;
    public GameObject parent;
    //private float speed = 0.9f;

    void Start ()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.Find("CustomFPC"))
        {
            parent = transform.parent.gameObject;
            Behaviour halo = (Behaviour) parent.GetComponent("Halo");
            halo.enabled = false; // false
            Destroy( gameObject );
            ninjaManager.addHealth( healthPoints );//health + 5;
            ninjaManager.keepScore(5.0f);
            Debug.Log("EATING THe COOKIE");
        }
    }

    void Update()
    {
        //transform.Rotate( rotSpeed * Time.deltaTime, 0, rotSpeed * Time.deltaTime );
    }
}
