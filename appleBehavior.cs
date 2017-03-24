/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleBehavior : MonoBehaviour {

    public GameObject slicedApplePrefab = null;
    private GameObject slicedAppleGameObj = null;
    private float speed = 0.05f;
    private float groundDamage = 1.0f;
    private NinjaManager ninjaManager;
    private bool katanaHit = false;
    
    void Start ()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter(Collider other) // if its hit increase score and destroy
    {
        if( other.gameObject == GameObject.Find("Sword_Mesh"))
        {
            slicedAppleGameObj = (GameObject) Instantiate(slicedApplePrefab, transform.position, transform.rotation);
            slicedAppleGameObj = (GameObject) Instantiate(slicedApplePrefab, transform.position, Quaternion.Euler(0, 180, 0));
            Destroy(gameObject);
            //Debug.Log( "KATANA HIT" );
        }
        if( other.gameObject == GameObject.Find("customSyurikenn(Clone)"))
        {
            slicedAppleGameObj = (GameObject) Instantiate(slicedApplePrefab, transform.position, transform.rotation);
            slicedAppleGameObj = (GameObject) Instantiate(slicedApplePrefab, transform.position, Quaternion.Euler(0, 180, 0));
            Destroy(gameObject);
            //Debug.Log( "KATANA HIT" );
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime,0);
        if (transform.position.y <= -0.6f ) // if it hits the ground destroy and decrease score
        {
            Destroy(gameObject);
            ninjaManager.takeDamage(groundDamage); // health - 1; 
        }
    }
}
