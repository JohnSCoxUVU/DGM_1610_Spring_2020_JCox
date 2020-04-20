using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
        // public Transform target;
    public float moveSpeed = 5;
    private Rigidbody enemyRb;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // target = GameObject.Find("Player").transform;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Pwayer");
    }

    // Update is called once per frame
    void Update()
    {
      //transform.LookAt("Pwayer");
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


    }

   void FixedUpdate()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);    
    }


}



