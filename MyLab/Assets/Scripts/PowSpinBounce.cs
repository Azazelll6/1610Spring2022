using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowSpinBounce : MonoBehaviour
{
    public float spinSpeed;
    public float moveSpeed;

    private float topBounds;
    private float botBounds;

    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
