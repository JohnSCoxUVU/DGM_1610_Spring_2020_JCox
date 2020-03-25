using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchesgetstitches : MonoBehaviour
{

    public string favHero;
    public int smarts = 5;





    // Start is called before the first frame update
    void Start()
    {
        if (favHero == "Superman")
        {
            print("Wrong!");
        }
        else if (favHero == "Thor") {
            print("Noice!");
                }

        switch (favHero)
        {
            case "Superman":
                print("Wrong!");
                break;
            case "Thor":
                print("Correct!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (smarts)
        {

        }




    }
}
