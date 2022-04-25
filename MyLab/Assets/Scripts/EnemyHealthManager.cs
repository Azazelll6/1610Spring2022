using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public EnemyData enemyData;
    private int currentHealth;
    
    
    void Start()
    {
        //define current health to public for initial spawn and private health for when just the player obj hits 0
        currentHealth = enemyData.health;
    }
    
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    //when the object is hit and takes damage take that damage from their health
    public void DmgEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
