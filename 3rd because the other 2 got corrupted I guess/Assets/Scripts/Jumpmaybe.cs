using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Jumpmaybe : MonoBehaviour
{
    public int forceConst = 50;

private bool canJump;
    private Rigidbody selfRigidbody;

    // Start is called before the first frame update
    void Start()
    {

        selfRigidbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);

        }    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;

        }
    }
}
