/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitTrigger : MonoBehaviour {

    private FruitRandomizer randomizeFruits;
    public int triggerLevel; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.Find("CustomFPC"))
        {
            randomizeFruits = GameObject.Find("CustomFPC").GetComponent<FruitRandomizer>();
            randomizeFruits.level = triggerLevel;
            //randomizeFruits.triggerLevel(); //only used to verify trigger level
            //randomizeFruits.triggerLevel();
            //Debug.Log("Player ENTERED trigger zone");
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    randomizeFruits = GameObject.Find("FPSController").GetComponent<FruitRandomizer>();
    //    randomizeFruits.level = triggerLevel;
    //    randomizeFruits.triggerLevel();
    //    Debug.Log("Player is IN trigger zone");
    //}

    private void OnTriggerExit(Collider other)
    {
        if( other.gameObject ==  GameObject.Find("CustomFPC"))
        {
            randomizeFruits = GameObject.Find("CustomFPC").GetComponent<FruitRandomizer>();
            randomizeFruits.level = 0;
            //randomizeFruits.triggerLevel();
            //Debug.Log( "Player LEFT trigger zone" );
        }
    }
}
