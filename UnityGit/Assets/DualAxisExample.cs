using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DualAxisExample : MonoBehaviour 
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        
        transform.position = new Vector3(xPos, 0, vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}
