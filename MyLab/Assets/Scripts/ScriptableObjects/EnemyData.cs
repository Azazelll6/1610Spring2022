using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "My Game/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public string description;
    public int health;
    public float speed;
    public float damage;
    public float bounceDistance;
}
