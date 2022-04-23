using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    //public List<GameObject> ammoPrefab;
    public float spd;
    void Start()
    {
        Time.timeScale = 1.0f;
    }
    void Update()
    {
       //int index = Random.Range(0, ammoPrefab.Count);
        transform.Translate(Vector3.forward * spd * Time.deltaTime);
    }
}
