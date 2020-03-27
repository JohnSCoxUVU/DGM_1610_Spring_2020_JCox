using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPractice : MonoBehaviour
{
    public string favCandy;


    // Start is called before the first frame update
    void Start()
    {
        if (favCandy == "Chocolate")
        {
            print("Nice!");
        }


        switch (favCandy)
        {
            case "Chocolate":               
                print("Nice!");
                break;
            case "Caramel":
                print("Acceptable.");
                break;
            case "Licorice":
                print("Nope.");
                break;
            case "I don't like candy":
                print("To each their own, friend.");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
