using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;
    public float jumpdis;


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
        // (x,y,z)

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKey(KeyCode.Space) && CompareTag("Floor"))
        {
            transform.Translate(Vector3.up * jumpdis * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.CompareTag("Floor")) //primary 
        {
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
}
