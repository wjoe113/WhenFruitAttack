/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleHalfBehavior : MonoBehaviour {

    private float rotSpeed = 10f;
    private float speed = 0.05f;
    private float groundDamage = 1.0f;
    private float points = 2.0f;
    private NinjaManager ninjaManager;

    void Start()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter( Collider other )// if its hit increase score and destroy
    {
        if( other.gameObject == GameObject.Find( "Sword_Mesh" )  )
        {
            Destroy( gameObject );
            ninjaManager.keepScore( points ); //score + 1;
            //Debug.Log( "KATANA HIT" );
        }
        if(other.gameObject == GameObject.Find( "customSyurikenn(Clone)" ) )
        {
            Destroy( gameObject );
            ninjaManager.keepScore( points ); //score + 1;
            //Debug.Log( "KATANA HIT" );
        }
    }

    void Update ()
    {
        transform.Rotate(-rotSpeed * Time.deltaTime, rotSpeed * Time.deltaTime, rotSpeed / 2 * Time.deltaTime);
        transform.Translate(-speed * Time.deltaTime, -speed* 2.0f * Time.deltaTime, -speed * Time.deltaTime);

        if (transform.position.y <= -0.6f) //if it hits the ground, destroy
        {
            Destroy(gameObject);
            ninjaManager.takeDamage(groundDamage);//health - 1; 
        }
    }
}
