﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizedMovement : MonoBehaviour
{
    public CharacterController controller;
   
    public float speed = 12f;
    public float gravity = -9.81f;

   


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}