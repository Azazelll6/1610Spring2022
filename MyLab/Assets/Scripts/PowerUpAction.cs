using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerUpAction : MonoBehaviour
{
    [SerializeField] private GameObject powIndicator;

    public PowerUps powerUp;
    public SpinAndBounce spinAndBounce;
    
    private string _powDescription;
    private float spinSpeed;
    private float amp;
    private float freq;
    private float center;

    void Start()
    {
        _powDescription = powerUp.powFunction;

    }
    
    public void PowerUpIndicator()
    {
        powIndicator.SetActive(true);
        Debug.Log(_powDescription);
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
