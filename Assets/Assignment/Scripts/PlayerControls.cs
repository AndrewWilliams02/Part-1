using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    Rigidbody2D rigidbody;

    Vector2 movementDirection;
    public float movementSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection.y = Input.GetAxis("Vertical");
        movementDirection.x = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(movementDirection * movementSpeed * Time.deltaTime);
    }
}
