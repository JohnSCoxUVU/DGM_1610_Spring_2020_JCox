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
        currentBattery = 50 * batteries;
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



