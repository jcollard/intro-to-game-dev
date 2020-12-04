using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeDetector : MonoBehaviour
{

    public float teleportY = 5.25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Colliding with Edge!");

        // Create a variable containing the object that collided with the edge
        GameObject collidingObject = collision.gameObject;

        print(collidingObject);

        float currentX = collidingObject.transform.position.x;
        collidingObject.transform.position = new Vector2(currentX, teleportY);

    }

}
