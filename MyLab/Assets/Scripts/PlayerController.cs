using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask ground;
    private Camera mainCamera;
    private Rigidbody playerRb;
    private Vector3 mvVelocity;
    private Vector3 mvInput;
    private Vector3 skew;
    private float moveSpeed;
    private int currentHealth;
    
    public bool gameOver = false;

    public WeaponController weaponController;
    public PlayerData playerData;

    
    //public ParticleSystem eParticle;
    //private AudioSource playerAudio;
    //public AudioClip Sound;
    
    void Start()
    {
        //define current health to public for initial spawn and private health for when just that enemy obj hits 0
        currentHealth = playerData.health;
        moveSpeed = playerData.speed;
        
        
        playerRb = GetComponent<Rigidbody>();
        //playerAudio = GetComponent<AudioSource>();
        mainCamera = FindObjectOfType<Camera>();
    }

    void Update()
    {
        //Creates a line to screen
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        //Defines a new vertical plane the line will hit
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;
        
        
        // If game over, no more movement
        if (!gameOver)
        {
            //if a ray (being the cameraray) intersects the plane,
            //output the value between the camera and the plane as raylength
            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 faceMouse = cameraRay.GetPoint(rayLength);
                //Draw the rayLength
                Debug.DrawLine(cameraRay.origin, faceMouse, Color.blue);
            
                //Get the player to look at the mouse and is keeps them up straight
                transform.LookAt(new Vector3(faceMouse.x,transform.position.y,faceMouse.z));
            }
        
       
            Move();
            //if LMB click/hold fire weapon
            if (Input.GetMouseButtonDown(0))
            {
                //changes isFiring bool in WeaponController.cs to true
                weaponController.isFiring = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                //changes isFiring bool in WeaponController.cs to false
                weaponController.isFiring = false;
            }
        }
        if (currentHealth <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void FixedUpdate()
    {
        playerRb.velocity = mvVelocity;
    }

    private void Move()
    {
        //Raw is immediate 0 to 1, without Raw it is gradual
        mvInput = new Vector3(Input.GetAxisRaw("Horizontal"),0f,Input.GetAxisRaw("Vertical"));
        //Skews the input on the vertical and hoizontal inputs by 45 degrees, giving the iso game an up down feel to movement
        skew = Quaternion.Euler(new Vector3(0, 45, 0)) * mvInput;
        
        mvVelocity = skew * moveSpeed;
    }
    private void OnCollisionEnter(Collision other)
    {
        // if player collides with Karen, die and set gameOver to true
        if (other.gameObject.CompareTag("Karen"))
        {
            //Particle.Play();
            //playerAudio.PlayOneShot(Sound, 1.0f);
            //gameOver = true;
            //Debug.Log("Game Over!");
            //Destroy(other.gameObject);
        }

    }
    //when the player is hit and takes damage take that damage from their health
    public void DmgPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
    }
}



