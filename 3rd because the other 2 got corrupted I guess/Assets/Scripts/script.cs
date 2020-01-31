using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody rb;
    public LayerMask groundlayers;
    public float jumpforce = 9;

    public SphereCollider col;


   private bool isGrounded()
    {

       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundlayers);

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);


        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))

        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

    }


       

        }


        
    

