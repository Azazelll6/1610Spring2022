using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool CanShoot = true; // Define true for shooting at start
    private bool cooldown = false;
    
    //public float FireRate = 100f;
    //public float NextShot = -1f;
    //public float timer = Time.time;

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > NextShot)
        {
            CanShoot = true;
        }*/
        
        if (Input.GetKeyDown(KeyCode.Space) && cooldown == false) //&& CanShoot == true)// On spacebar press send dog, unless on cooldown
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("ResetCooldown", 2.0f);
            bool cooldown = true;

            //NextShot = Time.time + FireRate;
        }
    }
    void ResetCooldown ()
    {
        bool cooldown = false;
    }
}
