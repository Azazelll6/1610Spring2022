using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowTriggerEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent powUpTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            powUpTrigger.Invoke();
        }
    }
}
