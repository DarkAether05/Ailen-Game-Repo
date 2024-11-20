using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScrpit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Greetings Earthlings");
       Debug.Log("You have my Sword!");
       Debug.Log("And my bow");
       Debug.Log("And my Axe");

       transform.Translate(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("According to the judgement of the oratice mecanique d'Analyse Cardinale");
       transform.Translate(00.1f, 00.1f, 00.1f);
    }
}
