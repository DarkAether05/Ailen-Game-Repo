using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Kill()
    {
        Destroy(gameObject);
    }
    public int startingHealth;
    private int currantHealth;
    private void Awake()
    {
        currantHealth = startingHealth;
    }
    public void ChangeHealth(int changeAmount)
}
