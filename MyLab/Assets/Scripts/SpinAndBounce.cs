using UnityEngine;

[CreateAssetMenu(menuName = "My Game/Variables/SpinAndBounce")]
public class SpinAndBounce : ScriptableObject
{ 
   public float spinSpeed;
   public float bounceAmplitude;
   public float bounceFrequency;
   public float bounceInitialHeight;
}
