using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f; 
    public float countdown = 3.0f;

    
    void Update ()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
            light.enabled = true;
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }   
}