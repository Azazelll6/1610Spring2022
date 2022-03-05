using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    static void Main()
    {
        int[] arr = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

        Console.WriteLine("Even numbers below 20:");

        foreach (int i in arr)
        {
            
            if (i == 2)
            {
                continue;
                Console.WriteLine(i + " ");
            }
        }
        Console.WriteLine("Odd numbers below 20:");
        
        foreach (int i in arr)
        {
            if (i != 2)
            {
                break;
                Console.WriteLine(i + " ");
            }
        }
    }

}
