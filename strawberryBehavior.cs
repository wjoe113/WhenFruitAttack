/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberryBehavior : MonoBehaviour {

    public GameObject strawberryPrefab = null;
    private GameObject strawberryGameObj = null;
    private GameObject strawberryGameObj2 = null;
    private GameObject strawberryGameObj3 = null;
    private GameObject strawberryGameObj4 = null;
    private float speed = 0.1f;
    private float groundDamage = 1.0f;
    private NinjaManager ninjaManager;

    void Start()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter(Collider other) // if it hit increase score and destroy object
    {
        if(other.gameObject == GameObject.Find("Sword_Mesh"))
        {
            strawberryGameObj = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( .1f, 0f, 0f ), Quaternion.Euler( 90, 0, 45 ) );
            strawberryGameObj2 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( -.1f, 0f, 0f ), Quaternion.Euler( 45, 0, 0 ) );
            strawberryGameObj3 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( 0f, .1f, 0f ), Quaternion.Euler( 45, 0, 90 ) );
            strawberryGameObj4 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( 0f, 0f, .1f ), Quaternion.Euler( 90, 0, 0 ) );
            Destroy(gameObject);
        }

        if(other.gameObject == GameObject.Find("customSyurikenn(Clone)"))
        {
            strawberryGameObj = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( .1f, 0f, 0f ), Quaternion.Euler( 90, 0, 45 ) );
            strawberryGameObj2 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( -.1f, 0f, 0f ), Quaternion.Euler( 45, 0, 0 ) );
            strawberryGameObj3 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( 0f, .1f, 0f ), Quaternion.Euler( 45, 0, 90 ) );
            strawberryGameObj4 = (GameObject) Instantiate( strawberryPrefab, transform.position + new Vector3( 0f, 0f, .1f ), Quaternion.Euler( 90, 0, 0 ) );
            Destroy(gameObject);
            // You're as sweet as a strawberry :)
        }
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (transform.position.y <= -0.8f)
        {
            Destroy(gameObject);
            ninjaManager.takeDamage(groundDamage); // health - 1; 
        }
    }
}
