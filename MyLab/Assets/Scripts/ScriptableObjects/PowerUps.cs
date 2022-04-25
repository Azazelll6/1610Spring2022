using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PowerUps", menuName = "My Game/Variables/Power Ups")]
public class PowerUps : ScriptableObject
{
    public string powFunction;
    public float moveSpeed;
    public float fireRate;
    public float heal;
    public float healthBoost;
    public float damage;
}
