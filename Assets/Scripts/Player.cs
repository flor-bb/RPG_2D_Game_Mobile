using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
   
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

       if(movementJoystick.joystick.transform.position.x > movementJoystick.joystickBG.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(movementJoystick.joystick.transform.position.x < movementJoystick.joystickBG.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
  
    }
}
