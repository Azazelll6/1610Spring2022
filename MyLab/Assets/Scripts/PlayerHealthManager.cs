using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int health;
    private int currentHealth;

    /*Used for flashing color (not working)
    public float flashLength;
    private float flashCounter;

    private Renderer rend;
    private Color storedColor;
    */

    void Start()
    {
        //define current health to public for initial spawn and private health for when just that enemy obj hits 0
        currentHealth = health;
        
        /*Used for flashing color (not working)
        //Get mesh Renderer
        rend = GetComponent<Renderer>();
        //Get color of mesh Renderer
        storedColor = rend.material.GetColor("_Color");
        */
    }
    
    void Update()
    {
        if (currentHealth <= 0)
        {
            Debug.Log("Game Over");
        }
        
        /*Used for flashing color (not working)
        //flash or color apply and remove
        if(flashCounter > 0)
        {
            flashCounter -= Time.DeltaTime;
            if(flashCounter <= 0)
            {
                rend.material.SetColor("_Color"), storedColor);
            }
        */
        
    }
    //when the object is hit and takes damage take that damage from their health
    public void DmgPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
       
        /*Used for flashing color (not working)
        //
        flashCounter = flashLength;
        rend.material.SetColor("_Color", Color.white);
        */
    }
}
