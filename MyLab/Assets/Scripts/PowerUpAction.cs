using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerUpAction : MonoBehaviour
{
    [SerializeField] private GameObject powIndicator;

    public PowerUps powerUp;
    public SpinAndBounce spinAndBounce;
    
    private string powDescription;
    private float spinSpeed;
    private float amp;
    private float freq;
    private float center;

    void Start()
    {
        powDescription = powerUp.powFunction;

    }
    
    public void PowerUpIndicator()
    {
        powIndicator.SetActive(true);
        Debug.Log(powDescription);
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
    // If Player collides with powerup, activate powerup
    /*{
        if (other.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            //smokePartiicle.Play();
            //hasPowerup = true;
            //powerupIndicator.SetActive(true);
            //StartCoroutine(PowerupCooldown());
        }
    }

    // Coroutine to count down powerup duration
    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }*/
}
