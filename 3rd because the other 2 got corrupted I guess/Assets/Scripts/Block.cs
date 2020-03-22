using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject shield;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Shield")
        {
            SpawnShield();
            Destroy(GameObject.FindGameObjectWithTag("Shield"));
        }
    }

    public void SpawnShield()
    {
        Instantiate(shield, GetComponent<OptimizedMovement>().gameObject.transform.position,
                    GetComponent<OptimizedMovement>().gameObject.transform.rotation);
    }
}


