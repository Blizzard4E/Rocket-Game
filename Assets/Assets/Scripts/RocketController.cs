using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float thrustForce = 10f;
    public float rotateDegree = 25f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -rotateDegree * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotateDegree * Time.deltaTime);
        }
    }
}
