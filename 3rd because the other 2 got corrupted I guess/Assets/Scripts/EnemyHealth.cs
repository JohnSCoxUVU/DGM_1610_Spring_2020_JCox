using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int CurrentHealth;
    public int maxHealth = 3;
    public Transform SpawnPoint;
    public int points = 10;



    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = maxHealth;
        SpawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            print("Enemy is Dead!");            
            // Add points to score for killing enemy
            //scoreManager.AddPoints(points);
            //Move enemy to spawn point for restart
            transform.position = SpawnPoint.position;
            transform.rotation = SpawnPoint.rotation;
            CurrentHealth = maxHealth;
        }
    }
}
