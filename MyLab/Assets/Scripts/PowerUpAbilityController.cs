using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpAbilityController : MonoBehaviour
{
    private string[] powerUpTags = {"DMGPowerUp", "MvSPDPowerUp", "FrPowerUp", "Heal"};
    [SerializeField] private UnityEvent powUpTrigger;
    [SerializeField] private GameObject powIndicatorMvSpeed;
    [SerializeField] private GameObject powIndicatorFrSpeed;
    [SerializeField] private GameObject powIndicatorDmg;
    
    public bool hasPowerUp;
    public bool pushHeal;
    private float powerUpDuration = 5;

    private void Start()
    {
        hasPowerUp = false;
        pushHeal = false;
    }    
    
    private void Update()
    {
        if (hasPowerUp == false)
        {
            powIndicatorMvSpeed.SetActive(false);
            powIndicatorFrSpeed.SetActive(false);
            powIndicatorDmg.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DMGPowerUp"))
        {
            powUpTrigger.Invoke();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("MvSPDPowerUp"))
        {
            powUpTrigger.Invoke();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("FrPowerUp"))
        {
            powUpTrigger.Invoke();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Heal")) 
        {
            powUpTrigger.Invoke();
            Destroy(other.gameObject);
        }
    }
       
    // Coroutine to count down powerup duration
    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerUp = false;
    }
    
    public void MvSpdPowerUp()
    {
        hasPowerUp = true;
        StartCoroutine(PowerupCooldown());
        powIndicatorMvSpeed.SetActive(true);
        Debug.Log("Random Power Up Triggered");
    } 
    
    public void FireRateSpdPowerUp()
    {
        hasPowerUp = true;
        StartCoroutine(PowerupCooldown());
        powIndicatorDmg.SetActive(true);
        Debug.Log("Speed Power Up Triggered");
    }
    
    public void DmgPowerUp()
    {
        hasPowerUp = true;
        StartCoroutine(PowerupCooldown());
        powIndicatorDmg.SetActive(true);
        Debug.Log("Damage Power Up Triggered");
    }
    public void Heal()
    { 
        pushHeal = true;
        Debug.Log("Heal Triggered");
    }
    
}
