using System;
using System.Collections;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private string[] powerUpTags = {"DMGPowerUp", "MvSPDPowerUp", "FrPowerUp", "Heal"};
    
    private Rigidbody enemyRB;
    private float moveSpeed;
    private float takenKnockBack;

    private PlayerController player;

    private int dmgToGive;
    private int currentHealth;

    public EnemyData enemyData;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        //give reference to the player game object
        player = FindObjectOfType<PlayerController>();
        
        dmgToGive = enemyData.damage;

        //define current health to public for initial spawn and private health for when just the player obj hits 0
        currentHealth = enemyData.health;
    }

    private void Update()
    {
        moveSpeed = enemyData.speed;
        takenKnockBack = enemyData.bounceDistance;
        
        //Move forward (towards player because of face player below)
        enemyRB.velocity = (transform.forward.normalized * moveSpeed);
        if (player != null)
        {
            //face the player
            transform.LookAt(player.transform.position);
        }
        //Destroy on 0 health
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    
    //Deal damage to player
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerController>().DmgPlayer(dmgToGive);
        }
        if (((IList)powerUpTags).Contains(other.gameObject.tag))
        {
            Destroy(other.gameObject);
        }
    }
    //when the object is hit and takes damage take that damage from their health
    public void DmgEnemy(int damage)
    {
        currentHealth -= damage;
    }
}

internal class HardSurfaceTags
{
}
