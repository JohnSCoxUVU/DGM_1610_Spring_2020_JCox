using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizedMovement : MonoBehaviour
{
    public CharacterController controller;
   
    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpForce = 10.0f;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * deltaX + transform.forward * deltaZ;
        controller.Move(move * speed * Time.deltaTime);

        Vector3 motion = new Vector3(deltaX, 0, deltaZ);
        motion = Vector3.ClampMagnitude(motion, speed);

        motion.y = gravity;

        controller.Move(motion);
        //controller.SimpleMove(motion);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
        }

        motion.y -= gravity * Time.deltaTime;
        controller.Move(motion * Time.deltaTime);

    }



}
