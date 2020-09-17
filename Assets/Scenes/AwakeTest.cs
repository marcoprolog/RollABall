using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeTest : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }

    private void FixedUpdate()
    {
        Debug.Log("fixedUpdate");
    }
}
