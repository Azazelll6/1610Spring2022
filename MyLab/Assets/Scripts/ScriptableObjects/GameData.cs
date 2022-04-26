using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "My Game/Variables/Game Data")]
public class GameData : ScriptableObject
{
    public float powerUpDuration;
    public int wave;
    public int enemySpawnRate;
    public int powerUpSpawnRate;
}
