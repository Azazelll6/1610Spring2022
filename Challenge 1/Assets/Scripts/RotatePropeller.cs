using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float speed = 2000;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spins the propeller while flying
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
