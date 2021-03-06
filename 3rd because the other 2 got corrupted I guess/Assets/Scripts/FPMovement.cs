﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMovement : MonoBehaviour
{

    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float jumpHeight;
    public bool isGrounded;

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);



        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight * 1000);
        }

        if (Input.GetKey(KeyCode.W))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 30;
            }
            else
            {
                speed = 15;
            }
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;

        }




        void OnCollisionEnter(Collision other)
        {


            if (other.gameObject.CompareTag("Floor")) //primary 
            {
                isGrounded = true;
                Debug.Log("Colliding with Floor");
            }
            else if (other.gameObject.CompareTag("Obstacle")) //secondary c:
            {
                Debug.Log("Colliding with Obstacle");
            }
            else //default/tertiary
            {
                Debug.Log("...");
            }




        }

        void OnCollisionExit(Collision Other)
        {
            if (Other.gameObject.CompareTag("Floor") || Other.gameObject.CompareTag("Obstacle"))
            {
                isGrounded = false;
                Debug.Log("Not touching the ground!");
            }

        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger activated");


        }
    }
}
