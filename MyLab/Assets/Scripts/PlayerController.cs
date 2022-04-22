using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask ground;
    private Camera mainCamera;
    private Rigidbody playerRb;
    private Vector3 mvVelocity;
    private Vector3 mvInput;
    private Vector3 skew;
    
    public float verticalInput;
    public float horizontalInput;

    public bool gameOver = false;
    public float mvSpeed = 10f;
    


    /* Code for later use if needed
    private Rigidbody playerRb;
    public ParticleSystem eParticle;
    
    private AudioSource playerAudio;
    
    public AudioClip Sound;
    */
    void Start()
    {
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
        
        //if a ray (being the cameraray) intersects the plane,
        //output the value between the camera and the plane as raylength
        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            //
            Vector3 faceMouse = cameraRay.GetPoint(rayLength);
            //Draw the rayLength
            Debug.DrawLine(cameraRay.origin, faceMouse, Color.blue);
            
            //Get the player to look at the mouse and is keeps them up straight
            transform.LookAt(new Vector3(faceMouse.x,transform.position.y,faceMouse.z));
        }
        
        // If game over, no more movement
        if (!gameOver)
        {
            Move(); 
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
        
        mvVelocity = skew * mvSpeed;
    }
    private void OnCollisionEnter(Collision other)
    {
        // if player collides with Karen, die and set gameOver to true
        if (other.gameObject.CompareTag("Karen"))
        {
            //Particle.Play();
            //playerAudio.PlayOneShot(Sound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }

    }
}

/*
    public GameObject projectilePrefab;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player when pressing space
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
*/



