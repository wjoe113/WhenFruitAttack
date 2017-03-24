/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCharacterController : MonoBehaviour {

    public Camera myCamera;
    public float movementSpeed = 5.0f;
	public float mouseSensitivity = 5.0f;
	public float jumpSpeed = 15.0f;
    public float upDownRange = 60.0f;
    float verticalRotation = 0;
	float verticalVelocity = 0;
    bool jumping;
    public bool perry;
    public bool crouching;
    //KinectManager km;
    [Tooltip("The katana")]
    public GameObject katana;
    [Tooltip("The perry animation")]
    public ParticleSystem perryAnimation;
    CharacterController characterController;
    float originalHeight;
    AudioSource woosh;

    void Start()
    {
        //km = gameObject.GetComponent<KinectManager>();
        characterController = GetComponent<CharacterController>();
        Screen.lockCursor = true;
        jumping = false;
        perry = false;
        crouching = false;
        originalHeight = characterController.height;
        woosh = katana.GetComponent<AudioSource>();
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
        //Vector3 leftFoot = km.GetJointPosition(km.GetPlayer1ID(), 15);
        //Vector3 rightShoulder = km.GetJointPosition(km.GetPlayer1ID(), 8);
        //Vector3 rightElbow = km.GetJointPosition(km.GetPlayer1ID(), 9);
        //Vector3 rightHand = km.GetJointPosition(km.GetPlayer1ID(), 11);
        //Vector3 rightKnee = km.GetJointPosition(km.GetPlayer1ID(), 17);
        //Vector3 rightFoot = km.GetJointPosition(km.GetPlayer1ID(), 19);
        //Vector3 spineBase = km.GetJointPosition(km.GetPlayer1ID(), 0);
        //Vector3 spineMid = km.GetJointPosition(km.GetPlayer1ID(), 1);

        /* ROTATION */
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        myCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        /* MOVEMENT */
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space)) // Jump
        {
            verticalVelocity = jumpSpeed;
            jumping = true;
        }
        if (jumping)
        {
            if (gameObject.GetComponent<VoiceManager>().glidable && verticalVelocity < 0f) // Glide
            {
                verticalVelocity *= 0.5f;
            }
        }

        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
        speed = transform.rotation * speed;
        characterController.Move(speed * Time.deltaTime);

        //      if (characterController.isGrounded && (leftKnee.y - leftFoot.y < 0.3f)) // Jump
        //      {
        //          verticalVelocity = jumpSpeed;
        //          jumping = true;
        //      }
        //      if (jumping)
        //      {
        //          if (gameObject.GetComponent<VoiceManager>().glidable && verticalVelocity < 0f) // Glide
        //          {
        //              verticalVelocity *= 0.5f;
        //          }
        //      }

        //      if (characterController.isGrounded && (rightKnee.y > spineBase.y) && !crouching) // Crouch
        //      {
        //          characterController.height = 0.8f;
        //          crouching = true;
        //      }
        //      if(characterController.isGrounded && (rightKnee.y - rightFoot.y < 0.3f) && crouching)
        //      {
        //          characterController.height = originalHeight;
        //          crouching = false;
        //      }

        //      if (head.z - spineBase.z > -0.2f) // Move forward
        //      {
        //          gameObject.transform.Translate(0, 0, -2f * Time.deltaTime);
        //      }
        //      if (head.z - spineBase.z < 0.1f) // Move back
        //      {
        //          gameObject.transform.Translate(0, 0, 2f * Time.deltaTime);
        //      }
        //      if (head.x - spineBase.x > 0.2f) // Move right
        //      {
        //          gameObject.transform.Translate(2f * Time.deltaTime, 0, 0);
        //      }
        //      if (head.x - spineBase.x < -0.2f) // Move left
        //      {
        //          gameObject.transform.Translate(-2f * Time.deltaTime, 0, 0);
        //      }
        //      if (rightHand.x - rightShoulder.x < -0.3f) // Turn left
        //      {
        //          gameObject.transform.Rotate(0, -20f * Time.deltaTime, 0);
        //      }
        //      if (leftHand.x - leftShoulder.x > 0.3f) // Turn right
        //      {
        //          gameObject.transform.Rotate(0, 20f * Time.deltaTime, 0);
        //      }

        //      if (rightHand.z < rightShoulder.z  && rightHand.y - rightShoulder.y > 0.1f) // Chop
        //      {
        //          woosh.Play();
        //          katana.GetComponent<Animation>().Play("katanaChopAnimation");
        //      }

        //      if (rightElbow.y - rightShoulder.y < 0.1f && rightHand.x < head.x) // Slash
        //      {
        //          woosh.Play();
        //          katana.GetComponent<Animation>().Play("katanaSlashAnimation");
        //      }

        //      if (leftHand.y > head.y) // Stab
        //      {
        //          woosh.Play();
        //          katana.GetComponent<Animation>().Play("katanaStabAnimation");
        //      }

        //      if (rightHand.x < leftElbow.x && leftHand.x > rightElbow.x) // Parry
        //      {
        //          ParticleSystem.EmissionModule em = perryAnimation.emission;
        //          em.enabled = true;
        //          perryAnimation.Play();
        //          perry = true;
        //      }
        //      else
        //      {
        //          perry = false;
        //          perryAnimation.Stop();
        //      }

        //      if (leftHand.y > head.y && rightHand.y > head.y) // Fruit gods mold the fruit
        //      {
        //          GameObject[] myFruit = GameObject.FindGameObjectsWithTag("Fruit");
        //          foreach (GameObject fruit in myFruit)
        //          {
        //              fruit.GetComponent<moldBehavior>().getMoldy();
        //          }
        //      }
    }

    void turnRight()
    {
        gameObject.transform.Rotate(0, -1f, 0);
    }

    void turnLeft()
    {
        gameObject.transform.Rotate(0, 1f, 0);
    }
}
