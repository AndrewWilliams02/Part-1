using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float maxSpeed = 1000;
    float steeringSpeed = 150, forwardSpeed = 500, steering, acceleration;
    Vector2 force;
    Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        steering = Input.GetAxis("Horizontal");
        acceleration = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.AddTorque((-1*steering) * steeringSpeed * Time.deltaTime);
        force = transform.up * forwardSpeed * acceleration * Time.deltaTime;

        if(rigidBody.velocity.magnitude < maxSpeed)
        {
            rigidBody.AddForce(force);
        }
    }
}
