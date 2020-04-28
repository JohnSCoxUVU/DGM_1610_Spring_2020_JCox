using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthREDONE : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth;

    public float healthBarLength;

    public Text gameOver;

    private CharacterController controller;



    // Use this for initialization
    void Start()
    {
        curHealth = 100;
        gameOver.GetComponent<Text>().enabled = false;

        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustCurrentHealth(0);
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, healthBarLength, 20), curHealth + "/" + maxHealth);
    }

    public void AdjustCurrentHealth(int adj)
    {

        curHealth += adj;

        if (curHealth <= 0)
        {
            curHealth = 0;
            print("You are dead!");
            gameOver.GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
        }

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;


        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag("Health"))
        {
            curHealth = 100;
            Destroy(other.gameObject);
        }
        // used for health pickups


        if (other.gameObject.CompareTag("Enemy")) 
        {
            curHealth -= 25;

        }
        //used for Enemy Damage

    }

}
