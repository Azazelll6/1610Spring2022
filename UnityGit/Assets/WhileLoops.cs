using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WhileLoops : MonoBehaviour
{
    void Start()
    {
        string guess = "";
        Console.WriteLine("What animal am I thinking of?");
        
        
        while (guess != "dog") {
            Console.WriteLine("Make a guess:");
            guess = Console.ReadLine();
        }
        Console.WriteLine("That's right!");
    }
    
}
