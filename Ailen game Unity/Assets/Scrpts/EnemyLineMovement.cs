using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    // Public varible
    // Exposed for editing in the unity editor
    public float forceStrength; // How fast the enemy moves
    public Vector2 directon; // What direction the enemy should move in

    // Private varibles
    // Not visable in editor, used for tracking data while the game is running
    private Rigidbody2D ourRigidbody; // The container for the rigidbody attached to this object

    // Awake is called when the script is frist loaded
    void Awake()
    {
        // Get and store the rigidbody we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
        // Normalise our direaction
        // Normilse changes it to be length 1, so we can mulipty it by our speed / force later
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
