/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class VoiceManager : MonoBehaviour {

    [SerializeField]
    private string[] m_Keywords;
    KeywordRecognizer m_Recognizer;
    [Tooltip("The katana")]
    public GameObject katana;
    [Tooltip("Where the shuriken spawns here")]
    public GameObject starSpawn;
    [Tooltip("The shurikens")]
    public GameObject star;
    [Tooltip("The force of the shuriken")]
    public float starForce = 300f;
    [Tooltip("Time the shuriken travels")]
    public float timeLeft = 5.0f;
    [Tooltip("Shurikens left")]
    public float starCount = 5.0f;
    [Tooltip("Allows the player to glide")]
    public bool glidable;
    [Tooltip("Shuriken count on GUI")]
    public Text shurikens;
    [Tooltip("An apple")]
    public GameObject applePrefab;
    [Tooltip("A pear")]
    public GameObject pearPrefab;
    [Tooltip("A banana")]
    public GameObject bananaPrefab;
    bool grabbing;
    GameObject fruitObj;
    AudioSource woosh;

    void Start ()
    {
        m_Keywords = new string[11];
        m_Keywords[0] = "Throw";
        m_Keywords[1] = "Star";
        m_Keywords[2] = "Glide";
        m_Keywords[3] = "Chop";
        m_Keywords[4] = "Slash";
        m_Keywords[5] = "Stab";
        m_Keywords[6] = "Center";
        m_Keywords[7] = "Mold";
        m_Keywords[8] = "Apple";
        m_Keywords[9] = "Pear";
        m_Keywords[10] = "Banana";
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnKeywordsRecognized;
        m_Recognizer.Start();
        Debug.Log(m_Recognizer.IsRunning.ToString());
        glidable = false;
        grabbing = false;
        woosh = katana.GetComponent<AudioSource>();
    }

    private void Update()
    {
        shurikens.text = "Shurikens: " + starCount;
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        if (args.text == m_Keywords[0]) // Throw fruit
        {
            if (grabbing)
            {
                Rigidbody tempRigidBody = fruitObj.GetComponent<Rigidbody>();
                tempRigidBody.AddForce(transform.forward * 500);
                Destroy(fruitObj, timeLeft);
                grabbing = false;
            }
        }

        if (args.text == m_Keywords[1])
        {
            if(starCount > 0)
            {
                GameObject tempForce = Instantiate(star, starSpawn.transform.position, starSpawn.transform.rotation) as GameObject;
                tempForce.transform.Rotate(Vector3.left * 90);
                Rigidbody tempRigidBody = tempForce.GetComponent<Rigidbody>();
                tempRigidBody.AddForce(transform.forward * starForce);
                Destroy(tempForce, timeLeft);
                starCount--;
            }
        }

        if (args.text == m_Keywords[2])
        {
            if (!glidable)
            {
                glidable = true;
            }
            else
            {
                glidable = false;
            }
        }

        if (args.text == m_Keywords[3])
        {
            woosh.Play();
            katana.GetComponent<Animation>().Play("katanaChopAnimation");
        }

        if (args.text == m_Keywords[4])
        {
            woosh.Play();
            katana.GetComponent<Animation>().Play("katanaSlashAnimation");
        }

        if (args.text == m_Keywords[5])
        {
            woosh.Play();
            katana.GetComponent<Animation>().Play("katanaStabAnimation");
        }
        if (args.text == m_Keywords[6])
        {
            gameObject.GetComponent<NavigationManager>().initWaypoints();
            gameObject.GetComponent<NavigationManager>().findWaypoints();
            GameObject currentWaypoint = GameObject.Find("WayPoint");
            Vector3 newDir = Vector3.RotateTowards(gameObject.transform.position, currentWaypoint.transform.position, 1.0f * Time.deltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        if (args.text == m_Keywords[7]) // Fruit gods mold the fruit
        {
            GameObject[] myFruit = GameObject.FindGameObjectsWithTag("Fruit");
            foreach (GameObject fruit in myFruit)
            {
                fruit.GetComponent<moldBehavior>().getMoldy();
            }
        }

        if (args.text == m_Keywords[8]) // Grab apple
        {
            fruitObj = Instantiate(applePrefab, starSpawn.transform.position, Quaternion.Euler(0, 0, 0));
            grabbing = true;
        }

        if (args.text == m_Keywords[9]) // Grab pear
        {
            fruitObj = Instantiate(pearPrefab, starSpawn.transform.position, Quaternion.Euler(0, 0, 0));
            grabbing = true;
        }

        if (args.text == m_Keywords[10]) // Grab banana
        {
            fruitObj = Instantiate(bananaPrefab, starSpawn.transform.position, Quaternion.Euler(0, 0, 0));
            grabbing = true;
        }
    }

    public void addStars(float add)
    {
        starCount += add;
    }
}
