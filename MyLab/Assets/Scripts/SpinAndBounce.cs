using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Game/ Actions/ SpinAndBounce")]
public class SpinAndBounce : ScriptableAction
{ 
   public GameObject[] objectsToSpinAndBounce;

   public override void PerformAction(GameObject obj)
   {
       //objectsToSpinAndBounce.transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
   }
}
