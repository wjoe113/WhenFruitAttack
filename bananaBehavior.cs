/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaBehavior : MonoBehaviour {

    public GameObject pealedBananaPrefab = null;
    private GameObject pealedBananaGameObj = null;
    private float speed = 0.1f;
    private float groundDamage = 1.0f;
    private NinjaManager ninjaManager;

    void Start ()
    {
        ninjaManager = GameObject.Find("CustomFPC").GetComponent<NinjaManager>();
    }

    private void OnTriggerEnter( Collider other )// if its hit increase score and destroy
    {
        if( other.gameObject == GameObject.Find( "Sword_Mesh" ) )
        {
            pealedBananaGameObj = (GameObject) Instantiate( pealedBananaPrefab, transform.position, transform.localRotation );
            Destroy( gameObject );
            //Debug.Log( "KATANA HIT" );
        }
        if(other.gameObject == GameObject.Find( "customSyurikenn(Clone)" ) )
        {
            pealedBananaGameObj = (GameObject) Instantiate( pealedBananaPrefab, transform.position, transform.localRotation );
            Destroy( gameObject );
            //Debug.Log( "KATANA HIT" );
        }
    }

    void Update ()
    {
        transform.Translate(  0, -speed * Time.deltaTime, 0 );

        if( transform.position.y <= -0.6f ) // if it hits the ground destroy and decrease score
        {
            Destroy( gameObject );
            ninjaManager.takeDamage( groundDamage ); // health - 1; 
        }
    }
}
