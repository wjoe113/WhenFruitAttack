/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giantFruitBehavior : MonoBehaviour {

    private float speed = 0.1f;
    private int hits = 0;
    private float groundDamage = 1.0f;
    private float points = 20.0f;
    GameObject FPC;
    private NinjaManager ninjaManager;
    float dist2Player;

    // Use this for initialization
    void Start()
    {
        ninjaManager = GameObject.Find( "CustomFPC" ).GetComponent<NinjaManager>();
        dist2Player = 100f;
        FPC = GameObject.Find("CustomFPC");
    }

    private void OnTriggerEnter( Collider other )// if its hit increase score and destroy
    {

        if( other.gameObject == GameObject.Find( "Sword_Mesh" ) )
        {
            hits++;
  
            if( hits == 10 )
            {
                Destroy( gameObject );
                ninjaManager.keepScore( points );//score + 1;
            }
            //Debug.Log( "KATANA HIT" );
        }
        if( other.gameObject == GameObject.Find( "customSyurikenn(Clone)" ) )
        {
            hits++;

            if( hits == 10 )
            {
                Destroy( gameObject );
                ninjaManager.keepScore( points );//score + 1;
            }

            //Debug.Log( "KATANA HIT" );
        }

        if (other.gameObject == FPC)
        {
            Destroy(gameObject);
            ninjaManager.takeDamage(50);
        }
    }

    void Update()
    {
        dist2Player = Vector3.Distance(FPC.transform.position, gameObject.transform.position);

        if(dist2Player < 5f)
        {
            gameObject.transform.LookAt(FPC.transform);
            gameObject.transform.Translate(0.5f * Vector3.forward * Time.deltaTime);
        }
    }
}