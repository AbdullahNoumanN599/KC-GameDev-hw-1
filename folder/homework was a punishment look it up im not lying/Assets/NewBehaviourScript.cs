using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "rock the dwayne jonathon";
        int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        damaged();
        print(health + "THE DWAYNE WONT SAY CHING CHONG BING BONGIN CHINESE NO MORE");
        boosted();
        print(health + "LET THE ROCK TELL YOU IN CHINESE: CHING CHONG BING BONG HIT STONE COLD AIIII");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void damaged()
    {
        health -= 20;
    }

    void boosted()
    {
        health += 10;
    }
}
