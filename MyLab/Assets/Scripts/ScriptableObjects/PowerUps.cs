using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PowerUps", menuName = "My Game/Power Ups")]
public abstract class PowerUps : ScriptableObject
{
    [SerializeField] private GameObject powIndicator;

    public string powFunction;
    public float moveSpeed;
    public float fireRate;
    public float heal;
    public float healthBoost;
    public float damage;    
    public float spinSpeed;
    public float bounceSpeed;
    public float topBounds;
    public float botBounds;
    
    public void PowerUpIndicator()
    {
        powIndicator.SetActive(true);
        Debug.Log(powFunction);
    }
}
