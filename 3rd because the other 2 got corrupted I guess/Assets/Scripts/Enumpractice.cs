using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumpractice : MonoBehaviour
{


    enum Days {sun = 1, mon = 2, tues, wed, thurs, fri, sat };

    Days currentDay;


    // Start is called before the first frame update
    void Start()
    {
        currentDay = Days.sun;


    }

    // Update is called once per frame
    void Update()
    {
        if(currentDay == Days.mon)
        {
            print("Go back to bed!");
        }


    }
}
