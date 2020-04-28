using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintWithStamina : MonoBehaviour
{

    float stamina = 10, maxStamina = 10;
    bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MovementOnceMoreWithFeeling>();
        // Call movement for speed values

    }

    void SetRunning(bool isRunning)
    {

        this.isRunning = isRunning;
        //Distinguishes the declared bool from the void function

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
