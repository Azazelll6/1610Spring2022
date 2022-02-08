using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript : MonoBehaviour
{
    void update()
    {
        if (Input.getkeydown(keycode.R))
        {
            getcomponent<renderer>().material.color = color.red;
        }
        if (Input.getkeydown(keycode.G))
        {
            getcomponent<renderer>().material.color = color.red;
        }
        if (Input.getkeydown(keycode.B))
        {
            getcomponent<renderer>().material.color = color.red;
        }
    }
}