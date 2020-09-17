using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTest : MonoBehaviour
{
    public GameObject mainCameraObject;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        mainCameraObject = GameObject.Find("Main Camera");
        camera = mainCameraObject.GetComponent<Camera>();
        // gameObject.GetComponent<Camera>(); == GetComponent<Camera>();
        //  gameObject == reference to the game object that the script is currently on
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
