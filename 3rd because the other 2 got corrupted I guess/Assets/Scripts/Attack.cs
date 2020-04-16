using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float damage;
    public Transform target;
    public int moveSpeed = 3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveSpeed*Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        print("Enemy is attacking!");
        var health = other.gameObject.GetComponent<PlayerHealth>();

        if(health != null)
        {

        }

    }


}



