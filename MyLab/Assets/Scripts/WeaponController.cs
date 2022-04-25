using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public bool isFiring;
    
    //private GameManager gameManager;
    public AmmoController ammo;

    public PlayerData playerData;
    private float shotCounter;
    private float ammoSpd;
    private float reload;
    

    public Transform fireSpawn;

    void Start()
    {
        reload = playerData.reloadTime;
    }

    private void Update()
    {

        if (isFiring)
        {
            //if we are firing the fire rate counter will count down till next available shot
            shotCounter -= Time.fixedDeltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = reload;//at end of counter reset to the fire rate value for next shot
                //Create bullet at the correct spawn point as a AmmoController with the correct
                //properties instead of a GameObject
                AmmoController newAmmo = Instantiate(ammo, fireSpawn.position, fireSpawn.rotation) as AmmoController;
                newAmmo.spd = ammoSpd;
            }
        }
        //setting fire rate to be ready to fire if we haven't fired since FR hit 0
        else if(!isFiring)
        {
            if (shotCounter > 0)
            {
                shotCounter -= Time.fixedDeltaTime;
            }
        }
    }
}
