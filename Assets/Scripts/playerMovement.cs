using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float sideWayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() // mejor usar fixeUpdate que Update para todo lo que implique fisicas y añadir fuerzas
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime); // recordar usar delta time para evitar la diferencia de frames entre pc

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

