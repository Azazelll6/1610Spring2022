using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    void Start()
    {
        Console.WriteLine("Watch me count to 100");

        for (int i = 0; i < 101; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Pretty sweet, right?");
    }

}
