using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsThisReallyAllAMouseLookNeeds : MonoBehaviour
{


    // Update is called once per frame
    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}

