/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManager : MonoBehaviour {

    float frontDist = 100f;
    float backDist = -100f;
    float leftDist = -100f;
    float rightDist = 100f;
    //GameObject closestFrontW;
    //GameObject closestBackW;
    //GameObject closestLeftW;
    //GameObject closestRightW;
    GameObject iWaypoint;
    public GameObject currentWaypoint;
    public GameObject nextWaypoint;
    public GameObject previousWaypoint;
    public GameObject leftWaypoint;
    public GameObject rightWaypoint;
	
	void Start()
    {
        iWaypoint = GameObject.Find("WayPoint");
        currentWaypoint = GameObject.Find("WayPoint");
        leftWaypoint = null;
        rightWaypoint = null;
    }

    public void initWaypoints()
    {
        iWaypoint = GameObject.Find("WayPoint");
        currentWaypoint = GameObject.Find("WayPoint");
        leftWaypoint = null;
        rightWaypoint = null;
    }

    public void findWaypoints()
    {
        if (iWaypoint == currentWaypoint)
        {
            nextWaypoint = GameObject.Find("WayPoint3");
            previousWaypoint = GameObject.Find("WayPoint");
            leftWaypoint = null;
            rightWaypoint = null;
        }

        //if (currentWaypoint.name.Equals("WayPoint3"))
        //{
        //    nextWaypoint = GameObject.Find("WayPoint4");
        //    previousWaypoint = GameObject.Find("WayPoint");
        //    leftWaypoint = null;
        //    rightWaypoint = null;
        //}
        //if (currentWaypoint.name.Equals("WayPoint3"))
        //{
        //    nextWaypoint = GameObject.Find("WayPoint4");
        //    previousWaypoint = GameObject.Find("WayPoint");
        //    leftWaypoint = null;
        //    rightWaypoint = null;
        //}
        //if (currentWaypoint.name.Equals("WayPoint4"))
        //{
        //    nextWaypoint = GameObject.Find("WayPoint6");
        //    previousWaypoint = GameObject.Find("WayPoint3");
        //    leftWaypoint = GameObject.Find("WayPoint5");
        //    rightWaypoint = GameObject.Find("WayPoint8");
        //}
        //if (currentWaypoint.name.Equals("WayPoint5"))
        //{
        //    previousWaypoint = GameObject.Find("WayPoint4");
        //    previousWaypoint = GameObject.Find("WayPoint4");
        //    leftWaypoint = null;
        //    rightWaypoint = null;
        //}
        //if (currentWaypoint.name.Equals("WayPoint6"))
        //{
        //    nextWaypoint = GameObject.Find("WayPoint7");
        //    previousWaypoint = GameObject.Find("WayPoint4");
        //    leftWaypoint = null;
        //    rightWaypoint = null;
        //}
    }

    //void giveMeAHeadAche()
    //{
    //    GameObject[] myWaypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    //    foreach (GameObject currentWaypoint in myWaypoints)
    //    {
    //        currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX = gameObject.transform.position.x - currentWaypoint.transform.position.x;
    //        currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerY = gameObject.transform.position.y - currentWaypoint.transform.position.y;
    //        currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ = gameObject.transform.position.z - currentWaypoint.transform.position.z;

    //        if (currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ < frontDist)
    //        {
    //            currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ = frontDist;
    //            closestFrontW = currentWaypoint;
    //            Debug.Log("Front Waypoint: " + currentWaypoint.name.ToString());
    //        }
    //        if (currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ > backDist && currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ < 0)
    //        {
    //            currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerZ = backDist;
    //            closestFrontW = currentWaypoint;
    //            Debug.Log("Back Waypoint: " + currentWaypoint.name.ToString());
    //        }
    //        if (currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX < rightDist)
    //        {
    //            currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX = rightDist;
    //            closestFrontW = currentWaypoint;
    //            Debug.Log("Right Waypoint: " + currentWaypoint.name.ToString());
    //        }
    //        if (currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX > leftDist && currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX < 0)
    //        {
    //            currentWaypoint.GetComponent<WaypointManager>().distanceToPlayerX = leftDist;
    //            closestFrontW = currentWaypoint;
    //            Debug.Log("Left Waypoint: " + currentWaypoint.name.ToString());
    //        }
    //    }
    //}
}
