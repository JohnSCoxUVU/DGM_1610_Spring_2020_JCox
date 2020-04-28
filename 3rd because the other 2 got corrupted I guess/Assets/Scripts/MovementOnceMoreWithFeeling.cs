using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovementOnceMoreWithFeeling : MonoBehaviour
{
    private CharacterController charController;
    [SerializeField] private float movementSpeed;
    
    bool isRunning;
    
    public float stamina;
        float maxStamina = 10;
    
    Rect staminaRect;
    Texture staminaTexture;
    //Stamina Bar


    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 40;
        stamina = maxStamina;
        SetRunning(false);

        staminaRect = new Rect(Screen.width / 10, Screen.height * 9 / 10, Screen.width / 3, Screen.height / 50);
        staminaTexture = new Texture2D(1, 1);
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
            SetRunning(true);
            
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 40;
            SetRunning(false);
            stamina += Time.deltaTime;
        }

        if (isRunning)
        {
            movementSpeed = 70;
            stamina -= Time.deltaTime;
            if (stamina < 0)
            {
                stamina = 0;
                SetRunning(false);
            }
        } else if (stamina < maxStamina)
        {
            stamina += Time.deltaTime;
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

    void SetRunning(bool isRunning)
    {
        this.isRunning = isRunning;
        //Equalizes the declared bool and the function.

    }

    private void OnGUI()
    {
        float ratio = stamina / maxStamina;
        float rectWidth = ratio * Screen.width / 3;
        staminaRect.width = rectWidth;
        GUI.DrawTexture(staminaRect, staminaTexture);

    }

}
