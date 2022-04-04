using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool hasPowerup = false;
	public GameObject powerupIndicator;
	private Rigidbody playerRb;
	public float speed = 2.0f;
	private float PowerupStrength = 15.0f;
	private GameObject focalPoint;


    void Start()
    {
	    playerRb = GetComponent<Rigidbody>();
	    focalPoint = GameObject.Find("Focal Point");
    }


    void Update()
    {
	    float forwardInput = Input.GetAxis("Vertical");
	    playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
	    powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
	    if (other.CompareTag("Powerup"))
	    {
		    hasPowerup = true;
		    powerupIndicator.gameObject.SetActive(true);
		    Destroy(other.gameObject);
		    StartCoroutine(PowerupCountdownRoutine());
	    }
    }
    IEnumerator PowerupCountdownRoutine()
    {
	    yield return new WaitForSeconds(7);
	    hasPowerup = false;
	    powerupIndicator.gameObject.SetActive(false);

    }
    
    
    private void OnCollisionEnter(Collision collision)
    {
	    if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
	    {
		    Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
		    Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
		    
		    Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
		    enemyRigidbody.AddForce(awayFromPlayer * PowerupStrength, ForceMode.Impulse);
	    }
    }
}
