using UnityEngine;
using UnityEngine.UI; //add this when referencing UI elements
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public int score = 0;

    private Rigidbody rb;

    public Text scoreUI;
    public Text winUI;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("got a point");
        score++;
        other.gameObject.SetActive(false);
        scoreUI.text = "Score: " + score;

        if (score == 7)
        {
            //activate the win text
            winUI.enabled = true;
        }
    }

}