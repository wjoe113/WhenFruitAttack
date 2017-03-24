/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peeledBananaBehavior : MonoBehaviour {

    public GameObject bareBananaPrefab = null;
    private GameObject bareBananaGameObj = null;
    private float rotSpeed = 10f;
    private float speed = 0.1f;
    private float groundDamage = 1.0f;
    private NinjaManager ninjaManager;

    void Start()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter( Collider other ) // if it hit increase score and destroy object
    {
        if(other.gameObject == GameObject.Find("Sword_Mesh"))
        {
            bareBananaGameObj = (GameObject) Instantiate(bareBananaPrefab, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }

        if(other.gameObject == GameObject.Find("customSyurikenn(Clone)"))
        {
            bareBananaGameObj = (GameObject) Instantiate(bareBananaPrefab, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(-rotSpeed * Time.deltaTime,0, Time.deltaTime);  
        transform.Translate(0, -speed * 2.0f * Time.deltaTime, 0);
        if( transform.position.y <= -0.6f ) // if it hits the ground, destroy
        {
            Destroy(gameObject);
            ninjaManager.takeDamage(groundDamage); // health - 1; 
        }
    }
}
