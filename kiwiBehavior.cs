/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiwiBehavior : MonoBehaviour {

    private float speed = 0.4f;
    private float groundDamage = 1.0f;
    private float points = 2.0f;
    private NinjaManager ninjaManager;
    private GameObject fpc;

    void Start ()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter( Collider other )// if its hit increase score and destroy
    {
        if( other.gameObject == GameObject.Find( "Sword_Mesh" )  )
        {
            Destroy( gameObject );
            ninjaManager.keepScore( points );//score + 1;
            //Debug.Log( "KATANA HIT" );
        }
        if( other.gameObject == GameObject.Find( "customSyurikenn(Clone)" ) )
        {
            Destroy( gameObject );
            ninjaManager.keepScore( points );//score + 1;
            //Debug.Log( "KATANA HIT" );
        }
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

        if( transform.position.y <= -0.8f ) //if it hits the ground, destroy
        {
            Destroy( gameObject );
            ninjaManager.takeDamage( groundDamage );//health - 1; 
        }
    }
}
