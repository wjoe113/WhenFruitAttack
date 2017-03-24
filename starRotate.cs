/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starRotate : MonoBehaviour {
	
	void Update ()
    {
        gameObject.transform.Rotate(0, 0, 500 * Time.deltaTime);
	}
}
