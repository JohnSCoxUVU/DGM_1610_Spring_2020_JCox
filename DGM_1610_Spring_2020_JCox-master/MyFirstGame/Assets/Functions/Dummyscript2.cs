using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummyscript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int coins;
        int defeated_monsters = 5;
        int days = 200;
        coins = defeated_monsters + days;
        Debug.Log(coins);
        int damage;
        int attack;
            attack = 5;
        damage = attack * 4;
        int health;
        health = 400;
        int remaining_health;
        remaining_health = health - damage;
        int mana;
        mana = 5000;
        int firespellcost;
        firespellcost = 500;
        int remainingmana;
        remainingmana = mana - firespellcost;
        Debug.Log(remaining_health);
        Debug.Log(remainingmana);
        int fullness;
        int food;
        int time;
        food = 300;
        time = 200;
        fullness = food - time;
        Debug.Log(fullness);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
