using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool flashlightEnabled;
    public GameObject flashlight;
    public GameObject lightObj;
    public float maxBattery;
    public float currentBattery;

    private int batteries;
    private GameObject batteryPickedUp;
    private float usedEnergy;

         
    // Start is called before the first frame update
    void Start()
    {
        currentBattery = maxBattery;
        maxBattery = 50 * batteries;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        maxBattery = 50 * batteries;
        currentBattery = maxBattery;




        //equip 
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlightEnabled =! flashlightEnabled;
        }

        if (flashlightEnabled)
        {

            flashlight.SetActive(true);
            

            if(currentBattery <= 0)
            {
                lightObj.SetActive(false);
                batteries = 0;
            }
            if(currentBattery > 0)
            {
                lightObj.SetActive(true);
                currentBattery -= 0.2f * Time.deltaTime;
                usedEnergy += 0.5f * Time.deltaTime;
            }

            if (usedEnergy >= 50)
            {
                batteries -= 1;
                usedEnergy = 0;
            }


        }

        else { 
            flashlight.SetActive(false);
             }
        }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Battery")
        {
            batteryPickedUp = other.gameObject;
            batteries += 1;
            Destroy(batteryPickedUp);
        }
    }


}



