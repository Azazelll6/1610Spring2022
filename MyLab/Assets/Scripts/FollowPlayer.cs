using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 camPos;
    
    void Update()
    {
        //camPos = new Vector3(0, 0, 0);
        transform.position = player.transform.position;
    }


}
