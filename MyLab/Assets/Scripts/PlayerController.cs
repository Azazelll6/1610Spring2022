using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;

    public bool gameOver = false;
    public float horiMvSpeed = .03f;
    public float vertMvSpeed = .05f;
    public float xRange = 27f;
    public float zTopRange = 33; 
    public float zBotRange = 25;


    /* Code for later use if needed
    private Rigidbody playerRb;
    public ParticleSystem eParticle;
    
    private AudioSource playerAudio;
    
    public AudioClip Sound;
    */
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        //playerAudio = GetComponent<AudioSource>();

    }

    void Update()
    {
        verticalInput = Input.GetAxis("Horizontal");
        horizontalInput = Input.GetAxis("Vertical");
        // If game over no more movement
        if (!gameOver)
        {
            //Horizontal movement along z axis
            transform.Translate(Vector3.right * verticalInput * horiMvSpeed);
            //Vertical movement along x axis
            transform.Translate(Vector3.forward * horizontalInput * vertMvSpeed);
        }
        
        
        
        /*//Stop at top 
        if (transform.position.z > zTopRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopRange);
        }
        //Stop at bottom
        if (transform.position.z < -zBotRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBotRange);
        }
        //Stop at right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Stop at left
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }*/
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



