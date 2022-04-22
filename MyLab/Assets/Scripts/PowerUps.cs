using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private GameObject powIndicatorSpd;
    [SerializeField] private GameObject powIndicatorDmg;
    [SerializeField] private GameObject powIndicatorSlow;
    
    public void PowerupSpd()
    {
        powIndicatorSpd.SetActive(true);
        Debug.Log("Increase Atk and FireRate");
    }
    public void PowerupDmg()
    { 
        powIndicatorDmg.SetActive(true);
        Debug.Log("Increase Dmg"); 
    } 
    public void PowerupSlow() 
    {
        powIndicatorSlow.SetActive(true);
        Debug.Log("Start slow motion");
    }
}
