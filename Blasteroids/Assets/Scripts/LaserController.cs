using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    // The speed the laser moves
    public float speed = 3;

    // The range the laser can travel
    public float range = 15;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        this.range = this.range - speed * Time.deltaTime;

        if (this.range < 0)
        {
            print("Range is less than 0");
            UnityEngine.Object.Destroy(this.gameObject);
        }

    }
}
