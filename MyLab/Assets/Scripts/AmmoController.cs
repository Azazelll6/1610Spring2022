using UnityEngine;

public class AmmoController : MonoBehaviour
{
    public PlayerController player;
    public GameObject[] ammoPrefab;
    public float spd;
    private float ammoTTL;
    private int dmgToGive;
    private float knockStrength;

    public PlayerData playerData;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();

        dmgToGive = playerData.damage;
        ammoTTL = playerData.ammoLife;
        spd = playerData.ammoSpeed;
        knockStrength = playerData.bounceDistance;
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
            other.gameObject.GetComponent<EnemyController>().DmgEnemy(dmgToGive);
            
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
