using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Here I forgot to put the code into the public class. I'm leaving it to show my mistake and correction.
public float speed;
public float verticalInput;
public float horizontalInput;
public float turnSpeed;
*/

public class Anattempttodomovementfrommemory : MonoBehaviour
{


    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);


        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.CompareTag("Floor")) //primary 
        {
            Debug.Log("Touching Floor");
        }
        else if (other.gameObject.CompareTag("Obstacle")) //secondary c:
        {
            Debug.Log("Touching Obstacle");
        }
        else //default/tertiary
        {
            Debug.Log("Waiting.");
        }

       


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger triggered");
    }


}
