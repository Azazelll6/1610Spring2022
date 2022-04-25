using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody enemyRB;
    private float moveSpeed;
    private float takenKnockBack;

    private PlayerController player;
    public EnemyData enemyData;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        //give reference to the player game object
        player = FindObjectOfType<PlayerController>();

        moveSpeed = enemyData.speed;
        takenKnockBack = enemyData.bounceDistance;
    }

    private void FixedUpdate()
    {
        //Move forward (towards player because of face player below)
        enemyRB.velocity = (transform.forward.normalized * moveSpeed);
    }

    private void Update()
    {
        //face the player
        transform.LookAt(player.transform.position);
    }
}
