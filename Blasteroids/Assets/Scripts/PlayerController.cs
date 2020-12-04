using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 120;
    public float thrusterSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        this.transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float rotation = Input.GetAxis("Rotation");
        // Rotate the ship on the z-axis
        this.transform.Rotate(0, 0, rotation * Time.deltaTime * rotationSpeed);

        float thruster = Input.GetAxis("Thruster");
        // Move the ship forward when the thruster button is pressed
        this.transform.Translate(Vector2.up * thruster * Time.deltaTime * thrusterSpeed);

    }
}
