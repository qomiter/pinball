using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{    
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDampner = 150f;
    public float speed = 0f; 
    HingeJoint2D hinge;
    JointMotor2D motor2D;
    public string inputName;
    
  
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor2D = hinge.motor;
        

        
    }

    
    void FixedUpdate()
    {   
        hinge.useLimits = true;

        if(Input.GetAxis(inputName) == 1)
        {
            motor2D.motorSpeed = -speed;
            hinge.motor = motor2D;
            Debug.Log("Getting here!");
        }
        else
        {
            motor2D.motorSpeed = speed;
            hinge.motor = motor2D;
            Debug.Log("else");
        }
        
        
    }

}
