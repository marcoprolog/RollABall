using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    Transmitter transmitterComponent;

    // Start is called before the first frame update
    void Start()
    {
        GameObject transmitterObject = GameObject.Find("Transmitter");
        transmitterComponent = transmitterObject.GetComponent<Transmitter>();
        Transform transmitterTransform = transmitterObject.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transmitterComponent.score);
    }

    private void OnMouseDown()
    {
        
    }
}
