using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "My Game/Variables/Player Data")]
public class PlayerData : ScriptableObject
{
    public int health;
    public int damage;
    public float speed;
    public float ammoSpeed;
    public float ammoSpinSpeed;
    public float ammoLife;
    public float reloadTime;
    public float bounceDistance;
}
