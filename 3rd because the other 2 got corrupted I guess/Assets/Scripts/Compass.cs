using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 360 - transform.root.rotation.eulerAngles.y, 0);
    }
}