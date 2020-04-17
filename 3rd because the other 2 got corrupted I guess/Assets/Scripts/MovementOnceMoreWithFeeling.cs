using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovementOnceMoreWithFeeling : MonoBehaviour
{
    private CharacterController charController;
    [SerializeField] private float movementSpeed;


    // Start is called before the first frame update
    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float vertInput = Input.GetAxis("Vertical") * movementSpeed;
        float horInput = Input.GetAxis("Horizontal") * movementSpeed;

       UnityEngine.Vector3 forwardMovement = transform.forward * vertInput;
        UnityEngine.Vector3 sidewaysMovement = transform.right * horInput;

        charController.SimpleMove(forwardMovement + sidewaysMovement);
        //Time.deltatime not necessary, simplemove does so automatically
    }

}
