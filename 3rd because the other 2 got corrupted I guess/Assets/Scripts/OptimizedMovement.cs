using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizedMovement : MonoBehaviour
{
    public CharacterController controller;
   
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpforce = 10.0f;
    private Vector3 motion = Vector3.zero;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

                 }
    void Move()
    {
        motion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        motion *= speed;
        motion = transform.TransformDirection(motion);

        controller.Move(motion);
        //controller.SimpleMove(motion);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            motion.y = jumpforce;
        }

        motion.y -= gravity * Time.deltaTime;
        controller.Move(motion * Time.deltaTime);

    }



}
