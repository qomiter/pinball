using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plunger : MonoBehaviour
{
    private SpringJoint2D springJoint;
    private Rigidbody2D rb;
    private float force = 0f;
    public float maxForce = 90f;
    public float powerIndex = 2f;
    public float pressTime; 

    private void Start()
    {
        springJoint = GetComponent<SpringJoint2D>();
        springJoint.distance = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        force = powerIndex * maxForce;
    }

    private void FixedUpdate()
    {
        // When force is not 0
        if (force != 0)
        {
            // release springJoint and power up
            springJoint.distance = 1f;
            rb.AddForce(Vector3.up * force);
            force = 0;
        }

        // When the plunger is held down
        if (pressTime != 0)
        {
            // retract the springJoint distance and reduce the power
            springJoint.distance = 0.8f;
            rb.AddForce(Vector3.down * 400);
        }
    }

}
