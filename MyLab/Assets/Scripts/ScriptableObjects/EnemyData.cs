using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "My Game/Variables/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public string description;
    public GameObject[] enemyPrefab;
    public int health;
    public float speed;
    public int damage;
    public float bounceDistance;
}
