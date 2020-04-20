using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mewvement : MonoBehaviour
{
    float movespeed;
    float walkSpeed = 4;
    float sprintSpeed = 6;
    float gravity = 6;
    bool isGrounded;

    Vector3 moveDirection;

    CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(moveX, 0, moveZ);
            


            if(Input.GetKey(KeyCode.LeftShift))
            {
                movespeed = sprintSpeed;
            }
            else
            {
                movespeed = walkSpeed;
            }
          
            moveDirection *= movespeed;

        }

        moveDirection.y -= gravity;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
