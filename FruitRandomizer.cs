/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRandomizer : MonoBehaviour {

    public GameObject strawberryPrefab = null;
    public GameObject applePrefab = null;
    public GameObject pearPrefab = null;
    public GameObject kiwiPrefab = null;
    public GameObject bananaPrefab = null;
    private GameObject strawberryGameObj = null;
    private GameObject appleGameObj = null;
    private GameObject pearGameObj = null;
    private GameObject kiwiGameObj = null;
    private GameObject bananaGameObj = null;
    private GameObject player;
    private Vector3 playerPosition;
    public int level;
    private int framesLevel = 0;

    void Start ()
    {
        player = GameObject.Find("CustomFPC");
    }

    //public void triggerLevel()
    //{
    //    //level = 1;

    //    //Debug.Log("LEVEL per trigger" + level);
    //}

    void Update()
    {
        framesLevel++;
        playerPosition = player.transform.position;
        //Debug.Log( "LEVEL per update" + framesLevel );

        if(level == 1 && framesLevel == 350)
        {
            appleGameObj = (GameObject) Instantiate( applePrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.4f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            strawberryGameObj = (GameObject) Instantiate( strawberryPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            pearGameObj = (GameObject) Instantiate( pearPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            bananaGameObj = (GameObject) Instantiate( bananaPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            kiwiGameObj = (GameObject) Instantiate( kiwiPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            //Debug.Log( playerPosition );
            //Debug.Log("LEVEL 1 FRUITS FALLING");
            framesLevel = 0; //restart timer

        }
         if(level == 2 && framesLevel == 300)
        {
            appleGameObj = (GameObject) Instantiate( applePrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.4f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            strawberryGameObj = (GameObject) Instantiate( strawberryPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            pearGameObj = (GameObject) Instantiate( pearPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            bananaGameObj = (GameObject) Instantiate( bananaPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            kiwiGameObj = (GameObject) Instantiate( kiwiPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            //Debug.Log( "LEVEL 2 FRUITS FALLING" );
            framesLevel = 0; //restart timer

        }
         if(level == 3 && framesLevel == 250)
        {
            appleGameObj = (GameObject) Instantiate( applePrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.4f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            strawberryGameObj = (GameObject) Instantiate( strawberryPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            pearGameObj = (GameObject) Instantiate( pearPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            bananaGameObj = (GameObject) Instantiate( bananaPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            kiwiGameObj = (GameObject) Instantiate( kiwiPrefab, playerPosition + new Vector3( UnityEngine.Random.Range( 0.2f, 1f ), 0.6f, UnityEngine.Random.Range( -0.3f, 0.4f ) ), Quaternion.Euler( 0, 0, 0 ) );
            //Debug.Log( "LEVEL 3 FRUITS FALLING" );
            framesLevel = 0; //restart timer
        }

        if (level == 0)
        {
            framesLevel = 0;
        }
    }
}
