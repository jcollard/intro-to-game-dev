using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
        this.transform.Rotate(0, 0, rotation * Time.deltaTime * 90);

        float thruster = Input.GetAxis("Thruster");
        this.transform.Translate(Vector2.up * Time.deltaTime * thruster);
        print(rotation);

    }
}
