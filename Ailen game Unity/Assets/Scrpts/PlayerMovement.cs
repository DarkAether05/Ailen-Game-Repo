using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    //Awake is called before start
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //physicsBody.velocity.x = -1;

        //make a varibale to hold a velocity
        //get the velocity from the rigidbody
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -1;

        physicsBody.velocity = newVelocity;
    }
    public void MoveRight()
    {
        //physicsBody.velocity.x = -1;

        //make a varibale to hold a velocity
        //get the velocity from the rigidbody
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = 1;

        physicsBody.velocity = newVelocity;
    }
}
