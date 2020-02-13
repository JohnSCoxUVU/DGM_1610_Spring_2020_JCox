using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickup : Pickup
{

    public int healthAmt = 100;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("You gained " + healthAmt + " health!");
    }


}
