using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;
    private int currantHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currantHealth == 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        Destroy(gameObject);
    }
    private void Awake()
    {
        currantHealth = startingHealth;
    }
    public void ChangeHealth(int changeAmount)
    {
        currantHealth = currantHealth + changeAmount;
        currantHealth = Mathf.Clamp(currantHealth, 0, startingHealth);
    }
    // This function is a custom function
    // It is a getter function which gives info to the calling code 
    // The int is the type of info that will be givin
    public int GetHealth()
    {
        // Return will give the following info back to the calling code
        return currantHealth;
    }
}
