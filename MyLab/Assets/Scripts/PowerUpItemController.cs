using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PowerUpItemController : MonoBehaviour
{
    public SpinAndBounce spinAndBounce;
    
    private string powDescription;
    private float spinSpeed;
    private float amp;
    private float freq;
    private float center;

    void Start()
    {

    }
    
    void Update()
    {
        spinSpeed = spinAndBounce.spinSpeed;
        amp = spinAndBounce.bounceAmplitude;
        freq = spinAndBounce.bounceFrequency;
        center = spinAndBounce.bounceInitialHeight;
        
        transform.Rotate(Vector3.up * (spinSpeed * Time.deltaTime));
        transform.position = new Vector3(transform.position.x, center + (Mathf.Sin(Time.time * freq) * amp), transform.position.z);
        
    }
}
