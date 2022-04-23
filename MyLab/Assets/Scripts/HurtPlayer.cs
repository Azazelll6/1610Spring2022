using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int dmgToGive;

    //On trigger collision, hurt player's health 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealthManager>().DmgPlayer(dmgToGive);
        }
    }
}