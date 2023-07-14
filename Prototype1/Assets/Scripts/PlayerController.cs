using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardlInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        // Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
