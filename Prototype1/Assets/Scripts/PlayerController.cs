using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }
    
    void Update()
    {
        //Define inputs from Project settings>input manager
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward by vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle by vertical input
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
