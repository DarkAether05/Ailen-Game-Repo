using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int hazardDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the collider of the object we collided with
        Collider2D collider = collision.collider;
        // Try to get the player health script attached to that object
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        // Check if we found a player health script on the collided object
        if (player != null)
        {
            // Call the kill function on the player varible
            player.ChangeHealth(-hazardDamage);
        }
        
    }
}
