using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;

    public int maxHealth = 3;

    public Transform SpawnPoint;

    public int points = 10;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        SpawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("Enemy is Dead!");            
            // Add points to score for killing enemy
            ScoreManager.AddPoints(points);
            //Move enemy to spawn point for restart
            transform.position = SpawnPoint.position;
            transform.rotation = SpawnPoint.rotation;
            //reset enemy health
            currentHealth = maxHealth;
        }
    }
}
