using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    //public List<GameObject> ammoPrefab;
    public float spd;
    public float ammoTTL;

    public int dmgToGive;
    void Start()
    {

    }
    void Update()
    {
       //int index = Random.Range(0, ammoPrefab.Count);
        transform.Translate(Vector3.forward * spd * Time.smoothDeltaTime);
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
            Destroy(gameObject);
        }
        //Destroy Ammo on colliding with wall
        else if (other.gameObject.CompareTag("Wall"))
        { 
            Destroy(gameObject);
        }
    }
}
