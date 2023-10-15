using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            collisionCount++;
            Debug.Log("Collisions with Sphere: " + collisionCount);
        }
    }
}