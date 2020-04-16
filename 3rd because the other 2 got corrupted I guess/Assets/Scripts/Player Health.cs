using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public const int maxHealth = 100;
    public int damage;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
        dead = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            dead = true;
            playerHealth = 0;
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

