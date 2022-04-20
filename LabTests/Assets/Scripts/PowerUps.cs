using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private GameObject powIndicator;
    
    public void PowerupIncrease()
    {
        powIndicator.SetActive(true);
        Debug.Log("Increase Atk and FireRate");
    }
}
