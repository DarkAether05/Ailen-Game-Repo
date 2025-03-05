using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    // This is will contain the slider componenet attached to this object
    // Slider = varible is in the form of a slider component
    Slider healthBar;

    // This will be the PlayerHealth componenet that we can ask for
    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        // Getting the silder componet off this game object (the one this scrpit is attached to) and sorting it in the healthBar variable 
        healthBar = GetComponent <Slider>();
        // Search the entire scene for the PlayerHealth componete and store it in the player varible
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        // Create temporaray float varibles so we can use float division
        float currantHealth = player.GetHealth();
        float maxHealth = player.startingHealth;
        // The slider value should be between 0 and 1 with 0 being empty and 1 being full
        // We divide the currant health by the max helath to get a number between 0 and 1
        healthBar.value = currantHealth / maxHealth;
    }
}
