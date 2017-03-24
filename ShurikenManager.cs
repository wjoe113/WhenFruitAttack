/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenManager : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("CustomFPC") || other.gameObject.name.Equals("Sword_Mesh"))
        {
            // DO NOTHING
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
