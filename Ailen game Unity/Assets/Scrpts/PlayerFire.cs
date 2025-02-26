using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Unity edioter varible
    // Which will hold our prefab reference
    public GameObject projectilePrefab;

    public Vector2 projectlVelocity;

    public void FireProjectle()
    {
        // Clone a projectoile
        // Declare a varible to hold the cloned object
        GameObject clonedProjectile;
        // Use the intansise function to clone the projectiles
        clonedProjectile = Instantiate(projectilePrefab);
        // Postion the projectile on the player
        clonedProjectile.transform.position = transform.position;

        // Fire it in a direction
        // Declare a varilble to hold the projectiles rigidbody
        Rigidbody2D projectileRigidbody;
        // Get the projectiles rigidbody
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the enter setting
        projectileRigidbody.velocity = projectlVelocity;
    }
}
