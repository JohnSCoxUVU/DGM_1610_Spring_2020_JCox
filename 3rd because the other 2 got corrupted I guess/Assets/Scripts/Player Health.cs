using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public int damage;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
        dead = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            dead = true;
        }
        else
        {
            dead = false;
        }

        if (dead == true)
        {
            print("GAME OVER");
        }
    }
}
