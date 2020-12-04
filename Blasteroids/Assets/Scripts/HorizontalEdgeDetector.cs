using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEdgeDetector : MonoBehaviour
{
    public float teleportX = 5.25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Colliding with Edge!");

        // Create a variable containing the object that collided with the edge
        GameObject collidingObject = collision.gameObject;

        print(collidingObject);

        float currentY = collidingObject.transform.position.y;
        collidingObject.transform.position = new Vector2(teleportX, currentY);

    }
}
