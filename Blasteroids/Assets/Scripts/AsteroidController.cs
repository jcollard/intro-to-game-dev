using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    // The initial force vector to apply to this 
    public Vector2 initialForce;
    public float rotationSpeed;
    public Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody.AddForce(initialForce);
    }

    private void Update()
    {
        transform.Rotate(transform.forward * rotationSpeed * Time.deltaTime);
    }

}
