using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    public PlayerController player;
    //public List<GameObject> ammoPrefab;
    public float spd;
    public float ammoTTL;

    public int dmgToGive;

    public float knockStrength;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
       //int index = Random.Range(0, ammoPrefab.Count);
        transform.Translate(Vector3.forward * (spd * Time.deltaTime));
        //Destroy ammo after (ammoTTL) sec
        ammoTTL -= Time.deltaTime;
        if (ammoTTL <= 0)
        {
            Destroy(gameObject);
        }
        /*Same thing
         Destroy(gameObject, ammoTTL);
         */
    }
    private void OnCollisionEnter(Collision other)
    {
        //Destroy Karen on hit
        if (other.gameObject.CompareTag("Karen"))
        {
            other.gameObject.GetComponent<EnemyHealthManager>().DmgEnemy(dmgToGive);
            
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - player.transform.position;
            enemyRigidbody.AddForce(awayFromPlayer * knockStrength, ForceMode.Force);
            
            Destroy(gameObject);
        }
        //Destroy Ammo on colliding with wall
        else if (other.gameObject.CompareTag("Wall"))
        { 
            Destroy(gameObject);
        }
    }
}
