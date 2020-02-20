using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBarAttempt : MonoBehaviour
{
    public int ammo = 30;
    public TextAsset uitext;
    private bool isAttacking = false;
    public float delay = 0.1f;

    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            StartCoroutine(Attack());
        }

    }

    private IEnumerator Attack()
    {
        if (isAttacking == true)
        {
            yield break;
        }
        isAttacking = true;
        ammo -= 1;
       /* if (uitext != null)
        { 
            uitext.text = ammo.ToString();
        }
        yield return new WaitForSeconds(delay);
        isAttacking = false; /* \* */
    }
}

