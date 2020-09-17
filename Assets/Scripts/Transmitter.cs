using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : MonoBehaviour
{

    string name = "Marco";
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void SomethingSomething()
    {
        name = "somethign";
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
