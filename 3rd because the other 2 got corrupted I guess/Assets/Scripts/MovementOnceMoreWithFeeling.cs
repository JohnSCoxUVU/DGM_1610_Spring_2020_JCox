using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovementOnceMoreWithFeeling : MonoBehaviour
{
    private CharacterController charController;
    [SerializeField] private float movementSpeed;


    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 40;    
    }


    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = 70;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 40;
        }
       

    }

    private void PlayerMovement()
    {
        float vertInput = Input.GetAxis("Vertical");
        float horInput = Input.GetAxis("Horizontal");

       UnityEngine.Vector3 forwardMovement = transform.forward * vertInput * movementSpeed;
        UnityEngine.Vector3 sidewaysMovement = transform.right * horInput * movementSpeed;

        charController.SimpleMove(forwardMovement + sidewaysMovement);
        //Time.deltatime not necessary, simplemove does so automatically
    }




}
