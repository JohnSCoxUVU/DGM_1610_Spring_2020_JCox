using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, 0.1f);
                            // (x,y,z)

    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.CompareTag("Floor")) //primary 
        {
            Debug.Log("Colliding with Floor");
        }
        else if(other.gameObject.CompareTag("Obstacle")) //secondary c:
        {
            Debug.Log("Colliding with Obstacle");
        }
        else //default/tertiary
        {
            Debug.Log("...");
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger activated");


    }


}
