using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //This makes an object follow an object defined as player (Vehicle)
        transform.position = player.transform.position + offset;
    }
}
