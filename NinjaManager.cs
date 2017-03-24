/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaManager : MonoBehaviour{

    /* INIT */
    //[Tooltip("The player's katana")]
    //public GameObject katana;
    //KinectManager km;
    //GameObject obj; // Raycast stored obj
    //Renderer objRenderer;
    //Material oldMtl;
    //[Tooltip("Camera pos for raycast")]
    //public Camera myCamera;
    //[Tooltip("Highlights the object with material")]
    //public Material highlightMaterial;
    //Vector3 rayCastOrigin;
    //Vector3 rayCastDir;
    [Tooltip("The score text")]
    public Text myText;
    bool grabbing;
    bool grabbable;
    GameObject[] taggedObjects;
    Vector3 nullVector = new Vector3(0, 0, 0);

    /* PLAYER STATS */
    [Tooltip("HP Texture")]
    public Texture2D HpBarTexture;
    public float curHp = 100.0f;
    static float maxHp = 100.0f;
    public float score = 0.0f;
    float hpBarLength;
    float percentOfHP;

    void Start()
    {
        //km = gameObject.GetComponent<KinectManager>();
        grabbing = false;
    }

    void OnGUI()
    {
        if (curHp > 0) // Health bar
        {
            GUI.DrawTexture(new Rect((Screen.width) - 300, Screen.height - 270, hpBarLength * 2, 20), HpBarTexture);
        }
        //if (curMana > 0) // Mana bar
        //{
        //   GUI.DrawTexture(new Rect((Screen.width) - 200, Screen.height - 320, manaBarLength * 2, 20), ManaBarTexture);
        //}
        //if (curStamina > 0) // Stamina bar
        //{
        //    GUI.DrawTexture(new Rect((Screen.width) - 300, Screen.height - 290, stamBarLength * 2, 20), StaminaBarTexture);
        //}
        //GUI.TextField(new Rect((Screen.width - 300), Screen.height - 30, 200, 50), "Shurkiens: " + gameObject.GetComponent<VoiceManager>().starCount.ToString()); // shuriken counter
    }

    void Update()
    {
        /* KINECT JOINTS */
        //Vector3 head = km.GetJointPosition(km.GetPlayer1ID(), 3);
        //Vector3 leftShoulder = km.GetJointPosition(km.GetPlayer1ID(), 4);
        //Vector3 leftElbow = km.GetJointPosition(km.GetPlayer1ID(), 5);
        //Vector3 leftWrist = km.GetJointPosition(km.GetPlayer1ID(), 6);
        //Vector3 leftHand = km.GetJointPosition(km.GetPlayer1ID(), 7);
        //Vector3 leftKnee = km.GetJointPosition(km.GetPlayer1ID(), 13);
        //Vector3 rightShoulder = km.GetJointPosition(km.GetPlayer1ID(), 8);
        //Vector3 rightElbow = km.GetJointPosition(km.GetPlayer1ID(), 9);
        //Vector3 rightHand = km.GetJointPosition(km.GetPlayer1ID(), 11);
        //Vector3 rightKnee = km.GetJointPosition(km.GetPlayer1ID(), 17);
        //Vector3 spineBase = km.GetJointPosition(km.GetPlayer1ID(), 0);
        //Vector3 spineMid = km.GetJointPosition(km.GetPlayer1ID(), 1);

        /* KATANA */
        //moveKatana(rightHand);

        /* PULL
        Vector3 currWristToShoulderLen = km.GetJointPosition(km.GetPlayer1ID(), 7) - km.GetJointPosition(km.GetPlayer1ID(), 4);
        if (Mathf.Abs(Mathf.Abs(rightShoulder.x) - Mathf.Abs(rightElbow.x)) <= 0.1f
            && Mathf.Abs(Mathf.Abs(rightShoulder.z) - Mathf.Abs(rightElbow.z)) <= 0.1f
            && rightElbow.y > rightShoulder.y                                   // if right elbow is above left shoulder 
            && grabbable                                                        // if the currently selected object is grabbable
            && curMana >= 10.0f                                                 // if the player has enough mana
            && leftHand != nullVector)                                              // if head exists in scene
        {
        }*/

        /* HP */
        percentOfHP = curHp / maxHp;
        hpBarLength = percentOfHP * 150;
    }

    /* RAYCAST */
    void FixedUpdate()
    {
        //RaycastHit hit;
        //if (!grabbing)
        //{
        //    Vector3 raycastDirection = new Vector3(km.GetJointPosition(km.GetPlayer1ID(), 7).x, 0f, 1.0f);
        //    Vector3 raycastOrigin = new Vector3(myCamera.transform.position.x, myCamera.transform.position.y, myCamera.transform.position.z);
            
        //    if (Physics.Raycast(raycastOrigin, raycastDirection, out hit))
        //    {
        //        //Debug.Log("Hit");
        //        Debug.Log("****DIRECTION: " + raycastDirection);
        //        //Debug.Log("****ORIGIN: " + raycastOrigin);
        //        if (obj != hit.collider.gameObject)
        //        {
        //            if (obj != null)
        //            {
        //                objRenderer.material = oldMtl;
        //            }
        //            if (hit.collider.gameObject.name.Contains("Cube"))
        //            {
        //                obj = hit.collider.gameObject;
        //                objRenderer = obj.GetComponent<Renderer>();
        //                oldMtl = objRenderer.material;
        //                objRenderer.material = highlightMaterial;
        //                grabbable = true;
        //            }
        //        }
        //    }
        //    else if (obj != null)
        //    {
        //        objRenderer.material = oldMtl;
        //        obj = null;
        //    }
        //}
    }

    /* GOT HIT */
    public void takeDamage(float damage)
    {
        if (curHp > damage + 1 && !gameObject.GetComponent<CustomCharacterController>().perry)
        {
            curHp -= damage;
        }
        else
        {
            Time.timeScale = 0.0f;
            // GAME OVER
            //display high score!
        }
        //Debug.Log( "DAMAGE " + curHp );
    }

    /* GOT HEALTH */
    public void addHealth(float health)
    {
        if( curHp < 100.0f && !gameObject.GetComponent<CustomCharacterController>().perry)
        {
            curHp += health;
        }
        //Debug.Log( "Adding HEALTH " + curHp );
    }

    public void keepScore( float points )
    {
        score += points;
        myText.text = "Score: " + score;
        //Debug.Log( "Score: " + score );
    }

    /* PLAYER IS HIT BY FRUIT */
    private void OnTriggerEnter( Collider other )
    {
        GameObject[] fruits = GameObject.FindGameObjectsWithTag( "Fruit" );

        foreach(GameObject fruit in fruits)
        {
            if( other.gameObject == fruit )
            {
                //Debug.Log( "FRUIT HIT!!!****" );
                takeDamage(1.0f); //health -1; 
                Destroy( fruit );
            }
        }
    }

    /* MOVES THE KATANA */
    //void moveKatana(Vector3 rightHand)
    //{
    //    katana.transform.rotation = Quaternion.Euler(
    //        gameObject.transform.rotation.x + (rightHand.x * 150),
    //        gameObject.transform.rotation.y + (rightHand.y * 150),
    //        gameObject.transform.rotation.z + (-rightHand.z * 150) + 180);
    //    //Debug.Log((gameObject.transform.rotation.x + (rightHand.x * 100)) + " " + (gameObject.transform.rotation.y + (rightHand.y * 100)) + " " + (gameObject.transform.rotation.z + (rightHand.z * 100)));
    //}
}